using System;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool n = false;			//Проверка на наличие скобок
			int m = 0;		
			Console.WriteLine ("Введите арифметическое вырожение со скобками: ");
			string s1 = Console.ReadLine();
			for (int i = 0; i < s1.Length; i++) {
				if (s1 [i] == '(') {
					n = true;
					m++;
				}
				if (s1 [i] == ')') {
					if (m == 0) {
						Console.WriteLine ("Некорректная расстановка скобок! ");
						break;
					} else
						m--;
				}
			}
			if (n) {
				if (m == 0)
					Console.WriteLine ("Скобки расставлены верно! ");
				else
					Console.WriteLine ("Некорректная расстановка скобок! ");
			} else
				Console.WriteLine ("Скобок нет! ");
			
		}
	}
}
