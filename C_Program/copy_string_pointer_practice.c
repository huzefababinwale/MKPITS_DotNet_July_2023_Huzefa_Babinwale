#include<stdio.h>
void main()
{
	char str1[10];
	char str2[10];
	char *ptr ,*ptr2;
	
	printf("Enter string: ");
	gets(str1);
	ptr= &str1;
	ptr2=&str2;
	
	while(*ptr!='\0')
	{
		*ptr2=*ptr;
		ptr++;
		ptr2++;
	}
	*ptr='\0';

	printf("str2= %s", str2);
	
}
