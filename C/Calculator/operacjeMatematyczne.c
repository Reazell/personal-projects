#include <stdio.h>
#include <math.h>
#include <tgmath.h>
#include <gsl/gsl_sf_bessel.h>
#include <gsl/gsl_poly.h>

#include "operacjeMatematyczne.h"
#include "funkcje.h"

void dodawanie(void)
{

    double a, suma=0, k=0, liczba;
    double *wskaznik_c;
    printf("\nWpisz ilosc dodawanych elementow:");
    scanf("%lf",&a);
    printf("Wprowadz %lf liczb po kolei: \n",a);
    while(k<a)
    {
        scanf("%lf",&liczba);
        wskaznik_c = &liczba;
        suma=suma+*wskaznik_c;
        k=k+1;
    }
    printf("Suma %lf liczb wynosi = %lf \n",a,suma);
    czyscStandardoweWejscie();
}

void odejmowanie(void)
{

    double a, b, c = 0;
    printf("\nWprowadz a  : ");
    scanf("%lf", &a);
    printf("Wprowadz b : ");
    scanf("%lf", &b);


    c =a - b;

    printf("\n%lf - %lf = %lf\n", a, b, c);
    czyscStandardoweWejscie();
}

void mnozenie(void)
{

    double a, b, mnozenie=0;
    printf("\nWprowadz mnożną : ");
    scanf("%lf", &a);
    printf("Wprowadz mnożnik: ");
    scanf("%lf", &b);

    mnozenie=a*b;

    printf("\nMnozenie podanych liczb wynosi = %lf\n",mnozenie);
    czyscStandardoweWejscie();
}

void dzielenie(void)
{

    double a, b, d=0;
    printf("\nWprowadz dzielną  : ");
    scanf("%lf", &a);
    printf("Wprowadz dzielnik : ");
    scanf("%lf", &b);


    d=a/b;

    printf("\nWynik dzielenia wynosi %lf\n",d);
    czyscStandardoweWejscie();
}

void modulus(void)
{

    int a, b, d=0;
    printf("\nWprowadz pierwszą liczbę : ");
    scanf("%d", &a);
    printf("Wprowadz druga liczbę : ");
    scanf("%d", &b);

    d =a % b;

    printf("\nModulo z tych liczb wynosi  %d\n",d);
    czyscStandardoweWejscie();
}

void potega(void)
{

    double a,b, p;
    printf("\nPodaj dwie liczby aby obliczyc potege \n");
    printf("Liczba : ");
    scanf("%lf",&a);
    printf("Potega : ");
    scanf("%lf",&b);


    p=pow(a,b);

    printf("\n%lf do potegi %lf wynosi %lf \n",a,b,p);
    czyscStandardoweWejscie();
}

void bessel(void)
{

    double a;
    printf("\nPodaj wartość która będzie obliczona za pomocą funkcji Bessela =  \n");
    scanf("%lf",&a);
    double b=gsl_sf_bessel_J0(a);
    printf("J0(%g) = %.18lf\n",a,b);
    czyscStandardoweWejscie();
}

void wielomian(void)
{

    int i;
    printf("\nObliczanie wielomianu P(x) = -1 + x^5\n\n");
    printf("\nPierwiastki tego wielomianu wynoszą : \n");
    double a[6] = {-1,0,0,0,0,1};
    double z[10];

    gsl_poly_complex_workspace * w
            =gsl_poly_complex_workspace_alloc(6);

    gsl_poly_complex_solve(a,6,w,z);

    gsl_poly_complex_workspace_free (w);
    for (i=1;i<6;i++)
    {
        printf("Pierwiastek %d = %+1.5f %+1.5fi\n",i,z[2*i],z[2*i+1]);

    }
    czyscStandardoweWejscie();
}

void pierwiastek(void)
{

    double pierwiastek;
    double stopien_pierwiastka;
    double wynik_pierwiastka;
    double stopien;

    printf("Podaj liczbe = ");
    scanf("%lf", &pierwiastek);

    printf("Podaj stopień pierwiastka = ");
    scanf("%lf", &stopien_pierwiastka);

    stopien=(1/stopien_pierwiastka);
    wynik_pierwiastka=pow(pierwiastek,stopien);

    printf("Wynik pierwiastkowania wynosi %1.2lf\n", wynik_pierwiastka);
    czyscStandardoweWejscie();
}

int silnia()
{
    long double i,silnia=1,num;

    printf("Wprowadz liczbe : ");
    scanf("%Lf",&num);

    if (num<0)
    {
        printf("\nWprowadz dodatnia liczbe");
        printf("\nNie ma silni z liczby ujemnej");
        return 1;
    }

    for (i=1;i<=num;i++)
        silnia=silnia*i;
    printf("Silnia z %Lf wynosi %Lf\n",num,silnia);
    czyscStandardoweWejscie();
    return 0;
}
