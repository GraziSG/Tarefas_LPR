#include <iostream>
#include <random>
using namespace std;

int main()
{

    int numDigitado;

    random_device numAlatorio;
    uniform_int_distribution <> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAlatorio);

    cout << "Duvido tu acertar o algarismo de 1 a 100 que eu estou pensando :D" << endl;

    do {
        cin >> numDigitado;
        
        if (numDigitado > valorInteiro) {
           
            cout << numDigitado << "?????? ihhh chutou alto" << endl;
        }
        else if (numDigitado < valorInteiro) {

            cout << numDigitado<< "?????? ihhh chutou baixo" << endl;

        }
        if (numDigitado == valorInteiro) {

            cout << "NICE!!! TU ACERTOU (" << numDigitado << ")" << endl;
            break;
        }

    } while (numDigitado != valorInteiro);
}
