*********************CONFIGURAR AMBIENTE DESARROLLO PYTHON**************************************
-instalar python. https://www.python.org/downloads/ 

---dentro de la carpeta principal
---crear ambiente virtual -->  myenv es el nombre del ambiente viritual puede ser cualquiera, nombre corto sin espacios en blanco
python -m venv myenv

---activar ambiente virtual
.\myenv\Scripts\activate

---instalar mysql conector, es el driver de la base: mysql para conectar con: python
python -m pip install mysql-connector-python


---actulizar pip (opcional)
python.exe -m pip install --upgrade pip


*********************CONFIGURAR APIs para Python*************************
--instalar fastapi para crear las APIs get, post, put, delete
pip install fastapi

--instalar webapi para tener un servidor web
pip install uvicorn

*********************CONFIGURAR ORM PARA CREACION DE TABLAS EN MYSQL DESDE Python*************************
---ORM SQLAlchemyClase 
pip install sqlalchemy


*********************CONFIGURAR ORM PARA CREACION DE TABLAS EN MYSQL DESDE Python*************************

--crear carpeta config y dentro el archivo database.py
--crear el main.py con los respectivos metodos APIs

-main.py


--levartar servidor
python -m uvicorn mainAPI:app

---recargar cambios en caliente
python -m uvicorn mainAPI:app --reload

--cargar en diferente puerto
python -m uvicorn mainAPI:app --reload --port 8082

--swagger OPenAPI
http://localhost:8081/docs


******************Configurar Seguridad en Apis*******************
--instalar JWT en python
--doc de JWT: https://www.netmentor.es/entrada/que-es-jwt
pip install pyjwt

--crear el archivo jwt_manager.py
--en este archivo se crea el token y el key(codigo secreto de mi token)
--crear el Usuario con clave y correo
--crear el metodo generar token
--pagina web para visualizar contenido de un token:  https://jwt.io/

