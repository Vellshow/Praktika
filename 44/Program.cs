int firstNum = 0,
secondNum = 1,
number = 10,
sum = firstNum + secondNum,
swap = 0;

for (int i = 0; i <= number; i++)
{
    Console.WriteLine(sum);
    swap = sum;
    sum = sum + secondNum;
    secondNum = swap;
    
}
Console.WriteLine(sum);
