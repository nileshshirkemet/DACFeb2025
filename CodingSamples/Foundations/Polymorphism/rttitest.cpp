#include "boards.h"
#include <iostream>

//automatically convert unqualified names (like Medium) of symbols
//within Ads namespace to their qualified names (Ads::Medium)
using namespace Ads;

double Order(Signboard* poster, int count)
{
	float discount = count < 10 ? 0 : 0.05;
	double cost = poster->Price();
	//dynamic_cast is used for down-casting or side-casting of one 
	//pointer type to another, it checks if conversion is valid using
	//runtime type identification (RTTI) otherwise it returns nullptr(0)
	Wasteful* scrap = dynamic_cast<Wasteful*>(poster);
	if(scrap != nullptr)
		cost += 0.75 * scrap->Extra();
	return count * cost * (1 - discount);
}

int main(void)
{
	float d;
	int n;
	std::cout << "Size and Number of Boards: ";
	std::cin >> d >> n;

	RectangularBoard a(0.8 * d, 0.6 * d, Medium::Wooden);
	CircularBoard b(d, Medium::Metal);

	std::cout << "Total payment for rectangular boards: "
			  << Order(&a, n)
			  << std::endl;
	std::cout << "Total payment for circular boards: "
			  << Order(&b, n)
			  << std::endl;
}



