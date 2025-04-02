#include <cstdio>
#include "computation.h"

//extern double Compute(int, int, float);

int main(void)
{
	int lower, upper;

	puts("Hello User."); 

	printf("Lower and Upper Limits: ");
	scanf("%d%d", &lower, &upper);

	try
	{
		printf("Result of simple computation  = %lf\n", Compute(lower, upper));
		printf("Result of complex computation = %lf\n", Compute(lower, upper, 3.5));
	}
	catch(int e)
	{
		printf("Invalid limit: %d\n", e);
	}
	puts("Goodbye User!");
}

