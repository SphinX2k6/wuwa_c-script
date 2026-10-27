using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AF2 RID: 10994
	internal static class ModuleInitializer
	{
		// Token: 0x0602847A RID: 164986 RVA: 0x003D488C File Offset: 0x003D2A8C
		internal static void Initialize()
		{
			AssemblyLoadContext loadContext = AssemblyLoadContext.GetLoadContext(Assembly.GetExecutingAssembly());
			IEnumerable<Assembly> enumerable = (loadContext != null) ? loadContext.Assemblies : null;
			if (enumerable != null)
			{
				foreach (Assembly assembly in enumerable)
				{
					Module manifestModule = assembly.ManifestModule;
					RuntimeHelpers.RunModuleConstructor(manifestModule.ModuleHandle);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Assembly ");
					defaultInterpolatedStringHandler.AppendFormatted(manifestModule.Name);
					defaultInterpolatedStringHandler.AppendLiteral(" mvid ");
					defaultInterpolatedStringHandler.AppendFormatted<Guid>(manifestModule.ModuleVersionId);
					UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
	}
}
