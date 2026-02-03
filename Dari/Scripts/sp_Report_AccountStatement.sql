-- =============================================
-- تقرير كشف الحساب (مستأجر أو عقار)
-- نفّذ هذا السكربت على قاعدة البيانات Dari
-- =============================================
-- المعاملات:
--   @ReportType: 1 = كشف حساب مستأجر, 2 = كشف حساب عقار
--   @MovementType: NULL = الكل, '1' = إيجار, '2' = فاتورة, '3' = سندات
-- =============================================

IF OBJECT_ID('sp_Report_AccountStatement', 'P') IS NOT NULL
    DROP PROCEDURE sp_Report_AccountStatement;
GO

CREATE PROCEDURE sp_Report_AccountStatement
    @ReportType        INT,              -- 1 مستأجر, 2 عقار
    @TenantNo          NVARCHAR(50) = NULL,
    @PropertyNo        NVARCHAR(50) = NULL,
    @ApartmentNo       NVARCHAR(50) = NULL,
    @Year              INT = NULL,
    @FromMonth         INT = NULL,
    @ToMonth           INT = NULL,
    @MovementType      NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- افترض أن جدول الحركات المالية اسمه FinancialMovements والأعمدة كالتالي (عدّل أسماء الجدول/الأعمدة إن اختلفت):
    -- MovementType, DocumentNo, DocumentType, DocumentDate, BillYear, BillMonth, TenantNo, ApartmentNo, Debit, Credit, Notes

    SELECT
        fm.DocumentNo        AS [رقم المستند],
        CASE fm.MovementType
            WHEN '1' THEN N'إيجار'
            WHEN '2' THEN N'فاتورة'
            WHEN '3' THEN N'سندات'
            ELSE fm.MovementType
        END                  AS [نوع المستند],
        fm.DocumentDate      AS [التاريخ],
        fm.BillYear          AS [سنة],
        fm.BillMonth         AS [شهر],
        fm.TenantNo          AS [رقم المستأجر],
        fm.ApartmentNo       AS [رقم الشقة],
        ISNULL(fm.Debit, 0)  AS [مدين],
        ISNULL(fm.Credit, 0) AS [دائن],
        fm.Notes             AS [ملاحظات]
    FROM FinancialMovements fm
    LEFT JOIN Apartments a ON a.ApartmentNo = fm.ApartmentNo
    WHERE 1 = 1
      AND (@ReportType = 1 AND (@TenantNo IS NULL OR fm.TenantNo = @TenantNo))
      AND (@ReportType = 2 AND (@PropertyNo IS NULL OR a.PropertyNo = @PropertyNo))
      AND (@ApartmentNo IS NULL OR fm.ApartmentNo = @ApartmentNo)
      AND (@Year IS NULL OR fm.BillYear = @Year)
      AND (@FromMonth IS NULL OR fm.BillMonth >= @FromMonth)
      AND (@ToMonth IS NULL OR fm.BillMonth <= @ToMonth)
      AND (@MovementType IS NULL OR fm.MovementType = @MovementType)
    ORDER BY fm.DocumentDate, fm.DocumentNo;
END
GO
