#include<stdio.h>
void deposit(int amt, int bal);
void withdrawl(int amt, int bal);

void main()
{
	int amt;
	int bal;
	bal =1000;
	printf("\nEnter ammount: ");
	scanf("%d", &amt);
	deposit(amt, bal);
	withdrawl(amt, bal);
	
}
void deposit(int amt, int bal)
{
	bal=bal+amt;
	printf("balance = %d",bal);
}
void withdrawl(int amt, int bal)
{

	bal = bal-amt;
	printf("Balance ammount =%d",bal);
	
}
	

