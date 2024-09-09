#ifndef MENU_H
#define MENU_H

#include "MenuItem.h"
#include <vector>

class Menu {
private:
    std::vector<MenuItem> items;

public:
    void addMenuItem(const std::string& name, double price);
    void displayMenu() const;
    MenuItem getMenuItem(int index) const;
    bool isEmpty() const;
};

#endif // MENU_H

