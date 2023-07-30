#include<stdio.h>
void prime(int a)
{
	int  i, pri;
	if(a%2==0)
	{
		printf("Its Prime Number");
	}
	else
	{
		printf("it is not a prime number");
	}
}

void main()
{
	int a;
	printf("Enter your no.");
	scanf("%d",&a);
	prime(a);
}
