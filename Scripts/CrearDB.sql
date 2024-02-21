IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Usuarios')
BEGIN
  CREATE DATABASE Usuarios;
END;
