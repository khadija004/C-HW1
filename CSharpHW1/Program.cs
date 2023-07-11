//Task1
//1. Daxil olunan ədədə qədər olan ədədlərin cəmini tapan alqoritm.

//int num = 5;
//int sum=0;

//for (int i = 0; i < num; i++)
//{
//    sum+=i;
//}
//Console.WriteLine(sum);

//Task2
//2. Daxil olunan ədədin faktorialını tapan alqoritm.

//int num = 4;
//int factorial = 1;

//for (int i = 1; i <= num; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);


//Task3
//3. Array-də(minimum 5 element olsun) tək index-də duran elementlərin cəmini tapmaq.

//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int sum = default;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine(sum);

//Task4
//4. Array-də(minimum 5 element olsun) bütün elementlər cütdürsə true əks halda false çap etmək algorithmi qurun.

int[] arr = { 4, 5, 6, 7, 8, 9, 10 };
bool answer = true;

for (int i = 0; i < arr.Length; i++)
{
	if (arr[i]%2!=0)
	{
		answer = false;
        Console.WriteLine("false");
		break;

    }

}
if (answer == true)
{
    Console.WriteLine("true");
}

