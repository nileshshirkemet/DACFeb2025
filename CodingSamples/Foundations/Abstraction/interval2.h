#include <cstdio>

class Interval
{
public:
	Interval(short min = 0, short sec = 0)
	{
		minutes = min + sec / 60;
		seconds = sec % 60;
		++count;
	}

	//copy constructor
	Interval(const Interval& that)
	{
		minutes = that.minutes;
		seconds = that.seconds;
		++count;
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

	void Print() const
	{
		printf("%hd:%02hd\n", minutes, seconds);
	}

	//overloading + operator to support a + b === a.operator+(b)
	Interval operator+(const Interval& rhs) const
	{
		return Interval(minutes + rhs.minutes, seconds + rhs.seconds);
	}

	static int Active() 
	{
		return count;
	}

	~Interval()
	{
		--count;
	}

private:
	short minutes;
	short seconds;
	static int count;
};

int Interval::count = 0;

