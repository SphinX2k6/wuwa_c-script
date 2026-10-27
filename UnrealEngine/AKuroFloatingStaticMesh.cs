using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AFC RID: 6908
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh")]
	[UnrealStructLayout(2448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2448)]
	public class AKuroFloatingStaticMesh : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject, IInterface_KuroVirtualParentBeAttachedNotify, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06019CE6 RID: 105702 RVA: 0x00261D61 File Offset: 0x0025FF61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFloatingStaticMesh._ClassPtr;
		}

		// Token: 0x06019CE7 RID: 105703 RVA: 0x00261D6D File Offset: 0x0025FF6D
		int IInterface_KuroVirtualParentBeAttachedNotify.InterfaceOffset()
		{
			return AKuroFloatingStaticMesh.__InterfaceOffset_IInterface_KuroVirtualParentBeAttachedNotify;
		}

		// Token: 0x06019CE8 RID: 105704 RVA: 0x00261D74 File Offset: 0x0025FF74
		public AKuroFloatingStaticMesh() : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CE9 RID: 105705 RVA: 0x00261D9C File Offset: 0x0025FF9C
		[NullableContext(1)]
		public AKuroFloatingStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700673F RID: 26431
		// (get) Token: 0x06019CEA RID: 105706 RVA: 0x00261DCF File Offset: 0x0025FFCF
		// (set) Token: 0x06019CEB RID: 105707 RVA: 0x00261DE3 File Offset: 0x0025FFE3
		public unsafe AKuroFloatingStaticMesh BindingActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroFloatingStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_BindingActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_BindingActor, value);
			}
		}

		// Token: 0x17006740 RID: 26432
		// (get) Token: 0x06019CEC RID: 105708 RVA: 0x00261DF8 File Offset: 0x0025FFF8
		// (set) Token: 0x06019CED RID: 105709 RVA: 0x00261E0C File Offset: 0x0026000C
		public unsafe FVector Movement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Movement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Movement) = value;
			}
		}

		// Token: 0x17006741 RID: 26433
		// (get) Token: 0x06019CEE RID: 105710 RVA: 0x00261E21 File Offset: 0x00260021
		// (set) Token: 0x06019CEF RID: 105711 RVA: 0x00261E31 File Offset: 0x00260031
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17006742 RID: 26434
		// (get) Token: 0x06019CF0 RID: 105712 RVA: 0x00261E44 File Offset: 0x00260044
		// (set) Token: 0x06019CF1 RID: 105713 RVA: 0x00261E7D File Offset: 0x0026007D
		[Nullable(1)]
		public FKuroCurveVector MovementCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._MovementCurve) == null)
				{
					result = (this._MovementCurve = new FKuroCurveVector(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_MovementCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_MovementCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006743 RID: 26435
		// (get) Token: 0x06019CF2 RID: 105714 RVA: 0x00261E9E File Offset: 0x0026009E
		// (set) Token: 0x06019CF3 RID: 105715 RVA: 0x00261EB2 File Offset: 0x002600B2
		public unsafe FVector RotateCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotateCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotateCenter) = value;
			}
		}

		// Token: 0x17006744 RID: 26436
		// (get) Token: 0x06019CF4 RID: 105716 RVA: 0x00261EC7 File Offset: 0x002600C7
		// (set) Token: 0x06019CF5 RID: 105717 RVA: 0x00261EDB File Offset: 0x002600DB
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17006745 RID: 26437
		// (get) Token: 0x06019CF6 RID: 105718 RVA: 0x00261EF0 File Offset: 0x002600F0
		// (set) Token: 0x06019CF7 RID: 105719 RVA: 0x00261F00 File Offset: 0x00260100
		public unsafe bool UseRotationRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_UseRotationRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_UseRotationRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006746 RID: 26438
		// (get) Token: 0x06019CF8 RID: 105720 RVA: 0x00261F11 File Offset: 0x00260111
		// (set) Token: 0x06019CF9 RID: 105721 RVA: 0x00261F25 File Offset: 0x00260125
		public unsafe FFloatRange RotationRangeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeX) = value;
			}
		}

		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x06019CFA RID: 105722 RVA: 0x00261F3A File Offset: 0x0026013A
		// (set) Token: 0x06019CFB RID: 105723 RVA: 0x00261F4E File Offset: 0x0026014E
		public unsafe FFloatRange RotationRangeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeY) = value;
			}
		}

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x06019CFC RID: 105724 RVA: 0x00261F63 File Offset: 0x00260163
		// (set) Token: 0x06019CFD RID: 105725 RVA: 0x00261F77 File Offset: 0x00260177
		public unsafe FFloatRange RotationRangeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationRangeZ) = value;
			}
		}

		// Token: 0x17006749 RID: 26441
		// (get) Token: 0x06019CFE RID: 105726 RVA: 0x00261F8C File Offset: 0x0026018C
		// (set) Token: 0x06019CFF RID: 105727 RVA: 0x00261FC5 File Offset: 0x002601C5
		[Nullable(1)]
		public FKuroCurveFloat RotationAlphaCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RotationAlphaCurve) == null)
				{
					result = (this._RotationAlphaCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationAlphaCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationAlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700674A RID: 26442
		// (get) Token: 0x06019D00 RID: 105728 RVA: 0x00261FE6 File Offset: 0x002601E6
		// (set) Token: 0x06019D01 RID: 105729 RVA: 0x00261FF6 File Offset: 0x002601F6
		public unsafe float RotationFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationFrequency) = value;
			}
		}

		// Token: 0x1700674B RID: 26443
		// (get) Token: 0x06019D02 RID: 105730 RVA: 0x00262007 File Offset: 0x00260207
		// (set) Token: 0x06019D03 RID: 105731 RVA: 0x00262017 File Offset: 0x00260217
		public unsafe float CurvePhaseOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_CurvePhaseOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_CurvePhaseOffset) = value;
			}
		}

		// Token: 0x1700674C RID: 26444
		// (get) Token: 0x06019D04 RID: 105732 RVA: 0x00262028 File Offset: 0x00260228
		// (set) Token: 0x06019D05 RID: 105733 RVA: 0x00262038 File Offset: 0x00260238
		public unsafe bool UseNullMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_UseNullMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_UseNullMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700674D RID: 26445
		// (get) Token: 0x06019D06 RID: 105734 RVA: 0x00262049 File Offset: 0x00260249
		// (set) Token: 0x06019D07 RID: 105735 RVA: 0x0026205D File Offset: 0x0026025D
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x1700674E RID: 26446
		// (get) Token: 0x06019D08 RID: 105736 RVA: 0x00262072 File Offset: 0x00260272
		// (set) Token: 0x06019D09 RID: 105737 RVA: 0x00262082 File Offset: 0x00260282
		public unsafe float TickFactorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_TickFactorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_TickFactorScale) = value;
			}
		}

		// Token: 0x1700674F RID: 26447
		// (get) Token: 0x06019D0A RID: 105738 RVA: 0x00262093 File Offset: 0x00260293
		// (set) Token: 0x06019D0B RID: 105739 RVA: 0x002620A3 File Offset: 0x002602A3
		public unsafe bool bEnableSequenceControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bEnableSequenceControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bEnableSequenceControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006750 RID: 26448
		// (get) Token: 0x06019D0C RID: 105740 RVA: 0x002620B4 File Offset: 0x002602B4
		// (set) Token: 0x06019D0D RID: 105741 RVA: 0x002620C4 File Offset: 0x002602C4
		public unsafe bool bEnableSequenceFullControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bEnableSequenceFullControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bEnableSequenceFullControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006751 RID: 26449
		// (get) Token: 0x06019D0E RID: 105742 RVA: 0x002620D5 File Offset: 0x002602D5
		// (set) Token: 0x06019D0F RID: 105743 RVA: 0x002620E5 File Offset: 0x002602E5
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x17006752 RID: 26450
		// (get) Token: 0x06019D10 RID: 105744 RVA: 0x002620F6 File Offset: 0x002602F6
		// (set) Token: 0x06019D11 RID: 105745 RVA: 0x0026210A File Offset: 0x0026030A
		public unsafe FVector MovementBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_MovementBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_MovementBias) = value;
			}
		}

		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x06019D12 RID: 105746 RVA: 0x0026211F File Offset: 0x0026031F
		// (set) Token: 0x06019D13 RID: 105747 RVA: 0x00262133 File Offset: 0x00260333
		public unsafe FVector RotationBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationBias) = value;
			}
		}

		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x06019D14 RID: 105748 RVA: 0x00262148 File Offset: 0x00260348
		// (set) Token: 0x06019D15 RID: 105749 RVA: 0x0026215C File Offset: 0x0026035C
		public unsafe FBoxSphereBounds CachedBounding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_CachedBounding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_CachedBounding) = value;
			}
		}

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x06019D16 RID: 105750 RVA: 0x00262171 File Offset: 0x00260371
		// (set) Token: 0x06019D17 RID: 105751 RVA: 0x0026218A File Offset: 0x0026038A
		public unsafe bool bHideLogicallyOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bHideLogicallyOnBeginPlay) & AKuroFloatingStaticMesh.__PropertyMask_bHideLogicallyOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bHideLogicallyOnBeginPlay) = ((*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bHideLogicallyOnBeginPlay) & ~AKuroFloatingStaticMesh.__PropertyMask_bHideLogicallyOnBeginPlay) | (value ? AKuroFloatingStaticMesh.__PropertyMask_bHideLogicallyOnBeginPlay : 0));
			}
		}

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x06019D18 RID: 105752 RVA: 0x002621BA File Offset: 0x002603BA
		// (set) Token: 0x06019D19 RID: 105753 RVA: 0x002621D3 File Offset: 0x002603D3
		public unsafe bool bUseMaxDistanceToDisableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bUseMaxDistanceToDisableCollision) & AKuroFloatingStaticMesh.__PropertyMask_bUseMaxDistanceToDisableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bUseMaxDistanceToDisableCollision) = ((*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_bUseMaxDistanceToDisableCollision) & ~AKuroFloatingStaticMesh.__PropertyMask_bUseMaxDistanceToDisableCollision) | (value ? AKuroFloatingStaticMesh.__PropertyMask_bUseMaxDistanceToDisableCollision : 0));
			}
		}

		// Token: 0x17006757 RID: 26455
		// (get) Token: 0x06019D1A RID: 105754 RVA: 0x00262203 File Offset: 0x00260403
		// (set) Token: 0x06019D1B RID: 105755 RVA: 0x00262213 File Offset: 0x00260413
		public unsafe bool SyncHiddenStateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_SyncHiddenStateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_SyncHiddenStateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006758 RID: 26456
		// (get) Token: 0x06019D1C RID: 105756 RVA: 0x00262224 File Offset: 0x00260424
		// (set) Token: 0x06019D1D RID: 105757 RVA: 0x00262238 File Offset: 0x00260438
		public unsafe UKuroAsyncMoveDebugComponent DebugDrawComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAsyncMoveDebugComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_DebugDrawComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_DebugDrawComponent, value);
			}
		}

		// Token: 0x06019D1E RID: 105758 RVA: 0x0026224D File Offset: 0x0026044D
		public void SetLogicallyShow(ECollisionEnabled Type)
		{
			AKuroFloatingStaticMesh.__SetLogicallyShow_Internal(base.NativePtr, Type);
		}

		// Token: 0x06019D1F RID: 105759 RVA: 0x00262260 File Offset: 0x00260460
		public void SetLogicallyHidden()
		{
			AKuroFloatingStaticMesh.__SetLogicallyHidden_Internal(base.NativePtr);
		}

		// Token: 0x06019D20 RID: 105760 RVA: 0x0026226D File Offset: 0x0026046D
		public void RecaptureBindingOffset()
		{
			AKuroFloatingStaticMesh.__RecaptureBindingOffset_Internal(base.NativePtr);
		}

		// Token: 0x06019D21 RID: 105761 RVA: 0x0026227A File Offset: 0x0026047A
		public bool GetLogicallyShow()
		{
			return AKuroFloatingStaticMesh.__GetLogicallyShow_Internal(base.NativePtr);
		}

		// Token: 0x06019D22 RID: 105762 RVA: 0x00262287 File Offset: 0x00260487
		public void CalculateBounds()
		{
			AKuroFloatingStaticMesh.__CalculateBounds_Internal(base.NativePtr);
		}

		// Token: 0x06019D23 RID: 105763
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyShow_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> Type);

		// Token: 0x06019D24 RID: 105764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyHidden_Internal(IntPtr @this);

		// Token: 0x06019D25 RID: 105765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecaptureBindingOffset_Internal(IntPtr @this);

		// Token: 0x06019D26 RID: 105766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLogicallyShow_Internal(IntPtr @this);

		// Token: 0x06019D27 RID: 105767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateBounds_Internal(IntPtr @this);

		// Token: 0x06019D28 RID: 105768 RVA: 0x00262294 File Offset: 0x00260494
		static AKuroFloatingStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh");
		}

		// Token: 0x06019D29 RID: 105769 RVA: 0x002622A2 File Offset: 0x002604A2
		protected AKuroFloatingStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E08A RID: 57482
		internal static int __InterfaceOffset_IInterface_KuroVirtualParentBeAttachedNotify;

		// Token: 0x0400E08B RID: 57483
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh";

		// Token: 0x0400E08C RID: 57484
		private static IntPtr _ClassPtr;

		// Token: 0x0400E08D RID: 57485
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E08E RID: 57486
		internal static int __PropertyOffset_BindingActor;

		// Token: 0x0400E08F RID: 57487
		internal static int __PropertyOffset_Movement;

		// Token: 0x0400E090 RID: 57488
		internal static int __PropertyOffset_Frequency;

		// Token: 0x0400E091 RID: 57489
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x0400E092 RID: 57490
		private FKuroCurveVector _MovementCurve;

		// Token: 0x0400E093 RID: 57491
		internal static int __PropertyOffset_RotateCenter;

		// Token: 0x0400E094 RID: 57492
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400E095 RID: 57493
		internal static int __PropertyOffset_UseRotationRange;

		// Token: 0x0400E096 RID: 57494
		internal static int __PropertyOffset_RotationRangeX;

		// Token: 0x0400E097 RID: 57495
		internal static int __PropertyOffset_RotationRangeY;

		// Token: 0x0400E098 RID: 57496
		internal static int __PropertyOffset_RotationRangeZ;

		// Token: 0x0400E099 RID: 57497
		internal static int __PropertyOffset_RotationAlphaCurve;

		// Token: 0x0400E09A RID: 57498
		private FKuroCurveFloat _RotationAlphaCurve;

		// Token: 0x0400E09B RID: 57499
		internal static int __PropertyOffset_RotationFrequency;

		// Token: 0x0400E09C RID: 57500
		internal static int __PropertyOffset_CurvePhaseOffset;

		// Token: 0x0400E09D RID: 57501
		internal static int __PropertyOffset_UseNullMesh;

		// Token: 0x0400E09E RID: 57502
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400E09F RID: 57503
		internal static int __PropertyOffset_TickFactorScale;

		// Token: 0x0400E0A0 RID: 57504
		internal static int __PropertyOffset_bEnableSequenceControl;

		// Token: 0x0400E0A1 RID: 57505
		internal static int __PropertyOffset_bEnableSequenceFullControl;

		// Token: 0x0400E0A2 RID: 57506
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0400E0A3 RID: 57507
		internal static int __PropertyOffset_MovementBias;

		// Token: 0x0400E0A4 RID: 57508
		internal static int __PropertyOffset_RotationBias;

		// Token: 0x0400E0A5 RID: 57509
		internal static int __PropertyOffset_CachedBounding;

		// Token: 0x0400E0A6 RID: 57510
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x0400E0A7 RID: 57511
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;

		// Token: 0x0400E0A8 RID: 57512
		internal static int __PropertyOffset_bUseMaxDistanceToDisableCollision;

		// Token: 0x0400E0A9 RID: 57513
		internal static byte __PropertyMask_bUseMaxDistanceToDisableCollision;

		// Token: 0x0400E0AA RID: 57514
		internal static int __PropertyOffset_SyncHiddenStateToChildren;

		// Token: 0x0400E0AB RID: 57515
		internal static int __PropertyOffset_DebugDrawComponent;
	}
}
