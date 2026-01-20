#include <iostream>
#include <vector>
#include <sstream>
#include <string>
#include <array>

static void	youngPhysicist(const std::vector<std::vector<int>>& n) {
	const std::array<std::string, 2>	output = {"NO", "YES"};
	
	if (!n.size()) {
		std::cout << output[0] << std::endl;
		return ;
	}

	long	x = 0, y = 0, z = 0;
	for(int row = 1; row < n.size(); row++) {
		x += n[row][0];
		y += n[row][1];
		z += n[row][2];
	}

	const int key = (x == 0 && y == 0 && z == 0);

	std::cout << output[key] << std::endl;
}

int main() {
	std::vector<std::vector<int>>	n;
	std::string						line;;

	while(std::getline(std::cin, line)) {
		std::stringstream	ss(line);
		std::vector<int>	nums;
		int					x;

		while (ss >> x)
			nums.push_back(x);

		n.push_back(nums);
	}
	
	youngPhysicist(n);
	return (0);
}
