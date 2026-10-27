using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001130 RID: 4400
	[UnrealObjectPath("/Script/Engine.SoundEffectSubmixPreset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class USoundEffectSubmixPreset : USoundEffectPreset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601019F RID: 65951 RVA: 0x0017B90F File Offset: 0x00179B0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundEffectSubmixPreset._ClassPtr;
		}

		// Token: 0x060101A0 RID: 65952 RVA: 0x0017B91B File Offset: 0x00179B1B
		static USoundEffectSubmixPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundEffectSubmixPreset");
		}

		// Token: 0x060101A1 RID: 65953 RVA: 0x0017B92C File Offset: 0x00179B2C
		protected USoundEffectSubmixPreset() : this(BuiltinUtils.AllocNativeUObject(USoundEffectSubmixPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060101A2 RID: 65954 RVA: 0x0017B954 File Offset: 0x00179B54
		protected USoundEffectSubmixPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A89 RID: 35465
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundEffectSubmixPreset";

		// Token: 0x04008A8A RID: 35466
		private static IntPtr _ClassPtr;

		// Token: 0x04008A8B RID: 35467
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
