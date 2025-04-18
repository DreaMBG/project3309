// 1. Кои алгоритми са линейни? - Съставени са от инстукции (команди), които се изпълняват последователно една след друга по реда на записването им.
// 2. Кои алгоритми са разклонени? - Разклонени алгоритми са тези, при които последователността от действия, с които се решава задачата, зависи от входните данни.
// 3. Кои алгоритми са циклични? - Имат зададено условие, които се изпълнява в някакъв цикъл, докато не му се даде край.

// 4. Каква е разликата между цикъл с пред условие и цикъл със след условие? - 
// Цикъл с предусловие – Ако повторенията продължават, докато е в сила дадено условие, и завършват щом то вече не е в сила се използува оператора. 
// Цикъл със след условие - Ако върне стойност False, цикълът се прекратява и се преминава на следваща команда.

// 5. Кои цикли са вложени? - Вложените цикли представляват конструкция, при която в тялото на един външен цикъл се изпълнява друг, които е вътрешен цикъл.

// Задачи с програмни кодове: 

// 1. Да се състави алгоритъм за намиране на обем на правилна триъгълна пирамида. Стойностите на страните на основата и височината се задават от клавиатурата.

// (Алгоритъм):
// 0. Извиква се #include <math.h>
// 1. Въвеждат се стойностите за a и h. (При нас се въвеждат с double).
// 2. Въвежда се дължината на страната на основата (а);
// 3. Въвежда се височината на пирамидата (h). 
// 4. Използва се формула за лице на основата. S = (a * a * sqrt(3)) / 4;
// 5. Използва се формула за изчисляване обема на пирамидата. V = (1.0 / 3) * lice_osnova * h;
// 6. Принтират се данните от последната функцията. (obem).

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
  double a, h;
  printf_s("Vuvedi duljinata na stranata na osnovata (a): );
  scanf_s("%lf", &a);

  printf_s("Vuvedi visochinata na piramidata (h): );
  scanf_s("%lf", &h);

  double lice_osnova = (a * a * sqrt(3)) / 4;
  double obem = (1.0 / 3) * lice_osnova * h;

  printf_s("Obemut na piramidata e: %.2lf", obem);

  return 0;
}

// 2. Да се състави алгоритъм за въвеждане на две числа и намиране на по-голямото от тях.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{      
	double a, b;

	printf_s("A = ");
	scanf_s("%lf", &a);

	printf_s("B = ");
	scanf_s("%lf", &b);

	if (a > b) {
		printf_s("A > B");
	}
	else if (b > a) {
		printf_s("B > A");
	}
	else if (a == 0, b == 0) {
		printf_s("A = 0, B = 0 => Ravni");
	}
	else if (a = b) {
		printf_s("Ravni");
	}

	return 0;
}

// 4. Да се състави алгоритъм за намиране на произведението на произволно въведени
// положителни числа от клавиатурата. Въвеждането на стойност 0 да прекрати
// понататъшното въвеждане на числа.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{      
	double a, b;

	printf_s("A = ");
	scanf_s("%lf", &a);

	printf_s("B = ");
	scanf_s("%lf", &b);

	double sum = a * b;

	if (a == 0) {
		printf_s("Nevuzmojno");
	}
	else if (b == 0) {
		printf_s("Nevuzmojno");
	}

	printf_s("Sum = %.2lf", sum);

	return 0;
}


