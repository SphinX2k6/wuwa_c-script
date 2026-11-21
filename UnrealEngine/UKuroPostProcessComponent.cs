using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D9 RID: 1241
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent")]
	[UnrealStructLayout(8544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8544)]
	public class UKuroPostProcessComponent : UPostProcessComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073CC RID: 29644 RVA: 0x000A9BBA File Offset: 0x000A7DBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPostProcessComponent._ClassPtr;
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x000A9BC8 File Offset: 0x000A7DC8
		public UKuroPostProcessComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroPostProcessComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		[NullableContext(1)]
		public UKuroPostProcessComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPostProcessComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x060073CF RID: 29647 RVA: 0x000A9C23 File Offset: 0x000A7E23
		// (set) Token: 0x060073D0 RID: 29648 RVA: 0x000A9C37 File Offset: 0x000A7E37
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_WeatherDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_WeatherDataAsset, value);
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x060073D1 RID: 29649 RVA: 0x000A9C4C File Offset: 0x000A7E4C
		// (set) Token: 0x060073D2 RID: 29650 RVA: 0x000A9C60 File Offset: 0x000A7E60
		public unsafe UKuroTODData PPTODDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTODData>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_PPTODDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_PPTODDataAsset, value);
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x060073D3 RID: 29651 RVA: 0x000A9C75 File Offset: 0x000A7E75
		// (set) Token: 0x060073D4 RID: 29652 RVA: 0x000A9C89 File Offset: 0x000A7E89
		public unsafe AVolume ReferencedVolumeActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AVolume>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_ReferencedVolumeActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPostProcessComponent.__PropertyOffset_ReferencedVolumeActor, value);
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x000A9C9E File Offset: 0x000A7E9E
		// (set) Token: 0x060073D6 RID: 29654 RVA: 0x000A9CAE File Offset: 0x000A7EAE
		public unsafe bool bUpdateOverrideWithTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_bUpdateOverrideWithTOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_bUpdateOverrideWithTOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x000A9CBF File Offset: 0x000A7EBF
		public void SetWeatherDataAsset(UKuroWeatherDataAsset InWeatherDataAsset)
		{
			UKuroPostProcessComponent.__SetWeatherDataAsset_Internal(base.NativePtr, (InWeatherDataAsset != null) ? InWeatherDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x000A9CDC File Offset: 0x000A7EDC
		public void SetReferencedVolumeActor(AVolume InReferencedVolumeActor)
		{
			UKuroPostProcessComponent.__SetReferencedVolumeActor_Internal(base.NativePtr, (InReferencedVolumeActor != null) ? InReferencedVolumeActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x000A9CF9 File Offset: 0x000A7EF9
		public void SetPPTODDataAsset(UKuroTODData InPPTODDataAsset)
		{
			UKuroPostProcessComponent.__SetPPTODDataAsset_Internal(base.NativePtr, (InPPTODDataAsset != null) ? InPPTODDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x000A9D16 File Offset: 0x000A7F16
		public void PostModify()
		{
			UKuroPostProcessComponent.__PostModify_Internal(base.NativePtr);
		}

		// Token: 0x060073DB RID: 29659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeatherDataAsset_Internal(IntPtr @this, IntPtr InWeatherDataAsset);

		// Token: 0x060073DC RID: 29660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReferencedVolumeActor_Internal(IntPtr @this, IntPtr InReferencedVolumeActor);

		// Token: 0x060073DD RID: 29661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPPTODDataAsset_Internal(IntPtr @this, IntPtr InPPTODDataAsset);

		// Token: 0x060073DE RID: 29662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostModify_Internal(IntPtr @this);

		// Token: 0x060073DF RID: 29663 RVA: 0x000A9D23 File Offset: 0x000A7F23
		static UKuroPostProcessComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent");
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x000A9D31 File Offset: 0x000A7F31
		protected UKuroPostProcessComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003196 RID: 12694
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent";

		// Token: 0x04003197 RID: 12695
		private static IntPtr _ClassPtr;

		// Token: 0x04003198 RID: 12696
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003199 RID: 12697
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x0400319A RID: 12698
		internal static int __PropertyOffset_PPTODDataAsset;

		// Token: 0x0400319B RID: 12699
		internal static int __PropertyOffset_ReferencedVolumeActor;

		// Token: 0x0400319C RID: 12700
		internal static int __PropertyOffset_bUpdateOverrideWithTOD;
	}
}
