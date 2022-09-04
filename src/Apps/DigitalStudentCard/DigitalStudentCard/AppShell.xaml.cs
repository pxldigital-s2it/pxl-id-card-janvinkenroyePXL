﻿using DigitalStudentCard.Core.Views.LectorMoment;
using DigitalStudentCard.Core.Views.QRCode;
using DigitalStudentCard.Core.Views.StudentMoment;
using System;
using Xamarin.Forms;

namespace DigitalStudentCard.Core
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LectorMomentDetailPage), typeof(LectorMomentDetailPage));
            Routing.RegisterRoute(nameof(QRCodePage), typeof(QRCodePage));
            Routing.RegisterRoute(nameof(LectorMomentsPage), typeof(LectorMomentsPage));
            Routing.RegisterRoute(nameof(StudentMomentsPage), typeof(StudentMomentsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
