-- Tablas Menores

--CREATE TABLE Moneda (
--	MonedaID INT NOT NULL IDENTITY (1,1),
--	Nombre VARCHAR(40),
--	Abreviatura VARCHAR(4),
--	Simbolo VARCHAR(3),
--	CONSTRAINT PK_Moneda PRIMARY KEY (MonedaID),
--);

--INSERT INTO Moneda VALUES('GUARANIES', 'PYG');
--INSERT INTO Moneda VALUES('DOLARES AMERICANOS', 'USD');
--INSERT INTO Moneda VALUES('PESOS ARGENTINOS', 'ARG');
use master;
DROP DATABASE SysTurismo;
CREATE DATABASE SysTurismo;

USE SysTurismo;

CREATE TABLE users(
id varchar(10) not null,
nom varchar(30) not null,
email varchar(50) not null,
pass varchar(20) not null,
CONSTRAINT PK_users PRIMARY KEY (id));

--CREATE PROCEDURE [dbo].[alta_users](
--@id varchar(10),
--@nom varchar(30),
--@email varchar(50),
--@pass varchar(20)
--)
--as
--insert into users
--values(@id, @nom, @email, @pass);

--CREATE procedure [dbo].[ver_users](
--@id varchar(10)
--)
--as 
--select * from users
--where id=@id;

INSERT INTO users VALUES ('admin', 'Administrador', 'admin@hotmail.com', '1234');

CREATE TABLE TipoCliente(
	TipoClienteID INT NOT NULL IDENTITY(1,1),
	Descripcion VARCHAR(30) NOT NULL,
	CONSTRAINT PK_TipoCliente PRIMARY KEY (TipoClienteID),
);

INSERT INTO TipoCliente VALUES('BRONCE');
INSERT INTO TipoCliente VALUES('PLATA');
INSERT INTO TipoCliente VALUES('ORO');

CREATE TABLE CargoEmpleado (
	CargoEmpleadoID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Descripcion VARCHAR(256) NOT NULL,
	CONSTRAINT PK_CargoEmpleado PRIMARY KEY (CargoEmpleadoID),
);

INSERT INTO CargoEmpleado VALUES ('Cajero', 'Se encargar de realizar las cobranzas');
INSERT INTO CargoEmpleado VALUES ('Gerente', 'Se encargar de organizar y reunir nuevo personal');
INSERT INTO CargoEmpleado VALUES ('Jefe', 'Se de todo el personal de la empresa y sus areas');
INSERT INTO CargoEmpleado VALUES ('Vendedor', 'Se encargar de realizar busqueda de clientes para la empresa');
INSERT INTO CargoEmpleado VALUES ('Call Center', 'Se encargar de atender a los clientes via telefonica');

CREATE TABLE TipoDocumento (
	TipoDocumentoID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoDocumento PRIMARY KEY (TipoDocumentoID),
);

INSERT INTO TipoDocumento VALUES ('C.I. Paraguaya');
INSERT INTO TipoDocumento VALUES ('DNI');
INSERT INTO TipoDocumento VALUES ('Pasaporte');

CREATE TABLE MedioDePago (
	MedioDePagoID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_MedioDePago PRIMARY KEY (MedioDePagoID),
);

INSERT INTO MedioDePago VALUES ('Efectivo');
INSERT INTO MedioDePago VALUES ('Tarjeta de Débito');
INSERT INTO MedioDePago VALUES ('Tarjeta de Crédito');

--CREATE TABLE Imagen (
--	ImagenID INT NOT NULL IDENTITY (1,1),
--	Formato VARCHAR(50) NOT NULL,
--	Leyenda VARCHAR(200),
--	URI VARCHAR(2048) NOT NULL,
--	CONSTRAINT PK_Imagen PRIMARY KEY (ImagenID),
--);

CREATE TABLE Pais (
	PaisID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Pais PRIMARY KEY (PaisID),
);

INSERT INTO PAIS Values('PARAGUAY');
INSERT INTO PAIS Values('ESTADOS UNIDOS');
INSERT INTO PAIS Values('ARGENTINA');
INSERT INTO PAIS Values('BRASIL');
INSERT INTO PAIS Values('BOLIVIA');
INSERT INTO PAIS Values('URUGUAY');
INSERT INTO PAIS Values('PERU');
INSERT INTO PAIS Values('CHILE');
INSERT INTO PAIS Values('COLOMBIA');
INSERT INTO PAIS Values('ECUADOR');
INSERT INTO PAIS Values('MEXICO');
INSERT INTO PAIS Values('CANADA');
INSERT INTO PAIS Values('ESPAÑA');

CREATE TABLE Departamento (
	DepartamentoID INT NOT NULL IDENTITY (1,1),
	PaisID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Departamento PRIMARY KEY (DepartamentoID),
	CONSTRAINT FK_Departamento_Pais FOREIGN KEY (PaisID) REFERENCES Pais(PaisID),
);

INSERT INTO Departamento VALUES (1, 'ASUNCION');
INSERT INTO Departamento VALUES (1, 'CONCEPCION');
INSERT INTO Departamento VALUES (1, 'SAN PEDRO');
INSERT INTO Departamento VALUES (1, 'CORDILLERA');
INSERT INTO Departamento VALUES (1, 'GUAIRA');
INSERT INTO Departamento VALUES (1, 'CAAGUAZU');
INSERT INTO Departamento VALUES (1, 'CAAZAPA');
INSERT INTO Departamento VALUES (1, 'ITAPUA');
INSERT INTO Departamento VALUES (1, 'MISIONES');
INSERT INTO Departamento VALUES (1, 'PARAGUARI');
INSERT INTO Departamento VALUES (1, 'ALTO PARANA');
INSERT INTO Departamento VALUES (1, 'CENTRAL');
INSERT INTO Departamento VALUES (1, 'ÑEEMBUCU');
INSERT INTO Departamento VALUES (1, 'AMAMBAY');
INSERT INTO Departamento VALUES (1, 'CANINDEYU');
INSERT INTO Departamento VALUES (1, 'PRESIDENTE HAYES');
INSERT INTO Departamento VALUES (1, 'BOQUERON');
INSERT INTO Departamento VALUES (1, 'ALTO PARAGUAY');

CREATE TABLE Ciudad (
	CiudadID INT NOT NULL IDENTITY (1,1),
	DepartamentoID INT NOT NULL,
	PaisID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Ciudad PRIMARY KEY (CiudadID),
	CONSTRAINT FK_Ciudad_Departamento FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID),
	CONSTRAINT FK_Ciudad_Pais FOREIGN KEY (PaisID) REFERENCES Pais(PaisID),
);

INSERT INTO Ciudad VALUES(1,1,'ASUNCION');
INSERT INTO Ciudad VALUES(1,1,'CONCEPCION');
INSERT INTO Ciudad VALUES(1,1,'BELEN');
INSERT INTO Ciudad VALUES(1,1,'AZOTEY');
INSERT INTO Ciudad VALUES(1,1,'HORQUETA');
INSERT INTO Ciudad VALUES(1,1,'LORETO');
INSERT INTO Ciudad VALUES(1,1,'SAN CARLOS DEL APA');
INSERT INTO Ciudad VALUES(1,1,'SAN LAZARO');
INSERT INTO Ciudad VALUES(1,1,'YBYYAU');
INSERT INTO Ciudad VALUES(2,1,'SAN PEDRO DEL Y.');
INSERT INTO Ciudad VALUES(2,1,'25 DE DICIEMBRE');
INSERT INTO Ciudad VALUES(2,1,'ANTEQUERA');
INSERT INTO Ciudad VALUES(2,1,'CAPIIVARY');
INSERT INTO Ciudad VALUES(2,1,'CHORE');
INSERT INTO Ciudad VALUES(2,1,'GRAL.ELIZARDO AQUINO');
INSERT INTO Ciudad VALUES(2,1,'GRAL. F. RESQUIN');
INSERT INTO Ciudad VALUES(2,1,'GUAJAYVI');
INSERT INTO Ciudad VALUES(2,1,'ITAC. DEL ROSARIO');
INSERT INTO Ciudad VALUES(2,1,'LIMA');
INSERT INTO Ciudad VALUES(2,1,'NUEVA GERMANIA');
INSERT INTO Ciudad VALUES(2,1,'SAN ESTANISLAO');
INSERT INTO Ciudad VALUES(2,1,'SAN PABLO');
INSERT INTO Ciudad VALUES(2,1,'STA.ROSA DEL AGUARAY');
INSERT INTO Ciudad VALUES(2,1,'TACUATI');
INSERT INTO Ciudad VALUES(2,1,'UNION');
INSERT INTO Ciudad VALUES(2,1,'VILLA DEL ROSARIO');
INSERT INTO Ciudad VALUES(2,1,'YATAITY DEL NORTE');
INSERT INTO Ciudad VALUES(2,1,'YRYBUCUA');
INSERT INTO Ciudad VALUES(3,1,'CAACUPE');
INSERT INTO Ciudad VALUES(3,1,'1RO. DE MARZO');
INSERT INTO Ciudad VALUES(3,1,'ALTOS');
INSERT INTO Ciudad VALUES(3,1,'ARROYOS Y ESTEROS');
INSERT INTO Ciudad VALUES(3,1,'ATYRA');
INSERT INTO Ciudad VALUES(3,1,'CARAGUATAY');
INSERT INTO Ciudad VALUES(3,1,'EMBOSCADA');
INSERT INTO Ciudad VALUES(3,1,'EUSEBIO AYALA');
INSERT INTO Ciudad VALUES(3,1,'ISLA PUCU');
INSERT INTO Ciudad VALUES(3,1,'ITAC.DE LA CORDILLER');
INSERT INTO Ciudad VALUES(3,1,'JUAN DE MENA');
INSERT INTO Ciudad VALUES(3,1,'LOMA GRANDE');
INSERT INTO Ciudad VALUES(3,1,'MBOCAYATY DEL YHAGUY');
INSERT INTO Ciudad VALUES(3,1,'NUEVA COLOMBIA');
INSERT INTO Ciudad VALUES(3,1,'PIRIBEBUY');
INSERT INTO Ciudad VALUES(3,1,'SAN BERNARDINO');
INSERT INTO Ciudad VALUES(3,1,'SAN JOSE OBRERO');
INSERT INTO Ciudad VALUES(3,1,'SANTA ELENA');
INSERT INTO Ciudad VALUES(3,1,'TOBATI');
INSERT INTO Ciudad VALUES(3,1,'VALENZUELA');
INSERT INTO Ciudad VALUES(4,1,'VILLARRICA');
INSERT INTO Ciudad VALUES(4,1,'BORJA');
INSERT INTO Ciudad VALUES(4,1,'CAP. M. JOSE TROCHE');
INSERT INTO Ciudad VALUES(4,1,'CORONEL MARTINEZ');
INSERT INTO Ciudad VALUES(4,1,'DR. BOTRELL');
INSERT INTO Ciudad VALUES(4,1,'FELIX PEREZ CARDOZO');
INSERT INTO Ciudad VALUES(4,1,'GRAL. E. A. GARAY');
INSERT INTO Ciudad VALUES(4,1,'INDEPENDENCIA');
INSERT INTO Ciudad VALUES(4,1,'ITAPE');
INSERT INTO Ciudad VALUES(4,1,'ITURBE');
INSERT INTO Ciudad VALUES(4,1,'JOSE A. FASSARDI');
INSERT INTO Ciudad VALUES(4,1,'MBOCAYATY DEL GUAIRA');
INSERT INTO Ciudad VALUES(4,1,'NATALICIO TALAVERA');
INSERT INTO Ciudad VALUES(4,1,'ÑUMI');
INSERT INTO Ciudad VALUES(4,1,'PASO YOBAI');
INSERT INTO Ciudad VALUES(4,1,'SAN SALVADOR');
INSERT INTO Ciudad VALUES(4,1,'TEBICUARY');
INSERT INTO Ciudad VALUES(4,1,'YATAITY DEL GUAIRA');
INSERT INTO Ciudad VALUES(5,1,'CORONEL OVIEDO');
INSERT INTO Ciudad VALUES(5,1,'3 DE FEBRERO');
INSERT INTO Ciudad VALUES(5,1,'CAAGUAZU');
INSERT INTO Ciudad VALUES(5,1,'CARAYAO');
INSERT INTO Ciudad VALUES(5,1,'DR. CECILIO BAEZ');
INSERT INTO Ciudad VALUES(5,1,'DR.J. E.ESTIGARRIBIA');
INSERT INTO Ciudad VALUES(5,1,'DR. JUAN M. FRUTOS');
INSERT INTO Ciudad VALUES(5,1,'JOSE DOMINGO OCAMPOS');
INSERT INTO Ciudad VALUES(5,1,'LA PASTORA');
INSERT INTO Ciudad VALUES(5,1,'FRANCISCO S.LOPEZ');
INSERT INTO Ciudad VALUES(5,1,'NUEVA LONDRES');
INSERT INTO Ciudad VALUES(5,1,'R.I. 3 CORRALES');
INSERT INTO Ciudad VALUES(5,1,'RAUL ARSENIO OVIEDO');
INSERT INTO Ciudad VALUES(5,1,'REPATRIACION');
INSERT INTO Ciudad VALUES(5,1,'SAN JOAQUIN');
INSERT INTO Ciudad VALUES(5,1,'SAN J.DE LOS ARROYOS');
INSERT INTO Ciudad VALUES(5,1,'STA.ROSA DEL MBUTUY');
INSERT INTO Ciudad VALUES(5,1,'SIMON BOLIVAR');
INSERT INTO Ciudad VALUES(5,1,'TEMBIAPORA');
INSERT INTO Ciudad VALUES(5,1,'VAQUERIA');
INSERT INTO Ciudad VALUES(5,1,'YHU');
INSERT INTO Ciudad VALUES(6,1,'CAAZAPA');
INSERT INTO Ciudad VALUES(6,1,'ABAI');
INSERT INTO Ciudad VALUES(6,1,'BUENA VISTA');
INSERT INTO Ciudad VALUES(6,1,'DR. MOISES BERTONI');
INSERT INTO Ciudad VALUES(6,1,'FULGENCIO YEGROS');
INSERT INTO Ciudad VALUES(6,1,'GRAL.MORINIGO');
INSERT INTO Ciudad VALUES(6,1,'MACIEL');
INSERT INTO Ciudad VALUES(6,1,'SAN JUAN NEPOMUCENO');
INSERT INTO Ciudad VALUES(6,1,'TAVAI');
INSERT INTO Ciudad VALUES(6,1,'YUTY');
INSERT INTO Ciudad VALUES(7,1,'ENCARNACION');
INSERT INTO Ciudad VALUES(7,1,'ALTO VERA');
INSERT INTO Ciudad VALUES(7,1,'BELLA VISTA');
INSERT INTO Ciudad VALUES(7,1,'CAMBYRETA');
INSERT INTO Ciudad VALUES(7,1,'CAPITAN MEZA');
INSERT INTO Ciudad VALUES(7,1,'CAPITAN MIRANDA');
INSERT INTO Ciudad VALUES(7,1,'CARLOS ANTONIO LOPEZ');
INSERT INTO Ciudad VALUES(7,1,'CARMEN DEL PARANA');
INSERT INTO Ciudad VALUES(7,1,'CORONEL BOGADO');
INSERT INTO Ciudad VALUES(7,1,'EDELIRA');
INSERT INTO Ciudad VALUES(7,1,'FRAM');
INSERT INTO Ciudad VALUES(7,1,'GENERAL ARTIGAS');
INSERT INTO Ciudad VALUES(7,1,'GENERAL DELGADO');
INSERT INTO Ciudad VALUES(7,1,'HOHENAU');
INSERT INTO Ciudad VALUES(7,1,'ITAPUA POTY');
INSERT INTO Ciudad VALUES(7,1,'JESUS');
INSERT INTO Ciudad VALUES(7,1,'JOSE LEANDRO OVIEDO');
INSERT INTO Ciudad VALUES(7,1,'LA PAZ');
INSERT INTO Ciudad VALUES(7,1,'MAYOR OTAÑO');
INSERT INTO Ciudad VALUES(7,1,'NATALIO');
INSERT INTO Ciudad VALUES(7,1,'NUEVA ALBORADA');
INSERT INTO Ciudad VALUES(7,1,'OBLIGADO');
INSERT INTO Ciudad VALUES(7,1,'PIRAPO');
INSERT INTO Ciudad VALUES(7,1,'SAN COSME Y DAMIAN');
INSERT INTO Ciudad VALUES(7,1,'SAN JUAN DEL PARANA');
INSERT INTO Ciudad VALUES(7,1,'SAN PEDRO DEL PARANA');
INSERT INTO Ciudad VALUES(7,1,'SAN RAFAEL DEL PARAN');
INSERT INTO Ciudad VALUES(7,1,'TOMAS ROMERO PEREIRA');
INSERT INTO Ciudad VALUES(7,1,'TRINIDAD');
INSERT INTO Ciudad VALUES(7,1,'YATYTAY');
INSERT INTO Ciudad VALUES(8,1,'SAN JUAN BAUTISTA');
INSERT INTO Ciudad VALUES(8,1,'AYOLAS');
INSERT INTO Ciudad VALUES(8,1,'SAN IGNACIO');
INSERT INTO Ciudad VALUES(8,1,'SAN MIGUEL');
INSERT INTO Ciudad VALUES(8,1,'SAN PATRICIO');
INSERT INTO Ciudad VALUES(8,1,'SANTA MARIA');
INSERT INTO Ciudad VALUES(8,1,'SANTA ROSA');
INSERT INTO Ciudad VALUES(8,1,'SANTIAGO');
INSERT INTO Ciudad VALUES(8,1,'VILLA FLORIDA');
INSERT INTO Ciudad VALUES(8,1,'YAVEVYRY');
INSERT INTO Ciudad VALUES(9,1,'PARAGUARI');
INSERT INTO Ciudad VALUES(9,1,'ACAHAY');
INSERT INTO Ciudad VALUES(9,1,'CAAPUCU');
INSERT INTO Ciudad VALUES(9,1,'CARAPEGUA');
INSERT INTO Ciudad VALUES(9,1,'ESCOBAR');
INSERT INTO Ciudad VALUES(9,1,'GRAL. B. CABALLERO');
INSERT INTO Ciudad VALUES(9,1,'LA COLMENA');
INSERT INTO Ciudad VALUES(9,1,'MBUYAPEY');
INSERT INTO Ciudad VALUES(9,1,'PIRAYU');
INSERT INTO Ciudad VALUES(9,1,'QUIINDY');
INSERT INTO Ciudad VALUES(9,1,'QUYQUYHO');
INSERT INTO Ciudad VALUES(9,1,'SAN ROQUE GONZALEZ');
INSERT INTO Ciudad VALUES(9,1,'SAPUCAI');
INSERT INTO Ciudad VALUES(9,1,'TEBICUARYMI');
INSERT INTO Ciudad VALUES(9,1,'YAGUARON');
INSERT INTO Ciudad VALUES(9,1,'YBYCUI');
INSERT INTO Ciudad VALUES(9,1,'YBYTYMI');
INSERT INTO Ciudad VALUES(10,1,'CIUDAD DEL ESTE');
INSERT INTO Ciudad VALUES(10,1,'DR. J. L. MALLORQUIN');
INSERT INTO Ciudad VALUES(10,1,'DOMINGO M. DE IRALA');
INSERT INTO Ciudad VALUES(10,1,'HERNANDARIAS');
INSERT INTO Ciudad VALUES(10,1,'IRUÑA');
INSERT INTO Ciudad VALUES(10,1,'ITAKYRY');
INSERT INTO Ciudad VALUES(10,1,'JUAN E. O''LEARY');
INSERT INTO Ciudad VALUES(10,1,'LOS CEDRALES');
INSERT INTO Ciudad VALUES(10,1,'MBARACAYU');
INSERT INTO Ciudad VALUES(10,1,'MINGA GUAZU');
INSERT INTO Ciudad VALUES(10,1,'MINGA PORA');
INSERT INTO Ciudad VALUES(10,1,'NARANJAL');
INSERT INTO Ciudad VALUES(10,1,'ÑACUNDAY');
INSERT INTO Ciudad VALUES(10,1,'PRESIDENTE FRANCO');
INSERT INTO Ciudad VALUES(10,1,'SAN ALBERTO');
INSERT INTO Ciudad VALUES(10,1,'SAN CRISTOBAL');
INSERT INTO Ciudad VALUES(10,1,'SANTA FE DEL PARANA');
INSERT INTO Ciudad VALUES(10,1,'SANTA RITA');
INSERT INTO Ciudad VALUES(10,1,'STA. ROSA DEL MONDAY');
INSERT INTO Ciudad VALUES(10,1,'YGUAZU');
INSERT INTO Ciudad VALUES(11,1,'AREGUA');
INSERT INTO Ciudad VALUES(11,1,'CAPIATA');
INSERT INTO Ciudad VALUES(11,1,'FERNANDO DE LA MORA');
INSERT INTO Ciudad VALUES(11,1,'GUARAMBARE');
INSERT INTO Ciudad VALUES(11,1,'ITA');
INSERT INTO Ciudad VALUES(11,1,'ITAUGUA');
INSERT INTO Ciudad VALUES(11,1,'J. AUGUSTO SALDIVAR');
INSERT INTO Ciudad VALUES(11,1,'LAMBARE');
INSERT INTO Ciudad VALUES(11,1,'LIMPIO');
INSERT INTO Ciudad VALUES(11,1,'LUQUE');
INSERT INTO Ciudad VALUES(11,1,'MARIANO R. ALONSO');
INSERT INTO Ciudad VALUES(11,1,'NUEVA ITALIA');
INSERT INTO Ciudad VALUES(11,1,'ÑEMBY');
INSERT INTO Ciudad VALUES(11,1,'SAN ANTONIO');
INSERT INTO Ciudad VALUES(11,1,'SAN LORENZO');
INSERT INTO Ciudad VALUES(11,1,'VILLA ELISA');
INSERT INTO Ciudad VALUES(11,1,'VILLETA');
INSERT INTO Ciudad VALUES(11,1,'YPACARAI');
INSERT INTO Ciudad VALUES(11,1,'YPANE');
INSERT INTO Ciudad VALUES(12,1,'PILAR');
INSERT INTO Ciudad VALUES(12,1,'ALBERDI');
INSERT INTO Ciudad VALUES(12,1,'CERRITO');
INSERT INTO Ciudad VALUES(12,1,'DESMOCHADOS');
INSERT INTO Ciudad VALUES(12,1,'GRAL. JOSE E. DIAZ');
INSERT INTO Ciudad VALUES(12,1,'GUAZU CUA');
INSERT INTO Ciudad VALUES(12,1,'HUMAITA');
INSERT INTO Ciudad VALUES(12,1,'ISLA UMBU');
INSERT INTO Ciudad VALUES(12,1,'LAURELES');
INSERT INTO Ciudad VALUES(12,1,'MAYOR J. MARTINEZ');
INSERT INTO Ciudad VALUES(12,1,'PASO DE PATRIA');
INSERT INTO Ciudad VALUES(12,1,'SAN JUAN BAUTISTA');
INSERT INTO Ciudad VALUES(12,1,'TACUARAS');
INSERT INTO Ciudad VALUES(12,1,'VILLA FRANCA');
INSERT INTO Ciudad VALUES(12,1,'VILLA OLIVA');
INSERT INTO Ciudad VALUES(12,1,'VILLALBIN');
INSERT INTO Ciudad VALUES(13,1,'PEDRO J. CABALLERO');
INSERT INTO Ciudad VALUES(13,1,'BELLA VISTA');
INSERT INTO Ciudad VALUES(13,1,'CAPITAN BADO');
INSERT INTO Ciudad VALUES(14,1,'SALTO DEL GUAIRA');
INSERT INTO Ciudad VALUES(14,1,'CORPUS CHRISTI');
INSERT INTO Ciudad VALUES(14,1,'FRANCISCO C. ALVAREZ');
INSERT INTO Ciudad VALUES(14,1,'ITANARA');
INSERT INTO Ciudad VALUES(14,1,'KATUETE');
INSERT INTO Ciudad VALUES(14,1,'LA PALOMA');
INSERT INTO Ciudad VALUES(14,1,'NUEVA ESPERANZA');
INSERT INTO Ciudad VALUES(14,1,'SAN ISIDRO CURUGUATY');
INSERT INTO Ciudad VALUES(14,1,'VILLA YGATIMI');
INSERT INTO Ciudad VALUES(14,1,'YASY CAÑY');
INSERT INTO Ciudad VALUES(14,1,'YPE JHU');
INSERT INTO Ciudad VALUES(15,1,'VILLA HAYES');
INSERT INTO Ciudad VALUES(15,1,'BENJAMIN ACEVAL');
INSERT INTO Ciudad VALUES(15,1,'FORTIN JOSE FALCON');
INSERT INTO Ciudad VALUES(15,1,'GRAL. JOSE M. BRUGUE');
INSERT INTO Ciudad VALUES(15,1,'NANAWA');
INSERT INTO Ciudad VALUES(15,1,'PTO. PINASCO');
INSERT INTO Ciudad VALUES(15,1,'TTE.IRALA FERNANDEZ');
INSERT INTO Ciudad VALUES(15,1,'TTE ESTEBAN MARTINEZ');
INSERT INTO Ciudad VALUES(16,1,'FUERTE OLIMPO');
INSERT INTO Ciudad VALUES(16,1,'PUERTO CASADO');
INSERT INTO Ciudad VALUES(16,1,'CARMELO PERALTA');
INSERT INTO Ciudad VALUES(16,1,'BAHIA NEGRA');
INSERT INTO Ciudad VALUES(17,1,'FILADELFIA');
INSERT INTO Ciudad VALUES(17,1,'LOMA PLATA');
INSERT INTO Ciudad VALUES(17,1,'MCAL.ESTIGARRIBIA');

CREATE TABLE Profesion(
	ProfesionID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50),
	CONSTRAINT PK_Profesion PRIMARY KEY (ProfesionID),
);

INSERT INTO Profesion VALUES ('ESTUDIANTE');
INSERT INTO Profesion VALUES ('PROFESOR');
INSERT INTO Profesion VALUES ('ABOGADO');
INSERT INTO Profesion VALUES ('INFORMATICO');

CREATE TABLE EstadoHabitacion (
	EstadoHabitacionID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_EstadoHabitacion PRIMARY KEY (EstadoHabitacionID),
);

INSERT INTO EstadoHabitacion VALUES('LIBRE');
INSERT INTO EstadoHabitacion VALUES('OCUPADO');
INSERT INTO EstadoHabitacion VALUES('RESERVADO');
INSERT INTO EstadoHabitacion VALUES('MANTENIMIENTO');

CREATE TABLE TipoAlojamiento (
	TipoAlojamientoId INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoAlojamiento PRIMARY KEY (TipoAlojamientoID),
);

INSERT INTO TipoAlojamiento VALUES('HOTEL');
INSERT INTO TipoAlojamiento VALUES('HOSPEDAJE');
INSERT INTO TipoAlojamiento VALUES('QUINTA');

CREATE TABLE TipoHabitacion (
	TipoHabitacionID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoHabitacion PRIMARY KEY (TipoHabitacionID),
);

INSERT INTO TipoHabitacion VALUES('INDIVIDUAL');
INSERT INTO TipoHabitacion VALUES('DOBLE INDIVIDUAL');
INSERT INTO TipoHabitacion VALUES('DOBLE');
INSERT INTO TipoHabitacion VALUES('CAMA SUPLETORIA');
INSERT INTO TipoHabitacion VALUES('TRIPLE');
INSERT INTO TipoHabitacion VALUES('JUNIOR SUITE');
INSERT INTO TipoHabitacion VALUES('SUITE');
INSERT INTO TipoHabitacion VALUES('SUITE PRESIDENCIAL');
INSERT INTO TipoHabitacion VALUES('SUITE NUPCIAL');

CREATE TABLE TipoServicioAlojamiento(
	TipoServicioAlojamientoID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(100) NOT NULL,
	CONSTRAINT PK_TipoServicioAlojamiento PRIMARY KEY (TipoServicioAlojamientoID),
);

INSERT INTO TipoServicioAlojamiento VALUES ('PISCINA');
INSERT INTO TipoServicioAlojamiento VALUES ('PISCINA CLIMATIZADA');
INSERT INTO TipoServicioAlojamiento VALUES ('RESTAURANTE');
INSERT INTO TipoServicioAlojamiento VALUES ('BAR');
INSERT INTO TipoServicioAlojamiento VALUES ('SERVICIO AL CUARTO');
INSERT INTO TipoServicioAlojamiento VALUES ('WIFI');
INSERT INTO TipoServicioAlojamiento VALUES ('SALA DE EVENTOS');
INSERT INTO TipoServicioAlojamiento VALUES ('SPA');
INSERT INTO TipoServicioAlojamiento VALUES ('GIMNASIO');
INSERT INTO TipoServicioAlojamiento VALUES ('ACCESO PARA SILLA DE RUEDAS');
INSERT INTO TipoServicioAlojamiento VALUES ('ACEPTAN MASCOTAS');
INSERT INTO TipoServicioAlojamiento VALUES ('SERVICIO DE LIMPIEZA DIARIA DEL CUARTO');

CREATE TABLE TipoServicioHabitacion(
	TipoServicioHabitacionID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(100) NOT NULL,
	CONSTRAINT PK_TipoServicioHabitacion PRIMARY KEY (TipoServicioHabitacionID),
);

INSERT INTO TipoServicioHabitacion VALUES ('DESAYUNO');
INSERT INTO TipoServicioHabitacion VALUES ('COCINA');
INSERT INTO TipoServicioHabitacion VALUES ('TELEVISION POR CABLE');
INSERT INTO TipoServicioHabitacion VALUES ('FRIGOBAR');
INSERT INTO TipoServicioHabitacion VALUES ('NETFLIX');
INSERT INTO TipoServicioHabitacion VALUES ('WIFI EMPRESARIAL');

-- Tablas Mayores

CREATE TABLE SucursalEmpresa (
	SucursalEmpresaID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR (50) NOT NULL,
	CiudadID INT NOT NULL,
	Telefono VARCHAR (30),
	Direccion VARCHAR (100),
	Email VARCHAR (50),
	CantidadEmpleados INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_SucursalEmpresa PRIMARY KEY (SucursalEmpresaID),
	CONSTRAINT FK_SucursalEmpresa_Ciudad FOREIGN KEY (CiudadID) REFERENCES Ciudad(CiudadID),
);

INSERT INTO SucursalEmpresa VALUES ('Turipar', 1, '565889', 'Gral Santos c Rca Siria', 'turipar@turismo.com.py', 26, 1);

CREATE TABLE Alojamiento (
	AlojamientoID INT NOT NULL IDENTITY (1,1),
	TipoAlojamientoID INT NOT NULL,
	Imagen Image,
	Nombre VARCHAR(50),
	Direccion VARCHAR(100) NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	PaginaWeb VARCHAR(30) NOT NULL,
	Estrellas INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Alojamiento PRIMARY KEY (AlojamientoID),
	CONSTRAINT FK_Alojamiento_TipoAlojamiento FOREIGN KEY (TipoAlojamientoID) REFERENCES TipoAlojamiento(TipoAlojamientoID),
);

INSERT INTO TipoAlojamiento values ('Hotel');

INSERT INTO Alojamiento (TipoAlojamientoID, Nombre, Direccion, Telefono, PaginaWeb, Estrellas, EstadoSistema )
 values (1, 'Sheraton', 'Asuncion', '0991546888', 'sheraton@hotmail.com', 4, 1);

CREATE TABLE SucursalAlojamiento (
	SucursalAlojamientoID INT NOT NULL IDENTITY(1,1),
	AlojamientoID INT NOT NULL,
	Nombre VARCHAR (50) NOT NULL,
	CiudadID INT NOT NULL,
	Telefono VARCHAR (30),
	Direccion VARCHAR (100),
	Email VARCHAR (50),
	ServicioID INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_SucursalAlojamiento PRIMARY KEY (SucursalAlojamientoID),
	CONSTRAINT FK_SucursalAlojamiento_Alojamiento FOREIGN KEY (AlojamientoID) REFERENCES Alojamiento(AlojamientoID),
	CONSTRAINT FK_SucursalAlojamiento_Ciudad FOREIGN KEY (CiudadID) REFERENCES Ciudad(CiudadID),
	CONSTRAINT FK_SucursalAlojamiento_Servicio FOREIGN KEY (ServicioID) REFERENCES TipoServicioAlojamiento(TipoServicioAlojamientoID)
);

CREATE TABLE Cliente (
	ClienteID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	TipoDocumentoID INT NOT NULL,
	NroDocumento VARCHAR(30) NOT NULL,
	EstadoCivil CHAR(1) NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	ProfesionID INT NOT NULL,
	Sexo BIT NOT NULL,
	TipoClienteID INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Cliente PRIMARY KEY (ClienteID),
	CONSTRAINT FK_Cliente_TipoDocumento FOREIGN KEY (TipoDocumentoID) REFERENCES TipoDocumento(TipoDocumentoID),
	CONSTRAINT FK_Cliente_Profesion FOREIGN KEY (ProfesionID) REFERENCES Profesion(ProfesionID),
	CONSTRAINT FK_Cliente_TipoCliente FOREIGN KEY (TipoClienteID) REFERENCES TipoCliente(TipoClienteID),
);

CREATE TABLE Habitacion (
	HabitacionID INT NOT NULL IDENTITY (1,1),
	NroHabitacion INT NOT NULL,
	SucursalAlojamientoID INT NOT NULL,
	Precio MONEY NOT NULL,          -- en guaranies
	TipoHabitacionID INT NOT NULL,
	EstadoHabitacionID INT NOT NULL,
	ServicioHabitacionID int NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,

	CONSTRAINT PK_Habitacion PRIMARY KEY (HabitacionID),
	CONSTRAINT FK_Habitacion_SucursalAlojamiento FOREIGN KEY (SucursalAlojamientoID) REFERENCES SucursalAlojamiento(SucursalAlojamientoID),
	CONSTRAINT FK_Habitacion_TipoHabitacion FOREIGN KEY (TipoHabitacionID) REFERENCES TipoHabitacion(TipoHabitacionID),
	CONSTRAINT FK_Habitacion_ServicioHabitacion FOREIGN KEY (ServicioHabitacionID) REFERENCES TipoServicioHabitacion(TipoServicioHabitacionID),
	CONSTRAINT FK_Habitacion_EstadoHabitacion FOREIGN KEY (EstadoHabitacionID) REFERENCES EstadoHabitacion(EstadoHabitacionID),
);

CREATE TABLE Empleado (
	EmpleadoID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	CargoEmpleadoID INT NOT NULL,
	TipoDocumentoID INT NOT NULL,
	NroDocumento VARCHAR(30) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	SucursalEmpresaID INT NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	EstadoCivil CHAR(1) NOT NULL,
	Antiguedad INT NOT NULL,           -- en años
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Empleado PRIMARY KEY (EmpleadoID),
	CONSTRAINT FK_Empleado_CargoEmpleado FOREIGN KEY (CargoEmpleadoID) REFERENCES CargoEmpleado(CargoEmpleadoID),
	CONSTRAINT FK_Empleado_TipoDocumento FOREIGN KEY (TipoDocumentoID) REFERENCES TipoDocumento(TipoDocumentoID),
	CONSTRAINT FK_Empleado_SucursalEmpresa FOREIGN KEY (SucursalEmpresaID) REFERENCES SucursalEmpresa(SucursalEmpresaID),
);

CREATE TABLE TipoServicioAlojamientoPorSucursalAlojamiento(
	TipoServicioAlojamientoID INT NOT NULL,
	SucursalAlojamientoID INT NOT NULL,
	CONSTRAINT PK_TipoServicioAlojamientoPorAlojamiento PRIMARY KEY (TipoServicioAlojamientoID, SucursalAlojamientoID),
	CONSTRAINT FK_TipoServicioAlojamientoPorAlojamiento_TipoServicioAlojamiento FOREIGN KEY (TipoServicioAlojamientoID) REFERENCES TipoServicioAlojamiento(TipoServicioAlojamientoID),
	CONSTRAINT FK_TipoServicioAlojamientoPorAlojamiento_SucursalAlojamiento FOREIGN KEY (SucursalAlojamientoID) REFERENCES SucursalAlojamiento(SucursalAlojamientoID),
);

CREATE TABLE TipoServicioHabitacionPorHabitacion(
	TipoServicioHabitacionID INT NOT NULL,
	HabitacionID INT NOT NULL,
	CONSTRAINT PK_TipoServicioHabitacionPorHabitacion PRIMARY KEY (TipoServicioHabitacionID, HabitacionID),
	CONSTRAINT FK_TipoServicioHabitacionPorHabitacion_TipoServicioHabitacion FOREIGN KEY (TipoServicioHabitacionID) REFERENCES TipoServicioHabitacion(TipoServicioHabitacionID),
	CONSTRAINT FK_TipoServicioHabitacionPorHabitacion_Habitacion FOREIGN KEY (HabitacionID) REFERENCES Habitacion(HabitacionID),
);

-- cabecera detalle

--CREATE TABLE Reserva (
--	ReservaID INT NOT NULL IDENTITY (1,1),
--	ClienteID INT NOT NULL,
--	AlojamientoID INT NOT NULL,
--	SucursalID INT NOT NULL,
--	HabitacionID INT NOT NULL,
--	PrecioReserva MONEY NOT NULL,
--	MonedaReservaID INT NOT NULL,
--	FechaReserva DATETIME NOT NULL,
--	FechaCheckIn DATETIME NOT NULL,
--	FechaCheckOut DATETIME NOT NULL,
--	Pagado BIT NOT NULL,
--	MedioDePagoID INT NOT NULL,
--	CONSTRAINT PK_Reserva PRIMARY KEY (ReservaID),
--	CONSTRAINT FK_Reserva_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente (ClienteID),
--	CONSTRAINT FK_Reserva_AlojamientoID FOREIGN KEY (AlojamientoID) REFERENCES Alojamiento(AlojamientoID),
--	CONSTRAINT FK_Reserva_Sucursal FOREIGN KEY (SucursalID) REFERENCES Sucursal(SucursalID),
--	CONSTRAINT FK_Reserva_Habitacion FOREIGN KEY (HabitacionID) REFERENCES Habitacion(HabitacionID),
--	CONSTRAINT FK_Reserva_Moneda FOREIGN KEY (MonedaReservaID) REFERENCES Moneda(MonedaID),
--);


-- Vistas. Se deben crear de a uno descomentando y seleccionando el codigo correspondiente.
 --CREATE VIEW vista_cliente AS
 -- SELECT
	--c.ClienteID as Codigo,
	--c.Nombre,
	--c.Apellido,
	--td.Descripcion as [Tipo Documento],
	--c.NroDocumento as [Numero Documento],
	--case c.EstadoCivil
	--	when 's' then 'Soltero'
	--	when 'c' then 'Casado'
	--	when 'v' then 'Viudo'
	--	when 'd' then 'Divorciado'
	--end as [Estado Civil],
	--c.Telefono,
	--c.Direccion,
	--c.Email,
	--c.FechaNacimiento as [Fecha Nacimiento],
	--p.Descripcion as Profesion,
	--case c.Sexo
	--	when 1 then 'Masculino'
	--	when 0 then 'Femenino'
 --   end as Sexo,
	--tc.Descripcion as [Tipo Cliente],
	--case c.EstadoSistema
	--	when 1 then 'Habilitado'
	--	when 0 then 'Deshabilitado'
	--end as [Estado Sistema]
 -- FROM Cliente c JOIN
 -- TipoDocumento td ON td.TipoDocumentoID = c.TipoDocumentoID JOIN
 -- TipoCliente tc on tc.TipoClienteID = c.TipoClienteID JOIN
 -- Profesion p on p.ProfesionID = c.ProfesionID

 -- Vista de Empleado
-- CREATE VIEW vista_Empleado AS
 
-- SELECT        dbo.Empleado.EmpleadoID, dbo.Empleado.Nombre, dbo.Empleado.Apellido, dbo.CargoEmpleado.Nombre AS Cargo, dbo.TipoDocumento.Descripcion, dbo.Empleado.NroDocumento, 
--                         dbo.Empleado.FechaNacimiento, dbo.SucursalEmpresa.Nombre AS Sucursal, dbo.Empleado.Telefono, dbo.Empleado.Direccion, 
--                         CASE dbo.Empleado.EstadoCivil WHEN 's' THEN 'Soltero' WHEN 'c' THEN 'Casado' WHEN 'v' THEN 'Viudo' WHEN 'd' THEN 'Divorciado' END AS [Estado Civil], dbo.Empleado.Antiguedad, 
--                         dbo.Empleado.EstadoSistema
--FROM            dbo.Empleado INNER JOIN
--                         dbo.CargoEmpleado ON dbo.Empleado.CargoEmpleadoID = dbo.CargoEmpleado.CargoEmpleadoID INNER JOIN
--                         dbo.TipoDocumento ON dbo.Empleado.TipoDocumentoID = dbo.TipoDocumento.TipoDocumentoID INNER JOIN
--                         dbo.SucursalEmpresa ON dbo.Empleado.SucursalEmpresaID = dbo.SucursalEmpresa.SucursalEmpresaID;

--vista habitacion
--CREATE VIEW vista_habitacion AS
--SELECT        dbo.Habitacion.HabitacionID, dbo.Habitacion.NroHabitacion, dbo.Habitacion.Precio, dbo.SucursalAlojamiento.Nombre, dbo.TipoHabitacion.Descripcion, dbo.EstadoHabitacion.Descripcion AS Expr1, 
--                         dbo.TipoServicioHabitacion.Descripcion AS Expr2, dbo.Habitacion.EstadoSistema
--FROM            dbo.Habitacion INNER JOIN
--                         dbo.SucursalAlojamiento ON dbo.Habitacion.SucursalAlojamientoID = dbo.SucursalAlojamiento.SucursalAlojamientoID INNER JOIN
--                         dbo.TipoHabitacion ON dbo.Habitacion.TipoHabitacionID = dbo.TipoHabitacion.TipoHabitacionID INNER JOIN
--                         dbo.EstadoHabitacion ON dbo.Habitacion.EstadoHabitacionID = dbo.EstadoHabitacion.EstadoHabitacionID INNER JOIN
--                         dbo.TipoServicioHabitacion ON dbo.Habitacion.ServicioHabitacionID = dbo.TipoServicioHabitacion.TipoServicioHabitacionID

--vista sucursalalojamiento
-- CREATE VIEW vista_sucursal_alojamiento  AS
--SELECT        dbo.SucursalAlojamiento.SucursalAlojamientoID, dbo.Alojamiento.Nombre, dbo.SucursalAlojamiento.Nombre AS Expr1, dbo.Ciudad.Descripcion, dbo.SucursalAlojamiento.Telefono, 
--                         dbo.SucursalAlojamiento.Direccion, dbo.SucursalAlojamiento.Email, dbo.TipoServicioAlojamiento.Descripcion AS Expr2, dbo.SucursalAlojamiento.EstadoSistema
--FROM            dbo.SucursalAlojamiento INNER JOIN
--                         dbo.Alojamiento ON dbo.SucursalAlojamiento.AlojamientoID = dbo.Alojamiento.AlojamientoID INNER JOIN
--                         dbo.Ciudad ON dbo.SucursalAlojamiento.CiudadID = dbo.Ciudad.CiudadID INNER JOIN
--                         dbo.TipoServicioAlojamiento ON dbo.SucursalAlojamiento.ServicioID = dbo.TipoServicioAlojamiento.TipoServicioAlojamientoID