enum Geometry {Rectangular, Triangular, Elliptical};

class Banner
{
public:
	Banner()
	{
		region = 20 * 5;
		shape = Geometry::Rectangular;
	}

	void Resize(float w, float h)
	{
		region = w * h;
	}

	double Area() const
	{
		switch(shape)
		{
			case Geometry::Triangular:
				return 0.5 * region;
			case Geometry::Elliptical:
				return 0.785 * region;
			default:
				return region;
		}
	}

	void Reshape(Geometry g) 
	{
		shape = g;
	}
private:
	double region;
	Geometry shape;
};

