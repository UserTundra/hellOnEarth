﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oksana_kids
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_kidsEntitiesConn : DbContext
    {
        public bd_kidsEntitiesConn()
            : base("name=bd_kidsEntitiesConn")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<B01_testing_aims_to_tests> B01_testing_aims_to_tests { get; set; }
        public virtual DbSet<B02_study_courses_to_pupils_classes> B02_study_courses_to_pupils_classes { get; set; }
        public virtual DbSet<B03_study_subjects_to_courses> B03_study_subjects_to_courses { get; set; }
        public virtual DbSet<B04_test_tasks_to_study_subjects> B04_test_tasks_to_study_subjects { get; set; }
        public virtual DbSet<B05_testing_task_modules_to_tests> B05_testing_task_modules_to_tests { get; set; }
        public virtual DbSet<R01_people_category> R01_people_category { get; set; }
        public virtual DbSet<R02_pupils_classes> R02_pupils_classes { get; set; }
        public virtual DbSet<R03_testing_types> R03_testing_types { get; set; }
        public virtual DbSet<R04_end_testing_reasons> R04_end_testing_reasons { get; set; }
        public virtual DbSet<R05_legal_ownership_forms> R05_legal_ownership_forms { get; set; }
        public virtual DbSet<R06_testing_aims> R06_testing_aims { get; set; }
        public virtual DbSet<R07_methodical_materials> R07_methodical_materials { get; set; }
        public virtual DbSet<R08_study_courses> R08_study_courses { get; set; }
        public virtual DbSet<R09_study_subjects> R09_study_subjects { get; set; }
        public virtual DbSet<R10_next_action_variants> R10_next_action_variants { get; set; }
        public virtual DbSet<R11_variants_of_passing_tasks_results_analysis> R11_variants_of_passing_tasks_results_analysis { get; set; }
        public virtual DbSet<R12_instructions_to_test_tasks_types> R12_instructions_to_test_tasks_types { get; set; }
        public virtual DbSet<R13_play_result_variants> R13_play_result_variants { get; set; }
        public virtual DbSet<R14_track_types> R14_track_types { get; set; }
        public virtual DbSet<R15_task_key_words> R15_task_key_words { get; set; }
        public virtual DbSet<T01_personalities> T01_personalities { get; set; }
        public virtual DbSet<T02_tests> T02_tests { get; set; }
        public virtual DbSet<T03_testing_task_modules> T03_testing_task_modules { get; set; }
        public virtual DbSet<T04_testing_tasks> T04_testing_tasks { get; set; }
        public virtual DbSet<T05_test_passing_results> T05_test_passing_results { get; set; }
        public virtual DbSet<T06_teaching_materials> T06_teaching_materials { get; set; }
        public virtual DbSet<T07_soundtracks> T07_soundtracks { get; set; }
        public virtual DbSet<T08_audio_video_tracks> T08_audio_video_tracks { get; set; }
        public virtual DbSet<T09_comment_variants_on_passing_tasks> T09_comment_variants_on_passing_tasks { get; set; }
        public virtual DbSet<T10_organizations> T10_organizations { get; set; }
        public virtual DbSet<T11_task_answers> T11_task_answers { get; set; }
        public virtual DbSet<R00_decode> R00_decode { get; set; }
        public virtual DbSet<T01_1_pupils> T01_1_pupils { get; set; }
        public virtual DbSet<T01_2_others> T01_2_others { get; set; }
    }
}