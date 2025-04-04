#include "boards.h"

#define PI 3.14

namespace Ads
{
	double Signboard::Price() const
	{
		float rate;

		switch(material)
		{
			case Medium::Wooden:
				rate = 2.25;
				break;
			case Medium::Metal:
				rate = 3.75;
				break;
			default:
				rate = 0.95;
		}
		return rate * Area();

	}

	RectangularBoard::RectangularBoard(float width, float height, Medium make)
	{
		if(width > height)
		{
			length = width;
			breadth = height;
		}
		else
		{
			length = height;
			breadth = width;
		}
		material = make;
	}

	double RectangularBoard::Area() const
	{
		return length * breadth;
	}

	CircularBoard::CircularBoard(float diameter, Medium make)
	{
		radius = diameter / 2;
		material = make;
	}

	double CircularBoard::Area() const
	{
		return PI * radius * radius;
	}
}

