#include<stdio.h>
void main()
{
	int day_num;
	
	printf("Enter the No.: \n");
	scanf("%d",&day_num);
	
	switch(day_num)
	{
		case 1:
			printf("Monday");
			break;
		case 2:
			printf("Tuesday");
			break;
		case 3:
			printf("Wednesday");
			break;
		case 4:
			printf("Thursday");
			break;
		case 5:
			printf("Friday");
			break;
		case 6:
			printf("Saturday");
			break;
		case 7:
			printf("Sunday");
		default:
			printf("Invalid Number");
			
	}
}
