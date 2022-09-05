using Autofac;
using DigitalStudentCard.Core.DataStores;
using DigitalStudentCard.Core.Repositories.Contracts;
using DigitalStudentCard.Core.Repositories;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Services.Contracts.General;
using DigitalStudentCard.Core.Services.Data;
using DigitalStudentCard.Core.Services.General;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using System;
using DigitalStudentCard.Core.ViewModels.QRCode;

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

        public void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<LectorMomentDetailViewModel>();
            builder.RegisterType<LectorMomentsViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<StudentMomentsViewModel>();
            builder.RegisterType<QRCodeViewModel>();
            builder.RegisterType<QRScanningViewModel>();
            builder.RegisterType<AppShellViewModel>();

            //MockDataStores
            builder.RegisterType<MockPresenceDataStore>();
            builder.RegisterType<MockStudentDataStore>();
            builder.RegisterType<MockMomentDataStore>();

            //services - auth
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();

            //services - data
            builder.RegisterType<MomentDataService>().As<IMomentDataService>();
            builder.RegisterType<PresenceDataService>().As<IPresenceDataService>();
            builder.RegisterType<StudentDataService>().As<IStudentDataService>();

            //services - general
            builder.RegisterType<AlertService>().As<IAlertService>();
            builder.RegisterType<QRCodeService>().As<IQRCodeService>();

            //General
            builder.RegisterType<GenericRepository>().As<IGenericRepository>();
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
