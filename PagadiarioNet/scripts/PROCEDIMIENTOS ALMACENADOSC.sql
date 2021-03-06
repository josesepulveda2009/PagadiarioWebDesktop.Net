CREATE PROCEDURE SP_CLIENTE
(
	@OPCION INT,
	@CEDULA VARCHAR(20), 
	@APELLIDOS VARCHAR(100), 
	@NOMBRES VARCHAR(100), 
	@TELEFONO VARCHAR(10),
	@CELULAR VARCHAR(10), 
	@DIRECCION VARCHAR(MAX), 
	@NOTAS VARCHAR(MAX), 
	@ID INT
)
AS 
BEGIN 
	IF @OPCION = 1 
	BEGIN 
		INSERT INTO CLIENTE(CEDULA, APELLIDOS, NOMBRES, TELEFONO, CELULAR, DIRECCION, NOTAS)
		VALUES(@CEDULA, @APELLIDOS, @NOMBRES, @TELEFONO, @CELULAR, @DIRECCION, @NOTAS)
	END
	
	ELSE IF @OPCION = 2 
	BEGIN 
		UPDATE CLIENTE SET CEDULA=@CEDULA, APELLIDOS=@APELLIDOS, NOMBRES=@NOMBRES, TELEFONO=@TELEFONO, CELULAR=@CELULAR, DIRECCION=@DIRECCION, NOTAS=@NOTAS
		WHERE ID=@ID
	END
	
	ELSE IF @OPCION = 3 
	BEGIN 
		DELETE FROM CLIENTE WHERE ID=@ID
	END    
END 

CREATE PROCEDURE SP_COBRADOR
(
	@OPCION INT,
	@COBRADOR VARCHAR(100),
	@CELULAR VARCHAR(10), 
	@ZONA VARCHAR(MAX),
	@ID INT
)
AS 
BEGIN 
	IF @OPCION = 1 
	BEGIN 
		INSERT INTO COBRADOR(COBRADOR, CELULAR, ZONA)
		VALUES(@COBRADOR, @CELULAR, @ZONA)
	END
	
	ELSE IF @OPCION = 2 
	BEGIN 
		UPDATE COBRADOR SET COBRADOR=@COBRADOR, CELULAR=@CELULAR, ZONA=@ZONA
		WHERE ID=@ID
	END
	
	ELSE IF @OPCION = 3 
	BEGIN 
		DELETE FROM COBRADOR WHERE ID=@ID
	END    
END 