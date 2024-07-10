﻿CREATE PROC FI_SP_IncClienteBeneficiarioV2
    @NOME          VARCHAR (50) ,
    @CPF           VARCHAR (15),
	@IDCLIENTE     BIGINT
AS
BEGIN
	INSERT INTO BENEFICIARIOS (CPF, NOME, IDCLIENTE) 
	VALUES (@CPF, @NOME, @IDCLIENTE)

	SELECT SCOPE_IDENTITY()
END