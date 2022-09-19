// тетрис
Console.Clear();
int[,] pole = 
{
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
};


void PrintArray(int[,] array) //вывод экрана
    {
        for(int i = 0; i < array.GetLength(0); i++)  
            {
                for ( int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == 1 ) Console.Write($"  {array[i, j]}  ");
                        else Console.Write($"     ");
                    }
                 Console.WriteLine();

            }
        Console.WriteLine();

    }

int figura = 5;   // фигуры квадрат, палка, зет, ге, танчикю Значит переменния будет принимать значения от 0 до 4: 5 фигуры нет
int go;       // будет принимать значения от пользователя повернуть, лево, право,вниз значения от 0 до 3
int poloj = 0;    // запоминает положение фигуры на поле для её поворота положения от 0 до 4 где 0 нет еще фигуры а значит и положения еще нет
int exit = 0; // выход если будет пересеченте едениц
int kordRow = 0; // запоминаем кодинату фигуры относитально строк
int kordCol = 0; // запоминаем кординату фигуры относительно столбцов
int newFigura = 1; // фигуры нет на экрне, при 0 фигура на экране

void NewFigura(int f) // выводим на экран новую фигуру запоминаем кординаты и положение
    {
        poloj = 0;
        if (f == 0)// квадрат
            {
                if (pole[1,4] == 0 && pole[1,5] == 0 && pole[0,4] == 0 && pole[0,5] == 0) 
                {
                   pole[1,4] =1; pole[1,5] = 1; pole[0,4] = 1; pole[0,5] = 1;
                   poloj = 1; kordCol = 4; kordRow = 1;
                }
                else exit = 1;               
            }
        else
        {
            if(f == 1) // tank
                {
                    if (pole[0,4] == 0 && pole[1,4] == 0 && pole[2,4] == 0 && pole[1,5] == 0) 
                        {
                            pole[0,4] =1; pole[1,4] = 1; pole[2,4] = 1; pole[1,5] = 1;
                            poloj = 1; kordCol = 4; kordRow = 1;
                        }
                    else exit += 1;
                    
                }
            else
            {
                if (f == 2) // kon'
                    {
                        if (pole[0,4] == 0 && pole[1,4] == 0 && pole[2,4] == 0 && pole[0,5] == 0) 
                            {
                                pole[0,4] =1; pole[1,4] = 1; pole[2,4] = 1;  pole[0,5] = 1;
                                kordCol = 4; kordRow = 1; poloj = 1;
                            }
                        else exit += 1;
                        
                    }
                else
                {
                    if (f ==3) //Z
                        {
                            if (pole[0,4] == 0 && pole[1,4] == 0 && pole[1,5] == 0 && pole[2,5] == 0) 
                                {
                                    pole[0,4] =1; pole[1,4] = 1; pole[1,5] = 1; pole[2,5] = 1;
                                    kordCol = 4; kordRow = 1; poloj = 1;
                                }
                                    
                            else exit += 1;
                            poloj = 1;
                        }
                    else // palka
                        {
                            if (pole[0,4] == 0 && pole[1,4] == 0 && pole[2,4] == 0 && pole[3,4] == 0 && pole[4,4] == 0 ) 
                                {
                                    pole[0,4] =1; pole[1,4] = 1; pole[2,4] = 1; pole[3,4] = 1; pole[4,4] = 1;
                                    kordCol = 4; kordRow = 2; poloj = 1;
                                }
                            else exit += 1;
                            poloj = 1;
                        }
                }
            }
        }
        newFigura = 0;
    }
//повроты фигур
void PovorotKvadrat(int kR, int kC, int p) //  поворот квадрат
    {
        if ( p == 1) poloj += 1;
        else
        {
            if (p == 2) poloj+= 1;
            else
            {
                if (p == 3) poloj += 1;
                else /*p == 4 */ poloj =1;
            }
        }
    }
void PovorotTank(int kR, int kC, int p)  // поворот танк
    {
        if ( p == 1 )
            {
                if ( pole[kR , kC - 1] == 0) 
                    {
                        pole[kR , kC - 1] = 1;
                        pole[kR - 1, kC] = 0;
                        poloj += 1;
                    }
            }
        else
            {
                if ( p == 2 )
                    {
                        if (pole[kR - 1, kC] == 0)
                            {
                                pole[kR - 1, kC] = 1;
                                pole[kR , kC + 1] = 0;
                                poloj += 1;
                            }
                    }
                else
                {
                    if ( p == 3)
                        {
                            if ( pole[kR, kC + 1] == 0)
                                {
                                    pole[kR, kC + 1] = 1;
                                    pole[kR + 1, kC] = 0;
                                    poloj += 1;
                                }
                        }
                    else //p == 4
                    {
                        if (pole[kR + 1, kC] == 0)
                            {
                                pole[kR + 1, kC] = 1;
                                pole[kR, kC - 1] = 0;
                                poloj = 1;
                            }
                    }
                }
            }

    }
void PovorotKon(int kR, int kC, int p) //поворот конь
    {
       if ( p == 1 )
            {
                if ( pole[kR , kC - 1] == 0 && pole[kR , kC + 1] == 0 && pole[kR + 1, kC + 1] == 0) 
                    {
                        pole[kR , kC - 1] = 1;
                        pole[kR , kC + 1] = 1;
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR - 1, kC] = 0;
                        pole[kR - 1, kC + 1] = 0;
                        pole[kR + 1, kC] = 0;
                        poloj += 1;
                    }
            }
        else
            {
                if ( p == 2 )
                    {
                        if (pole[kR - 1, kC] == 0 && pole[kR + 1, kC -1] == 0 && pole[kR + 1, kC] == 0)
                            {
                                pole[kR - 1, kC] = 1;
                                pole[kR + 1, kC -1] = 1;
                                pole[kR + 1, kC] = 1;
                                pole[kR + 1 , kC + 1] = 0;
                                pole[kR , kC - 1] = 0;
                                pole[kR , kC + 1] = 0;
                                poloj += 1;
                            }
                    }
                else
                {
                    if ( p == 3)
                        {
                            if ( pole[kR, kC + 1] == 0 && pole[kR, kC - 1] == 0 && pole[kR - 1, kC - 1] == 0)
                                {
                                    pole[kR, kC + 1] = 1;
                                    pole[kR, kC - 1] = 1;
                                    pole[kR - 1, kC - 1] = 1;
                                    pole[kR - 1, kC] = 0;
                                    pole[kR + 1, kC] = 0;
                                    pole[kR + 1, kC - 1] = 0;
                                    poloj += 1;
                                }
                        }
                    else //p == 4
                    {
                        if (pole[kR + 1, kC] == 0 && pole[kR - 1, kC + 1] == 0 && pole[kR - 1, kC] == 0)
                            {
                                pole[kR + 1, kC] = 1;
                                pole[kR - 1, kC + 1] = 1;
                                pole[kR - 1, kC] = 1;
                                pole[kR, kC + 1] = 0;
                                pole[kR, kC - 1] = 0;
                                pole[kR - 1, kC - 1] = 0;
                                poloj = 1;
                            }
                    }
                }
            } 
    }
void PovorotZ(int kR, int kC, int p) // поворот Z
    {
        if ( p == 1 )
            {
                if ( pole[kR + 1, kC] == 0 && pole[kR + 1, kC - 1] == 0) 
                    {
                        pole[kR + 1, kC] = 1;
                        pole[kR + 1, kC - 1] = 1;
                        pole[kR - 1, kC] = 0;
                        pole[kR + 1, kC + 1] = 0;
                        poloj += 1;
                    }
            }
        else// p ==2
            {
                if ( pole[kR - 1, kC] == 0 && pole[kR + 1, kC + 1] == 0) 
                    {
                        pole[kR + 1, kC] = 0;
                        pole[kR + 1, kC - 1] = 0;
                        pole[kR - 1, kC] = 1;
                        pole[kR + 1, kC + 1] = 1;
                        poloj = 1;
                    }
            }
    }
void PovorotPalka(int kR, int kC, int p) // поворот палка
 {
        if ( p == 1 )
            {
                if ( pole[kR , kC - 2] == 0 && pole[kR , kC - 1] == 0 && pole[kR , kC + 1] == 0 && pole[kR , kC + 2] == 0) 
                    {
                        pole[kR , kC - 2] = 1;
                        pole[kR , kC - 1] = 1;
                        pole[kR , kC + 1] = 1;
                        pole[kR , kC + 2] = 1;
                        pole[kR - 2, kC] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR + 1, kC] = 0;
                        pole[kR + 2, kC] = 0;
                        poloj += 1;
                    }
            }
        else// p ==2
            {
                if ( pole[kR - 2, kC] == 0 && pole[kR - 1, kC] == 0 && pole[kR + 1, kC] == 0 && pole[kR + 2, kC] == 0) 
                    {
                        pole[kR , kC - 2] = 0;
                        pole[kR , kC - 1] = 0;
                        pole[kR , kC + 1] = 0;
                        pole[kR , kC + 2] = 0;
                        pole[kR - 2, kC] = 1;
                        pole[kR - 1, kC] = 1;
                        pole[kR + 1, kC] = 1;
                        pole[kR + 2, kC] = 1;
                        poloj = 1;
                    }
            }
    }
// фигура идет в лево право
void GoRaitKvadrat(int kR, int kC, int p)// квадрат идет на право
    {
        if (pole[kR, kC +2] == 0 && pole[kR -1, kC +2] == 0)
            {
                pole[kR, kC +2] = 1;
                pole[kR -1, kC +2] = 1;
                pole[kR, kC] = 0;
                pole[kR - 1, kC] = 0;
                kordCol += 1;
            }
    }
void GoLeftKvadrat(int kR, int kC, int p)// квадрат идет на лево
{
if (pole[kR, kC - 1] == 0 && pole[kR -1, kC - 1] == 0)
            {
                pole[kR, kC - 1] = 1;
                pole[kR -1, kC - 1] = 1;
                pole[kR, kC + 1] = 0;
                pole[kR - 1, kC+ 1] = 0;
                kordCol -= 1;
            }
}

void GoRaitTank(int kR, int kC, int p)//идет на право танк
    {
        if (p == 1)
            {
                if (pole[kR + 1, kC + 1] == 0 && pole[kR - 1, kC + 1] == 0 && pole[kR, kC + 2] == 0 )
                    {
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR - 1, kC + 1] = 1;
                        pole[kR, kC + 2] = 1;
                        pole[kR + 1, kC] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC] = 0;
                        kordCol += 1;
                    }
            }
        else
        {
            if (p == 2)
            {
                if (pole[kR, kC + 2] == 0 && pole[kR + 1, kC + 1] == 0 )
                    {
                        pole[kR, kC + 2] = 1;
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR, kC - 1] = 0;
                        pole[kR + 1, kC] = 0;
                        kordCol += 1;
                    }
            }
            else
            {
                if (p == 3)
                {
                if (pole[kR + 1, kC + 1] == 0 && pole[kR - 1, kC + 1] == 0 && pole[kR, kC + 1] == 0 )
                    {
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR - 1, kC + 1] = 1;
                        pole[kR, kC + 1] = 1;
                        pole[kR + 1, kC ] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC - 1] = 0;
                        kordCol += 1;
                    }
                }
                else // p == 4
                {
                if (pole[kR, kC + 2] == 0 && pole[kR - 1, kC + 1] == 0 )
                    {
                        pole[kR, kC + 2] = 1;
                        pole[kR - 1, kC + 1] = 1;
                        pole[kR, kC - 1] = 0;
                        pole[kR - 1, kC] = 0;
                        kordCol += 1;
                    }
                }
            }
        }
    }
void GoLeftTank(int kR, int kC, int p) // идет на лево танк
{
        if (p == 1)
            {
                if (pole[kR + 1, kC - 1] == 0 && pole[kR - 1, kC - 1] == 0 && pole[kR, kC - 1] == 0 )
                    {
                        pole[kR + 1, kC - 1] = 1;
                        pole[kR - 1, kC - 1] = 1;
                        pole[kR, kC - 1] = 1;
                        pole[kR + 1, kC] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC + 1 ] = 0;
                        kordCol -= 1;
                    }
            }
        else
        {
            if (p == 2)
            {
                if (pole[kR, kC - 2] == 0 && pole[kR + 1, kC - 1] == 0 )
                    {
                        pole[kR, kC - 2] = 1;
                        pole[kR + 1, kC - 1] = 1;
                        pole[kR, kC + 1] = 0;
                        pole[kR + 1, kC] = 0;
                        kordCol -= 1;
                    }
            }
            else
            {
                if (p == 3)
                {
                if (pole[kR + 1, kC - 1] == 0 && pole[kR - 1, kC - 1] == 0 && pole[kR, kC - 2] == 0 )
                    {
                        pole[kR + 1, kC - 1] = 1;
                        pole[kR - 1, kC - 1] = 1;
                        pole[kR, kC - 2] = 1;
                        pole[kR + 1, kC ] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC ] = 0;
                        kordCol -= 1;
                    }
                }
                else // p == 4
                {
                if (pole[kR, kC - 2] == 0 && pole[kR - 1, kC - 1] == 0 )
                    {
                        pole[kR, kC - 2] = 1;
                        pole[kR - 1, kC - 1] = 1;
                        pole[kR, kC + 1] = 0;
                        pole[kR - 1, kC] = 0;
                        kordCol -= 1;
                    }
                }
            }
        }
}

void GoRaitKon(int kR, int kC, int p)//идет на право конь
{
    if (p == 1)
            {
                if (pole[kR, kC + 1] == 0 && pole[kR + 1, kC + 1] == 0 && pole[kR - 1, kC + 2] == 0 )
                    {
                        pole[kR, kC + 1] = 1;
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR - 1, kC + 2] = 1;
                        pole[kR + 1, kC] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC] = 0;
                        kordCol += 1;
                    }
            }
        else
        {
            if (p == 2)
            {
                if (pole[kR, kC + 2] == 0 && pole[kR + 1, kC + 2] == 0 )
                    {
                        pole[kR, kC + 2] = 1;
                        pole[kR + 1, kC + 2] = 1;
                        pole[kR + 1, kC + 1] = 0;
                        pole[kR , kC - 1] = 0;
                        kordCol += 1;
                    }
            }
            else
            {
                if (p == 3)
                {
                if (pole[kR + 1, kC + 1] == 0 && pole[kR - 1, kC + 1] == 0 && pole[kR, kC + 1] == 0 )
                    {
                        pole[kR + 1, kC + 1] = 1;
                        pole[kR - 1, kC + 1] = 1;
                        pole[kR, kC + 1] = 1;
                        pole[kR - 1, kC ] = 0;
                        pole[kR + 1, kC - 1] = 0;
                        pole[kR, kC] = 0;
                        kordCol += 1;
                    }
                }
                else // p == 4
                {
                if (pole[kR, kC + 2] == 0 && pole[kR - 1, kC] == 0 )
                    {
                        pole[kR, kC + 2] = 1;
                        pole[kR - 1, kC] = 1;
                        pole[kR, kC - 1] = 0;
                        pole[kR - 1, kC - 1] = 0;
                        kordCol += 1;
                    }
                }
            }
        }
}
void GoLeftKon(int kR, int kC, int p)//идет на лево конь
{
            if (p == 1)
            {
                if (pole[kR + 1, kC - 1] == 0 && pole[kR - 1, kC - 1] == 0 && pole[kR, kC - 1] == 0 )
                    {
                        pole[kR + 1, kC - 1] = 1;
                        pole[kR - 1, kC - 1] = 1;
                        pole[kR, kC - 1] = 1;
                        pole[kR + 1, kC] = 0;
                        pole[kR, kC] = 0;
                        pole[kR - 1, kC + 1 ] = 0;
                        kordCol -= 1;
                    }
            }
        else
        {
            if (p == 2)
            {
                if (pole[kR + 1, kC] == 0 && pole[kR, kC - 2] == 0 )
                    {
                        pole[kR, kC - 2] = 1;
                        pole[kR + 1, kC] = 1;
                        pole[kR, kC + 1] = 0;
                        pole[kR + 1, kC + 1] = 0;
                        kordCol -= 1;
                    }
            }
            else
            {
                if (p == 3)
                {
                if (pole[kR, kC - 1] == 0 && pole[kR - 1, kC - 1] == 0 && pole[kR + 1, kC - 2] == 0 )
                    {
                        pole[kR, kC - 1] = 1;
                        pole[kR - 1, kC - 1] = 1;
                        pole[kR + 1, kC - 2] = 1;
                        pole[kR + 1, kC ] = 0;
                        pole[kR - 1, kC] = 0;
                        pole[kR, kC ] = 0;
                        kordCol -= 1;
                    }
                }
                else // p == 4
                {
                if (pole[kR, kC - 2] == 0 && pole[kR - 1, kC - 2] == 0 )
                    {
                        pole[kR, kC - 2] = 1;
                        pole[kR - 1, kC - 2] = 1;
                        pole[kR, kC + 1] = 0;
                        pole[kR - 1, kC - 1] = 0;
                        kordCol -= 1;
                    }
                }
            }
        }
}

void GoRaitZ(int kR, int kC, int p)//идет на право z
{
    if( p == 1)
    {
        if (pole[kR - 1, kC + 1] == 0 && pole[kR, kC + 2] == 0 && pole[kR + 1, kC + 2] == 0)
        {
            pole[kR - 1, kC + 1] = 1;
            pole[kR + 1, kC + 2] = 1;
            pole[kR, kC + 2] = 1;
            pole[kR, kC] = 0;
            pole[kR - 1, kC] = 0;
            pole[kR + 1, kC + 1] = 0;
            kordCol += 1;
        }
    }
    else // p == 2
    {
        if (pole[kR + 1, kC + 1] == 0 && pole[kR, kC + 2] == 0)
        {
            pole[kR + 1, kC + 1] = 1;
            pole[kR, kC + 2] = 1;
            pole[kR, kC] = 0;
            pole[kR + 1, kC - 1] = 0;
            kordCol += 1;
        }
    }
}
void GoLeftZ(int kR, int kC, int p) // идет на лево z
{
    if( p == 1)
    {
        if (pole[kR - 1, kC - 1] == 0 && pole[kR, kC - 1] == 0 && pole[kR + 1, kC] == 0)
        {
            pole[kR - 1, kC - 1] = 1;
            pole[kR, kC - 1] = 1;
            pole[kR + 1, kC] = 1;
            pole[kR - 1, kC] = 0;
            pole[kR, kC + 1] = 0;
            pole[kR + 1, kC + 1] = 0;
            kordCol -= 1;
        }
    }
    else // p == 2
    {
         if (pole[kR, kC - 1] == 0 && pole[kR + 1, kC - 2] == 0)
        {
            pole[kR + 1, kC - 2] = 1;
            pole[kR, kC - 1] = 1;
            pole[kR + 1, kC] = 0;
            pole[kR, kC + 1] = 0;
            kordCol -= 1;
        }
    }
}

void GoRaitPalka(int kR, int kC, int p)//идет на право палка
{
    if( p == 1)
    {
        if (pole[kR - 2,kC + 1] == 0 && pole[kR - 1,kC + 1] == 0 && pole[kR,kC + 1] == 0 && pole[kR + 1,kC + 1] == 0 && pole[kR + 2,kC + 1] == 0)
        {
            pole[kR - 2, kC + 1] = 1; pole[kR -1, kC + 1] = 1; pole[kR, kC + 1] = 1; pole[kR + 1, kC + 1] = 1; pole[kR + 2, kC + 1] = 1;
            pole[kR - 2, kC] = 0; pole[kR - 1, kC] = 0; pole[kR, kC] = 0; pole[kR + 1, kC] = 0; pole[kR + 2, kC] = 0;
            kordCol += 1;
        }
    }
    else // p == 2
    {
        if(pole[kR, kC + 3] == 0)
        {
            pole[kR, kC + 3] = 1;
            pole[kR, kC - 2] = 0;
            kordCol += 1;
        }
    }
}
void GoLeftPalka(int kR, int kC, int p)//идет на лево палка
{
    if( p == 1)
    {
        if (pole[kR - 2,kC  - 1] == 0 && pole[kR - 1,kC - 1] == 0 && pole[kR, kC - 1] == 0 && pole[kR + 1,kC - 1] == 0 && pole[kR + 2,kC - 1] == 0)
        {
            pole[kR - 2, kC - 1] = 1; pole[kR -1, kC - 1] = 1; pole[kR, kC - 1] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 2, kC - 1] = 1;
            pole[kR - 2, kC] = 0; pole[kR - 1, kC] = 0; pole[kR, kC] = 0; pole[kR + 1, kC] = 0; pole[kR + 2, kC] = 0;
            kordCol -= 1;
        }
    }
    else // p == 2
    {
        if(pole[kR, kC - 3] == 0)
        {
            pole[kR, kC - 3] = 1;
            pole[kR, kC + 2] = 0;
            kordCol -= 1;
        }
    }
}
// спуск
void GoDounKvadrat(int kR, int kC, int p) // спуск квадрат
    {
        if ( pole[kR + 1, kC] == 0 && pole[kR + 1, kC + 1] == 0)
            {
                pole[kR + 1, kC] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR - 1, kC] = 0; pole[kR - 1, kC + 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
    }

void GoDounTank(int kR, int kC, int p) // спуск танк
{
    if(p == 1)
        {
            if (pole[kR + 2, kC] == 0 && pole[kR + 1, kC + 1] == 0)
            {
                pole[kR + 2, kC] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR - 1, kC] = 0; pole[kR, kC + 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
        }
    else
    {
        if(p == 2)
        {
            if (pole[kR + 2, kC] == 0 && pole[kR + 1, kC - 1] == 0 && pole[kR + 1, kC + 1] == 0)
            {
                pole[kR + 2, kC] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR, kC] = 0; pole[kR, kC + 1] = 0; pole[kR, kC - 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
        }
        else
        {
            if (p == 3)
                {
                if (pole[kR + 2, kC] == 0 && pole[kR + 1, kC - 1] == 0)
                {
                    pole[kR + 2, kC] = 1; pole[kR + 1, kC - 1] = 1;
                    pole[kR - 1, kC] = 0; pole[kR, kC - 1] = 0;
                    kordRow += 1;
                }
                else newFigura +=1;
                }
            else // p == 4
                {
                if (pole[kR + 1, kC] == 0 && pole[kR + 1, kC - 1] == 0 && pole[kR + 1, kC + 1] == 0)
                {
                pole[kR + 1, kC] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR - 1, kC] = 0; pole[kR, kC + 1] = 0; pole[kR, kC - 1] = 0;
                kordRow += 1;
                }
                else newFigura +=1;
                }
        }
    }
}

void GoDounKon(int kR, int kC, int p) // спуск конь
{
    if(p == 1)
        {
            if (pole[kR + 2, kC] == 0 && pole[kR, kC + 1] == 0)
            {
                pole[kR + 2, kC] = 1; pole[kR, kC + 1] = 1;
                pole[kR - 1, kC] = 0; pole[kR - 1, kC + 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
        }
    else
    {
        if(p == 2)
        {
            if (pole[kR + 2, kC + 1] == 0 && pole[kR + 1, kC - 1] == 0 && pole[kR + 1, kC] == 0)
            {
                pole[kR + 2, kC + 1] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 1, kC] = 1;
                pole[kR, kC] = 0; pole[kR, kC + 1] = 0; pole[kR, kC - 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
        }
        else
        {
            if (p == 3)
                {
                if (pole[kR + 2, kC] == 0 && pole[kR + 2, kC - 1] == 0)
                {
                    pole[kR + 2, kC] = 1; pole[kR + 2, kC - 1] = 1;
                    pole[kR - 1, kC] = 0; pole[kR + 1, kC - 1] = 0;
                    kordRow += 1;
                }
                else newFigura +=1;
                }
            else // p == 4
                {
                if (pole[kR + 1, kC] == 0 && pole[kR + 1, kC - 1] == 0 && pole[kR + 1, kC + 1] == 0)
                {
                pole[kR + 1, kC] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR - 1, kC - 1] = 0; pole[kR, kC] = 0; pole[kR, kC + 1] = 0;
                kordRow += 1;
                }
                else newFigura +=1;
                }
        }
    }
}

void GoDounZ(int kR, int kC, int p) // спуск Z
{
    if (p == 1)
        {
            if (pole[kR + 1, kC] == 0 && pole[kR + 2, kC + 1] == 0)
            {
                pole[kR + 1, kC] = 1; pole[kR + 2, kC + 1] = 1;
                pole[kR - 1, kC] = 0; pole[kR, kC + 1] = 0;
                kordRow += 1;
            }
            else newFigura +=1;
        }
    else //(p == 2)
        {
                if (pole[kR + 2, kC] == 0 && pole[kR + 2, kC - 1] == 0 && pole[kR + 1, kC + 1] == 0)
                {
                pole[kR + 2, kC] = 1; pole[kR + 2, kC - 1] = 1; pole[kR + 1, kC + 1] = 1;
                pole[kR + 1, kC - 1] = 0; pole[kR, kC + 1] = 0; pole[kR, kC] = 0;
                kordRow += 1;
                }
                else newFigura +=1;
        }   
    }

void GoDounPalka(int kR, int kC, int p) // спуск палка
{
    if (p == 1)
        {
            if (pole[kR + 3, kC] == 0)
                {
                    pole[kR + 3, kC] = 1;
                    pole[kR - 2, kC] = 0;
                    kordRow += 1;
                }
            else newFigura +=1;
        }
    else //(p == 2)
    {
        if (pole[kR + 1, kC - 2] == 0 && pole[kR + 1, kC - 1] == 0 && pole[kR + 1, kC] == 0 && pole[kR + 1, kC + 1] == 0 && pole[kR + 1, kC + 2] == 0)
                {
                    pole[kR + 1, kC -2] = 1; pole[kR + 1, kC - 1] = 1; pole[kR + 1, kC] = 1; pole[kR + 1, kC + 1] = 1; pole[kR + 1, kC + 2] = 1;
                    pole[kR, kC - 2] = 0; pole[kR, kC - 1] = 0; pole[kR, kC] = 0; pole[kR, kC + 1] = 0; pole[kR, kC + 2] = 0;
                    kordRow += 1;
                }
            else newFigura +=1;
    }
}

// удаляем строку
void DeleteRaw()
{
    for (int i = (20); i >= 0; i -- ) // бежим по строкам с конца в начало
        {
           if(pole[i, 1] == 1 &&  pole[i, 2] == 1 && pole[i, 3] == 1 && pole[i, 4] == 1 && pole[i, 5]  == 1 && pole[i, 6] == 1 && pole[i, 7] == 1 && pole[i, 8] == 1 && pole[i, 9] == 1 && pole[i, 10] == 1)
            {
                for (int count = i; count > 0; count --) // опускае все строки на 1 вниз
                    {
                        for(int j = 0; j < 12; j ++)
                            {
                                pole[count, j] = pole[count - 1, j];
                            }                       
                    }
                pole[0, 1] = 0; pole[0, 2] = 0; pole[0, 3] = 0; pole[0, 4] = 0; 
                pole[0, 5] = 0; pole[0, 6] = 0; pole[0, 7] = 0; pole[0, 8] = 0; 
                pole[0, 9] = 0; pole[0, 10] = 0; // строке 0 присваиваем все 0
            
            }
        }
}

Console.Clear();
PrintArray(pole);

while( exit == 0 ) // игра запускается
{// проверяем пройгрыш
    Console.Clear();
    DeleteRaw();// удаляем собраные строки
    PrintArray(pole); // выводим результат
    while ( newFigura == 0) // управляем фигурой 
        {
            Console.Write("Введите число");
            go = Convert.ToInt16(Console.ReadLine());
            if ( go == 0 ) // поворот
                {
                    if ( figura == 0 ) 
                        {
                            PovorotKvadrat(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                    if ( figura == 1 ) 
                        {
                            PovorotTank(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                    if ( figura == 2 ) 
                        {
                            PovorotKon(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                    if ( figura == 3 ) 
                        {
                        PovorotZ(kordRow, kordCol, poloj);
                        Console.Clear();
                        PrintArray(pole);
                        Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                    if ( figura == 4 ) 
                        {
                            PovorotPalka(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                }
            else
            {
                if ( go == 1 ) // лево
                    {
                        if ( figura == 0 ) 
                            {    
                            GoLeftKvadrat(kordRow, kordCol, poloj);   
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                            }
                        if ( figura == 1 ) 
                            {
                                GoLeftTank(kordRow, kordCol, poloj);
                                Console.Clear();
                                PrintArray(pole);
                                Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                            }
                        if ( figura == 2 ) 
                            {
                                GoLeftKon(kordRow, kordCol, poloj);
                                 Console.Clear();
                                PrintArray(pole);
                                Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                            }
                        if ( figura == 3 ) 
                        {
                            GoLeftZ(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        if ( figura == 4 ) 
                        {
                            GoLeftPalka(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                    }
                else
                {
                    if ( go == 2 ) // право
                        {
                        if ( figura == 0 ) 
                        {
                            GoRaitKvadrat(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        if ( figura == 1 ) 
                        {
                            GoRaitTank(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        if ( figura == 2 ) 
                        {
                            GoRaitKon(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        if ( figura == 3 ) 
                        {
                            GoRaitZ(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        if ( figura == 4 ) 
                        {
                            GoRaitPalka(kordRow, kordCol, poloj);
                            Console.Clear();
                            PrintArray(pole);
                            Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                        }
                        }
                    else
                    {
                        if ( go == 3 ) // вниз
                            {
                                if ( figura == 0 ) 
                                {
                                    GoDounKvadrat(kordRow, kordCol, poloj);
                                    Console.Clear();
                                    PrintArray(pole);
                                    Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                                }
                                if ( figura == 1 ) 
                                {
                                    GoDounTank(kordRow, kordCol, poloj);    
                                    Console.Clear();
                                    PrintArray(pole);
                                    Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                                }
                                if ( figura == 2 ) 
                                {
                                    GoDounKon(kordRow, kordCol, poloj);
                                    Console.Clear();
                                    PrintArray(pole);
                                    Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                                }
                                if ( figura == 3 ) 
                                {
                                    GoDounZ(kordRow, kordCol, poloj);
                                    Console.Clear();
                                    PrintArray(pole);
                                    Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                                }
                                if ( figura == 4 ) 
                                {   
                                    GoDounPalka(kordRow, kordCol, poloj);
                                    Console.Clear();
                                    PrintArray(pole);
                                    Console.WriteLine("введите команду 0 - повород, 1 - влево, 2 - вправо, 3 - вниз");
                                }
                            }
                        else // пользователь ввел не то число
                        {
                            Console.WriteLine("Enter number from 0 to 3 ");
                        }
                    }
                }
            }
        }
figura = new Random().Next(0,5); // рандом выбирает фигуру
Console.Clear();
NewFigura(figura); //создаем новую фигуру
Console.Clear();
PrintArray(pole);
}

