cc = gcc-4.7
flags = -Wall -pedantic -Wextra -std=c11
linker = -lm -lgsl -lgslcblas

all: KalkulatorPrzybyszewski.exe

funkcje.o: funkcje.c funkcje.h
	$(cc) $(flags) $< -c -o $@

operacjeMatematyczne.o: operacjeMatematyczne.c operacjeMatematyczne.h funkcje.h
	$(cc) $(flags) $< -c -o $@

KalkulatorPrzybyszewski.o: KalkulatorPrzybyszewski.c operacjeMatematyczne.h funkcje.h
	$(cc) $(flags) $< -c -o $@

KalkulatorPrzybyszewski.exe: funkcje.o operacjeMatematyczne.o KalkulatorPrzybyszewski.o
	$(cc) $(flags) $^ $(linker) -o $@

run: KalkulatorPrzybyszewski.exe
	./$<

clear:
	rm -rf *.o
	rm -rf *.exe
