

    /*
	CONSTRAINT CHK_Person CHECK (Age>=18 AND City='Sandnes')
	CREATE TABLE your_table ([NumeRomână] NVARCHAR(255), [AlteCaractereăîâșț] NVARCHAR(255));
	SELECT [NumeRomână], [AlteCaractereăîâșț] FROM your_table;[]
	*/

/* delete command
use master;drop database CatalogVirtual;
*/

create database CatalogVirtual;
use CatalogVirtual;
alter database CatalogVirtual collate Romanian_CI_AS;


create table Facultate
(
Denumire nvarchar(100) not null,
[Abreviere/Prescurtare] nvarchar(30) not null,
[Ani de studiu - Licență] smallint not null,
constraint pk primary key([Abreviere/Prescurtare]),
constraint c1 check ([Ani de studiu - Licență]>=3 and [Ani de studiu - Licență]<=10)
);
insert into Facultate values
(N'Facultatea de Design de produs și mediu','DPM',4),
(N'Facultatea de Inginerie electrică și știința calculatoarelor','IESC',4),
(N'Facultatea de Design de mobilier și inginerie a lemnului','DMIL',4),
(N'Facultatea de Inginerie mecanică',N'Mecanică',4),
(N'Facultatea de Inginerie tehnologică și management industrial','ITMI',4),
(N'Facultatea de Silvicultură și exploatări forestiere','Silvic',4),
(N'Facultatea de Știința și ingineria materialelor','SIM',4),
(N'Facultatea de Drept','Drept',4),
(N'Facultatea de Educație fizică și sporturi montane','Sport',3),
(N'Facultatea de Litere','Litere',3),
(N'Facultatea de Matematică și informatică','MateInfo',3),
(N'Facultatea de Medicină',N'Medicină',6),
(N'Facultatea de Muzică',N'Muzică',3),
(N'Facultatea de Psihologie și științele educației','PsihoEdu',3),
(N'Facultatea de Sociologie și comunicare','Socio',3),
(N'Facultatea de Științe economice și administrarea afacerilor','ECON',3),
(N'Facultatea de Alimentație și turism','AT',4),
(N'Facultatea de Construcții',N'Construcții',4);

create table [Specializare Licență]
(
Facultate nvarchar(30) not null, --de fapt sunt abrevieri iesc,dpm etc
Denumire nvarchar(250) not null,
Abreviere nvarchar(50) not null, -- aia,ti etc ptr celelalte
constraint pk1 primary key(Facultate,Abreviere),
constraint fk1 foreign key(Facultate) references Facultate ([Abreviere/Prescurtare])
);
insert into [Specializare Licență] values
('DPM','Design industrial','DI'),
('DPM',N'Design industrial (în limba engleză)',N'DI (în limba engleză)'),
('DPM','Ingineria sistemelor de energii regenerabile','ISER'),
('DPM',N'Ingineria și protecția mediului în industrie','IPMI'),
('DPM',N'Mecatronică',N'Mecatronică'),
('DPM','Optometrie','Optometrie'),
('DPM',N'Inginerie medicală','IM'),
('IESC',N'Electrotehnică','ET'),
('IESC',N'Inginerie electrică și calculatoare (în limba engleză)',N'ET (în limba engleză)'),
('IESC',N'Tehnologii și sisteme de telecomunicații','TST'),
('IESC','Calculatoare','Calculatoare'),
('IESC',N'Automatică și informatică aplicată','AIA'),
('IESC',N'Tehnologia informației','TI'),
('IESC',N'Robotică','Robo'),
('DMIL',N'Ingineria și designul produselor finite din lemn','IDPFL'),
('DMIL',N'Ingineria prelucrării lemnului','IPL'),
(N'Mecanică','Autovehicule rutiere','Auto'),
(N'Mecanică',N'Ingineria transportului și a traficului','ITT'),
(N'Mecanică',N'Inginerie mecanică','IM'),
('ITMI',N'Tehnologia construcțiilor de mașini','TCM'),
('ITMI',N'Sisteme de producții digitale','SPD'),
('ITMI',N'Ingineria și managementul calitații','IMC'),
('ITMI',N'Inginerie economică industrială','IEI'),
('ITMI',N'Ingineria și managementul afacerilor','IMA'),
('ITMI',N'Construcții aerospațiale','CA'),
('Silvic',N'Cinegetică',N'Cinegetică'),
('Silvic',N'Exploatări forestiere','EF'),
('Silvic',N'Silvicultură',N'Silvicultură'),
('Silvic',N'Măsurători Terestre și Cadastru','MTC'),
('SIM',N'Ingineria sudării','IS'),
('SIM',N'Ingineria securității în industrie','ISI'),
('SIM',N'Știința materialelor','SM'),
('SIM',N'Inginerie economică în domeniul mecanic','IEDM'),
('Drept','Drept','Drept'),
('Sport',N'Educație fizică și sportivă','EDS'),
('Sport',N'Kinoterapie și motricitate specială','KMS'),
('Sport',N'Sport și performanță motrică','SPM'),
('Litere',N'Limba și literatura română - Limba și literatura engleză/franceză/germană','RO-EFG'),
('Litere',N'Limba și literatura engleză și Limba și literatura franceză/germană/română','ENG-FGR'),
('Litere',N'Limba și literatura chineză - Limba și literatura română/engleză/franceză/germană','CHN-REFG'),
('MateInfo',N'Matematică-Informatică','MI'),
('MateInfo',N'Informatică','Info'),
('MateInfo',N'Informatică aplicată','IA'),
('MateInfo',N'Informatică aplicată (în limba germană)',N'IA (în limba germană'),
(N'Medicină',N'Medicină',N'Medicină'),
(N'Medicină',N'Asistență medicală generală','AMG'),
(N'Medicină','Balneofiziokinoterapie','BFKT'),
(N'Medicină','Laborator clinic','LC'),
(N'Muzică',N'Muzică',N'Muzică'),
(N'Muzică',N'Interpretare muzicală - Canto','IM-Canto'),
(N'Muzică',N'Interpretare muzicală - Instrumente','IM-Instrumente'),
(N'Muzică',N'Interpretare muzicală - Instrumente (în limba engleză)',N'IM-Instrumente (în limba engleză)'),
('PsihoEdu','Psihologie','Psihologie'),
('PsihoEdu',N'Pedagogia învățământului primar și preșcolar','PIPP'),
('PsihoEdu',N'Psihopedagogie specială','PS'),
('Socio',N'Asistență socială','AS'),
('Socio',N'Comunicare și relații publice','CRP'),
('Socio','Media digitală','MD'),
('Socio','Resurse Umane','RU'),
('Socio','Sociologie','Sociologie'),
('Socio',N'Media digitală (în limba engleză)',N'MD (în limba engleză)'),
('ECON','Marketing','Marketing'),
('ECON',N'Economia comerțului, turismului și serviciilor','ECTS'),
('ECON','Administrarea afacerilor','AdA'),
('ECON',N'Administrarea afacerilor (în limba engleză)',N'AdA (în limba engleză)'),
('ECON',N'Contabilitate și informatică de gestiune','CIG'),
('ECON','Management','Management'),
('ECON',N'Informatică economică','IE'),
('ECON',N'Afaceri internaționale','AI'),
('ECON','Finanțe și bănci','FB'),
('AT','Ingineria produselor alimentare','IPA'),
('AT',N'Controlul și expertiza produselor alimentare','CEPA'),
('AT',N'Inginerie și management în industria turismului','IMIT'),
('AT',N'Inginerie și management în alimentație publică și agroturism','IMAPA'),
(N'Construcții',N'Construcții civile, industriale și agricole','CCIA'),
(N'Construcții',N'Căi ferate, drumuri și poduri','CFDP'),
(N'Construcții',N'Instalații pentru construcții','IC');
/* create table [Specializare Masterat/Doctorat] ... */

create table [DPM-DI Discipline Licență]
(
Facultate nvarchar(30) default 'DPM',
Specializare nvarchar(50) default 'DI',
An smallint not null,
Semestru smallint not null,
[Disciplină] nvarchar(150) not null,
Credit smallint not null,
constraint c2 check (Specializare='DI'),
constraint c3 check (Credit>=1 and Credit<=10),
constraint fk2 foreign key(Facultate,Specializare) references [Specializare Licență](Facultate,Abreviere),
);
insert into [DPM-DI Discipline Licență] (An,Semestru,Disciplină,Credit) values
(1,1,'Discplina1',5),
(1,1,'Discplina2',3),
(1,1,'Discplina3',4),
(1,1,'Discplina4',6),
(1,1,'Discplina5',2),
(1,1,'Discplina6',5),
(1,1,'Discplina7',1),
(1,1,'Discplina8',2),
(1,1,'Discplina9',2),

(1,2,'DiscplinaA',5),
(1,2,'DiscplinaB',3),
(1,2,'DiscplinaC',4),
(1,2,'DiscplinaD',6),
(1,2,'DiscplinaE',2),
(1,2,'DiscplinaF',5),
(1,2,'DiscplinaG',1),
(1,2,'DiscplinaH',2),
(1,2,'DiscplinaI',2),

(2,1,'DiscplinaA1',5),
(2,1,'DiscplinaA2',3),
(2,1,'DiscplinaA3',4),
(2,1,'DiscplinaA4',6),
(2,1,'DiscplinaA5',2),
(2,1,'DiscplinaA6',5),
(2,1,'DiscplinaA7',1),
(2,1,'DiscplinaA8',2),
(2,1,'DiscplinaA9',2),

(2,2,'DiscplinaB1',5),
(2,2,'DiscplinaB2',3),
(2,2,'DiscplinaB3',4),
(2,2,'DiscplinaB4',6),
(2,2,'DiscplinaB5',2),
(2,2,'DiscplinaB6',5),
(2,2,'DiscplinaB7',1),
(2,2,'DiscplinaB8',2),
(2,2,'DiscplinaB9',2),

(3,1,'DiscplinaC1',5),
(3,1,'DiscplinaC2',3),
(3,1,'DiscplinaC3',4),
(3,1,'DiscplinaC4',6),
(3,1,'DiscplinaC5',2),
(3,1,'DiscplinaC6',5),
(3,1,'DiscplinaC7',1),
(3,1,'DiscplinaC8',2),
(3,1,'DiscplinaC9',2),

(3,2,'DiscplinaD1',5),
(3,2,'DiscplinaD2',3),
(3,2,'DiscplinaD3',4),
(3,2,'DiscplinaD4',6),
(3,2,'DiscplinaD5',2),
(3,2,'DiscplinaD6',5),
(3,2,'DiscplinaD7',1),
(3,2,'DiscplinaD8',2),
(3,2,'DiscplinaD9',2),

(4,1,'DiscplinaE1',5),
(4,1,'DiscplinaE2',3),
(4,1,'DiscplinaE3',4),
(4,1,'DiscplinaE4',6),
(4,1,'DiscplinaE5',2),
(4,1,'DiscplinaE6',5),
(4,1,'DiscplinaE7',1),
(4,1,'DiscplinaE8',2),
(4,1,'DiscplinaE9',2),

(4,2,'DiscplinaF1',5),
(4,2,'DiscplinaF2',3),
(4,2,'DiscplinaF3',4),
(4,2,'DiscplinaF4',6),
(4,2,'DiscplinaF5',2),
(4,2,'DiscplinaF6',5),
(4,2,'DiscplinaF7',1),
(4,2,'DiscplinaF8',2),
(4,2,'DiscplinaF9',2);
/* create table [DPM-urm spec Licenta] ... */
/* create table [IESC etc-spec1,apoi spec2 etc Licenta] ... */

create table Student 
(
[Număr matricol] nvarchar(10) not null,
Nume nvarchar(50) not null,
Prenume nvarchar(60) not null,
[Inițială tată/tutore] nchar(1) not null,
CNP char(14) not null,
Facultate nvarchar(30) not null,
Specializare nvarchar(50) not null,
[Ciclu de învățământ] nvarchar(9) not null,
[Medie de înscriere] decimal(3,2) not null,
Grupa nvarchar(10) not null,
constraint pk6 primary key(Nume,Prenume,[Număr matricol]),
constraint fk6 foreign key(Facultate,Specializare) references [Specializare Licență](Facultate,Abreviere),
constraint c8 check ([Ciclu de învățământ]=N'Licență' or [Ciclu de învățământ]='Masterat' or [Ciclu de învățământ]='Doctorat')
);
/* In loc de asta: constraint c2 check (Facultate='DPM' or Facultate='IESC' or etc)
                   constraint c3 check (Specializare='AIA' or 'TI' or etc)    */
go
create trigger trg1_Student on Student after insert, update as
begin
    declare @IsValid bit = 1;
    declare cursor_name cursor for
    select Facultate from inserted;
    open cursor_name;
    declare @Facultate nvarchar(100);

    fetch next from cursor_name INTO @Facultate;

    while @@FETCH_STATUS = 0
    begin
        if not exists (select 1 from Facultate where [Abreviere/Prescurtare] = @Facultate)
        begin
            set @IsValid = 0;
            break;
        end;

        fetch next from cursor_name INTO @Facultate;
    end;

    close cursor_name;
    deallocate cursor_name;

    if @IsValid = 0
    begin
        raiserror ('Invalid value for Facultate.', 16, 1);
        rollback transaction;
        return;
    end;
end;

go
create trigger trg2_Student on Student after insert, update as
begin
    declare @IsValid bit = 1;
    declare cursor_name cursor for
    select Specializare from inserted;
	open cursor_name;
	declare @Specializare nvarchar(100);

	fetch next from cursor_name INTO @Specializare;

    while @@FETCH_STATUS = 0
    begin
        if not exists (select 1 from [Specializare Licență] where Abreviere = @Specializare)
        begin
            set @IsValid = 0;
            break;
        end;

        fetch next from cursor_name INTO @Specializare;
    end;

    close cursor_name;
    deallocate cursor_name;

    if @IsValid = 0
    begin
        raiserror ('Invalid value for Facultate.', 16, 1);
        rollback transaction;
        return;
    end;
end;


insert into Student values
('100M100','Ion','Popa','M','50201020139988','DPM','DI',N'Licență',7.92,'grTEST1'),
('100M101','Ionel','Popescu','L','50201020139981','DPM','DI',N'Licență',5.42,'grTEST2'),
('100M500','Ionelut','Plopu','M','50201020139998','DPM','DI',N'Licență',6.52,'grTEST2');
select * from Student;
/*pana aici totul a fost rulat si functioneaza, vom folosi in continuare un alt querry*/