﻿using System;
using System.Collections;
namespace folawor
{
    public class SamplesStack
    {
        public static void Main()
        {

            Stack myStack = new Stack();
            string a;
            for (; ; )
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Enter value: ");
                Console.WriteLine("1 - Enter new element stack: ");
                Console.WriteLine("2 - Copy Stack: ");
                Console.WriteLine("3 - pop the stack: ");
                Console.WriteLine("4 - Pop an item from the stack: ");
                Console.WriteLine("5 - Checking if the stack is empty: ");
                Console.WriteLine("6 - Determining the middle element of the stack: ");

                int chnge = int.Parse(Console.ReadLine());
                switch (chnge)
                {
                    case 1:
                        Console.WriteLine("Enter new value in stack: ");
                        a = Console.ReadLine();
                        myStack.Push(a);
                        break;
                    case 2:
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            Copy_stack(myStack, myStack);
                        }
                        break;
                    case 3:
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            PrintValues(myStack);
                        }
                        break;
                    case 4:
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            Console.WriteLine("Enter postion value stack: ");
                            int posit = int.Parse(Console.ReadLine());
                            PrintValues_number(myStack, posit);
                        }                       
                        break;
                    case 5:
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            PrintValues(myStack);
                        }
                        break;
                    case 6:
                        if (myStack.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            PrintValues_Center(myStack, myStack);
                        }
                        break;
                    default:
                        Console.WriteLine("Error repeat please");
                        break;
                }
            }
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("Value stack:   {0}\n", obj);
            Console.WriteLine();
        }
        public static void PrintValues_Center(IEnumerable myCollection,Stack myStack)
        {
            if (myStack.Count == 0)
            {
                Console.WriteLine("\nСтек пуст!");
                Console.WriteLine();
                return;
            }
            else
            {
                int sizestack = 0, center;
                foreach (Object obj in myCollection)
                    sizestack += 1;
                center = sizestack / 2;
                sizestack = 0;
                foreach (Object obj in myCollection)
                {
                    sizestack += 1;
                    if(sizestack== center)
                    {
                        Console.Write("Value center stack:   {0}", obj);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void PrintValues_number(IEnumerable myCollection, int posit)
        {
            int sizestack = 0;
            foreach (Object obj in myCollection)
            {
                sizestack += 1;
                if (sizestack == posit)
                {
                    Console.Write("Value center stack:   {0}", obj);
                    return;
                }
            }
        }
        public static int Size_Stzck(IEnumerable myCollection)
        {
            int sizestack = 0;
            foreach (Object obj in myCollection)
            {
                sizestack += 1;
            }
            return sizestack;
        }
        public static void Copy_stack(IEnumerable myCollection,Stack myStack)
        {
            Stack Copy = new Stack();
            Stack myStack2 = new Stack();
            ///////празмер стека для массива
            int sizestack = Size_Stzck(myStack);
            int sizestack_2 = Size_Stzck(myStack2);
            //массив со значениями стека
            var newarray_1 = new string[sizestack];//значение первого стека
            sizestack -= 1;
            for (int i = sizestack; i > -1; i--)
                newarray_1[i] = (String)myStack.Pop();//занос данных
            sizestack += 1;
            var newarray_2 = new string[1];
            string a;
            for (; ; )
            {
                Console.WriteLine("Enter value: ");
                Console.WriteLine("1 - Enter new element stack: ");
                Console.WriteLine("2 - Pop element stack: ");
                Console.WriteLine("3 - Pop an item from the stack: ");
                Console.WriteLine("4 - Checking if the stack is empty: ");
                Console.WriteLine("5 - Determining the middle element of the stack: ");
                Console.WriteLine("6 - Sorting the stack: ");
                int chnge = int.Parse(Console.ReadLine());
                switch (chnge)
                {
                    case 1:
                        Console.WriteLine("Enter new value in stack: ");
                        a = Console.ReadLine();
                        myStack2.Push(a);
                        sizestack_2 += 1;
                        Array.Resize(ref newarray_2, sizestack_2);
                        sizestack_2 -= 1;
                        newarray_2[sizestack_2] = a;
                        sizestack_2 += 1;
                        break;
                    case 2:
                        if (myStack2.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                            Console.WriteLine();
                        }
                        else
                        {
                            PrintValues(myStack2);
                        }
                        break;
                    case 3:
                        if (myStack2.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                            Console.WriteLine();
                        }
                        else
                        {
                            int posit = int.Parse(Console.ReadLine());
                            PrintValues_number(myStack2, posit);
                        }
                        break;
                    case 4:
                        if (myStack2.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Стек не пуст!");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        if (myStack2.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                            Console.WriteLine();
                        }
                        else
                        {
                            PrintValues_Center(myStack2, myStack2);
                        }
                        break;
                    case 6:
                        if (myStack2.Count == 0)
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        else
                        {
                            sizestack_2 = Size_Stzck(myStack2);
                            var common_array = new string[sizestack + sizestack_2];//игтоговый стек
                            sizestack_2 -= 1;
                            for (int i = sizestack_2; i > -1; i--)
                                newarray_2[i] = (String)myStack2.Pop();
                            sizestack_2 += 1;
                            string temp;
                            newarray_1.CopyTo(common_array, 0);
                            newarray_2.CopyTo(common_array, newarray_1.Length);
                            for (int i = 0; i < common_array.Length - 1; i++)
                            {
                                for (int j = i + 1; j < common_array.Length; j++)
                                {
                                    if (common_array[i].Length > common_array[j].Length)
                                    {
                                        temp = common_array[i];
                                        common_array[i] = common_array[j];
                                        common_array[j] = temp;
                                    }
                                }
                            }
                            for (int i = 0; i < sizestack + sizestack_2; i++)
                            {
                                Copy.Push(common_array[i]);
                            }
                            PrintValues(Copy);
                        }
                        break;
                        case 7:
                            System.Environment.Exit;
                        break;
                    default:
                        Console.WriteLine("Error repeat please");
                        Console.WriteLine();
                        break;
                }
            }
        }
           //foreach (Object obj in myCollection)
           //     Console.Write("    {0}", obj);
           // Console.WriteLine();
    }
}


//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//namespace ConsoleApplication1
//{
//    class folawor
//    {
//        static void Main()
//        {
//            Stack MyStack = new Stack();
//            for (; ; )
//            {
//                Console.WriteLine("Enter value: ");
//                Console.WriteLine("Enter new element stack: ");
//                Console.WriteLine("Copy Stack: ");
//                Console.WriteLine("Enter value: ");
//                Console.WriteLine("Pop an item from the stack: ");
//                Console.WriteLine("Checking if the stack is empty: ");
//                int chnge = int.Parse(Console.ReadLine());
//                switch (chnge)
//                {
//                    case 1:
//                        break;
//                    case 2:
//                        break;
//                    case 3:
//                        break;
//                    case 4:
//                        break;
//                    case 5:
//                        if (MyStack.Count == 0)
//                        {
//                            Console.WriteLine("\nСтек пуст!");
//                            Console.WriteLine();
//                        }
//                        break;
//                }
//            }
//        }
//    }
//}









///////////////////////////////////////
/////
//MyStack.Push('A');
//MyStack.Push('N');
//MyStack.Push('X');
//Console.WriteLine("Исходный стек: ");
//foreach (char s in MyStack)
//    Console.Write(s);
//Console.WriteLine("\n");
//while (MyStack.Count > 0)
//{
//    Console.WriteLine("Pop -> {0}", MyStack.Pop());
//}
//if (MyStack.Count == 0)
//    Console.WriteLine("\nСтек пуст!");
//Console.ReadLine();