using NUnit.Framework;
using ServiceProject;
namespace Tests
{
    public class Tests1
    {
        CountWords cw = new CountWords();
       
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int output = cw.NumOfWorlds();
            Assert.AreEqual(6,output);
        }
        [Test]
        public void Test2()
        {
             StringTitleCase tc = new StringTitleCase(); 
             tc.strTitleCase();
             tc.strCamelCaseFunc();
             
           
        }
    }
}