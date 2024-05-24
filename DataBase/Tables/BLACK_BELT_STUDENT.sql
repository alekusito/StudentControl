/*
- Fecha Creación: 25/12/2021
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de cinturones negros.
*/

CREATE TABLE BLACK_BELT_STUDENT
(
	BLACK_BELT_STUDENT_ID int not null primary key auto_increment,
	INDIVIDUAL_ID int not null,
    BELT_REGISTER_DATE date not null,
    foreign key (INDIVIDUAL_ID) references PERSON(INDIVIDUAL_ID)
)