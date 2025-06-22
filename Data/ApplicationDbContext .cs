using ISC_BE02.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  
using System.Reflection.Emit;  

namespace ISC_BE02.Data  
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
 
        public DbSet<CoursesLearned> CoursesLearned { get; set; }
        public DbSet<TotalCoursesTaken> TotalCoursesTaken { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<StudentsChangeSchool> StudentsChangeSchool { get; set; }
        public DbSet<StudentsChangeClasses> StudentsChangeClasses { get; set; }
        public DbSet<Reserved> Reserved { get; set; }
        public DbSet<AcceptingSchoolTransfers> AcceptingSchoolTransfers { get; set; }
        public DbSet<ClassHistorySession> ClassHistorySessions { get; set; }
        public DbSet<ClassHistory> ClassHistory { get; set; }
        public DbSet<Registrations> Registrations { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<StudentsProfile> StudentsProfile { get; set; }
        public DbSet<SubjectType> SubjectType { get; set; }
        public DbSet<Subjects_Class> Subjects_Class { get; set; }
        public DbSet<Class_Detail> Class_Detail { get; set; }
        public DbSet<Team_Department> Team_Department { get; set; }
        public DbSet<ClassroomSettings> ClassroomSettings { get; set; }
        public DbSet<CourseOfferings> CourseOfferings { get; set; }
        public DbSet<Decentralization> Decentralization { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassType> ClassType { get; set; }
        public DbSet<Exemptions> Exemptions { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<Reward> Reward { get; set; }
        public DbSet<StudentMCQAnswers> StudentMCQAnswers { get; set; }
        public DbSet<CourseLessons> CourseLessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategories> CourseCategories { get; set; }
        public DbSet<ClassSessions> ClassSessions { get; set; }
        public DbSet<PastClasses> PastClasses { get; set; }
        public DbSet<UpcomingClass> UpcomingClass { get; set; }
        public DbSet<TeacherProfile> TeacherProfile { get; set; }
        public DbSet<LearningOutcomes> LearningOutcomes { get; set; }
        public DbSet<Faculty_StudyBlock> Faculty_StudyBlock { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<TrainingLevels> TrainingLevels { get; set; }
        public DbSet<Student_Grades> Student_Grades { get; set; }
        public DbSet<Teaching_Assessment> Teaching_Assessment { get; set; }
        public DbSet<AssessmentParts> AssessmentParts { get; set; }
        public DbSet<Student_Submissions> Student_Submissions { get; set; }
        public DbSet<Assignment_Group> Assignment_Group { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<LabScheduleClasses> LabScheduleClasses { get; set; }
        public DbSet<LabSchedules> LabSchedules { get; set; }
        public DbSet<LabGraders> LabGraders { get; set; }
        public DbSet<AssessmentQuestions> AssessmentQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOptions> QuestionOptions { get; set; }
        public DbSet<WorkHistories> WorkHistories { get; set; }
        public DbSet<Employment_History> Employment_History { get; set; }
        public DbSet<SystemSettings> SystemSettings { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Syllabus_topics> Syllabus_topics { get; set; }
        public DbSet<LiveSessions> LiveSessions { get; set; }
        public DbSet<LiveChatMessages> LiveChatMessages { get; set; }
        public DbSet<SchoolProfile> SchoolProfile { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<ThreadPosts> ThreadPosts { get; set; }
        public DbSet<DiscussionThreads> DiscussionThreads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Explicitly map each entity to its table name
            modelBuilder.Entity<CoursesLearned>().ToTable("CoursesLearned");
            modelBuilder.Entity<TotalCoursesTaken>().ToTable("TotalCoursesTaken");
            modelBuilder.Entity<Semester>().ToTable("Semester");
            modelBuilder.Entity<SchoolYear>().ToTable("SchoolYear");
            modelBuilder.Entity<StudentsChangeSchool>().ToTable("StudentsChangeSchool");
            modelBuilder.Entity<StudentsChangeClasses>().ToTable("StudentsChangeClasses");
            modelBuilder.Entity<Reserved>().ToTable("Reserved");
            modelBuilder.Entity<AcceptingSchoolTransfers>().ToTable("AcceptingSchoolTransfers");
            modelBuilder.Entity<ClassHistorySession>().ToTable("ClassHistorySession");
            modelBuilder.Entity<ClassHistory>().ToTable("ClassHistory");
            modelBuilder.Entity<Registrations>().ToTable("Registrations");
            modelBuilder.Entity<UserGroup>().ToTable("UserGroup");
            modelBuilder.Entity<StudentsProfile>().ToTable("StudentsProfile");
            modelBuilder.Entity<SubjectType>().ToTable("SubjectType");
            modelBuilder.Entity<Subjects_Class>().ToTable("Subjects_Class");
            modelBuilder.Entity<Class_Detail>().ToTable("Class_Detail");
            modelBuilder.Entity<Team_Department>().ToTable("Team-Department"); // Assuming table name is "Team-Department"
            modelBuilder.Entity<ClassroomSettings>().ToTable("ClassroomSettings");
            modelBuilder.Entity<CourseOfferings>().ToTable("CourseOfferings");
            modelBuilder.Entity<Decentralization>().ToTable("Decentralization");
            modelBuilder.Entity<Notification>().ToTable("Notification");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<RolePermissions>().ToTable("RolePermissions");
            modelBuilder.Entity<Permissions>().ToTable("Permissions");
            modelBuilder.Entity<Subject>().ToTable("Subjects");
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<ClassType>().ToTable("ClassType");
            modelBuilder.Entity<Exemptions>().ToTable("Exemptions");
            modelBuilder.Entity<Discipline>().ToTable("Discipline");
            modelBuilder.Entity<Reward>().ToTable("Reward");
            modelBuilder.Entity<StudentMCQAnswers>().ToTable("StudentMCQAnswers");
            modelBuilder.Entity<CourseLessons>().ToTable("CourseLessons");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<CourseCategories>().ToTable("CourseCategories");
            modelBuilder.Entity<ClassSessions>().ToTable("ClassSessions");
            modelBuilder.Entity<PastClasses>().ToTable("PastClasses");
            modelBuilder.Entity<UpcomingClass>().ToTable("UpcomingClass");
            modelBuilder.Entity<TeacherProfile>().ToTable("TeacherProfile");
            modelBuilder.Entity<LearningOutcomes>().ToTable("LearningOutcomes");
            modelBuilder.Entity<Faculty_StudyBlock>().ToTable("Faculty - StudyBlock"); // Assuming table name is "Faculty - StudyBlock"
            modelBuilder.Entity<Score>().ToTable("Score");
            modelBuilder.Entity<Grades>().ToTable("Grades");
            modelBuilder.Entity<TrainingLevels>().ToTable("TrainingLevels");
            modelBuilder.Entity<Student_Grades>().ToTable("Student_Grades");
            modelBuilder.Entity<Teaching_Assessment>().ToTable("Teaching_Assessment");
            modelBuilder.Entity<AssessmentParts>().ToTable("AssessmentParts");
            modelBuilder.Entity<Student_Submissions>().ToTable("Student_Submissions");
            modelBuilder.Entity<Assignment_Group>().ToTable("Assignment_Group");
            modelBuilder.Entity<Assignment>().ToTable("Assignments");
            modelBuilder.Entity<LabScheduleClasses>().ToTable("LabScheduleClasses");
            modelBuilder.Entity<LabSchedules>().ToTable("LabSchedules");
            modelBuilder.Entity<LabGraders>().ToTable("LabGraders");
            modelBuilder.Entity<AssessmentQuestions>().ToTable("AssessmentQuestions");
            modelBuilder.Entity<Question>().ToTable("Questions");
            modelBuilder.Entity<QuestionOptions>().ToTable("QuestionOptions");
            modelBuilder.Entity<WorkHistories>().ToTable("WorkHistories");
            modelBuilder.Entity<Employment_History>().ToTable("Employment_History");
            modelBuilder.Entity<SystemSettings>().ToTable("SystemSettings");
            modelBuilder.Entity<Qualification>().ToTable("Qualifications");
            modelBuilder.Entity<Syllabus_topics>().ToTable("Syllabus_topics");
            modelBuilder.Entity<LiveSessions>().ToTable("LiveSessions");
            modelBuilder.Entity<LiveChatMessages>().ToTable("LiveChatMessages");
            modelBuilder.Entity<SchoolProfile>().ToTable("SchoolProfile");
            modelBuilder.Entity<Campus>().ToTable("Campuses");
            modelBuilder.Entity<ThreadPosts>().ToTable("ThreadPosts");
            modelBuilder.Entity<DiscussionThreads>().ToTable("DiscussionThreads");

            // Configure relationships based on the provided schema (retained from previous response)

            // User and Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.Role_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // User and UserGroup
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserGroup)
                .WithMany(ug => ug.Users)
                .HasForeignKey(u => u.Group_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // User and SchoolYear (for SchoolYear_ID in User)
            modelBuilder.Entity<User>()
                .HasOne(u => u.SchoolYear)
                .WithMany(sy => sy.Users)
                .HasForeignKey(u => u.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // SchoolYear and User (for User_ID in SchoolYear)
            modelBuilder.Entity<SchoolYear>()
                .HasOne(sy => sy.User)
                .WithMany(u => u.SchoolYearsCreated) // Assuming a navigation property for User creating SchoolYears
                .HasForeignKey(sy => sy.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // SchoolYear and SchoolProfile
            modelBuilder.Entity<SchoolYear>()
                .HasOne(sy => sy.School)
                .WithMany(sp => sp.SchoolYears)
                .HasForeignKey(sy => sy.School_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // SchoolProfile and SchoolYear (for SchoolYear_ID in SchoolProfile)
            modelBuilder.Entity<SchoolProfile>()
                .HasOne(sp => sp.SchoolYear)
                .WithMany(sy => sy.SchoolProfiles) // Assuming a navigation property for SchoolProfile linked to SchoolYear
                .HasForeignKey(sp => sp.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Campus and SchoolProfile
            modelBuilder.Entity<Campus>()
                .HasOne(c => c.School)
                .WithMany(sp => sp.Campuses)
                .HasForeignKey(c => c.School_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Trong SchoolContext.cs (phương thức OnModelCreating)

            modelBuilder.Entity<TotalCoursesTaken>() // Bắt đầu từ phía "nhiều" (dependent)
                .HasOne(tct => tct.CoursesLearned) // Mỗi TotalCoursesTaken có một CoursesLearned
                .WithMany(cl => cl.TotalCoursesTaken) // Một CoursesLearned có nhiều TotalCoursesTaken
                .HasForeignKey(tct => tct.CoursesLearned_ID) // Khóa ngoại CoursesLearned_ID nằm trên TotalCoursesTaken
                .OnDelete(DeleteBehavior.Restrict); // Giữ nguyên DeleteBehavior của bạn
            // CoursesLearned and SchoolYear
            modelBuilder.Entity<CoursesLearned>()
                .HasOne(cl => cl.SchoolYear)
                .WithMany(sy => sy.CoursesLearned)
                .HasForeignKey(cl => cl.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TotalCoursesTaken and CoursesLearned (Already defined above as inverse)

            // TotalCoursesTaken and User
            modelBuilder.Entity<TotalCoursesTaken>()
                .HasOne(tct => tct.User)
                .WithMany(u => u.TotalCoursesTaken)
                .HasForeignKey(tct => tct.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Semester and SchoolYear
            modelBuilder.Entity<Semester>()
                .HasOne(s => s.SchoolYear)
                .WithMany(sy => sy.Semesters)
                .HasForeignKey(s => s.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsChangeSchool and User
            modelBuilder.Entity<StudentsChangeSchool>()
                .HasOne(scs => scs.User)
                .WithMany(u => u.StudentsChangeSchoolRequests)
                .HasForeignKey(scs => scs.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsChangeSchool and SchoolYear
            modelBuilder.Entity<StudentsChangeSchool>()
                .HasOne(scs => scs.SchoolYear)
                .WithMany(sy => sy.StudentsChangeSchoolRequests)
                .HasForeignKey(scs => scs.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsChangeClasses and User
            modelBuilder.Entity<StudentsChangeClasses>()
                .HasOne(scc => scc.User)
                .WithMany(u => u.StudentsChangeClassesRequests)
                .HasForeignKey(scc => scc.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsChangeClasses and Class (Class_IDPresent)
            modelBuilder.Entity<StudentsChangeClasses>()
                .HasOne(scc => scc.ClassPresent)
                .WithMany(c => c.StudentsChangeClassesPresent)
                .HasForeignKey(scc => scc.Class_IDPresent)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsChangeClasses and Class (Class_IDMoveTo)
            modelBuilder.Entity<StudentsChangeClasses>()
                .HasOne(scc => scc.ClassMoveTo)
                .WithMany(c => c.StudentsChangeClassesMoveTo)
                .HasForeignKey(scc => scc.Class_IDMoveTo)
                .OnDelete(DeleteBehavior.Restrict);

            // Reserved and User
            modelBuilder.Entity<Reserved>()
                .HasOne(r => r.User)
                .WithMany(u => u.ReservedRequests)
                .HasForeignKey(r => r.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reserved and Class (Class_IDPresent)
            modelBuilder.Entity<Reserved>()
                .HasOne(r => r.ClassPresent)
                .WithMany(c => c.ReservedPresent)
                .HasForeignKey(r => r.Class_IDPresent)
                .OnDelete(DeleteBehavior.Restrict);

            // Reserved and Class (Class_IDMoveTo)
            modelBuilder.Entity<Reserved>()
                .HasOne(r => r.ClassMoveTo)
                .WithMany(c => c.ReservedMoveTo)
                .HasForeignKey(r => r.Class_IDMoveTo)
                .OnDelete(DeleteBehavior.Restrict);

            // AcceptingSchoolTransfers and User
            modelBuilder.Entity<AcceptingSchoolTransfers>()
                .HasOne(ast => ast.User)
                .WithMany(u => u.AcceptingSchoolTransfers)
                .HasForeignKey(ast => ast.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // AcceptingSchoolTransfers and SchoolYear
            modelBuilder.Entity<AcceptingSchoolTransfers>()
                .HasOne(ast => ast.SchoolYear)
                .WithMany(sy => sy.AcceptingSchoolTransfers)
                .HasForeignKey(ast => ast.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassHistorySession and ClassHistory
            modelBuilder.Entity<ClassHistorySession>()
                .HasOne(chs => chs.ClassHistory)
                .WithMany(ch => ch.ClassHistorySessions)
                .HasForeignKey(chs => chs.History_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassHistory and Class
            modelBuilder.Entity<ClassHistory>()
                .HasOne(ch => ch.Class)
                .WithMany(c => c.ClassHistory)
                .HasForeignKey(ch => ch.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassHistory and Subject
            modelBuilder.Entity<ClassHistory>()
                .HasOne(ch => ch.Subject)
                .WithMany(s => s.ClassHistory)
                .HasForeignKey(ch => ch.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassHistory and User
            modelBuilder.Entity<ClassHistory>()
                .HasOne(ch => ch.User)
                .WithMany(u => u.ClassHistory)
                .HasForeignKey(ch => ch.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Registrations and User (Student_user_id)
            modelBuilder.Entity<Registrations>()
                .HasOne(r => r.StudentUser)
                .WithMany(u => u.Registrations)
                .HasForeignKey(r => r.Student_user_id)
                .OnDelete(DeleteBehavior.Restrict);

            // Registrations and CourseOfferings
            modelBuilder.Entity<Registrations>()
                .HasOne(r => r.CourseOfferings)
                .WithMany(co => co.Registrations)
                .HasForeignKey(r => r.CourseOfferings_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Decentralization and UserGroup
            modelBuilder.Entity<Decentralization>()
                .HasOne(d => d.UserGroup)
                .WithMany(ug => ug.Decentralizations)
                .HasForeignKey(d => d.Group_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Notification and User
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // RolePermissions (Junction Table)
            modelBuilder.Entity<RolePermissions>()
                .HasKey(rp => new { rp.Role_ID, rp.Permissions_ID });

            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.Role_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Permissions)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.Permissions_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Subjects_Class (Junction Table)
            modelBuilder.Entity<Subjects_Class>()
                .HasKey(sc => new { sc.Subjects_ID, sc.Class_ID });

            modelBuilder.Entity<Subjects_Class>()
                .HasOne(sc => sc.Subject)
                .WithMany(s => s.Subjects_Classes)
                .HasForeignKey(sc => sc.Subjects_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Subjects_Class>()
                .HasOne(sc => sc.Class)
                .WithMany(c => c.Subjects_Classes)
                .HasForeignKey(sc => sc.Class_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Class_Detail and User (Student_ID)
            modelBuilder.Entity<Class_Detail>()
                .HasOne(cd => cd.StudentUser)
                .WithMany(u => u.ClassDetailsAsStudent)
                .HasForeignKey(cd => cd.Student_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class_Detail and Class
            modelBuilder.Entity<Class_Detail>()
                .HasOne(cd => cd.Class)
                .WithMany(c => c.ClassDetails)
                .HasForeignKey(cd => cd.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class_Detail and Team_Department
            modelBuilder.Entity<Class_Detail>()
                .HasOne(cd => cd.Department)
                .WithMany(td => td.ClassDetails)
                .HasForeignKey(cd => cd.Department_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class_Detail and User (User_ID)
            modelBuilder.Entity<Class_Detail>()
                .HasOne(cd => cd.User)
                .WithMany(u => u.ClassDetailsManaged) // Assuming a manager/creator relationship
                .HasForeignKey(cd => cd.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class_Detail and SchoolYear
            modelBuilder.Entity<Class_Detail>()
                .HasOne(cd => cd.SchoolYear)
                .WithMany(sy => sy.ClassDetails)
                .HasForeignKey(cd => cd.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Team_Department and SchoolYear
            modelBuilder.Entity<Team_Department>()
                .HasOne(td => td.SchoolYear)
                .WithMany(sy => sy.Departments)
                .HasForeignKey(td => td.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Team_Department and User
            modelBuilder.Entity<Team_Department>()
                .HasOne(td => td.User)
                .WithMany(u => u.DepartmentsManaged) // Assuming user manages a department
                .HasForeignKey(td => td.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Team_Department and SchoolProfile
            modelBuilder.Entity<Team_Department>()
                .HasOne(td => td.School)
                .WithMany(sp => sp.Departments)
                .HasForeignKey(td => td.School_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseOfferings and Course
            modelBuilder.Entity<CourseOfferings>()
                .HasOne(co => co.Course)
                .WithMany(c => c.CourseOfferings)
                .HasForeignKey(co => co.Courses_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseOfferings and User (Instructor_user_id)
            modelBuilder.Entity<CourseOfferings>()
                .HasOne(co => co.InstructorUser)
                .WithMany(u => u.CourseOfferingsTaught)
                .HasForeignKey(co => co.Instructor_user_id)
                .OnDelete(DeleteBehavior.Restrict);

            // Subjects and SubjectType
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.SubjectType)
                .WithMany(st => st.Subjects)
                .HasForeignKey(s => s.SubjectType_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Subjects and Team_Department
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Department)
                .WithMany(td => td.Subjects)
                .HasForeignKey(s => s.Department_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Subjects and User
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.User)
                .WithMany(u => u.SubjectsCreated)
                .HasForeignKey(s => s.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Subjects and SchoolYear
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.SchoolYear)
                .WithMany(sy => sy.Subjects)
                .HasForeignKey(s => s.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class and User
            modelBuilder.Entity<Class>()
                .HasOne(c => c.User)
                .WithMany(u => u.ClassesManaged)
                .HasForeignKey(c => c.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class and Team_Department
            modelBuilder.Entity<Class>()
                .HasOne(c => c.Department)
                .WithMany(td => td.Classes)
                .HasForeignKey(c => c.Department_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class and SchoolYear
            modelBuilder.Entity<Class>()
                .HasOne(c => c.SchoolYear)
                .WithMany(sy => sy.Classes)
                .HasForeignKey(c => c.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class and ClassroomSettings
            modelBuilder.Entity<Class>()
                .HasOne(c => c.ClassroomSettings)
                .WithMany(cs => cs.Classes)
                .HasForeignKey(c => c.ClassroomSettings_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Class and ClassType
            modelBuilder.Entity<Class>()
                .HasOne(c => c.ClassType)
                .WithMany(ct => ct.Classes)
                .HasForeignKey(c => c.ClassType_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Exemptions and User
            modelBuilder.Entity<Exemptions>()
                .HasOne(e => e.User)
                .WithMany(u => u.Exemptions)
                .HasForeignKey(e => e.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Exemptions and Class
            modelBuilder.Entity<Exemptions>()
                .HasOne(e => e.Class)
                .WithMany(c => c.Exemptions)
                .HasForeignKey(e => e.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Discipline and User
            modelBuilder.Entity<Discipline>()
                .HasOne(d => d.User)
                .WithMany(u => u.Disciplines)
                .HasForeignKey(d => d.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Discipline and Class
            modelBuilder.Entity<Discipline>()
                .HasOne(d => d.Class)
                .WithMany(c => c.Disciplines)
                .HasForeignKey(d => d.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reward and User
            modelBuilder.Entity<Reward>()
                .HasOne(r => r.User)
                .WithMany(u => u.Rewards)
                .HasForeignKey(r => r.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reward and Class
            modelBuilder.Entity<Reward>()
                .HasOne(r => r.Class)
                .WithMany(c => c.Rewards)
                .HasForeignKey(r => r.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentMCQAnswers and Student_Submissions
            modelBuilder.Entity<StudentMCQAnswers>()
                .HasOne(sma => sma.Submission)
                .WithMany(ss => ss.StudentMCQAnswers)
                .HasForeignKey(sma => sma.Submissions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentMCQAnswers and Question
            modelBuilder.Entity<StudentMCQAnswers>()
                .HasOne(sma => sma.Question)
                .WithMany(q => q.StudentMCQAnswers)
                .HasForeignKey(sma => sma.Questions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentMCQAnswers and QuestionOptions
            modelBuilder.Entity<StudentMCQAnswers>()
                .HasOne(sma => sma.QuestionOption)
                .WithMany(qo => qo.StudentMCQAnswers)
                .HasForeignKey(sma => sma.QuestionOptions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseLessons and CourseOfferings
            modelBuilder.Entity<CourseLessons>()
                .HasOne(cl => cl.CourseOffering)
                .WithMany(co => co.CourseLessons)
                .HasForeignKey(cl => cl.CourseOfferings_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // CourseLessons and SchoolProfile
            modelBuilder.Entity<CourseLessons>()
                .HasOne(cl => cl.School)
                .WithMany(sp => sp.CourseLessons)
                .HasForeignKey(cl => cl.School_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Course and CourseCategories
            modelBuilder.Entity<Course>()
                .HasOne(c => c.CourseCategory)
                .WithMany(cc => cc.Courses)
                .HasForeignKey(c => c.CourseCategories_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassSessions and User
            modelBuilder.Entity<ClassSessions>()
                .HasOne(cs => cs.User)
                .WithMany(u => u.ClassSessions)
                .HasForeignKey(cs => cs.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ClassSessions and Class
            modelBuilder.Entity<ClassSessions>()
                .HasOne(cs => cs.Class)
                .WithMany(c => c.ClassSessions)
                .HasForeignKey(cs => cs.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // PastClasses and User
            modelBuilder.Entity<PastClasses>()
                .HasOne(pc => pc.User)
                .WithMany(u => u.PastClasses)
                .HasForeignKey(pc => pc.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // PastClasses and Subject
            modelBuilder.Entity<PastClasses>()
                .HasOne(pc => pc.Subject)
                .WithMany(s => s.PastClasses)
                .HasForeignKey(pc => pc.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // UpcomingClass and Subject
            modelBuilder.Entity<UpcomingClass>()
                .HasOne(uc => uc.Subject)
                .WithMany(s => s.UpcomingClasses)
                .HasForeignKey(uc => uc.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // UpcomingClass and User
            modelBuilder.Entity<UpcomingClass>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UpcomingClasses)
                .HasForeignKey(uc => uc.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TeacherProfile and Subject
            modelBuilder.Entity<TeacherProfile>()
                .HasOne(tp => tp.Subject)
                .WithMany(s => s.TeacherProfiles)
                .HasForeignKey(tp => tp.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TeacherProfile and Team_Department
            modelBuilder.Entity<TeacherProfile>()
                .HasOne(tp => tp.Department)
                .WithMany(td => td.TeacherProfiles)
                .HasForeignKey(tp => tp.Department_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TeacherProfile and User
            modelBuilder.Entity<TeacherProfile>()
                .HasOne(tp => tp.User)
                .WithMany(u => u.TeacherProfiles)
                .HasForeignKey(tp => tp.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TeacherProfile and SchoolYear
            modelBuilder.Entity<TeacherProfile>()
                .HasOne(tp => tp.SchoolYear)
                .WithMany(sy => sy.TeacherProfiles)
                .HasForeignKey(tp => tp.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TeacherProfile and Class
            modelBuilder.Entity<TeacherProfile>()
                .HasOne(tp => tp.Class)
                .WithMany(c => c.TeacherProfiles)
                .HasForeignKey(tp => tp.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LearningOutcomes and Score
            modelBuilder.Entity<LearningOutcomes>()
                .HasOne(lo => lo.Score)
                .WithMany(s => s.LearningOutcomes)
                .HasForeignKey(lo => lo.Score_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LearningOutcomes and User
            modelBuilder.Entity<LearningOutcomes>()
                .HasOne(lo => lo.User)
                .WithMany(u => u.LearningOutcomes)
                .HasForeignKey(lo => lo.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LearningOutcomes and SchoolYear
            modelBuilder.Entity<LearningOutcomes>()
                .HasOne(lo => lo.SchoolYear)
                .WithMany(sy => sy.LearningOutcomes)
                .HasForeignKey(lo => lo.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Faculty_StudyBlock and User
            modelBuilder.Entity<Faculty_StudyBlock>()
                .HasOne(fsb => fsb.User)
                .WithMany(u => u.FacultyStudyBlocks)
                .HasForeignKey(fsb => fsb.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Faculty_StudyBlock and SchoolProfile
            modelBuilder.Entity<Faculty_StudyBlock>()
                .HasOne(fsb => fsb.School)
                .WithMany(sp => sp.FacultyStudyBlocks)
                .HasForeignKey(fsb => fsb.School_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Faculty_StudyBlock and SchoolYear
            modelBuilder.Entity<Faculty_StudyBlock>()
                .HasOne(fsb => fsb.SchoolYear)
                .WithMany(sy => sy.FacultyStudyBlocks)
                .HasForeignKey(fsb => fsb.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Score and Subject
            modelBuilder.Entity<Score>()
                .HasOne(s => s.Subject)
                .WithMany(sub => sub.Scores)
                .HasForeignKey(s => s.Subjects_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Score and Class
            modelBuilder.Entity<Score>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Scores)
                .HasForeignKey(s => s.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Score and SchoolYear
            modelBuilder.Entity<Score>()
                .HasOne(s => s.SchoolYear)
                .WithMany(sy => sy.Scores)
                .HasForeignKey(s => s.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Grades and User
            modelBuilder.Entity<Grades>()
                .HasOne(g => g.User)
                .WithMany(u => u.Grades)
                .HasForeignKey(g => g.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Grades and TrainingLevels
            modelBuilder.Entity<Grades>()
                .HasOne(g => g.TrainingLevel)
                .WithMany(tl => tl.Grades)
                .HasForeignKey(g => g.Training_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Grades and SchoolYear
            modelBuilder.Entity<Grades>()
                .HasOne(g => g.SchoolYear)
                .WithMany(sy => sy.Grades)
                .HasForeignKey(g => g.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // TrainingLevels and SchoolYear
            modelBuilder.Entity<TrainingLevels>()
                .HasOne(tl => tl.SchoolYear)
                .WithMany(sy => sy.TrainingLevels)
                .HasForeignKey(tl => tl.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Student_Grades and User
            modelBuilder.Entity<Student_Grades>()
                .HasOne(sg => sg.User)
                .WithMany(u => u.StudentGrades)
                .HasForeignKey(sg => sg.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Teaching_Assessment and Class
            modelBuilder.Entity<Teaching_Assessment>()
                .HasOne(ta => ta.Class)
                .WithMany(c => c.TeachingAssessments)
                .HasForeignKey(ta => ta.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Teaching_Assessment and Subject
            modelBuilder.Entity<Teaching_Assessment>()
                .HasOne(ta => ta.Subject)
                .WithMany(s => s.TeachingAssessments)
                .HasForeignKey(ta => ta.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Teaching_Assessment and User
            modelBuilder.Entity<Teaching_Assessment>()
                .HasOne(ta => ta.User)
                .WithMany(u => u.TeachingAssessments)
                .HasForeignKey(ta => ta.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Teaching_Assessment and SchoolYear
            modelBuilder.Entity<Teaching_Assessment>()
                .HasOne(ta => ta.SchoolYear)
                .WithMany(sy => sy.TeachingAssessments)
                .HasForeignKey(ta => ta.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // AssessmentParts and Assignments
            modelBuilder.Entity<AssessmentParts>()
                .HasOne(ap => ap.Assignment)
                .WithMany(a => a.AssessmentParts)
                .HasForeignKey(ap => ap.Assignment_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Student_Submissions and AssessmentParts
            modelBuilder.Entity<Student_Submissions>()
                .HasOne(ss => ss.AssessmentPart)
                .WithMany(ap => ap.StudentSubmissions)
                .HasForeignKey(ss => ss.AssessmentParts_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Student_Submissions and User
            modelBuilder.Entity<Student_Submissions>()
                .HasOne(ss => ss.User)
                .WithMany(u => u.StudentSubmissions)
                .HasForeignKey(ss => ss.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Student_Submissions and SchoolYear
            modelBuilder.Entity<Student_Submissions>()
                .HasOne(ss => ss.SchoolYear)
                .WithMany(sy => sy.StudentSubmissions)
                .HasForeignKey(ss => ss.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Assignment_Group (Junction Table)
            modelBuilder.Entity<Assignment_Group>()
                .HasKey(ag => new { ag.Assignments_ID, ag.Class_ID });

            modelBuilder.Entity<Assignment_Group>()
                .HasOne(ag => ag.Assignment)
                .WithMany(a => a.Assignment_Groups)
                .HasForeignKey(ag => ag.Assignments_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Assignment_Group>()
                .HasOne(ag => ag.Class)
                .WithMany(c => c.Assignment_Groups)
                .HasForeignKey(ag => ag.Class_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Assignments and Teaching_Assessment
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.TeachingAssessment)
                .WithMany(ta => ta.Assignments)
                .HasForeignKey(a => a.Teaching_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Assignments and Faculty_StudyBlock
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Faculty)
                .WithMany(fsb => fsb.Assignments)
                .HasForeignKey(a => a.Faculty_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LabScheduleClasses (Junction Table)
            modelBuilder.Entity<LabScheduleClasses>()
                .HasKey(lsc => new { lsc.LabSchedules_ID, lsc.Class_ID });

            modelBuilder.Entity<LabScheduleClasses>()
                .HasOne(lsc => lsc.LabSchedule)
                .WithMany(ls => ls.LabScheduleClasses)
                .HasForeignKey(lsc => lsc.LabSchedules_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LabScheduleClasses>()
                .HasOne(lsc => lsc.Class)
                .WithMany(c => c.LabScheduleClasses)
                .HasForeignKey(lsc => lsc.Class_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // LabSchedules and Subject
            modelBuilder.Entity<LabSchedules>()
                .HasOne(ls => ls.Subject)
                .WithMany(s => s.LabSchedules)
                .HasForeignKey(ls => ls.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LabSchedules and User
            modelBuilder.Entity<LabSchedules>()
                .HasOne(ls => ls.User)
                .WithMany(u => u.LabSchedules)
                .HasForeignKey(ls => ls.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LabSchedules and SchoolYear
            modelBuilder.Entity<LabSchedules>()
                .HasOne(ls => ls.SchoolYear)
                .WithMany(sy => sy.LabSchedules)
                .HasForeignKey(ls => ls.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LabGraders (Junction Table)
            modelBuilder.Entity<LabGraders>()
                .HasKey(lg => new { lg.LabSchedules_ID, lg.User_ID });

            modelBuilder.Entity<LabGraders>()
                .HasOne(lg => lg.LabSchedule)
                .WithMany(ls => ls.LabGraders)
                .HasForeignKey(lg => lg.LabSchedules_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LabGraders>()
                .HasOne(lg => lg.User)
                .WithMany(u => u.LabGraders)
                .HasForeignKey(lg => lg.User_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // AssessmentQuestions and Questions
            modelBuilder.Entity<AssessmentQuestions>()
                .HasOne(aq => aq.Question)
                .WithMany(q => q.AssessmentQuestions)
                .HasForeignKey(aq => aq.Questions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Questions and User
            modelBuilder.Entity<Question>()
                .HasOne(q => q.User)
                .WithMany(u => u.Questions)
                .HasForeignKey(q => q.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Questions and Subject
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Subject)
                .WithMany(s => s.Questions)
                .HasForeignKey(q => q.Subject_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // QuestionOptions and Questions
            modelBuilder.Entity<QuestionOptions>()
                .HasOne(qo => qo.Question)
                .WithMany(q => q.QuestionOptions)
                .HasForeignKey(qo => qo.Questions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // WorkHistories and User
            modelBuilder.Entity<WorkHistories>()
                .HasOne(wh => wh.User)
                .WithMany(u => u.WorkHistories)
                .HasForeignKey(wh => wh.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // WorkHistories and SchoolYear
            modelBuilder.Entity<WorkHistories>()
                .HasOne(wh => wh.SchoolYear)
                .WithMany(sy => sy.WorkHistories)
                .HasForeignKey(wh => wh.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // WorkHistories and Class
            modelBuilder.Entity<WorkHistories>()
                .HasOne(wh => wh.Class)
                .WithMany(c => c.WorkHistories)
                .HasForeignKey(wh => wh.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employment_History and User (CreatedByID)
            modelBuilder.Entity<Employment_History>()
                .HasOne(eh => eh.CreatedByUser)
                .WithMany(u => u.EmploymentHistoriesCreated)
                .HasForeignKey(eh => eh.CreatedByID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employment_History and User (User_ID)
            modelBuilder.Entity<Employment_History>()
                .HasOne(eh => eh.User)
                .WithMany(u => u.EmploymentHistories)
                .HasForeignKey(eh => eh.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Qualifications and User
            modelBuilder.Entity<Qualification>()
                .HasOne(q => q.User)
                .WithMany(u => u.Qualifications)
                .HasForeignKey(q => q.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

             
            // Qualifications and SchoolYear
            modelBuilder.Entity<Qualification>()
                .HasOne(q => q.SchoolYear)
                .WithMany(sy => sy.Qualifications)
                .HasForeignKey(q => q.SchoolYear_ID) 
                .OnDelete(DeleteBehavior.Restrict);

            // Syllabus_topics and Teaching_Assessment
            modelBuilder.Entity<Syllabus_topics>()
                .HasOne(st => st.TeachingAssessment)
                .WithMany(ta => ta.SyllabusTopics)
                .HasForeignKey(st => st.Teaching_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Syllabus_topics and SchoolYear
            modelBuilder.Entity<Syllabus_topics>()
                .HasOne(st => st.SchoolYear)
                .WithMany(sy => sy.SyllabusTopics)
                .HasForeignKey(st => st.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LiveSessions and Teaching_Assessment
            modelBuilder.Entity<LiveSessions>()
                .HasOne(ls => ls.TeachingAssessment)
                .WithMany(ta => ta.LiveSessions)
                .HasForeignKey(ls => ls.Teaching_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LiveChatMessages and LiveSessions
            modelBuilder.Entity<LiveChatMessages>()
                .HasOne(lcm => lcm.LiveSession)
                .WithMany(ls => ls.LiveChatMessages)
                .HasForeignKey(lcm => lcm.LiveSessions_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // LiveChatMessages and User
            modelBuilder.Entity<LiveChatMessages>()
                .HasOne(lcm => lcm.User)
                .WithMany(u => u.LiveChatMessages)
                .HasForeignKey(lcm => lcm.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ThreadPosts and DiscussionThreads
            modelBuilder.Entity<ThreadPosts>()
                .HasOne(tp => tp.DiscussionThread)
                .WithMany(dt => dt.ThreadPosts)
                .HasForeignKey(tp => tp.Discussion_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // ThreadPosts and User
            modelBuilder.Entity<ThreadPosts>()
                .HasOne(tp => tp.User)
                .WithMany(u => u.ThreadPosts)
                .HasForeignKey(tp => tp.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // DiscussionThreads and User
            modelBuilder.Entity<DiscussionThreads>()
                .HasOne(dt => dt.User)
                .WithMany(u => u.DiscussionThreads)
                .HasForeignKey(dt => dt.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // DiscussionThreads and Teaching_Assessment
            modelBuilder.Entity<DiscussionThreads>()
                .HasOne(dt => dt.TeachingAssessment)
                .WithMany(ta => ta.DiscussionThreads)
                .HasForeignKey(dt => dt.Teaching_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsProfile and Class
            modelBuilder.Entity<StudentsProfile>()
                .HasOne(sp => sp.Class)
                .WithMany(c => c.StudentsProfiles)
                .HasForeignKey(sp => sp.Class_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsProfile and Team_Department
            modelBuilder.Entity<StudentsProfile>()
                .HasOne(sp => sp.Department)
                .WithMany(td => td.StudentsProfiles)
                .HasForeignKey(sp => sp.Department_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsProfile and User
            modelBuilder.Entity<StudentsProfile>()
                .HasOne(sp => sp.User)
                .WithMany(u => u.StudentsProfiles)
                .HasForeignKey(sp => sp.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentsProfile and SchoolYear
            modelBuilder.Entity<StudentsProfile>()
                .HasOne(sp => sp.SchoolYear)
                .WithMany(sy => sy.StudentsProfiles)
                .HasForeignKey(sp => sp.SchoolYear_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}