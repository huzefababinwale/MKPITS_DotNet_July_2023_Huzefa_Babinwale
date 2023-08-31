#include<iostream>
using namespace std;
class cars
{
	public:
		string make;
		string model;
		int year;
		
		void startEngine()
		{
			cout<<"Enginge started :"<<endl;
		}
		void brake()
		{
			cout<<"Break Applied"<<endl;
		}
		
};
int main()
{
	cars c1;
	c1.make="Maruti";
	c1.model="Sarararara";
	c1.year=2202;
	
	cout<<"Make is "<<c1.make<<endl;
	cout<<"Model is "<<c1.model<<endl;
	cout<<"Model Year is "<<c1.year<<endl;
	
	c1.startEngine();
	
	c1.brake();
	return 0;
}

