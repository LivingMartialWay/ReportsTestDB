CREATE PROCEDURE [dbo].[spDropOffLog_GetRecords]
	@startDate datetime,
	@endDate datetime
AS
begin
	set nocount on;

select * from dbo.ReportTestTable r
where @startDate <= r.DeliveredWhen and @endDate >= r.DeliveredWhen

end
