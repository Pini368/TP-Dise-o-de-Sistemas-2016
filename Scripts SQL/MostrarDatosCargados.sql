SELECT id_competencia AS Código, nombre AS Nombre, descripcion AS Descripción FROM Competencia;

SELECT F.codigo_factor AS Código, F.nombre AS Nombre, F.descripcion AS Descripción, C.nombre AS Competencia FROM Factor F INNER JOIN Competencia C ON F.codigo_competencia = C.id_competencia;

SELECT C.nombre AS Competencia, F.nombre AS Factor, P.nombre AS Nombre, P.interrogante AS Pregunta, P.descripcion AS Descripción, OPR.nombre, R.nombre, VR.ponderacion FROM Pregunta P INNER JOIN Factor F ON P.codigo_factor = F.codigo_factor INNER JOIN ValorRespuesta VR ON VR.id_pregunta = P.id_pregunta INNER JOIN Respuesta R ON VR.id_respuesta = R.id_respuesta INNER JOIN OpcionRespuesta OPR ON R.id_opcion_respuesta = OPR.id_opcion_respuesta INNER JOIN Competencia C ON F.codigo_competencia = C.id_competencia;

SELECT OPR.nombre AS Nombre, OPR.descripcion AS Descripción, R.orden AS Orden, R.nombre AS Descripción FROM OpcionRespuesta OPR INNER JOIN Respuesta R ON OPR.id_opcion_respuesta = R.id_opcion_respuesta;

SELECT nroCandidato AS Candidato, apellido AS Apellido, nombre AS Nombre, nro_documento AS 'Nro de Documento', tipo_documento AS TIPO, fecha_nacimiento AS 'Fecha Nac.', genero AS Genero, nacionalidad AS Nacionalidad, IIF(email IS NULL, '', email) AS Email, IIF(escolaridad = 1, 'PRIMARIO', IIF(escolaridad = 2, 'SECUNDARIO', IIF(escolaridad = 3, 'UNIVERSITARIO', 'SIN ESCOLARIDAD'))) AS Escolaridad, IIF(id_consultor IS NULL, 'NO', 'SI') AS Eliminado FROM Candidato;