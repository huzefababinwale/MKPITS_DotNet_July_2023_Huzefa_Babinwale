#include<iostream>
using namespace std;
class Bank_account
{
	public:
		int account_no;
		int Balance=0;
		int amount=0;
//	int depo=0 ;
	
	void deposit()
	{
		cout<<"Enter ammount to be Deposited in account"<<endl;
		cin>>amount;
		if (amount>=1)
		{
			Balance=Balance+amount;
		}
	}
	void withdrawl()
	{
		cout<<"Enter ammount to be Withdrawl"<<endl;
		cin>>amount;
		if (amount>=1)
		{
			Balance=Balance-amount;
		}
	}
	void balance()
	{
		cout<<"Ammount Remaining in Your Account is = ";
		cout<<Balance<<endl;
	}
};
int main()
{
	int amount, Balance;
	Bank_account b1; 
	b1.deposit();
	b1.withdrawl();
	b1.balance();
}
