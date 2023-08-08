
#include<stdio.h>
int addition()
{
	int n1, n2, result;
	printf("Enter two number ");
	scanf("%d%d",&n1, &n2);
	result = n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do 
	{
		int result =addition();
		
		printf("Result is = %d\n",result);
		printf("Do you want to continue: Y/N \n");
		fflush(stdin);
		scanf("%c",&ch);	
	}
	while (ch=='y');
	
	
}
