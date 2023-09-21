#include<stdio.h>
int main()
{
    int num=0;
    int i;
    int t1=0, t2=1;
    int fab=1;
    printf("Enter Value till: ");
    scanf("%d",&num);

    for(i=0; i<=num; i++)
    {
        t1=t2;
        t2=fab;
        fab=t1+t2;
        printf("%d",fab);
    }


}
