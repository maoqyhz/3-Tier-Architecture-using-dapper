#3-Tier-Architecture-using-dapper

using StackExchange/dapper-dot-net to develop 3-Tier Architecture. Just a simple example in study.

利用Dapper关系对象映射器写的简单的三层架构。

Dapper：StackOverFlow在使用的一个微型的ORM，框架整体效率较高，轻量级的ORM框架。网上有较多的扩展。此处只是简单的调用Dapper中的方法。

Dapper-Extensions:基于dapper扩展的CRUD的操作类库，使用一些简单的CRUD操作时可是直接使用该类库。

##UI层：
Dapper.Console：一个简单的控制台程序。

##BLL业务逻辑层：
Dapper.IBLL：业务逻辑层的抽象接口。
Dapper.BLL：业务逻辑层的具体实现。（会根据配置文件的不同调用不同的DAL层）

##DAL数据访问层：
Dapper.IDAL：数据访问层的抽象接口。利于程序的扩展。
Dapper.SQLServerDAL：不同数据库的实现层，派生自IDAL接口。（可能还有OracleDAL、MySQLDAL等等）

##实体类：
Dapper.Model：数据库实体类

##解耦:
Dapper.Factory：工厂。通过工厂来创建对应的实例。DALFactory创建具体的DAL，ConnectionFactory创建供Dapper使用的IDBConnection实例。

##单元测试：
Dapper.Test：进行数据库的单元测试。单元测试项目中无法直接读取Dapper.Console下的App.config。复制过来即可。
			需要Mock测试的，可以参考使用MS Fakes、Moq等测试框架。