// Конзолно приложение, което разменя две зададени числа от указател. 

#include <iostream>
#include <stdio.h>

void razmeni(int* a, int* b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

int main()
{
    int x, y;

    printf_s("Vuvedete purvoto chislo: ");
    scanf_s("%d", &x);

    printf_s("Vuvedete vtoroto chislo: ");
    scanf_s("%d", &y);

    printf_s("\nPredi razmqnata x = %d, y = %d\n", x, y);

    razmeni(&x, &y);

    printf_s("Sled smqnata x = %d, y = %d", x, y);

    return 0;
}
