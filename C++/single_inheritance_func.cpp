#include<iostream>
using namespace std;
class person
{
	public :
		string name;
		string city;
};
class student: public person
{
	public :
		int rollno;
		int marks;
};
int main()
{
	student s1;
	s1.name="Huzefa";
	s1.rollno=32;
	s1.marks=456;
	s1.city="Ghr";
	
	cout<<s1.name <<s1.marks <<s1.rollno;
}
