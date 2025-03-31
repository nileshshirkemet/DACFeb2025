#include <cstdio>

double BannerPrice(float width, float height) //_Z11BannerPriceff
{
	float rate = width <= height ? 0.95 : 0.80;
	return width * height * rate;
}

//function overloading - defining two functions within same scope
//with identical name but different list of parameter types.
double BannerPrice(float width, float height, short layers) //_Z11BannerPriceffs
{
	return 1.35 * width * height * layers;
}


int main(void)
{
	float w, h;
	int n;

	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	printf("Number of Banners   : ");
	scanf("%d", &n);

	printf("Total payment for regular banners: %.2f\n", n * BannerPrice(w, h));
	printf("Total payment for premium banners: %.2f\n", n * BannerPrice(w, h, 3));
}
