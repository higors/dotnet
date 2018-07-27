﻿	CREATE TABLE ORDERS
	(
		ORDERID INT IDENTITY(1,1) PRIMARY KEY,
		SALESMAN VARCHAR(200),
		ORDERQUANTITY INT,
		ORDERDATE DATE
	)

	GO 

	CREATE TABLE ITEMS
	(
		ITEMID INT IDENTITY(1,1) PRIMARY KEY,
		DESCRIPTION VARCHAR(200),
		COST DECIMAL
	)

	GO

	ALTER TABLE ORDERS
	ADD IDITEM INT,
		CONSTRAINT FKIDITEM FOREIGN KEY(IDITEM) REFERENCES ITEMS(ITEMID)