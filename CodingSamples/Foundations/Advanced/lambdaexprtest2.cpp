#include <iostream>
#include <vector>
#include <ranges> //required C++ 20

using namespace std;

int main(void)
{
	vector<int> nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
	auto result = nums
		| views::filter([](int n){ return n % 2; })
		| views::transform([](int n){ return 0.5 * n * n; })
		| views::reverse;
	for(double entry : result)
		cout << entry << endl;
}


