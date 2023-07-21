#include<stdio.h>
void main()
{
	char name[10];
	char designation;
	int salary;
	
	printf("Enter the Employee name");
	scanf("%s",&name);
	
	printf("Enter Designation (m - Manager\n p-Peon\n c-clerk)");
	fflush(stdin);
	scanf("%c", &designation);
	
	switch(designation)
	{
		case 'm':
			printf("Calculated Salary for Manager is 50,000 ");
			break;
		case 'c':
			printf("Calculated Salary for Clerk is 20,000");
			break;
		case 'p':
			printf("Calculate Salary for Peon is 10,000 ");
			break;
		default:
			printf("Invalid Designation" );
			break;
			
	}
	
}
