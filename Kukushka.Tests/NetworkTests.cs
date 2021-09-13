using Kukushka.Network.Data.Models;
using NUnit.Framework;
using System;

namespace Kukushka.Tests
{
    public class NetworkTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetActivityTimeTest()
        {
            /*
            var user = new User();
            user.SetActivity(System.DayOfWeek.Sunday, 1, true);
            user.SetActivity(System.DayOfWeek.Sunday, 2, true);
            user.SetActivity(System.DayOfWeek.Sunday, 3, true);
            user.SetActivity(System.DayOfWeek.Sunday, 4, true);
            user.SetActivity(System.DayOfWeek.Sunday, 5, true);
            user.SetActivity(System.DayOfWeek.Sunday, 6, true);

            var days = user.ActivityTime;

            TestContext.Write("**");
            for (int i = 0; i < 7; i++)
                TestContext.Write("		" + new string[] { "бя", "ом", "бр", "яп", "вр", "ор", "яа" }[i]);
            TestContext.WriteLine();


            for (int h = 0; h < 24; h++)
            {
                TestContext.Write((h + 1).ToString("D2"));
                for (int d = 0; d < 7; d++)
                    TestContext.Write("		" + (days[(DayOfWeek)d][h] ? "ON" : "OF"));
                TestContext.WriteLine();
            }
            */
            Assert.Pass();

        }
    }
}