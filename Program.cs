using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace TreesLibraryProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 30;

            BinarySearchTree<int> binaryTree = new()
            { Root = new() { Data = 50 } };

            binaryTree.Root.Children =
                [
                new() { Data = 32, Parent = binaryTree.Root },
                new() { Data = 36, Parent = binaryTree.Root }
                ];

            binaryTree.Root.Left.Children =
                [
                new() { Data = 17, Parent = binaryTree.Root.Left },
                new() { Data = 33, Parent = binaryTree.Root.Left }
                ];

            binaryTree.Root.Left.Left.Children =
                [
                new() { Data = 3, Parent = binaryTree.Root.Left },
                new() { Data = 18, Parent = binaryTree.Root.Left }
                ];

            binaryTree.Root.Right.Children =
                [
                new() { Data = 51, Parent = binaryTree.Root.Left },
                new() { Data = 55, Parent = binaryTree.Root.Left }
                ];

            Console.WriteLine(binaryTree.Contains(number));


            

            //Tree<int> tree = new()
            //{ Root = new() { Data = 100 } };

            //tree.Root.Children =
            //    [
            //    new() { Data = 50 , Parent = tree.Root },
            //    new() { Data = 1 , Parent = tree.Root },
            //    new() { Data = 150 , Parent = tree.Root }
            //    ];

            //tree.Root.Children[2].Children =
            //    [
            //    new() { Data = 30, Parent = tree.Root.Children[2] },
            //    new() { Data = 5, Parent = tree.Root.Children[2] },
            //    new() { Data = 11, Parent = tree.Root.Children[2] }
            //    ];

            //tree.Root.Children[2].Children[0].Children =
            //    [
            //    new() { Data = 96, Parent = tree.Root.Children[2].Children[3] },
            //    new() { Data = 9, Parent = tree.Root.Children[2].Children[3] }
            //    ];

            //tree.Root.Children[1].Children =
            //    [
            //    new() { Data = 70, Parent = tree.Root.Children[1] },
            //    new() { Data = 61, Parent = tree.Root.Children[1] }
            //    ];

            //tree.Root.Children[0].Children =
            //    [
            //    new() { Data = 12, Parent = tree.Root.Children[0] }
            //    ];

            //tree.Root.Children[0].Children[0].Children =
            //    [
            //    new() { Data = 45, Parent = tree.Root.Children[0].Children[0] },
            //    new() { Data = 21, Parent = tree.Root.Children[0].Children[0] }
            //    ];

            //tree.Root.Children[0].Children[0].Children[1].Children =
            //    [
            //    new() { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1] }
            //    ];

            //BinaryTree<string> binaryTree2 = GetTree();
            //BinaryTreeNode<string>? node = binaryTree2.Root;
            //while (node != null)
            //{
            //    if (node.Left != null && node.Right != null)
            //    {
            //        Console.WriteLine(node.Data);
            //        node = Console.ReadKey(true).Key switch
            //        {
            //            ConsoleKey.Y => node.Left,
            //            ConsoleKey.N => node.Right,
            //            _ => node
            //        };
            //    }
            //    else
            //    {
            //        Console.WriteLine(node.Data);
            //        node = null;
            //    }
            //}

            //BinaryTree<string> GetTree()
            //{
            //    BinaryTree<string> binaryTree2 = new();

            //    binaryTree2.Root = new BinaryTreeNode<string>()
            //    {
            //        Data = "Do you have an experience in app development ? ",
            //        Children =
            //        [
            //            new BinaryTreeNode<string>()
            //            {
            //                Data = "Have you worked as a developer for 5 + years ? ",
            //                Children =
            //                [
            //                    new() { Data = "Apply as a senior developer" },
            //                    new() { Data = "Apply as a middle developer" }
            //                ]
            //            },

            //            new BinaryTreeNode<string>()
            //            {
            //                Data = "Have you completed a university?",
            //                Children =
            //                [
            //                    new() { Data = "Apply as a junior developer" },
            //                    new BinaryTreeNode<string>()
            //                    {
            //                        Data = "Have you completed MSSA?",
            //                        Children =
            //                        [
            //                            new() { Data = "Apply for long-time internship" },
            //                            new BinaryTreeNode<string>()
            //                            {
            //                                Data = "Have you applied to MSSA ? ",
            //                                Children =
            //                                [
            //                                    new() { Data = "Apply to MSSA" },
            //                                    new() { Data = "Complete the program" }
            //                                ]
            //                            }
            //                        ]
            //                    }
            //                ]
            //            }
            //        ]
            //    };
            //    binaryTree2.Count = 9;

            //    return binaryTree2;
            //}
        }
    }
}
