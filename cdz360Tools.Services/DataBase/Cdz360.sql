/****** Script for SelectTopNRows command from SSMS  ******/
SELECT * FROM [Cdz360].[dbo].[TChargingPileInfo] order by thedate desc
go
SELECT * FROM [Cdz360].[dbo].[TChargingPileOnlineStatus] order by thedate desc
go
SELECT * FROM [Cdz360].[dbo].TChargeOver_HisRec order by thedate desc
go
select * from TChargingPileOffline_HisRec order by thedate desc
go

delete from  [TChargingPileInfo]
delete from  [TChargingPileOnlineStatus]
delete from  TChargeOver_HisRec
delete from TChargingPileOffline_HisRec