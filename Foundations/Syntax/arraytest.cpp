#include <cstdio>

int main(void)
{
	short grade = 0;
	int month = 0;
	float basic = 368.50;
	double salary = 0;
	const int year[] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

	printf("Pay-grade  : ");
	scanf("%hd", &grade);
	printf("Month[1-12]: ");
	scanf("%d", &month);

	salary = (32.25 * grade + basic) * year[month - 1];
	printf("Salary = %.2lf\n", salary);
	//year[5] = 50;
}

