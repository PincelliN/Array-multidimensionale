// See https://aka.ms/new-console-template for more information
int [,] a=new int[5,5];

int value=1;

for (int e = 0; e < 5; e++)
{
    for (int i = 0; i <5; i++)
    {
        if(i==0){
          a[e,i]= 0;
           value++; 
        }else{
        a[e,i]= value++;
            }
      Console.Write( a[e,i]); 
    }
Console.WriteLine();
}
