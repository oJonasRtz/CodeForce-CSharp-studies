#include <iostream>
#include <vector>

class TheaterSquares {
	public:
		static unsigned long long solve(const std::vector<int>& nma) {
			try {
				if (nma.size() != 3)
					throw std::invalid_argument("Invalid number of arguments");

				int n = nma[0];
				int m = nma[1];
				int a = nma[2];

				unsigned long long x = n / a + (n % a != 0);
				unsigned long long y = m / a + (m % a != 0);

				return (x * y);
			} catch (const std::invalid_argument& e) {
				std::cerr << e.what() << std::endl;
				return 0;
			}
		}
};

int main(void) {
	std::vector<int> n(3);

	for (int i = 0; i < n.size(); i++) {
		std::cin >> n[i];
		n[i] = static_cast<int>(n[i]);
	}

	std::cout << TheaterSquares::solve(n) << std::endl;
	return (0);
}
