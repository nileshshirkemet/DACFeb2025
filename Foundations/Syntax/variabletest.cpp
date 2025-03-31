#include <cstdio>

int main(void)
{
	long int upper = 0;
	long int sum = 0;

	printf("Upper Limit: ");
	scanf("%ld", &upper);

	sum = upper * (upper + 1) / 2;

	printf("Sum of Integers = %ld\n", sum);
}

