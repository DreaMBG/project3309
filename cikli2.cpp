// 1.Да се изведат всички цели числа от N до 1, всяко на различен ред.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    int n;
    printf_s("Vuvedi N: ");
    scanf_s("%d", &n);

    for (int i = n; i >= 1; i--) {
        printf_s("%d\n", i);
    }

}


// 2.Да се изведат всички цели числа от 5 до 100, които се делят на 5.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    for (int i = 5; i <= 100; i++) { // Въвеждане на числата делящи се на 5 (от 5 до 100)
        if (i % 5 == 0) { // Число което се дели на 5 и има остатък 0
            printf_s("%d\n", i); // Изход
        }
    }

}

// 3.Да се изведат числата от 1 до 100 по следният начин:
// А) 1,2,3,4,5,6,7………100;
// Б)100,99,98,97,96,…..1;
// В)* 1,100,2,99,3,98…..49,52,50,51;
// Г) крайното число се въвежда от потребителя.


// Вариант 1 (без меню).

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    
    int i;
    int krai;

    printf_s("Vuvedi kraino chislo: ");
    scanf_s("%d", &krai);

    printf_s("\nA) Ot 1 do %d: \n", krai);
    for (int i = 1; i <= krai; i++) {
        printf_s("%d", i);
        if (i != krai) {
            printf_s(",");
        }
    }
    printf_s("\n");

    printf_s("\nB) Ot %d to 1: \n", krai);
    for (int i = krai; i >= 1; i--) {
        printf_s("%d", i);
        if (i != 1) {
            printf(",");
        }
    }
    printf_s("\n");

    printf_s("\n C) Krastosano: \n");
    int lqvo = 1;
    int dqsno = krai;
    while (lqvo <= dqsno) {
        if (lqvo == dqsno) {
            printf_s("%d", lqvo);
        }
        else {
            printf_s("%d,%d", lqvo, dqsno);
        }
        lqvo++;
        dqsno--;
        if (lqvo <= dqsno) {
            printf_s(",");
        }
    }
    printf_s("\n");

}


// Вариант 2 (с меню). Избора се прави от клавиатурата.
// ЗАДЪЛЖИТЕЛНО ПЪРВО СЕ ВЪВЕЖДА ЧИСЛОТО (ОПЦИЯ 4).

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    
    int izbor;
    int krai;

    do {
        printf_s("\n--- MENU ---\n");
        printf_s("1. A) Ot 1 do kraino chislo\n");
        printf_s("2. B) Ot kraino chislo do 1\n");
        printf_s("3. C) Krastosano: 1, 100, 2, 99, ... \n");
        printf_s("4. D) Vuvedi novo kraino chislo\n");
        printf_s("0. Izhod\n");
        printf_s("Izbor: ");
        scanf_s("%d", &izbor);

        switch (izbor) {
            case 1:
                if (krai == 0) {
                    printf_s("Molq purvo vuvedete kraino chislo (izberete opciq 4).\n");
                    break;
                }
                printf_s("A) Ot 1 do %d: \n", krai);
                for (int i = 1; i <= krai; i++) {
                    printf_s("%d", i);
                    if (i != krai) {
                        printf_s(",");
                    }
                }
                printf_s("\n");
                break;

            case 2:
                if (krai == 0) {
                    printf_s("Molq purvo vuvedete kraino chislo (izberete opciq 4).\n");
                    break;
                }
                printf_s("B) Ot %d do 1: \n", krai);
                for (int i = krai; i >= 1; i--) {
                    printf_s("%d", i);
                    if (i != 1) {
                        printf_s(",");
                    }
                }
                printf_s("\n");
                break;

            case 3:
                if (krai == 0) {
                    printf_s("Molq purvo vuvedete kraino chislo (izberete opciq 4).\n");
                    break;
                }
                printf_s("C) Krastosano ot 1 do %d: \n", krai);
                {
                    int lqvo = 1;
                    int dqsno = krai;
                    while (lqvo <= dqsno) {
                        if (lqvo == dqsno) {
                            printf_s("%d", lqvo);
                        }
                        else {
                            printf_s("%d,%d", lqvo, dqsno);
                        }
                        lqvo++;
                        dqsno--;
                        if (lqvo <= dqsno) {
                            printf_s(",");
                        }
                    }
                    printf_s("\n");
                }
                break;

            case 4:
                printf_s("Vuvedete kraino chislo: ");
                scanf_s("%d", &krai);
                break;

            case 0:
                printf_s("Izhod...\n");
                break;

            default:
                printf_s("Nevaliden izbor!\n");
        }
    } while (izbor != 0);

}
