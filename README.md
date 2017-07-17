# 3-Tier-Architecture-using-dapper

using StackExchange/dapper-dot-net to develop 3-Tier Architecture. Just a simple example in study.

A simple 3-tier architecture using the Dapper relational object mapper.

- Dapper：a simple object mapper for .Net developed by Stackexchange.

- Dapper-Extensions:Dapper Extensions is a small library that complements Dapper by adding basic CRUD operations (Get, Insert, Update, Delete) for your POCOs. 

## UI layer：
Dapper.Console：A simple console program act as UI layer.

## Business logic layer：
- Dapper.IBLL：BLL's abstract interface.
- Dapper.BLL：BLL's implementation。（call different DAL layers depending on the configuration file）

## Data access layer：
- Dapper.IDAL：DAL's abstract interface.
- Dapper.SQLServerDAL：Implementation of different databases，derived from IDAL interface.

## Entity ：
Dapper.Model：database model.

## Decoupling :
Dapper.Factory：factory.Create a corresponding instance from the factory。DALFactory create concrete DAL.

## Unit test：
Dapper.Test：Perform a unit test for the database. Unit test project can not directly read Dapper.Console *App.config*. Copy it over.
Need to Mock test, you can refer to the use of MS Fakes, Moq and other test framework.
