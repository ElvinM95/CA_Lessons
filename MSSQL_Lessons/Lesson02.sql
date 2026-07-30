USE P416
SELECT LEN(Name) NameLenth FROM Students
SELECT CHARINDEX('@',Email) Email FROM Students
SELECT SUBSTRING(Email,1,3) Email FROM Students
SELECT SUBSTRING(Email,0,CHARINDEX('@',Email)) Email FROM Students
SELECT SUBSTRING(Email,CHARINDEX('@',Email),LEN(Email)) Email FROM Students
SELECT SUM(Age) FROM Students
SELECT AVG(Age) FROM Students
SELECT MIN(Age) FROM Students
SELECT MAX(Age) FROM Students
SELECT * FROM Students WHERE Age>(SELECT AVG(Age) FROM Students)