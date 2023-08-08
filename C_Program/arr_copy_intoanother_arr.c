#include<stdio.h>
void main()
{
	int n,i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("\n Enter num ");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\n element of array 1 ");
	for(i=0;i<5;i++)
	{
		printf("\n %d", arr1[i]);
	}
	printf("element of array 2: ");
	for(i=0;i<5;i++)
	{
		printf("\n %d",arr2[i]);
	}
	
	
}
