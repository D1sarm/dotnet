// 14. Найти третью цифру числа или сообщить, что её нет


int a = 8519527;
int b = a / 100;
int c = b % 10;
if(a > 99){
    Console.WriteLine(c);
}
else{
    Console.WriteLine("Заданное число < 100");
}