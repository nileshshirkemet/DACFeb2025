class Banner
{
public: //members declared in this block are visible outside of this class

	//constructor - a special method defined by the class
	//whose name matches with the name of this class and 
	//does not have a specific return type, it is called
	//to initialize values of fields whenever a new instance
	//is activated
	//default constructor - a constructor which is automatically
	//called during activation if no constructor is called
	//explicitly, such a constructor must not have any non-optional
	//parameter (declared without any default argument)
	Banner()
	{
		width = 20;
		height = 5;
	}

	/*
	void Banner::Resize(Banner* this, float w, float h)
	{
		this[0].width = w;
		this[0].height = h;
	}
	*/
	void Resize(float w, float h)
	{
		width = w;
		height = h;
	}


	/*
	double Banner::Area(const Banner* this)
	{
		return this[0].width * this[0].height;
	}
	*/
	double Area() const
	{
		return width * height;
	}

private: //member declared in this block are only visible inside of this class
	float width;
	float height;
};

