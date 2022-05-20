using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Family.Framework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
