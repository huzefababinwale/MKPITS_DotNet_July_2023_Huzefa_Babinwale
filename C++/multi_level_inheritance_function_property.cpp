#include<iostream>
using namespace std;

class person
{
	public :
		string name;
		string address;
	void get_person(string n, string a)
	{
		name =n;
		address = a;
	}
};

class employee : public person
{
	public :
		int emp_no;
		int salary;
	void get_emp_data(int en, int s)
	{
		emp_no = en;
		salary = s;
	}
	void displaydata()
	{
		cout<<"name "<<name<<endl;
		cout<<"address"<<address<<endl;
		cout<<"emp_no"<<emp_no<<endl;
		cout<<"salary"<<salary<<endl;
		
	}
};

int main()
{
	employee emp;
	cout<<"Enter emp Details name\taddress\temp_no\tsalary "<<endl;
	cin>>emp.name>>emp.address>>emp.emp_no>>emp.salary;
	
	emp.get_person(emp.name, emp.address);
	emp.get_emp_data(emp.emp_no, emp.salary);
	emp.displaydata();
	return 0;
	
}





