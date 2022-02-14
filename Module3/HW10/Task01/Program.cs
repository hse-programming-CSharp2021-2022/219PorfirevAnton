using System;
using System.Collections.Generic;


namespace Task01
{
    class BTnode<T>
        where T: struct, IComparable
    {
        public T Value { get; set; }
        int count;
        BTnode<T> left;
        BTnode<T> right;
        public bool IsLeave
        {
            get
            {
                return left == null && right == null;
            }
        }

        public BTnode(T val)
        {
            this.Value = val;
            count = 1;
            left = null;
            right = null;
        }

        public void InsertValue(T value)
        {
            if (Value.CompareTo(value) == 0)
            {
                count++;
            }
            else if(Value.CompareTo(value) < 0)
            {
                if(right != null)
                {
                    right.InsertValue(value);
                }
                else
                {
                    right = new BTnode<T>(value);
                }
            }
            else
            {
                if (left != null)
                {
                    left.InsertValue(value);
                }
                else
                {
                    left = new BTnode<T>(value);
                }
            }
        }

        /// <summary>
        /// Вывод в ширину.
        /// </summary>
        public void Print()
        {
            Queue<BTnode<T>> queue = new Queue<BTnode<T>>();
            queue.Enqueue(this);
            while(queue.Count != 0)
            {
                BTnode<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if(step.left != null)
                {
                    queue.Enqueue(step.left);
                }
                if(step.right != null)
                {
                    queue.Enqueue(step.right);
                }
            }
        }

        /// <summary>
        /// Вывод в ширину.
        /// </summary>
        public void PrintBack()
        {
            Queue<BTnode<T>> queue = new Queue<BTnode<T>>();
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                BTnode<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if (step.right != null)
                {
                    queue.Enqueue(step.right);
                }
                if (step.left != null)
                {
                    queue.Enqueue(step.left);
                }
            }
        }
        public void Delete(T value)
        {
            if(Value.CompareTo(value) == 0)
            {
                if(left == null)
                {
                    right = right.right;
                }
                else
                {
                    left = left.left;
                }
            }
            else if (Value.CompareTo(value) > 0)
            {
                if(left == null)
                {
                    throw new ArgumentException("Такого элемента нет");
                }
                if (left.IsLeave)
                {
                    left = null;
                }
                else
                {
                    left.Delete(value);
                }
            }
            else
            {
                if (right == null)
                {
                    throw new ArgumentException("Такого элемента нет");
                }
                if (right.IsLeave)
                {
                    right = null;
                }
                else
                {
                    right.Delete(value);
                }
            }
        }

        public bool Find(T value)
        {
            if(Value.CompareTo(value) == 0)
            {
                return true;
            }
            else if(Value.CompareTo(value) < 0)
            {
                if(right != null)
                {
                    return right.Find(value);
                }
            }
            else
            {
                if (left != null)
                {
                    return left.Find(value);
                }
            }
            return false;
        }
    }

    class BinaryTree<T>
        where T: struct, IComparable
    {
        BTnode<T> root;

        public bool IsEmpty
        {
            get
            {
                return root == null;
            }
        }
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(T val)
        {
            if (IsEmpty)
            {
                root = new BTnode<T>(val);
            }
            else
            {
                root.InsertValue(val);
            }
        }

        public void Print()
        {
            if(!IsEmpty)
                root.Print();
        }

        public void Delete(T val)
        {
            if (IsEmpty)
            {
                throw new ArgumentException("Такого элемента нет");
            }
            else
            {
                root.Delete(val);
            }
        }

        public bool Find(T value)
        {
            return (!IsEmpty) && root.Find(value);
        }

        public void Preorder(BTnode<T> node)
        {
            if (Find(node.Value))
            {
                node.Print();
            }
        }

        public void Clear()
        {
            root = null;
        }

        public void Inorder()
        {
            if (!IsEmpty)
            {
                root.PrintBack();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            for(int i = 0; i < 11; i += 2)
            {
                tree.Insert(i);
            }
            for (int i = 1; i < 12; i += 2)
            {
                tree.Insert(i);
            }
            tree.Print();
        }
    }
}
