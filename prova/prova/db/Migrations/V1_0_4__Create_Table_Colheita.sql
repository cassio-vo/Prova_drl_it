CREATE TABLE `colheita` (
	`Id` int(10) UNSIGNED NOT NULL,
	`Informacoes` VARCHAR(50) NULL DEFAULT NULL,
	`DataColheita` datetime(6) NULL DEFAULT NULL,
	`PesoBruto` decimal(65,2) NULL DEFAULT NULL,
	`IdArvore` int(10) UNSIGNED NULL DEFAULT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (`IdArvore`) REFERENCES Arvore(`Id`)
)
ENGINE=InnoDB
;