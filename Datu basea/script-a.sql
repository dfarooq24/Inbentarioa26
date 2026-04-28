create schema inbentarioa26;
USE inbentarioa26;

-- 1. TAULA MINTEGIA
CREATE TABLE mintegia (
    id_mintegia INT AUTO_INCREMENT PRIMARY KEY,
    izena VARCHAR(100) NOT NULL
);

-- 2. TAULA ERABILTZAILEA
CREATE TABLE erabiltzailea (
    id_erab INT AUTO_INCREMENT PRIMARY KEY,
    izena VARCHAR(100) NOT NULL,
    pasahitza VARCHAR(255) NOT NULL,
    rola VARCHAR(50) NOT NULL,
    id_mintegia INT,
    FOREIGN KEY (id_mintegia) REFERENCES mintegia(id_mintegia)
);

-- 3. TAULA GAILUA
CREATE TABLE gailua (
    id_gailu INT AUTO_INCREMENT PRIMARY KEY,
    marka VARCHAR(100) NOT NULL,
    modelo VARCHAR(100),
    erosketa_data DATE,
    egoera VARCHAR(50),
    kokalekua VARCHAR(100),
    mota VARCHAR(50) NOT NULL,
    id_mintegia INT,
    FOREIGN KEY (id_mintegia) REFERENCES mintegia(id_mintegia)
);

-- 4. TAULA ORDENAGAILUA
CREATE TABLE ordenagailua (
    id_ordenagailu INT AUTO_INCREMENT PRIMARY KEY,
    id_gailu INT NOT NULL UNIQUE,
    rom VARCHAR(50),
    ram VARCHAR(50),
    cpu VARCHAR(100),
    FOREIGN KEY (id_gailu) REFERENCES gailua(id_gailu)
        ON DELETE CASCADE
);

-- 5. TAULA INPRIMAGAILUA
CREATE TABLE inprimagailua (
    id_inprimagailu INT AUTO_INCREMENT PRIMARY KEY,
    id_gailu INT NOT NULL UNIQUE,
    kolorea BOOLEAN NOT NULL,
    FOREIGN KEY (id_gailu) REFERENCES gailua(id_gailu)
        ON DELETE CASCADE
);

-- 6. TAULA EZABATUTAKO_GAILUA
CREATE TABLE ezabatutako_gailua (
    id_ezabatua INT AUTO_INCREMENT PRIMARY KEY,
    id_gailu_originala INT,
    marka VARCHAR(100),
    modelo VARCHAR(100),
    erosketa_data DATE,
    egoera VARCHAR(50),
    kokalekua VARCHAR(100),
    mota VARCHAR(50),
    id_mintegia INT,
    ezabatze_data DATETIME NOT NULL
);
-- INSERTAK
-- Mintegia
INSERT INTO mintegia (izena) VALUES 
('Informatika'),
('Matematika'),
('Administrazioa');
-- Erabiltzailea
INSERT INTO erabiltzailea (izena, pasahitza, rola, id_mintegia) VALUES
('ikt', '1234', 'admin', 1),
('irak', '1234', 'mintegi_burua', 1),
('admin', '1234', 'irakaslea', 2);
-- Gailua
INSERT INTO gailua (marka, modelo, erosketa_data, egoera, mota, id_mintegia) VALUES
('HP', 'EliteBook', '2022-05-10', 'aktibo', 'ordenagailua', 1),
('Dell', 'OptiPlex', '2021-03-15', 'aktibo', 'ordenagailua', 1),
('Epson', 'XP-3100', '2020-11-20', 'aktibo', 'inprimagailua', 2),
('Canon', 'MG2550', '2019-07-01', 'apurtuta', 'inprimagailua', 3);
-- Ordenagilua
INSERT INTO ordenagailua (id_gailu, rom, ram, cpu) VALUES
(1, '512GB', '16GB', 'Intel i7'),
(2, '256GB', '8GB', 'Intel i5');
-- Inprimagailua
INSERT INTO inprimagailua (id_gailu, kolorea) VALUES
(3, TRUE),
(4, FALSE);
-- Ezabatutako gailua
INSERT INTO ezabatutako_gailua 
(id_gailu_originala, marka, modelo, erosketa_data, egoera, kokalekua, mota, id_mintegia, ezabatze_data)
VALUES
(5, 'Lenovo', 'ThinkPad', '2020-01-10', 'aktibo', 'Gela 103', 'ordenagailua', 1, NOW());


-- Borratu "kokalekua"
ALTER TABLE gailua
DROP COLUMN kokalekua;

ALTER TABLE ezabatutako_gailua
DROP COLUMN kokalekua;
