#include <iostream>
#include <stdio.h>
using namespace std;
char * substr(char *str, int char_inicial, int char_final)
{
	char* aux = new char[char_final+1];
	
	for (int i = char_inicial; i < char_inicial + char_final; i++)
		aux[i-char_inicial] = str[i];
	
	aux[char_final] = '\0';

	return aux;
}
int main(void)
{
	char site[40] = "http://www.unifenas.br/inscricao.asp";
	char* s = substr(site, 7, 15);
	cout << s << endl;
	return 0;
}