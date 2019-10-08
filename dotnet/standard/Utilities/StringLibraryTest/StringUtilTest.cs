using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibrary;

namespace StringLibraryTest
{
    [TestClass]
    public class StringUtilTest
    {
        [TestMethod]
        public void TestStartsWithUppercase()
        {
            // Arrange
            string[] wordList = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };

            foreach (string word in wordList)
            {
                // Act
                bool result = word.StartsWithUpper();

                // Assert
                Assert.IsTrue(result, $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Arrange
            string[] wordList = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };

            foreach (string word in wordList)
            {
                // Act
                bool result = word.StartsWithUpper();

                // Assert
                Assert.IsFalse(result, $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestDirectCallWithNullOrEmpty()
        {
            // Arrange
            string[] wordList = { string.Empty, null };

            foreach (string word in wordList)
            {
                // Act
                bool result = StringUtil.StartsWithUpper(word);

                // Assert
                Assert.IsFalse(result, $"Expected for '{(word ?? "<null>")}': false; Actual: {result}");
            }
        }
    }
}
