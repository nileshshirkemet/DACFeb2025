#include "banner1.h"
#include <cstdio>

double BannerPrice(Banner poster, int copies)
{
	float rate = copies < 5 ? 0.95 : 0.80;
	return rate * poster.Area(); //Banner::Area(&poster)
}

int main(void)
{
	int n;
	printf("Number of Banners   : ");
	scanf("%d", &n);
	
	Banner b;
	printf("Total payment for standard banner = %.2lf\n", n * BannerPrice(b, n));

	float w, h;
	printf("Dimensions of Your Banner: ");
	scanf("%f%f", &w, &h);

	Banner c;
	c.Resize(w, h); //Banner::Resize(&c, w, h)
	printf("Total payment for your banner = %.2lf\n", n * BannerPrice(c, n));
}

