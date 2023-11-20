#include<stdio.h>
void main()
{
	int xaxis, yaxis, n=7, spc;
	for (xaxis=n;xaxis>=1;xaxis--)
	{
		for (spc=1;spc<=xaxis;spc++)
		{
			printf(" ");
		}
		for (yaxis=1;yaxis<=xaxis;yaxis++)
		{
			printf("* ");
		}
		printf("\n");
//		if (xaxis==1)
//		{
//			for (spc=1;spc<=xaxis;spc++)
//			{
//				printf(" ");
//			}
//			for(xaxis=1;xaxis<=n;xaxis++)
//			{
//				for (yaxis=1;yaxis<=xaxis; yaxis++)
//				{
//					printf("* ");
//				}
//				printf("\n");
//			}
//		}
		
	}
}
