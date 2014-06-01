﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OnlineAssessment.Domain;
using OnlineAssessment.Infrastructure;

namespace OnlineAssessment.Service
{
    public class QuestionService : IQuestionService
    {
        public IEnumerable<Question> GetAllQuestion(Guid subjectId, QuestionForm? questionType = null) {
            using (var context = new OnlineAssessmentContext()) {
                var courseQuestions = context
                    .Questions
                    .Where(q => q.Subject.SubjectId == subjectId)
                    .Where(q => questionType == null || q.QuestionForm == questionType);

                return courseQuestions;
            }
        }

        public Question GetQuestion(Guid questionId) {
            using (var context = new OnlineAssessmentContext()) {
                var question = context.Questions.Find(questionId);

                return question;
            }
        }

        public Guid AddQuestion(Guid subjectId, Question question) {
            using (var context = new OnlineAssessmentContext()) {
                var subject = context.Subjects.Find(subjectId);
                subject.Questions.Add(question);
                context.SaveChanges();

                return question.QuestionId;
            }
        }

        public void ModifyQuestion(Question question) {
            using (var context = new OnlineAssessmentContext()) {
                context.Questions.Attach(question);
                context.Entry(question).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteQuestion(Guid questionId) {
            using (var context = new OnlineAssessmentContext()) {
                var question = context.Questions.Find(questionId);
                context.Questions.Remove(question);
                context.SaveChanges();
            }
        }
    }
}