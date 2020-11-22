using Meta;
using NUnit.Framework;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [TestFixture]
    public class MetaQuizzesTests
    {
        [Test]
        [Ignore("Should only save once!")]
        public void Save()
        {
            var metaQuiz = new MetaQuizzes();
            var allMeta = metaQuiz.GetAll();

            foreach (var meta in allMeta)
            {

            }
        }
    }
}
