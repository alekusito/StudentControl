/*
- Fecha Creación: 14/06/2024
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de personas.
*/

CREATE TABLE PERSON_CONTACT
(
    ID int not null primary key auto_increment,
	PERSON_INDIVIDUAL_ID int not null,
    CONTACT_INDIVIDUAL_ID int not null
)