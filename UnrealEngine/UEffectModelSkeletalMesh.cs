using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CD RID: 973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelSkeletalMesh")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UEffectModelSkeletalMesh : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600603F RID: 24639 RVA: 0x00089357 File Offset: 0x00087557
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelSkeletalMesh._ClassPtr;
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x00089364 File Offset: 0x00087564
		public UEffectModelSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(UEffectModelSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0008938C File Offset: 0x0008758C
		public UEffectModelSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x000893BF File Offset: 0x000875BF
		// (set) Token: 0x06006043 RID: 24643 RVA: 0x000893D3 File Offset: 0x000875D3
		[Nullable(2)]
		public unsafe USkeletalMesh SkeletalMeshRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_SkeletalMeshRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_SkeletalMeshRef, value);
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x000893E8 File Offset: 0x000875E8
		// (set) Token: 0x06006045 RID: 24645 RVA: 0x000893FC File Offset: 0x000875FC
		[Nullable(2)]
		public unsafe UAnimationAsset AnimationRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_AnimationRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_AnimationRef, value);
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06006046 RID: 24646 RVA: 0x00089411 File Offset: 0x00087611
		// (set) Token: 0x06006047 RID: 24647 RVA: 0x00089421 File Offset: 0x00087621
		public unsafe int LodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_LodBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_LodBias) = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x00089432 File Offset: 0x00087632
		// (set) Token: 0x06006049 RID: 24649 RVA: 0x00089442 File Offset: 0x00087642
		public unsafe bool bForceLod0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceLod0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceLod0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600604A RID: 24650 RVA: 0x00089454 File Offset: 0x00087654
		// (set) Token: 0x0600604B RID: 24651 RVA: 0x0008948D File Offset: 0x0008768D
		public TArray<UMaterialInterface> ReplaceMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceMaterials) == null)
				{
					result = (this._ReplaceMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ReplaceMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600604C RID: 24652 RVA: 0x0008949B File Offset: 0x0008769B
		// (set) Token: 0x0600604D RID: 24653 RVA: 0x000894AB File Offset: 0x000876AB
		public unsafe bool Looping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Looping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Looping) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600604E RID: 24654 RVA: 0x000894BC File Offset: 0x000876BC
		// (set) Token: 0x0600604F RID: 24655 RVA: 0x000894CC File Offset: 0x000876CC
		public unsafe bool Playing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Playing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Playing) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06006050 RID: 24656 RVA: 0x000894E0 File Offset: 0x000876E0
		// (set) Token: 0x06006051 RID: 24657 RVA: 0x00089519 File Offset: 0x00087719
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06006052 RID: 24658 RVA: 0x0008953C File Offset: 0x0008773C
		// (set) Token: 0x06006053 RID: 24659 RVA: 0x00089575 File Offset: 0x00087775
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x00089598 File Offset: 0x00087798
		// (set) Token: 0x06006055 RID: 24661 RVA: 0x000895D1 File Offset: 0x000877D1
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x000895F2 File Offset: 0x000877F2
		// (set) Token: 0x06006057 RID: 24663 RVA: 0x00089602 File Offset: 0x00087802
		public unsafe bool EnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_EnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_EnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x00089613 File Offset: 0x00087813
		// (set) Token: 0x06006059 RID: 24665 RVA: 0x00089623 File Offset: 0x00087823
		public unsafe float HideFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_HideFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_HideFrames) = value;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x00089634 File Offset: 0x00087834
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x00089644 File Offset: 0x00087844
		public unsafe bool CastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_CastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_CastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00089655 File Offset: 0x00087855
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x00089665 File Offset: 0x00087865
		public unsafe bool ForbidCastToonShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ForbidCastToonShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ForbidCastToonShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x00089676 File Offset: 0x00087876
		// (set) Token: 0x0600605F RID: 24671 RVA: 0x00089686 File Offset: 0x00087886
		public unsafe bool bForceRenderInBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceRenderInBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceRenderInBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x00089698 File Offset: 0x00087898
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x000896D1 File Offset: 0x000878D1
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x000896E0 File Offset: 0x000878E0
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x00089719 File Offset: 0x00087919
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x00089727 File Offset: 0x00087927
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x00089737 File Offset: 0x00087937
		public unsafe bool bStopAnimWhenHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bStopAnimWhenHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bStopAnimWhenHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x00089748 File Offset: 0x00087948
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x00089758 File Offset: 0x00087958
		public unsafe bool bSyncOwnerMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bSyncOwnerMaterialController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bSyncOwnerMaterialController) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x00089769 File Offset: 0x00087969
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x00089779 File Offset: 0x00087979
		public unsafe bool bEnableKuroForceShears
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bEnableKuroForceShears) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bEnableKuroForceShears) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x0008978A File Offset: 0x0008798A
		static UEffectModelSkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelSkeletalMesh");
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00089798 File Offset: 0x00087998
		protected UEffectModelSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040028E2 RID: 10466
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelSkeletalMesh";

		// Token: 0x040028E3 RID: 10467
		private static IntPtr _ClassPtr;

		// Token: 0x040028E4 RID: 10468
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040028E5 RID: 10469
		internal static int __PropertyOffset_SkeletalMeshRef;

		// Token: 0x040028E6 RID: 10470
		internal static int __PropertyOffset_AnimationRef;

		// Token: 0x040028E7 RID: 10471
		internal static int __PropertyOffset_LodBias;

		// Token: 0x040028E8 RID: 10472
		internal static int __PropertyOffset_bForceLod0;

		// Token: 0x040028E9 RID: 10473
		internal static int __PropertyOffset_ReplaceMaterials;

		// Token: 0x040028EA RID: 10474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceMaterials;

		// Token: 0x040028EB RID: 10475
		internal static int __PropertyOffset_Looping;

		// Token: 0x040028EC RID: 10476
		internal static int __PropertyOffset_Playing;

		// Token: 0x040028ED RID: 10477
		internal static int __PropertyOffset_Location;

		// Token: 0x040028EE RID: 10478
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040028EF RID: 10479
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040028F0 RID: 10480
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x040028F1 RID: 10481
		internal static int __PropertyOffset_Scale;

		// Token: 0x040028F2 RID: 10482
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x040028F3 RID: 10483
		internal static int __PropertyOffset_EnableCollision;

		// Token: 0x040028F4 RID: 10484
		internal static int __PropertyOffset_HideFrames;

		// Token: 0x040028F5 RID: 10485
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x040028F6 RID: 10486
		internal static int __PropertyOffset_ForbidCastToonShadow;

		// Token: 0x040028F7 RID: 10487
		internal static int __PropertyOffset_bForceRenderInBurst;

		// Token: 0x040028F8 RID: 10488
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x040028F9 RID: 10489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x040028FA RID: 10490
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x040028FB RID: 10491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x040028FC RID: 10492
		internal static int __PropertyOffset_bStopAnimWhenHidden;

		// Token: 0x040028FD RID: 10493
		internal static int __PropertyOffset_bSyncOwnerMaterialController;

		// Token: 0x040028FE RID: 10494
		internal static int __PropertyOffset_bEnableKuroForceShears;
	}
}
