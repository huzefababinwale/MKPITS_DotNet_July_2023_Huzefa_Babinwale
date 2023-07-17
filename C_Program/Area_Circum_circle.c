#include<stdio.h>
void main()
{
	float radius, area, circum;
	
	printf("Enter Radius of Circle");
	scanf("%f",&radius);
	
	area=3.14f*radius*radius;
	circum= 2*3.14*radius;
	
	printf("Area of Circle is = %f",area);
	printf("\nCircumference of Circle is = %f",circum);
}
