﻿using Autofac;
using Autofac.Integration.Mvc;
using OnlineAssessment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAssessment.Web
{
    public class AutofacConfig
    {
        public static void RegisterIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            SetupServiceInjection(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void SetupServiceInjection(ContainerBuilder builder) {
            builder.RegisterType<AnsweringService>()
                .As<IAnsweringService>()
                .InstancePerRequest();
            builder.RegisterType<ExaminationService>()
                .As<IExaminationService>()
                .InstancePerRequest();
            builder.RegisterType<MembershipService>()
                .As<IMembershipService>()
                .InstancePerRequest();
            builder.RegisterType<QuestionService>()
                .As<IQuestionService>()
                .InstancePerRequest();
        }
    }
}