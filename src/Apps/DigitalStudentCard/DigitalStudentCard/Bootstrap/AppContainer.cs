﻿using Autofac;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalStudentCard.Core.Bootstrap
{
    public interface IDependencyResolver
    {
        object Resolve(Type typeName);
        T Resolve<T>();
    }

    public class AppContainer : IDependencyResolver
    {
        private IContainer _container;
        private static AppContainer _instance;

        public static AppContainer Instance => _instance ?? (_instance = new AppContainer());

        private AppContainer()
        {
            RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<LectorMomentDetailViewModel>();
            builder.RegisterType<LectorMomentsViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<StudentMomentsViewModel>();
            builder.RegisterType<StudentMomentItemViewModel>();

            /*
            //services - data
            builder.RegisterType<CatalogDataService>().As<ICatalogDataService>();
            builder.RegisterType<ShoppingCartDataService>().As<IShoppingCartDataService>();
            builder.RegisterType<ContactDataService>().As<IContactDataService>();
            builder.RegisterType<OrderDataService>().As<IOrderDataService>();
            */

            /*
            //services - general
            builder.RegisterType<ConnectionService>().As<IConnectionService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<DialogService>().As<IDialogService>();
            builder.RegisterType<PhoneService>().As<IPhoneService>();
            builder.RegisterType<SettingsService>().As<ISettingsService>().SingleInstance();
            */

            //General
            // builder.RegisterType<GenericRepository>().As<IGenericRepository>();
            builder.Register(c => Instance).As<IDependencyResolver>();

            _container = builder.Build();
        }

        public object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
