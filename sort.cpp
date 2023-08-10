// Online C++ compiler to run C++ program online
#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>

class PmergeMe
{
    public:
        PmergeMe() {};
        ~PmergeMe() {};
        std::vector<int>    vec;
        void    sortRecursive(std::size_t index, bool *trigger)
        {
            static int  iter;
            
            if (iter == 200)
            {
                iter--;
                return ;
            }
            if ((index >= 0) && ((index + 1) < vec.size()))
            {
                if (vec[index] > vec[index + 1])
                {
                    int tmp = vec[index];
                    
                    vec[index] = vec[index + 1];
                    vec[index + 1] = tmp;
                    iter++;
                    sortRecursive(0, trigger);
                }
                else
                {
                    iter++;
                    sortRecursive(++index, trigger);
                }
            }
            else
                *trigger = true;
        };
};


// void    sort(std::vector<int> &vec)
// {
//     sortRecursive(0);
// }

int main()
{
    PmergeMe    Pm;
    bool        trigger = false;
    
    for (int i = 0; i < 200; i++)
        Pm.vec.push_back(rand() % 10000);
    std::cout << "**********Start**********\n\n";
    for (std::vector<int>::iterator it = Pm.vec.begin(); it != Pm.vec.end(); it++)
        std::cout << *it << std::endl;
    std::cout << "\n**********End**********\n\n";
    while (!trigger)
        Pm.sortRecursive(0, &trigger);
    std::cout << "**********Start**********\n\n";
    for (std::vector<int>::iterator it = Pm.vec.begin(); it != Pm.vec.end(); it++)
        std::cout << *it << std::endl;
    std::cout << "\n**********End**********\n\n";
    // std::cout << Pm.vec.size() << std::endl;
    return 0;
}
