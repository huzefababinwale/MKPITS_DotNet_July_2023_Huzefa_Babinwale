#include<stdio.h>
void factorial(int a)
{
	int fact=1, i;
	
	for (i=1;i<=a;i++)
	{
		fact=fact*i;
		
	}
	printf("%d",fact);	
}
	
void main()
{
	int a;
	printf("Enter a No. to generate Factorial");
	scanf("%d",&a);
	factorial(a);
}
	

