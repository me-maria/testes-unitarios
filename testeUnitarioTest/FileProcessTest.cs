using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testeUnitario;

namespace testeUnitarioTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod] //verifica existencia de arquivo
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\EDT.txt");

            Assert.IsTrue(fromCall);
        }

        [TestMethod] //verifica não existencia de arquivos 
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\EDT.txt");

            Assert.IsFalse(fromCall);
        }
  
    }
}
