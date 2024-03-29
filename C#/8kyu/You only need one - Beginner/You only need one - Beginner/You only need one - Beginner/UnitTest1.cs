using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace You_only_need_one___Beginner
{
    public class Kata
    {
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }


        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, Kata.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            Assert.AreEqual(true, Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.AreEqual(false, Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
    }
}