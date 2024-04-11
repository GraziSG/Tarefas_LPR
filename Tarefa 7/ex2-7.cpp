#include <iostream>
using namespace std;

void ex1()
{
    int contador1 = 0;
    int contador2 = 0;
    double acumulador = 0;
    int qunatidade, numAnalisado;

    cout << "Insira a quantidade de algarismos que serao digitados: ";
    cin >> qunatidade;

    while (contador2 < qunatidade)
    {
        cout << "Digite um número";
        cin >> numAnalisado;
        contador2++;

        if (numAnalisado % 2 == 0)
        {
            acumulador += numAnalisado;
            contador1++;
        }
    }

    double media = acumulador / contador1;
    cout << "Media: " << media;


}

void ex3()
{
    int acumulador = 0;

    for (int i = 50; i <= 500; i++) {

        if (i % 3 == 0 && i % 2 != 0) {
            acumulador += i;
        }
    }

    cout << acumulador << endl;
}

void ex4(int num)
{
    int digito;
    int acumulador = 0;

    int quadrado = num * num;

    while (quadrado > 0)
    {
        digito = quadrado % 10;
        acumulador += digito;
        quadrado /= 10;
    }

    cout << "A soma dos algarismos do quadrado desse numero: " << acumulador;

}

int main()
{
    int opcao;
    do {
        int num;
        cout << "\nSelecione a opcao desejada: \n1 = Atividade 1 - media aritmetica de numeros pares \n2 = Atividade 3 - multiplos de 3, de 50 a 500 \n3 = Atividade 4 - soma de digitos do quadrado \n4 = Sair do programa" << endl;
        cin >> opcao;

        switch (opcao)
        {
        case 1:
            ex1();
            break;

        case 2:
            ex3();
            break;

        case 3:
            cout << "Insira o algarismo inteiro: ";
            cin >> num;
            ex4(num);
            break;

        case 4:
            cout << "Saindo do programa...";
            break;

        default:
            cout << "Numero invalido";
        }


    } while (opcao != 4);
}

