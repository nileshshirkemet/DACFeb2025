#include <cstdio>

double BannerPrice(float width, float height)
{
	float rate = width <= height ? 0.95 : 0.80;
	return width * height * rate;
}

int main(void)
{
	float w, h;
	int n;

	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	printf("Number of Banners   : ");
	scanf("%d", &n);

	printf("Total payment for regular banner = %.2lf\n", n * BannerPrice(w, h));
	printf("Total payment for premium banner = %.2lf\n", n * BannerPrice(w + 1, h + 1));
}

