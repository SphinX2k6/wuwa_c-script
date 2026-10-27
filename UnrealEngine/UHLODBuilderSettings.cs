using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C29 RID: 3113
	[UnrealObjectPath("/Script/Engine.HLODBuilderSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UHLODBuilderSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009DF6 RID: 40438 RVA: 0x000E0881 File Offset: 0x000DEA81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODBuilderSettings._ClassPtr;
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x000E0890 File Offset: 0x000DEA90
		public UHLODBuilderSettings() : this(BuiltinUtils.AllocNativeUObject(UHLODBuilderSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x000E08B8 File Offset: 0x000DEAB8
		[NullableContext(1)]
		public UHLODBuilderSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODBuilderSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x000E08EB File Offset: 0x000DEAEB
		static UHLODBuilderSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODBuilderSettings");
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x000E08F9 File Offset: 0x000DEAF9
		protected UHLODBuilderSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400571A RID: 22298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODBuilderSettings";

		// Token: 0x0400571B RID: 22299
		private static IntPtr _ClassPtr;

		// Token: 0x0400571C RID: 22300
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
