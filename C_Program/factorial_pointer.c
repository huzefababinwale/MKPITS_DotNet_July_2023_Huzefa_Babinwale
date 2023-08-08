#include<stdio.h>
#include<string.h>

void main()
{
	int num, fact=1;
	int *n=num;
	printf("Enter a no. to get Factorial: ");
	scanf("%d",&num);
	while (num>0)
	{
		fact= fact*num;
		num=num-1;
	}
	printf("factorial: %d ",fact);

}

