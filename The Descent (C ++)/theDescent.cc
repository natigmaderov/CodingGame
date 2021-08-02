#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

  while (1) {
    int max = 0;
    int max_i = 0;
    for (int i = 0; i < 8; i++) {
      int MH;
      cin >> MH; cin.ignore();
      if (max < MH) {
        max = MH;
        max_i = i;
      }
    }
    cout << max_i << endl;
  }
}
