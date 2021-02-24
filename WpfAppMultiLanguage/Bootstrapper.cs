﻿using System;
using Stylet;
using StyletIoC;
using WpfAppMultiLanguage.Pages;
using WpfExtensions.Xaml;

namespace WpfAppMultiLanguage
{
    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }

        protected override void OnLaunch()
        {
            base.OnLaunch();
            I18nManager.Instance.Add(LQClass.AdminForWPF.I18nResources.UiResource.ResourceManager);
        }
    }
}
