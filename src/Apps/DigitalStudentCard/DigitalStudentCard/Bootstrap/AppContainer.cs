using Autofac;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using System;

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
