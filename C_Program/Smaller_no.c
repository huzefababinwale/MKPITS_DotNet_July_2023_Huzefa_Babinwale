#include<stdio.h>
void main()
{
	int n1 , n2;
	printf("Enter n1 and n2");
	scanf("%d %d",&n1,&n2);
	
	if (n1>n2)
	{
		printf("%d is smaller than n1", n2);
	}
	else
	{
		printf("%d is smaller than n2", n1);
	}
}
