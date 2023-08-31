#include<iostream>
using namespace std;

class Animal
{
	public: 
	void eat()
	{
		cout<<"Eating"<<endl;
	}
};
class Dog : public Animal
	{
		public :
			void Bark()
			{
				cout<<"Dog Bark"<<endl;
			}
	};

int main()
{
	Dog d1;
	d1.eat();
	d1.Bark();
	return 0;
}
