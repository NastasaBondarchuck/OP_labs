from abc import *


class Triad:
    def __init__(self, first, second, third):
        self.first = first
        self.second = second
        self.third = third

    @abstractmethod
    def increase_first(self, num):
        pass

    @abstractmethod
    def increase_second(self, num):
        pass

    @abstractmethod
    def increase_third(self, num):
        pass

    @abstractmethod
    def reduce_first(self, num):
        pass

    @abstractmethod
    def reduce_second(self, num):
        pass

    @abstractmethod
    def reduce_third(self, num):
        pass
