#include<stdio.h>
void main()
{
	int arr[5];
	int i, j; 
	int cnt=0;
	
	for (i=0;i<5;i++)
	{
		printf("Enter numbers in array list: ");
		scanf("%d", &arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if (arr[i]==arr[j])
			{
				cnt++;
				break;
			}
			
		}
	}
	printf("\n number of duplicates element is = %d ",cnt);
}
