#include <iostream>
using namespace std;

int main()
{
    int num;
    cout << "Insira um algarismo inteiro: ";
    cin >> num;

    if (num % 2 == 0) {
     
        cout << "O algarismo " << num << " eh par!";
    }

    else{

        cout << "O algarismo " << num << " eh impar!";
}
}

