#include <iostream>
#include <stdio.h>
using namespace std;
int * max(int * v1, int * v2, int tam)
{
	int *vetor= new int[tam];
	for (int i = 0; i < tam; i++)
		v1[i] > v2[i] ? vetor[i] = v1[i] : vetor[i] = v2[i];
	return vetor;
}
int main(void)
{
	int V1[5] = { 2,5,3,8,6 }, V2[5] = { 8,2,0,4,6 };
	int* M = max(V1, V2, 5);
	for (int i = 0; i < 5; i++)
		cout << M[i] << endl;
	return 0;
}