using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testeUnitario;

namespace testeUnitarioTest
{
    [TestClass]
    public class FileProcessTest
    {
     
            [TestMethod] // Teste de verificação de existência de arquivo 
            public void FileNameDoesExist()
            {
                FileProcess fp = new FileProcess(); 

                bool fromcall = fp.FileExists(@"C:\Users\maria\OneDrive\Documentos\atividades\api.txt"); 

                Assert.IsTrue(fromcall); 
            }


    }
}
