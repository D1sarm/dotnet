// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = 44;
int kratno = 2;
if(a % kratno == 0){
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" кратно числу ");
    Console.Write(kratno);
}
else{
    Console.Write("Остаток = ");
    Console.Write(a % kratno);    
}
