/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

bool Palindrom(int num)
{
  int number = num;
  int rev_number = 0;
  while (number > 0)
  {
    int rev = number % 10;
    rev_number = rev_number * 10 + rev;
    number = number / 10;
  }
  return (num == rev_number);
}
bool x5(int num){
  int i = 0;
  while (Math.Abs(num) > 0)
  {
    i++;
    num/=10;
  }
  return (i==5);
}

Console.WriteLine("Задайте целое пятизначное число: ");
try
{
  int x = Convert.ToInt32(Console.ReadLine());
  if (x5(x))
  {
    if (Palindrom(Math.Abs(x)))
    {
      Console.WriteLine("Это палиндромом.");
    }
    else
    {
      Console.WriteLine("Это не палиндромом.");
    }
  }
  else
  {
    Console.WriteLine("Число не пятизначное.");
  }

}
catch
{ Console.WriteLine("Не корректный ввод данных."); }