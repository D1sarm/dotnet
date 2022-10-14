// int[] a = {1,2,3};
// int[] b = {3,2,1};
// int[] c = {0,0,0};
// for(int i = 0; i<a.Length; i++){
//     c[i] = a[i] + b[i];
// }
// System.Console.WriteLine(string.Join(' ',c));

// int n = 999;// 10 <= n <= 1000
// int[] arr = new int[n];// 0..100


// {1,2,1,1,1,1,2,2,2,3,3,3,3, 8,9}

// 1 - 5р
// 2 - 4р
// 3 - 4р
// 8 - 1р
// 9 - 1р
int n = 4; // 10 <= n <= 1000
int[] arr = new int [n]; // 0..100
int[] arr2 = new int [n]; // Массив уже провереных элементов
// Заполнили массив.
for(int i = 0; i<arr.Length; i++){
     arr[i] = Random.Shared.Next(0,3);
}
System.Console.WriteLine(string.Join(' ',arr)); // Посмотрим на сгенерированный массив
for(int j = 0; j<arr.Length; j++){
    int count = 1; // Количество одинаковых элементов
    int a = arr[j];
    for(int k = 0; k < arr2.Length; k++)
    {
        if(a == arr2[k])
        {
            arr2[k] = a;
        }
        else
        {
            for(int b = j+1; b < arr.Length; b++){
                if(arr[b] == a) count++;   
            }
        }
    }
    System.Console.WriteLine($"{arr[j]} - {count}р");
}


