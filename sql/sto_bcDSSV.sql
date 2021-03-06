USE [DeMoQLSV]
GO
/****** Object:  StoredProcedure [dbo].[bcDSSV]    Script Date: 4/19/2015 6:30:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- exec bcDSSV N'AU', N'AUTP      ','AUTP1  '
ALTER PROCEDURE [dbo].[bcDSSV] 
	-- Add the parameters for the stored procedure here
	@maK nvarchar(50),
	@maN nvarchar (50),
	@maL nvarchar (50)

AS
DECLARE @SqlStr NVARCHAR(MAX),
        @ParamList NVARCHAR(2000)

	 SELECT @SqlStr =' SELECT distinct A.MaSV, A.TenSV,A.GioiTinh,A.SDT,A.DiaChi,A.Email,A.NgaySinh
                            FROM tbl_SINHVIEN A
                            INNER JOIN tbl_LOP B
                            ON A.MaLop = B.MaLop
                            INNER JOIN tbl_NGHANH C
                            ON B.MaNghanh = C.MaNghanh
                            INNER JOIN tbl_KHOA D
                            ON C.MaKhoa = D.MaKhoa                    
                            WHERE 1 = 1 '
IF @maK  !=''
       SELECT @SqlStr = @SqlStr + '
              AND (D.MaKhoa = @maK)
              '
IF @maN !=''
       SELECT @SqlStr = @SqlStr + '
              AND (C.MaNghanh = @maN)
              '
IF @maL  !=''
       SELECT @SqlStr = @SqlStr + '
             AND (A.MaLop = @maL)
              '
SELECT @Paramlist = '
      @maK nvarchar(50) ,
	@maN nvarchar (50),
	@maL nvarchar (50) 
       '
	   	   EXEC SP_EXECUTESQL	@SqlStr,
								@Paramlist,
								@maK ,
								@maN ,
								@maL 
							