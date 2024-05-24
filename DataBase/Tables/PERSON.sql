/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de personas.
*/

CREATE TABLE PERSON
(
	INDIVIDUAL_ID int not null primary key auto_increment,
    DOCUMENT_NUMBER varchar(15) not null,
    FIRST_NAME varchar(20) not null,
    MIDDLE_MANE varchar(20) null,
    LAST_NAME varchar(20) not null,
    SECOND_LAST_NAME varchar(20) null,
    BIRTH_DATE datetime not null,
    ADDRESS varchar(200) not null,
    PHONE_NUMBER varchar(15) not null,
    CELL_PHONE_NUMBER varchar(15) not null,
    MAIL_ADDRESS varchar(100) not null
)
