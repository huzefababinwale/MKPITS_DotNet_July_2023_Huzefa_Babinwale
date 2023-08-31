#include<iostream>
using namespace std;

class classA
{
	protected :
		int n1;
	public :
		void getn1(int n)
		{
			n1=n;
		}
};

class classB:public classA
{
	protected:
		int n2;	
	public :
		void getn2(int n)
		{
			n2=n;
		}
};
class classC
{
	protected:
		int n3;
	public:
		void getn3(int n)
		{
			n3=n;
		}
};
class classD:public classB, public classC
{
	public:
		int mul()
		{
			int mu=n1*n2*n3;
			return mu;
		}
};
int main()
{
	classD d;
	int m;
	d.getn1(2);
	d.getn2(3);
	d.getn3(4);
	m=d.mul();
	cout<<"Results are "<<m;
}


