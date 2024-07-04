#include <stdlib.h>   
#include <list>
#include <iostream>
using namespace std;

int main()
{
	list<int> numeros;

	for (auto i = 0; i < 100; i++) {
		int num = rand() % 100;
		numeros.push_back(num);
	}
	numeros.sort();

	for (auto elemento : numeros) 
	{
		cout << elemento << endl;

	}
	
	/*for (int elemento : numeros) {
		if (elemento % 2 == 0)
		{
			numeros.remove(elemento);
		}
	}*/
	//for (auto elemento : numeros) {
//		cout << elemento << endl;
//	}

}
