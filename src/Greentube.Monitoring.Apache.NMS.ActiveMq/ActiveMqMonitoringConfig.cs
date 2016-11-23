﻿using System;

namespace Greentube.Monitoring.Apache.NMS.ActiveMq
{
    /// <summary>
    /// Abstraction that holdes configuration for ActiveMQ monitoring connection
    /// </summary>
    public interface IActiveMqMonitoringConfig
    {
        /// <summary>
        /// represents valid ActiveMQ connection url
        /// </summary>
        Uri Uri { get; }
        /// <summary>
        /// holdes username used to establish ActiveMQ connection
        /// </summary>
        string User { get; }
        /// <summary>
        /// holdes password used to establish ActiveMQ connection
        /// </summary>
        string Password { get; }
    }

    /// <inheritdoc cref="IActiveMqMonitoringConfig"/>
    public class ActiveMqMonitoringConfig : IActiveMqMonitoringConfig
    {
        /// <summary>
        /// Constructor of ActiveMq Monitoring Config
        /// </summary>
        /// <param name="uri">valid ActiveMQ Uri</param>
        /// <param name="user">username used to open connection</param>
        /// <param name="password">password used to open connection</param>
        public ActiveMqMonitoringConfig(Uri uri, string user, string password)
        {
            Uri = uri;
            User = user;
            Password = password;
        }

        /// <inheritdoc cref="IActiveMqMonitoringConfig.Uri"/>
        public Uri Uri { get; }
        /// <inheritdoc cref="IActiveMqMonitoringConfig.User"/>
        public string User { get; }
        /// <inheritdoc cref="IActiveMqMonitoringConfig.Password"/>
        public string Password { get; }
    }
}