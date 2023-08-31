#include<iostream>
using namespace std;

class Shape
{
	virtual void draw()=0;
};

class Rectangle
{
	public:
		void draw()
		{
			cout<<"draw the rectangle: ";
		}
};
int main()
{
	Rectangle r;
	r.draw();
	return 0;
}
