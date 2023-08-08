#include<stdio.h>
void main()
{
	int n , i;
	printf("Enter value of n ");
	scanf("%d",&n);
	int num[n];
//	Accepting values

	for (i=0;i<=n-1;i++)
	{
		printf("\n Enter the marks: ");
		scanf("%d",&num[i]);		
	}
	for (i=n-1; i>=0; i--)
	{
		printf("\n num=%d", num[i]);
	}
}
