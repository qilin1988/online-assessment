﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssesment.Domain
{
    public class Question : ICanMigrate
    {
        public Question() {
            QuestionOptions = new List<QuestionOption>();
        }

        public Guid QuestionId { get; set; }

        public QuestionType QuestionType { get; set; }
        public string QuestionBody { get; set; }
        public string ReferenceRightAnswer { get; set; }
        public CourseLevel CourseLevel { get; set; }

        private int _questionDegree;
        public int QuestionDegree {
            get { return _questionDegree; }
            set {
                if (value < 0 || value > 10) {
                    throw new InvalidOperationException("invalid degree value. degree value should > 0 and < 10");
                }
                _questionDegree = value;
            }
        }

        public virtual Chapter Chapter { get; set; }
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
