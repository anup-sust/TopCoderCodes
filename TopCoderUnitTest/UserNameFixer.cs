using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class UserNameFixer
    {
        private UserName UserName;
        public UserNameFixer()
        {
            this.UserName = new UserName();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.UserName.newMember(new []{"MasterOfDisaster", "TygerTyger1", "DingBat", "Orpheus",
                "TygerTyger", "WolfMan", "MrKnowItAll"}, "TygerTyger") == "TygerTyger2");
        }
    }
}
