#include<stdio.h>
void main()
{
	int sub1, sub2, sub3, total;
	
	printf("Enter the Marks of Maths : ");
	scanf("%d",&sub1);
	
	printf("Enter the Marks of Science : ");
	scanf("%d",&sub2);
	
	printf("Enter the Marks of Geography: ");
	scanf("%d",&sub3);
	
	total = sub1+sub2+sub3;
	
	printf("Total obtain Marks of Three Subjects are %d", total);
}
