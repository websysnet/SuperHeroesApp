using ClasesAvanzadas;

Profesor profe1 = new Profesor { Name = "Carlos", Age = 45, Subject = "Matemáticas" };


Profesor profe2 = new Profesor { Name = "Maria", Age = 42, Subject = "Ingles" };

Estudiante estudiante1 = new Estudiante { Name = "Ana", Age = 20, School = "Universidad XYZ", profesores = new List<Profesor> { profe1,profe2 } };

estudiante1.Saludar();
estudiante1.Estudiar();
Console.WriteLine("Profesores del estudiante:");
estudiante1.MostrarProfesores(estudiante1.profesores!);





