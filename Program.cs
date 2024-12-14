// See https://aka.ms/new-console-template for more information
int [,] a=new int[5,5];

int value=1;

 for (int e = 0; e < 5; e++)
{
    for (int i = 0; i <5; i++)
    {
       int b= value++;
        a[e,i]= (i==0)?0:b;
      Console.Write($"{a[e,i]} " ); 
    }
Console.WriteLine();
} 

