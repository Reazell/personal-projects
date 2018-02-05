#include <stdio.h>
#include <stdlib.h>

#include "operacjeMatematyczne.h"
#include "funkcje.h"

int main()
{
    int menu=1;
    char KEY;

    lista_dzialan();

    while(menu)
    {
        printf("\n");
        printf("\nKtora operacja ma zostac wykonana: ");

        KEY=getchar();

        switch(KEY)
        {
        case '+': dodawanie();
            break;

        case '-': odejmowanie();
            break;

        case '*': mnozenie();
            break;

        case '/': dzielenie();
            break;

        case 'p':
        case 'P': pierwiastek();
            break;

        case '?': modulus();
            break;

        case '!': silnia();
            break;

        case '^': potega();
            break;

        case 'B':
        case 'b': bessel();
            break;

        case 'W':
        case 'w': wielomian();
            break;

        case 'H':
        case 'h': lista_dzialan();
            break;

        case 'Q':
        case 'q': exit(0);
            break;
        case 'C':
        case 'c': czyszczenie();
            break;

        default : czyszczenie();

            printf("\nProsze ponownie wprowadzic operacje");

        }
    }
    return 0;
}
