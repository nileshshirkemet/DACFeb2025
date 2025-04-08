#include <iostream>

class Interval
{
public:
	Interval(short min = 0, short sec = 0)
	{
		minutes = min + sec / 60;
		seconds = sec % 60;
	}

	long Time() const
	{
		return 60 * minutes + seconds;
	}

	Interval operator+(const Interval& rhs) const
	{
		return Interval(minutes + rhs.minutes, seconds + rhs.seconds);
	}

	bool operator<(const Interval& rhs) const
	{
		return Time() < rhs.Time();
	}

	bool operator==(const Interval& rhs) const
	{
		return Time() == rhs.Time();
	}
private:
	short minutes;
	short seconds;

	//friend function - a non-member function of a class which
	//has access to the private members of that class (since it
	//is also defined by the author of that class)
	friend std::ostream& operator<<(std::ostream& out, const Interval& val);
};

//overloading insertion(<<) operator for Interval, as this operator
//requires Interval to be on right-hand-side it must be overloaded
//as a global function
std::ostream& operator<<(std::ostream& out, const Interval& val)
{
	if(val.seconds < 10)
		out << val.minutes << ":0" << val.seconds;
	else
		out << val.minutes << ":" << val.seconds;
	return out;
}

