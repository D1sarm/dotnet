// Задача 13: Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void result(int a){
    int b = a / 100;
    int c = b % 10;
    if(a > 99){
        Console.WriteLine(c);
    }
    else{
        Console.WriteLine("Третьей цифры нет");
    }
}

result(645);