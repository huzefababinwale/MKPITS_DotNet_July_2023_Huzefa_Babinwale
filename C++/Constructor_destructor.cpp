#include<iostream>
using namespace std;
class Employee
{
	public:
//		int emp_num;
		string emp_name;
		
	Employee()
	{
		cout<<"Employee Constructor Fetched succesfully"<<endl;
	}
	~Employee()
	{
		cout<<"Destructor Fetched succesfully"<<endl;
	}
	
};
int main()
{
	Employee e1;
//	Employee e2;
	
	return 0;
}
