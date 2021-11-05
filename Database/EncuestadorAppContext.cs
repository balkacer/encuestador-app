using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database
{
    public partial class EncuestadorAppContext : DbContext
    {
        public EncuestadorAppContext()
        {
        }

        public EncuestadorAppContext(DbContextOptions<EncuestadorAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QuestionResponse> QuestionResponses { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<Respondent> Respondents { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-C6J44E2\\SQLEXPRESS;Database=EncuestadorApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<QuestionResponse>(entity =>
            {
                entity.ToTable("QuestionResponse");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuizQuestion)
                    .WithMany(p => p.QuestionResponses)
                    .HasForeignKey(d => d.QuizQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionR__QuizQ__31EC6D26");

                entity.HasOne(d => d.Respondent)
                    .WithMany(p => p.QuestionResponses)
                    .HasForeignKey(d => d.RespondentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionR__Respo__30F848ED");
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.ToTable("Quiz");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Quizzes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Quiz__UserId__276EDEB3");
            });

            modelBuilder.Entity<QuizQuestion>(entity =>
            {
                entity.ToTable("QuizQuestion");

                entity.HasIndex(e => new { e.QuizId, e.Question }, "UQ_Quiz_Question")
                    .IsUnique();

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuizQuestions)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuizQuest__QuizI__2B3F6F97");
            });

            modelBuilder.Entity<Respondent>(entity =>
            {
                entity.ToTable("Respondent");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Responden__QuizI__2E1BDC42");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Username, "UQ__User__536C85E4933E1FB5")
                    .IsUnique();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
