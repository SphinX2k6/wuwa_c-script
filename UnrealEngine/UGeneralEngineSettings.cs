using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079D RID: 1949
	[UnrealObjectPath("/Script/EngineSettings.GeneralEngineSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGeneralEngineSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600658E RID: 25998 RVA: 0x000919ED File Offset: 0x0008FBED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeneralEngineSettings._ClassPtr;
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x000919FC File Offset: 0x0008FBFC
		public UGeneralEngineSettings() : this(BuiltinUtils.AllocNativeUObject(UGeneralEngineSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x00091A24 File Offset: 0x0008FC24
		[NullableContext(1)]
		public UGeneralEngineSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeneralEngineSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x00091A57 File Offset: 0x0008FC57
		static UGeneralEngineSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.GeneralEngineSettings");
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x00091A65 File Offset: 0x0008FC65
		protected UGeneralEngineSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400314A RID: 12618
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/EngineSettings.GeneralEngineSettings";

		// Token: 0x0400314B RID: 12619
		private static IntPtr _ClassPtr;

		// Token: 0x0400314C RID: 12620
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
