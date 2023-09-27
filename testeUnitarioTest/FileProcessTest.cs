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

        [TestMethod] //verifica se uma exceção ArgumentNullException é lançada quando o nome do arquivo é nulo ou vazio.
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }

        [TestMethod]//(com try catch)verifica se o nome do arquivo é nulo ou vazio.
        public void FileNameNullOrEmptyThrowsArgumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess(); 

            try
            {
                fp.FileExists(""); 
            }
            catch
            {
                return;
            }
            Assert.Fail("Falha");
        }

    }
}
