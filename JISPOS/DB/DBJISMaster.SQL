Create Database HariOm

use HariOm

-----------Common----------

Create table EForm
(
EFormId		numeric(18) Primary Key,
EFormCode	nvarchar(20) Unique,
MillName	nvarchar(255),
PartyName	nvarchar(255),
BillingName	nvarchar(255),
PeriodFrom	nvarchar(155),
PeriodYear	nvarchar(155),		
Amount		float,
CFormNo		nvarchar(155),
CAmount		float,
CFormRcDate	datetime,
CFormSentDate	datetime,
CourierName	nvarchar(255),
CourierNo	nvarchar(255),
E1FormNo	nvarchar(155),
E1Amount	float,
E1Date		datetime,
CStatus		nvarchar(255),
E1Status	nvarchar(255),
)

CREATE TABLE AutoGeneration 
(
	AGNID			numeric(18) Primary Key,  
	AGNCode			nvarchar (20) Unique,
	TableName		nvarchar (50) Unique,
	prefix			nvarchar (10) Unique,
	KeySize			numeric (3),
	StartFrom		numeric (10)
)

CREATE TABLE CompanyDetails
(
	CompanyId		numeric(20)Primary Key,
	CompanyCode		nvarchar(50)Unique,
	CompanyName		nvarchar(50)Unique,
	Address			nvarchar(2000),
	PhNo			nvarchar(50),
	MobileNo		nvarchar(50),
	MailId			nvarchar(100),
	Tin				nvarchar(50),
	Cst				nvarchar(50)
)

create table ColorSchema
(
	ColorId					nvarchar(20),
	ColorCode				nvarchar(20),
	staffName				nvarchar(20),
	FColor					nvarchar(30),
	BColor					nvarchar(30),
	Grid1stFColor			nvarchar(30),
	Grid2stFColor			nvarchar(30),
	Grid1stBColor			nvarchar(30),
	Grid2stBColor			nvarchar(30),
	btnBordercolor			nvarchar(30),
	btnMouseDownBackcolor	nvarchar(30),
	btnMouseOverBackcolor	nvarchar(30),
	GridHeading				nvarchar(30), 
	lbltitle				nvarchar(30)
)

CREATE TABLE LedgerReport 
(
	LReportId		numeric(18) Primary Key,
	LReportCode		nvarchar (20) Unique,
	VoucherNo		nvarchar (20),
	VoucherType		nvarchar (20),
	LDate			datetime,
	LedgerName		nvarchar (100),
	Particulars		nvarchar(100),
	Narration		nvarchar(255),
	ACType			nvarchar(30),
	DRAmount		float,
	CRAmount		float,
	GroupName		nvarchar(50),
	PaymentDate		datetime,
	LFrom			nvarchar(50),
	LTo				nvarchar(50),
	RefNo			nvarchar(50),
	FU1				nvarchar(100),
	FU2				nvarchar(100),
	FU3				nvarchar(100)
) 


create table SoftValidation
(
	SVId				nvarchar(20) Primary Key,
	SVCode				nvarchar(20) unique,
	AvailableTimes		float
)

create table TextTranslation
(
	TTId				numeric(18) Primary Key,
	TTCode				nvarchar(20) Unique,
	TTEnglish			nvarchar(200),
	TTTamil				nvarchar(200)
)


-------------Master---------------------
CREATE TABLE UnitsOfMeasurement
(
	UOMId			numeric(18) Primary Key,
	UOMCode			nvarchar (20) Unique,
	UOMSymbol		nvarchar (20) Unique,
	formalname		nvarchar (50)
)
CREATE TABLE TaxMaster 
(
	TaxId			numeric(18) Primary Key,
	TaxCode			varchar (20) Unique,
	TaxValue		float Unique,
	Narration		varchar(50)
) 

CREATE TABLE Party
(
	PartyId			numeric(18) Primary Key,
	PartyCode		nvarchar (20) Unique,
	LedgerName		nvarchar(50) Unique,
	PartyName		nvarchar(50),
	AddressLine1	nvarchar(220),
	AddressLine2	nvarchar(220),
	MobileNo		nvarchar(50),
	TelePhoneNo		nvarchar(50),
	CST				nvarchar(50),	
	TinNo			nvarchar(50),
	EMailId			nvarchar(50)
)
CREATE TABLE Mill 
(
	MillId			numeric(18) Primary Key,
	MillCode		nvarchar (20) Unique,
	LedgerName		nvarchar(50) Unique,
	MillName		nvarchar(50),
	AddressLine1	nvarchar(220),
	AddressLine2	nvarchar(220),
	MobileNo		nvarchar(50),
	TelePhoneNo		nvarchar(50),
	CST				nvarchar(50),	
	TinNo			nvarchar(50),
	EMailId			nvarchar(50)
)

CREATE TABLE Products
(
	ProductId		numeric(18) Primary Key,
	ProductCode		nvarchar (20) Unique,
	ProductName		nvarchar(50) Unique,
	ItemCode		nvarchar(50),	
	PurchaseRate	float,
	SellingRate		float,
	UOMSymbol		nvarchar(20)
)

CREATE TABLE Ledger 
(
	LedgerId		numeric(18) Primary Key,
	LedgerCode		nvarchar (20) Unique,
	LedgerName		nvarchar(50) Unique,
	BillingName		nvarchar(50),
	Address			nvarchar(500),
	Phone			nvarchar(20),
	Mobile			nvarchar(20),
	MailId			nvarchar(50),
	CreditDays		nvarchar(5),
	CreditLimit		nvarchar(10),
	Note			nvarchar(50)
)  


create table UserAccount
(
	UserId			numeric(20) primary key,
	UserCode		nvarchar(50) UNIQUE,
	CompanyName		nvarchar(50),
	UserName		nvarchar(50),
	Password		nvarchar(20),
	UserType		nvarchar(30)
)

create table CompanyInfo
(
	CompanyId		numeric(20) primary key,
	CompanyCode		nvarchar(50) UNIQUE,
	CompanyName		nvarchar(550) Unique
	
)

--------------Transaction-------------
Create table DebitNote
(
DNId		numeric(18) Primary key,
DNCode		nvarchar(20) Unique,
MillName	nvarchar(255),
BillingName	nvarchar(255),
Address		nvarchar(555),
BillDate	datetime,
NoOfBags	float,
TotalKg		float,
Amount		float,
ExMillAmount	float,
BillQuarter	nvarchar(155),
NYear		nvarchar(15),
CommissionPer	float,
CommissionAmt	float,
ServiceTax	float,
TaxAmount	float,
TotalAmount	float,
TDSAmt		float,
TDSyr		nvarchar(155),
CompanyName	nvarchar(155),
ChequeAmt	float, 
ChequeNo	nvarhcar(155),
ChequeDate	datetime
)
Create Table DebitNodeDetials
(
	DNDId	Numeric(18) Primary key,
	DNDCode	nvarchar(20) unique,
	DNCode	nvarchar(20),
	SNo		numeric(5),
	MWDate  DateTime,
	Invoice	nvarchar(20),
	PartyName nvarchar(50),
	NoOfBags	numeric(10),
	Weight		Numeric(10),
	TotalKg		Numeric(10),
	Rate		Numeric(10),
	Amount		Numeric(10),
	[Count] 	nvarchar(50),
	MWCode		nvarchar(20)
)

Create table CForm
(
CFId		numeric(18) Primary key,
CFCode		nvarchar(20) Unique,
MillName	nvarchar(255),
CDateFrom	datetime,
CDateTo		datetime,
CFormNo		nvarchar(155),
CAmount		float,
EFormNo		nvarchar(155),
E1Date		datetime,
Amount		float,
Narration	nvarchar(555)
)

Create table MillWorking
(
MWId		numeric(18) Primary key,
MWCode		nvarchar(20) Unique,
MillName	nvarchar(255),
MWDate		datetime,
Type		nvarchar(155),
InvoiceNo	nvarchar(155),
CFormNo		nvarchar(155),
CAmount		float,
EFormNo		nvarchar(155),
E1Date		datetime,
ItemAmount	float,
TaxPer		float,
TaxAmt		float,
DisAmt		float,
Extras		float,
Advance		float,
TotalAmount	float,
Outstanding	float
)

Create table MillWorkingDetails
(
MWDId		numeric(18) Primary key,
MWDCode		nvarchar(20) Unique,
MWCode		nvarchar(20) FOREIGN KEY REFERENCES MillWorking(MWCode),
SNo			int,
RecdDate	datetime,
Amount		float
)
Create table MonthlyWorking
(
MOWId		numeric(18) Primary key,
MOWCode		nvarchar(20) Unique,
MillName	nvarchar(255),
MOWDate		datetime,
Type		nvarchar(155),
Address		nvarchar(555),
InvoiceNo	nvarchar(155),
ItemAmount	float,
TaxPer		float,
TaxAmt		float,
DisAmt		float,
Extras		float,
Advance		float,
TotalAmount	float,
Narration	nvarchar(555)
)
Create table MonthlyWorkingDetails
(
MOWDId		numeric(18) Primary key,
MOWDCode	nvarchar(20) Unique ,
MOWCode		nvarchar(20) FOREIGN KEY REFERENCES MonthlyWorking(MOWCode),
SNo			int,
PartyName	nvarchar(255),
NoOfBags	float,
Weight		float,
UOM			nvarchar(155),
Rate		nvarchar(155),
Amount		float
)

Create table CFormDetails
(
CDetailsId		numeric(18) Primary Key,
CDetailsCode	nvarchar(20) Unique,
MasterCode		nvarchar(55),
SNo				int,
MonthlyCode		nvarchar(55),
Amount			float
)

Create table PartyWorking
(
PartyId		numeric(18) Primary key,
PartyCode	nvarchar(20) Unique,
MillName	nvarchar(255),
PWDate		datetime,
Type		nvarchar(155),
InvoiceNo	nvarchar(155),
CFormNo		nvarchar(155),
CAmount		float,
EFormNo		nvarchar(155),
E1Date		datetime,
ItemAmount	float,
TaxPer		float,
TaxAmt		float,
DisAmt		float,
Extras		float,
Advance		float,
TotalAmount	float,

)
Create table PartyWorkingDetails
(
PWDId		numeric(18) Primary key,
PWDCode		nvarchar(20) Unique,
PartyCode	nvarchar(20) FOREIGN KEY REFERENCES PartyWorking(PartyCode),
SNo			int,
PartyName	nvarchar(255),
NoOfBags	float,
Weight		float,
UOM			nvarchar(155),
Rate		nvarchar(155),
Amount		float
)

CREATE TABLE Payment 
(
	PaymentId		numeric(18) Primary Key,
	PaymentCode		nvarchar (20) Unique,
	PaymentDate		datetime,
	PaymentTo		nvarchar(50),
	PayName			nvarchar(50),
	PaymentFrom		nvarchar(155),
	PayAmount		float,
	Details			nvarchar(50),
	Narration		nvarchar(100)  
)

CREATE TABLE Receipt
(
	ReceiptId		numeric(18) Primary Key,
	ReceiptCode		nvarchar (20) Unique,
	ReceiptDate		datetime,
	ReceiptFrom		nvarchar(50),
	Fromm			nvarchar(155),
	ReceiptTo		nvarchar(50),
	ReceiptAmount	float,
	Details			nvarchar(50),
	Narration		nvarchar(100)  
)
create table ReceiptBill
(
	ReceiptBillId		numeric(18)primary key,
	ReceiptBillCode		nvarchar(20)unique,
	ReceiptBillFrom		nvarchar(50),
	ReceiptBillDate		datetime,
	ReceiptBillMode		nvarchar(20),
	ReceiptBillAmount	numeric(18),
	BankName			nvarchar(50),
	ChequeNo			nvarchar(20),
	ChequeDate			nvarchar(20),
	Narration			nvarchar(100)
)

create table StockDetail
(
	StockDetailid	numeric(18) primary key,
	StockDetailcode	nvarchar(20)unique,
	StockName		nvarchar(50),
	Inwards			int,
	Outwards		int,
	UOM				nvarchar(20)
)


CREATE TABLE Stock 
(
	StockId			numeric(18) Primary Key,
	StockCode		nvarchar (20) Unique,
	VoucherNo		nvarchar (50),
	VoucherType		nvarchar (50),
	SDate			datetime,
	ProductName		nvarchar (50) ,
	Qunatity		float,
	Rate			float,
	UOM				nvarchar(50),	
	Amount			float,
	TaxPercentage	float ,
	TaxAmount		float,
	TotalAmount		float,
	Ledger			nvarchar(50),
	GodownName		nvarchar(50) ,
	GroupName		nvarchar(50)  
)

Create table PartyDebitNote
(
DNId		numeric(18) Primary key,
DNCode		nvarchar(20) Unique,
MillName	nvarchar(255),
BillingName	nvarchar(255),
Address		nvarchar(555),
BillDate	datetime,
NoOfBags	float,
TotalKg		float,
Amount		float,
ExMillAmount	float,
BillQuarter	nvarchar(155),
NYear		nvarchar(15),
CommissionPer	float,
CommissionAmt	float,
ServiceTax	float,
TaxAmount	float,
TotalAmount	float,
TDSAmt		float,
TDSyr		nvarchar(155),
CompanyName	nvarchar(155),
ChequeAmt	float, 
ChequeNo	nvarhcar(155),
ChequeDate	datetime
)
Create Table PartyDebitNodeDetials
(
	DNDId	Numeric(18) Primary key,
	DNDCode	nvarchar(20) unique,
	DNCode	nvarchar(20),
	SNo		numeric(5),
	MWDate  DateTime,
	Invoice	nvarchar(20),
	PartyName nvarchar(50),
	NoOfBags	numeric(10),
	Weight		Numeric(10),
	TotalKg		Numeric(10),
	Rate		Numeric(10),
	Amount		Numeric(10),
	[Count] 	nvarchar(50),
	MWCode		nvarchar(20)
)
---------------Insertion------------------

Insert into AutoGeneration values('0001','AGN0001','AutoGeneration','AGN','4','1')
Insert into AutoGeneration values('0002','AGN0002','CompanyDetails','CMD','4','1')
Insert into AutoGeneration values('0003','AGN0003','UnitsOfMeasurement','UOM','4','1')
Insert into AutoGeneration values('0004','AGN0004','Products','PRO','4','1')
Insert into AutoGeneration values('0005','AGN0005','PTY','Party','4','1')
Insert into AutoGeneration values('0006','AGN0006','Mill','MIL','4','1')
Insert into AutoGeneration values('0007','AGN0007','StockDetail','STK','4','1')
Insert into AutoGeneration values('0008','AGN0008','Ledger','LED','4','1')
Insert into AutoGeneration values('0009','AGN0009','CForm','CFM','4','1')
Insert into AutoGeneration values('0010','AGN0010','UserAccount','UAC','4','1')
Insert into AutoGeneration values('0011','AGN0011','MillWorking','MWK','4','1')
Insert into AutoGeneration values('0012','AGN0012','MillWorkingDetails','MWD','4','1')
Insert into AutoGeneration values('0013','AGN0013','MonthlyWorking','MOW','4','1')
Insert into AutoGeneration values('0014','AGN0014','MonthlyWorkingDetails','MOD','4','1')
Insert into AutoGeneration values('0015','AGN0015','PartyWorking','PWR','4','1')
Insert into AutoGeneration values('0016','AGN0016','PartyWorkingDetails','PWD','4','1')
Insert into AutoGeneration values('0018','AGN0018','Payment','PAY','4','1')
Insert into AutoGeneration values('0019','AGN0019','Receipt','RCP','4','1')
Insert into AutoGeneration values('0020','AGN0020','ReceiptBill','RCB','4','1')
Insert into AutoGeneration values('0021','AGN0021','TaxMaster','TAX','4','1')
