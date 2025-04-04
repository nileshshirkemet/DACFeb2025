class Banner
{
public:
	Banner(float w = 20, float h = 5)
	{
		width = w;
		height = h;
	}

	void Resize(float w, float h)
	{
		width = w;
		height = h;
	}

	//virtual function - a member function that supports 
	//dynamic binding i.e a call to it can be indirected 
	//through its corresponding slot within the class 
	//specific v-table which is addressed by each instance 
	//of that class
	virtual double Area() const
	{
		return width * height;
	}

private:
	float width;
	float height;
};

//defining CurvedBanner as a derived class of Banner (base-class)
class CurvedBanner : public Banner
{
public:
	CurvedBanner(float r) : Banner(18, 6)
	{
		radius = r;
	}

	//function overriding - defining a member function in a
	//derived class whose declaration matches with a virtual
	//member function of its base class
	double Area() const
	{
		return Banner::Area() - 0.86 * radius * radius;
	}
private:
	float radius;
};

