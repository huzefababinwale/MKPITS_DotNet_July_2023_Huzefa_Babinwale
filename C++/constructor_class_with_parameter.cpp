#include <iostream>
using namespace std;
class Employee
{
	public:
		int emp_num;
		string emp_name;
	
	Employee(int eno, string ename)
	{
		emp_num=eno;
		emp_name=ename;
	}
	
	void display()
	{
		cout<<emp_num<<endl;
		cout<<emp_name<<endl;
	}
	
};
int main()
{
	int emp_num;
	string emp_name;
	
	Employee e1(55, "hfjdkljgl");
	e1.display(); 
	return 0;
	
}
