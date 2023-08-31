#include<iostream>
using namespace std;

class shape
{
	public:
		int x ;
		int y;
		
	void get_data(int a, int b)
	{
		x=a;
		y=b;
		
	}
};

class rectangle : public shape
{
	public:
		int area_rec()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};

class triangle : public shape
{
	public :
		float area_triangle()
		{
			float ta;
			ta=0.5*x*y;
			return ta;
		}		
};

int main()
{
	rectangle r1;
	triangle t1;
	int result, length, breath, base, height;
	
	cout<<"Enter Length and Breath of rectangle: \n";
	cin>>length>>breath;
	r1.get_data(length, breath);
	result = r1.area_rec();
	cout<<result<<endl;
	
	cout<<"Enter base & height of triangle: \n";
	cin>>base>>height;
	t1.get_data(base, height );
	result= t1.area_triangle();
	cout<<"results are: "<<result;
}

