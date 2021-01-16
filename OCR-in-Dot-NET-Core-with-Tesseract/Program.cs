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
                string imgPath = @"D:/Era Infotech Remote Job/OCR-in-Dot-NET-Core-with-Tesseract/OCR-in-Dot-NET-Core-with-Tesseract/TestImg.bmp";
                string tessdataPath = @"C:/Program Files (x86)/Tesseract-OCR/tessdata";
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
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
