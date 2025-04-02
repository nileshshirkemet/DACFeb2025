#include <cstdio>

class Interval
{
public:
	Interval(short min = 0, short sec = 0)
	{
		id = ++count;
		minutes = min + sec / 60;
		seconds = sec % 60;
		printf("Interval instance<%d> activated\n", id);
	}

	long Time() const
	{
		return 60 * minutes + seconds;
	}

	void Update(long t) 
	{
		minutes = t / 60;
		seconds = t % 60;
	}

	//instance method - called on object using . operator, receives
	//'this' parameter which addresses the instance refered by that object
	void Print() const
	{
		printf("%hd:%02hd\n", minutes, seconds);
	}

	//class method - called on class using :: operator, does not
	//receive 'this' parameter and as such it only supports references
	//to other static members
	static int Activated() 
	{
		return count;
	}

	//destructor - special method to reverse side effect of constructor,
	//it is automatically called when identifier of a local object 
	//goes out of scope (stack semantcs) or just before the instance 
	//referred by an object is removed from the memory
	~Interval()
	{
		printf("Interval instance<%d> deactivated\n", id);
	}
private:
	int id; //instance field - separate value for each instance
	short minutes;
	short seconds;
	static int count; //class field - value shared by all instances
};

//initializer for static field of a class
int Interval::count = 0;

