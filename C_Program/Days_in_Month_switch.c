#include<stdio.h>
void main()
{
	int month;
		
	printf("Enter the Month number : ");
	scanf("%d", &month);
	
	switch(month)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			printf("No. of Days are 31");
			break;
		case 2:
			printf("No. of Days are 28");
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			printf("No. of Days are 30");
			break;
		default:
			printf("Not intrested");				
		}	
	
}
