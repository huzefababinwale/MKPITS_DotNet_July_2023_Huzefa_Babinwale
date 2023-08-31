#include<iostream>
using namespace std;

class Ability
{
	protected :
		string abilityName;
	public :
		void getAbility(string a)
		{
			abilityName= a;
		}
};
class Equipnment 
{
		protected :
			string equipnmentName;
		public :
			void getEquipnment(string e)
			{
				equipnmentName = e;
			}
};
	
class Character : public Ability, public Equipnment
{
	private:
	string CharacterName;
	public:
	void getCharacterName(string c)
	{
		CharacterName = c;
	}
	void display()
	{
		
		cout<<"Character Name  : "<<abilityName<<endl;
		cout<<"Equipnment Name : "<<equipnmentName<<endl;
		cout<<"Character Name : "<<CharacterName<<endl;
	}
};

int main()
{
	Character c1;
	c1.getAbility("Flying");
	c1.getEquipnment("WEBB");
	c1.getCharacterName("FUFU");
	c1.display();
	return 0;
}
