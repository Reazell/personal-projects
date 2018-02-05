#include <stdio.h>

#include "funkcje.h"

void lista_dzialan(void)
{

    printf("\nWitam w kalkulatorze Szymona Przybyszewskiego \n\n");

    printf("Wpisz Q lub q aby wyjsc z programu\n");
    printf("Wpisz H lub h aby wyswietlic opcje\n");
    printf("Wpisz C lub c aby wyczyscic ekran \n");


    printf("Wpisz + aby dodawać \n");
    printf("Wpisz - aby odejmować \n");
    printf("Wpisz * aby mnożyć \n");
    printf("Wpisz / aby podzielić \n");
    printf("Wpisz ? aby wykonać modulo \n");
    printf("Wpisz ^ aby potegowac \n");
    printf("Wpisz P aby pierwiastkowac \n");
    printf("Wpisz B aby wykonać funkcje Bessela \n");
    printf("Wpisz W aby obliczyć wielomian\n");
    printf("Wpisz ! aby obliczyc silnie \n\n");
}

void czyszczenie(void)
{
    czyscEkran();
    lista_dzialan();
}

void czyscStandardoweWejscie(void)
{
    while('\n' !=getchar());
}

void czyscEkran(void)
{
    printf("\033[2J");
}
