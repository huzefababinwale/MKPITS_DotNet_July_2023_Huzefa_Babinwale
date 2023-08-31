#include<iostream>
using namespace std;

class person
{
	public:
	string name;
	string address;
};
class employee : public person
{
	public:
	string designation;
	int emp_no;
	int salary;
};
class part_time_emp : public employee
{
	public:
	int hours;
};

int main()
{
	employee e1;
	e1.name="Akash";
	e1.address="Ghr";
	e1.emp_no;
	e1.salary;
	
	part_time_emp p1;
	p1.name="Gujjar";
	p1.address="in Melaa";
	p1.emp_no=1234;
	p1.salary=50000;
	p1.hours=4;
	
	
	cout<<p1.name<<" rehta h "<<p1.address<<" Part time work & having no. "<<p1.emp_no<<" and Salary is "<<p1.salary<<",  hour of working is "<<p1.hours; 	
}
