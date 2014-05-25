﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssessment.Domain
{
    public class ExaminationQuestion
    {
        public ExaminationQuestion() {
            QuestionOptions = new List<ExaminationQuestionOption>();
        }

        public int ExaminationQuestionId { get; set; }

        public Guid QuestionId { get; set; }
        public int QuestionIndex { get; set; }
        public int Score { get; set; }
        public double QuestionDegree { get; set; }
        public QuestionForm QuestionType { get; set; }
        public string QuestionBody { get; set; }
        public string ReferenceRightAnswer { get; set; }

        public ICollection<ExaminationQuestionOption> QuestionOptions { get; set; }

        public double AvarageDegree
        {
            get { return QuestionDegree*Score; }
        }
    }
}