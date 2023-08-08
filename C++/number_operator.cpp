#include<iostream>
using namespace std;
int main()
{
	int n1,n2,total=0;
	char op;
	cout<<"Enter two numbers ";
	cin>>n1>>n2;
	cout<<"Enter operators like (+,-,*,/)";
	cin>>op;
	if (op=='+')
	
	{
		total = n1+n2;
	}
	else if (op=='-')
	{
		total = n1-n2;
		}	
		
	else if (op=='*')
	{
		total = n1*n2;
	}
	else if (op=='/')
	{
		total = n1/n2;
	}
	cout<<"Total of give numbers and operator is "<<total;
}
