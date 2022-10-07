// 18. Проверить истинность утверждения ¬(X or Y or Z) = ¬X and ¬Y and ¬Z

bool x = false;
bool y = false;
bool z = false;

if(!(x | y | z) == (!x&!y &!z)){
    Console.Write("1" );

 
    
}
