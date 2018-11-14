
create table Users(

UserId nchar(9) primary key,

FirstName nvarchar(25) not null,

LastName nvarchar(25) not null,

Permission nvarchar(25) not null,

Password nchar(15) not null default 'diagnobile',


CONSTRAINT d_1 check(UserId like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);


create table Patients(

PatientId nchar(9) primary key,

FirstName nvarchar(25) not null,

LastName nvarchar(25) not null,

DateBirth DATE,

ChronicDiseases nvarchar(255),
Sensitivity nvarchar(255),
CONSTRAINT d_2 check(PatientId like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);


create table Treatments(

TreatmentNum int IDENTITY(1,1) primary key,

PatientId nchar(9) FOREIGN KEY REFERENCES Patients(PatientId),

NurseId nchar(9) FOREIGN KEY REFERENCES Users(UserId),

DoctorId nchar(9) FOREIGN KEY REFERENCES Users(UserId),

BodyTemperature nvarchar(25) not null,

BloodPressure nvarchar(25) not null
,
Pulse nvarchar(25)
,
Complaints nvarchar(255)
,
EstimatedDiagnosis nvarchar(255),
ContinuingCare nvarchar(255),
FinalDiagnosis
 nvarchar(255),
TreatmentRequired nvarchar(255),
TreatmentStatus nvarchar(50));

create table TreatmentsTimes(

TreatmentNum int primary key FOREIGN KEY REFERENCES Treatments(TreatmentNum),

ReceptionTime time,

StartNurseTreatment time,

EndNurseTreatment time,

StartDoctorTreatment time,

EndDoctorTreatment time,

ReleaseTime time
);


create table Symptoms(

SymptomNum int IDENTITY(1,1) primary key,

SymptomDescription nchar(255) not null
);


create table SymptomsTreatments(

TreatmentNum int FOREIGN KEY REFERENCES Treatments(TreatmentNum),

SymptomNum int FOREIGN KEY REFERENCES Symptoms(SymptomNum),

RemarksSymptoms nchar(255),

CONSTRAINT d_3 PRIMARY KEY(TreatmentNum,SymptomNum));


create table Organs(

OrganNum int IDENTITY(1,1) primary key,

OrganDescription nchar(255),
PartBody nchar(255));


create table OrgansTesting(

SymptomNum int FOREIGN KEY REFERENCES Symptoms(SymptomNum),

OrganNum int FOREIGN KEY REFERENCES Organs(OrganNum),
CONSTRAINT d_4 PRIMARY KEY(SymptomNum,OrganNum));

create table FindingsTreatments(

TreatmentNum int FOREIGN KEY REFERENCES Treatments(TreatmentNum),

OrganNum int FOREIGN KEY REFERENCES Organs(OrganNum),

PartBody nchar(255),
ViewBody nchar(255),

Side nchar(255),

PrincipleType nchar(255),

FindingDescription nchar(255),

CONSTRAINT d_5 PRIMARY KEY(TreatmentNum,OrganNum));



create table PalpationFindingsTreatments(

TreatmentNum int FOREIGN KEY REFERENCES Treatments(TreatmentNum),

OrganNum int FOREIGN KEY REFERENCES Organs(OrganNum),

Repetitive nchar(255),
exactLocation nchar(255),
part nchar(255),

Side nchar(255),

FindingDescription nchar(255),

CONSTRAINT d_6 PRIMARY KEY(TreatmentNum,OrganNum));

create table TestsTreatments(

TreatmentNum int FOREIGN KEY REFERENCES Treatments(TreatmentNum),
PatientId nchar(9) FOREIGN KEY REFERENCES Patients(PatientId),

TestType nchar(255),

TestName nchar(255),

TestValue nchar(255),

CONSTRAINT d_7 PRIMARY KEY(TreatmentNum,PatientId));