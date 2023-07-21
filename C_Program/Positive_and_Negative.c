#include<stdio.h>
void main()
{
	int num;
	
	printf("Enter your Number ");
	scanf("%d", &num);
	
	if (num==0)
	{
		printf("Number is Nuetral");
	}
	else if (num>0)
	{
		printf("Number is Possitive");
	}
	else
	{
		printf("Number is negative");
	}
}
//1. start
//2.Declare no.
//3. input number
//4. if number is ==0 
//	4.1 print the no. is 0
//	4.2 got to step 7
//5. if number> 0
//	5.1 number is positive 
//	5.2 jump to step 7
//6. else print number is negative
//	6.1 jumo to step 7
//7. Stop
