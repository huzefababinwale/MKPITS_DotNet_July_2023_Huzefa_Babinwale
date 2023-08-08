#include<stdio.h>
int average(int n1,int n2,int n3,int n4,int n5)
{
	int add= n1+n2+n3+n4+n5;
	int result=add/5;
	
	return result;
}
void main()
{
	int n1,n2,n3,n4,n5;
	printf("Enter 5 no. to get the avarage: ");
//	fflush(stdin);
	scanf("%d%d%d%d%d", &n1, &n2, &n3, &n4, &n5);
	
	
	float result=average(n1,n2,n3,n4,n5);
	printf("Result of average of 5 no. is = %d",result);
	
}
