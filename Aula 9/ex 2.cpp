using namespace std;
#include <iostream>;
#include <array>;

//.size()

struct Livro
{
	string Titulo;
	string Autor;
	short AnoPublicacao;
	short NumeroPaginas;
	float Preco;

};
int main() {
	
	Livro l1; Livro l2; Livro l3;
	array<short, 3> Biblioteca;

		cout << "Insira o titulo, o autor, o ano de publicacao, o numero de paginas e o preco do livro 1" << endl;
		cin >> l1.Titulo; cin >> l1.Autor; cin >> l1.AnoPublicacao; cin >> l1.NumeroPaginas; cin >> l1.Preco;
		Biblioteca[0] = { l1.NumeroPaginas };

		cout << "\nInsira o titulo, o autor, o ano de publicacao, o numero de paginas e o preco do livro 2" << endl;
		cin >> l2.Titulo; cin >> l2.Autor; cin >> l2.AnoPublicacao; cin >> l2.NumeroPaginas; cin >> l2.Preco;
		Biblioteca[1] = { l2.NumeroPaginas };

		cout << "\nInsira o titulo, o autor, o ano de publicacao, o numero de paginas e o preco do livro 1" << endl;
		cin >> l3.Titulo; cin >> l3.Autor; cin >> l3.AnoPublicacao; cin >> l3.NumeroPaginas; cin >> l3.Preco;
		Biblioteca[2] = { l3.NumeroPaginas };
		

	float PrecoTotal = l1.Preco + l2.Preco + l3.Preco;
	float somaPaginas = 0;

	for (short precos : Biblioteca)
	{
		somaPaginas += precos;
	}

	float mediaPaginas = somaPaginas / Biblioteca.size();

	cout << "O preco total eh: R$" << PrecoTotal << endl;
	cout << "A media de paginas eh: " << mediaPaginas;

}