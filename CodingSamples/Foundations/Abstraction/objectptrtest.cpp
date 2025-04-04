#include "interval1.h"
#include <cstdio>

double Speed(float distance, const Interval* duration)
{
	return 3.6 * distance / duration->Time(); //p[0].member === p->member
}

int main(void)
{
	Interval a(2, 105);
	a.Print();
	printf("Speed for this Interval = %.3f\n", Speed(600, &a));

	long t;
	printf("Time: ");
	scanf("%ld", &t);
	
	if(t >= 10)
	{
		Interval b;
		b.Update(t);
		b.Print();
		printf("Speed for this Interval = %.3f\n", Speed(600, &b));
	}//Interval destructor for b will be called here

	//calling static method
	printf("Number of Intervals Activated = %d\n", Interval::Activated());
}//Interval destructor for a will be called here

