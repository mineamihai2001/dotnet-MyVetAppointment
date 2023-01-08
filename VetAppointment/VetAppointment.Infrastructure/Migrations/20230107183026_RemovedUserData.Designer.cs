﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetAppointment.Infrastructure;

#nullable disable

namespace VetAppointment.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230107183026_RemovedUserData")]
    partial class RemovedUserData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("VetAppointment.Domain.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MedicId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MedicId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RoomId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.AuthenticationModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MedicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<double>("PaymentSum")
                        .HasColumnType("REAL");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("ClientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MedicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MedicId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Medic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Medics");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Medicine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BillId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PricePerUnit")
                        .HasColumnType("REAL");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Nurse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("MedicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MedicId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Appointment", b =>
                {
                    b.HasOne("VetAppointment.Domain.Models.Medic", "Medic")
                        .WithMany("Appointments")
                        .HasForeignKey("MedicId");

                    b.HasOne("VetAppointment.Domain.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId");

                    b.HasOne("VetAppointment.Domain.Models.Room", "Room")
                        .WithMany("Appointments")
                        .HasForeignKey("RoomId");

                    b.Navigation("Medic");

                    b.Navigation("Patient");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Bill", b =>
                {
                    b.HasOne("VetAppointment.Domain.Models.Appointment", "Appointment")
                        .WithOne("Bill")
                        .HasForeignKey("VetAppointment.Domain.Models.Bill", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetAppointment.Domain.Models.Client", "Client")
                        .WithMany("Billings")
                        .HasForeignKey("ClientId");

                    b.Navigation("Appointment");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Client", b =>
                {
                    b.HasOne("VetAppointment.Domain.Models.Medic", null)
                        .WithMany("Clients")
                        .HasForeignKey("MedicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Medicine", b =>
                {
                    b.HasOne("VetAppointment.Domain.Models.Bill", null)
                        .WithMany("Prescription")
                        .HasForeignKey("BillId");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Patient", b =>
                {
                    b.HasOne("VetAppointment.Domain.Models.Client", null)
                        .WithMany("Pets")
                        .HasForeignKey("ClientId");

                    b.HasOne("VetAppointment.Domain.Models.Medic", null)
                        .WithMany("Patients")
                        .HasForeignKey("MedicId");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Appointment", b =>
                {
                    b.Navigation("Bill");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Bill", b =>
                {
                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Client", b =>
                {
                    b.Navigation("Billings");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Medic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Clients");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("VetAppointment.Domain.Models.Room", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
