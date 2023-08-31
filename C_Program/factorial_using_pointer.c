#include<stdio.h>
int main()
{
	int factorial=1;
	int *ptr;
	int num;
	
	printf("Enter no. ");
	scanf("%d",&num);
	ptr=&num;
	
	while(*ptr>0)
	{
		factorial= *ptr *factorial;
		*ptr=*ptr -1;
	}
	printf("%d",factorial);
}
