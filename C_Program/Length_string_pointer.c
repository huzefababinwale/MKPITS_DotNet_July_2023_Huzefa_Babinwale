//to find Length of a string
void main()
{
	char name[10];
	char *ptr;
	int cnt;
	
	printf("Enter String: ");
	gets(name);
	ptr=name;
	
	while (*ptr !='\0')
	{
		cnt=cnt+1;
	}
	printf("count of string is = %d",cnt);
	
}

