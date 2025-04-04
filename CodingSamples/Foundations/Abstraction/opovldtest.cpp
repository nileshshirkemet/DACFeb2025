#include "interval2.h"
#include <cstdio>

int main(void)
{
	Interval a(3, 45);
	a.Print();

	puts("Copying...");
	Interval b = a;
	b.Print();

	Interval c(2, 35);
	c.Print();

	puts("Adding...");
	Interval d = a + b + c;
	d.Print();

	printf("Number of Active Intervals = %d\n", Interval::Active());
}

