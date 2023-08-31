#include<stdio.h>
int main()
{
	int num=20;
	while (num<=30)
	{
		if (num %2!=0)
		{
			printf("%d \t",num);
		}
		num=num+1;
	}
	return 0;
}

