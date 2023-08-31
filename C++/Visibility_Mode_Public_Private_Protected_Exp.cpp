#include<iostream>
using namespace std;
class student
{
	private:
		int rollno=10;
		
	public:
		void display()
		{
			cout<<"rollno= "<<rollno;
		}
		void setdata(int r)
		{
			rollno=r;
		}
};

int main()
{
	student s1;
	int rn;
	cout<<"Enter your roll no. : "<<endl;
	cin>>rn;
	s1.setdata(rn);
	s1.display();
}
