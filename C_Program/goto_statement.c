#include<stdio.h>
void main()
{
	int num, i=1 ;
	
	printf("Enter No.");
	scanf("%d", &num);
	
	table:
		printf("\n%d*%d = %d ", num, i, num*i);
		i++;
		
		if (i<=10)
		{
			goto table;
		}
	
}
