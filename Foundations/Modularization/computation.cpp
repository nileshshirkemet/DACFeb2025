#include <cmath>
#include "computation.h"

double Compute(int first, int last, float level)
{
	double result = 0;

	if(last < first)
		throw last; //transfer control to exception handler (catch block)
					//that handles exception of 'int' type

	for(int current = first; current <= last; ++current)
	{
		result += pow(current, level);
	}

	return result; //transfer control to statement after the call
}


