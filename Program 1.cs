#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "Russian");
    int a, b;
    cout << "Введите в одной строке два целых числа и нажмите <Enter> ";
    cin >> a >> b;
    if (a == b) cout << "числа " << a << " и " << b << " равны";
    else cout << a << ((a < b) ? " меньше " : " больше ") << b;
    cout << endl;
    system("pause");
    return 0;
