﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oas.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Oas.Infrastructure.Mapping
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping() {
            HasKey(m => m.CourseId);

            Property(m => m.CourseName).IsRequired();
            HasMany(m => m.PinSubjects);
        }
    }

    public class SubjectPinMapping : EntityTypeConfiguration<SubjectPin>
    {
        public SubjectPinMapping() {
            HasKey(m => m.SubjectPinId);

            Property(m => m.SubjectId).IsRequired();
            Property(m => m.PinName).IsRequired();
        }
    }
}
