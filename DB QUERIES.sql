CREATE TABLE GARUREG(USID INT NOT NULL PRIMARY KEY,UNAME CHAR(20),USERNAME VARCHAR(20),PASS VARCHAR(20),REPASS VARCHAR(20),DOB VARCHAR(15),GENDER CHAR(8),MOBILENO NUMBER(10),EMAILID VARCHAR(20),ADDRESS VARCHAR(40),PRIVILAGE CHAR(1));
SELECT * FROM GARUREG;
DROP TABLE GARUREG;

CREATE TABLE TASKUSERDATA(USID INT NOT NULL REFERENCES GARUREG,CAREERID INT NOT NULL PRIMARY KEY,DEPT CHAR(20),PROCESS CHAR(30),POSITION CHAR(30),CRDATE VARCHAR(20));
SELECT *  FROM TASKUSERDATA; 
drop table TASKUSERDATA;

CREATE TABLE TASKPROJECT(PRJID INT NOT NULL PRIMARY KEY, PRJNAME CHAR(40),PRJLAN VARCHAR(20),STDATE VARCHAR(20), ENDATE VARCHAR(20));
SELECT *  FROM TASKPROJECT;

CREATE TABLE TMSTASK(TASKID INT NOT NULL PRIMARY KEY,TASKNAME VARCHAR(30),DURATION VARCHAR(30));
SELECT *  FROM TMSTASK;

SELECT USID FROM GARUREG WHERE UNAME= 'Dineshkumar         ';

CREATE TABLE FEEDBACKDETAILS(FID INT NOT NULL PRIMARY KEY,ENTRYDATE VARCHAR(15),UNAME CHAR(20),POSITION VARCHAR(30),PROCESS VARCHAR(30),DEPT CHAR(30),DESCR VARCHAR(100));
SELECT * FROM FEEDBACKDETAILS;
drop table FEEDBACKDETAILS;  
SELECT MAX(FID) FROM FEEDBACKDETAILS;

commit;

update TASKPROJECT set PRJNAME='ebill' where PRJID=1;
    
    