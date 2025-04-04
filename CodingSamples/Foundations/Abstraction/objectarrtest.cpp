#include "interval1.h"
#include <cstdio>

int main(void)
{
	int n;
	printf("Number of Intervals: ");
	scanf("%d", &n);

	if(n == 1)
	{
		//new statement - allocates memory space for instance of specified class
		//on runtime heap, calls the specified constructor and returns the address 
		//of this instance
		Interval* a = new Interval(3, 45);
		a->Print();
		//delete stetement - calls destructor on the instance addressed by the
		//specified pointer and deallocates memory occupied by this instance
		delete a;
	}
	else
	{
		//new[n] statement - allocates memory space for n instances of specified class
		//on runtime heap, calls default constructor of that class on each of these
		//instances and returns address of the first instance (at index 0)
		Interval* b = new Interval[n];
		for(int i = 0; i < n; ++i)
		{
			b[i].Update(40 * i + 225);
			b[i].Print();
		}
		//delete[] statement - calls destructor on each instance with array
		//addressed by specified pointe and deallocates memory occupied by 
		//this array
		delete[] b;
	}
}

