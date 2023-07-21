#include<stdio.h>
void main()
{
	
	int age, eligibility, i;
	char gender, name[100];
	
	i=0;
	
	
	
	printf("Enter The Details of 10 users in form of Name_____Gender____Age \n");
	printf("Gender\tAge\t\n");
	scanf("%c%d",&gender,&age);
	
	if (gender=='m')
	{
		if (age>=21)
		{
			printf("Eligible");	
		}
		else
		{
			printf("Not Eligible");
		}
	}
	else{
		if(age>=18)
		{
			printf("Elligible");
		}
		else{
			printf("Not Eligible");
		}
	}
			
	
	printf("%c %c %d",name, gender, age);
	
}
