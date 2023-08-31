#include<iostream>
using namespace std;

class calculation 
{
	public:
	int add(int x, int y)
	{
		return x+y;
	}
	int add(int x, int y, int z)
	{
		return x+y+z;
	}
};

int main()
{
	calculation C;
	cout<<"addition of two no. "<<C.add(2,3)<<endl;
	cout<<"addition of two no. "<<C.add(5,6,7);
}
