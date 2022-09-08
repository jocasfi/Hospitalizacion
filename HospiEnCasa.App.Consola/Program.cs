// See https://aka.ms/new-console-template for more information
using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

public class Program
{
    private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente( new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioMedico _repositorioMedico = new RepositorioMedico( new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero( new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar( new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext() );
    private static IRepositorioSignoVital _repositorioSignoVital = new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext() );

    private static void Main(String[] args)
    {
        Console.WriteLine("Hola Mundo .NET Hospital en Casa!");
        
        BuscarPaciente();
        VerListadoPacientes();
        /*AdicionarEnfermero();
        AdicionarMedico();
        AdicionarAuxiliar();
        AdicionarPaciente();
        AdicionarFamiliar();
        AdicionarHistoria();
        AdicionarSignoVital();
        BuscarPaciente();
        VerListadoPacientes();*/
    }

    public static void BuscarPaciente()
    {
        var paciente = _repositorioPaciente.GetPaciente(3);
        Console.WriteLine(paciente.Nombre);
    }

    static void VerListadoPacientes()
    {
        var pacientes = _repositorioPaciente.GetAllPaciente();
        foreach (var p in pacientes ){
            Console.WriteLine("Pacientes Registrados: " + p.Id + " - " + p.Nombre + " " + p.Apellidos);
        }

    }

    /*static void AdicionarSignoVital()
    {
        Console.WriteLine("Adicionando Signos Vitales ....");
        SignoVital signoVital = new SignoVital();
        signoVital.FechaRegistro = "Fecha Prueba";
        signoVital.Oximetria = "Cifra Prueba";
        signoVital.FrecuenciaRespiratoria = "Cifra Prueba";
        signoVital.FrecuenciaCardiaca = "Cifra Prueba";
        signoVital.Temperatura = "Cifra Prueba";
        signoVital.PresionArterial = "Cifra Prueba";
        signoVital.Glicemia = "Cifra Prueba";
        signoVital.HistoriaClinicaId = 1;

        _repositorioSignoVital.AddSignoVital(signoVital);
        Console.WriteLine("Signos Vitales creados con exito");
    }

    static void AdicionarHistoria()
    {
        Console.WriteLine("Adicionando Historia Clinica ....");
        HistoriaClinica historiaClinica = new HistoriaClinica();
        historiaClinica.Identificador = "Historia-1A";
        historiaClinica.Diagnostico = "Gripa";
        historiaClinica.Entorno = "Cuidado en casa con vigilancia medica";
        historiaClinica.PacienteId = 1;
        historiaClinica.MedicoId = 1;

        _repositorioHistoria.AddHistoria(historiaClinica);
        Console.WriteLine("Historia Clinica creada con exito");
    }

    static void AdicionarFamiliar()
    {
        Console.WriteLine("Adicionando un Familiar ....");
        Familiar familiar = new Familiar();
        familiar.Parentesco = "FamliarA";
        familiar.Email = "Prueba";
        familiar.PacienteId = 1;
        familiar.Nombre = "FamliarA";
        familiar.Apellidos = "Prueba";
        familiar.NumeroTelefono = "123";
        familiar.Genero = "Prueba";

        _repositorioFamiliar.AddFamiliar(familiar);
        Console.WriteLine("Familiar fue creado con exito");
    }
    static void AdicionarPaciente()
    {
        Console.WriteLine("Adicionando un Paciente ....");
        Paciente paciente = new Paciente();
        paciente.Direccion = "Calle 100 con 20";
        paciente.Coordenadas = "105.102.2";
        paciente.Ciudad = "Neiva";
        paciente.FechaNacimiento = "15-07-1980";
        paciente.AuxiliarHospitalId = 1;
        paciente.MedicoId = 1;
        paciente.EnfermeroId = 1;
        paciente.Nombre = "Camilo";
        paciente.Apellidos = "Castro Castrillo";
        paciente.NumeroTelefono = "8775421";
        paciente.Genero = "Masculino";

        _repositorioPaciente.AddPaciente(paciente);
        Console.WriteLine("Paciente fue creado con exito");
    }

    static void AdicionarEnfermero()
    {
        Console.WriteLine("Adicionando un Enfermero ....");
        Enfermero enfermero = new Enfermero();
        enfermero.TarjetaProfesional = "123";
        enfermero.HorasLaborales = "123";
        enfermero.Nombre = "Generico";
        enfermero.Apellidos = "Generico";
        enfermero.NumeroTelefono = "123";
        enfermero.Genero = "Generico";

        _repositorioEnfermero.AddEnfermero(enfermero);
        Console.WriteLine("Medico fue creado con exito");
    }

    static void AdicionarMedico()
    {
        Console.WriteLine("Adicionando un Medico ....");
        Medico medico = new Medico();
        medico.Especialidad = "Generico";
        medico.RegRethus = "123";
        medico.Nombre = "Generico";
        medico.Apellidos = "Generico";
        medico.NumeroTelefono = "123";
        medico.Genero = "Generico";

        _repositorioMedico.AddMedico(medico);
        Console.WriteLine("Medico fue creado con exito");
    }

    static void AdicionarAuxiliar()
    {
        Console.WriteLine("Adicionando un Auxiliar ....");
        AuxiliarHospital auxiliarHospital = new AuxiliarHospital();
        auxiliarHospital.Nombre = "Generico";
        auxiliarHospital.Apellidos = "Generico";
        auxiliarHospital.NumeroTelefono = "123";
        auxiliarHospital.Genero = "Generico";

        _repositorioAuxiliar.AddAuxiliar(auxiliarHospital);
        Console.WriteLine("Auxiliar fue creado con exito");
    }*/

    /*static void BuscarPaciente()
    {
        //TODO
    }

    static void VerListadoPacientes()
    {
        //TODO
    }*/
}

