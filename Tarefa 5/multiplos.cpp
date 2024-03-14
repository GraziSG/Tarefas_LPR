#include <iostream>
using namespace std;

int main()
{ 

    int num1, num2;
    cout << "Insira dois algarismos inteiros: " << endl;
    cin >> num1;
    cin >> num2;

    if (num1 > num2) {
        
        if (num1 % num2 == 0) {

            cout << "Os algarismos " << num1 << " e " << num2 << " sao multiplos" << endl;
        }

        else {

            cout << "Os algarismos " << num1 << " e " << num2 << " nao sao multiplos" << endl;
        }

    }

    else {

        if (num2 % num1 == 0) {

            cout << "Os algarismos " << num1 << " e " << num2 << " sao multiplos" << endl;
        }

        else {

            cout << "Os algarismos " << num1 << " e " << num2 << " nao sao multiplos" << endl;
        }

    }
}


