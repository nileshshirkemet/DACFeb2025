#include <cstdio>

int main(void)
{
	short age = 0;
	float rate = 0;

	printf("Age: ");
	scanf("%hd", &age);

	switch(age)
	{
		case 16:
			rate = 60;
			break;
		case 18:
			rate = 75;
			break;
		case 21:
			rate = 80;
			break;
		case 50:
			rate = 100;
			break;
		default:
			rate = 50;
	}

	printf("Gift Amount = %.2f\n", age * rate);
}

