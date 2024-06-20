//EXERCICIO 1

using namespace std;
#include <iostream>

int main()
{
    int numeros [10];
    int pares [10];
    int impares [10];

    cout<<"Digite 10 algarismos inteiros: ";
    for(int i = 0; i < 10; i++)
    {
    int numDigitado;
    cin >> numDigitado;
    numeros [i] = numDigitado;
    
    if (numeros[i] % 2 == 0)
    {
     pares[i] = numeros[i];
    }
    else 
    {
      impares[i] = numeros[i];
    }
    
    }
   for (int par : pares)
   {
       cout << "PAR:" << par << endl;
   }

for (int impar : impares)
   {
       cout << "IMPAR:" << impar << endl;
   }
    return 0;
}