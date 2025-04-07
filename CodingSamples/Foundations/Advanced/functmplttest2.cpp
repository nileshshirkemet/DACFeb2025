#include <iostream>
#include <string>


using namespace std;

template<typename Target>
Target Select(Target first, Target second)
{
	if(first > second)
		return first;
	return second;
}

//explicit specialization of Select function template for Target=string
template<>
string Select(string first, string second)
{
	if(first.size() > second.size())
		return first;
	return second;
}

int main(void)
{
	cout << "Selected double value = " << Select(23.4, 32.1) << endl;
	cout << "Selected string value = " << Select(string("Tuesday"), string("Thursday")) << endl;

}

