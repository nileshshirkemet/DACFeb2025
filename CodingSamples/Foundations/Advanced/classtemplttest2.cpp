#include <iostream>
#include <string>

using namespace std;

template<typename I, typename V>
class IndexedValue
{
public:
	IndexedValue(I i, V v) : index(i), value(v)
	{
	}

	void Print() const
	{
		cout << "(" << index << ") => " << value << endl; 
	}
private:
	I index;
	V value;

};

//partial specialization for IndexedValue class template with V=bool
template<typename I>
class IndexedValue<I, bool>
{
public:
	IndexedValue(I i, bool v) : index(i)
	{
		value = v;
	}

	void Print() const
	{
		cout << "(" << index << ") => " << (value ? "yes" : "no") << endl; 
	}
private:
	I index;
	bool value;
};

//full specialization of IndexedValue class template with I=int, V=string
template<>
class IndexedValue<int, string>
{
public:
	IndexedValue(string v) : value(v)
	{
		static int count = 0;
		index = ++count;
	}

	void Print() const
	{
		cout << "[" << index << "] => \"" << value << "\"" << endl; 
	}
private:
	int index;
	string value;
};

int main(void)
{
	IndexedValue<string, double> a("Jack", 23.4);
	a.Print();

	IndexedValue<string, bool> b("Retired", true);
	b.Print();

	IndexedValue<int, string> c("Monday");
	c.Print();

	IndexedValue<int, string> d("Tuesday");
	d.Print();
}


