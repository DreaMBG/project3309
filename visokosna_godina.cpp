// Изчислява броя години въведени от потребителя дали се високосни. 
// Използван е масив до максимум 10 години и функция за изчисляване на високосната година.

#include <iostream>
#include <stdio.h>
#include <math.h>

int visokosna(int year) {
    //Високосна година е:
    // - дели се на 4 и не се дели на 100
    // или
    // - дели се на 400

    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
        return 1;
    }
    else {
        return 0;
    }
}

int main()
{
    int years[10]; // Използва се масив до 10 години
    int count;

    printf_s("Kolko godini iskate da vuvedete? (max 10): ");
    scanf_s("%d", &count);

    if (count > 10 || count < 1) {
        printf_s("Nevaliden broi godini.\n");
        return 1;
    }

    for (int i = 0; i < count; i++) {
        printf_s("Vuvedete godina #%d: ", i + 1);
        scanf_s("%d", &years[i]);
    }

    printf_s("\nRezultati:\n");
    for (int i = 0; i < count; i++) {
        if (visokosna(years[i])) {
            printf_s("%d e visokosna godina.\n", years[i]);
        }
        else {
            printf_s("%d ne e visokosna godina.\n", years[i]);
        }
    }

    return 0;
}
