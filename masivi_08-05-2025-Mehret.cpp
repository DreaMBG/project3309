// Условие за да може една година да е високосна.
//година, деляща се на числото 4 без остатък, е високосна;
//ако годината обаче също се дели без остатък на 100, то тя не е високосна;
//но ако годината също се дели без остатък и на 400, то тя пак ще е високосна.

#include <iostream>
#include <stdio.h>

int visokosna(int year) {
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
        return 1;
    }
    else {
        return 0;
    }
}

int proverkaMasiv(int count) {
    if (count > 10 || count < 1) {
        printf_s("Nevaliden broi godini.");
        return 1;
    }
}

int main()
{
    int years[10];
    int count;

    printf_s("Vuvedete broq na godinite (Max 10): ");
    scanf_s("%d", &count);

    proverkaMasiv(count);

    for (int i = 0; i < count; i++) {
        printf_s("Vuvedete godina: ", i + 1);
        scanf_s("%d", &years[i]);
    }

    printf_s("\nRezultati:\n");
    for (int i = 0; i < count; i++) {

        if (visokosna(years[i])) {
            printf_s("%d e visokosna.\n", years[i]);
        }
        else {
            printf_s("%d ne e visokosna.\n", years[i]);
        }
    }
}
