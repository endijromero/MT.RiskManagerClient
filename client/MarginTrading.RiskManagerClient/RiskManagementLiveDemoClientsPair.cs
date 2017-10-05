using System;
using System.Collections.Generic;
using System.Text;

namespace MarginTrading.RiskManagerClient
{
    /// <summary>
    /// A container for a pair of api clients for demo and live risk management backends
    /// </summary>
    public class RiskManagementLiveDemoClientsPair
    {
        /// <summary>
        /// /// Client for Demo Risk Management
        /// </summary>
        public IRiskManagementApi Demo { get; }
        /// <summary>
        /// Client for Live Risk Management
        /// </summary>
        public IRiskManagementApi Live { get; }
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="demo">demo client</param>
        /// <param name="live">live client</param>
        public RiskManagementLiveDemoClientsPair(IRiskManagementApi demo, IRiskManagementApi live)
        {
            Demo = demo;
            Live = live;
        }

        /// <summary>
        /// A helper method to get an api client based on the boolean flag <paramref name="isLive"/>
        /// </summary>
        public IRiskManagementApi Get(bool isLive)
        {
            return isLive ? Live : Demo;
        }
    }
}
