using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.WIContract.Tests
{
    public class WorkItemTypeTests
    {
        [Test]
        public void GetWorkItemTypesTest()
        {
            var result = WorkItemType.GetWorkItemTypes();
            Assert.That(result.Count, Is.GreaterThan(0),$"Result count wrong");
        }

        [Test]
        public void GetWorkItemTypesExcludingBugTest()
        {
            string[] filter = new string[] { "Bug" };
            var result = WorkItemType.GetWorkItemTypes(filter);
            Assert.That(result.Count, Is.GreaterThan(0), $"Result count wrong");
            Assert.That(result, Does.Not.Contains("Bug"), $"Result contains Bug");
        }

        [Test]
        public void GetWorkItemTypesExcludingInvalidTermTest()
        {
            string[] filter = new string[] { "Null" };
            var result = WorkItemType.GetWorkItemTypes();
            var result2 = WorkItemType.GetWorkItemTypes(filter);
            Assert.That(result.Count, Is.EqualTo(result2.Count), $"Result count wrong");
        }
    }
}
