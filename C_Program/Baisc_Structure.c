#include<stdio.h>
struct book
{
	char title[10];
	char author[50];
	int	bookid;
};

void main()
{
	struct book b1;
	strcpy(b1.title,"Dotnet");
	strcpy(b1.author,"PRIYA");
	b1.bookid=123;
	printf("title = %s ",b1.title);
	printf("Author is My Lob %s ",b1.author);
	printf("having book ID %d",b1.bookid);
	
}

	
