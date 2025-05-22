// Задача: Да се въведе от клавиатурата стойности от масив. Да ги изведе. (10 стойности на масива).

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <algorithm>

int main()
{
    //int mA[10]; // въвеждане на масива (големина на масива).

    //for (int i = 0; i < 10; i++) { // цикъл за въвеждане на масива.
    //    scanf_s("%d", &mA[i]); // стойност на елементите в масива.
    //}

    //printf_s("\n"); // нов ред.

    //for (int i = 0; i < 10; i++) { // цикъл за извеждане на масива.
    //    printf_s("%d", mA[i]); // принтиране на елементите в масива.
    //}

    /*printf_s("\n");*/
    
    // За извеждане в обратен ред.

    /*for (int i = length - 1; i >= 0; i--)
    {

    }*/

    /*for (int i = 10 - 1; i >= 0; i--) {
        printf_s("%d", mA[i]);
    }*/

    /*double mA[10];
    double sum = 0;
    double sum2 = 0;
    for (int i = 0; i < 10; i++) {
        scanf_s("%lf", &mA[i]);
    }

    for (int i = 0; i < 10; i++) {
        
        sum += mA[i];
        sum2 = sum / 10;
        
    }
    printf_s("\n");
    printf_s("Sum = %lf \n", sum);
    printf_s("Sredno aritmetichno = %lf", sum2);*/


    int mas[20];
    int i, j, a, k, max;

    printf_s("Nomer na masiv (granici ot 2 do 20) = ");
    scanf_s("%d", &j);

    for (a = 0; a < j; a++) {
        scanf_s("\n%d", &mas[a]);
    }

    max = mas[0];
    k = 0;
    for (i = 1; i < j; i++) {
        if (mas[i] > max) {
            max = mas[i];
            k = i;
        }
        printf_s("max = %d\n", max);
        printf_s("indexa na poziciqta e %d\n", k);
    }




    return 0;
}
