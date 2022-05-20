using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using Xunit;

namespace Family.VideoTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var inputFile = new MediaFile { Filename = @"C:\Users\EDZ\Desktop\images\a9ae482ce4ad720d4abac27ebccf01cb.mp4" };
            var outputFile = new MediaFile { Filename = @"C:\Users\EDZ\Desktop\images\To_Save_Image.jpg" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                // Saves the frame located on the 15th second of the video.
                var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(0) };
                engine.GetThumbnail(inputFile, outputFile, options);
            }
        }
    }
}
