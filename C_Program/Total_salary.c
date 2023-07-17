#include<stdio.h>
void main()
{
	float basic_salary, DA, HRA, total_salary ;
	
	printf("Enter Basic Salary :");
	scanf("%f",&basic_salary);
	
	DA= basic_salary*0.45;
	HRA= basic_salary*0.35;
	total_salary= DA+HRA+basic_salary;
	
	printf("Total Salary of person is = %f",total_salary);
	
	
}
