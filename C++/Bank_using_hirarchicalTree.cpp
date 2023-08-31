#include<iostream>
using namespace std;

class Account
{
	public :
		int acc_no;
		int bal, intrest;
		void get_data(int a, int b, int c)
		{
			acc_no=a;
			bal=b;
			intrest=c;
		}
};

class saving : public Account
{
	public :
		int deposit(int amount)
		{
			bal = bal+intrest+amount;
			return bal;
		}
};
class current: public Account
{
	public :
		int deposit(int amount)
		{
			bal = bal+amount;
			return bal;
		}
};

int main()
{
	saving s1;
	current d1;
	int result, amount, bal, intrest,acc_no;
	
	cout<<"Enter acc details: "<<endl;
	cout<<"Acc_no.\t balance\t intrest\t amount: ";
	cin>>acc_no>>bal>>intrest>>amount;
	s1.get_data(bal,intrest, amount);
	result =s1.deposit(amount);
	cout<<"Saving account balance is: "<<result<<endl;
	
	d1.get_data(bal,intrest,amount);	
	result =d1.deposit(amount);
	cout<<"Current Account Balance is: "<<result;
	return 0;
}

