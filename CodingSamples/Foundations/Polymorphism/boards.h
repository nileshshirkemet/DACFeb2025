//Namespace - a named scope that groups related symbols to avoid
//collissions between names of these symbols and other symbols
//not belonging to their group, a symbol S that belongs to namespace N
//can be referred from outside of N using its qualified name N::S
namespace Ads
{

	enum Medium {Plastic = 1, Wooden = 2, Metal = 5};

	//abstract data type (ADT) - a class that defines at least one
	//pure virtual function, it does not support instantiation and
	//can only be used as a pointer or a reference type
	class Signboard
	{
	public:
		//pure virtual function - a virtual function defined without
		//any specific implementation by its class, logically 0 is
		//placed in the coressponding slot of v-table of its class
		virtual double Area() const = 0;
		double Price() const;
		virtual ~Signboard() {}
	protected: //members are visible in the derived class
		Medium material;
	};

	class RectangularBoard : public Signboard
	{
	public:
		RectangularBoard(float width, float height, Medium make);
		double Area() const;
	private:
		float length, breadth;
	};

	class CircularBoard : public Signboard
	{
	public:	
		CircularBoard(float diameter, Medium make);
		double Area() const;
	private:
		float radius;
	};
}

