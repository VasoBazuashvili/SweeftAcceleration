--პირველი დავალება ცხრილების შექმნა
--მასწების ცხრილის შექმნა
CREATE TABLE Teacher (
    ID int PRIMARY KEY,
    name varchar(250) NOT NULL,
    surname varchar(250) NOT NULL,
    gender varchar(10) NOT NULL,
    subject varchar(250) NOT NULL
);


--მოსწების ცხრილის შექმნა
CREATE TABLE Pupil (
    ID int PRIMARY KEY,
    first_name varchar(250) NOT NULL,
    last_name varchar(250) NOT NULL,
    gender varchar(10) NOT NULL,
    class varchar(250) NOT NULL
);

--დაჯოინება
CREATE TABLE Teacher_Pupil (
    teacher_id int NOT NULL,
    pupil_id int NOT NULL,
    PRIMARY KEY (teacher_id, pupil_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(ID),
    FOREIGN KEY (pupil_id) REFERENCES Pupil(ID)
);

--მეორე დავალება - გიორგის მასწების ძებნა

SELECT DISTINCT t.name, t.surname
FROM Teacher t
JOIN Teacher_Pupil tp ON t.ID = tp.teacher_id
JOIN Pupil p ON tp.pupil_id = p.ID
WHERE p.first_name = 'Giorgi';

