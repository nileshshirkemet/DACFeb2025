#include "boards.h"
#include <iostream>

double Order(Ads::Signboard* poster, int count)
{
	float discount = count < 10 ? 0 : 0.05;

	return count * (1 - discount) * poster->Price();
}

int main(void)
{
	int n;
	std::cout << "Number of Boards: ";
	std::cin >> n;

	Ads::RectangularBoard a(12.5, 4.8, Ads::Medium::Wooden);
	Ads::CircularBoard b(15.6, Ads::Medium::Metal);

	std::cout << "Total payment for rectangular boards: "
			  << Order(&a, n)
			  << std::endl;
	std::cout << "Total payment for circular boards: "
			  << Order(&b, n)
			  << std::endl;
}



