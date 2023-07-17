#include<stdio.h>
void main()
{
	float sub1, sub2, sub3, total, percent;
	
	printf("Enter Marks of Three Subjects: \n");
	scanf("%f %f %f", &sub1, &sub2, &sub3);
	
	total= sub1+sub2+sub3;
	percent= (total/300)*100;
	
	printf("Total Marks obtain from 300 is %f and Percentage of Student is %f ",total,percent);
	
}
