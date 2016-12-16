--Insert de Competencias

--INSERT INTO Competencia VALUES (@codigo, @nombre, @descripcion, 'Activo', NULL, NULL);

--Insert de Pregunta

--INSERT INTO Factor VALUES (@nombre, NULL, 'Activo', @orden, @codigo_competencia, NULL, NULL);

--INSERT INTO OpcionRespuesta VALUES (@nombre, NULL, NULL, NULL);

--INSERT INTO Respuesta VALUES (@nombre, @orden, @id_opcion_respuesta);

--INSERT INTO ValorRespuesta VALUES (@ponderacion, @id_pregunta, @id_respuesta);

--INSERT INTO Pregunta VALUES (@descripcion, @pregunta, @nombre, @codigo_factor, NULL, NULL, @codigo_competencia);

--Insert de Candidato

--Si tiene email y fecha de nacimiento

--INSERT INTO Candidato VALUES (@idCandidato, @nroDto, @tipoDto, NULL, @apellido, @nombre, @genero, @nacionalidad, @fecha_nacimiento, @email, @escolaridad, NULL, NULL);

--Si no tiene email y fecha de nacimiento

--INSERT INTO Candidato VALUES (@idCandidato, @nroDto, @tipoDto, NULL, @apellido, @nombre, @genero, @nacionalidad, NULL, NULL, @escolaridad, NULL, NULL);