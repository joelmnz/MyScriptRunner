﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScriptRunner
{
    internal class ScriptOpener
    {
        private const string COMMENT_CHAR = "#";
        private const char ARG_SEPERATOR = '|';
        private const string RUN_OPTION = "run";
        private const string EDIT_OPTION = "edit";
        private const string DEFAULT_EDITOR = "notepad";

        public static void RunScript(string scriptFile, bool asAdmin)
        {
            RunFileAction(scriptFile, RUN_OPTION, string.Empty, asAdmin);
        }

        public static void EditScript(string scriptFile)
        {
            RunFileAction(scriptFile, EDIT_OPTION, DEFAULT_EDITOR, false);
        }

        private static void RunFileAction(string scriptFile, string actionName, string defaultRun, bool asAdmin)
        {
            if (string.IsNullOrEmpty(scriptFile)) { return; }
            if (!System.IO.File.Exists(scriptFile)) { return; }

            var option = GetConfigOption(scriptFile, actionName);
            if (option == null)
            {
                option = new ScriptOpenOption { ActionType = actionName, RunCommand = defaultRun };
            }

            System.Diagnostics.ProcessStartInfo pi = null;
            if (string.IsNullOrEmpty(option.RunCommand))
            {
                pi = new System.Diagnostics.ProcessStartInfo(scriptFile);
            }
            else
            {
                pi = new System.Diagnostics.ProcessStartInfo(option.RunCommand, string.Format(option.RunArgsFormat, scriptFile));
                //pi.UseShellExecute = false;
            }

            if (asAdmin == true)
            {
                pi.Verb = "runas";
            }

            System.Diagnostics.Process.Start(pi);
        }

        private static ScriptOpenOption GetConfigOption(string fileName, string action)
        {
            if (ConfigOptions == null || ConfigOptions.Count == 0) { return null; }

            string fileExt = System.IO.Path.GetExtension(fileName);

            return ConfigOptions.FirstOrDefault((item) => item.ActionType == action && item.ContainsExtension(fileExt));
        }

        internal static void Init()
        {
            if (!System.IO.File.Exists(ExtensionHandlersConfigFile))
            {
                System.IO.File.WriteAllText(ExtensionHandlersConfigFile, Properties.Resources.ExampleLaunchersFile);
            }

            ConfigOptions = GetConfigOptions();
        }

        public static void OpenExtensionHandlerConfigFile()
        {
            EditScript(ExtensionHandlersConfigFile);
        }

        private static List<ScriptOpenOption> ConfigOptions { get; set; }

        private static List<ScriptOpenOption> GetConfigOptions()
        {
            var lsOptions = new List<ScriptOpenOption>();

            if (!System.IO.File.Exists(ExtensionHandlersConfigFile)) { return lsOptions; }

            using (var sr = new System.IO.StreamReader(ExtensionHandlersConfigFile))
            {
                do
                {
                    string szLine = sr.ReadLine();
                    if (string.IsNullOrEmpty(szLine) || szLine.StartsWith(COMMENT_CHAR)) { continue; }

                    var arValues = szLine.Split(ARG_SEPERATOR);
                    //if (arValues.Length  3) { continue; } // its invalid, ignore it

                    var opt = new ScriptOpenOption(arValues);
                    if (opt.IsValid()) { lsOptions.Add(opt); }
                } while (!sr.EndOfStream);
            }

            return lsOptions;
        }

        public const string EXT_CONFIG_FILE = "ExtensionHandlers.ini";

        public static string ExtensionHandlersConfigFile
        {
            get
            {
                return System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, EXT_CONFIG_FILE);
            }
        }

        private class ScriptOpenOption
        {
            private const string RUNARGS_DEFAULT_FORMAT = "\"{0}\"";

            public ScriptOpenOption()
            {
            }

            public ScriptOpenOption(string[] values)
            {
                if (values == null || values.Length < 3) { return; }

                this.ActionType = values[0].Trim();
                this.Extensions = " " + values[1] + " "; // need spacings before and after
                this.RunCommand = values[2];

                if (values.Length > 3)
                {
                    this.RunArgsFormat = values[3];
                }

                this.Extensions = this.Extensions.ToLower();
            }

            public string ActionType { get; set; }
            public string Extensions { get; set; }
            public string RunCommand { get; set; }

            private string _RunArgsFormat = RUNARGS_DEFAULT_FORMAT;

            public string RunArgsFormat
            {
                get
                {
                    return _RunArgsFormat;
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _RunArgsFormat = RUNARGS_DEFAULT_FORMAT;
                    }
                    else
                    {
                        _RunArgsFormat = value;
                    }
                }
            }

            public bool IsValid()
            {
                return !string.IsNullOrEmpty(this.RunCommand);
            }

            public bool ContainsExtension(string fileExt)
            {
                return this.Extensions.Contains(" " + fileExt.ToLower() + " ");
            }
        } //ScriptOpenOption
    } // class
} // ns