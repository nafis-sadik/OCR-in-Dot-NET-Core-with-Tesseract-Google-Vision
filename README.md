# OCR in .NET Core with Tesseract and Google Vision

![Framework](https://img.shields.io/badge/framework-.net%20core%20v3.1-green)

# Dependencies for Tesseract

| -------------------------------------------- | -------------------------------------------------------------------- |
| Tools & Frameworks                           | Links                                                                |
| -------------------------------------------- | -------------------------------------------------------------------- |
| Tesseract Engine exe                         | [Download](https://digi.bib.uni-mannheim.de/tesseract/)              |
| Tesseract Nuget Package                      | [Nuget](https://www.nuget.org/packages/Tesseract/4.1.1/)             |
| System.Drawing.Common                        | [Nuget](https://www.nuget.org/packages/System.Drawing.Common/5.0.0/) |
| Tesseract Installation & Configuration Guide | [Youtube](https://www.youtube.com/watch?v=QJkKDsjj1oA)               |
| -------------------------------------------- | -------------------------------------------------------------------- |

# How to use it? (Tesseract)

Once Tesseract Engine has been installed and configured
**Step # 1 :**

    Clone the repository

**Step # 2 :**

    Open the solution file (Recommended with Visual Studio 2019)

**Step # 3 :**

    Run the project

# Inside Program.cs of OCR-in-Dot-NET-Core-with-Tesseract

- Put the path of your image with text at "**imgPath**" variable
- Put the path of your tessdata directory at "**tessdataPath**" variable
- Put your desired language selection in "**lang**" variable based on file names available inside **tessdata** directory
