#ifndef COFFEESHOP_H
#define COFFEESHOP_H

#include "Menu.h"
#include "Order.h"

class CoffeeShop {
private:
    Menu menu;
    Order order;

public:
    void displayMainMenu();
    
private:
    void addMenuItem();
    void viewMenu() const;
    void placeOrder();
    void viewOrder() const;
    void calculateTotal() const;
};

#endif // COFFEESHOP_H

