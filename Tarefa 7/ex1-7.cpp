#include <iostream>
using namespace std;

int num_reverso = 0;

void inversao(int num)
{
    while (num > 0) {

        num_reverso *= 10; 
        num_reverso = num_reverso + (num % 10);
        num /= 10;

        //estou acertando matemática básica agora :D

    }
}

int main()
{
    int num;
    cout << "Insira um algarismo inteiro: ";
    cin >> num;
    inversao(num);
    cout << num_reverso;

}

