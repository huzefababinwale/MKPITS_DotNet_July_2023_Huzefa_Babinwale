#include<iostream>
using namespace std;

class calculation 
{
	public:
	int add(int x, int y)
	{
		return x+y;
	}
	float add(float k, float j)
	{
		return k+j;
	}
};

int main()
{
	calculation C;
	cout<<"addition of two no. "<<C.add(2,3)<<endl;
	cout<<"addition of two no. "<<C.add(5.12f,6.4f);
}
