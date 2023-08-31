#include<stdio.h>
int main()
{
	char str[10], *ptr;
	int cnt=0;
	
	printf("Enter your string: ");
	gets(str);
	ptr=&str;
	
	while(*ptr !='\0')
	{
		cnt=cnt+1;
		ptr++;
	}
	printf("cnt = %d",cnt);
}

