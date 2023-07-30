#include<stdio.h>
int main()
{
	int counter=1, sum=0;
	
	while (counter<=5)
	{
		sum = sum+counter;
		counter = counter+1;
	}
	printf("%d",sum);
}
