using System;
using Google.Cloud.Storage.V1;
using Google.Cloud.Vision.V1;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;

namespace OCR_using_Google_Cloud_Vision_API
{
    class Program
    { 
        static void LoadImg (string imgPath)
        {
            Image image = Image.FromFile(imgPath);
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<EntityAnnotation> response = client.DetectText(image);
            for (int i = 1; i < response.Count; i++)
            {
                if (response[i].Description != null)
                    Console.WriteLine(response[i].Description);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoadImg(@"D:/OCR/OCR-in-Dot-NET-Core-with-Tesseract/OCR-in-Dot-NET-Core-with-Tesseract/TestData/TestImg.bmp");
        }
    }
}
