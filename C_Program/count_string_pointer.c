#include<stdio.h>
#include<string.h>
void main()
{
	char name[100];
	int cnt;
	char *ptr;
	
	printf("Enter Name: ");
	gets(name);
	ptr=name;
	
	while(*ptr !='\0')
	{
		if (*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			cnt=cnt+1;
		}
		ptr++;
	}
	printf("vowels in a string is %d", cnt);
	
}
