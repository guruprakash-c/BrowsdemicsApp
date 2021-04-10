USE [NewsDBNw]
GO
CREATE TABLE MediaMaster(
	mediaId uniqueidentifier primary key,
	accountHolder varchar(50),
	mediaName varchar (100) NOT NULL,
	mediaEndpointUrl ntext NOT NULL,
	mediaKey ntext NOT NULL,
	keywordParam varchar(50) null,
	languageParam varchar(50) null,
	countryParam varchar(50) null,
	categoryParam varchar(50) null,
	findInParam varchar(50) null,
	fromDateParam  DateTime null,
	toDateParam DateTime null,
	sortByParam varchar(100) null,
	nullableParam varchar(100) null default 'none',
	mediaLimit int not NULL,
	limitType varchar(50) null,
	isMediaActive bit default 1
);
go 
CREATE TABLE [dbo].[NLog_Error](  
	[Id] [int] IDENTITY(1, 1) NOT NULL,  
	[TimeStamp][DateTime2] NOT NULL,  
	[Level] [nvarchar](50) NOT NULL,  
	[Host] [nvarchar](max) NOT NULL,  
	[Type] [nvarchar](50) NOT NULL,  
	[Logger] [nvarchar](50) NOT NULL,  
	[Message] [nvarchar](max) NOT NULL,  
	[stacktrace] [nvarchar](max) NOT NULL,  
	[isResolved][bit] default 0,
	CONSTRAINT [PK_NLogError] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (  
	PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,  
	IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,  
	ALLOW_PAGE_LOCKS = ON  
) ON [PRIMARY]  
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
go
/*SP*/
create proc SP_AddUpdateMedia(
	@ID varchar (100),
	@Media varchar (100),
	@User varchar(50),
	@EndpointUrl ntext,
	@Key ntext,
	@Keywords varchar(50),
	@Language varchar(50),
	@Country varchar(50),
	@Category varchar(50) = null,
	@FindIn varchar(50) = null,
	@FromDate  DateTime,
	@ToDate DateTime,
	@SortBy varchar(100) = null,
	@IsNullable varchar(100) = null,
	@Limit int,
	@Type varchar(50) = null,
	@option int--1: insert,2-update
)
as
begin
	declare @status int;
	set @status = 0;
	if @option = 1 
		if(select count(mediaId) from MediaMaster where accountHolder = @User) = 0  
			begin
				insert into MediaMaster (accountHolder,
							[mediaName],
							mediaEndpointUrl,
							mediaKey,
							keywordParam,
	                        languageParam,
							countryParam,
							categoryParam,
							findInParam,
							fromDateParam,
							toDateParam,
							sortByParam,
							nullableParam,
							mediaLimit,
							limitType) 
				values(@User,
					@Media,
					@EndpointUrl,
					@Key,
					@Keywords,
					@Language,
					@Country,
					@Category,
					@FindIn,
					@FromDate,
					@ToDate,
					@SortBy,
					@IsNullable,
					@Limit,
					@Type);
				set @status = 1;
			end
	else if @option = 2
		begin
			update MediaMaster set mediaKey = @Key where mediaId = @ID;
			set @status = 2;
		end
	else 
		begin 
			set @status = -1; 
		end	
end
go
create proc SP_BlockMedia(@Id varchar(100))
as 
begin
	update MediaMaster set isMediaActive = 0 where mediaId = @Id;
end
go
create proc SP_GetMedia(
@All bit
)
as 
begin
	select mediaId as 'ID',
		   [mediaName] as 'Media',
	 	   accountHolder as 'User',
		   mediaEndpointUrl as 'API',
		   mediaKey as 'Key',
		   keywordParam as 'Keywords',
		   languageParam as 'Language',
		   countryParam as 'Country',
		   categoryParam as 'Category',
		   findInParam as 'FindIn',
		   fromDateParam as 'FromDate',
		   toDateParam as 'ToDate',
		   sortByParam as 'SortBy',
		   nullableParam as 'IsEmpty',
		   mediaLimit as 'Max',
		   limitType as 'Type',
		   isMediaActive as 'Status'
	from MediaMaster
	where 
		isMediaActive = @All
	order by 
		[mediaName] asc;
end
go
create proc SP_GetLogs
as 
begin
	select Id as 'ID',
		   TimeStamp as 'OccurredOn',
	 	   Level as 'Severity',
		   Host as 'Domain',
		   Type as 'Category',
		   Logger as 'Log',
		   Message as 'Message',
		   stacktrace as 'Trace',
		   isResolved as 'Status'
	from NLog_Error
	order by 
		TimeStamp desc;
end
go