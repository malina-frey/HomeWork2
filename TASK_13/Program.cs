/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Number = new Random().Next();
int variable = Number;
int result = 0;
if (Number / 100 == 0)
{
    Console.WriteLine(Number + " -> третьей цифры нет ");
}
else
{
    while (variable > 1000)
    {
        variable = variable / 10;
        result = variable % 10;
    }
    Console.WriteLine(Number + " -> третья цифра "+ result);
}