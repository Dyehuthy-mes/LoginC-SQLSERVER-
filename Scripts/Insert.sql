USE Usuarios;
IF OBJECT_ID(N'Usuarios', N'U') IS NULL 
BEGIN 
    CREATE TABLE Usuarios (
        UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
        NombreUsuario NVARCHAR(50) NOT NULL,
        Contraseña NVARCHAR(100) NOT NULL,
        Mail       NVARCHAR(50) NOT NULL,
        Telefono   NVARCHAR(50) NOT NULL,
        Direccion  NVARCHAR(50) NOT NULL
    );

    INSERT INTO Usuarios(NombreUsuario,Contraseña,Mail,Telefono,Direccion) 
    VALUES ('TestUser','$2y$10$Lh59lVBVQ8sqje9sbN6Sh.XvFkexDy86GzCyS7XDDg6GukcSh5rr2','mailto@developer.com','1159403485','Evergreen 848');
END;