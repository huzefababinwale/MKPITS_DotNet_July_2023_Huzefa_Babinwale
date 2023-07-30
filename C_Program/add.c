#include<stdio.h>
void addition(int n1, int n2)
{
	int results = n1+n2;
	printf("results are, %d ", results);
}
void main()
{
	int num1, num2;
	printf("Enter the no.");
	scanf("%d%d",&num1, &num2);
	addition(num1, num2);
	printf("\n Completed ");
}
