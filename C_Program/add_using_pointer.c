#include<stdio.h>
#include<string.h>

void main()
{
	int num1 , num2, add;
	int *ptr;
	printf("Enter first no.: ");
	scanf("%d",&num1);
	printf("Enter Second no.: ");
	scanf("%d",&num2);
	add = num1+num2;
	ptr=add;
	printf("Addition of two no. is = %d",ptr);
}
