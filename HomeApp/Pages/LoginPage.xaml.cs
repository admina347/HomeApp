﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCounter = 0;
        //string errorMessage;

        // Создаем объект, возвращающий свойства устройства
        IDeviceDetector detector = DependencyService.Get<IDeviceDetector>();

        public LoginPage()
        {
            InitializeComponent();

            // Изменяем внешний вид кнопки для Desktop-версии
            if (Device.Idiom == TargetIdiom.Desktop)
                loginButton.CornerRadius = 0;

            //// Изменяем внешний вид кнопки для Windows-версии
            //if (Device.RuntimePlatform == Device.UWP)
            //    loginButton.CornerRadius = 0;

            // Передаем информацию о платформе на экран
            //runningDevice.Text = detector.GetDevice();

            // Устанавливаем динамический ресурс с помощью специально метода
            infoMessage.SetDynamicResource(Label.TextColorProperty, "errorColor");

        }

        /// <summary>
        /// По клику обрабатываем счётчик и выводим разные сообщения
        /// </summary>
        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCounter == 0)
            {
                loginButton.Text = $"Выполняется вход..";
            }
            else if (loginCounter > 5)
            {
                loginButton.IsEnabled = false;

                // Обновляем динамический ресурс по необходимости
                Resources["errorColor"] = Color.FromHex("#e70d4f");
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
            }
            else
            {
                // Обновляем динамический ресурс по необходимости
                Resources["errorColor"] = Color.FromHex("#ff8e00");

                loginButton.Text = $"Выполняется вход...";
                infoMessage.Text = $" Попыток входа: { loginCounter}";
            }

            loginCounter += 1;
        }
    }
}