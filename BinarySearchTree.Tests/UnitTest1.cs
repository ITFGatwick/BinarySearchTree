using BinarySearchTree.BST;

namespace BinarySearchTree.Tests
{
    public class Tests
    {
        BinarySearchTree<string, string> tree;

        [SetUp]
        public void Setup()
        {
            tree = new BinarySearchTree<string, string>();
        }

        [Test]
        public void AddNode_WhenDoingSomething_ItShouldDoSomething()
        {   
            // Arrange

            // Act
            var result = tree.AddNode("testKey", "testValue");

            // Assert
            Assert.IsNotNull(result);
        }
    }
}