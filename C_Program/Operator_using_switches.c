#include<stdio.h>
void main()
{
	int num1, num2, result=0;
	char op;
	
	printf("Enter Two Numbers: \n");
	scanf("%d%d", &num1, &num2);
	printf("Enter the Operator\n");
	fflush(stdin);
	scanf("%c",&op);
	
	switch	(op)
	{
		case '+':
			result = num1+num2;
			break;		
		case '-':
			result = num1-num2;
			break;
		case '*':
			result = num1*num2;
			break;
		case '/':
			result = num1/num2;
		default:
			printf("Invalid operator");
			break;
	}
	printf("result = %d", result);
}
