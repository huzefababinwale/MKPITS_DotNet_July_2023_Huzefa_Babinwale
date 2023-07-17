#include<stdio.h>
void main()
{
	int n1, n2;
	
	printf("Enter n1 and n2\n");
	scanf("%d %d", &n1, &n2);
	
	if (n1>n2)
	{
		printf("n1 is Greater than n2");
	}
	else
	{
		printf("n2 is Greater than n1");
	}
}
