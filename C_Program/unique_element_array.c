#include<stdio.h>
void main()
{
	char name[5];
	int cnt, i, j;
	
	for(i=0;i<5;i++)
	{
		printf("Enter values: ");
		gets(name);
	}
	
	for (i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(name[i]!=name[j])
			{
				cnt++;
				
			}
		}
		
	}
	printf("Count of unique values are : %d",cnt);
}
