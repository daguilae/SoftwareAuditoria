-- -----------------------------------------------------
-- Schema SoftwareAuditoria
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `SoftwareAuditoria`;

-- -----------------------------------------------------
-- Schema SoftwareAuditoria
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SoftwareAuditoria`;
USE `SoftwareAuditoria`;


--
-- Table structure for table `marcotrabajo`
--

DROP TABLE IF EXISTS `marcotrabajo`;
CREATE TABLE `marcotrabajo` (
  `ID_MarcoTrabajo` int NOT NULL,
  `Nombre_MarcoTrabajo` varchar(20) DEFAULT NULL,
  `Descripcion_MarcoTrabajo` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_MarcoTrabajo`)
);

--
-- Dumping data for table `marcotrabajo`
--

INSERT INTO `marcotrabajo` VALUES (1,'COBIT','marco de trabajo ',1);


--
-- Table structure for table `tiposprocesos`
--

DROP TABLE IF EXISTS `tiposprocesos`;
CREATE TABLE `tiposprocesos` (
  `ID_TipoObjetivo` int NOT NULL,
  `Nombre_TipoObjetivo` varchar(20) DEFAULT NULL,
  `Descripcion_TipoObjetivo` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_TipoObjetivo`)
);

--
-- Dumping data for table `tiposprocesos`
--

INSERT INTO `tiposprocesos` VALUES (1,'Entrega','Entrega y dar soporte',1);


--
-- Table structure for table `procesos`
--

DROP TABLE IF EXISTS `procesos`;
CREATE TABLE `procesos` (
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `ID_TipoObjetivo` int NOT NULL,
  `Nombre_Procesos` varchar(40) DEFAULT NULL,
  `Descripcion_Objetivo` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Procesos`,`ID_MarcoTrabajo`),
  KEY `fk_Procesos_MarcoTeorico` (`ID_MarcoTrabajo`),
  KEY `fk_Procesos_TiposProcesos1` (`ID_TipoObjetivo`),
  CONSTRAINT `fk_Procesos_MarcoTeorico` FOREIGN KEY (`ID_MarcoTrabajo`) REFERENCES `marcotrabajo` (`ID_MarcoTrabajo`),
  CONSTRAINT `fk_Procesos_TiposProcesos1` FOREIGN KEY (`ID_TipoObjetivo`) REFERENCES `tiposprocesos` (`ID_TipoObjetivo`)
);

--
-- Dumping data for table `procesos`
--

INSERT INTO `procesos` VALUES (1,1,1,'Entrega y dar Soporte','Descripcion ',1);


--
-- Table structure for table `objetivos`
--

DROP TABLE IF EXISTS `objetivos`;
CREATE TABLE `objetivos` (
  `ID_Actividad` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `Nombre_Actividad` varchar(20) DEFAULT NULL,
  `Descripcion_Actividad` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Actividad`,`ID_Procesos`,`ID_MarcoTrabajo`),
  KEY `fk_Objetivos_Procesos1` (`ID_Procesos`,`ID_MarcoTrabajo`),
  CONSTRAINT `fk_Objetivos_Procesos1` FOREIGN KEY (`ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `procesos` (`ID_Procesos`, `ID_MarcoTrabajo`)
);

--
-- Dumping data for table `objetivos`
--

INSERT INTO `objetivos` VALUES (1,1,1,'Versionado','Versionado de software',1);


--
-- Table structure for table `tareas`
--

DROP TABLE IF EXISTS `tareas`;
CREATE TABLE `tareas` (
  `ID_Tarea` int NOT NULL,
  `ID_Actividad` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `Nombre_Tarea` varchar(20) DEFAULT NULL,
  `Descripcion_Tarea` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Tarea`,`ID_Actividad`,`ID_Procesos`,`ID_MarcoTrabajo`),
  KEY `fk_Tareas_Objetivos1` (`ID_Actividad`,`ID_Procesos`,`ID_MarcoTrabajo`),
  CONSTRAINT `fk_Tareas_Objetivos1` FOREIGN KEY (`ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `objetivos` (`ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`)
) ;


--
-- Table structure for table `tiporecursos`
--

DROP TABLE IF EXISTS `tiporecursos`;
CREATE TABLE `tiporecursos` (
  `ID_TipoRecurso` int NOT NULL,
  `Nombre_TipoRecurso` varchar(20) DEFAULT NULL,
  `Descripcion_TipoRecurso` varchar(20) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_TipoRecurso`)
);

--
-- Dumping data for table `tiporecursos`
--

INSERT INTO `tiporecursos` VALUES (1,'Recurso Externo','Recurso externo',1);


--
-- Table structure for table `recursos`
--

DROP TABLE IF EXISTS `recursos`;
CREATE TABLE `recursos` (
  `ID_Recurso` int NOT NULL,
  `ID_TipoRecurso` int NOT NULL,
  `Nombre_Recurso` varchar(20) DEFAULT NULL,
  `Descripcion_Recurso` varchar(20) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Recurso`),
  KEY `fk_Recursos_TipoRecursos1` (`ID_TipoRecurso`),
  CONSTRAINT `fk_Recursos_TipoRecursos1` FOREIGN KEY (`ID_TipoRecurso`) REFERENCES `tiporecursos` (`ID_TipoRecurso`)
);

--
-- Dumping data for table `recursos`
--

INSERT INTO `recursos` VALUES (1,1,'Asesor de IT','Asesor',1);


--
-- Table structure for table `procesos_has_recursos`
--

DROP TABLE IF EXISTS `procesos_has_recursos`;
CREATE TABLE `procesos_has_recursos` (
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `ID_Recurso` int NOT NULL,
  PRIMARY KEY (`ID_Procesos`,`ID_MarcoTrabajo`,`ID_Recurso`),
  KEY `fk_Procesos_has_Recursos_Recursos1` (`ID_Recurso`),
  CONSTRAINT `fk_Procesos_has_Recursos_Procesos1` FOREIGN KEY (`ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `procesos` (`ID_Procesos`, `ID_MarcoTrabajo`),
  CONSTRAINT `fk_Procesos_has_Recursos_Recursos1` FOREIGN KEY (`ID_Recurso`) REFERENCES `recursos` (`ID_Recurso`)
) ;


--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;

CREATE TABLE `empresa` (
  `ID_EMpresa` int NOT NULL,
  `Nombre_Empresa` varchar(20) DEFAULT NULL,
  `Direccion_Empresa` varchar(20) DEFAULT NULL,
  `Telefono_Empresa` varchar(15) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_EMpresa`)
);

--
-- Dumping data for table `empresa`
--

INSERT INTO `empresa` VALUES (1,'PSA','zona 2','23654789',1);



--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;

CREATE TABLE `departamento` (
  `ID_Departamento` int NOT NULL,
  `ID_Empresa` int NOT NULL,
  `Nombre_Departamento` varchar(20) DEFAULT NULL,
  `Descripcion_Departamento` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Departamento`,`ID_Empresa`),
  KEY `fk_Departamento_Empresa1` (`ID_Empresa`),
  CONSTRAINT `fk_Departamento_Empresa1` FOREIGN KEY (`ID_Empresa`) REFERENCES `empresa` (`ID_EMpresa`)
);

--
-- Dumping data for table `departamento`
--

INSERT INTO `departamento` VALUES (1,1,'IT','depro de IT',1);


--
-- Table structure for table `proyecto`
--

DROP TABLE IF EXISTS `proyecto`;
CREATE TABLE `proyecto` (
  `ID_Proyecto` int NOT NULL,
  `ID_Departamento` int NOT NULL,
  `ID_Empresa` int NOT NULL,
  `Nombre_Proyecto` varchar(20) DEFAULT NULL,
  `Descripcion_Proyecto` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Proyecto`,`ID_Departamento`,`ID_Empresa`),
  KEY `fk_Proyecto_Departamento1` (`ID_Departamento`,`ID_Empresa`),
  CONSTRAINT `fk_Proyecto_Departamento1` FOREIGN KEY (`ID_Departamento`, `ID_Empresa`) REFERENCES `departamento` (`ID_Departamento`, `ID_Empresa`)
) ;


--
-- Table structure for table `cronograma_encabezado`
--

DROP TABLE IF EXISTS `cronograma_encabezado`;

CREATE TABLE `cronograma_encabezado` (
  `ID_Cronograma` int NOT NULL,
  `ID_Proyecto` int NOT NULL,
  `FechaInicial_Cronograma` date DEFAULT NULL,
  `FechaFinal_Cronograma` date DEFAULT NULL,
  PRIMARY KEY (`ID_Cronograma`),
  KEY `fk_Cronograma_Proyecto1` (`ID_Proyecto`),
  CONSTRAINT `fk_Cronograma_Proyecto1` FOREIGN KEY (`ID_Proyecto`) REFERENCES `proyecto` (`ID_Proyecto`)
);


--
-- Table structure for table `auditores`
--

DROP TABLE IF EXISTS `auditores`;

CREATE TABLE `auditores` (
  `ID_Auditor` int NOT NULL,
  `Nombre_Auditor` varchar(20) DEFAULT NULL,
  `Apellidos_Auditor` varchar(20) DEFAULT NULL,
  `Telefono_Auditor` varchar(20) DEFAULT NULL,
  `Correo_Auditor` varchar(20) DEFAULT NULL,
  `Nit_Auditor` varchar(7) DEFAULT NULL,
  `DPI_Auditor` varchar(13) DEFAULT NULL,
  `Sexo_Auditor` varchar(20) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Auditor`)
);

--
-- Dumping data for table `auditores`
--

INSERT INTO `auditores` VALUES (1,'Ilse','Penia','45654823','ilse@gmail.com','4669875','789652348956','F',1);


--
-- Table structure for table `tipoalerta`
--

DROP TABLE IF EXISTS `tipoalerta`;
CREATE TABLE `tipoalerta` (
  `ID_TipoAlerta` int NOT NULL,
  `Nombre_TipoAlerta` varchar(20) DEFAULT NULL,
  `Descripcion_TipoAlerta` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  `ID_Auditor` int NOT NULL,
  PRIMARY KEY (`ID_TipoAlerta`),
  KEY `fk_TipoAlerta_Auditores1` (`ID_Auditor`),
  CONSTRAINT `fk_TipoAlerta_Auditores1` FOREIGN KEY (`ID_Auditor`) REFERENCES `auditores` (`ID_Auditor`)
) ;


--
-- Table structure for table `alertas`
--

DROP TABLE IF EXISTS `alertas`;

CREATE TABLE `alertas` (
  `ID_Alertas` int NOT NULL,
  `ID_Proyecto` int NOT NULL,
  `Fecha_Alerta` datetime DEFAULT NULL,
  `TipoAlerta_ID_TipoAlerta` int NOT NULL,
  `Descripcion_Alerta` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Alertas`),
  KEY `fk_Alertas_Proyecto1` (`ID_Proyecto`),
  KEY `fk_Alertas_TipoAlerta1` (`TipoAlerta_ID_TipoAlerta`),
  CONSTRAINT `fk_Alertas_Proyecto1` FOREIGN KEY (`ID_Proyecto`) REFERENCES `proyecto` (`ID_Proyecto`),
  CONSTRAINT `fk_Alertas_TipoAlerta1` FOREIGN KEY (`TipoAlerta_ID_TipoAlerta`) REFERENCES `tipoalerta` (`ID_TipoAlerta`)
);


--
-- Table structure for table `evaluacion_encabezado`
--

DROP TABLE IF EXISTS `evaluacion_encabezado`;
CREATE TABLE `evaluacion_encabezado` (
  `ID_Evaluacion_Encabezado` int NOT NULL AUTO_INCREMENT,
  `ID_Proyecto` int NOT NULL,
  `Fecha_Evaluacion` date DEFAULT NULL,
  `ObjetivoNegocio` varchar(100) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Evaluacion_Encabezado`),
  KEY `fk_Evaluaciones_Proyecto1` (`ID_Proyecto`),
  CONSTRAINT `fk_Evaluaciones_Proyecto1` FOREIGN KEY (`ID_Proyecto`) REFERENCES `proyecto` (`ID_Proyecto`)
);


--
-- Table structure for table `tipoevaluacion`
--

DROP TABLE IF EXISTS `tipoevaluacion`;
CREATE TABLE `tipoevaluacion` (
  `ID_TipoEvaluacion` int NOT NULL,
  `Nombre_TipoEvaluacion` varchar(20) DEFAULT NULL,
  `Descripcion_TipoEvaluacion` varchar(100) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_TipoEvaluacion`)
) ;


--
-- Dumping data for table `tipoevaluacion`
--

INSERT INTO `tipoevaluacion` VALUES (1,'Evaluacion','Tipo de Evaluacion',1);

--
-- Table structure for table `reportes_encabezado`
--

DROP TABLE IF EXISTS `reportes_encabezado`;
CREATE TABLE `reportes_encabezado` (
  `ID_Reportes_Encabezado` int NOT NULL AUTO_INCREMENT,
  `ID_Auditor` int NOT NULL,
  `FechaCreacion` date DEFAULT NULL,
  `Objetivo` varchar(100) DEFAULT NULL,
  `Alcance` varchar(100) DEFAULT NULL,
  `Escala` varchar(100) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Reportes_Encabezado`),
  KEY `fk_Auditor_Reportes_Encabezado` (`ID_Auditor`),
  CONSTRAINT `fk_Auditor_Reportes_Encabezado` FOREIGN KEY (`ID_Auditor`) REFERENCES `auditores` (`ID_Auditor`)
) ;


--
-- Table structure for table `reportes_detalle`
--

DROP TABLE IF EXISTS `reportes_detalle`;
CREATE TABLE `reportes_detalle` (
  `ID_Linea` int NOT NULL AUTO_INCREMENT,
  `ID_Reportes_Encabezado` int NOT NULL,
  `ID_Evaluacion_Encabezado` int NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Linea`,`ID_Reportes_Encabezado`),
  KEY `fk_Reportes_Detalle_Reportes_encabezado` (`ID_Reportes_Encabezado`),
  KEY `fk_Reportes_Detalle_Evaluacion_Encabezado` (`ID_Evaluacion_Encabezado`),
  CONSTRAINT `fk_Reportes_Detalle_Evaluacion_Encabezado` FOREIGN KEY (`ID_Evaluacion_Encabezado`) REFERENCES `evaluacion_encabezado` (`ID_Evaluacion_Encabezado`),
  CONSTRAINT `fk_Reportes_Detalle_Reportes_encabezado` FOREIGN KEY (`ID_Reportes_Encabezado`) REFERENCES `reportes_encabezado` (`ID_Reportes_Encabezado`)
) ;


--
-- Table structure for table `recursosparaevaluacion`
--

DROP TABLE IF EXISTS `recursosparaevaluacion`;
CREATE TABLE `recursosparaevaluacion` (
  `ID_Evaluacion_Encabezado` int NOT NULL,
  `ID_Recurso` int NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Evaluacion_Encabezado`,`ID_Recurso`),
  KEY `fk_Evaluaciones_has_Recursos_Recursos1` (`ID_Recurso`),
  CONSTRAINT `fk_Evaluaciones_has_Recursos_Evaluaciones1` FOREIGN KEY (`ID_Evaluacion_Encabezado`) REFERENCES `evaluacion_encabezado` (`ID_Evaluacion_Encabezado`),
  CONSTRAINT `fk_Evaluaciones_has_Recursos_Recursos1` FOREIGN KEY (`ID_Recurso`) REFERENCES `recursos` (`ID_Recurso`)
) ;


--
-- Table structure for table `proyecto_has_procesos`
--

DROP TABLE IF EXISTS `proyecto_has_procesos`;
CREATE TABLE `proyecto_has_procesos` (
  `ID_Proyecto` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  PRIMARY KEY (`ID_Proyecto`,`ID_Procesos`,`ID_MarcoTrabajo`),
  KEY `fk_Proyecto_has_Procesos_Procesos1` (`ID_Procesos`,`ID_MarcoTrabajo`),
  CONSTRAINT `fk_Proyecto_has_Procesos_Procesos1` FOREIGN KEY (`ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `procesos` (`ID_Procesos`, `ID_MarcoTrabajo`),
  CONSTRAINT `fk_Proyecto_has_Procesos_Proyecto1` FOREIGN KEY (`ID_Proyecto`) REFERENCES `proyecto` (`ID_Proyecto`)
) ;


--
-- Table structure for table `marcotrabajo_has_empresa`
--

DROP TABLE IF EXISTS `marcotrabajo_has_empresa`;
CREATE TABLE `marcotrabajo_has_empresa` (
  `ID_MarcoTrabajo` int NOT NULL,
  `ID_EMpresa` int NOT NULL,
  `fecha_marcoEmpresarialAsignado` date DEFAULT NULL,
  `Estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`ID_MarcoTrabajo`,`ID_EMpresa`),
  KEY `fk_MarcoTeorico_has_Empresa_Empresa1` (`ID_EMpresa`),
  CONSTRAINT `fk_MarcoTeorico_has_Empresa_Empresa1` FOREIGN KEY (`ID_EMpresa`) REFERENCES `empresa` (`ID_EMpresa`),
  CONSTRAINT `fk_MarcoTeorico_has_Empresa_MarcoTeorico1` FOREIGN KEY (`ID_MarcoTrabajo`) REFERENCES `marcotrabajo` (`ID_MarcoTrabajo`)
) ;


--
-- Table structure for table `instrumentos`
--

DROP TABLE IF EXISTS `instrumentos`;
CREATE TABLE `instrumentos` (
  `ID_Instrumentos` int NOT NULL,
  `Nombre_Instrumento` varchar(20) DEFAULT NULL,
  `Descripcion_Instrumento` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Instrumentos`)
);

--
-- Dumping data for table `instrumentos`
--

INSERT INTO `instrumentos` VALUES (1,'Rubrica 1','Rubrica sobre primera entrega',1);


--
-- Table structure for table `rubrica`
--

DROP TABLE IF EXISTS `rubrica`;
CREATE TABLE `rubrica` (
  `ID_Rubrica` int NOT NULL,
  `Nombre_Rubrica` varchar(20) DEFAULT NULL,
  `Descripcion100_Rubrica` varchar(80) DEFAULT NULL,
  `ID_Instrumentos` int NOT NULL,
  `Descripcion75_Rubrica` varchar(80) DEFAULT NULL,
  `Descripcion50_Rubrica` varchar(80) DEFAULT NULL,
  `Descripcion25_Rubrica` varchar(80) DEFAULT NULL,
  `Descripcion0_Rubrica` varchar(80) DEFAULT NULL,
  `Total_Rubrica` double DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Rubrica`),
  KEY `fk_rubrica_has_Instrumentos_rubrica1` (`ID_Instrumentos`),
  CONSTRAINT `fk_rubrica_has_Instrumentos_rubrica1` FOREIGN KEY (`ID_Instrumentos`) REFERENCES `instrumentos` (`ID_Instrumentos`)
) ;


--
-- Table structure for table `instrumentosparaevaluar`
--

DROP TABLE IF EXISTS `instrumentosparaevaluar`;
CREATE TABLE `instrumentosparaevaluar` (
  `ID_Evaluacion_Encabezado` int NOT NULL,
  `ID_Instrumentos` int NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Evaluacion_Encabezado`,`ID_Instrumentos`),
  KEY `fk_Evaluaciones_has_Instrumentos_Instrumentos1` (`ID_Instrumentos`),
  CONSTRAINT `fk_Evaluaciones_has_Instrumentos_Evaluaciones1` FOREIGN KEY (`ID_Evaluacion_Encabezado`) REFERENCES `evaluacion_encabezado` (`ID_Evaluacion_Encabezado`),
  CONSTRAINT `fk_Evaluaciones_has_Instrumentos_Instrumentos1` FOREIGN KEY (`ID_Instrumentos`) REFERENCES `instrumentos` (`ID_Instrumentos`)
);


--
-- Table structure for table `observaciones`
--

DROP TABLE IF EXISTS `observaciones`;
CREATE TABLE `observaciones` (
  `ID_Observaciones` int NOT NULL,
  `ID_Evaluacion_Encabezado` int NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_Observaciones`),
  KEY `fk_Observaciones_Evaluaciones1` (`ID_Evaluacion_Encabezado`),
  CONSTRAINT `fk_Observaciones_Evaluaciones1` FOREIGN KEY (`ID_Evaluacion_Encabezado`) REFERENCES `evaluacion_encabezado` (`ID_Evaluacion_Encabezado`)
);


--
-- Table structure for table `ayuda`
--

DROP TABLE IF EXISTS `ayuda`;

CREATE TABLE `ayuda` (
  `ID_Ayuda` int NOT NULL,
  `Nombre_Ayuda` varchar(20) DEFAULT NULL,
  `Ruta_Ayuda` varchar(100) DEFAULT NULL,
  `Pagina_Ayuda` varchar(100) DEFAULT NULL,
  `Estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_Ayuda`)
);



--
-- Dumping data for table `ayuda`
--

INSERT INTO `ayuda` VALUES (1,'Proyectos','Ruta','PAGINA','1'),(2,'Proyectos','Ruta','PAGINA','1'),(3,'Proyectos','Ruta','PAGINA','1'),(4,'Proyectos','Ruta','PAGINA','1'),(5,'Proyectos','Ruta','PAGINA','1'),(6,'Proyectos','Ruta','PAGINA','1'),(7,'Proyectos','Ruta','PAGINA','1'),(8,'Proyectos','Ruta','PAGINA','1'),(9,'Proyectos','Ruta','PAGINA','1'),(10,'Proyectos','Ruta','PAGINA','1'),(11,'Proyectos','Ruta','PAGINA','1'),(12,'Proyectos','Ruta','PAGINA','1'),(13,'Proyectos','Ruta','PAGINA','1'),(14,'Proyectos','Ruta','PAGINA','1'),(15,'Proyectos','Ruta','PAGINA','1'),(16,'Proyectos','Ruta','PAGINA','1');


--
-- Table structure for table `auditoresdeproyecto`
--

DROP TABLE IF EXISTS `auditoresdeproyecto`;

CREATE TABLE `auditoresdeproyecto` (
  `ID_Proyecto` int NOT NULL,
  `ID_Departamento` int NOT NULL,
  `ID_EMpresa` int NOT NULL,
  `ID_Auditor` int NOT NULL,
  PRIMARY KEY (`ID_Proyecto`,`ID_Departamento`,`ID_EMpresa`,`ID_Auditor`),
  KEY `fk_Proyecto_has_Auditores_Auditores1` (`ID_Auditor`),
  CONSTRAINT `fk_Proyecto_has_Auditores_Auditores1` FOREIGN KEY (`ID_Auditor`) REFERENCES `auditores` (`ID_Auditor`),
  CONSTRAINT `fk_Proyecto_has_Auditores_Proyecto1` FOREIGN KEY (`ID_Proyecto`, `ID_Departamento`, `ID_EMpresa`) REFERENCES `proyecto` (`ID_Proyecto`, `ID_Departamento`, `ID_Empresa`)
);


--
-- Table structure for table `cronograma_detalle`
--

DROP TABLE IF EXISTS `cronograma_detalle`;

CREATE TABLE `cronograma_detalle` (
  `ID_Tarea` int NOT NULL,
  `ID_Actividad` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `ID_Cronograma` int NOT NULL,
  `FechaInicio` date DEFAULT NULL,
  `FechaFin` date DEFAULT NULL,
  `Progreso_Tarea` int DEFAULT NULL,
  PRIMARY KEY (`ID_Tarea`,`ID_Actividad`,`ID_Procesos`,`ID_MarcoTrabajo`,`ID_Cronograma`),
  KEY `fk_Tareas_has_Cronograma_Cronograma1` (`ID_Cronograma`),
  CONSTRAINT `fk_Tareas_has_Cronograma_Cronograma1` FOREIGN KEY (`ID_Cronograma`) REFERENCES `cronograma_encabezado` (`ID_Cronograma`),
  CONSTRAINT `fk_Tareas_has_Cronograma_Tareas1` FOREIGN KEY (`ID_Tarea`, `ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `tareas` (`ID_Tarea`, `ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`)
);


--
-- Table structure for table `cronogramadeauditores`
--

DROP TABLE IF EXISTS `cronogramadeauditores`;

CREATE TABLE `cronogramadeauditores` (
  `ID_Tarea` int NOT NULL,
  `ID_Actividad` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `ID_Cronograma` int NOT NULL,
  `ID_Auditor` int NOT NULL,
  PRIMARY KEY (`ID_Tarea`,`ID_Actividad`,`ID_Procesos`,`ID_MarcoTrabajo`,`ID_Cronograma`,`ID_Auditor`),
  KEY `fk_Cronograma_Detalle_has_Auditores_Auditores1` (`ID_Auditor`),
  CONSTRAINT `fk_Cronograma_Detalle_has_Auditores_Auditores1` FOREIGN KEY (`ID_Auditor`) REFERENCES `auditores` (`ID_Auditor`),
  CONSTRAINT `fk_Cronograma_Detalle_has_Auditores_Cronograma_Detalle1` FOREIGN KEY (`ID_Tarea`, `ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`, `ID_Cronograma`) REFERENCES `cronograma_detalle` (`ID_Tarea`, `ID_Actividad`, `ID_Procesos`, `ID_MarcoTrabajo`, `ID_Cronograma`)
);


--
-- Table structure for table `contactos`
--

DROP TABLE IF EXISTS `contactos`;

CREATE TABLE `contactos` (
  `ID_Contacto` int NOT NULL,
  `Nombre_Contacto` varchar(20) DEFAULT NULL,
  `Telefono_Contacto` varchar(15) DEFAULT NULL,
  `Email_Contacto` varchar(50) DEFAULT NULL,
  `Cargo_Contacto` varchar(20) DEFAULT NULL,
  `Etiqueta_Contacto` varchar(10) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  `ID_Departamento` int NOT NULL,
  `ID_Empresa` int NOT NULL,
  PRIMARY KEY (`ID_Contacto`,`ID_Departamento`,`ID_Empresa`),
  KEY `fk_Contactos_Departamento1` (`ID_Departamento`,`ID_Empresa`),
  CONSTRAINT `fk_Contactos_Departamento1` FOREIGN KEY (`ID_Departamento`, `ID_Empresa`) REFERENCES `departamento` (`ID_Departamento`, `ID_Empresa`)
);

--
-- Dumping data for table `contactos`
--

INSERT INTO `contactos` VALUES (1,'Laura','45698752','laura@gmail.com','Gerente','Srta.',1,1,1);


--
-- Table structure for table `escalaevaluacion`
--

DROP TABLE IF EXISTS `escalaevaluacion`;

CREATE TABLE `escalaevaluacion` (
  `ID_EscalaEvaluacion` int NOT NULL AUTO_INCREMENT,
  `Nombre_Escala` varchar(20) DEFAULT NULL,
  `Descripcion_Escala` varchar(100) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_EscalaEvaluacion`)
);


--
-- Table structure for table `evaluacion_detalle`
--

DROP TABLE IF EXISTS `evaluacion_detalle`;

CREATE TABLE `evaluacion_detalle` (
  `ID_Evaluacion_Encabezado` int NOT NULL AUTO_INCREMENT,
  `ID_Linea` int NOT NULL,
  `ID_Procesos` int NOT NULL,
  `ID_MarcoTrabajo` int NOT NULL,
  `Centro_Analisis` varchar(20) DEFAULT NULL,
  `Observacion_Proceso` varchar(100) DEFAULT NULL,
  `Fecha_Observacion_Proceso` date DEFAULT NULL,
  `Valor` int DEFAULT NULL,
  `ID_EscalaEvaluacion` int NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Evaluacion_Encabezado`,`ID_Linea`),
  KEY `fk_Evaluacion_Detalle_Procesos1` (`ID_Procesos`,`ID_MarcoTrabajo`),
  KEY `fk_EscalaEvaluacion_TipoCalificacion1` (`ID_EscalaEvaluacion`),
  CONSTRAINT `fk_EscalaEvaluacion_TipoCalificacion1` FOREIGN KEY (`ID_EscalaEvaluacion`) REFERENCES `escalaevaluacion` (`ID_EscalaEvaluacion`),
  CONSTRAINT `fk_Evaluacion_Detalle_Procesos1` FOREIGN KEY (`ID_Procesos`, `ID_MarcoTrabajo`) REFERENCES `procesos` (`ID_Procesos`, `ID_MarcoTrabajo`)
);

-- ---------------------------------------------------




-- -----------------------------------------------------
-- Schema seguridad
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `seguridad`;

-- -----------------------------------------------------
-- Schema seguridad
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `seguridad`;
USE `seguridad`;


--
-- Table structure for table `tbl_modulo`
--

DROP TABLE IF EXISTS `tbl_modulo`;
CREATE TABLE `tbl_modulo` (
  `PK_id_Modulo` int NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado_modulo` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_Modulo`)
) ;

--
-- Dumping data for table `tbl_modulo`
--

INSERT INTO `tbl_modulo` VALUES (1,'SIC',' ',1),(1000,'SCM',' ',1);



--
-- Table structure for table `tbl_aplicacion`
--

DROP TABLE IF EXISTS `tbl_aplicacion`;
CREATE TABLE `tbl_aplicacion` (
  `PK_id_aplicacion` int NOT NULL,
  `PK_id_modulo` int NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `estado_aplicacion` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`),
  CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`)
) ;

--
-- Dumping data for table `tbl_aplicacion`
--
INSERT INTO `tbl_aplicacion` VALUES (1,1,'mant',' ',1),(1001,1000,'Mantenimientos',' ',1),(1002,1000,'Movimientos de Inventario',' ',1),(1003,1000,'Ordenes de Compra',' ',1),(1004,1000,'Cotizaciones',' ',1);


--
-- Table structure for table `tbl_usuario`
--

DROP TABLE IF EXISTS `tbl_usuario`;
CREATE TABLE `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint DEFAULT NULL,
  `estado_usuario` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_usuario`)
) ;

--
-- Dumping data for table `tbl_usuario`
--

INSERT INTO `tbl_usuario` VALUES ('MiUsuario','Usuario','Prueba','e19d5cd5af0378da05f63f891c7467af',0,1),('usu','','','25d55ad283aa400af464c76d713c07ad',NULL,1);



--
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
CREATE TABLE `tbl_bitacora` (
  `PK_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`),
  CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`)
);


--
-- Table structure for table `tbl_perfil_encabezado`
--

DROP TABLE IF EXISTS `tbl_perfil_encabezado`;
CREATE TABLE `tbl_perfil_encabezado` (
  `PK_id_perfil` int NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_perfil`)
) ;

--
-- Dumping data for table `tbl_perfil_encabezado`
--

INSERT INTO `tbl_perfil_encabezado` VALUES (1,'Adim',' ',1);


--
-- Table structure for table `tbl_perfil_detalle`
--

DROP TABLE IF EXISTS `tbl_perfil_detalle`;
CREATE TABLE `tbl_perfil_detalle` (
  `PK_id_perfil` int NOT NULL,
  `PK_id_aplicacion` int NOT NULL,
  `ingresar` tinyint DEFAULT NULL,
  `consultar` tinyint DEFAULT NULL,
  `modificar` tinyint DEFAULT NULL,
  `eliminar` tinyint DEFAULT NULL,
  `imprimir` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`),
  CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`),
  CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`)
) ;

--
-- Dumping data for table `tbl_perfil_detalle`
--

INSERT INTO `tbl_perfil_detalle` VALUES (1,1,1,1,1,1,1),(1,1001,1,1,1,1,1),(1,1002,1,1,1,1,1),(1,1003,1,1,1,1,1),(1,1004,1,1,1,1,1);


--
-- Table structure for table `tbl_usuario_aplicacion`
--

DROP TABLE IF EXISTS `tbl_usuario_aplicacion`;
CREATE TABLE `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int NOT NULL,
  `ingresar` tinyint DEFAULT NULL,
  `consultar` tinyint DEFAULT NULL,
  `modificar` tinyint DEFAULT NULL,
  `eliminar` tinyint DEFAULT NULL,
  `imprimir` tinyint DEFAULT NULL,
  PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`),
  CONSTRAINT `fk_tbl_usuario_aplicacion_tbl_aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`),
  CONSTRAINT `fk_Usuario_aplicacion_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`)
) ;

--
-- Dumping data for table `tbl_usuario_aplicacion`
--

INSERT INTO `tbl_usuario_aplicacion` VALUES ('MiUsuario',1,1,1,1,1,1),('usu',1,1,1,1,1,1);


--
-- Table structure for table `tbl_usuario_perfil`
--

DROP TABLE IF EXISTS `tbl_usuario_perfil`;
CREATE TABLE `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int NOT NULL,
  PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`),
  CONSTRAINT `fk_Usuario_perfil_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`),
  CONSTRAINT `fk_Usuario_perfil_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`)
) ;

--
-- Dumping data for table `tbl_usuario_perfil`
--

INSERT INTO `tbl_usuario_perfil` VALUES ('MiUsuario',1),('usu',1);


