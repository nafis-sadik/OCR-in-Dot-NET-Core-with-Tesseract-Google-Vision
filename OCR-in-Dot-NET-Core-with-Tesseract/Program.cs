using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace OCR_in_Dot_NET_Core_with_Tesseract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string imgPath = @"D:\OCR\OCR-in-Dot-NET-Core-with-Tesseract\OCR-in-Dot-NET-Core-with-Tesseract\TestData\num.bmp";
                //string imgPath = @"D:\OCR\OCR-in-Dot-NET-Core-with-Tesseract\OCR-in-Dot-NET-Core-with-Tesseract\TestData\TestImg.bmp";
                //string imgPath = @"D:\OCR\OCR-in-Dot-NET-Core-with-Tesseract\OCR-in-Dot-NET-Core-with-Tesseract\TestData\imgpsh_fullsize_anim.bmp";
                //string imgPath = @"D:\OCR\OCR-in-Dot-NET-Core-with-Tesseract\OCR-in-Dot-NET-Core-with-Tesseract\TestData\Handwriting-sample-Katie.png";
                string tessdataPath = @"C:/Program Files/Tesseract-OCR/tessdata";
                string lang = "eng";
                Pix pix = Pix.LoadFromFile(imgPath);
                TesseractEngine tesseractEngine = new TesseractEngine(tessdataPath, lang, EngineMode.Default);
                Page page = tesseractEngine.Process(pix, PageSegMode.Auto);
                string result = page.GetText();
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
