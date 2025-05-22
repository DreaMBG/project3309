// ZadachiC++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
using namespace std;

int main()
{
   /* int x, y, * px = 0, * py = 0, z;
    x = 5;
    y = 6;
    
    px = &x;
    py = &y;
    z = x;
    *px =*py;
    *py = z;
       

    cout << "Value for x: " << x << endl;
    
    
    cout << "Value for y: " << y << endl;*/

    //Zad 4

    double m[3];
    double* pB = 0, *pS =0 ;

 

    for (int i = 0; i < 3; i++)
    {
        cout << "New array: ";
        cin >> m[i];
    }
    
    for (int i = 0; i < 3; i++)
    {
        if (*pB < m[i])
        {
            *pB = m[i];
            
        }
        else {
            *pS > m[i];
            *pS = m[i];
        }
    }
    //cout << "All elements of the array: " ;
    cout << "Golqm: " << *pB << endl;
    cout << "Maluk: " << *pS;
    






}

