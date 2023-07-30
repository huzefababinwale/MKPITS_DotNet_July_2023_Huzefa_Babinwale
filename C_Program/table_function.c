#include<stdio.h>
void table(int a)
{
	int i, tab;
	for (i=1;i<=10;i++)
	{
		tab=i*a;
		printf("\n%d=%d*%d",tab,i,a);
	}
	
}
void main()
{
	int a;
	printf("Enter the no. to print table : ");
	scanf("%d",&a);
	table(a);
}
