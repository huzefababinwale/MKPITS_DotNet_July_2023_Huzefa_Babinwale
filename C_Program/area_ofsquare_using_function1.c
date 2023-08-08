//area_ofsquare_using_function1.c
#include<stdio.h>

int area(int side)
{
	int area = side*side;
	return area;
}
void main()
{
	int side;
	
	int result;
	printf("Enter Length of one side of Rectangle: ");
	scanf("%d",&side);
	result= area(side);
	printf("Area of square = %d sq.ft.", result);
}


