#include<stdio.h>
void main()
{
	int num1, num2, num3, result;
	printf("Enter first number: ");
	scanf("%d", &num1);
	
	printf("Enter Second number: ");
	scanf("%d",&num2);
	
	printf("Enter Third number: ");
	scanf("%d",&num3);
	
	result=num1+num2+num3;
	
	printf("Total of given three numbers is %d", result);
}
