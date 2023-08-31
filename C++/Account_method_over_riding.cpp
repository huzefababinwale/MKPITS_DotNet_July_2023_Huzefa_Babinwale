#include<iostream>
using namespace std;
class Account
{
	public :
		int actno;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"hello from account deposit "<<endl;
		}
};

class Saving : public Account
{
	public :
		void deposit(int amt)
		{
			int bal=0;
			int interest =100;
			bal = bal+amt+interest;
			cout<<"Hello from Saving, account Balance is : "<<bal<<endl;
		}
};

class Current : public Account
{
	
	public:
		void deposite(int amt)
		{
			bal = bal +amt;
			cout<<"bal without interest "<<bal<<endl;
		}
};

int main()
{
	Account *A;
	Saving S;
	Current C;
	A=&S;
	A->actno=123;
	A->bal=100;
	A->deposit(100);
	A=&C;
	A->actno=233;
	A->bal=100;
	A->deposit(100);
	return 0;
}

