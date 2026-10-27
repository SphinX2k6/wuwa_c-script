using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F3 RID: 1779
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKSimple")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FRigUnit_TwoBoneIKSimple : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005FC4 RID: 24516 RVA: 0x000894D4 File Offset: 0x000876D4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKSimple._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKSimple._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimple", ref FRigUnit_TwoBoneIKSimple._ScriptStructPtr);
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x000894F8 File Offset: 0x000876F8
		// (set) Token: 0x06005FC6 RID: 24518 RVA: 0x0008950C File Offset: 0x0008770C
		public unsafe FName BoneA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneA) = value;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x00089521 File Offset: 0x00087721
		// (set) Token: 0x06005FC8 RID: 24520 RVA: 0x00089535 File Offset: 0x00087735
		public unsafe FName BoneB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneB) = value;
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06005FC9 RID: 24521 RVA: 0x0008954A File Offset: 0x0008774A
		// (set) Token: 0x06005FCA RID: 24522 RVA: 0x0008955E File Offset: 0x0008775E
		public unsafe FName EffectorBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_EffectorBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_EffectorBone) = value;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06005FCB RID: 24523 RVA: 0x00089573 File Offset: 0x00087773
		// (set) Token: 0x06005FCC RID: 24524 RVA: 0x00089587 File Offset: 0x00087787
		public unsafe FTransform Effector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_Effector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_Effector) = value;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06005FCD RID: 24525 RVA: 0x0008959C File Offset: 0x0008779C
		// (set) Token: 0x06005FCE RID: 24526 RVA: 0x000895B0 File Offset: 0x000877B0
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06005FCF RID: 24527 RVA: 0x000895C5 File Offset: 0x000877C5
		// (set) Token: 0x06005FD0 RID: 24528 RVA: 0x000895D9 File Offset: 0x000877D9
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06005FD1 RID: 24529 RVA: 0x000895EE File Offset: 0x000877EE
		// (set) Token: 0x06005FD2 RID: 24530 RVA: 0x000895FE File Offset: 0x000877FE
		public unsafe float SecondaryAxisWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_SecondaryAxisWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_SecondaryAxisWeight) = value;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06005FD3 RID: 24531 RVA: 0x0008960F File Offset: 0x0008780F
		// (set) Token: 0x06005FD4 RID: 24532 RVA: 0x00089623 File Offset: 0x00087823
		public unsafe FVector PoleVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVector) = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06005FD5 RID: 24533 RVA: 0x00089638 File Offset: 0x00087838
		// (set) Token: 0x06005FD6 RID: 24534 RVA: 0x00089648 File Offset: 0x00087848
		public unsafe EControlRigVectorKind PoleVectorKind
		{
			get
			{
				return (EControlRigVectorKind)(*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVectorKind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVectorKind) = (byte)value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06005FD7 RID: 24535 RVA: 0x00089659 File Offset: 0x00087859
		// (set) Token: 0x06005FD8 RID: 24536 RVA: 0x0008966D File Offset: 0x0008786D
		public unsafe FName PoleVectorSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVectorSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_PoleVectorSpace) = value;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x00089682 File Offset: 0x00087882
		// (set) Token: 0x06005FDA RID: 24538 RVA: 0x00089692 File Offset: 0x00087892
		public unsafe bool bEnableStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_bEnableStretch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_bEnableStretch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06005FDB RID: 24539 RVA: 0x000896A3 File Offset: 0x000878A3
		// (set) Token: 0x06005FDC RID: 24540 RVA: 0x000896B3 File Offset: 0x000878B3
		public unsafe float StretchStartRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_StretchStartRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_StretchStartRatio) = value;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06005FDD RID: 24541 RVA: 0x000896C4 File Offset: 0x000878C4
		// (set) Token: 0x06005FDE RID: 24542 RVA: 0x000896D4 File Offset: 0x000878D4
		public unsafe float StretchMaximumRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_StretchMaximumRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_StretchMaximumRatio) = value;
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x000896E5 File Offset: 0x000878E5
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x000896F5 File Offset: 0x000878F5
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x00089706 File Offset: 0x00087906
		// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x00089716 File Offset: 0x00087916
		public unsafe float BoneALength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneALength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneALength) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x00089727 File Offset: 0x00087927
		// (set) Token: 0x06005FE4 RID: 24548 RVA: 0x00089737 File Offset: 0x00087937
		public unsafe float BoneBLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneBLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_BoneBLength) = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06005FE5 RID: 24549 RVA: 0x00089748 File Offset: 0x00087948
		// (set) Token: 0x06005FE6 RID: 24550 RVA: 0x00089758 File Offset: 0x00087958
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x0008976C File Offset: 0x0008796C
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x000897AF File Offset: 0x000879AF
		public FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TwoBoneIKSimple_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_TwoBoneIKSimple_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TwoBoneIKSimple_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x000897D0 File Offset: 0x000879D0
		// (set) Token: 0x06005FEA RID: 24554 RVA: 0x00089813 File Offset: 0x00087A13
		public FCachedRigElement CachedBoneAIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBoneAIndex) == null)
				{
					result = (this._CachedBoneAIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedBoneAIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedBoneAIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x00089834 File Offset: 0x00087A34
		// (set) Token: 0x06005FEC RID: 24556 RVA: 0x00089877 File Offset: 0x00087A77
		public FCachedRigElement CachedBoneBIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBoneBIndex) == null)
				{
					result = (this._CachedBoneBIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedBoneBIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedBoneBIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x00089898 File Offset: 0x00087A98
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x000898DB File Offset: 0x00087ADB
		public FCachedRigElement CachedEffectorBoneIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedEffectorBoneIndex) == null)
				{
					result = (this._CachedEffectorBoneIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedEffectorBoneIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedEffectorBoneIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x000898FC File Offset: 0x00087AFC
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x0008993F File Offset: 0x00087B3F
		public FCachedRigElement CachedPoleVectorSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedPoleVectorSpaceIndex) == null)
				{
					result = (this._CachedPoleVectorSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedPoleVectorSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple.__PropertyOffset_CachedPoleVectorSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00089960 File Offset: 0x00087B60
		public FRigUnit_TwoBoneIKSimple()
		{
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x00089968 File Offset: 0x00087B68
		public FRigUnit_TwoBoneIKSimple(FName BoneA, FName BoneB, FName EffectorBone, FTransform Effector, FVector PrimaryAxis, FVector SecondaryAxis, float SecondaryAxisWeight, FVector PoleVector, EControlRigVectorKind PoleVectorKind, FName PoleVectorSpace, bool bEnableStretch, float StretchStartRatio, float StretchMaximumRatio, float Weight, float BoneALength, float BoneBLength, bool bPropagateToChildren, FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings, FCachedRigElement CachedBoneAIndex, FCachedRigElement CachedBoneBIndex, FCachedRigElement CachedEffectorBoneIndex, FCachedRigElement CachedPoleVectorSpaceIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.BoneA = BoneA;
			this.BoneB = BoneB;
			this.EffectorBone = EffectorBone;
			this.Effector = Effector;
			this.PrimaryAxis = PrimaryAxis;
			this.SecondaryAxis = SecondaryAxis;
			this.SecondaryAxisWeight = SecondaryAxisWeight;
			this.PoleVector = PoleVector;
			this.PoleVectorKind = PoleVectorKind;
			this.PoleVectorSpace = PoleVectorSpace;
			this.bEnableStretch = bEnableStretch;
			this.StretchStartRatio = StretchStartRatio;
			this.StretchMaximumRatio = StretchMaximumRatio;
			this.Weight = Weight;
			this.BoneALength = BoneALength;
			this.BoneBLength = BoneBLength;
			this.bPropagateToChildren = bPropagateToChildren;
			this.DebugSettings = DebugSettings;
			this.CachedBoneAIndex = CachedBoneAIndex;
			this.CachedBoneBIndex = CachedBoneBIndex;
			this.CachedEffectorBoneIndex = CachedEffectorBoneIndex;
			this.CachedPoleVectorSpaceIndex = CachedPoleVectorSpaceIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x00089A30 File Offset: 0x00087C30
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKSimple.StaticStruct();
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x00089A3C File Offset: 0x00087C3C
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKSimple(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x00089A46 File Offset: 0x00087C46
		public FRigUnit_TwoBoneIKSimple(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x00089A51 File Offset: 0x00087C51
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKSimple(Pointer, false, true);
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00089A5B File Offset: 0x00087C5B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKSimple(Pointer, MemoryOwner);
		}

		// Token: 0x04002CC5 RID: 11461
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKSimple";

		// Token: 0x04002CC6 RID: 11462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CC7 RID: 11463
		internal static int __PropertyOffset_BoneA;

		// Token: 0x04002CC8 RID: 11464
		internal static int __PropertyOffset_BoneB;

		// Token: 0x04002CC9 RID: 11465
		internal static int __PropertyOffset_EffectorBone;

		// Token: 0x04002CCA RID: 11466
		internal static int __PropertyOffset_Effector;

		// Token: 0x04002CCB RID: 11467
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x04002CCC RID: 11468
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x04002CCD RID: 11469
		internal static int __PropertyOffset_SecondaryAxisWeight;

		// Token: 0x04002CCE RID: 11470
		internal static int __PropertyOffset_PoleVector;

		// Token: 0x04002CCF RID: 11471
		internal static int __PropertyOffset_PoleVectorKind;

		// Token: 0x04002CD0 RID: 11472
		internal static int __PropertyOffset_PoleVectorSpace;

		// Token: 0x04002CD1 RID: 11473
		internal static int __PropertyOffset_bEnableStretch;

		// Token: 0x04002CD2 RID: 11474
		internal static int __PropertyOffset_StretchStartRatio;

		// Token: 0x04002CD3 RID: 11475
		internal static int __PropertyOffset_StretchMaximumRatio;

		// Token: 0x04002CD4 RID: 11476
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002CD5 RID: 11477
		internal static int __PropertyOffset_BoneALength;

		// Token: 0x04002CD6 RID: 11478
		internal static int __PropertyOffset_BoneBLength;

		// Token: 0x04002CD7 RID: 11479
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002CD8 RID: 11480
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x04002CD9 RID: 11481
		[Nullable(2)]
		private FRigUnit_TwoBoneIKSimple_DebugSettings _DebugSettings;

		// Token: 0x04002CDA RID: 11482
		internal static int __PropertyOffset_CachedBoneAIndex;

		// Token: 0x04002CDB RID: 11483
		[Nullable(2)]
		private FCachedRigElement _CachedBoneAIndex;

		// Token: 0x04002CDC RID: 11484
		internal static int __PropertyOffset_CachedBoneBIndex;

		// Token: 0x04002CDD RID: 11485
		[Nullable(2)]
		private FCachedRigElement _CachedBoneBIndex;

		// Token: 0x04002CDE RID: 11486
		internal static int __PropertyOffset_CachedEffectorBoneIndex;

		// Token: 0x04002CDF RID: 11487
		[Nullable(2)]
		private FCachedRigElement _CachedEffectorBoneIndex;

		// Token: 0x04002CE0 RID: 11488
		internal static int __PropertyOffset_CachedPoleVectorSpaceIndex;

		// Token: 0x04002CE1 RID: 11489
		[Nullable(2)]
		private FCachedRigElement _CachedPoleVectorSpaceIndex;
	}
}
