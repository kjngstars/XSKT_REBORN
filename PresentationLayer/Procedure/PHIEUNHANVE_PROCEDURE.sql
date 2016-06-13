USE QUANLYXOSO;
--PHIEUNHANVE_INSERT
CREATE PROCEDURE PHIEUNHANVE_INSERT	 @p_MAPHIEUNHANVE           VARCHAR(15)   = NULL OUTPUT,
									 @p_NGAYLAP                  datetime = NULL,
									 @p_MADOITAC                 VARCHAR(15) = NULL,
									 @p_MADOTPHATHANH            VARCHAR(15) = NULL
AS
	   INSERT INTO PHIEUNHANVE
	   (MAPHIEUNHANVE,
	    NGAYLAP,
	    MADOITAC,
	    MADOTPHATHANH
	   )
	   VALUES
	   ( @p_MAPHIEUNHANVE ,
		 @p_NGAYLAP ,
		 @p_MADOITAC ,
		 @p_MADOTPHATHANH
	   );
GO
--PHIEUNHANVE_UPDATE
CREATE PROCEDURE PHIEUNHANVE_UPDATE  @p_MAPHIEUNHANVE           VARCHAR(15)   = NULL OUTPUT,
									 @p_NGAYLAP                  datetime = NULL,
									 @p_MADOITAC                 VARCHAR(15) = NULL,
									 @p_MADOTPHATHANH            VARCHAR(15) = NULL
AS
    BEGIN TRANSACTION;
	   UPDATE PHIEUNHANVE
		SET
		    MAPHIEUNHANVE = @p_MAPHIEUNHANVE,
		    NGAYLAP = @p_NGAYLAP,
		    MADOITAC = @p_MADOITAC,
			MADOTPHATHANH = @P_MADOTPHATHANH
	   WHERE MAPHIEUNHANVE = @p_MAPHIEUNHANVE;
	   IF @@Error <> 0
		  GOTO ABORT;
	   COMMIT TRANSACTION;
	   RETURN '0';
	   ABORT:
	BEGIN
	    ROLLBACK TRANSACTION;
	END;
GO
--PHIEUNHANVE_DELETE
CREATE PROCEDURE PHIEUNHANVE_DELETE @p_MAPHIEUNHANVE VARCHAR(15) = NULL
AS
	DELETE
	FROM PHIEUNHANVE
	WHERE MAPHIEUNHANVE = @p_MAPHIEUNHANVE;
GO
--PHIEUNHANVE_SEARCHBYMAPHIEUNHANVE
CREATE PROCEDURE PHIEUNHANVE_SEARCHBYMAPHIEUNHANVE @p_MAPHIEUNHANVE VARCHAR(15) = NULL
AS
	SELECT *
	FROM PHIEUNHANVE
	WHERE MAPHIEUNHANVE = @p_MAPHIEUNHANVE;
GO

--CHITIETPHIEUNHANVE_INSERT
CREATE PROCEDURE CHITIETPHIEUNHANVE_INSERT 	@P_MAPHIEUNHANVE VARCHAR(15) = NULL,
											@P_MALOAIVE VARCHAR(15) = NULL,
											@p_SOLUONGNHAN INT

	
AS 
	   INSERT INTO CHITIETPHIEUNHANVE
	   (
	    MAPHIEUNHANVE,
	    MALOAIVE,
	    SOLUONGNHAN
	   )
	   VALUES
	   (
		 @P_MAPHIEUNHANVE ,
		 @P_MALOAIVE ,
		 @p_SOLUONGNHAN
	   );
	   
GO