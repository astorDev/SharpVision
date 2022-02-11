using System.IO;
using NUnit.Framework;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace SharpVision.Tests;

public class ExtractorShould
{
    public ExtractorShould()
    {
        Directory.CreateDirectory("results");
    }
    
    [Test]
    public void ExtractObjectFromYandex()
    {
        var image = Image.Load<Rgba32>("yandex.png");
        image.Mutate(i => i.Grayscale());
        image.Save("results/yandex_1.png");
        image.Mutate(i => i.Resize(image.Width / 2, image.Height / 2));
        image.Save("results/yandex_3.png");
    }
}