using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C9 RID: 1225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh")]
	[UnrealStructLayout(2448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2448)]
	public class AKuroFloatingStaticMesh : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070EC RID: 28908 RVA: 0x000A699E File Offset: 0x000A4B9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFloatingStaticMesh._ClassPtr;
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x000A69AC File Offset: 0x000A4BAC
		public AKuroFloatingStaticMesh() : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x000A69D4 File Offset: 0x000A4BD4
		public AKuroFloatingStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x000A6A07 File Offset: 0x000A4C07
		// (set) Token: 0x060070F0 RID: 28912 RVA: 0x000A6A1B File Offset: 0x000A4C1B
		[Nullable(2)]
		public unsafe AKuroFloatingStaticMesh BindingActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroFloatingStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_BindingActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_BindingActor, value);
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x000A6A30 File Offset: 0x000A4C30
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x000A6A44 File Offset: 0x000A4C44
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

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x060070F3 RID: 28915 RVA: 0x000A6A59 File Offset: 0x000A4C59
		// (set) Token: 0x060070F4 RID: 28916 RVA: 0x000A6A69 File Offset: 0x000A4C69
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

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060070F5 RID: 28917 RVA: 0x000A6A7C File Offset: 0x000A4C7C
		// (set) Token: 0x060070F6 RID: 28918 RVA: 0x000A6AB5 File Offset: 0x000A4CB5
		public FKuroCurveVector MovementCurve
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_MovementCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060070F7 RID: 28919 RVA: 0x000A6AD6 File Offset: 0x000A4CD6
		// (set) Token: 0x060070F8 RID: 28920 RVA: 0x000A6AEA File Offset: 0x000A4CEA
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

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060070F9 RID: 28921 RVA: 0x000A6AFF File Offset: 0x000A4CFF
		// (set) Token: 0x060070FA RID: 28922 RVA: 0x000A6B13 File Offset: 0x000A4D13
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

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x060070FB RID: 28923 RVA: 0x000A6B28 File Offset: 0x000A4D28
		// (set) Token: 0x060070FC RID: 28924 RVA: 0x000A6B38 File Offset: 0x000A4D38
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

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x060070FD RID: 28925 RVA: 0x000A6B49 File Offset: 0x000A4D49
		// (set) Token: 0x060070FE RID: 28926 RVA: 0x000A6B5D File Offset: 0x000A4D5D
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

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x060070FF RID: 28927 RVA: 0x000A6B72 File Offset: 0x000A4D72
		// (set) Token: 0x06007100 RID: 28928 RVA: 0x000A6B86 File Offset: 0x000A4D86
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

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06007101 RID: 28929 RVA: 0x000A6B9B File Offset: 0x000A4D9B
		// (set) Token: 0x06007102 RID: 28930 RVA: 0x000A6BAF File Offset: 0x000A4DAF
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

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06007103 RID: 28931 RVA: 0x000A6BC4 File Offset: 0x000A4DC4
		// (set) Token: 0x06007104 RID: 28932 RVA: 0x000A6BFD File Offset: 0x000A4DFD
		public FKuroCurveFloat RotationAlphaCurve
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroFloatingStaticMesh.__PropertyOffset_RotationAlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x000A6C1E File Offset: 0x000A4E1E
		// (set) Token: 0x06007106 RID: 28934 RVA: 0x000A6C2E File Offset: 0x000A4E2E
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06007107 RID: 28935 RVA: 0x000A6C3F File Offset: 0x000A4E3F
		// (set) Token: 0x06007108 RID: 28936 RVA: 0x000A6C4F File Offset: 0x000A4E4F
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

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06007109 RID: 28937 RVA: 0x000A6C60 File Offset: 0x000A4E60
		// (set) Token: 0x0600710A RID: 28938 RVA: 0x000A6C70 File Offset: 0x000A4E70
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x000A6C81 File Offset: 0x000A4E81
		// (set) Token: 0x0600710C RID: 28940 RVA: 0x000A6C95 File Offset: 0x000A4E95
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatingStaticMesh.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x0600710D RID: 28941 RVA: 0x000A6CAA File Offset: 0x000A4EAA
		// (set) Token: 0x0600710E RID: 28942 RVA: 0x000A6CBA File Offset: 0x000A4EBA
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

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x0600710F RID: 28943 RVA: 0x000A6CCB File Offset: 0x000A4ECB
		// (set) Token: 0x06007110 RID: 28944 RVA: 0x000A6CDB File Offset: 0x000A4EDB
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

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x000A6CEC File Offset: 0x000A4EEC
		// (set) Token: 0x06007112 RID: 28946 RVA: 0x000A6CFC File Offset: 0x000A4EFC
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06007113 RID: 28947 RVA: 0x000A6D0D File Offset: 0x000A4F0D
		// (set) Token: 0x06007114 RID: 28948 RVA: 0x000A6D1D File Offset: 0x000A4F1D
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

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06007115 RID: 28949 RVA: 0x000A6D2E File Offset: 0x000A4F2E
		// (set) Token: 0x06007116 RID: 28950 RVA: 0x000A6D42 File Offset: 0x000A4F42
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x000A6D57 File Offset: 0x000A4F57
		// (set) Token: 0x06007118 RID: 28952 RVA: 0x000A6D6B File Offset: 0x000A4F6B
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x000A6D80 File Offset: 0x000A4F80
		// (set) Token: 0x0600711A RID: 28954 RVA: 0x000A6D94 File Offset: 0x000A4F94
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

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x0600711B RID: 28955 RVA: 0x000A6DA9 File Offset: 0x000A4FA9
		// (set) Token: 0x0600711C RID: 28956 RVA: 0x000A6DC2 File Offset: 0x000A4FC2
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x000A6DF2 File Offset: 0x000A4FF2
		// (set) Token: 0x0600711E RID: 28958 RVA: 0x000A6E0B File Offset: 0x000A500B
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

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x0600711F RID: 28959 RVA: 0x000A6E3B File Offset: 0x000A503B
		// (set) Token: 0x06007120 RID: 28960 RVA: 0x000A6E4B File Offset: 0x000A504B
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

		// Token: 0x06007121 RID: 28961 RVA: 0x000A6E5C File Offset: 0x000A505C
		public void SetLogicallyShow(ECollisionEnabled Type)
		{
			AKuroFloatingStaticMesh.__SetLogicallyShow_Internal(base.NativePtr, Type);
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x000A6E6F File Offset: 0x000A506F
		public void SetLogicallyHidden()
		{
			AKuroFloatingStaticMesh.__SetLogicallyHidden_Internal(base.NativePtr);
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x000A6E7C File Offset: 0x000A507C
		public void RecaptureBindingOffset()
		{
			AKuroFloatingStaticMesh.__RecaptureBindingOffset_Internal(base.NativePtr);
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x000A6E89 File Offset: 0x000A5089
		public bool GetLogicallyShow()
		{
			return AKuroFloatingStaticMesh.__GetLogicallyShow_Internal(base.NativePtr);
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x000A6E96 File Offset: 0x000A5096
		public void CalculateBounds()
		{
			AKuroFloatingStaticMesh.__CalculateBounds_Internal(base.NativePtr);
		}

		// Token: 0x06007126 RID: 28966
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyShow_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> Type);

		// Token: 0x06007127 RID: 28967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyHidden_Internal(IntPtr @this);

		// Token: 0x06007128 RID: 28968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecaptureBindingOffset_Internal(IntPtr @this);

		// Token: 0x06007129 RID: 28969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLogicallyShow_Internal(IntPtr @this);

		// Token: 0x0600712A RID: 28970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateBounds_Internal(IntPtr @this);

		// Token: 0x0600712B RID: 28971 RVA: 0x000A6EA3 File Offset: 0x000A50A3
		static AKuroFloatingStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh");
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x000A6EB1 File Offset: 0x000A50B1
		protected AKuroFloatingStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030C5 RID: 12485
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingStaticMesh";

		// Token: 0x040030C6 RID: 12486
		private static IntPtr _ClassPtr;

		// Token: 0x040030C7 RID: 12487
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030C8 RID: 12488
		internal static int __PropertyOffset_BindingActor;

		// Token: 0x040030C9 RID: 12489
		internal static int __PropertyOffset_Movement;

		// Token: 0x040030CA RID: 12490
		internal static int __PropertyOffset_Frequency;

		// Token: 0x040030CB RID: 12491
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x040030CC RID: 12492
		[Nullable(2)]
		private FKuroCurveVector _MovementCurve;

		// Token: 0x040030CD RID: 12493
		internal static int __PropertyOffset_RotateCenter;

		// Token: 0x040030CE RID: 12494
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040030CF RID: 12495
		internal static int __PropertyOffset_UseRotationRange;

		// Token: 0x040030D0 RID: 12496
		internal static int __PropertyOffset_RotationRangeX;

		// Token: 0x040030D1 RID: 12497
		internal static int __PropertyOffset_RotationRangeY;

		// Token: 0x040030D2 RID: 12498
		internal static int __PropertyOffset_RotationRangeZ;

		// Token: 0x040030D3 RID: 12499
		internal static int __PropertyOffset_RotationAlphaCurve;

		// Token: 0x040030D4 RID: 12500
		[Nullable(2)]
		private FKuroCurveFloat _RotationAlphaCurve;

		// Token: 0x040030D5 RID: 12501
		internal static int __PropertyOffset_RotationFrequency;

		// Token: 0x040030D6 RID: 12502
		internal static int __PropertyOffset_CurvePhaseOffset;

		// Token: 0x040030D7 RID: 12503
		internal static int __PropertyOffset_UseNullMesh;

		// Token: 0x040030D8 RID: 12504
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x040030D9 RID: 12505
		internal static int __PropertyOffset_TickFactorScale;

		// Token: 0x040030DA RID: 12506
		internal static int __PropertyOffset_bEnableSequenceControl;

		// Token: 0x040030DB RID: 12507
		internal static int __PropertyOffset_bEnableSequenceFullControl;

		// Token: 0x040030DC RID: 12508
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x040030DD RID: 12509
		internal static int __PropertyOffset_MovementBias;

		// Token: 0x040030DE RID: 12510
		internal static int __PropertyOffset_RotationBias;

		// Token: 0x040030DF RID: 12511
		internal static int __PropertyOffset_CachedBounding;

		// Token: 0x040030E0 RID: 12512
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x040030E1 RID: 12513
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;

		// Token: 0x040030E2 RID: 12514
		internal static int __PropertyOffset_bUseMaxDistanceToDisableCollision;

		// Token: 0x040030E3 RID: 12515
		internal static byte __PropertyMask_bUseMaxDistanceToDisableCollision;

		// Token: 0x040030E4 RID: 12516
		internal static int __PropertyOffset_SyncHiddenStateToChildren;
	}
}
