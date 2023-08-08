#include<stdio.h>
int area()
{
	int side;
	printf("Enter the Length of side of Square: ");
	scanf("%d",&side);
	int area=side*side;
	return area;
}

void main()
{
	int side;
	int result=area();
	printf("Area of Square = %d sq.ft. ", result);
}
