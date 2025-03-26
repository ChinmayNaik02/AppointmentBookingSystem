CREATE DATABASE AppointmentBookingSystem;

USE AppointmentBookingSystem;

CREATE TABLE Users(
	UserID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Age int NOT NULL,
	EmailId nvarchar(100) UNIQUE,
	UserPassword nvarchar(50) NOT NULL,
	UserRole nvarchar(50) NOT NULL,
	);

Create table ServiceProviders(
	ServiceProviderId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Age int NOT NULL,
	EmailId nvarchar(100),
	ServiceProviderRole nvarchar(50) NOT NULL,
	Specialization nvarchar(100),
);

Create table Appointments(
	AppointmentId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	UserId int NOT NULL,
	ServiceProviderId int NOT NULL,
	AppointmentDescription nvarchar(max),
	FOREIGN KEY(UserId) REFERENCES Users(UserId),
	FOREIGN KEY(ServiceProviderId) REFERENCES ServiceProviders(ServiceProviderId),
);

Create table Slots(
	SlotId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	SlotDate DATE NOT NULL,
	SlotStartTime TIME NOT NULL,
	SlotEndTime TIME NOT NULL,
	ServiceProviderId int NOT NULL,
	FOREIGN KEY(ServiceProviderId) REFERENCES ServiceProviders(ServiceProviderId),
);