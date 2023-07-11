﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Music2.Data;

namespace Music2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230508203833_MusicDbContext2")]
    partial class MusicDbContext2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Music2.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContactInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.HasIndex("TrackId1");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Music2.Models.AudioTrack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Album")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AudioTracks");
                });

            modelBuilder.Entity("Music2.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Music2.Models.Release", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Releases");
                });

            modelBuilder.Entity("Music2.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Lyrics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("ReleaseId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Music2.Models.Artist", b =>
                {
                    b.HasOne("Music2.Models.Track", null)
                        .WithMany("Authors")
                        .HasForeignKey("TrackId");

                    b.HasOne("Music2.Models.Track", null)
                        .WithMany("Performers")
                        .HasForeignKey("TrackId1");
                });

            modelBuilder.Entity("Music2.Models.Release", b =>
                {
                    b.HasOne("Music2.Models.Artist", "Artist")
                        .WithMany("Releases")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Music2.Models.Genre", "Genre")
                        .WithMany("Releases")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Music2.Models.Track", b =>
                {
                    b.HasOne("Music2.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Music2.Models.Release", "Release")
                        .WithMany("Tracks")
                        .HasForeignKey("ReleaseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Release");
                });

            modelBuilder.Entity("Music2.Models.Artist", b =>
                {
                    b.Navigation("Releases");
                });

            modelBuilder.Entity("Music2.Models.Genre", b =>
                {
                    b.Navigation("Releases");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Music2.Models.Release", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Music2.Models.Track", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Performers");
                });
#pragma warning restore 612, 618
        }
    }
}
