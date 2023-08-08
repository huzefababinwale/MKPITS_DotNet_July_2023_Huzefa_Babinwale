#include<stdio.h>
void main()
{
	int num = 5;
	int *pointer = &num;
	
	printf("Address of pointer = %x \n");
	printf("Value inside address = %d ",*pointer);
}
