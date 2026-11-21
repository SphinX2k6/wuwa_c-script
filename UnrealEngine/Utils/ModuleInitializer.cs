using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace UnrealEngine.Utils
{
	// Token: 0x020008A2 RID: 2210
	internal static class ModuleInitializer
	{
		// Token: 0x0600BE34 RID: 48692 RVA: 0x0012FBEC File Offset: 0x0012DDEC
		[Obfuscation]
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
					defaultInterpolatedStringHandler.AppendFormatted<Module>(manifestModule);
					defaultInterpolatedStringHandler.AppendLiteral(" mvid ");
					defaultInterpolatedStringHandler.AppendFormatted<Guid>(manifestModule.ModuleVersionId);
					UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
	}
}
