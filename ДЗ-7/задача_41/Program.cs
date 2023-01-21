/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" 
и производится при помощи нажатия Enter
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4   */


string consoleEnter = "";
int positivNumber = 0,
    count = 0;
while(true)
{
    Console.Write("Введите число или слова stop для остановки ввода и Enter для производение: ");
    string userEnter = Convert.ToString(Console.ReadLine());
    if (userEnter == "stop") break;
    consoleEnter += userEnter + ", ";
    positivNumber = int.Parse(userEnter);
    if (positivNumber > 0) count++;
}

Console.WriteLine($"{consoleEnter} -> {count} - положительных числа");


