from functions import *


class Time(Triad):
    def __init__(self, first, second, third):
        super().__init__(first, second, third)

    def increase_first(self, num):
        self.first += num

    def increase_second(self, num):
        i = 0
        while i < num:
            self.second += 1
            if self.second == 60:
                self.increase_first(1)
                self.second = 0
            i += 1

    def increase_third(self, num):
        i = 0
        while i < num:
            self.third += 1
            if self.third == 60:
                self.increase_second(1)
                self.third = 0
            i += 1

    def reduce_first(self, num):
        self.first -= num

    def reduce_second(self, num):
        i = 0
        while i < num:
            self.second -= 1
            if self.second == 0:
                self.reduce_first(1)
                self.second = 60
            i += 1

    def reduce_third(self, num):
        i = 0
        while i < num:
            self.third -= 1
            if self.third == 0:
                self.reduce_second(1)
                self.third = 60
            i += 1

    def print_time(self):
        print("{first}:{second}:{third}".format(first=correction(self.first), second=correction(self.second),
                                                third=correction(self.third)))
