from random import randint
from Date import *
from Time import *


def correction(num):
    num_ = str(num)
    if 10 > num >= 0:
        num_ = "0" + str(num)
    elif 0 > num > -10:
        num_ = "-0" + str(-num)
    return num_


def choose_year():
    answer = input("Choose type of years (yy/yyyy): [2/4]    ")
    while answer != "2" and answer != "4":
        answer = input("Enter 2 or 4: ")
    return 100 if answer == 2 else 2030


def create_dates(year):
    dates_list = []
    num = int(input("Enter the number of dates: "))
    i = 0
    while i < num:
        first = randint(1, 32)
        second = randint(1, 12)
        third = randint(0, year)
        date = Date(first, second, third)
        dates_list.append(date)
        i += 1
    return dates_list


def create_times():
    times_list = []
    num = int(input("Enter the number of times: "))
    i = 0
    while i < num:
        first = randint(0, 100)
        second = randint(0, 60)
        third = randint(0, 60)
        time = Time(first, second, third)
        times_list.append(time)
        i += 1
    return times_list


def comparing(dates_list: list):
    copy = dates_list.copy()
    times_from_dates = []
    for date in copy:
        if date.third <= 59:
            time = Time(date.first, date.second, date.third)
            times_from_dates.append(time)
            dates_list.remove(date)
    if len(times_from_dates) == 0:
        time = Time("01", "01", "01")
        times_from_dates.append(time)
    return times_from_dates
