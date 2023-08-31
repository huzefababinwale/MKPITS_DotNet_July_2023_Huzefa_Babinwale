#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
		
	void getdata()
	{
		cout<<"Enter roll number, name, course of the student: "<<endl;
		cin>>rollno>>name>>course;
	}
	void display()
	{
		cout<<"\t"<<rollno<<"\t"<<name<<"\t"<<course<<endl;
	}
};

int main()
{
	student std1, std2;
	cout<<"student1"<<endl;
	std1.getdata();
	std1.display();
	
	cout<<"student2"<<endl;
	std2.getdata();
	std2.display();
	return 0;
}
