from Triad import Triad

Days31 = [1, 3, 5, 7, 8, 10, 12]
Days30 = [4, 6, 9, 11]


def correction(num):
    num_ = num
    if 10 > int(num) >= 0:
        num_ = "0" + str(num)
    elif 0 > int(num) > -10:
        num_ = "-0" + str(-int(num))
    return num_


class Date (Triad):
    def __init__(self, first, second, third):
        super().__init__(first, second, third)

    def increase_first(self, num):
        i = 0
        while i < num:
            self.first += 1
            if Days30.__contains__(self.second):
                if self.first == 30:
                    self.increase_second(1)
                    self.first = 0
            elif Days31.__contains__(self.second):
                if self.first == 31:
                    self.increase_second(1)
                    self.first = 0
            else:
                if self.first == 28:
                    self.increase_second(1)
                    self.first = 0
            i += 1

    def increase_second(self, num):
        i = 0
        while i < num:
            self.second += 1
            if self.second == 12:
                self.increase_third(1)
                self.second = 0
            i += 1

    def increase_third(self, num):
        self.third += num

    def reduce_first(self, num):
        i = 0
        while i < num:
            self.first -= 1
            if self.first == 0:
                if Days30.__contains__(self.second - 1):
                    self.reduce_second(1)
                    self.first = 30
                elif Days31.__contains__(self.second-1):
                    self.reduce_second(1)
                    self.first = 31
                else:
                    self.reduce_second(1)
                    self.first = 28
            i += 1

    def reduce_second(self, num):
        i = 0
        while i < num:
            self.second -= 1
            if self.second == 0:
                self.reduce_third(1)
                self.second = 12
            i += 1

    def reduce_third(self, num):
        self.third -= num

    def date_validation(self):
        if self.first > 30 and Days30.__contains__(self.second):
            number = self.first - 29
            self.first = 29
            self.increase_first(number)
        elif self.first > 31 and Days31.__contains__(self.second):
            number = self.first - 30
            self.first = 30
            self.increase_first(number)
        elif self.first > 27 and self.second == 2:
            number = self.first - 27
            self.first = 27
            self.increase_first(number)

    def print_date(self):
        print("{first}.{second}.{third}".format(first=correction(self.first), second=correction(self.second),
                                                third=correction(self.third)))

