using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200112D RID: 4397
	[UnrealObjectPath("/Script/Engine.SoundEffectPreset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class USoundEffectPreset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601018E RID: 65934 RVA: 0x0017B766 File Offset: 0x00179966
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundEffectPreset._ClassPtr;
		}

		// Token: 0x0601018F RID: 65935 RVA: 0x0017B772 File Offset: 0x00179972
		static USoundEffectPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundEffectPreset");
		}

		// Token: 0x06010190 RID: 65936 RVA: 0x0017B780 File Offset: 0x00179980
		protected USoundEffectPreset() : this(BuiltinUtils.AllocNativeUObject(USoundEffectPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010191 RID: 65937 RVA: 0x0017B7A8 File Offset: 0x001799A8
		protected USoundEffectPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A7C RID: 35452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundEffectPreset";

		// Token: 0x04008A7D RID: 35453
		private static IntPtr _ClassPtr;

		// Token: 0x04008A7E RID: 35454
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
