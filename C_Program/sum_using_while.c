#include<stdio.h>
int main()
{
	int num=10;
	int sum=0;
	
	while(num<=20)
	{
		sum = sum+num;
		num=num+1;
	}
	printf("%d", sum);
	return 0;
}
