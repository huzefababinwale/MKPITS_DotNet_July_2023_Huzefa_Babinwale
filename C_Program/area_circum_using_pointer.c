#include<stdio.h>
int calculation(float r, float *area,float *circum)
{
	*area=3.14*r*r;
	*circum= 2*3.14*r;
}
void main()
{
	int radius;
	float area, circum;
	printf("Pleade provide value of radius: ");
	scanf("%d",&radius);
	calculation(radius, &area ,&circum);
	printf("area of circle is = %f\n Circumference of circle is = %f",area, circum);
}


