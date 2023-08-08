#include<stdio.h>
struct kinetc
{
	char title[10];
	char author[30];
	int Num;
};

void printbook(struct kinetc *ptr);
void main()
{
	struct kinetc k1;
	printf("Enter your details of Title, Author, KineticNum");
	scanf("%s",&k1.title);
	scanf("%s",&k1.author);
	scanf("%d",&k1.Num);
	printbook(&k1);
	
}
void printbook(struct kinetc *ptr)
{
	
	printf("TItle of book is %s, having author named as %s, with kinetic value of %d",ptr->title,ptr->author,ptr->Num);
}
