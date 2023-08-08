#include<stdio.h>
void main()
{
	int arr[5];
	int fre[5];
	int i, j,cnt;
	
	for( i=0; i<5; i++)
	{
		printf("Enter no.: ");
		scanf("%d",&arr[i]);
		fre[i]=0;
	}
	for (i=0;i<5;i++)
	{
		cnt=1;
		for(j=i+1; j<5; j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				fre[j]=0;
				
			}
		}
		if (fre[i] !=0 )
		{
			fre[i]= cnt;
		}
		
	}
	for(i=0;i<5;i++)
	{
		if(fre[i]!=0)
		{
			printf("Frequency of %d is %d times \n", arr[i], fre[i]);
		}
	}
}
