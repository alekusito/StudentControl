/*
- Fecha Creación: 19/03/2023
- Autor: Alejandro Villagrán
- Descripción: Tabla para registro de ascensos.
*/

CREATE TABLE BELT_PROMOTION
(
	ID int not null primary key auto_increment,
    PROMOTION_DATE datetime not null,
	STUDENT_ID int not null,
    PROMOTED_BELT int not null,
    foreign key (STUDENT_ID) references STUDENT(STUDENT_ID),
    foreign key (PROMOTED_BELT) references BELT(BELT_ID)
)