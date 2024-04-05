using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TKshka;

namespace UnitTestProject2
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WithCorrectMarks()
        {

            Assert.AreEqual(Program.GetMark("10", "50", "30", "10"), "Всего баллов: 100. Оценка: 5");
            Assert.AreEqual(Program.GetMark("10", "20", "30", "10"), "Всего баллов: 69. Оценка: 4");
            Assert.AreEqual(Program.GetMark("0", "40", "0", "0"), "Всего баллов: 39. Оценка: 3");
            Assert.AreEqual(Program.GetMark("0", "10", "0", "0"), "Всего баллов: 10. Оценка: 2");
        }

        [TestMethod]
        public void WithIncorrectMarks()
        {
            Assert.AreEqual(Program.GetMark("25", "50", "30", "10"), "Неверное количество баллов для задания 1");
            Assert.AreEqual(Program.GetMark("10", "60", "30", "10"), "Неверное количество баллов для задания 2");
            Assert.AreEqual(Program.GetMark("10", "50", "100", "10"), "Неверное количество баллов для задания 3");
            Assert.AreEqual(Program.GetMark("10", "50", "30", "90"), "Неверное количество баллов для задания 4");
        }

        [TestMethod]
        public void WithWhitespaceMarks()
        {
            Assert.AreEqual(Program.GetMark("", "50", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("7", "", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "50", "", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "50", "30", ""), "Некорректные значения!");
        }

        [TestMethod]
        public void WithLetterMarks()
        {
            Assert.AreEqual(Program.GetMark("qwertyu", "50", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "dfssdfsdf", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "50", "aaaaaaa", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "50", "30", "dsfsdfds"), "Некорректные значения!");
        }
    }
}


