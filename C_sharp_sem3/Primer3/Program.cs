// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

int aX = 1;
int aY = 1;
int bX = 5;
int bY = 4;

double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
System.Console.WriteLine(result);