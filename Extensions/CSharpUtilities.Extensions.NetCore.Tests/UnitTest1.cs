using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpUtilities.Extensions.NetCore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncriptionTestShouldPass()
        {
            const string key = "123456789012345678901234";

            string value = "74be16979710d4c4e7c6647856088456";
            var encrypted = value.Encrypt(key);
            var decrypted = encrypted.Decrypt(key);

            Assert.AreEqual(value, decrypted);
        }
    }
}
