//EXERCICIO 2

using namespace std;
#include <iostream>

int main()
{
    int numeros [10];
    int numPesquisa;
    int posicoesNumP [10];
    int acumulador = 0;
    
    cout<<"Digite 10 algarismos inteiros: ";
    for(int i = 0; i < 10; i++)
    {
    cin >> numeros [i];
    }
   
     cout<<"Digite o algarismo que deseja pesquisar: ";
     cin >> numPesquisa;
     
     for(int i = 0; i < 10; i++)
     {
         if (numPesquisa == numeros [i])
         {
             posicoesNumP[acumulador] = i;
             acumulador++;
             
         }
     }
     cout << "O numero pesquisado eh : " << numPesquisa << endl;
  cout << "Ele aparece " << acumulador << " vezes no vetor e nas posicoes: " <<endl;
  for (int posic : posicoesNumP)
  {
      if (posic != 0)
      {
        cout << posic << endl;
      }
  }
 
}