using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace class1
{
    class Stack_cl{
		public Stack st;
		public bool bl;
		//////////////////////////////////////////////////////////////////////////
		public static Stack_cl operator +(Stack_cl st1, string val)
        {
			Stack_cl st_ = new Stack_cl();
			st_.st.Push(val);
			return st_;
		}
		//////////////////////////////////////////////////////////////////////////
		public static Stack_cl operator -(Stack_cl st1, string val)
		{
			Stack_cl st_ = new Stack_cl();
			st_.st.Pop();
			IEnumerable myCollection = st_.st;
			Object obj = myCollection;
			Console.WriteLine("Value Stack: " + obj);
			return st_;
		}
		//////////////////////////////////////////////////////////////////////////
		public static bool operator &(Stack_cl st1,int x = 0)
        {
			Stack_cl newst = new Stack_cl();
			if(newst.st.Count==0 || newst.st.Count <= 0)
            {
				newst.bl = false;
			}
            else{
				newst.bl = true;
			}
			return newst.bl;

		}
		//////////////////////////////////////////////////////////////////////////
		//public static bool operator !(Stack_cl st1, int x = 0)
		//{
		//	Stack_cl newst = new Stack_cl();
		//	if (newst.st.Count == 0 || newst.st.Count <= 0)
		//	{
		//		newst.bl = false;
		//	}
		//	else
		//	{
		//		newst.bl = true;
		//	}
		//	return newst.bl;
		//}
		//////////////////////////////////////////////////////////////////////////
		public static int Size_Stzck(IEnumerable myCollection)
		{
			int sizestack = 0;
			foreach (Object obj in myCollection)
			{
				sizestack += 1;
			}
			return sizestack;
		}
		//////////////////////////////////////////////////////////////////////////
		public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("Value stack:   {0}\n", obj);
            Console.WriteLine();
        }
		//////////////////////////////////////////////////////////////////////////
		public class Owner
		{
			int id;
			string name;
			string org;

			public Owner()
			{
				id = 45362;
				name = "Danik";
				org = "MYword.";
			}

			public void Print()
			{
				Console.WriteLine(id + " " + name + " " + org);
			}
		}
		//////////////////////////////////////////////////////////////////////////
		public class Date
		{
			DateTime dt;
			DateTime time_Now = DateTime.Now;
			public Date()
			{
				dt = new DateTime(2020, 10, 04);
			}
			public void Print()
			{
				Console.WriteLine(dt.ToString("d"));
				Console.WriteLine("Time Now: " + time_Now);

			}
		}
		//////////////////////////////////////////////////////////////////////////
		public static void Copy_stack(IEnumerable myCollection, Stack myStack)
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
							StatisticOperation.PrintValues_number(myStack2);
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
							StatisticOperation.PrintValues_Center(myStack2, myStack2);
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
						return;
					case 8:
						int newsize = Size_Stzck(myStack2);
						if (myStack2.Count == 0 || newsize == 1)
						{
							Console.WriteLine("Стек пуст или имеет одно значение");
						}
						else
						{
							StatisticOperation.class_interaction_number_element();
							StatisticOperation.class_interaction_difference();
							StatisticOperation.class_interaction_Sum();
							StatisticOperation.WordCount(myStack);
						}
						break;
					default:
						Console.WriteLine("Error repeat please");
						Console.WriteLine();
						break;
				}
			}
		}
	}
	//////////////////////////////////////////////////////////////////////////
	static class StatisticOperation
	{
		//////////////////////////////////////////////////////////////////////////
		public static void class_interaction_number_element()
		{
			Stack_cl p_ = new Stack_cl();
			Stack newst = p_.st;
			int sizestack = 0;
			foreach (Object obj in p_.st)
			{
				sizestack += 1;
			}
			Console.WriteLine("Number Stack: " + sizestack);
		}
		//////////////////////////////////////////////////////////////////////////
		public static void class_interaction_Sum()
		{
			Stack_cl p_ = new Stack_cl();
			if (p_.st.Count == 0 || p_.st.Count <= 0)
			{
				Console.WriteLine("Stack is empty");
			}
			else
			{
				Stack newst = p_.st;
				int sizestack = 0;
				foreach (Object obj in p_.st)
				{
					sizestack += 1;
				}
				int max = sizestack;
				string str_ = "";
				sizestack = 0;
				foreach (Object obj in p_.st)
				{
					sizestack += 1;
					if (sizestack == 1 || sizestack == max)
					{
						str_ += p_.st;
					}
				}
				Console.WriteLine("Sum Stack: " + str_);
			}
		}
		//////////////////////////////////////////////////////////////////////////
		public static void class_interaction_difference()
		{
			Stack_cl p_ = new Stack_cl();
			Stack newst = p_.st;
			int sizestack = 0;

			foreach (Object obj in p_.st)
			{
				sizestack += 1;
			}
			int max = sizestack;
			sizestack = 0;
			string str_ = "";
			string del_ = "";
			foreach (Object obj in p_.st)
			{
				sizestack += 1;
				if (sizestack == 1)
				{
					str_ += p_.st;
					del_ += p_.st;
				}
				if (sizestack == max)
				{
					str_ = str_.Replace(del_, "");
				}

			}
			Console.WriteLine("Sum Stack: " + str_);
		}
		//////////////////////////////////////////////////////////////////////////
		public static void WordCount(this IEnumerable myCollection)
		{
			int sizestack = 0, lengthstr;
			string str_ = "";
			foreach (Object obj in myCollection)
			{
				sizestack += 1;
				str_ += myCollection;
				lengthstr = str_.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
				str_ = "";
				lengthstr = 0;
			}
		}
		//////////////////////////////////////////////////////////////////////////
		//расшиерние для методов
		//////////////////////////////////////////////////////////////////////////
		public static void PrintValues_number(this IEnumerable myCollection)
		{
			foreach (Object obj in myCollection)
			{
				Console.Write("Value stack:   {0}", obj);
			}
			return;
		}
		//////////////////////////////////////////////////////////////////////////
		public static void PrintValues_Center(this IEnumerable myCollection, Stack myStack)
		{
			if (myStack.Count == 0)
			{
				Console.WriteLine("\nСтек пуст!");
				Console.WriteLine();
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
					if (sizestack == center)
					{
						Console.Write("Value center stack:   {0}", obj);
					}
				}
				Console.WriteLine();
			}
			return;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//название переменной + переменная содрежащая данные
			Stack_cl st_m = new Stack_cl();
			bool x = true;
			Console.WriteLine("Enter new value: ");
			string str = Console.ReadLine();
			st_m += str;

			st_m -= str;
			st_m.bl &= x;

		}
	}
}