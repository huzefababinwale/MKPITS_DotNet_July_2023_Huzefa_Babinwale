#include<iostream>
using namespace std;

class person
{
	protected:
		string name;
};

class student : public person
{
	public :
		void putdata(string s)
		{
			name =s;
		}
		void displaydata()
		{
			cout<<"name "<<name<<endl;
		}
};

class clear : public person
{
	public :
		void changedata(string a)
		{
			name = a;
		}
		void updatedata()
		{
			cout<<"name "<<name<<endl;	
		}
};

int main()
{
	string newName;
	student s1;
	clear c1;
	s1.putdata("ammar");
	s1.displaydata();
	cout<<"ENter new name to update: "<<endl;
	cin>>newName;
	c1.changedata(newName);
	c1.updatedata();
	s1.displaydata();
}
