#include<iostream>
using namespace std;
class Employee
{
	public:
		int emp_num;
		string emp_name;
		
	Employee(int emp_num, string emp_name)
	{
		this -> emp_num=emp_num;
		this -> emp_name=emp_name;
	}
	void display()
	{
		cout<<emp_num<<emp_name;
	}
};
int main()
{
	int emp_num;
	int emp_name;
	
	Employee e1(13 ,"Raj");
	
	e1.display();
}
