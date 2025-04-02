#include <cstdio>

int main(void)
{
	int lower = 0, upper = 0;

	printf("Lower and Upper Limits: ");
	scanf("%d%d", &lower, &upper);

	long sum = 0;

	for(int value = lower; value <= upper; ++value)
	{
		sum += value * value;
	}

	printf("Sum of Squares = %ld\n", sum);
}

