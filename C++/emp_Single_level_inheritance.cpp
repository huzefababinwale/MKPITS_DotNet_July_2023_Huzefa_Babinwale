#include<iostream>
using namespace std;

class emp
{
	public : 
	int rol_no;
	string name;
};
class company: public emp
{
	public:
	string city;
	string naam;
};
int main()
{
	company c1;
	c1.rol_no=24;
	c1.name = "NAME";
	c1.city = "Gondia";
	c1.naam="Google";
	
	cout<<c1.rol_no <<c1.city <<c1.name <<c1.naam <<endl;
}
