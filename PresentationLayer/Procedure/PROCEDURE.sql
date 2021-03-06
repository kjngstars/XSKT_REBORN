USE QUANLYXOSO;
CREATE PROCEDURE GENCODE @p_PREFIX VARCHAR(15),
					@p_KEYGEN VARCHAR(15) OUT
AS
	DECLARE @CurrentValue AS NUMERIC;
	BEGIN TRANSACTION;
	IF NOT EXISTS
	(
	    SELECT CURRENTVALUE
	    FROM PREFIX
	    WHERE PREFIX = @p_PREFIX
	)
	    BEGIN
		   INSERT INTO PREFIX
		   (PREFIX,
		    CURRENTVALUE
		   )
		   VALUES
		   (@p_PREFIX,
		    1
		   );
		   IF @@ERROR <> 0
			  GOTO ABORT;
		   SET @CurrentValue = 1;
	    END;
	ELSE
	    BEGIN
		   IF EXISTS
		   (
			  SELECT CURRENTVALUE
			  FROM PREFIX
			  WHERE PREFIX = @p_PREFIX
		   )
			  UPDATE PREFIX
			    SET
				   CURRENTVALUE = CURRENTVALUE + 1
			  WHERE PREFIX = @p_PREFIX;
		   IF @@ERROR <> 0
			  GOTO ABORT;
		   SELECT @CurrentValue = CURRENTVALUE
		   FROM PREFIX
		   WHERE PREFIX = @p_PREFIX;
	    END;
	SET @p_KEYGEN = @p_PREFIX+RIGHT('000000000000000'+CONVERT(VARCHAR(15), @CurrentValue), 15 - LEN(@p_PREFIX));
	IF @@ERROR <> 0
	    GOTO ABORT;
	COMMIT TRANSACTION;
	RETURN 0;
	ABORT:
	BEGIN
	    ROLLBACK TRANSACTION;
	    SET @p_KEYGEN = '';
	    RETURN -1;
	END;