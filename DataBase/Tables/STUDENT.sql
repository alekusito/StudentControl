/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de estudiantes.
*/

CREATE TABLE STUDENT
(
	STUDENT_ID int not null primary key auto_increment,
	INDIVIDUAL_ID int not null,
    CURRENT_BELT int not null,
    foreign key (INDIVIDUAL_ID) references PERSON(INDIVIDUAL_ID)
)