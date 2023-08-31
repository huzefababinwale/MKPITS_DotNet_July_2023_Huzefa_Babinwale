#include<iostream>
using namespace std;
int main()
{
	int num1, num2;
	cout<<"Enter two number: ";
	cin>>num1>>num2;
	if (num1>num2)
	{
		cout<<num1<<" is greater than any other number listed ";
	}
	else if (num2>num1)
	{
		cout<<num2<< " is greater than any other number";
	}
	else 
	{
		cout<<"Given Numbers are same.";
	}
	
	
}
