//2. Да се състави конзолно приложение, с което се дефинира едномерен масив от 10 целочислени елемента.
// Да се въведат стойностите на елементите и да се изведат като се използват три начина: 
// достъп чрез индекс посредством оператор [], 
// достъп чрез индекс посредством оператор *, 
// достъп чрез указател.

#include <iostream>
#include <stdio.h>

int main()
{
    int arr[10];
    int i;

    // Въвеждане на елементите
    printf_s("Vuvedete 10 celi chisla:\n");
    for (i = 0; i < 10; i++) {
        printf_s("arr[%d] = ", i);
        scanf_s("%d", &arr[i]);
    }

    // Извеждане чрез оператор []
    printf_s("\nIzvejdane chrez indeksen dostup (arr[i]):\n");
    for (i = 0; i < 10; i++) {
        printf_s("%d ", arr[i]);
    }

    // Извеждане чрез указателна аритметика: *(arr + i)
    printf_s("\n\nIzvejdane chrez ukazatelna aritmetika (*(arr + i)): \n");
    for (i = 0; i < 10; i++) {
        printf_s("%d ", *(arr + i));
    }

    // Извеждане чрез указател
    printf_s("\n\nIzvejdane chrez ukazatel (chrez p++):\n");
    int* p = arr;
    for (i = 0; i < 10; i++) {
        printf_s("%d ", *p);
        p++;
    }

    printf_s("\n");
    return 0;
}

