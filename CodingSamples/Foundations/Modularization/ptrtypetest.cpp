#include <cstdio>

double Average(double first, double second, double* deviation)
{
	*deviation = first > second ? (first - second) / 2 : (second - first) / 2;
	return (first + second) / 2;
}

int main(void)
{
	double p = 0, q = 0;

	printf("Two real values: ");
	scanf("%lf%lf", &p, &q);

	double d = 0;
	double a = Average(p, q, &d);

	printf("Average is %.3f with a deviation of %.3f\n", a, d);
}

