#include<stdio.h>
void main()
{
	int prize, quantity, total, discounted_prize;
	char name[10], product_name[20];
	
	printf("Enter Your Name: \n");
	scanf("%s",&name);
	printf("Product Name: \n");
	scanf("%s",&product_name);
	printf("Enter product prize: \n");
	scanf("%d",&prize);
	printf("Enter Quantity of Product: \n");
	scanf("%d",&quantity);
	
	total= quantity*prize;
	
	if (total>=1000)
	{
		discounted_prize= (total*40/100);
		total = total-discounted_prize;
		printf("Total Payable amount is %d",total);
	}
	else if (total>=500)
	{
		discounted_prize= (total*25/100);
		total = total-discounted_prize;
		printf("Total Payable amount is %d",total);
	}
	else 
	{
		discounted_prize= (total*10/100);
		total = total-discounted_prize;
		printf("Total Payable amount is %d",total);
	}
}
