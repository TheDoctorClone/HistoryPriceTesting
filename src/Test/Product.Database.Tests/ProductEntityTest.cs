using Docker.DotNet;
using Docker.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using Xunit;

namespace Product.Database.Tests
{
    public class ProductEntityTest
    {
        public ProductEntityTest()
        {
            DockerClient dockerClient = new DockerClientConfiguration()
            .CreateClient();
            string mongo = nameof(mongo);
            string latest = nameof(latest);

            dockerClient.Images.CreateImageAsync(
                new ImagesCreateParameters() { FromImage = mongo, Tag = latest },
                null,
                new Progress<JSONMessage>((message) => Console.WriteLine(JsonSerializer.Serialize(message))),
                CancellationToken.None
            ).Wait();

            var taskContainer = dockerClient.Containers.CreateContainerAsync(
                  new CreateContainerParameters
                  {
                      Image = $"{mongo}:{latest}",
                      Name = mongo,
                      ExposedPorts = new Dictionary<string, EmptyStruct>() { ["27001"] = new EmptyStruct() }
                  },
                  CancellationToken.None
              );
            taskContainer.Wait();
            dockerClient.Containers.StartContainerAsync(taskContainer.Result.ID, new ContainerStartParameters()).Wait();
        }

        //posso testare tutte le entità nello stessa classe?
        //sono comunque in tabelle separate

        [Fact]
        public void ProductEntityTest_Created_Ok()
        {

        }

        [Fact]
        public void PriceEntityTest_Created_Ok()
        {

        }

        [Fact]
        public void PriceEntityTest_CheckDateBeforeInsert()
        {

        }

        [Fact]
        public void PriceEntityTest_GetSpecificDate()
        {

        }

        [Fact]
        public void DiscountEntityTest_Created_Ok()
        {

        }

        [Fact]
        public void DiscountEntityTest_CheckDateBeforeInsert()
        {

        }

        [Fact]
        public void DiscountEntityTest_GetSpecificDate()
        {

        }
    }
}