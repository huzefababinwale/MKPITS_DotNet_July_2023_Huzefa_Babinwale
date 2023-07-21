#include<stdio.h>
void main()
{
	int n1, n2, n3;
	
	printf("Enter 3 numbers to compare\n");
	scanf("%d%d%d",&n1, &n2, &n3);
	
	if (n1>n2 && n1>n3)
	{
		printf("n1 %d is Greater than all", n1);
	}
	else if (n1<n2 && n3<n2)
	{
		printf("n2 %d is Greater than all", n2);
	}
	else
	{
		printf("n3 %d is Greater than all", n3);
	}
	return 0;
}
