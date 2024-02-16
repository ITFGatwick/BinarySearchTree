using BinarySearchTree.BST;
using BinarySearchTree.Data;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main()
        {
            var tree = CreateBinarySearchTreeAndPopulateWithTestContactsUsingTheirNameAsTheKey();

            var contact = tree.FindByKey("Sigourney H. Holman");
            if (!IsContactFound(contact))
            {
                PrintContactNotFound();
                return;
            }

            PrintContact(contact);
        }

        static BinarySearchTree<string, Contact> CreateBinarySearchTreeAndPopulateWithTestContactsUsingTheirNameAsTheKey()
        {
            var tree = new BinarySearchTree<string, Contact>();
            foreach (var contact in TestData.Contacts)
            {
                tree.AddNode(contact.Name, contact);
            }

            return tree;
        }

        static bool IsContactFound(Contact contact)
        {
            return contact != null;
        }

        static void PrintContactNotFound()
        {
            Console.WriteLine("Could not find the contact");
        }

        static void PrintContact(Contact contact)
        {
            Console.WriteLine("Id: {0} Name: {1} Company: {2}", contact.Id, contact.Name, contact.Company);
        }
    }
}