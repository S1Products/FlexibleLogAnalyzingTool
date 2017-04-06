#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

using log4net;

namespace FlatEngine
{
    /// <summary>
    /// Log utility
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class Log
    {
        private const int DEFAULT_CALLER_FRAME_INDEX = 1;
        private const string PUBLIC_METHOD_IN = ">> ";
        private const string PUBLIC_METHOD_OUT = "<< ";

        private const string PRIVATE_METHOD_IN = "-> ";
        private const string PRIVATE_METHOD_OUT = "<- ";

        private const string PARAM_START = "[PRM";
        private const string PARAM_END = "]";
        private const string RETURN_START = " [RET=";
        private const string RETURN_END = "]";

        private ILog logger;

        public Log(Type type)
        {
            logger = LogManager.GetLogger(type);
        }

        /// <summary>
        /// Output log for public method entry point
        /// </summary>
        public void In()
        {
            if (!logger.IsInfoEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            logger.Info(PUBLIC_METHOD_IN + callerMethod.Name);
        }

        /// <summary>
        /// Output log for public method entry point with parameters
        /// </summary>
        /// <param name="parameters">Method parameters</param>
        public void In(params object[] parameters)
        {
            if (!logger.IsInfoEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            string message = PUBLIC_METHOD_IN + callerMethod.Name;

            message += "{";

            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    message += PARAM_START + i + "=";

                    if (parameters[i] == null)
                    {
                        message += "null" + PARAM_END;
                    }
                    else
                    {
                        message += parameters[i].ToString() + PARAM_END;
                    }
                }
            }
            message += "}";

            logger.Info(message);
        }

        /// <summary>
        /// Output log for public method end point
        /// </summary>
        public void Out()
        {
            if (!logger.IsInfoEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            logger.Info(PUBLIC_METHOD_OUT + callerMethod.Name);
        }

        /// <summary>
        /// Output log for public method end point with return value
        /// </summary>
        /// <param name="returnValue">Return value</param>
        public void Out(object returnValue)
        {
            if (!logger.IsInfoEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            string message = PUBLIC_METHOD_OUT + callerMethod.Name;

            if (returnValue == null)
            {
                message += RETURN_START + "null" + RETURN_END;
            }
            else
            {
                message += RETURN_START + returnValue.ToString() + RETURN_END;
            }

            logger.Info(message);
        }

        /// <summary>
        /// Output log for private method entry point
        /// </summary>
        public void InPrivate()
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            logger.Debug(PRIVATE_METHOD_IN + callerMethod.Name);
        }

        /// <summary>
        /// Output log for private method entry point with parameters
        /// </summary>
        /// <param name="parameters">Method parameters</param>
        public void InPrivate(params object[] parameters)
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            string message = PRIVATE_METHOD_IN + callerMethod.Name;

            message += "{";

            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    message += PARAM_START + i + "=";

                    if (parameters[i] == null)
                    {
                        message += "null" + PARAM_END;
                    }
                    else
                    {
                        message += parameters[i].ToString() + PARAM_END;
                    }
                }
            }
            message += "}";

            logger.Debug(message);
        }

        /// <summary>
        /// Output log for private method end point
        /// </summary>
        public void OutPrivate()
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            logger.Debug(PRIVATE_METHOD_OUT + callerMethod.Name);
        }

        /// <summary>
        /// Output log for private method end point with return value
        /// </summary>
        /// <param name="returnValue">Return value</param>
        public void OutPrivate(object returnValue)
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            StackFrame callerFrame = new StackFrame(DEFAULT_CALLER_FRAME_INDEX);
            MethodBase callerMethod = callerFrame.GetMethod();

            string message = PRIVATE_METHOD_OUT + callerMethod.Name;

            if (returnValue == null)
            {
                message += RETURN_START + "null" + RETURN_END;
            }
            else
            {
                message += RETURN_START + returnValue.ToString() + RETURN_END;
            }

            logger.Debug(message);
        }

        /// <summary>
        /// Output log as fatal error level
        /// </summary>
        /// <param name="message">Log message</param>
        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        /// <summary>
        /// Output log as fatal error level
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="ex">Caused exception</param>
        public void Fatal(string message, Exception ex)
        {
            logger.Fatal(message, ex);
        }

        /// <summary>
        /// Output log for error level
        /// </summary>
        /// <param name="message">Log message</param>
        public void Error(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        /// Output log as error level
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="ex">Caused exception</param>
        public void Error(string message, Exception ex)
        {
            logger.Error(message, ex);
        }

        /// <summary>
        /// Output log as warn level
        /// </summary>
        /// <param name="message">Log message</param>
        public void Warn(string message)
        {
            logger.Warn(message);
        }

        /// <summary>
        /// Output log as warn level
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="ex">Caused exception</param>
        public void Warn(string message, Exception ex)
        {
            logger.Warn(message, ex);
        }

        /// <summary>
        /// Output log as info level
        /// </summary>
        /// <param name="message">Log message</param>
        public void Info(string message)
        {
            logger.Info(message);
        }

        /// <summary>
        /// Output log as info level
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="ex">Caused exception</param>
        public void Info(string message, Exception ex)
        {
            logger.Info(message, ex);
        }

        /// <summary>
        /// Output log as debug level
        /// </summary>
        /// <param name="message">Log message</param>
        public void Debug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// Output log as debug level
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="ex">Caused exception</param>
        public void Debug(string message, Exception ex)
        {
            logger.Debug(message, ex);
        }
    }
}
