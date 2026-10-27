using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8F RID: 7055
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent")]
	[UnrealStructLayout(8480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8480)]
	public class UKuroPostProcessComponent : UPostProcessComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AC4D RID: 109645 RVA: 0x0027725C File Offset: 0x0027545C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPostProcessComponent._ClassPtr;
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x00277268 File Offset: 0x00275468
		public UKuroPostProcessComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroPostProcessComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x00277290 File Offset: 0x00275490
		[NullableContext(1)]
		public UKuroPostProcessComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPostProcessComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BA4 RID: 27556
		// (get) Token: 0x0601AC50 RID: 109648 RVA: 0x002772C3 File Offset: 0x002754C3
		// (set) Token: 0x0601AC51 RID: 109649 RVA: 0x002772D7 File Offset: 0x002754D7
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

		// Token: 0x17006BA5 RID: 27557
		// (get) Token: 0x0601AC52 RID: 109650 RVA: 0x002772EC File Offset: 0x002754EC
		// (set) Token: 0x0601AC53 RID: 109651 RVA: 0x00277300 File Offset: 0x00275500
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

		// Token: 0x17006BA6 RID: 27558
		// (get) Token: 0x0601AC54 RID: 109652 RVA: 0x00277318 File Offset: 0x00275518
		// (set) Token: 0x0601AC55 RID: 109653 RVA: 0x00277351 File Offset: 0x00275551
		[Nullable(1)]
		public FKuroGISetting GISetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroGISetting result;
				if ((result = this._GISetting) == null)
				{
					result = (this._GISetting = new FKuroGISetting(base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_GISetting, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGISetting.StaticStruct(), base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_GISetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006BA7 RID: 27559
		// (get) Token: 0x0601AC56 RID: 109654 RVA: 0x00277374 File Offset: 0x00275574
		// (set) Token: 0x0601AC57 RID: 109655 RVA: 0x002773AD File Offset: 0x002755AD
		[Nullable(1)]
		public FKuroGIPostProcessCustomData CustomData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroGIPostProcessCustomData result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new FKuroGIPostProcessCustomData(base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_CustomData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGIPostProcessCustomData.StaticStruct(), base.NativePtr + (IntPtr)UKuroPostProcessComponent.__PropertyOffset_CustomData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006BA8 RID: 27560
		// (get) Token: 0x0601AC58 RID: 109656 RVA: 0x002773CE File Offset: 0x002755CE
		// (set) Token: 0x0601AC59 RID: 109657 RVA: 0x002773E2 File Offset: 0x002755E2
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

		// Token: 0x17006BA9 RID: 27561
		// (get) Token: 0x0601AC5A RID: 109658 RVA: 0x002773F7 File Offset: 0x002755F7
		// (set) Token: 0x0601AC5B RID: 109659 RVA: 0x00277407 File Offset: 0x00275607
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

		// Token: 0x0601AC5C RID: 109660 RVA: 0x00277418 File Offset: 0x00275618
		public void SetWeatherDataAsset(UKuroWeatherDataAsset InWeatherDataAsset)
		{
			UKuroPostProcessComponent.__SetWeatherDataAsset_Internal(base.NativePtr, (InWeatherDataAsset != null) ? InWeatherDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AC5D RID: 109661 RVA: 0x00277435 File Offset: 0x00275635
		public void SetReferencedVolumeActor(AVolume InReferencedVolumeActor)
		{
			UKuroPostProcessComponent.__SetReferencedVolumeActor_Internal(base.NativePtr, (InReferencedVolumeActor != null) ? InReferencedVolumeActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AC5E RID: 109662 RVA: 0x00277452 File Offset: 0x00275652
		public void SetPPTODDataAsset(UKuroTODData InPPTODDataAsset)
		{
			UKuroPostProcessComponent.__SetPPTODDataAsset_Internal(base.NativePtr, (InPPTODDataAsset != null) ? InPPTODDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AC5F RID: 109663 RVA: 0x0027746F File Offset: 0x0027566F
		public void PostModify()
		{
			UKuroPostProcessComponent.__PostModify_Internal(base.NativePtr);
		}

		// Token: 0x0601AC60 RID: 109664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeatherDataAsset_Internal(IntPtr @this, IntPtr InWeatherDataAsset);

		// Token: 0x0601AC61 RID: 109665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReferencedVolumeActor_Internal(IntPtr @this, IntPtr InReferencedVolumeActor);

		// Token: 0x0601AC62 RID: 109666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPPTODDataAsset_Internal(IntPtr @this, IntPtr InPPTODDataAsset);

		// Token: 0x0601AC63 RID: 109667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostModify_Internal(IntPtr @this);

		// Token: 0x0601AC64 RID: 109668 RVA: 0x0027747C File Offset: 0x0027567C
		static UKuroPostProcessComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent");
		}

		// Token: 0x0601AC65 RID: 109669 RVA: 0x0027748A File Offset: 0x0027568A
		protected UKuroPostProcessComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E7AB RID: 59307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessComponent";

		// Token: 0x0400E7AC RID: 59308
		private static IntPtr _ClassPtr;

		// Token: 0x0400E7AD RID: 59309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E7AE RID: 59310
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x0400E7AF RID: 59311
		internal static int __PropertyOffset_PPTODDataAsset;

		// Token: 0x0400E7B0 RID: 59312
		internal static int __PropertyOffset_GISetting;

		// Token: 0x0400E7B1 RID: 59313
		private FKuroGISetting _GISetting;

		// Token: 0x0400E7B2 RID: 59314
		internal static int __PropertyOffset_CustomData;

		// Token: 0x0400E7B3 RID: 59315
		private FKuroGIPostProcessCustomData _CustomData;

		// Token: 0x0400E7B4 RID: 59316
		internal static int __PropertyOffset_ReferencedVolumeActor;

		// Token: 0x0400E7B5 RID: 59317
		internal static int __PropertyOffset_bUpdateOverrideWithTOD;
	}
}
