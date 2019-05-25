using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Migration.Common;
using Common.Config;
using Migration.Common.Log;
using NSubstitute;

namespace JiraExport.Tests
{
    public class JiraMapperTests
    {
        [Test]
        public void JiraMapperConstructTest()
        {

            var sut = new JiraMapper(null, new ConfigJson());

        }

        [Test]
        public void JiraMapperAddRemoveSingleLinkTest()
        {            
            var dict = new Dictionary<string, object>
            {
                { "Test", null }
            };
            var rev = Substitute.For<IJiraRevision>();
            rev.Fields.Returns(dict);
            rev.Index.Returns(0);
            
            var sut = new JiraMapper(null, new ConfigJson());
            sut.AddRemoveSingleLink(rev, null, "Test", null);
        }
    }
}
