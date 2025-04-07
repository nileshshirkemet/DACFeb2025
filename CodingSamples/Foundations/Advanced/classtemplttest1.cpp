#include <iostream>
#include <string>

using namespace std;

//class template - a class pattern which is used by the compiler to
//generate definition of actual (templated) class by replacing 
//type parameter T by a particular type which is exlicitly specified 
//within its usage in a declaration
template<typename T>
class Selector
{
public:
	//using initializer syntax to directly initialize fields
	//as copy of arguments of constructor (this will also work if T is
	//replaced by a class which does not support default constructor)
	Selector(T a, T b) : first(a), second(b)
	{
	}

	T Select(int index) const
	{
		if(index % 2)
			return first;
		return second;
	}
private:
	T first, second;
};

int main(void)
{
	int n;
	cout << "Selector: ";
	cin >> n;

	Selector<double> a(34.5, 43.2);
	cout << "Selected double value = " << a.Select(n) << endl;

	Selector<string> b("Monday", "Friday");
	cout << "Selected string value = " << b.Select(n) << endl;
}


