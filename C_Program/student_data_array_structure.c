#include<stdio.h>
struct student
{
	int rollno;
	char name[100];
	int age;
};
void main()
{
	struct student std[5];
	int i;
	for(i=0;i<5;i++)
	{
		printf("Enter roll number, Nmae & Age of student: ");
		scanf("%d %s %d", &std[i].rollno, &std[i].name, &std[i].age);
	}
	
	printf("\n Student Details: ");
	for (i=0;i<5;i++)
	{
		printf("roll no. = %d, name = %s, & age = %d\n", std[i].rollno, std[i].name, std[i].age);
	}
	
} 
