// 1. Напишете програма която отпечатва n на брой елемента и излиза от цикъла при условие i=4.
// Да се преправи програмния код така че при условие i=4,програмата да продължава своето изпълнение без да отпечата стойността на елемента на позиция 4.

// Вариант, при който прекъсва цикъла при i == 4. Използва се break.

// break не позволява да продължи цикъла повече от 4.

// Изход:
// 0
// 1
// 2
// 3

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
	int n;

	printf_s("Vuvedi broi elementi: ");
	scanf_s("%d", &n);

	for (int i = 0; i < n; i++) {
		if (i == 4) {
			break;
		}
		printf_s("%d\n", i);
	}
}


// Вариант 2 

// Пропуска при i == 4. Използва за функцията countinue.

// Вход - 10
// Изход:

// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
	int n;

	printf_s("Vuvedi broi elementi: ");
	scanf_s("%d", &n);

	for (int i = 0; i < n; i++) {
		if (i == 4) {
			continue;
		}
		printf_s("%d\n", i);
	}
}
