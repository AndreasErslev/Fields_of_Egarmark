using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Game.UI;

namespace Game.Test
{
    [TestFixture]
    public class TestDisplay
    {
        public Display _uut;
        public StringWriter _text;
        public StringReader _read;

        [SetUp]
        public void SetUp()
        {
            _uut = new Display();

        }

        [Test]
        public void ChooseAttack_Test()
        {

            _read = new StringReader("1");
            Console.SetIn(_read);

            _text = new StringWriter();
            Console.SetOut(_text);

            _uut.ChooseAttack();

            Assert.That(_text.ToString(), Is.EqualTo("Chose your attack:\r\n1: Slash\r\n2: Fireball\r\n3: Arrow\r\n"));
        }
    }
}
