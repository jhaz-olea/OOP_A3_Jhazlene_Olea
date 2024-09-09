#ifndef ORDER_H
#define ORDER_H

#include "MenuItem.h"
#include <vector>

class Order {
private:
    std::vector<MenuItem> orderItems;

public:
    void addItem(const MenuItem& item);
    void viewOrder() const;
    double calculateTotal() const;
    bool isEmpty() const;
};

#endif // ORDER_H

