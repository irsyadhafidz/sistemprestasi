insert into Siswa VALUES
('3','1','irsyad','Perempuan','XI IPA 3','Kebumen','2023-08-09','2021/2022');

insert into Perlombaan Values
('1','OSN IPA 2023','Akademik','Kabupaten/Kota',150);
select * from Perlombaan

insert into Prestasi values
('1','STD-0001','DAT-001','Juara 1',250);

delete Siswa 
UPDATE Siswa SET id_siswa=0001 WHERE id_siswa=2

select * from siswa
select max(right(id_pengguna,2)) from Pengguna
select max(right(id_siswa,9)) from Siswa