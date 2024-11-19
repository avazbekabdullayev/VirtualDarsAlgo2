


//eng katta 4tasini yigindisini 8,7,5,4 = 24
//eng kichik 4tasini yigindisini 2,3,4,5 = 14


int[] numberArrayMinMax = {2, 4, 6, 1, 8 };
const int NUMBER_ELEMENT_COUNT = 4;
int minNumberEasySum = 0;
for (int i = 0; i < NUMBER_ELEMENT_COUNT; i++) 
{
    int minNumber1 = numberArrayMinMax.Min();
    minNumberEasySum += minNumber1;
    numberArrayMinMax = numberArrayMinMax.Where(val => val != minNumber1).ToArray();
}
Console.WriteLine(minNumberEasySum);



int maxNumberEasySum = 0;
for (int i = 0; i < NUMBER_ELEMENT_COUNT; i++)
{
    int maxNumber1 = numberArrayMinMax.Max();
    maxNumberEasySum += maxNumber1;
    numberArrayMinMax = numberArrayMinMax.Where(val => val != maxNumber1).ToArray();
}
Console.WriteLine(maxNumberEasySum);





// numberArray ichidagi elementlarini yig'indisini hisoblash 
int[] numberArray = { 8, 2, 7, 4, 5, 3};
int sum = 0;
for (int i = 0; i < numberArray.Length; i++)
{
    sum = sum + numberArray[i];
}
Console.WriteLine(sum);



int[] numberArray2 = {1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 ,11, 12};
int sum2 = 0;
for (int i = 0; i < numberArray2.Length; i++)
{
   sum2 = sum2 + numberArray2[i];
}
Console.WriteLine(sum2);


int sum3 = 0;
for (int i = numberArray2.Length - 1; i>=0; i--)
{
    sum3 = sum3 + numberArray2[i];
}
Console.WriteLine(sum3);


//numberArrayni ichidagi eng kattasini topish
int[] numberArray3 = { 1, 3, 5, 2, 7, 8, 9, 4 };
int maxNumber = numberArray3[0];

for(int i = 0; i < numberArray3.Length; i++)
{
    if(numberArray3[i] > maxNumber)
    {
        maxNumber = numberArray3[i];
    }
}
Console.WriteLine(maxNumber);

////numberArrayni ichidagi eng kichigini topish
int[] numberArray4 = { 2, 4, 5, 8, 1 };
int osonTopishMinNumber = numberArray4.Min();
int minNumber = numberArray4[0];
for(int i = 0;i < numberArray4.Length; i++)
{
    if(numberArray4[i] < minNumber)
    {
        minNumber = numberArray4[i];
    }
}
Console.WriteLine(minNumber);
Console.WriteLine(osonTopishMinNumber);