int num = 0;
string numString = "";

Console.WriteLine("Введите число ");
while(!(Convert.ToBoolean(num))) {
    numString = Console.ReadLine();
    if(!(int.TryParse(numString, out num))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод.");
}

for(int i = 2; i < num; i++) {
    if(i % 2 == 0) { Console.Write(i); Console.Write(" "); }
}
Console.WriteLine();
