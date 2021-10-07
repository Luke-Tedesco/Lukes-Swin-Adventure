
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LukesSwinAdventure;

namespace LukesSwinAdventure 
{
    [TestFixture]
    public class NUnit_IdentifiableObj 
    {
        private Identifiable_obj _ident;


        [SetUp]
        public void SetUp()
        {
            _ident = new Identifiable_obj(new string[] { "id1", "id2" } );
        }


        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_ident.AreYou("id1"), "Tests AreYou method responds true");
            Assert.IsFalse(_ident.AreYou("id3"), "Tests AreYou method responds false");
            /*

            Assert.IsNotNull(_testableObject);
            /* 
            *  - expected: The value/data you are expecting to get.
            *  - actual: The actual data you have generated in your test.
            *  - message (optional): A short message informing you (the programmer) what the 
            *  assert statement is testing. For your own benefit when you are debugging later.
            /*/
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(_ident.AreYou("ID1"), "Tests AreYou method responds true without case sensitivety");
        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("id1", _ident.FirstID);
        }

            /*
             *  - Assert.IsTrue/IsFalse to test a boolean.
             *  - Assert.AreEqual to compare two values.
             *  - Assert.AreSame to compare two objects.
             *  - StringAssert statements to test strings.
             *  - Many other assert statements for different scenarios...
             */

        [Test]
        public void TestAddID()
        {
            _ident.AddIdentifier("id3");
            Assert.IsTrue(_ident.AreYou("id3"), "Tests AddID will add the string and the same string can be verified by AreYou");
        }
    }
}
