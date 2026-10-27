using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001242 RID: 4674
	[UnrealObjectPath("/Script/Engine.VolumetricLightmapDensityVolume")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class AVolumetricLightmapDensityVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060112E3 RID: 70371 RVA: 0x00193564 File Offset: 0x00191764
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AVolumetricLightmapDensityVolume._ClassPtr;
		}

		// Token: 0x060112E4 RID: 70372 RVA: 0x00193570 File Offset: 0x00191770
		public AVolumetricLightmapDensityVolume() : this(BuiltinUtils.AllocNativeUObject(AVolumetricLightmapDensityVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060112E5 RID: 70373 RVA: 0x00193598 File Offset: 0x00191798
		[NullableContext(1)]
		public AVolumetricLightmapDensityVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AVolumetricLightmapDensityVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x060112E6 RID: 70374 RVA: 0x001935CB File Offset: 0x001917CB
		// (set) Token: 0x060112E7 RID: 70375 RVA: 0x001935DF File Offset: 0x001917DF
		public unsafe FInt32Interval AllowedMipLevelRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AVolumetricLightmapDensityVolume.__PropertyOffset_AllowedMipLevelRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AVolumetricLightmapDensityVolume.__PropertyOffset_AllowedMipLevelRange) = value;
			}
		}

		// Token: 0x060112E8 RID: 70376 RVA: 0x001935F4 File Offset: 0x001917F4
		static AVolumetricLightmapDensityVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VolumetricLightmapDensityVolume");
		}

		// Token: 0x060112E9 RID: 70377 RVA: 0x00193602 File Offset: 0x00191802
		protected AVolumetricLightmapDensityVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009304 RID: 37636
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VolumetricLightmapDensityVolume";

		// Token: 0x04009305 RID: 37637
		private static IntPtr _ClassPtr;

		// Token: 0x04009306 RID: 37638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009307 RID: 37639
		internal static int __PropertyOffset_AllowedMipLevelRange;
	}
}
