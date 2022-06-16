from functions import *


year = choose_year()
dates_list = create_dates(year)
times_list = create_times()
print("\nList of random dates: ")
for date in dates_list:
    date.date_validation()
    date.print_date()

print("\nList of random times: ")
for time in times_list:
    time.print_time()

times_from_dates = comparing(dates_list)
print("\nList of dates, which can be times: "
      "\nIf list haven't got any date, you will see '01:01:01'. ")
for time in times_from_dates:
    time.print_time()

print("\nReduced dates: ")
for date in dates_list:
    date.reduce_first(5)
    date.print_date()

print("\nIncreased times: ")
for time in times_list:
    time.increase_second(15)
    time.print_time()