#include <iostream>
#include <string>
#include <map>
#include <vector>
#include <iterator>
#include <algorithm>
#include <sstream>

int main()
{
    std::stringstream   my_ss;
    std::string _string = "0";
    long double ld;
    std::map<std::string, long double>  my_map;
    my_ss << _string;
    my_ss >> ld;
    // std::cout << "Double Value: " << ld << std::endl;
    my_map.insert(std::pair<std::string, long double>("2009-01-02", ld));
    _string = "0.35";
    my_ss << _string;
    my_ss >> ld;
    // std::cout << "String: " << _string << std::endl;
    std::cout << "Double Value: " << ld << std::endl;
    // for (std::map<std::string, long double>::iterator   it = my_map.begin(); it != my_map.end(); it++)
    // {
    //     std::cout << "Date: " << it->first << ", Value: " << it->second << std::endl;
    // }
    return 0;
}
