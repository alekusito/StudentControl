/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de profesores.
*/

CREATE TABLE TEACHER
(
	TEACHER_ID int not null primary key auto_increment,
	INDIVIDUAL_ID int not null,
    foreign key (INDIVIDUAL_ID) references PERSON(INDIVIDUAL_ID)
)