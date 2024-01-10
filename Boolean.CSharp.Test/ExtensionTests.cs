using Boolean.CSharp.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
 

        [Test]
        public void TestQuestion1()
        {

            float a = 1.0f;
            float b = 2.0f;

            Extension extension = new Extension();

            float result = extension.add(a, b);

            Assert.AreEqual(3.0f, result);


        }
        [Test]
        public void TestQuestion2()
        {
            double a = 1.0;
            double b = 2.0;

            Extension extension = new Extension();

            double result = extension.add(a, b);

            Assert.AreEqual(3.0, result);
        }

        [Test]
        public void TestQuestion3()
        {
            float a = 2.0f;
            float b = 1.0f;

            Extension extension = new Extension();

            float result = extension.subtract(a, b);

            Assert.AreEqual(1.0f, result);
        }

        [Test]
        public void TestQuestion4()
        {
            string source = "the quick brown fox jumps over the lazy dog";
            char z = 'z';

            Extension extension = new Extension();

            string result = extension.subtract(source, z);

            Assert.IsTrue(result == "the quick brown fox jumps over the lay dog");
        }

        [Test]
        public void TestQuestion5()
        {
            int a = 2;
            int b = 5;

            Extension extension = new Extension();

            int result = extension.multiply(a, b);

            Assert.AreEqual(10, result);
        }
        [Test]
        public void TestQuestion6()
        {
            string source = "Hello";
            int dupes = 3;

            Extension extension = new Extension();

            string result = extension.multiply(source, 3);

            Assert.IsTrue("Hello,Hello,Hello" == result);
        }
        [Test]
        public void TestQuestion7()
        {
            //multiply([], 3) -> [6, 21, 9]
            string[] source = { "2", "7", "3" };
            int multiplier = 3;

            Extension extension = new Extension();
            var result = extension.multiply(source, multiplier);

            int[] answer = { 6, 21, 9 };

            Assert.IsTrue(result.SequenceEqual(answer));


        }

    }
}
