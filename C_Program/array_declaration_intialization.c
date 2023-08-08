#include<stdio.h>
void main()
{
	int i;
	int marks[3]={99,85,95};
	int sum=0;
	
	for (i=0;i<3;i++)
	{
		printf("\n marks=%d", marks[i]);
		sum = sum+marks[i];
	}
	printf("\n Sum of marks = %d", sum);
	
	
}
