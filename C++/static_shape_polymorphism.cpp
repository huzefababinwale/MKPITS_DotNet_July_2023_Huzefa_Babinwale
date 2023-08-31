#include<iostream>
using namespace std;
class Shape
{
	public :
		virtual void draw()
		{
			cout<<"draw method of shape class "<<endl;
		}
};
class Rectangle : public Shape
{
	public : 
	void draw()
	{
		cout<<"draw method of rectangle class "<<endl;
	}
};

int main()
{
	Shape *s;
	Shape s1;
	
	s=&s1;
	s->draw();
	
	Rectangle r1;
	s=&r1;
	s->draw();
	return 0;
}
