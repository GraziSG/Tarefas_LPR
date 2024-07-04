using namespace std;
#include <iostream>
#include <map>

int main()
{
	map<string, int> Cidades = {
	 {"Srs", 40605},{"PousoA", 152217},{"BelaVista", 10107},{"Itajuba", 93073},{"Natercia", 4691} };


	int soma = 0;
	double media = 0;
	int populacaoRemover;
	int maiorPopulacao = 0, menorPopulacao = 15000000;

	for (auto populacao : Cidades)
	{
		soma += populacao.second;

		if (populacao.second > maiorPopulacao) maiorPopulacao = populacao.second;
		if (populacao.second < menorPopulacao) menorPopulacao = populacao.second;
	}

	media = soma / Cidades.size();
	cout << "Media: " << media << endl;

	for (auto acimaMedia : Cidades)
	{
		if (acimaMedia.second > media)
		{
			cout << "A cidade " << acimaMedia.first << " está acima da média (" << acimaMedia.second << ")" << endl;
		}
	}
	for (auto cidade : Cidades)
	{
		if (cidade.second == maiorPopulacao) cout << cidade.first << " é a cidade mais populosa com " << cidade.second << " pessoas" << endl;
		else if (cidade.second == menorPopulacao) cout << cidade.first << " é a cidade menos populosa com " << cidade.second << " pessoas" << endl;
	}

	cout << "\nDigite o numero da populacao que deseja remover: ";
	cin >> populacaoRemover;

	cout << "\nLista depois de remover:" << endl;

	for (auto remover : Cidades)
	{
		if (remover.second == populacaoRemover) Cidades.erase(remover.first);
	}
	for (auto fim : Cidades)
	{
		cout << fim.first << "," << fim.second << endl;
	}


}
