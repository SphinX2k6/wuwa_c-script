using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200112E RID: 4398
	[UnrealObjectPath("/Script/Engine.SoundEffectSourcePreset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class USoundEffectSourcePreset : USoundEffectPreset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010192 RID: 65938 RVA: 0x0017B7B1 File Offset: 0x001799B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundEffectSourcePreset._ClassPtr;
		}

		// Token: 0x06010193 RID: 65939 RVA: 0x0017B7BD File Offset: 0x001799BD
		static USoundEffectSourcePreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundEffectSourcePreset");
		}

		// Token: 0x06010194 RID: 65940 RVA: 0x0017B7CC File Offset: 0x001799CC
		protected USoundEffectSourcePreset() : this(BuiltinUtils.AllocNativeUObject(USoundEffectSourcePreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010195 RID: 65941 RVA: 0x0017B7F4 File Offset: 0x001799F4
		protected USoundEffectSourcePreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A7F RID: 35455
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundEffectSourcePreset";

		// Token: 0x04008A80 RID: 35456
		private static IntPtr _ClassPtr;

		// Token: 0x04008A81 RID: 35457
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
