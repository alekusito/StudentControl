/*
- Fecha Creación: 14/06/2024
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de condiciones médicas de la persona.
*/

CREATE TABLE PERSON_MEDICAL_CONDITION
(
    ID int not null primary key auto_increment,
	INDIVIDUAL_ID int not null,
    DESCRIPTION varchar(500) not null
)