#include<stdio.h>
void main()
{
	char vowel[100];
	int num;
	char *ptr;
	
	printf("Enter your string: ");
	gets(vowel);	
	ptr=vowel;
	while (*ptr!='\0')
	{
		if (*ptr=='a'|| *ptr=='e'|| *ptr=='i'|| *ptr=='o'|| *ptr=='u')
		{
			num=num+1;
		}
		
		ptr++;
	}
	printf("%d", num);
	
}
