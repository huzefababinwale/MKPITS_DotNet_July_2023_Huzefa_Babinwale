#include<iostream>
using namespace std;
int main()
{
	int basic, HR, DA, total;
	cout<<"Enter Basic Salary: ";
	cin>>basic;
	HR= 0.35*basic;
	DA=0.45*basic;
	total=HR+DA+basic;
	cout<<"Total Salary will generate = "<<total;
}
