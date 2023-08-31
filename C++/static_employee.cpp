#include<iostream>
using namespace std;

class Employee
{
	public:
	int emp_no;
	string emp_name;
	static string company_name;
	
	Employee(int emp_no, string emp_name)
	{
		this->emp_no= emp_no;
		this->emp_name= emp_name;
	}
	void display()
	{
		cout<<"Employee Number : "<<emp_no<<endl;
		cout<<"Employee Name : "<<emp_name<<endl;
		cout<<"Company name: "<<company_name<<endl;
	}
};

string Employee :: company_name="PH-IT";

int main()
{
	Employee E1= Employee(123456, "Sagar ");
	Employee E2= Employee(456321, "Lagar ");
	
	E1.display();
	E2.display();
	return 0;
}
