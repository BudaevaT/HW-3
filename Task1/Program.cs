Console.Write(" Введите пятизначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);

if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine(" Палиндром ");
}
else
{
    Console.WriteLine(" Не палиндром ");
}