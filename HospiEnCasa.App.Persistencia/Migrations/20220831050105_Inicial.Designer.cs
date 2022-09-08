﻿// <auto-generated />
using System;
using HospiEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospiEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220831050105_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HospiEnCasa.App.Dominio.AuxiliarHospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuxiliarHospital");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Enfermero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorasLaborales")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enfermeros");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Familiar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Familiares");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegRethus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AuxiliarHospitalId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coordenadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnfermeroId")
                        .HasColumnType("int");

                    b.Property<string>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuxiliarHospitalId");

                    b.HasIndex("EnfermeroId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaCardiaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Glicemia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("Oximetria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresionArterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHoraCreacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("SugerenciasCuidados");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Familiar", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Paciente", "Paciente")
                        .WithMany("ListaFamiliares")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Medico", "Medico")
                        .WithMany("ListaHistorias")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospiEnCasa.App.Dominio.Paciente", "Paciente")
                        .WithMany("ListaHistorias")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Paciente", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.AuxiliarHospital", "AuxiliarHospital")
                        .WithMany("ListaPacientes")
                        .HasForeignKey("AuxiliarHospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospiEnCasa.App.Dominio.Enfermero", "Enfermero")
                        .WithMany("ListaPacientes")
                        .HasForeignKey("EnfermeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospiEnCasa.App.Dominio.Medico", "Medico")
                        .WithMany("ListaPacientes")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuxiliarHospital");

                    b.Navigation("Enfermero");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.SignoVital", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.HistoriaClinica", "HistoriaClinica")
                        .WithMany("ListaSignosVitales")
                        .HasForeignKey("HistoriaClinicaId");

                    b.Navigation("HistoriaClinica");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.HistoriaClinica", "HistoriaClinica")
                        .WithMany("ListaSugerencias")
                        .HasForeignKey("HistoriaClinicaId");

                    b.Navigation("HistoriaClinica");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.AuxiliarHospital", b =>
                {
                    b.Navigation("ListaPacientes");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Enfermero", b =>
                {
                    b.Navigation("ListaPacientes");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.HistoriaClinica", b =>
                {
                    b.Navigation("ListaSignosVitales");

                    b.Navigation("ListaSugerencias");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Medico", b =>
                {
                    b.Navigation("ListaHistorias");

                    b.Navigation("ListaPacientes");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Paciente", b =>
                {
                    b.Navigation("ListaFamiliares");

                    b.Navigation("ListaHistorias");
                });
#pragma warning restore 612, 618
        }
    }
}
