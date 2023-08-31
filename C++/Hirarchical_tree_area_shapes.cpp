#include<iostream>
using namespace std;

class shape
{
	public :
		int x, y;
		void get_data(int a, int b)
		{
			x=a;
			y=b;
		}
};
class rectangle : public shape
{
	public :
		int r_area(int l, int b)
		{
			int ra;
			ra = l*b;
			return ra;
		}
};
class triangle: public shape
{
	public :
		float r_area(int b, int h)
		{
			float ta;
			ta=0.5f*b*h;
			return ta;
		}
};

int main()
{
	rectangle r;
	triangle t;
	int length, breath, base, height;
	int ra;
	float ta;
	
	cout<<"enter length and breath "<<endl;
	cin>>length>>breath;
	ra= r.r_area(length,breath);
	cout<<"area of rectangle"<<ra<<endl;
	cout<<"enter base and height ";
	cin>>base>>height;
	ta=t.r_area(base,height);
	cout<<"area of Triangle "<<ta<<endl;
	return 0;
}




