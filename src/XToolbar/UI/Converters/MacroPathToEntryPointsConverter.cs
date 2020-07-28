﻿//*********************************************************************
//CAD+ Toolset
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://cadplus.xarial.com
//License: https://cadplus.xarial.com/license/
//*********************************************************************

using System;
using System.Globalization;
using System.Windows.Data;
using Xarial.CadPlus.XToolbar.Services;

namespace Xarial.CadPlus.XToolbar.UI.Converters
{
    public class MacroPathToEntryPointsConverter : IValueConverter
    {
        private readonly IMacroEntryPointsExtractor m_Extractor;

        public MacroPathToEntryPointsConverter()
            : this(XToolbarModule.Resolve<IMacroEntryPointsExtractor>())
        {
        }

        public MacroPathToEntryPointsConverter(IMacroEntryPointsExtractor extractor)
        {
            m_Extractor = extractor;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return m_Extractor.GetEntryPoints(value as string);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}