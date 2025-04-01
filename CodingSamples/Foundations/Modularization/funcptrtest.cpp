#include <cstdio>

double Expense(int year)
{
	return 5 * year - 4;
}

double Income(int year)
{
	return (year * year + 1) / 2;
}

//function pointer - is an identifier of the
//address of implementation of a function
//with a specific list of parameter types
//and a specific return type
//growth function pointer type parameter
//which points to the implementation of
//any function which takes first parameter of
//int type and returns result of double type
double CommonSum(int years, double(*growth)(int))
{
	double total = 0;

	for(int y = 1; y <= years; ++y)
	{
		total += growth(y); //indirect a call to function addressed by growth
	}

	return total;
}


int main(void)
{
	int n;

	printf("Number of years: ");
	scanf("%d", &n);

	printf("Total Expense: %.2f\n", CommonSum(n, &Expense));
	printf("Total Income : %.2f\n", CommonSum(n, Income));
}

