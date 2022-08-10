using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlmoxarifadoMVC.Models;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool esperado = true;
            bool resultado = false;
            Produto produto = new Produto();
            produto.ProID = 1;
            produto.ProEstoque = 10;

            Produtoestoque validarEstoque = new Produtoestoque();
            if (validarEstoque.verificarestoque(produto, 5) == true)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            Assert.AreEqual(esperado, resultado);
        }
    }
}
