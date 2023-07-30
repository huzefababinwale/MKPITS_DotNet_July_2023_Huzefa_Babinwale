#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
	
}
void kgoto()
{
	printf("Isse Kuch nh hoga\n");
}
void main()
{
	printf("Calling Hello funtion\n");
	kgoto();
	printf("Back in main\n  ");
	sayhello();
	printf("\n Bye");
}
