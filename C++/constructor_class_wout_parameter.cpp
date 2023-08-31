#include<iostream>
using namespace std;
class Employee
{
	public:
		int emp_num;
		string emp_name;
		
		Employee()
		{
			emp_num=123;
			emp_name="HKLEN";
		}
		
		void display()
		{
			cout<<"employee Number: "<<emp_num<<endl;
			cout<<"employee Name: "<<emp_name<<endl;
		}
};
int main()
{
	Employee e1;
	e1.display();
	return 0;	

}
