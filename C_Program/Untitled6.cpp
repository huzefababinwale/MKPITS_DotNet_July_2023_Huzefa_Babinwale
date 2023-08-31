#include<stdio.h>
int main()
{
	int num1, num2, *ptr, *ptr2, result;
	
	printf("Enter two number to add : \n");
	scanf("%d %d", &num1, &num2);
	
	ptr=&num1;
	ptr2=&num2;
	
	result = *ptr+*ptr2;
	printf("result= %d",result);
}
