#include <cstdio>

int main(void)
{
	float width = 0, height = 0;
	int copies = 0;
	float rate = 0;

	printf("Dimensions of Banner: ");
	scanf("%f%f", &width, &height);
	printf("Number of Banners   : ");
	scanf("%d", &copies);

	if(width > height)
	{
		puts("Making landscape banners...");
		rate = 0.80;
	}
	else
	{
		puts("Making potrait banners...");
		rate = 0.95;
	}

	double payment = width * height * rate * copies;

	printf("Total Payment = %.2lf\n", payment);
}

