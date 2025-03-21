#include <iostream>
#include <locale>
using namespace std;
#define RESET   "\033[0m"
#define RED     "\033[31m"
#define GREEN   "\033[32m"
#define WHITE "\033[47m"
int main()
{
    setlocale(LC_ALL, "pt_BR.utf8");
    int x,y;
    cout <<WHITE<< RED << "Digite numeros inteiros e falarei se eles são múltiplos ou não\n"<<RESET;
    cout <<GREEN << "\n---------------\n";
    cout << "SEJA BEM VINDO!\n";
    cout << "---------------\n";
    cout << "Digite um numero inteiro\n";
    if(cin >> x)
    {
        cout << "Digite outro numero inteiro\n";
        if(cin >> y)
        {
            if (y % x == 0 || x % y == 0)
            {
            cout << WHITE << GREEN << "São múltiplos\n";
            }
            else
            {
            cout << WHITE << RED << "Não são múltiplos\n";
            }
        }else
        {
            cout << WHITE << RED << "Digite um numero INTEIRO\n";
        }
    }else
    {
        cout << WHITE << RED << "Digite um numero INTEIRO\n";
    }
    cout << RESET;

}