#include<iostream>
using namespace std;

class Account
{
	public:
		int actno;
		int bal;
	void deposit(int amt)
	{
		cout<<"Hello from Account deposit "<<endl;
	}
};
class Saving : public Account
{
	public:
		void deposit(int amt)
		{
			int interest = 100;
			bal=bal+amt+interest;
			cout<<"Hello from Saving with balance "<<bal<<endl;
		}
};
class Current : public Account
{
	public:
		void deposit(int amt)
		{
			int bal=bal+amt;
			cout<<"balance without interest is: "<<bal<<endl;
		}
};
int main()
{
	Saving S;
	Current C;
	S.actno=456;
	S.bal=100;
	S.deposit(100);
	C.actno=555;
	C.bal=1000;
	C.deposit(1000);
	return 0;
}


