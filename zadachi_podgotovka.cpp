// Задача 1 Зоомагазин  
// Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.  
// Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв, а опаковка храна за котки струва 4 лв.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    const double dog_price = 2.50;
    const double cat_price = 4.00;

    double dog_food_pack;
    double cat_food_pack;

    printf_s("Vuvedete broq opakovki za kucheta: ");
    scanf_s("%lf", &dog_food_pack);

    printf_s("Vuvedete broq opakovki za kotki: ");
    scanf_s("%lf", &cat_food_pack);

    double total = (dog_price * dog_food_pack) + (cat_price * cat_food_pack);

    printf_s("Obshto: %.2f lv. \n", total);

}

// Задача 2 Зеленчуков магазин
// Земеделски производител продава реколтата от градината на зеленчуковата борса продава зеленчуци за N лева за килограм и плодове за M лева за килограм . 
// Напишете програма която пресмята приходите от реколтата на производителя в долари( проверете в интернет курса на долара). 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{

    double n, m;
    printf_s("Zelenchuci prodadeni v kg: ");
    scanf_s("%lf", &n);

    printf_s("Plodove prodadeni v kg: ");
    scanf_s("%lf", &m);

    const double dollar = 1.77;

    double total = (n + m) * dollar;
    printf_s("Obshto prihodi v dolari: %.2f", total);

}


// Задача 3  Цирк 
// Лили е ученичка в 3 клас има списък с учебници за пазаруване. 
// Цените (реални числа с двойна точност) на учебниците са по математика, български език,  английски език и физика се въвеждат от клавиатурата. 
// Родителите на Лили и дават  сума (въвежда се от клавиатурата) за покупка. В града пристига цирк и Лили иска да отиде. 
// Напишете програма, с която Лили да пресметне дали ще и стигнат парите да отиде на цирк и да си купи учебници. Резултата от изчислението да се закръгля до втория знак. 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{

    double math, bg, en, fiz;
    double n;

    printf_s("Kolko pari sa dadeni na Lili: ");
    scanf_s("%lf", &n);

    printf_s("Cena na uchebnik po Matematika: ");
    scanf_s("%lf", &math);
  
    printf_s("Cena na uchebnik po Bulgarski ezik: ");
    scanf_s("%lf", &bg);
  
    printf_s("Cena na uchebnik po Angliiski ezik: ");
    scanf_s("%lf", &en);
  
    printf_s("Cena na uchebnik po Fizika: ");
    scanf_s("%lf", &fiz);

    double total = math + bg + en + fiz;
    printf_s("Obshto pari za uchebnici: %.2f ot %.2f\n", total, n);

    double ostatuk = n - total;
    if (ostatuk > 0) {
        printf_s("Na lili i ostanaha: %.2f lv\n", ostatuk);
    }
    else {
        printf_s("Na lili ne i dostignaha: %.2f lv\n", ostatuk);
    }

    if (total > n) {
        printf_s("Lili nqma da ima pari da si kupi uchebnicite i nqma da moje da otide na cirk.");
    }
    else {
        printf_s("Lili uspq da si kupi uchebnicite i shte otide i na cirk.");
    }

}

// Задача 4  Средна скорост 
// Изчислете средната скорост, с която се движи автомобил, който е изминал разстояние от три километра за четири минути.  \

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{

    double km = 3.0;
    double time_minutes = 4.0;

    double time_hours = time_minutes / 60.0;

    double average_speed = km / time_hours;

    printf_s("Srednata skorost e: %.2f km/h\n", average_speed);
}

// Доставка на Храна
// Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
// Групата ще поръча десерт, чиято цена е равна на 20% от общата сметка (без доставка).
// Цената на доставката е 2.50 лв и се начислява най-накрая.

// От конзолата се четат 4 реда:
// - Брой пилешки менюта
// - Брой менюта с риба
// - Брой вегетариянски менюта
// Пилешко меню, Меню с риба, Вегетарианско меню са от реален тип с двойна точност. 

// Да се отпечатва на конзолата общата сума от всички менюта, форматирана до 3 знак след десетичната запетая. 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{

    double pile_cena = 10.35;
    double riba_cena = 12.40;
    double vegi_cena = 8.15;
    double dostavka = 2.50;

    double menu_pile, menu_riba, menu_vegi;

    printf_s("Broi pileshki menu-ta: ");
    scanf_s("%lf", &menu_pile);

    printf_s("Broi ribeshki menu-ta: ");
    scanf_s("%lf", &menu_riba);

    printf_s("Broi vegitarianski menu-ta: ");
    scanf_s("%lf", &menu_vegi);

    double total = menu_pile * pile_cena + menu_riba * riba_cena + menu_vegi * vegi_cena;

    double dessert_cena = total * 0.20;

    double obshta_cena = total + dessert_cena + dostavka;

    printf_s("Obshta cena: %.3f lv.\n", obshta_cena);
}
