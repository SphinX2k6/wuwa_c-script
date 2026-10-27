using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BBB RID: 7099
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSequentialSmartLightActor")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class AKuroSequentialSmartLightActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B2C5 RID: 111301 RVA: 0x00280980 File Offset: 0x0027EB80
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSequentialSmartLightActor._ClassPtr;
		}

		// Token: 0x0601B2C6 RID: 111302 RVA: 0x0028098C File Offset: 0x0027EB8C
		public AKuroSequentialSmartLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSequentialSmartLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B2C7 RID: 111303 RVA: 0x002809B4 File Offset: 0x0027EBB4
		[NullableContext(1)]
		public AKuroSequentialSmartLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSequentialSmartLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CFA RID: 27898
		// (get) Token: 0x0601B2C8 RID: 111304 RVA: 0x002809E7 File Offset: 0x0027EBE7
		// (set) Token: 0x0601B2C9 RID: 111305 RVA: 0x002809F7 File Offset: 0x0027EBF7
		public unsafe EKuroSmartLightActorDetectType DetectType
		{
			get
			{
				return (EKuroSmartLightActorDetectType)(*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectType) = (byte)value;
			}
		}

		// Token: 0x17006CFB RID: 27899
		// (get) Token: 0x0601B2CA RID: 111306 RVA: 0x00280A08 File Offset: 0x0027EC08
		// (set) Token: 0x0601B2CB RID: 111307 RVA: 0x00280A1C File Offset: 0x0027EC1C
		public unsafe FVector DetectCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectCenter) = value;
			}
		}

		// Token: 0x17006CFC RID: 27900
		// (get) Token: 0x0601B2CC RID: 111308 RVA: 0x00280A31 File Offset: 0x0027EC31
		// (set) Token: 0x0601B2CD RID: 111309 RVA: 0x00280A45 File Offset: 0x0027EC45
		public unsafe FVector DetectExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectExtent) = value;
			}
		}

		// Token: 0x17006CFD RID: 27901
		// (get) Token: 0x0601B2CE RID: 111310 RVA: 0x00280A5A File Offset: 0x0027EC5A
		// (set) Token: 0x0601B2CF RID: 111311 RVA: 0x00280A6A File Offset: 0x0027EC6A
		public unsafe float DetectRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DetectRadius) = value;
			}
		}

		// Token: 0x17006CFE RID: 27902
		// (get) Token: 0x0601B2D0 RID: 111312 RVA: 0x00280A7B File Offset: 0x0027EC7B
		// (set) Token: 0x0601B2D1 RID: 111313 RVA: 0x00280A8B File Offset: 0x0027EC8B
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006CFF RID: 27903
		// (get) Token: 0x0601B2D2 RID: 111314 RVA: 0x00280A9C File Offset: 0x0027EC9C
		// (set) Token: 0x0601B2D3 RID: 111315 RVA: 0x00280AAC File Offset: 0x0027ECAC
		public unsafe EKuroSequentialLightUpLogic LightUpLogic
		{
			get
			{
				return (EKuroSequentialLightUpLogic)(*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_LightUpLogic));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_LightUpLogic) = (byte)value;
			}
		}

		// Token: 0x17006D00 RID: 27904
		// (get) Token: 0x0601B2D4 RID: 111316 RVA: 0x00280ABD File Offset: 0x0027ECBD
		// (set) Token: 0x0601B2D5 RID: 111317 RVA: 0x00280ACD File Offset: 0x0027ECCD
		public unsafe EKuroLightUpSubMode_Distance DistanceSubMode
		{
			get
			{
				return (EKuroLightUpSubMode_Distance)(*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DistanceSubMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DistanceSubMode) = (byte)value;
			}
		}

		// Token: 0x17006D01 RID: 27905
		// (get) Token: 0x0601B2D6 RID: 111318 RVA: 0x00280ADE File Offset: 0x0027ECDE
		// (set) Token: 0x0601B2D7 RID: 111319 RVA: 0x00280AEE File Offset: 0x0027ECEE
		public unsafe EKuroLightUpSubMode_Index IndexSubMode
		{
			get
			{
				return (EKuroLightUpSubMode_Index)(*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_IndexSubMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_IndexSubMode) = (byte)value;
			}
		}

		// Token: 0x17006D02 RID: 27906
		// (get) Token: 0x0601B2D8 RID: 111320 RVA: 0x00280AFF File Offset: 0x0027ECFF
		// (set) Token: 0x0601B2D9 RID: 111321 RVA: 0x00280B0F File Offset: 0x0027ED0F
		public unsafe bool bIndexAscending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_bIndexAscending) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_bIndexAscending) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D03 RID: 27907
		// (get) Token: 0x0601B2DA RID: 111322 RVA: 0x00280B20 File Offset: 0x0027ED20
		// (set) Token: 0x0601B2DB RID: 111323 RVA: 0x00280B30 File Offset: 0x0027ED30
		public unsafe float DistanceRangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DistanceRangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_DistanceRangeSpeed) = value;
			}
		}

		// Token: 0x17006D04 RID: 27908
		// (get) Token: 0x0601B2DC RID: 111324 RVA: 0x00280B41 File Offset: 0x0027ED41
		// (set) Token: 0x0601B2DD RID: 111325 RVA: 0x00280B51 File Offset: 0x0027ED51
		public unsafe float GlobalLightUpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_GlobalLightUpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_GlobalLightUpTime) = value;
			}
		}

		// Token: 0x17006D05 RID: 27909
		// (get) Token: 0x0601B2DE RID: 111326 RVA: 0x00280B62 File Offset: 0x0027ED62
		// (set) Token: 0x0601B2DF RID: 111327 RVA: 0x00280B72 File Offset: 0x0027ED72
		public unsafe float GlobalLightOffTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_GlobalLightOffTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_GlobalLightOffTime) = value;
			}
		}

		// Token: 0x17006D06 RID: 27910
		// (get) Token: 0x0601B2E0 RID: 111328 RVA: 0x00280B83 File Offset: 0x0027ED83
		// (set) Token: 0x0601B2E1 RID: 111329 RVA: 0x00280B93 File Offset: 0x0027ED93
		public unsafe float LightUpInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_LightUpInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_LightUpInterval) = value;
			}
		}

		// Token: 0x17006D07 RID: 27911
		// (get) Token: 0x0601B2E2 RID: 111330 RVA: 0x00280BA4 File Offset: 0x0027EDA4
		// (set) Token: 0x0601B2E3 RID: 111331 RVA: 0x00280BB4 File Offset: 0x0027EDB4
		public unsafe float FadeInDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_FadeInDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_FadeInDelay) = value;
			}
		}

		// Token: 0x17006D08 RID: 27912
		// (get) Token: 0x0601B2E4 RID: 111332 RVA: 0x00280BC5 File Offset: 0x0027EDC5
		// (set) Token: 0x0601B2E5 RID: 111333 RVA: 0x00280BD5 File Offset: 0x0027EDD5
		public unsafe float FadeOutDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_FadeOutDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_FadeOutDelay) = value;
			}
		}

		// Token: 0x17006D09 RID: 27913
		// (get) Token: 0x0601B2E6 RID: 111334 RVA: 0x00280BE8 File Offset: 0x0027EDE8
		// (set) Token: 0x0601B2E7 RID: 111335 RVA: 0x00280C21 File Offset: 0x0027EE21
		[Nullable(1)]
		public TArray<UKuroSmartLightUnitComponent> LightUnits
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroSmartLightUnitComponent> result;
				if ((result = this._LightUnits) == null)
				{
					result = (this._LightUnits = new TArray<UKuroSmartLightUnitComponent>(base.NativePtr + (IntPtr)AKuroSequentialSmartLightActor.__PropertyOffset_LightUnits, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightUnits.CopyAssign(value);
			}
		}

		// Token: 0x17006D0A RID: 27914
		// (get) Token: 0x0601B2E8 RID: 111336 RVA: 0x00280C2F File Offset: 0x0027EE2F
		// (set) Token: 0x0601B2E9 RID: 111337 RVA: 0x00280C43 File Offset: 0x0027EE43
		public unsafe UKuroDebugDrawComponent DebugDrawComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroDebugDrawComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSequentialSmartLightActor.__PropertyOffset_DebugDrawComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSequentialSmartLightActor.__PropertyOffset_DebugDrawComponent, value);
			}
		}

		// Token: 0x17006D0B RID: 27915
		// (get) Token: 0x0601B2EA RID: 111338 RVA: 0x00280C58 File Offset: 0x0027EE58
		// (set) Token: 0x0601B2EB RID: 111339 RVA: 0x00280C6C File Offset: 0x0027EE6C
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSequentialSmartLightActor.__PropertyOffset_SceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSequentialSmartLightActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x0601B2EC RID: 111340 RVA: 0x00280C81 File Offset: 0x0027EE81
		public void RefreshLightUnits()
		{
			AKuroSequentialSmartLightActor.__RefreshLightUnits_Internal(base.NativePtr);
		}

		// Token: 0x0601B2ED RID: 111341 RVA: 0x00280C8E File Offset: 0x0027EE8E
		public virtual void OnSingleLightTurnedOn(UKuroSmartLightUnitComponent LightUnit)
		{
			AKuroSequentialSmartLightActor.__OnSingleLightTurnedOn_Internal(base.NativePtr, (LightUnit != null) ? LightUnit.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B2EE RID: 111342 RVA: 0x00280CAB File Offset: 0x0027EEAB
		public virtual void OnSingleLightTurnedOff(UKuroSmartLightUnitComponent LightUnit)
		{
			AKuroSequentialSmartLightActor.__OnSingleLightTurnedOff_Internal(base.NativePtr, (LightUnit != null) ? LightUnit.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B2EF RID: 111343 RVA: 0x00280CC8 File Offset: 0x0027EEC8
		public virtual void OnLightUpSequenceStarted()
		{
			AKuroSequentialSmartLightActor.__OnLightUpSequenceStarted_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F0 RID: 111344 RVA: 0x00280CD5 File Offset: 0x0027EED5
		public virtual void OnLightUpSequenceFinished()
		{
			AKuroSequentialSmartLightActor.__OnLightUpSequenceFinished_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F1 RID: 111345 RVA: 0x00280CE2 File Offset: 0x0027EEE2
		public virtual void OnLightOffSequenceStarted()
		{
			AKuroSequentialSmartLightActor.__OnLightOffSequenceStarted_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F2 RID: 111346 RVA: 0x00280CEF File Offset: 0x0027EEEF
		public virtual void OnLightOffSequenceFinished()
		{
			AKuroSequentialSmartLightActor.__OnLightOffSequenceFinished_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F3 RID: 111347 RVA: 0x00280CFC File Offset: 0x0027EEFC
		public void ForceLightUpSequenceEditorOnly()
		{
			AKuroSequentialSmartLightActor.__ForceLightUpSequenceEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F4 RID: 111348 RVA: 0x00280D09 File Offset: 0x0027EF09
		public void ForceLightOffSequenceEditorOnly()
		{
			AKuroSequentialSmartLightActor.__ForceLightOffSequenceEditorOnly_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F5 RID: 111349 RVA: 0x00280D16 File Offset: 0x0027EF16
		public void ForceAllLightUp()
		{
			AKuroSequentialSmartLightActor.__ForceAllLightUp_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F6 RID: 111350 RVA: 0x00280D23 File Offset: 0x0027EF23
		public void ForceAllLightOff()
		{
			AKuroSequentialSmartLightActor.__ForceAllLightOff_Internal(base.NativePtr);
		}

		// Token: 0x0601B2F7 RID: 111351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshLightUnits_Internal(IntPtr @this);

		// Token: 0x0601B2F8 RID: 111352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSingleLightTurnedOn_Internal(IntPtr @this, IntPtr LightUnit);

		// Token: 0x0601B2F9 RID: 111353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSingleLightTurnedOff_Internal(IntPtr @this, IntPtr LightUnit);

		// Token: 0x0601B2FA RID: 111354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLightUpSequenceStarted_Internal(IntPtr @this);

		// Token: 0x0601B2FB RID: 111355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLightUpSequenceFinished_Internal(IntPtr @this);

		// Token: 0x0601B2FC RID: 111356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLightOffSequenceStarted_Internal(IntPtr @this);

		// Token: 0x0601B2FD RID: 111357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLightOffSequenceFinished_Internal(IntPtr @this);

		// Token: 0x0601B2FE RID: 111358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceLightUpSequenceEditorOnly_Internal(IntPtr @this);

		// Token: 0x0601B2FF RID: 111359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceLightOffSequenceEditorOnly_Internal(IntPtr @this);

		// Token: 0x0601B300 RID: 111360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceAllLightUp_Internal(IntPtr @this);

		// Token: 0x0601B301 RID: 111361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceAllLightOff_Internal(IntPtr @this);

		// Token: 0x0601B302 RID: 111362 RVA: 0x00280D30 File Offset: 0x0027EF30
		static AKuroSequentialSmartLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSequentialSmartLightActor");
		}

		// Token: 0x0601B303 RID: 111363 RVA: 0x00280D3E File Offset: 0x0027EF3E
		protected AKuroSequentialSmartLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EA1B RID: 59931
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSequentialSmartLightActor";

		// Token: 0x0400EA1C RID: 59932
		private static IntPtr _ClassPtr;

		// Token: 0x0400EA1D RID: 59933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EA1E RID: 59934
		internal static int __PropertyOffset_DetectType;

		// Token: 0x0400EA1F RID: 59935
		internal static int __PropertyOffset_DetectCenter;

		// Token: 0x0400EA20 RID: 59936
		internal static int __PropertyOffset_DetectExtent;

		// Token: 0x0400EA21 RID: 59937
		internal static int __PropertyOffset_DetectRadius;

		// Token: 0x0400EA22 RID: 59938
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400EA23 RID: 59939
		internal static int __PropertyOffset_LightUpLogic;

		// Token: 0x0400EA24 RID: 59940
		internal static int __PropertyOffset_DistanceSubMode;

		// Token: 0x0400EA25 RID: 59941
		internal static int __PropertyOffset_IndexSubMode;

		// Token: 0x0400EA26 RID: 59942
		internal static int __PropertyOffset_bIndexAscending;

		// Token: 0x0400EA27 RID: 59943
		internal static int __PropertyOffset_DistanceRangeSpeed;

		// Token: 0x0400EA28 RID: 59944
		internal static int __PropertyOffset_GlobalLightUpTime;

		// Token: 0x0400EA29 RID: 59945
		internal static int __PropertyOffset_GlobalLightOffTime;

		// Token: 0x0400EA2A RID: 59946
		internal static int __PropertyOffset_LightUpInterval;

		// Token: 0x0400EA2B RID: 59947
		internal static int __PropertyOffset_FadeInDelay;

		// Token: 0x0400EA2C RID: 59948
		internal static int __PropertyOffset_FadeOutDelay;

		// Token: 0x0400EA2D RID: 59949
		internal static int __PropertyOffset_LightUnits;

		// Token: 0x0400EA2E RID: 59950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroSmartLightUnitComponent> _LightUnits;

		// Token: 0x0400EA2F RID: 59951
		internal static int __PropertyOffset_DebugDrawComponent;

		// Token: 0x0400EA30 RID: 59952
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x02003178 RID: 12664
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSingleLightTurnedOn_FunctionParams
		{
			// Token: 0x04016FAD RID: 94125
			[FieldOffset(0)]
			public IntPtr LightUnit;
		}

		// Token: 0x02003179 RID: 12665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSingleLightTurnedOff_FunctionParams
		{
			// Token: 0x04016FAE RID: 94126
			[FieldOffset(0)]
			public IntPtr LightUnit;
		}
	}
}
