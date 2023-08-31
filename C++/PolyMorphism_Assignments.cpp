#include<iostream>
using namespace std;

class Vehicle
{
	public:
	virtual void start()
	{
		cout<<"Engine is Started from class Vehicle: "<<endl;
	}
	virtual void stop()
	{
		cout<<"Engine is Stoped for Vehicle: "<<endl;
	}
};
class Car : public Vehicle
{
	public:
	void start()
	{
		cout<<"Engine is Started from class Car: "<<endl;
	}
	void stop()
	{
		cout<<"Engine is Stoped for Car: "<<endl;
	}
};
class MotorCycle : public Vehicle
{
	public:
	void start()
	{
		cout<<"Engine is Started from class MotorCycle: "<<endl;
	}
	void stop()
	{
		cout<<"Engine is Stoped for Vehicle: "<<endl;
	}
};
class Truck : public Vehicle
{
	public:
	void start()
	{
		cout<<"Engine is Started from class Truck: "<<endl;
	}
	void stop()
	{
		cout<<"Engine is Stoped for Vehicle: "<<endl;
	}
};
int main()
{
	Vehicle *V;
	Vehicle V1;
	Car C;
	Truck T;
	MotorCycle MC;
	 
	V=&V1;
	V->start();
	V->stop();
	
	V=&C;
	V->start();
	V->stop();
	
	V=&MC;
	V->start();
	V->stop();
	
	V=&T;
	V->start();
	V->stop();
	return 0;
}
