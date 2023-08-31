#include<iostream>
using namespace std;
class circle
{
	public:
		int radius, result;
		
	float Area()
	{
		float a=3.14f*radius*radius;
		return a;
	}
	float Circum() 
	{
		float Circum= 2*3.14f * radius;
		return Circum;
	}
	
};
int main()
{
	float result;
	circle c1;
	cout<<"Enter radius: ";
	cin>>c1.radius;
	result=c1.Area();
	cout<<"Area of given circu is = "<<result<<endl;
	result=c1.Circum();
	cout<<"Circumference of given circle is = "<<result<<endl;
	
}

