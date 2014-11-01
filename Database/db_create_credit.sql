/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     26/10/2014 20:14:21                          */
/*==============================================================*/


/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            int                  identity,
   CLIENT_TYPE          char(1)              not null,
   CLIENT_EGN_BULSTAT   nvarchar(13)         not null,
   CLIENT_FULLNAME      nvarchar(400)        not null,
   EMAIL                nvarchar(400)        null,
   TELEPHONE            nvarchar(400)        null,
   ADRESS_TEXT          nvarchar(400)        not null,
   CLIENT_NOTE          nvarchar(400)        null,
   MODIF_DATE           datetime             null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Index: IDX_CLIENT_EGN_BULSTAT_UQ                             */
/*==============================================================*/
create unique index IDX_CLIENT_EGN_BULSTAT_UQ on CLIENT (
CLIENT_TYPE ASC,
CLIENT_EGN_BULSTAT ASC
)
go

/*==============================================================*/
/* Table: CREDIT                                                */
/*==============================================================*/
create table CREDIT (
   CREDIT_ID            int                  identity,
   CREDIT_NO            nvarchar(50)         not null,
   CREDIT_DATE          datetime             not null,
   CREDIT_PERIOD        int                  not null,
   CREDIT_END_DATE      datetime             not null,
   CREDIT_BEGIN_DATE    datetime             not null,
   CLIENT_ID            int                  not null,
   PROD_CODE            int                  null,
   CREDIT_SUM           numeric(10,2)        not null,
   CREDIT_NOTE          nvarchar(400)        null,
   MODIF_DATE           datetime             null,
   constraint PK_CREDIT primary key (CREDIT_ID)
)
go

/*==============================================================*/
/* Index: IDX_CREDIT_NO_UQ                                      */
/*==============================================================*/
create unique index IDX_CREDIT_NO_UQ on CREDIT (
CREDIT_NO ASC
)
go

/*==============================================================*/
/* Table: CREDIT_PLAN                                           */
/*==============================================================*/
create table CREDIT_PLAN (
   MATURITY_ID          int                  identity,
   CREDIT_ID            int                  null,
   MATURITY_DATE        datetime             not null,
   MATURITY_SUM         numeric(15,2)        not null,
   MATURITY_NOTE        nvarchar(400)        not null,
   MODIF_DATE           datetime             null,
   constraint PK_CREDIT_PLAN primary key (MATURITY_ID)
)
go

/*==============================================================*/
/* Index: IDX_MATURITY_UQ                                       */
/*==============================================================*/
create unique index IDX_MATURITY_UQ on CREDIT_PLAN (
MATURITY_DATE ASC
)
go

/*==============================================================*/
/* Table: CREDIT_PRODUCT                                        */
/*==============================================================*/
create table CREDIT_PRODUCT (
   PROD_CODE            int                  identity,
   PROD_NAME            nvarchar(100)        not null,
   PROD_ACTIVE          char(1)              not null default 'N'
      constraint CKC_PROD_ACTIVE_CREDIT_P check (PROD_ACTIVE in ('Y','N')),
   PROD_SUM_FROM        numeric(10,2)        not null
      constraint CKC_PROD_SUM_FROM_CREDIT_P check (PROD_SUM_FROM >= 0),
   PROD_SUM_TO          numeric(10,2)        not null,
   MODIF_DATE           datetime             null,
   constraint PK_CREDIT_PRODUCT primary key (PROD_CODE)
)
go

/*==============================================================*/
/* Index: IDX_PROD_NAME_UQ                                      */
/*==============================================================*/
create unique index IDX_PROD_NAME_UQ on CREDIT_PRODUCT (
PROD_NAME ASC
)
go

/*==============================================================*/
/* Table: INTEREST                                              */
/*==============================================================*/
create table INTEREST (
   PROD_CODE            int                  not null,
   PROD_PERIOD          int                  not null,
   SUM_FROM             numeric(10,2)        not null,
   SUM_TO               numeric(10,2)        not null,
   constraint PK_INTEREST primary key (PROD_CODE, PROD_PERIOD, SUM_FROM, SUM_TO)
)
go

/*==============================================================*/
/* Table: PROD_PERIODS                                          */
/*==============================================================*/
create table PROD_PERIODS (
   PROD_CODE            int                  not null,
   PROD_PERIOD          int                  not null,
   constraint PK_PROD_PERIODS primary key (PROD_CODE, PROD_PERIOD)
)
go

alter table CREDIT
   add constraint FK_CREDIT_REFERENCE_CREDIT_P foreign key (PROD_CODE)
      references CREDIT_PRODUCT (PROD_CODE)
go

alter table CREDIT
   add constraint FK_CREDIT_REFERENCE_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go


alter table CREDIT_PLAN
   add constraint FK_CREDIT_P_REFERENCE_CREDIT foreign key (CREDIT_ID)
      references CREDIT (CREDIT_ID)
go

alter table INTEREST
   add constraint FK_INTEREST_REFERENCE_PROD_PER foreign key (PROD_CODE, PROD_PERIOD)
      references PROD_PERIODS (PROD_CODE, PROD_PERIOD)
         on delete cascade
go

alter table PROD_PERIODS
   add constraint FK_PROD_PER_REFERENCE_CREDIT_P foreign key (PROD_CODE)
      references CREDIT_PRODUCT (PROD_CODE)
         on delete cascade
go



