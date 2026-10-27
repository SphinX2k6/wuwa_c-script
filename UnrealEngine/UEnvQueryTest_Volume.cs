using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B4 RID: 436
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Volume")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class UEnvQueryTest_Volume : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x000278D6 File Offset: 0x00025AD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Volume._ClassPtr;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000278E4 File Offset: 0x00025AE4
		public UEnvQueryTest_Volume() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Volume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0002790C File Offset: 0x00025B0C
		[NullableContext(1)]
		public UEnvQueryTest_Volume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Volume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0002793F File Offset: 0x00025B3F
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x00027953 File Offset: 0x00025B53
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> VolumeContext
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_VolumeContext);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_VolumeContext) = value;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00027968 File Offset: 0x00025B68
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0002797C File Offset: 0x00025B7C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AVolume> VolumeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_VolumeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_VolumeClass) = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00027991 File Offset: 0x00025B91
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x000279AA File Offset: 0x00025BAA
		public unsafe bool bDoComplexVolumeTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_bDoComplexVolumeTest) & UEnvQueryTest_Volume.__PropertyMask_bDoComplexVolumeTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_bDoComplexVolumeTest) = ((*(base.NativePtr + (IntPtr)UEnvQueryTest_Volume.__PropertyOffset_bDoComplexVolumeTest) & ~UEnvQueryTest_Volume.__PropertyMask_bDoComplexVolumeTest) | (value ? UEnvQueryTest_Volume.__PropertyMask_bDoComplexVolumeTest : 0));
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000279DA File Offset: 0x00025BDA
		static UEnvQueryTest_Volume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Volume");
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000279E8 File Offset: 0x00025BE8
		protected UEnvQueryTest_Volume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000818 RID: 2072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Volume";

		// Token: 0x04000819 RID: 2073
		private static IntPtr _ClassPtr;

		// Token: 0x0400081A RID: 2074
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400081B RID: 2075
		internal static int __PropertyOffset_VolumeContext;

		// Token: 0x0400081C RID: 2076
		internal static int __PropertyOffset_VolumeClass;

		// Token: 0x0400081D RID: 2077
		internal static int __PropertyOffset_bDoComplexVolumeTest;

		// Token: 0x0400081E RID: 2078
		internal static byte __PropertyMask_bDoComplexVolumeTest;
	}
}
