#include<stdio.h>
void main()
{
	int i;
	int sum=0 ;
	int marks[5];
	
	for (i=0;i<5;i++)
	{
		printf("Enter Marks: ",marks[i]);
		scanf("%d",&marks[i]);
		
	}
	for(i=0;i<5;i++)
	{
		printf("marks = %d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n  sum of marks = %d",sum);
}
