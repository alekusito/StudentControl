/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de personal administrativo.
*/

CREATE TABLE ADMINISTRATIVE_CREW
(
	ADMINISTRATIVE_ID int not null primary key auto_increment,
	INDIVIDUAL_ID int not null,
    foreign key (INDIVIDUAL_ID) references PERSON(INDIVIDUAL_ID)
)