create table UserCredentials
(
	USER_ID INT PRIMARY KEY auto_increment,
	USER_USERNAME VARCHAR(50) NOT NULL,
	USER_PASSWORD VARCHAR(50) NOT NULL
);


create table UserDetails
(
	USER_ID INT NOT NULL,
	USER_NAME VARCHAR(255) NOT NULL,
	USER_EMPLOYEEID VARCHAR(50) NOT NULL,
	USER_COMPANY VARCHAR(255) NOT NULL,
	FOREIGN KEY(USER_ID) REFERENCES UserCredentials(USER_ID)
);

create table PolicyDetails
(
	POLICY_ID INT PRIMARY KEY auto_increment,	
	POLICY_NAME VARCHAR(255) NOT NULL,
	POLICY_INSURER VARCHAR(255) NOT NULL,
	POLICY_TPA VARCHAR(255) NOT NULL
);

create table UserPolicy
(
	USER_ID INT NOT NULL,
	POLICY_ID INT NOT NULL,
	USER_POLICYFROM DATE NOT NULL,
	USER_POLICYTO DATE NOT NULL,
	FOREIGN KEY(USER_ID) REFERENCES UserCredentials(USER_ID),
	FOREIGN KEY(POLICY_ID) REFERENCES PolicyDetails(POLICY_ID)
);



create table UserPaymentDetail
(
	PAYMENT_ID INT PRIMARY KEY auto_increment,
	USER_CARDNAME VARCHAR(255) NOT NULL,
	USER_CARDNUMBER BIGINT NOT NULL,
	USER_CVV INT NOT NULL,
	USER_CARDVALIDITY VARCHAR(5) NOT NULL,
	USER_ID INT,
	FOREIGN KEY(USER_ID) REFERENCES UserCredentials(USER_ID)
);



INSERT INTO UserCredentials (USER_USERNAME, USER_PASSWORD) VALUES
('Rajesh_Kumar', 'rajesh@123'),
('Sunita_Gupta', 'sunita@456'),
('Vikram_Singh', 'vikram@789');

INSERT INTO UserDetails (USER_ID, USER_NAME, USER_EMPLOYEEID, USER_COMPANY) VALUES
(1, 'Rajesh Kumar', 'EMP123', 'Indian Railways'),
(2, 'Sunita Gupta', 'EMP456', 'State Bank of India'),
(3, 'Vikram Singh', 'EMP789', 'Tata Motors');

INSERT INTO PolicyDetails (POLICY_NAME, POLICY_INSURER, POLICY_TPA) VALUES
('Health Insurance', 'Life Insurers Inc.', 'Star Health'),
('Car Insurance', 'Insurance Providers Ltd.', 'National Insurance'),
('Home Insurance', 'Home Insurance Corp.', 'Bajaj Allianz');

INSERT INTO UserPolicy (USER_ID, POLICY_ID, USER_POLICYFROM, USER_POLICYTO) VALUES
(1, 1, STR_TO_DATE('01-01-2024', '%d-%m-%Y'), STR_TO_DATE('31-12-2024', '%d-%m-%Y')),
(2, 1, STR_TO_DATE('15-02-2024', '%d-%m-%Y'), STR_TO_DATE('14-02-2025', '%d-%m-%Y')),
(3, 1, STR_TO_DATE('20-03-2024', '%d-%m-%Y'), STR_TO_DATE('19-03-2025', '%d-%m-%Y')),
(1, 2, STR_TO_DATE('10-01-2024', '%d-%m-%Y'), STR_TO_DATE('09-01-2025', '%d-%m-%Y')),
(2, 2, STR_TO_DATE('05-04-2024', '%d-%m-%Y'), STR_TO_DATE('04-04-2025', '%d-%m-%Y')),
(3, 2, STR_TO_DATE('22-07-2024', '%d-%m-%Y'), STR_TO_DATE('21-07-2025', '%d-%m-%Y')),
(1, 3, STR_TO_DATE('03-06-2024', '%d-%m-%Y'), STR_TO_DATE('02-06-2025', '%d-%m-%Y')),
(2, 3, STR_TO_DATE('18-08-2024', '%d-%m-%Y'), STR_TO_DATE('17-08-2025', '%d-%m-%Y')),
(3, 3, STR_TO_DATE('29-11-2024', '%d-%m-%Y'), STR_TO_DATE('28-11-2025', '%d-%m-%Y'));


INSERT INTO UserPaymentDetail (USER_CARDNAME, USER_CARDNUMBER, USER_CVV, USER_CARDVALIDITY, USER_ID) VALUES
('Rajesh Kumar', 1234567890123456, 123, '12/26', 1),
('Sunita Gupta', 2345678901234567, 234, '11/25', 2),
('Vikram Singh', 3456789012345678, 345, '10/24', 3);

select * from UserPolicy;