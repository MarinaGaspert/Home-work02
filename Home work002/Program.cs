/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
	
	int number = ReadInt("Введите число: ");
	int count = number.ToString().Length;
	Console.Write(Array(number, count));
	
/*Функция принимает сообщение  и выводит результат введенных данных пользователем. Цифровые значения. 
Преобразование Convert.To*/

	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	
	// Функция  выводит третью цифру числа. 
	int Array(int a, int b)
	{
	int result = 0;
	    if (b < 3)
	    {
	        Console.Write("Третьей цифры нет ");
	    }
	    else
	    {
	        int c = 1;
	        for (int i = b; i > 3; i--)
	        {
	            c = c * 10;
	        }
	

	        result = (a / c) % 10;
	    }
	return result;
	}


