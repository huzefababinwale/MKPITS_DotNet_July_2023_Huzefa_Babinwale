#include<stdio.h>
struct emp
{
	int emp_id;
	char name[10], designation[10];
	char departmrnt[10];
	int salary;
};

void main()
{
	int i;
	struct emp e[2];
	for (i=0;i<2;i++)
	{
		printf("Enter Employee ID \t  Name \t Designation \t Salary \n");
		scanf("%d\t %s \t %s \t %d",&e[i].emp_id, &e[i].name,&e[i].designation, &e[i].salary);
//		printf("\n Enter Nname: ");
//		scanf("%s",&e[i].name);	
//		printf("\n Enter Designation: ");
//		scanf("%s",&e[i].designation);
//		printf("Enter Salary: ");
//		scanf("%d",e[i].salary);
	}
	printf("\n Employee Details: ");
	for (i=0;i<2;i++)
	{
		printf("Employee ID: %d, Employee Name: %s, Employee Designation: %s, Employee Salary: %d \n",e[i].emp_id, e[i].name, e[i].designation, e[i].salary );
	}
}
