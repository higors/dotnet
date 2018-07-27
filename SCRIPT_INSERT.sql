INSERT INTO ITEMS(DESCRIPTION, COST)
VALUES	('TENIS', 240.00),
		('CAMISA P', 73.00),
		('CAMISA M', 73.00),
		('CALCA JEANS', 180.00);

GO

INSERT INTO ORDERS(IDITEM, OrderQuantity, Salesman, OrderDate)
VALUES	(1, 1, 'WANESSA', GETDATE()),
		(2, 2, 'ALICE', GETDATE()),
		(3, 1, 'ALICE', GETDATE()),
		(4, 1, 'JOHN', GETDATE());

GO

select * from ORDERS;

select * from ITEMS;