#include<iostream>
using namespace std;

int myFunction(int x, int y)
{
	if (y<=0)
	{
		return 1;
	}
	else
	{
		return x*(myFunction(x,y-1));
	}
}
int main()
{
	int res;
	res=myFunction(5,3);
	cout<<"results are= "<<res;
	return 0;
}


