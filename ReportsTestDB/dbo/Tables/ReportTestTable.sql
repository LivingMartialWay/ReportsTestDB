CREATE TABLE [dbo].[ReportTestTable] (
    [RecNo]         INT           IDENTITY (1, 1) NOT NULL,
    [DeliveryType]  NVARCHAR (50) NOT NULL,
    [DeliveredWhen] DATETIME      NOT NULL,
    [DeliveredBy]   NVARCHAR (50) NOT NULL,
    [BusinessName]  NVARCHAR (50) NOT NULL,
    [DeliveredTo]   NVARCHAR (50) NOT NULL,
    [ItemType]      NVARCHAR (50) NOT NULL,
    [CheckNo]       NVARCHAR (50) NOT NULL,
    [RecievedBy]    NVARCHAR (50) NOT NULL,
    [ProcessedBy]   NVARCHAR (50) NOT NULL,
    [ProcessedDate] DATETIME      NOT NULL
);

