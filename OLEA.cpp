#include "Order.h"
#include <iostream>
#include <stdexcept> // Include this for std::out_of_range

void Order::addItem(const MenuItem& item) {
    orderItems.push_back(item);
}

void Order::viewOrder() const {
    if (orderItems.empty()) {
        std::cout << "Order is empty." << std::endl;
        return;
    }
    for (const auto& item : orderItems) {
        std::cout << item.getName() << " - $" << item.getPrice() << std::endl;
    }
}

double Order::calculateTotal() const {
    double total = 0.0;
    for (const auto& item : orderItems) {
        total += item.getPrice();
    }
    return total;
}

bool Order::isEmpty() const {
    return orderItems.empty();
}

