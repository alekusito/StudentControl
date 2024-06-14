/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de personas.
*/

CREATE TABLE PERSON
(
	INDIVIDUAL_ID int not null primary key auto_increment,
    DOCUMENT_NUMBER varchar(15) null,
    FIRST_NAME varchar(20) not null,
    MIDDLE_NAME varchar(20) null,
    LAST_NAME varchar(20) not null,
    SECOND_LAST_NAME varchar(20) null,
    BIRTH_DATE datetime null,
    ADDRESS varchar(200) null,
    PHONE_NUMBER varchar(15) null,
    CELL_PHONE_NUMBER varchar(15) null,
    MAIL_ADDRESS varchar(100) null
)
