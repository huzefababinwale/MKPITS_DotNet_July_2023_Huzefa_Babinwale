#include<stdio.h>
void main()
{
	char ch;
	printf("Enter the char: \n");
	scanf("%c",&ch);
	switch(ch)
	{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			printf("%c Character is Vowel ");
		default:
			printf("%c The Character is not vowel", ch);
	}



}
