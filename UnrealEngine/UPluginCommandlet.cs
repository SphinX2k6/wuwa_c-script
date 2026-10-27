using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001012 RID: 4114
	[UnrealObjectPath("/Script/Engine.PluginCommandlet")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UPluginCommandlet : UCommandlet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E0F4 RID: 57588 RVA: 0x0014AC94 File Offset: 0x00148E94
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPluginCommandlet._ClassPtr;
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x0014ACA0 File Offset: 0x00148EA0
		public UPluginCommandlet() : this(BuiltinUtils.AllocNativeUObject(UPluginCommandlet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E0F6 RID: 57590 RVA: 0x0014ACC8 File Offset: 0x00148EC8
		[NullableContext(1)]
		public UPluginCommandlet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPluginCommandlet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600E0F7 RID: 57591 RVA: 0x0014ACFB File Offset: 0x00148EFB
		static UPluginCommandlet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PluginCommandlet");
		}

		// Token: 0x0600E0F8 RID: 57592 RVA: 0x0014AD09 File Offset: 0x00148F09
		protected UPluginCommandlet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078D7 RID: 30935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PluginCommandlet";

		// Token: 0x040078D8 RID: 30936
		private static IntPtr _ClassPtr;

		// Token: 0x040078D9 RID: 30937
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
