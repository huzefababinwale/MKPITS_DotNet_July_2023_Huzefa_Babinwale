#include<stdio.h>
void main()
{
	int arr[2][2]={{1,2},{3,4}};
	int row, col, cnt;
	
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("arr[%d][%d] = %d\n", row, col, arr[row][col]);
		}
	}
}
 

