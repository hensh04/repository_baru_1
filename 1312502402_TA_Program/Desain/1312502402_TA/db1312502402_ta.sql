# Host: localhost  (Version: 5.5.5-10.1.9-MariaDB)
# Date: 2016-06-22 17:12:33
# Generator: MySQL-Front 5.3  (Build 4.271)

/*!40101 SET NAMES latin1 */;

#
# Structure for table "detil_nota"
#

DROP TABLE IF EXISTS `detil_nota`;
CREATE TABLE `detil_nota` (
  `no_nota` varchar(8) NOT NULL DEFAULT '',
  `kd_obat` varchar(4) NOT NULL,
  `jml_obat_nota` int(2) DEFAULT NULL,
  `harga` int(2) DEFAULT NULL,
  `aturan_pakai_nota` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`no_nota`,`kd_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "detil_nota"
#

INSERT INTO `detil_nota` VALUES ('NOA00001','O001',10,30000,'3x1'),('NOA00001','O002',5,25000,'1x1'),('NOA00002','O001',10,30000,'2x1'),('NOA00002','O004',6,1000,'3x3'),('NOA00003','O002',2,25000,'1x1'),('NOA00003','O004',2,1000,'2x1');

#
# Structure for table "detil_resep"
#

DROP TABLE IF EXISTS `detil_resep`;
CREATE TABLE `detil_resep` (
  `no_resep` varchar(8) NOT NULL DEFAULT '',
  `kd_obat` varchar(4) NOT NULL,
  `jml_obat` int(2) DEFAULT NULL,
  `aturan_pakai` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`no_resep`,`kd_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "detil_resep"
#

INSERT INTO `detil_resep` VALUES ('RSP00001','O001',10,'3x1'),('RSP00001','O002',5,'1x1'),('RSP00002','O001',1,'1x1'),('RSP00003','O001',5,'2x1'),('RSP00003','O004',5,'3x3'),('RSP00004','O002',2,'1x1'),('RSP00004','O004',3,'2x1');

#
# Structure for table "detil_tindakan"
#

DROP TABLE IF EXISTS `detil_tindakan`;
CREATE TABLE `detil_tindakan` (
  `no_daftar` varchar(8) NOT NULL DEFAULT '',
  `kd_tindakan` varchar(4) NOT NULL,
  `banyaknya_tindakan` int(2) DEFAULT NULL,
  `biaya_tindakan` int(2) DEFAULT NULL,
  PRIMARY KEY (`no_daftar`,`kd_tindakan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "detil_tindakan"
#

INSERT INTO `detil_tindakan` VALUES ('DAF00001','TD01',2,35000),('DAF00002','TD01',1,35000),('DAF00002','TD02',1,120000),('DAF00007','TD03',1,200000),('DAF00009','TD01',5,35000),('DAF00009','TD02',2,120000),('DAF00010','TD03',1,200000),('DAF00011','TD01',1,35000);

#
# Structure for table "dokter"
#

DROP TABLE IF EXISTS `dokter`;
CREATE TABLE `dokter` (
  `kd_dokter` varchar(4) NOT NULL DEFAULT '',
  `nm_dokter` varchar(30) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `jns_kelamin` varchar(6) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `telepon` varchar(12) DEFAULT NULL,
  `biaya_jasa` int(2) DEFAULT NULL,
  PRIMARY KEY (`kd_dokter`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "dokter"
#

INSERT INTO `dokter` VALUES ('DR01','Test 1','1990-06-13','Pria','alamat 1','085682392324',25000),('DR02','Aluia Deta Mahardika','1995-07-12','Wanita','Ciledug','085695152331',30000),('DR03','aa','2016-05-16','Wanita','asd','234',7123),('DR04','Wahyudi','1989-05-22','Pria','jalan sawangan','085626565325',25000),('DR05','giri','1981-02-03','Pria','ciputat','086959695555',25000);

#
# Structure for table "kartu_status"
#

DROP TABLE IF EXISTS `kartu_status`;
CREATE TABLE `kartu_status` (
  `no_daftar` varchar(8) NOT NULL DEFAULT '',
  `tgl_kartu_status` date DEFAULT NULL,
  `keluhan` varchar(100) DEFAULT NULL,
  `diagnosa` varchar(100) DEFAULT NULL,
  `berat_badan` varchar(3) DEFAULT NULL,
  `tinggi_badan` varchar(3) DEFAULT NULL,
  `tensi` varchar(7) DEFAULT NULL,
  `no_pasien` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "kartu_status"
#

INSERT INTO `kartu_status` VALUES ('DAF00001','2016-05-22','Batuk dan menelan makanan sakit','Radang Tenggorokan','50','170','117/76','P00001'),('DAF00002','2016-05-20','digigit Binatang','digigit Binatang','65','165','117/76','P00003'),('DAF00003','2016-06-03','Hidung Meler, pusing','Flu dan Demam','80','171','120/76','P00004'),('DAF00004','2016-06-03','Pilek','Flu','50','160','120/73','P00001'),('DAF00005','2016-06-09','tenggorokan ga enak','batuk','45','150','120/100','P00002'),('DAF00006','2016-06-09','sakit tenggorokan dan pusing','batuk dan pilek','75','168','170/78','P00005'),('DAF00007','2016-06-09','cekup','cekup','50','165','120/78','P00001'),('DAF00009','2016-06-21','sering tersakiti','rapuh','180','155','100/100','P00006'),('DAF00010','2016-06-21','aaa','bbb','12','12','12','P00002'),('DAF00011','2016-06-21','keluhan aaa','diagnosa aaaa','34','12','23','P00007');

#
# Structure for table "kwitansi"
#

DROP TABLE IF EXISTS `kwitansi`;
CREATE TABLE `kwitansi` (
  `no_kwitansi` varchar(8) NOT NULL DEFAULT '',
  `tgl_kwitansi` date DEFAULT NULL,
  `no_daftar` varchar(8) NOT NULL,
  PRIMARY KEY (`no_kwitansi`,`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "kwitansi"
#

INSERT INTO `kwitansi` VALUES ('KWT00001','2016-06-10','DAF00004'),('KWT00002','2016-06-10','DAF00006'),('KWT00003','2016-06-10','DAF00003'),('KWT00004','2016-06-13','DAF00005'),('KWT00005','2016-06-13','DAF00007'),('KWT00006','2016-06-13','DAF00002'),('KWT00007','2016-06-21','DAF00009'),('KWT00008','2016-06-21','DAF00010'),('KWT00009','2016-06-21','DAF00011');

#
# Structure for table "nota"
#

DROP TABLE IF EXISTS `nota`;
CREATE TABLE `nota` (
  `no_nota` varchar(8) NOT NULL DEFAULT '',
  `tgl_nota` date DEFAULT NULL,
  `no_resep` varchar(8) NOT NULL DEFAULT '',
  PRIMARY KEY (`no_nota`,`no_resep`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "nota"
#

INSERT INTO `nota` VALUES ('NOA00001','2016-06-10','RSP00001'),('NOA00002','2016-06-13','RSP00003'),('NOA00003','2016-06-21','RSP00004');

#
# Structure for table "obat"
#

DROP TABLE IF EXISTS `obat`;
CREATE TABLE `obat` (
  `kd_obat` varchar(4) NOT NULL DEFAULT '',
  `nm_obat` varchar(25) DEFAULT NULL,
  `jns_obat` varchar(8) DEFAULT NULL,
  `harga_obat` int(2) DEFAULT NULL,
  `satuan` varchar(10) DEFAULT NULL,
  `stock` int(2) DEFAULT NULL,
  PRIMARY KEY (`kd_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "obat"
#

INSERT INTO `obat` VALUES ('O001','Flunax','Tablet',30000,'Strip',530),('O002','OBH','Sirup',25000,'Botol',281),('O003','teset1','Kapsul',6000,'strip',196),('O004','panadol','Tablet',1000,'strip',288);

#
# Structure for table "pasien"
#

DROP TABLE IF EXISTS `pasien`;
CREATE TABLE `pasien` (
  `no_pasien` varchar(6) NOT NULL DEFAULT '',
  `nm_pasien` varchar(30) DEFAULT NULL,
  `tmpt_lahir` varchar(20) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `jns_kelamin` varchar(6) DEFAULT NULL,
  `usia` int(3) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `telepon` varchar(12) DEFAULT NULL,
  `agama` varchar(10) DEFAULT NULL,
  `golongan_darah` varchar(2) DEFAULT NULL,
  `pekerjaan` varchar(25) DEFAULT NULL,
  `kk` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "pasien"
#

INSERT INTO `pasien` VALUES ('P00001','Hendri Pratama','Jakarta','1994-02-02','Pria',22,'Jl.Raya Parung-Ciputat, Bojongsari, Depok','085695152330','Islam','A','Mahasiswa','Hen'),('P00002','asd','asd','2016-05-09','Wanita',2,'asd','21','Protestan','B','asd','we'),('P00003','Fandi','Cipulir','1994-10-21','Pria',22,'Jl.Cipulir','02351561','Islam','B','Mahasiswa','munarif'),('P00004','Husni','Bintaro','1994-03-22','Pria',22,'TMII','008','Islam','A','Mahasiswa','Giri'),('P00005','humisar','jakarta','1980-06-09','Pria',36,'jalan ciledug','087484848343','Islam','A','dosen','giri'),('P00006','Rizky','Bandara','1990-06-14','Pria',26,'Bandara 123','088888888888','Islam','O','Dota Player','Riz'),('P00007','pake obat','aaa','2016-06-06','Wanita',0,'sdsdsd','2323','Lainnya','B','player','bapak');

#
# Structure for table "pendaftaran"
#

DROP TABLE IF EXISTS `pendaftaran`;
CREATE TABLE `pendaftaran` (
  `no_daftar` varchar(8) NOT NULL DEFAULT '',
  `tgl_daftar` date DEFAULT NULL,
  `biaya_daftar` int(2) DEFAULT NULL,
  `biaya_dokter` int(2) DEFAULT NULL,
  `kd_petugas` varchar(6) NOT NULL,
  `kd_dokter` varchar(4) NOT NULL,
  `no_pasien` varchar(6) NOT NULL,
  PRIMARY KEY (`no_daftar`,`kd_petugas`,`kd_dokter`,`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "pendaftaran"
#

INSERT INTO `pendaftaran` VALUES ('DAF00001','2016-05-20',2000,30000,'PTG001','DR02','P00001'),('DAF00002','2016-05-20',2000,25000,'PTG001','DR04','P00003'),('DAF00003','2016-06-03',2000,25000,'PTG001','DR04','P00004'),('DAF00004','2016-06-03',2000,25000,'PTG001','DR04','P00001'),('DAF00005','2016-06-09',2000,25000,'PTG001','DR01','P00002'),('DAF00006','2016-06-09',2000,25000,'PTG002','DR05','P00005'),('DAF00007','2016-06-09',2000,30000,'PTG002','DR02','P00001'),('DAF00008','2016-06-15',2000,25000,'PTG003','DR04','P00004'),('DAF00009','2016-06-21',2000,25000,'admin','DR04','P00006'),('DAF00010','2016-06-21',2000,25000,'admin','DR04','P00002'),('DAF00011','2016-06-21',2000,7123,'admin','DR03','P00007');

#
# Structure for table "petugas"
#

DROP TABLE IF EXISTS `petugas`;
CREATE TABLE `petugas` (
  `kd_petugas` varchar(6) NOT NULL DEFAULT '',
  `nm_petugas` varchar(30) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `jns_kelamin` varchar(6) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `telepon` varchar(12) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_petugas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "petugas"
#

INSERT INTO `petugas` VALUES ('admin','Hendri Pratama','1994-02-04','Pria','Jl.Raya Ciputat-Parung','02518603359','hensh'),('PTG001','Wawan','1965-05-17','Pria','Jl.Bojongsari','085214597845','22222'),('PTG002','hendri','2010-02-02','Pria','sawangan depok','087747548574','22222'),('PTG003','Husni Outlaw','1994-03-22','Pria','Taman Mangu Indah ','085771446292','220394');

#
# Structure for table "resep"
#

DROP TABLE IF EXISTS `resep`;
CREATE TABLE `resep` (
  `no_resep` varchar(8) NOT NULL DEFAULT '',
  `tgl_resep` date DEFAULT NULL,
  `no_daftar` varchar(8) NOT NULL,
  PRIMARY KEY (`no_resep`,`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "resep"
#

INSERT INTO `resep` VALUES ('RSP00001','2016-06-10','DAF00004'),('RSP00002','2016-06-10','DAF00006'),('RSP00003','2016-06-13','DAF00002'),('RSP00004','2016-06-21','DAF00011');

#
# Structure for table "surat_rujukan"
#

DROP TABLE IF EXISTS `surat_rujukan`;
CREATE TABLE `surat_rujukan` (
  `no_surat_rujukan` varchar(8) NOT NULL DEFAULT '',
  `tgl_surat_rujukan` date DEFAULT NULL,
  `tempat_rujukan` varchar(50) DEFAULT NULL,
  `keperluan` varchar(100) DEFAULT NULL,
  `no_daftar` varchar(8) NOT NULL,
  PRIMARY KEY (`no_surat_rujukan`,`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "surat_rujukan"
#

INSERT INTO `surat_rujukan` VALUES ('NSR00001','2016-05-24','RS. Sari Asih Ciputat','Cek Rontgen','DAF00001'),('NSR00002','2016-05-31','RS. Sari Asih Ciledug','suntik','DAF00002'),('NSR00003','2016-06-09','rs sari asih','cek darah','DAF00006');

#
# Structure for table "surat_sakit"
#

DROP TABLE IF EXISTS `surat_sakit`;
CREATE TABLE `surat_sakit` (
  `no_surat_sakit` varchar(8) NOT NULL DEFAULT '',
  `tgl_surat_sakit` date DEFAULT NULL,
  `keperluan` varchar(100) DEFAULT NULL,
  `no_daftar` varchar(8) NOT NULL,
  PRIMARY KEY (`no_surat_sakit`,`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "surat_sakit"
#

INSERT INTO `surat_sakit` VALUES ('NSK00001','2016-05-24','Istirahat izin tidak hadir kelas kuliah selama 2 hari dari tanggal 25-28 mei 2016','DAF00001'),('NSK00002','2016-06-09','izin tidak masuk kuliah dari tanggal 3 - 4 juni','DAF00006');

#
# Structure for table "surat_sehat"
#

DROP TABLE IF EXISTS `surat_sehat`;
CREATE TABLE `surat_sehat` (
  `no_surat_sehat` varchar(8) NOT NULL DEFAULT '',
  `tgl_surat_sehat` date DEFAULT NULL,
  `keperluan` varchar(100) DEFAULT NULL,
  `no_daftar` varchar(8) NOT NULL,
  PRIMARY KEY (`no_surat_sehat`,`no_daftar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "surat_sehat"
#

INSERT INTO `surat_sehat` VALUES ('NSS00001','2016-05-24','Untuk Melamar','DAF00001'),('NSS00002','2016-06-01','untuk itu','DAF00002'),('NSS00003','2016-06-09','lamaran kerja','DAF00006');

#
# Structure for table "tindakan"
#

DROP TABLE IF EXISTS `tindakan`;
CREATE TABLE `tindakan` (
  `kd_tindakan` varchar(4) NOT NULL DEFAULT '',
  `nm_tindakan` varchar(30) DEFAULT NULL,
  `harga_tindakan` int(2) DEFAULT NULL,
  PRIMARY KEY (`kd_tindakan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "tindakan"
#

INSERT INTO `tindakan` VALUES ('TD01','Imunisasi 1',35000),('TD02','Suntik Rabies',120000),('TD03','cekup',200000);

#
# Structure for table "cetakankwitansi2"
#

DROP VIEW IF EXISTS `cetakankwitansi2`;
CREATE VIEW `cetakankwitansi2` AS 
  select `x`.`no_kwitansi` AS `no_kwitansi`,`e`.`nm_petugas` AS `nm_petugas`,`b`.`no_nota` AS `no_nota`,`b`.`tgl_nota` AS `tgl_nota`,`a`.`biaya_daftar` AS `biaya_daftar`,`a`.`biaya_dokter` AS `biaya_dokter`,(select ifnull(sum((`detil_tindakan`.`banyaknya_tindakan` * `detil_tindakan`.`biaya_tindakan`)),0) from `detil_tindakan` where (`detil_tindakan`.`no_daftar` = `a`.`no_daftar`)) AS `biaya_tindakan`,(select ifnull(sum((`detil_nota`.`jml_obat_nota` * `detil_nota`.`harga`)),0) from (`nota` join `detil_nota`) where ((`nota`.`no_resep` = `z`.`no_resep`) and (`nota`.`no_nota` = `detil_nota`.`no_nota`))) AS `Biaya_OBAT`,`d`.`no_pasien` AS `no_pasien`,`d`.`nm_pasien` AS `nm_pasien`,`f`.`nm_dokter` AS `nm_dokter` from (`pasien` `d` left join (`dokter` `f` left join (((`petugas` `e` left join (`kwitansi` `x` left join `pendaftaran` `a` on((`x`.`no_daftar` = `a`.`no_daftar`))) on((`a`.`kd_petugas` = `e`.`kd_petugas`))) left join `resep` `z` on((`z`.`no_daftar` = `a`.`no_daftar`))) left join `nota` `b` on((`b`.`no_resep` = `z`.`no_resep`))) on((`a`.`kd_dokter` = `f`.`kd_dokter`))) on((`a`.`no_pasien` = `d`.`no_pasien`))) group by `a`.`no_daftar`;

#
# Structure for table "laporanpendatan"
#

DROP VIEW IF EXISTS `laporanpendatan`;
CREATE VIEW `laporanpendatan` AS 
  select `x`.`tgl_kwitansi` AS `TanggalKwt`,`d`.`nm_pasien` AS `NamaPasien`,(((`a`.`biaya_daftar` + `a`.`biaya_dokter`) + (select ifnull(sum((`detil_tindakan`.`banyaknya_tindakan` * `detil_tindakan`.`biaya_tindakan`)),0) from `detil_tindakan` where (`detil_tindakan`.`no_daftar` = `a`.`no_daftar`))) + (select ifnull(sum((`detil_nota`.`jml_obat_nota` * `detil_nota`.`harga`)),0) from (`nota` join `detil_nota`) where ((`nota`.`no_resep` = `z`.`no_resep`) and (`nota`.`no_nota` = `detil_nota`.`no_nota`)))) AS `Biaya_Keseluruhan` from (`pasien` `d` left join (`dokter` `f` left join (((`petugas` `e` left join (`kwitansi` `x` left join `pendaftaran` `a` on((`x`.`no_daftar` = `a`.`no_daftar`))) on((`a`.`kd_petugas` = `e`.`kd_petugas`))) left join `resep` `z` on((`z`.`no_daftar` = `a`.`no_daftar`))) left join `nota` `b` on((`b`.`no_resep` = `z`.`no_resep`))) on((`a`.`kd_dokter` = `f`.`kd_dokter`))) on((`a`.`no_pasien` = `d`.`no_pasien`))) group by `a`.`no_daftar`;

#
# Structure for table "laporanrekap"
#

DROP VIEW IF EXISTS `laporanrekap`;
CREATE VIEW `laporanrekap` AS 
  select `a`.`tgl_nota` AS `TanggalNota`,`c`.`nm_obat` AS `NamaObat`,sum(`b`.`jml_obat_nota`) AS `TotalPenggunaan` from ((`nota` `a` join `detil_nota` `b`) join `obat` `c`) where ((`b`.`no_nota` = `a`.`no_nota`) and (`b`.`kd_obat` = `c`.`kd_obat`)) group by `a`.`tgl_nota`,`b`.`kd_obat` order by sum(`b`.`jml_obat_nota`) desc;

#
# Structure for table "viewkwitansi"
#

DROP VIEW IF EXISTS `viewkwitansi`;
CREATE VIEW `viewkwitansi` AS 
  select `x`.`no_kwitansi` AS `no_kwitansi`,`e`.`nm_petugas` AS `nm_petugas`,`b`.`no_nota` AS `no_nota`,`b`.`tgl_nota` AS `tgl_nota`,`a`.`biaya_daftar` AS `biaya_daftar`,`a`.`biaya_dokter` AS `biaya_dokter`,(select ifnull(sum((`detil_tindakan`.`banyaknya_tindakan` * `detil_tindakan`.`biaya_tindakan`)),0) from `detil_tindakan` where (`detil_tindakan`.`no_daftar` = `a`.`no_daftar`)) AS `biaya_tindakan`,(select ifnull(sum((`detil_nota`.`jml_obat_nota` * `detil_nota`.`harga`)),0) from (`nota` join `detil_nota`) where ((`nota`.`no_resep` = `z`.`no_resep`) and (`nota`.`no_nota` = `detil_nota`.`no_nota`))) AS `Biaya_OBAT`,`d`.`no_pasien` AS `no_pasien`,`d`.`nm_pasien` AS `nm_pasien`,`f`.`nm_dokter` AS `nm_dokter` from (((((((`resep` `z` left join `pendaftaran` `a` on((`z`.`no_daftar` = `a`.`no_daftar`))) left join `nota` `b` on((`b`.`no_resep` = `z`.`no_resep`))) left join `dokter` `f` on((`a`.`kd_dokter` = `f`.`kd_dokter`))) left join `pasien` `d` on((`a`.`no_pasien` = `d`.`no_pasien`))) left join `petugas` `e` on((`a`.`kd_petugas` = `e`.`kd_petugas`))) left join `surat_sehat` `k` on((`k`.`no_daftar` = `a`.`no_daftar`))) left join `kwitansi` `x` on((`x`.`no_daftar` = `a`.`no_daftar`))) group by `a`.`no_daftar`;
