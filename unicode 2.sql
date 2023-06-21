use CatalogVirtual;
create table [Cadre Didactice]
(
Nume nvarchar(50) not null,
Prenume nvarchar(60) not null,
[Marcă Angajat] nchar(10) not null,/*id alfanumeric*/
Titlu nvarchar(20) not null,
Post nvarchar(50) not null,
constraint c11 primary key([Marcă Angajat])
);
insert into [Cadre Didactice] values
('Marius',N'Budăi','123ABC123F','dr. ing.',N'conferențiar universitar'),
('Dorin',N'Vasile','223ABC123F','dr. pr. ','CDA');
select * from [Cadre Didactice];


create table Utilizatori
(
Tip nvarchar(20) not null,
[Nume utilizator] nvarchar(200),
[Parolă] nvarchar(200),
constraint c20 check (Tip='administrator' or Tip='secretar' or Tip='cadru didactic'),
constraint pk20 primary key(Tip,[Nume utilizator],[Parolă])
);
insert into Utilizatori values
('administrator','',''),
('administrator','Alfa1','Beta1'),
('administrator','Alfa2','Beta2'),
('secretar','',''),
('secretar','Gama3','Delta3'),
('secretar','Gama4','Delta4'),
('cadru didactic','',''),
('cadru didactic','Ceva1','Ceva2'),
('cadru didactic','Ceva3','Ceva4');

alter table [DPM-DI Discipline Licență]
add constraint pk98 primary key([Disciplină]);

create table Note
(
Nume nvarchar(50) not null,
Prenume nvarchar(60) not null,
[Număr matricol] nvarchar(10) not null,
Nota smallint not null,
[Disciplină] nvarchar(150) not null,
constraint fk100 foreign key([Disciplină]) references [DPM-DI Discipline Licență]([Disciplină]),
constraint fk97 foreign key(Nume,Prenume,[Număr matricol]) references Student(Nume,Prenume,[Număr matricol])
);

select * from Student;

insert into Student values 
('@a','@b','@c','@','')
char m='A';
