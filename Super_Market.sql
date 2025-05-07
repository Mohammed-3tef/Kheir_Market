/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/7/2025 3:14:22 PM                          */
/*==============================================================*/

CREATE DATABASE Super_Market;
USE Super_Market;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPANY') and o.name = 'FK_COMPANY_INCLUDES_CATEGORY')
alter table COMPANY
   drop constraint FK_COMPANY_INCLUDES_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEPARTMENT') and o.name = 'FK_DEPARTME_PART_OF_CATEGORY')
alter table DEPARTMENT
   drop constraint FK_DEPARTME_PART_OF_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"ORDER"') and o.name = 'FK_ORDER_PLACES_USER')
alter table "ORDER"
   drop constraint FK_ORDER_PLACES_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ORDER_DETAILS') and o.name = 'FK_ORDER_DE_CONTAIN_ORDER')
alter table ORDER_DETAILS
   drop constraint FK_ORDER_DE_CONTAIN_ORDER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ORDER_DETAILS') and o.name = 'FK_ORDER_DE_INCLUDE_PRODUCT')
alter table ORDER_DETAILS
   drop constraint FK_ORDER_DE_INCLUDE_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_CONTAINS_STOCK')
alter table PRODUCT
   drop constraint FK_PRODUCT_CONTAINS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_INCLUDE_T_DEPARTME')
alter table PRODUCT
   drop constraint FK_PRODUCT_INCLUDE_T_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_PRODUCE_COMPANY')
alter table PRODUCT
   drop constraint FK_PRODUCT_PRODUCE_COMPANY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('COMPANY')
            and   name  = 'INCLUDES_FK'
            and   indid > 0
            and   indid < 255)
   drop index COMPANY.INCLUDES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPANY')
            and   type = 'U')
   drop table COMPANY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEPARTMENT')
            and   name  = 'PART_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEPARTMENT.PART_OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTMENT')
            and   type = 'U')
   drop table DEPARTMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"ORDER"')
            and   name  = 'PLACES_FK'
            and   indid > 0
            and   indid < 255)
   drop index "ORDER".PLACES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"ORDER"')
            and   type = 'U')
   drop table "ORDER"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDER_DETAILS')
            and   name  = 'INCLUDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDER_DETAILS.INCLUDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ORDER_DETAILS')
            and   name  = 'CONTAIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ORDER_DETAILS.CONTAIN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ORDER_DETAILS')
            and   type = 'U')
   drop table ORDER_DETAILS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'INCLUDE_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.INCLUDE_TO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'PRODUCE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.PRODUCE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'CONTAINS_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.CONTAINS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT')
            and   type = 'U')
   drop table PRODUCT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STOCK')
            and   type = 'U')
   drop table STOCK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CID                  int                  not null,
   NAME                 varchar(100)         not null,
   constraint PK_CATEGORY primary key nonclustered (CID)
)
go

/*==============================================================*/
/* Table: COMPANY                                               */
/*==============================================================*/
create table COMPANY (
   COMPID               int                  not null,
   CID                  int                  not null,
   CATE_ID              int                  not null,
   NAME                 varchar(100)         not null,
   COUNTRY              varchar(100)         null,
   constraint PK_COMPANY primary key nonclustered (COMPID)
)
go

/*==============================================================*/
/* Index: INCLUDES_FK                                           */
/*==============================================================*/
create index INCLUDES_FK on COMPANY (
CID ASC
)
go

/*==============================================================*/
/* Table: DEPARTMENT                                            */
/*==============================================================*/
create table DEPARTMENT (
   DID                  int                  not null,
   CID                  int                  not null,
   NAME                 varchar(100)         not null,
   constraint PK_DEPARTMENT primary key nonclustered (DID)
)
go

/*==============================================================*/
/* Index: PART_OF_FK                                            */
/*==============================================================*/
create index PART_OF_FK on DEPARTMENT (
CID ASC
)
go

/*==============================================================*/
/* Table: "ORDER"                                               */
/*==============================================================*/
create table "ORDER" (
   OID                  int                  not null,
   UID                  int                  not null,
   TOTAL_PRICE          decimal              not null,
   ORDER_DATE           datetime             not null,
   constraint PK_ORDER primary key nonclustered (OID)
)
go

/*==============================================================*/
/* Index: PLACES_FK                                             */
/*==============================================================*/
create index PLACES_FK on "ORDER" (
UID ASC
)
go

/*==============================================================*/
/* Table: ORDER_DETAILS                                         */
/*==============================================================*/
create table ORDER_DETAILS (
   OID                  int                  not null,
   PID                  int                  not null,
   ORDER_ID             int                  not null,
   QUANTITY             int                  not null,
   constraint AK_ORDER_ID_ORDER_DE unique (ORDER_ID)
)
go

/*==============================================================*/
/* Index: CONTAIN_FK                                            */
/*==============================================================*/
create index CONTAIN_FK on ORDER_DETAILS (
OID ASC
)
go

/*==============================================================*/
/* Index: INCLUDE_FK                                            */
/*==============================================================*/
create index INCLUDE_FK on ORDER_DETAILS (
PID ASC
)
go

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT (
   PID                  int                  not null,
   DID                  int                  not null,
   SID                  int                  not null,
   COMPID               int                  not null,
   NAME                 varchar(100)         not null,
   PRICE                decimal              not null,
   constraint PK_PRODUCT primary key nonclustered (PID)
)
go

/*==============================================================*/
/* Index: CONTAINS_FK                                           */
/*==============================================================*/
create index CONTAINS_FK on PRODUCT (
SID ASC
)
go

/*==============================================================*/
/* Index: PRODUCE_FK                                            */
/*==============================================================*/
create index PRODUCE_FK on PRODUCT (
COMPID ASC
)
go

/*==============================================================*/
/* Index: INCLUDE_TO_FK                                         */
/*==============================================================*/
create index INCLUDE_TO_FK on PRODUCT (
DID ASC
)
go

/*==============================================================*/
/* Table: STOCK                                                 */
/*==============================================================*/
create table STOCK (
   SID                  int                  not null,
   PRODUCT_QUANTITY     decimal              not null,
   constraint PK_STOCK primary key nonclustered (SID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   UID                  int                  not null,
   NAME                 varchar(100)         not null,
   EMAIL                char(100)            not null,
   PHONE                varchar(15)          not null,
   ADDRESS              varchar(255)         not null,
   IS_ADMIN             bit                  not null,
   PASSWORD             varchar(50)          not null,
   constraint PK_USER primary key nonclustered (UID)
)
go

alter table COMPANY
   add constraint FK_COMPANY_INCLUDES_CATEGORY foreign key (CID)
      references CATEGORY (CID)
go

alter table DEPARTMENT
   add constraint FK_DEPARTME_PART_OF_CATEGORY foreign key (CID)
      references CATEGORY (CID)
go

alter table "ORDER"
   add constraint FK_ORDER_PLACES_USER foreign key (UID)
      references "USER" (UID)
go

alter table ORDER_DETAILS
   add constraint FK_ORDER_DE_CONTAIN_ORDER foreign key (OID)
      references "ORDER" (OID)
go

alter table ORDER_DETAILS
   add constraint FK_ORDER_DE_INCLUDE_PRODUCT foreign key (PID)
      references PRODUCT (PID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_CONTAINS_STOCK foreign key (SID)
      references STOCK (SID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_INCLUDE_T_DEPARTME foreign key (DID)
      references DEPARTMENT (DID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_PRODUCE_COMPANY foreign key (COMPID)
      references COMPANY (COMPID)
go
