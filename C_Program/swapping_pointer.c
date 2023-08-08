#include<stdio.h>
void main()
{
	int num1=6;
	int num2=40;
	int *pointer1= &num1;  
	int *pointer2= &num2;
	
	printf("Value stored in pointer is equal to %d %d\n ",*pointer1, *pointer2);
//	int temp = *pointer1;
//	
//	*pointer1=*pointer2;
//	*pointer2= temp;
//	printf("Value stored in pointer is equal to %d %d", *pointer1, *pointer2);
	
	*pointer1=*pointer1+*pointer2;
	*pointer2=*pointer1-*pointer2;
	*pointer1=*pointer1-*pointer2;
	printf("value after swapping is %d %d ",*pointer1,*pointer2);
}



