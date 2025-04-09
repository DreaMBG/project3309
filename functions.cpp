// Зад. 1  Напишете програма която да извършва следните операции:
// -         Да се напише функция, която да събира две числа
// -         Да се напише функция, която да умножава две числа
// -         Да се напише функция, която  дели две числа
// -         Да се напише функция, която да повдига на 3 степен едно число.
// -         Да се напише функция, която да въвежда елементите на едномерен масив
// -         Да се напише функция, която да извежда елементите на едномерен масив
// -         Да се организира извикването на гореспоменатите подпрограми посредством меню.

#include <iostream>
#include <stdio.h>
#include <math.h>

double subirane(double a, double b) {
	return a + b;
}

double umnojenie(double a, double b) {
	return a * b;
}

double delenie(double a, double b) {
	if (b == 0) {
		printf_s("Delenie na 0 ne e pozvoleno.");
		return 0;
	}
	return a / b;
}

double stepenuvane(double a) {
	return pow(a, 3);
}

void razmerMasiv(int arr[], int size) {
	printf_s("Vuvedi %d elementa\n", size);
	for (int i = 0; i < size; i++) {
		scanf_s("%d", &arr[i]);
	}
}

void izhodMasiv(int arr[], int size) {
	printf_s("Elementite na masiva sa: \n");
	for (int i = 0; i < size; i++) {
		printf_s("%d ", arr[i]);
	}
	printf_s("\n");
}

int main()
{
	int izbor;
	int arr[100];
	int size = 0;

	double a, b;

	do {
		printf_s("\n--- Menu ---\n");
		printf_s("1. Subirane\n2. Umnojenie\n3. Delenie\n4. Stepenuvane\n5. Vuvejdane na masiv\n6. Izvejdane na masiv\n0. Izhod\nIzbor: ");
		scanf_s("%d", &izbor);

		switch (izbor) {
			case 1:
				printf_s("Vuvedi dve chisla: ");
				scanf_s("%lf %lf", &a, &b);
				printf_s("Suma: %.2lf\n", subirane(a, b));
				break;
			case 2:
				printf_s("Vuvedi dve chisla: ");
				scanf_s("%lf %lf", &a, &b);
				printf_s("Proizvedenie: %.2lf\n", umnojenie(a, b));
				break;
			case 3:
				printf_s("Vuvedi dve chisla: ");
				scanf_s("%lf %lf", &a, &b);
				printf_s("Chastno: %.2lf\n", delenie(a, b));
				break;
			case 4:
				printf_s("Vuvedi chislo: ");
				scanf_s("%lf", &a);
				printf_s("Stepen: %.2lf\n", stepenuvane(a));
				break;
			case 5:
				printf_s("Razmer na masiva: ");
				scanf_s("%d", &size);
				razmerMasiv(arr, size);
				break;
			case 6:
				izhodMasiv(arr, size);
				break;
			case 0:
				printf_s("Izhod...\n");
				break;
			default:
				printf_s("Nevaliden izbor!\n");
		}
	} while (izbor != 0);
}

// Зад.2 Напишете програма която да извършва следните операции:
// - Да се напише функция, която да пресмята  лице на квадрат
// - Да се напише функция, която да пресмята  лице на правоъгълник
// - Да се напише функция, която да пресмята  лице на успоредник
// - Да се напише функция, която да пресмята  лице на трапец
// - Да се напише функция, която да пресмята  лице на кръг
// - Да се напише функция, която да пресмята  лице на правоъгълен триъгълник
// - Да се напише функция, която да пресмята  лице на  триъгълник по 3 страни

// -   Да се организира извикването на гореспоменатите подпрограми посредством меню.

#include <iostream>
#include <stdio.h>
#include <math.h>

double kvadrat(double a) {
	return a * a;
}

double pravougulnik(double a, double b) {
	return a * b;
}

double usporednik(double a, double h) {
	return a * h;
}

double trapec(double a, double b, double h) {
	return (a + b) * h / 2.0;
}

double krug(double r, double PI = 3.14) {
	return PI * r * r;
}

double pravougulen(double a, double b) {
	return (a * b) / 2.0;
}

double tri_strani(double a, double b, double c) {
	double s = (a + b + c) / 2.0;
	return sqrt(s * (s - a) * (s - b) * (s - c));
}

int main()
{
	int izbor;
	double a, b, c, h;

	do {
		printf_s("\n--- Menu: Geometrichni Figuri ---\n");
		printf_s("1. Kvadrat\n2. Pravougulnik\n3. Usporednik\n4. Trapec\n5. Krug\n6. Pravougulen Triugulnik\n7. Triugulnik po strani\n0. Izhod\nIzbor: ");
		scanf_s("%d", &izbor);

		switch (izbor) {
		case 1:
			printf_s("Strana: ");
			scanf_s("%lf", &a);
			printf_s("Lice: %.2lf\n", kvadrat(a));
			break;
		case 2:
			printf_s("Dve strani: ");
			scanf_s("%lf %lf", &a, &b);
			printf_s("Lice: %.2lf\n", pravougulnik(a, b));
			break;
		case 3:
			printf_s("Osnova i visochina: ");
			scanf_s("%lf %lf", &a, &h);
			printf_s("Lice: %.2lf\n", usporednik(a, h));
			break;
		case 4:
			printf_s("Dve osnovi i visochnina: ");
			scanf_s("%lf %lf %lf", &a, &b, &h);
			printf_s("Lice: %.2lf\n", trapec(a, b, h));
			break;
		case 5:
			printf_s("Radius: ");
			scanf_s("%lf", &a);
			printf_s("Lice: %.2lf\n", krug(a));
			break;
		case 6:
			printf_s("Kateti: ");
			scanf_s("%lf %lf", &a, &b);
			printf_s("Lice: %.2lf\n", pravougulen(a, b));
			break;
		case 7:
			printf_s("Tri strani: ");
			scanf_s("%lf %lf %lf", &a, &b, &c);
			printf_s("Lice: %.2lf\n", tri_strani(a, b, c));
			break;
		case 0:
			printf_s("Izhod...\n");
			break;
		default:
			printf_s("Nevaliden izbor!\n");
		}
	} while (izbor != 0);
}
