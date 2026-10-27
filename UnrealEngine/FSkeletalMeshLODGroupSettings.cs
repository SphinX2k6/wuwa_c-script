using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010FC RID: 4348
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshLODGroupSettings")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FSkeletalMeshLODGroupSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC29 RID: 64553 RVA: 0x001742DA File Offset: 0x001724DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshLODGroupSettings._ScriptStructPtr != 0) ? FSkeletalMeshLODGroupSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshLODGroupSettings", ref FSkeletalMeshLODGroupSettings._ScriptStructPtr);
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600FC2A RID: 64554 RVA: 0x00174300 File Offset: 0x00172500
		// (set) Token: 0x0600FC2B RID: 64555 RVA: 0x00174343 File Offset: 0x00172543
		public FPerPlatformFloat ScreenSize
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ScreenSize) == null)
				{
					result = (this._ScreenSize = new FPerPlatformFloat(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_ScreenSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_ScreenSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600FC2C RID: 64556 RVA: 0x00174364 File Offset: 0x00172564
		// (set) Token: 0x0600FC2D RID: 64557 RVA: 0x001743A7 File Offset: 0x001725A7
		public FPerPlatformFloat KuroLODDistance
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroLODDistance) == null)
				{
					result = (this._KuroLODDistance = new FPerPlatformFloat(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_KuroLODDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_KuroLODDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600FC2E RID: 64558 RVA: 0x001743C8 File Offset: 0x001725C8
		// (set) Token: 0x0600FC2F RID: 64559 RVA: 0x001743D8 File Offset: 0x001725D8
		public unsafe float LODHysteresis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_LODHysteresis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_LODHysteresis) = value;
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600FC30 RID: 64560 RVA: 0x001743E9 File Offset: 0x001725E9
		// (set) Token: 0x0600FC31 RID: 64561 RVA: 0x001743F9 File Offset: 0x001725F9
		public unsafe EBoneFilterActionOption BoneFilterActionOption
		{
			get
			{
				return (EBoneFilterActionOption)(*(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_BoneFilterActionOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_BoneFilterActionOption) = (byte)value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600FC32 RID: 64562 RVA: 0x0017440C File Offset: 0x0017260C
		// (set) Token: 0x0600FC33 RID: 64563 RVA: 0x0017444F File Offset: 0x0017264F
		public TArray<FBoneFilter> BoneList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneFilter> result;
				if ((result = this._BoneList) == null)
				{
					result = (this._BoneList = new TArray<FBoneFilter>(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_BoneList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneList.CopyAssign(value);
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600FC34 RID: 64564 RVA: 0x00174460 File Offset: 0x00172660
		// (set) Token: 0x0600FC35 RID: 64565 RVA: 0x001744A3 File Offset: 0x001726A3
		public TArray<FName> BonesToPrioritize
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BonesToPrioritize) == null)
				{
					result = (this._BonesToPrioritize = new TArray<FName>(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_BonesToPrioritize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BonesToPrioritize.CopyAssign(value);
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600FC36 RID: 64566 RVA: 0x001744B1 File Offset: 0x001726B1
		// (set) Token: 0x0600FC37 RID: 64567 RVA: 0x001744C1 File Offset: 0x001726C1
		public unsafe float WeightOfPrioritization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_WeightOfPrioritization);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_WeightOfPrioritization) = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600FC38 RID: 64568 RVA: 0x001744D2 File Offset: 0x001726D2
		// (set) Token: 0x0600FC39 RID: 64569 RVA: 0x001744E6 File Offset: 0x001726E6
		[Nullable(2)]
		public unsafe UAnimSequence BakePose
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODGroupSettings.__PropertyOffset_BakePose);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMeshLODGroupSettings.__PropertyOffset_BakePose, value);
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600FC3A RID: 64570 RVA: 0x001744FC File Offset: 0x001726FC
		// (set) Token: 0x0600FC3B RID: 64571 RVA: 0x0017453F File Offset: 0x0017273F
		public FSkeletalMeshOptimizationSettings ReductionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletalMeshOptimizationSettings result;
				if ((result = this._ReductionSettings) == null)
				{
					result = (this._ReductionSettings = new FSkeletalMeshOptimizationSettings(base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_ReductionSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletalMeshOptimizationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMeshLODGroupSettings.__PropertyOffset_ReductionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600FC3C RID: 64572 RVA: 0x00174560 File Offset: 0x00172760
		public FSkeletalMeshLODGroupSettings()
		{
		}

		// Token: 0x0600FC3D RID: 64573 RVA: 0x00174568 File Offset: 0x00172768
		public FSkeletalMeshLODGroupSettings(FPerPlatformFloat ScreenSize, FPerPlatformFloat KuroLODDistance, float LODHysteresis, EBoneFilterActionOption BoneFilterActionOption, TArray<FBoneFilter> BoneList, TArray<FName> BonesToPrioritize, float WeightOfPrioritization, UAnimSequence BakePose, FSkeletalMeshOptimizationSettings ReductionSettings)
		{
			this.ScreenSize = ScreenSize;
			this.KuroLODDistance = KuroLODDistance;
			this.LODHysteresis = LODHysteresis;
			this.BoneFilterActionOption = BoneFilterActionOption;
			this.BoneList = BoneList;
			this.BonesToPrioritize = BonesToPrioritize;
			this.WeightOfPrioritization = WeightOfPrioritization;
			this.BakePose = BakePose;
			this.ReductionSettings = ReductionSettings;
		}

		// Token: 0x0600FC3E RID: 64574 RVA: 0x001745C0 File Offset: 0x001727C0
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshLODGroupSettings.StaticStruct();
		}

		// Token: 0x0600FC3F RID: 64575 RVA: 0x001745CC File Offset: 0x001727CC
		[NullableContext(2)]
		public FSkeletalMeshLODGroupSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FC40 RID: 64576 RVA: 0x001745D6 File Offset: 0x001727D6
		public FSkeletalMeshLODGroupSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FC41 RID: 64577 RVA: 0x001745E1 File Offset: 0x001727E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshLODGroupSettings(Pointer, false, true);
		}

		// Token: 0x0600FC42 RID: 64578 RVA: 0x001745EB File Offset: 0x001727EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshLODGroupSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040087D1 RID: 34769
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshLODGroupSettings";

		// Token: 0x040087D2 RID: 34770
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040087D3 RID: 34771
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x040087D4 RID: 34772
		[Nullable(2)]
		private FPerPlatformFloat _ScreenSize;

		// Token: 0x040087D5 RID: 34773
		internal static int __PropertyOffset_KuroLODDistance;

		// Token: 0x040087D6 RID: 34774
		[Nullable(2)]
		private FPerPlatformFloat _KuroLODDistance;

		// Token: 0x040087D7 RID: 34775
		internal static int __PropertyOffset_LODHysteresis;

		// Token: 0x040087D8 RID: 34776
		internal static int __PropertyOffset_BoneFilterActionOption;

		// Token: 0x040087D9 RID: 34777
		internal static int __PropertyOffset_BoneList;

		// Token: 0x040087DA RID: 34778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneFilter> _BoneList;

		// Token: 0x040087DB RID: 34779
		internal static int __PropertyOffset_BonesToPrioritize;

		// Token: 0x040087DC RID: 34780
		[Nullable(2)]
		private TArray<FName> _BonesToPrioritize;

		// Token: 0x040087DD RID: 34781
		internal static int __PropertyOffset_WeightOfPrioritization;

		// Token: 0x040087DE RID: 34782
		internal static int __PropertyOffset_BakePose;

		// Token: 0x040087DF RID: 34783
		internal static int __PropertyOffset_ReductionSettings;

		// Token: 0x040087E0 RID: 34784
		[Nullable(2)]
		private FSkeletalMeshOptimizationSettings _ReductionSettings;
	}
}
