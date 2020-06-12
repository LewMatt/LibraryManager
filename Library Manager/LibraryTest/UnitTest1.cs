using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;

namespace LibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_UpdatePass()
        {

            Random rnd = new Random();
            rnd.Next(0, 10000);
            string newPass = rnd.ToString();
            string expected = newPass;
            string id = 2.ToString();

            func fnc = new func();

            string trash_res = fnc.UpdatePass(newPass, id);

            Assert.AreEqual(expected, fnc.CheckPass(id));
        }


        [TestMethod]
        public void TestMethod_CheckPass()
        {  
            string expected = "admin";
            string id = 0.ToString();
            func fnc = new func();

            Assert.AreEqual(expected, fnc.CheckPass(id));
        }
    }
}
