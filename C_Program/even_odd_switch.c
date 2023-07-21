#include<stdio.h>
void main()
{
	int num;
	printf("Enter a number: \n");
	scanf("%d",&num);
	num = num%2==0;
	switch (num)
	{
		case 1:
			printf("these is even no.");
			break;
		default:
			printf("\nThese is Odd No. ");
			break;
	}
}

1. Start 
2. declare num 
