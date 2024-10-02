Enable-Migrations: Enables the migration in your project by creating a Configuration class.

--crear la carpeta migration con los mapeos
Add-Migration nombre_cualquiera: Creates a new migration class as per specified name with the Up() and Down() methods.

--llevar los cambios de migration a la BD
Update-Database: Executes the last migration file created by the Add-Migration command and applies changes to the database schema.




 migrationBuilder.Sql(@"
                        INSERT INTO [dbo].[departamento]([dpto_nro],[Nombre])VALUES(10,'RRHH')
                        INSERT INTO [dbo].[departamento]([dpto_nro],[Nombre])VALUES(22,'SISTEMAS')
                        GO
                        INSERT INTO [dbo].[empleado]
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES
                            ('20123456','Emiliano Martinez','Calle 1','20000101',150000,1)
                        GO
                        INSERT INTO [dbo].[empleado]
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES
                            ('25222333','Lionel Messi','Miami','20050502',200000,2)
                        GO");

migrationBuilder.Sql(@" truncate table  empleado  ;
                    delete from departamento  ;
                    DBCC CHECKIDENT (departamento , RESEED, 0);    ");