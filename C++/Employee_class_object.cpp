#include<iostream>
using namespace std;
class employee
{
	public:
		int empnum;
		string name;
		string designation;
		int salary;
		
	void getdetails()
	{
		cout<<"Enter the details of Employee"<<endl<<" \t empnum \t name \t designation \t salary"<<endl;
		cin>>empnum>>name>>designation>>salary;
	}
	void displaydetails()
	{
		cout<<"\t"<<empnum<<"\t"<<name<<"\t"<<designation<<"\t"<<salary;
	}
};
int main()
{
	employee e1;
	e1.getdetails();
	e1.displaydetails();
	
}
