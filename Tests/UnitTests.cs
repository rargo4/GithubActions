﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class ProgramTests
    {
        // Add operation tests
        [Test]
        public void Add_Valid_Argo()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Argo()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Argo()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Subtract operation tests
        [Test]
        public void Subtract_Valid_Argo()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-1, Program.Subtract("2", "3"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [Test]
        public void Subtract_Invalid_Argo()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_Argo()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Multiply operation tests
        [Test]
        public void Multiply_Valid_Argo()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(0, Program.Multiply("0", "3"));
            Assert.AreEqual(-15, Program.Multiply("3", "-5"));
        }

        [Test]
        public void Multiply_Invalid_Argo()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null_Argo()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Divide operation tests
        [Test]
        public void Divide_Valid_Argo()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
            Assert.AreEqual(-4, Program.Divide("8", "-2"));
        }

        [Test]
        public void Divide_Invalid_Argo()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_Argo()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Divide_ByZero_Argo()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide("1", "0"));
        }

        // Power operation tests
        [Test]
        public void Power_Valid_Argo()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(0.25, Program.Power("2", "-2"));
        }

        [Test]
        public void Power_Invalid_Argo()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Argo()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
