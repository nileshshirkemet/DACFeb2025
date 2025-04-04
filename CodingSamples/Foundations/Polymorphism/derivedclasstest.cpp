#include "banners.h"
#include <cstdio>

double BannerPrice(const Banner& poster, int count)
{
	float rate = count < 5 ? 0.95 : 0.80;
	//dynamic binding is used when a virtual function
	//of a class is called on an a pointer/reference
	//of that class type
	return count * rate * poster.Area();
}

int main(void)
{
	float w, h;
	int n;
	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	printf("Number of Banners   : ");
	scanf("%d", &n);

	Banner a(w, h);
	printf("Total payment for regular banner = %.2lf\n", BannerPrice(a, n));

	CurvedBanner b(3);
	b.Resize(w, h);
	printf("Total payment for curved banner  = %.2lf\n", BannerPrice(b, n));
}

