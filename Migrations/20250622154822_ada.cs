using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ISC_BE02.Migrations
{
    public partial class ada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassroomSettings",
                columns: table => new
                {
                    ClassroomSettings_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomSettings", x => x.ClassroomSettings_ID);
                });

            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    ClassType_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassTypeName = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.ClassType_ID);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseCategories_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseCategoriesName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => x.CourseCategories_ID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Permissions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Feature_name = table.Column<string>(type: "text", nullable: false),
                    Action_name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Permissions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Is_admin = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectType",
                columns: table => new
                {
                    SubjectType_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectTypeName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectType", x => x.SubjectType_ID);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    Setting_key = table.Column<string>(type: "text", nullable: false),
                    Setting_value = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.Setting_key);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Group_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Group_ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Courses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Syllabus = table.Column<string>(type: "text", nullable: false),
                    Default_price = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    Courses_image_url = table.Column<string>(type: "text", nullable: false),
                    CourseCategories_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Courses_ID);
                    table.ForeignKey(
                        name: "FK_Courses_CourseCategories_CourseCategories_ID",
                        column: x => x.CourseCategories_ID,
                        principalTable: "CourseCategories",
                        principalColumn: "CourseCategories_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "integer", nullable: false),
                    Permissions_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.Role_ID, x.Permissions_ID });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_Permissions_ID",
                        column: x => x.Permissions_ID,
                        principalTable: "Permissions",
                        principalColumn: "Permissions_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Role_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Role",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decentralization",
                columns: table => new
                {
                    Decentralization_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DecentralizationName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Is_True = table.Column<bool>(type: "boolean", nullable: false),
                    Group_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decentralization", x => x.Decentralization_ID);
                    table.ForeignKey(
                        name: "FK_Decentralization_UserGroup_Group_ID",
                        column: x => x.Group_ID,
                        principalTable: "UserGroup",
                        principalColumn: "Group_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcceptingSchoolTransfers",
                columns: table => new
                {
                    AcceptingSchoolTransfers_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Move_in_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SemesterMoveIn = table.Column<int>(type: "integer", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    Convert_from = table.Column<string>(type: "text", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptingSchoolTransfers", x => x.AcceptingSchoolTransfers_ID);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentParts",
                columns: table => new
                {
                    AssessmentParts_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Part_order = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Assignment_url = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Assignment_ID = table.Column<int>(type: "integer", nullable: false),
                    Teaching_AssessmentTeaching_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentParts", x => x.AssessmentParts_ID);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestions",
                columns: table => new
                {
                    AssessmentQuestions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question_order = table.Column<int>(type: "integer", nullable: false),
                    Questions_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestions", x => x.AssessmentQuestions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Assignment_Group",
                columns: table => new
                {
                    Assignments_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment_Group", x => new { x.Assignments_ID, x.Class_ID });
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Assignment_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Format = table.Column<int>(type: "integer", nullable: false),
                    Assignment_scope = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Assignment_Url = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PartitionType = table.Column<int>(type: "integer", nullable: false),
                    CraeteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false),
                    Faculty_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Assignment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    Campuses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Manager_name = table.Column<string>(type: "text", nullable: false),
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.Campuses_ID);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassName = table.Column<int>(type: "integer", nullable: false),
                    ClassCode = table.Column<string>(type: "text", nullable: false),
                    ClassPassword = table.Column<string>(type: "text", nullable: false),
                    StudentNumber = table.Column<int>(type: "integer", nullable: false),
                    ClassClassification = table.Column<int>(type: "integer", nullable: false),
                    FileClassURL = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Number_of_sessions = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClassURL = table.Column<string>(type: "text", nullable: false),
                    Join_code = table.Column<string>(type: "text", nullable: false),
                    Join_password = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false),
                    ClassroomSettings_ID = table.Column<int>(type: "integer", nullable: false),
                    ClassType_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Class_ID);
                    table.ForeignKey(
                        name: "FK_Class_ClassroomSettings_ClassroomSettings_ID",
                        column: x => x.ClassroomSettings_ID,
                        principalTable: "ClassroomSettings",
                        principalColumn: "ClassroomSettings_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_ClassType_ClassType_ID",
                        column: x => x.ClassType_ID,
                        principalTable: "ClassType",
                        principalColumn: "ClassType_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class_Detail",
                columns: table => new
                {
                    Detail_Class_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Admission_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    NumberOfSubjects = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Student_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Detail", x => x.Detail_Class_ID);
                    table.ForeignKey(
                        name: "FK_Class_Detail_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassHistory",
                columns: table => new
                {
                    History_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Decription = table.Column<string>(type: "text", nullable: false),
                    TotalSessisons = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassHistory", x => x.History_ID);
                    table.ForeignKey(
                        name: "FK_ClassHistory_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassHistorySession",
                columns: table => new
                {
                    SessisonHistory_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SessisonTotal = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    History_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassHistorySession", x => x.SessisonHistory_ID);
                    table.ForeignKey(
                        name: "FK_ClassHistorySession_ClassHistory_History_ID",
                        column: x => x.History_ID,
                        principalTable: "ClassHistory",
                        principalColumn: "History_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassSessions",
                columns: table => new
                {
                    Session_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Topic = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Duration_hours = table.Column<int>(type: "integer", nullable: false),
                    Duration_minutes = table.Column<int>(type: "integer", nullable: false),
                    StartDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPrivate = table.Column<bool>(type: "boolean", nullable: false),
                    AutoStart = table.Column<bool>(type: "boolean", nullable: false),
                    EnableRecording = table.Column<bool>(type: "boolean", nullable: false),
                    AllowSharing = table.Column<bool>(type: "boolean", nullable: false),
                    ShareLink = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSessions", x => x.Session_ID);
                    table.ForeignKey(
                        name: "FK_ClassSessions_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseLessons",
                columns: table => new
                {
                    CourseLessons_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LessonTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RoomNumber = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: false),
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLessons", x => x.CourseLessons_ID);
                });

            migrationBuilder.CreateTable(
                name: "CourseOfferings",
                columns: table => new
                {
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaxStudent = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Courses_ID = table.Column<int>(type: "integer", nullable: false),
                    Instructor_user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseOfferings", x => x.CourseOfferings_ID);
                    table.ForeignKey(
                        name: "FK_CourseOfferings_Courses_Courses_ID",
                        column: x => x.Courses_ID,
                        principalTable: "Courses",
                        principalColumn: "Courses_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoursesLearned",
                columns: table => new
                {
                    CoursesLearned_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Syllabus = table.Column<string>(type: "text", nullable: false),
                    Default_price = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    Courses_image_url = table.Column<string>(type: "text", nullable: false),
                    TotalCourses_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesLearned", x => x.CoursesLearned_ID);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Discipline_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisciplineDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    DisciplineRewardURL = table.Column<string>(type: "text", nullable: false),
                    Decision_day = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Discipline_ID);
                    table.ForeignKey(
                        name: "FK_Discipline_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiscussionThreads",
                columns: table => new
                {
                    Discussion_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Visibility = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Is_resolved = table.Column<bool>(type: "boolean", nullable: false),
                    View_count = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionThreads", x => x.Discussion_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employment_History",
                columns: table => new
                {
                    History_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Effective_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Certificate = table.Column<string>(type: "text", nullable: false),
                    Form = table.Column<string>(type: "text", nullable: false),
                    DecidedRetireURL = table.Column<string>(type: "text", nullable: false),
                    CreatedByID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_History", x => x.History_ID);
                });

            migrationBuilder.CreateTable(
                name: "Exemptions",
                columns: table => new
                {
                    Exemptions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExemptionObjects = table.Column<int>(type: "integer", nullable: false),
                    FormExemption = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemptions", x => x.Exemptions_ID);
                    table.ForeignKey(
                        name: "FK_Exemptions_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty - StudyBlock",
                columns: table => new
                {
                    Faculty_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FacultyName = table.Column<int>(type: "integer", nullable: false),
                    FacultyCode = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    School_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty - StudyBlock", x => x.Faculty_ID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Grade_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GradesName = table.Column<string>(type: "text", nullable: false),
                    GradesCode = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Training_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Grade_ID);
                });

            migrationBuilder.CreateTable(
                name: "LabGraders",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabGraders", x => new { x.LabSchedules_ID, x.User_ID });
                });

            migrationBuilder.CreateTable(
                name: "LabScheduleClasses",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabScheduleClasses", x => new { x.LabSchedules_ID, x.Class_ID });
                    table.ForeignKey(
                        name: "FK_LabScheduleClasses_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabSchedules",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Term_number = table.Column<int>(type: "integer", nullable: false),
                    Lab_name = table.Column<string>(type: "text", nullable: false),
                    Lab_start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Lab_end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Duration_minutes = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabSchedules", x => x.LabSchedules_ID);
                });

            migrationBuilder.CreateTable(
                name: "LearningOutcomes",
                columns: table => new
                {
                    LearningOutcomes_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Conduct = table.Column<string>(type: "text", nullable: false),
                    Average_score = table.Column<int>(type: "integer", nullable: false),
                    AcademicPerformance = table.Column<bool>(type: "boolean", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Score_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningOutcomes", x => x.LearningOutcomes_ID);
                });

            migrationBuilder.CreateTable(
                name: "LiveChatMessages",
                columns: table => new
                {
                    LiveChatMessages_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message_content = table.Column<string>(type: "text", nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Recording_url = table.Column<string>(type: "text", nullable: false),
                    LiveSessions_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveChatMessages", x => x.LiveChatMessages_ID);
                });

            migrationBuilder.CreateTable(
                name: "LiveSessions",
                columns: table => new
                {
                    LiveSessions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Scheduled_start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Actual_start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Actual_end_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Recording_url = table.Column<string>(type: "text", nullable: false),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveSessions", x => x.LiveSessions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Notification_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReceivingObject = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Notification_ID);
                });

            migrationBuilder.CreateTable(
                name: "PastClasses",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastClasses", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Qualifications_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Institution = table.Column<string>(type: "text", nullable: false),
                    Major = table.Column<string>(type: "text", nullable: false),
                    Study_form = table.Column<string>(type: "text", nullable: false),
                    StarTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Endtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Degree_name = table.Column<string>(type: "text", nullable: false),
                    Attachment_url = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Qualifications_ID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    QuestionOptions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Questions_ID = table.Column<int>(type: "integer", nullable: false),
                    Option_text = table.Column<string>(type: "text", nullable: false),
                    Is_correct = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.QuestionOptions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Questions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Questions_Text = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    QuestionsType = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Questions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Registrations_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Registration_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CourserName = table.Column<string>(type: "text", nullable: false),
                    Campus = table.Column<string>(type: "text", nullable: false),
                    StudentName = table.Column<string>(type: "text", nullable: false),
                    BirdDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sex = table.Column<int>(type: "integer", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    Education_level = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Payment_status = table.Column<int>(type: "integer", nullable: false),
                    Registrations_Image_Url = table.Column<string>(type: "text", nullable: false),
                    Student_user_id = table.Column<int>(type: "integer", nullable: false),
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Registrations_ID);
                    table.ForeignKey(
                        name: "FK_Registrations_CourseOfferings_CourseOfferings_ID",
                        column: x => x.CourseOfferings_ID,
                        principalTable: "CourseOfferings",
                        principalColumn: "CourseOfferings_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reserved",
                columns: table => new
                {
                    Reason_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    DateReserved = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReservedPeriod = table.Column<int>(type: "integer", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_IDPresent = table.Column<int>(type: "integer", nullable: false),
                    Class_IDMoveTo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserved", x => x.Reason_ID);
                    table.ForeignKey(
                        name: "FK_Reserved_Class_Class_IDMoveTo",
                        column: x => x.Class_IDMoveTo,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserved_Class_Class_IDPresent",
                        column: x => x.Class_IDPresent,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    Reward_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RewardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    DecisionRewardURL = table.Column<string>(type: "text", nullable: false),
                    Decision_day = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Reward_ID);
                    table.ForeignKey(
                        name: "FK_Reward_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolProfile",
                columns: table => new
                {
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolName = table.Column<string>(type: "text", nullable: false),
                    SchoolCode = table.Column<string>(type: "text", nullable: false),
                    ProvinceCity = table.Column<string>(type: "text", nullable: false),
                    CommuneWard = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    Head_office = table.Column<string>(type: "text", nullable: false),
                    SchoolType = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    PhoneFax = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DateEstablishment = table.Column<string>(type: "text", nullable: false),
                    Training_model = table.Column<string>(type: "text", nullable: false),
                    Webside = table.Column<string>(type: "text", nullable: false),
                    PrincipalName = table.Column<string>(type: "text", nullable: false),
                    PhonePrincipal = table.Column<string>(type: "text", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolProfile", x => x.School_ID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolYearName = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.SchoolYear_ID);
                    table.ForeignKey(
                        name: "FK_SchoolYear_SchoolProfile_School_ID",
                        column: x => x.School_ID,
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    Semester_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemesterName = table.Column<string>(type: "text", nullable: false),
                    LessonOfSemester = table.Column<int>(type: "integer", nullable: false),
                    StartTimeSemester = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTimeSemester = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Is_Current = table.Column<bool>(type: "boolean", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.Semester_ID);
                    table.ForeignKey(
                        name: "FK_Semester_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingLevels",
                columns: table => new
                {
                    Training_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingName = table.Column<string>(type: "text", nullable: false),
                    TrainingForm = table.Column<string>(type: "text", nullable: false),
                    Is_credit_based = table.Column<bool>(type: "boolean", nullable: false),
                    Is_credit_year_based = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Duration_years = table.Column<int>(type: "integer", nullable: false),
                    Required_credits = table.Column<int>(type: "integer", nullable: false),
                    Elective_credits = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Is_active = table.Column<bool>(type: "boolean", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingLevels", x => x.Training_ID);
                    table.ForeignKey(
                        name: "FK_TrainingLevels_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    EmailEmail = table.Column<string>(type: "text", nullable: false),
                    AvatarURL = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    History_ID = table.Column<int>(type: "integer", nullable: true),
                    Group_ID = table.Column<int>(type: "integer", nullable: false),
                    Role_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_User_ClassHistory_History_ID",
                        column: x => x.History_ID,
                        principalTable: "ClassHistory",
                        principalColumn: "History_ID");
                    table.ForeignKey(
                        name: "FK_User_Role_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Role",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserGroup_Group_ID",
                        column: x => x.Group_ID,
                        principalTable: "UserGroup",
                        principalColumn: "Group_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student_Grades",
                columns: table => new
                {
                    Student_Grades_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Submission_id = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<double>(type: "double precision", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    Graded_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Grades", x => x.Student_Grades_ID);
                    table.ForeignKey(
                        name: "FK_Student_Grades_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student_Submissions",
                columns: table => new
                {
                    Submissions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Submission_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    File_url = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    Text_answer = table.Column<string>(type: "text", nullable: false),
                    AssessmentParts_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Submissions", x => x.Submissions_ID);
                    table.ForeignKey(
                        name: "FK_Student_Submissions_AssessmentParts_AssessmentParts_ID",
                        column: x => x.AssessmentParts_ID,
                        principalTable: "AssessmentParts",
                        principalColumn: "AssessmentParts_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Submissions_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Submissions_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsChangeClasses",
                columns: table => new
                {
                    StudentsChangeClasses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    Class_IDPresent = table.Column<int>(type: "integer", nullable: false),
                    Class_IDMoveTo = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsChangeClasses", x => x.StudentsChangeClasses_ID);
                    table.ForeignKey(
                        name: "FK_StudentsChangeClasses_Class_Class_IDMoveTo",
                        column: x => x.Class_IDMoveTo,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsChangeClasses_Class_Class_IDPresent",
                        column: x => x.Class_IDPresent,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsChangeClasses_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsChangeSchool",
                columns: table => new
                {
                    StudentsChangeSchool_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    NameSchoolTransferred = table.Column<int>(type: "integer", nullable: false),
                    AddressSchoolTransferred = table.Column<int>(type: "integer", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsChangeSchool", x => x.StudentsChangeSchool_ID);
                    table.ForeignKey(
                        name: "FK_StudentsChangeSchool_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsChangeSchool_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team-Department",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentName = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team-Department", x => x.Department_ID);
                    table.ForeignKey(
                        name: "FK_Team-Department_SchoolProfile_School_ID",
                        column: x => x.School_ID,
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team-Department_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team-Department_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThreadPosts",
                columns: table => new
                {
                    ThreadPosts_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Attachment_url = table.Column<string>(type: "text", nullable: false),
                    Discussion_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadPosts", x => x.ThreadPosts_ID);
                    table.ForeignKey(
                        name: "FK_ThreadPosts_DiscussionThreads_Discussion_ID",
                        column: x => x.Discussion_ID,
                        principalTable: "DiscussionThreads",
                        principalColumn: "Discussion_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThreadPosts_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TotalCoursesTaken",
                columns: table => new
                {
                    TotalCourses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalNumberCourses = table.Column<int>(type: "integer", nullable: false),
                    TotalPayment = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    CoursesLearned_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalCoursesTaken", x => x.TotalCourses_ID);
                    table.ForeignKey(
                        name: "FK_TotalCoursesTaken_CoursesLearned_CoursesLearned_ID",
                        column: x => x.CoursesLearned_ID,
                        principalTable: "CoursesLearned",
                        principalColumn: "CoursesLearned_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalCoursesTaken_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                columns: table => new
                {
                    Word_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Organization_name = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    StarTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Endtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CertificateName = table.Column<string>(type: "text", nullable: false),
                    TrainingType = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistories", x => x.Word_ID);
                    table.ForeignKey(
                        name: "FK_WorkHistories_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkHistories_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkHistories_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentMCQAnswers",
                columns: table => new
                {
                    StudentMCQAnswers_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Submissions_ID = table.Column<int>(type: "integer", nullable: false),
                    Questions_ID = table.Column<int>(type: "integer", nullable: false),
                    QuestionOptions_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMCQAnswers", x => x.StudentMCQAnswers_ID);
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers_QuestionOptions_QuestionOptions_ID",
                        column: x => x.QuestionOptions_ID,
                        principalTable: "QuestionOptions",
                        principalColumn: "QuestionOptions_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers_Questions_Questions_ID",
                        column: x => x.Questions_ID,
                        principalTable: "Questions",
                        principalColumn: "Questions_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers_Student_Submissions_Submissions_ID",
                        column: x => x.Submissions_ID,
                        principalTable: "Student_Submissions",
                        principalColumn: "Submissions_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "StudentsProfile",
                columns: table => new
                {
                    StudentsProfile_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentName = table.Column<string>(type: "text", nullable: false),
                    StudentCode = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sex = table.Column<int>(type: "integer", nullable: false),
                    Nation = table.Column<string>(type: "text", nullable: false),
                    PlaceOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Religion = table.Column<string>(type: "text", nullable: false),
                    Admission_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Form = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    NumberRewards = table.Column<int>(type: "integer", nullable: false),
                    NumberDisciplinaryActions = table.Column<int>(type: "integer", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsProfile", x => x.StudentsProfile_ID);
                    table.ForeignKey(
                        name: "FK_StudentsProfile_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsProfile_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsProfile_Team-Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsProfile_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Subjects_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectCode = table.Column<string>(type: "text", nullable: false),
                    SubjectsName = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SubjectType_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Subjects_ID);
                    table.ForeignKey(
                        name: "FK_Subjects_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectType_SubjectType_ID",
                        column: x => x.SubjectType_ID,
                        principalTable: "SubjectType",
                        principalColumn: "SubjectType_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Team-Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Score_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScoreType = table.Column<string>(type: "text", nullable: false),
                    Coefficient = table.Column<int>(type: "integer", nullable: false),
                    ScoreNumber = table.Column<int>(type: "integer", nullable: false),
                    AverageScore = table.Column<int>(type: "integer", nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    Subjects_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Score_ID);
                    table.ForeignKey(
                        name: "FK_Score_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Score_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Score_Subjects_Subjects_ID",
                        column: x => x.Subjects_ID,
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects_Class",
                columns: table => new
                {
                    Subjects_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects_Class", x => new { x.Subjects_ID, x.Class_ID });
                    table.ForeignKey(
                        name: "FK_Subjects_Class_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_Class_Subjects_Subjects_ID",
                        column: x => x.Subjects_ID,
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherProfile",
                columns: table => new
                {
                    Teacher_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    TeacherName = table.Column<string>(type: "text", nullable: false),
                    TeacherCode = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    Member = table.Column<bool>(type: "boolean", nullable: false),
                    Party_member = table.Column<bool>(type: "boolean", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nation = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PlaceOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Religion = table.Column<string>(type: "text", nullable: false),
                    Admission_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Form = table.Column<int>(type: "integer", nullable: false),
                    Addres = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    NumberRewards = table.Column<int>(type: "integer", nullable: false),
                    NumberDisciplinaryActions = table.Column<int>(type: "integer", nullable: false),
                    FileURL = table.Column<string>(type: "text", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherProfile", x => x.Teacher_ID);
                    table.ForeignKey(
                        name: "FK_TeacherProfile_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherProfile_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherProfile_Subjects_Subject_ID",
                        column: x => x.Subject_ID,
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherProfile_Team-Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherProfile_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teaching_Assessment",
                columns: table => new
                {
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssignmentType = table.Column<int>(type: "integer", nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Class_ID = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teaching_Assessment", x => x.Teaching_ID);
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment_Class_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment_Subjects_Subject_ID",
                        column: x => x.Subject_ID,
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpcomingClass",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Subject_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingClass", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_UpcomingClass_Subjects_Subject_ID",
                        column: x => x.Subject_ID,
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpcomingClass_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syllabus_topics",
                columns: table => new
                {
                    Syllabus_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false),
                    Topic_title = table.Column<string>(type: "text", nullable: false),
                    Order_index = table.Column<int>(type: "integer", nullable: false),
                    StarTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syllabus_topics", x => x.Syllabus_ID);
                    table.ForeignKey(
                        name: "FK_Syllabus_topics_SchoolYear_SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYear_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syllabus_topics_Teaching_Assessment_Teaching_ID",
                        column: x => x.Teaching_ID,
                        principalTable: "Teaching_Assessment",
                        principalColumn: "Teaching_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptingSchoolTransfers_SchoolYear_ID",
                table: "AcceptingSchoolTransfers",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptingSchoolTransfers_User_ID",
                table: "AcceptingSchoolTransfers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentParts_Assignment_ID",
                table: "AssessmentParts",
                column: "Assignment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentParts_Teaching_AssessmentTeaching_ID",
                table: "AssessmentParts",
                column: "Teaching_AssessmentTeaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestions_Questions_ID",
                table: "AssessmentQuestions",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Group_Class_ID",
                table: "Assignment_Group",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Faculty_ID",
                table: "Assignments",
                column: "Faculty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Teaching_ID",
                table: "Assignments",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Campuses_School_ID",
                table: "Campuses",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassroomSettings_ID",
                table: "Class",
                column: "ClassroomSettings_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassType_ID",
                table: "Class",
                column: "ClassType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Department_ID",
                table: "Class",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SchoolYear_ID",
                table: "Class",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_User_ID",
                table: "Class",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_Class_ID",
                table: "Class_Detail",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_Department_ID",
                table: "Class_Detail",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_SchoolYear_ID",
                table: "Class_Detail",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_Student_ID",
                table: "Class_Detail",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_User_ID",
                table: "Class_Detail",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_Class_ID",
                table: "ClassHistory",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_SchoolYear_ID",
                table: "ClassHistory",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_Subject_ID",
                table: "ClassHistory",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_User_ID",
                table: "ClassHistory",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_User_ID1",
                table: "ClassHistory",
                column: "User_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistorySession_History_ID",
                table: "ClassHistorySession",
                column: "History_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSessions_Class_ID",
                table: "ClassSessions",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSessions_User_ID",
                table: "ClassSessions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseOfferings_ID",
                table: "CourseLessons",
                column: "CourseOfferings_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_School_ID",
                table: "CourseLessons",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOfferings_Courses_ID",
                table: "CourseOfferings",
                column: "Courses_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOfferings_Instructor_user_id",
                table: "CourseOfferings",
                column: "Instructor_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCategories_ID",
                table: "Courses",
                column: "CourseCategories_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLearned_SchoolYear_ID",
                table: "CoursesLearned",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLearned_TotalCourses_ID",
                table: "CoursesLearned",
                column: "TotalCourses_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Decentralization_Group_ID",
                table: "Decentralization",
                column: "Group_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_Class_ID",
                table: "Discipline",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_SchoolYear_ID",
                table: "Discipline",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_User_ID",
                table: "Discipline",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionThreads_Teaching_ID",
                table: "DiscussionThreads",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionThreads_User_ID",
                table: "DiscussionThreads",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_History_CreatedByID",
                table: "Employment_History",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_History_User_ID",
                table: "Employment_History",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exemptions_Class_ID",
                table: "Exemptions",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exemptions_User_ID",
                table: "Exemptions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_School_ID",
                table: "Faculty - StudyBlock",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_SchoolYear_ID",
                table: "Faculty - StudyBlock",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_User_ID",
                table: "Faculty - StudyBlock",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SchoolYear_ID",
                table: "Grades",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_Training_ID",
                table: "Grades",
                column: "Training_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_User_ID",
                table: "Grades",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabGraders_User_ID",
                table: "LabGraders",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabScheduleClasses_Class_ID",
                table: "LabScheduleClasses",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabSchedules_SchoolYear_ID",
                table: "LabSchedules",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabSchedules_Subject_ID",
                table: "LabSchedules",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabSchedules_User_ID",
                table: "LabSchedules",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningOutcomes_SchoolYear_ID",
                table: "LearningOutcomes",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningOutcomes_Score_ID",
                table: "LearningOutcomes",
                column: "Score_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningOutcomes_User_ID",
                table: "LearningOutcomes",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LiveChatMessages_LiveSessions_ID",
                table: "LiveChatMessages",
                column: "LiveSessions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LiveChatMessages_User_ID",
                table: "LiveChatMessages",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LiveSessions_Teaching_ID",
                table: "LiveSessions",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_User_ID",
                table: "Notification",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PastClasses_Subject_ID",
                table: "PastClasses",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PastClasses_User_ID",
                table: "PastClasses",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_SchoolYear_ID",
                table: "Qualifications",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_User_ID",
                table: "Qualifications",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_Questions_ID",
                table: "QuestionOptions",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Subject_ID",
                table: "Questions",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_User_ID",
                table: "Questions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CourseOfferings_ID",
                table: "Registrations",
                column: "CourseOfferings_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_Student_user_id",
                table: "Registrations",
                column: "Student_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_Class_IDMoveTo",
                table: "Reserved",
                column: "Class_IDMoveTo");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_Class_IDPresent",
                table: "Reserved",
                column: "Class_IDPresent");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_User_ID",
                table: "Reserved",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_Class_ID",
                table: "Reward",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_SchoolYear_ID",
                table: "Reward",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_User_ID",
                table: "Reward",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_Permissions_ID",
                table: "RolePermissions",
                column: "Permissions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolProfile_SchoolYear_ID",
                table: "SchoolProfile",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_School_ID",
                table: "SchoolYear",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_User_ID",
                table: "SchoolYear",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_Class_ID",
                table: "Score",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_SchoolYear_ID",
                table: "Score",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_Subjects_ID",
                table: "Score",
                column: "Subjects_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SchoolYear_ID",
                table: "Semester",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grades_User_ID",
                table: "Student_Grades",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Submissions_AssessmentParts_ID",
                table: "Student_Submissions",
                column: "AssessmentParts_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Submissions_SchoolYear_ID",
                table: "Student_Submissions",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Submissions_User_ID",
                table: "Student_Submissions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_QuestionOptions_ID",
                table: "StudentMCQAnswers",
                column: "QuestionOptions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_Questions_ID",
                table: "StudentMCQAnswers",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_Submissions_ID",
                table: "StudentMCQAnswers",
                column: "Submissions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_User_ID",
                table: "StudentMCQAnswers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeClasses_Class_IDMoveTo",
                table: "StudentsChangeClasses",
                column: "Class_IDMoveTo");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeClasses_Class_IDPresent",
                table: "StudentsChangeClasses",
                column: "Class_IDPresent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeClasses_User_ID",
                table: "StudentsChangeClasses",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeSchool_SchoolYear_ID",
                table: "StudentsChangeSchool",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeSchool_User_ID",
                table: "StudentsChangeSchool",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsProfile_Class_ID",
                table: "StudentsProfile",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsProfile_Department_ID",
                table: "StudentsProfile",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsProfile_SchoolYear_ID",
                table: "StudentsProfile",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsProfile_User_ID",
                table: "StudentsProfile",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Department_ID",
                table: "Subjects",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SchoolYear_ID",
                table: "Subjects",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectType_ID",
                table: "Subjects",
                column: "SubjectType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_User_ID",
                table: "Subjects",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Class_Class_ID",
                table: "Subjects_Class",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Syllabus_topics_SchoolYear_ID",
                table: "Syllabus_topics",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Syllabus_topics_Teaching_ID",
                table: "Syllabus_topics",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Class_ID",
                table: "TeacherProfile",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Department_ID",
                table: "TeacherProfile",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_SchoolYear_ID",
                table: "TeacherProfile",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Subject_ID",
                table: "TeacherProfile",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_User_ID",
                table: "TeacherProfile",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_Class_ID",
                table: "Teaching_Assessment",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_SchoolYear_ID",
                table: "Teaching_Assessment",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_Subject_ID",
                table: "Teaching_Assessment",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_User_ID",
                table: "Teaching_Assessment",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Team-Department_School_ID",
                table: "Team-Department",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Team-Department_SchoolYear_ID",
                table: "Team-Department",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Team-Department_User_ID",
                table: "Team-Department",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadPosts_Discussion_ID",
                table: "ThreadPosts",
                column: "Discussion_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadPosts_User_ID",
                table: "ThreadPosts",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalCoursesTaken_CoursesLearned_ID",
                table: "TotalCoursesTaken",
                column: "CoursesLearned_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalCoursesTaken_User_ID",
                table: "TotalCoursesTaken",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingLevels_SchoolYear_ID",
                table: "TrainingLevels",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingClass_Subject_ID",
                table: "UpcomingClass",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingClass_User_ID",
                table: "UpcomingClass",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Group_ID",
                table: "User",
                column: "Group_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_History_ID",
                table: "User",
                column: "History_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_ID",
                table: "User",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_SchoolYear_ID",
                table: "User",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_Class_ID",
                table: "WorkHistories",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_SchoolYear_ID",
                table: "WorkHistories",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_User_ID",
                table: "WorkHistories",
                column: "User_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcceptingSchoolTransfers_SchoolYear_SchoolYear_ID",
                table: "AcceptingSchoolTransfers",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcceptingSchoolTransfers_User_User_ID",
                table: "AcceptingSchoolTransfers",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentParts_Assignments_Assignment_ID",
                table: "AssessmentParts",
                column: "Assignment_ID",
                principalTable: "Assignments",
                principalColumn: "Assignment_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentParts_Teaching_Assessment_Teaching_AssessmentTeac~",
                table: "AssessmentParts",
                column: "Teaching_AssessmentTeaching_ID",
                principalTable: "Teaching_Assessment",
                principalColumn: "Teaching_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentQuestions_Questions_Questions_ID",
                table: "AssessmentQuestions",
                column: "Questions_ID",
                principalTable: "Questions",
                principalColumn: "Questions_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Group_Assignments_Assignments_ID",
                table: "Assignment_Group",
                column: "Assignments_ID",
                principalTable: "Assignments",
                principalColumn: "Assignment_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Group_Class_Class_ID",
                table: "Assignment_Group",
                column: "Class_ID",
                principalTable: "Class",
                principalColumn: "Class_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Faculty - StudyBlock_Faculty_ID",
                table: "Assignments",
                column: "Faculty_ID",
                principalTable: "Faculty - StudyBlock",
                principalColumn: "Faculty_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Teaching_Assessment_Teaching_ID",
                table: "Assignments",
                column: "Teaching_ID",
                principalTable: "Teaching_Assessment",
                principalColumn: "Teaching_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campuses_SchoolProfile_School_ID",
                table: "Campuses",
                column: "School_ID",
                principalTable: "SchoolProfile",
                principalColumn: "School_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_SchoolYear_SchoolYear_ID",
                table: "Class",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Team-Department_Department_ID",
                table: "Class",
                column: "Department_ID",
                principalTable: "Team-Department",
                principalColumn: "Department_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_User_User_ID",
                table: "Class",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Detail_SchoolYear_SchoolYear_ID",
                table: "Class_Detail",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Detail_Team-Department_Department_ID",
                table: "Class_Detail",
                column: "Department_ID",
                principalTable: "Team-Department",
                principalColumn: "Department_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Detail_User_Student_ID",
                table: "Class_Detail",
                column: "Student_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Detail_User_User_ID",
                table: "Class_Detail",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassHistory_SchoolYear_SchoolYear_ID",
                table: "ClassHistory",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassHistory_Subjects_Subject_ID",
                table: "ClassHistory",
                column: "Subject_ID",
                principalTable: "Subjects",
                principalColumn: "Subjects_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassHistory_User_User_ID",
                table: "ClassHistory",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassHistory_User_User_ID1",
                table: "ClassHistory",
                column: "User_ID1",
                principalTable: "User",
                principalColumn: "User_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSessions_User_User_ID",
                table: "ClassSessions",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_CourseOfferings_CourseOfferings_ID",
                table: "CourseLessons",
                column: "CourseOfferings_ID",
                principalTable: "CourseOfferings",
                principalColumn: "CourseOfferings_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_SchoolProfile_School_ID",
                table: "CourseLessons",
                column: "School_ID",
                principalTable: "SchoolProfile",
                principalColumn: "School_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseOfferings_User_Instructor_user_id",
                table: "CourseOfferings",
                column: "Instructor_user_id",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesLearned_SchoolYear_SchoolYear_ID",
                table: "CoursesLearned",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesLearned_TotalCoursesTaken_TotalCourses_ID",
                table: "CoursesLearned",
                column: "TotalCourses_ID",
                principalTable: "TotalCoursesTaken",
                principalColumn: "TotalCourses_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_SchoolYear_SchoolYear_ID",
                table: "Discipline",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_User_User_ID",
                table: "Discipline",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionThreads_Teaching_Assessment_Teaching_ID",
                table: "DiscussionThreads",
                column: "Teaching_ID",
                principalTable: "Teaching_Assessment",
                principalColumn: "Teaching_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionThreads_User_User_ID",
                table: "DiscussionThreads",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_History_User_CreatedByID",
                table: "Employment_History",
                column: "CreatedByID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_History_User_User_ID",
                table: "Employment_History",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exemptions_User_User_ID",
                table: "Exemptions",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty - StudyBlock_SchoolProfile_School_ID",
                table: "Faculty - StudyBlock",
                column: "School_ID",
                principalTable: "SchoolProfile",
                principalColumn: "School_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty - StudyBlock_SchoolYear_SchoolYear_ID",
                table: "Faculty - StudyBlock",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty - StudyBlock_User_User_ID",
                table: "Faculty - StudyBlock",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_SchoolYear_SchoolYear_ID",
                table: "Grades",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_TrainingLevels_Training_ID",
                table: "Grades",
                column: "Training_ID",
                principalTable: "TrainingLevels",
                principalColumn: "Training_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_User_User_ID",
                table: "Grades",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LabGraders_LabSchedules_LabSchedules_ID",
                table: "LabGraders",
                column: "LabSchedules_ID",
                principalTable: "LabSchedules",
                principalColumn: "LabSchedules_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabGraders_User_User_ID",
                table: "LabGraders",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabScheduleClasses_LabSchedules_LabSchedules_ID",
                table: "LabScheduleClasses",
                column: "LabSchedules_ID",
                principalTable: "LabSchedules",
                principalColumn: "LabSchedules_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabSchedules_SchoolYear_SchoolYear_ID",
                table: "LabSchedules",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LabSchedules_Subjects_Subject_ID",
                table: "LabSchedules",
                column: "Subject_ID",
                principalTable: "Subjects",
                principalColumn: "Subjects_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LabSchedules_User_User_ID",
                table: "LabSchedules",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LearningOutcomes_SchoolYear_SchoolYear_ID",
                table: "LearningOutcomes",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LearningOutcomes_Score_Score_ID",
                table: "LearningOutcomes",
                column: "Score_ID",
                principalTable: "Score",
                principalColumn: "Score_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LearningOutcomes_User_User_ID",
                table: "LearningOutcomes",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveChatMessages_LiveSessions_LiveSessions_ID",
                table: "LiveChatMessages",
                column: "LiveSessions_ID",
                principalTable: "LiveSessions",
                principalColumn: "LiveSessions_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveChatMessages_User_User_ID",
                table: "LiveChatMessages",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveSessions_Teaching_Assessment_Teaching_ID",
                table: "LiveSessions",
                column: "Teaching_ID",
                principalTable: "Teaching_Assessment",
                principalColumn: "Teaching_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_User_User_ID",
                table: "Notification",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PastClasses_Subjects_Subject_ID",
                table: "PastClasses",
                column: "Subject_ID",
                principalTable: "Subjects",
                principalColumn: "Subjects_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PastClasses_User_User_ID",
                table: "PastClasses",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_SchoolYear_SchoolYear_ID",
                table: "Qualifications",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_User_User_ID",
                table: "Qualifications",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_Questions_ID",
                table: "QuestionOptions",
                column: "Questions_ID",
                principalTable: "Questions",
                principalColumn: "Questions_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Subjects_Subject_ID",
                table: "Questions",
                column: "Subject_ID",
                principalTable: "Subjects",
                principalColumn: "Subjects_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_User_User_ID",
                table: "Questions",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_User_Student_user_id",
                table: "Registrations",
                column: "Student_user_id",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserved_User_User_ID",
                table: "Reserved",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reward_SchoolYear_SchoolYear_ID",
                table: "Reward",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reward_User_User_ID",
                table: "Reward",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolProfile_SchoolYear_SchoolYear_ID",
                table: "SchoolProfile",
                column: "SchoolYear_ID",
                principalTable: "SchoolYear",
                principalColumn: "SchoolYear_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolYear_User_User_ID",
                table: "SchoolYear",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_SchoolYear_SchoolYear_ID",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassHistory_SchoolYear_SchoolYear_ID",
                table: "ClassHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesLearned_SchoolYear_SchoolYear_ID",
                table: "CoursesLearned");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolProfile_SchoolYear_SchoolYear_ID",
                table: "SchoolProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_SchoolYear_SchoolYear_ID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Team-Department_SchoolYear_SchoolYear_ID",
                table: "Team-Department");

            migrationBuilder.DropForeignKey(
                name: "FK_User_SchoolYear_SchoolYear_ID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_User_User_ID",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassHistory_User_User_ID",
                table: "ClassHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassHistory_User_User_ID1",
                table: "ClassHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_User_User_ID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Team-Department_User_User_ID",
                table: "Team-Department");

            migrationBuilder.DropForeignKey(
                name: "FK_TotalCoursesTaken_User_User_ID",
                table: "TotalCoursesTaken");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesLearned_TotalCoursesTaken_TotalCourses_ID",
                table: "CoursesLearned");

            migrationBuilder.DropTable(
                name: "AcceptingSchoolTransfers");

            migrationBuilder.DropTable(
                name: "AssessmentQuestions");

            migrationBuilder.DropTable(
                name: "Assignment_Group");

            migrationBuilder.DropTable(
                name: "Campuses");

            migrationBuilder.DropTable(
                name: "Class_Detail");

            migrationBuilder.DropTable(
                name: "ClassHistorySession");

            migrationBuilder.DropTable(
                name: "ClassSessions");

            migrationBuilder.DropTable(
                name: "CourseLessons");

            migrationBuilder.DropTable(
                name: "Decentralization");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Employment_History");

            migrationBuilder.DropTable(
                name: "Exemptions");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "LabGraders");

            migrationBuilder.DropTable(
                name: "LabScheduleClasses");

            migrationBuilder.DropTable(
                name: "LearningOutcomes");

            migrationBuilder.DropTable(
                name: "LiveChatMessages");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "PastClasses");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Reserved");

            migrationBuilder.DropTable(
                name: "Reward");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Student_Grades");

            migrationBuilder.DropTable(
                name: "StudentMCQAnswers");

            migrationBuilder.DropTable(
                name: "StudentsChangeClasses");

            migrationBuilder.DropTable(
                name: "StudentsChangeSchool");

            migrationBuilder.DropTable(
                name: "StudentsProfile");

            migrationBuilder.DropTable(
                name: "Subjects_Class");

            migrationBuilder.DropTable(
                name: "Syllabus_topics");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "TeacherProfile");

            migrationBuilder.DropTable(
                name: "ThreadPosts");

            migrationBuilder.DropTable(
                name: "UpcomingClass");

            migrationBuilder.DropTable(
                name: "WorkHistories");

            migrationBuilder.DropTable(
                name: "TrainingLevels");

            migrationBuilder.DropTable(
                name: "LabSchedules");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "LiveSessions");

            migrationBuilder.DropTable(
                name: "CourseOfferings");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropTable(
                name: "Student_Submissions");

            migrationBuilder.DropTable(
                name: "DiscussionThreads");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AssessmentParts");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Faculty - StudyBlock");

            migrationBuilder.DropTable(
                name: "Teaching_Assessment");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ClassHistory");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "ClassroomSettings");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropTable(
                name: "SubjectType");

            migrationBuilder.DropTable(
                name: "Team-Department");

            migrationBuilder.DropTable(
                name: "SchoolProfile");

            migrationBuilder.DropTable(
                name: "TotalCoursesTaken");

            migrationBuilder.DropTable(
                name: "CoursesLearned");
        }
    }
}
