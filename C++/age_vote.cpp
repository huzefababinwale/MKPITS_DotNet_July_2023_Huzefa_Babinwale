#include<iostream>
using namespace std;
int main()
{
	int age;
	char gender;
	cout<<"Enter Gender and age: ";
	cin>>gender>>age;
	
	if (gender=='m')
	{
		if(age>=21)
		{
			cout<<"You are Eligible to vote. ";	
		}
		else
		{
			cout<<"You are not Eligible to vote. ";
		}
	}
	else if (gender=='f')
	{
		if (age>=18)
		{
			cout<<"You are eligible to vote. ";
		}
		else
		{
			cout<<"You are not eligible to vote. ";
		}
	}
	
}





