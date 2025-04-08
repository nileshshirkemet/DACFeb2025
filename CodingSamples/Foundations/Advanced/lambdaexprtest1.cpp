#include "interval.h"
#include <iostream>
#include <vector>
#include <set>
#include <algorithm>

using namespace std;

bool IsOdd(int num)
{
	return num % 2;
}

int main(void)
{
	//using vector<T> which is a sequential container (array-list)
	vector<int> a;
	a.push_back(381);
	a.push_back(562);
	a.push_back(723);
	a.push_back(804);
	a.push_back(615);
	a.push_back(426);
	a.push_back(237);
	a.push_back(138);
	cout << "Original integers in vector" << endl;
	//a container supports standard iteration by exposing begin()
	//and end() methods to return an iterator type which supports 
	//!=, ++ and * operators
	for(vector<int>::iterator i = a.begin(); i != a.end(); ++i)
		cout << *i << endl;
	sort(a.begin(), a.end());
	cout << "Sorted integers in vector" << endl;
	//auto type is inferred from initializer (modern C++)
	for(auto i = a.begin(); i != a.end(); ++i)
		cout << *i << endl;
	cout << "Number of odd integers = "
		 << count_if(a.begin(), a.end(), IsOdd)
		 << endl;
	cout << "----------------------------" << endl;

	//using set<T> which is an associative container (binary-tree)
	set<Interval> b;
	b.insert(Interval(4, 31));
	b.insert(Interval(7, 42));
	b.insert(Interval(6, 53));
	b.insert(Interval(3, 24));
	b.insert(Interval(5, 15));
	b.insert(Interval(2, 84));
	cout << "Original Intervals in set" << endl;
	//for-each loop structure (modern C++) can be applied 
	//to a container that supports standard iteration
	for(auto k : b)
		cout << k << endl;	
	int m;
	cout << "Minimum time: ";
	cin >> m;
	//using anonymous function known as lambda expression (modern C++):
	//[capture](arguments){ body }
	cout << "Number of big Intervals = "
		 << count_if(b.begin(), b.end(), [m](Interval i){ return i.Time() >= m; })
		 << endl;

}

