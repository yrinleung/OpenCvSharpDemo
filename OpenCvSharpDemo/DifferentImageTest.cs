using OpenCvSharp;
using OpenCvSharp.ImgHash;
using System;
using Xunit;
using Xunit.Abstractions;

namespace OpenCvSharpDemo
{
    public class DifferentImageTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public DifferentImageTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        /// <summary>
        /// RadialVarianceHash 计算相似度，hash值越接近1说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void RadialVarianceHashTest(string imageFile1, string imageFile2)
        {
            using (var model = RadialVarianceHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(40, 40);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }

        /// <summary>
        /// PHash 计算相似度，hash值越接近0说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void PHashTest(string imageFile1, string imageFile2)
        {
            using (var model = PHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(256, 256);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }

        /// <summary>
        /// MarrHildrethHash 计算相似度，hash值越接近0说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void MarrHildrethHashTest(string imageFile1, string imageFile2)
        {
            using (var model = MarrHildrethHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(256, 256);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }

        /// <summary>
        /// ColorMomentHash 计算相似度，hash值越接近0说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void ColorMomentHashTest(string imageFile1, string imageFile2)
        {
            using (var model = ColorMomentHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(256, 256);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }

        /// <summary>
        /// BlockMeanHash 计算相似度，hash值越接近0说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void BlockMeanHashTest(string imageFile1, string imageFile2)
        {
            using (var model = BlockMeanHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(256, 256);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }

        /// <summary>
        /// AverageHash 计算相似度，hash值越接近0说明越相似
        /// </summary>
        /// <param name="imageFile1"></param>
        /// <param name="imageFile2"></param>
        [Theory]
        [InlineData("image1-1.jpg", "image1-1.jpg")]
        [InlineData("image1-1.jpg", "image1-2.jpg")]
        [InlineData("image2-1.jpg", "image2-2.jpg")]
        [InlineData("image2-1.jpg", "image1-1.jpg")]
        [InlineData("image2-2.jpg", "image1-2.jpg")]
        public void AverageHashTest(string imageFile1, string imageFile2)
        {
            using (var model = AverageHash.Create())
            using (var img1 = new Mat(imageFile1, ImreadModes.Grayscale))
            using (var img2 = new Mat(imageFile2, ImreadModes.Grayscale))
            {
                var size = new Size(256, 256);
                using (var scaledImg1 = img1.Resize(size))
                using (var scaledImg2 = img2.Resize(size))
                {
                    double hash = model.Compare(scaledImg1, scaledImg2);
                    _testOutputHelper.WriteLine($"imageFile1:{imageFile1};");
                    _testOutputHelper.WriteLine($"imageFile2:{imageFile2};");
                    _testOutputHelper.WriteLine($"hash:{hash};");
                }
            }
        }
    }
}
