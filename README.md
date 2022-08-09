# LogAPI
API Documentation：https://documenter.getpostman.com/view/14269273/VUjMo5rP

Assumptions:1. LogAPI receives log data by http post method;
            2. Log data may contain mutiple log records;
            3. All the data fields are required;
            4. Data is transformed by Json format;
            5. Log records will be writen to different destinations;
            
Two destinations: log file and database(sqlite)

Summary: This project is implemented using .netcore3.1. It only covers the basic case. As i don't know much about 
kafka, mq and flatfile, they are not implemented and left with empty methods. Normal log file
and sqlite database are used as two different destinations in this project. 


            
