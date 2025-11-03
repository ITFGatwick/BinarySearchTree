# BinarySearchTree

## What is a Binary Search Tree?

A Binary Search Tree (BST) is a hierarchical data structure that stores items in a sorted manner. It consists of nodes, where each node contains:
- A key-value pair
- A reference to a left child node
- A reference to a right child node

### BST Properties

The key property of a BST is that for any given node:
- All nodes in the **left subtree** have keys **less than** the current node's key
- All nodes in the **right subtree** have keys **greater than** the current node's key
- Both left and right subtrees are also binary search trees

This property enables efficient searching, insertion, and deletion operations with average time complexity of O(log n).

### Example BST Structure
```
        50
       /  \
      30   70
     / \   / \
    20 40 60 80
```

In this tree:
- 30 < 50, so it's in the left subtree
- 70 > 50, so it's in the right subtree
- 20 < 30 and 40 > 30, maintaining the BST property

## Interview Task

You are tasked with implementing the core functionality of the `BinarySearchTree` class using **Test-Driven Development (TDD)**. The class currently has two methods that throw `NotImplementedException`:

1. `AddNode` - Adds a new key-value pair to the BST
2. `FindByKey` - Searches for a value by its key

### Requirements

#### Part 1: Implement AddNode Method
Using TDD, implement the `AddNode` method that:
- Takes a key and value as parameters
- Returns the newly created `BinarySearchTreeNode`
- Maintains the BST property (left < parent < right)
- Handles duplicate keys appropriately (your choice: update existing or ignore)

#### Part 2: Implement FindByKey Method
Using TDD, implement the `FindByKey` method that:
- Takes a key as parameter
- Returns the associated value if found
- Returns `default(TValue)` if the key doesn't exist
- Efficiently traverses the tree using BST properties

### TDD Process
1. **Red**: Write a failing test in `UnitTest1.cs`
2. **Green**: Write the minimum code to make the test pass
3. **Refactor**: Improve the code while keeping tests green
4. Repeat for each new requirement

### Getting Started

1. Start by running the existing test to see it fail
2. Begin with simple test cases (single node, then two nodes, etc.)
3. Gradually add more complex scenarios
4. The `Program.cs` shows how your BST will be used with `Contact` data

### Running Tests

```bash
# Run tests from the solution directory
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal
```

### Example Test Structure

Build upon the existing test structure in `UnitTest1.cs`. Consider testing scenarios like:
- Adding to empty tree
- Adding multiple nodes
- Searching existing keys
- Searching non-existent keys
- Tree structure maintenance

### Success Criteria

Your implementation should:
- ✅ Pass all your tests
- ✅ Allow the `Program.cs` to run successfully
- ✅ Maintain proper BST structure
- ✅ Handle edge cases gracefully
- ✅ Follow TDD principles throughout development

Good luck! Remember to think about the BST properties and how they guide both insertion and search operations.
