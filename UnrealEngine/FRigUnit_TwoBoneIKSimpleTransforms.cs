using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F5 RID: 1781
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_TwoBoneIKSimpleTransforms : FRigUnit_HighlevelBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600602C RID: 24620 RVA: 0x0008A0E0 File Offset: 0x000882E0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKSimpleTransforms._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKSimpleTransforms._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms", ref FRigUnit_TwoBoneIKSimpleTransforms._ScriptStructPtr);
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x0600602D RID: 24621 RVA: 0x0008A104 File Offset: 0x00088304
		// (set) Token: 0x0600602E RID: 24622 RVA: 0x0008A118 File Offset: 0x00088318
		public unsafe FTransform Root
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Root);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Root) = value;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x0600602F RID: 24623 RVA: 0x0008A12D File Offset: 0x0008832D
		// (set) Token: 0x06006030 RID: 24624 RVA: 0x0008A141 File Offset: 0x00088341
		public unsafe FVector PoleVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_PoleVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_PoleVector) = value;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x0008A156 File Offset: 0x00088356
		// (set) Token: 0x06006032 RID: 24626 RVA: 0x0008A16A File Offset: 0x0008836A
		public unsafe FTransform Effector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Effector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Effector) = value;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x0008A17F File Offset: 0x0008837F
		// (set) Token: 0x06006034 RID: 24628 RVA: 0x0008A193 File Offset: 0x00088393
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x0008A1A8 File Offset: 0x000883A8
		// (set) Token: 0x06006036 RID: 24630 RVA: 0x0008A1BC File Offset: 0x000883BC
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x0008A1D1 File Offset: 0x000883D1
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x0008A1E1 File Offset: 0x000883E1
		public unsafe float SecondaryAxisWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_SecondaryAxisWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_SecondaryAxisWeight) = value;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x0008A1F2 File Offset: 0x000883F2
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x0008A202 File Offset: 0x00088402
		public unsafe bool bEnableStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_bEnableStretch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_bEnableStretch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x0008A213 File Offset: 0x00088413
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x0008A223 File Offset: 0x00088423
		public unsafe float StretchStartRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_StretchStartRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_StretchStartRatio) = value;
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600603D RID: 24637 RVA: 0x0008A234 File Offset: 0x00088434
		// (set) Token: 0x0600603E RID: 24638 RVA: 0x0008A244 File Offset: 0x00088444
		public unsafe float StretchMaximumRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_StretchMaximumRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_StretchMaximumRatio) = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x0008A255 File Offset: 0x00088455
		// (set) Token: 0x06006040 RID: 24640 RVA: 0x0008A265 File Offset: 0x00088465
		public unsafe float BoneALength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_BoneALength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_BoneALength) = value;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x0008A276 File Offset: 0x00088476
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x0008A286 File Offset: 0x00088486
		public unsafe float BoneBLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_BoneBLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_BoneBLength) = value;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x0008A297 File Offset: 0x00088497
		// (set) Token: 0x06006044 RID: 24644 RVA: 0x0008A2AB File Offset: 0x000884AB
		public unsafe FTransform Elbow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Elbow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleTransforms.__PropertyOffset_Elbow) = value;
			}
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x0008A2C0 File Offset: 0x000884C0
		public FRigUnit_TwoBoneIKSimpleTransforms()
		{
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x0008A2C8 File Offset: 0x000884C8
		public FRigUnit_TwoBoneIKSimpleTransforms(FTransform Root, FVector PoleVector, FTransform Effector, FVector PrimaryAxis, FVector SecondaryAxis, float SecondaryAxisWeight, bool bEnableStretch, float StretchStartRatio, float StretchMaximumRatio, float BoneALength, float BoneBLength, FTransform Elbow)
		{
			this.Root = Root;
			this.PoleVector = PoleVector;
			this.Effector = Effector;
			this.PrimaryAxis = PrimaryAxis;
			this.SecondaryAxis = SecondaryAxis;
			this.SecondaryAxisWeight = SecondaryAxisWeight;
			this.bEnableStretch = bEnableStretch;
			this.StretchStartRatio = StretchStartRatio;
			this.StretchMaximumRatio = StretchMaximumRatio;
			this.BoneALength = BoneALength;
			this.BoneBLength = BoneBLength;
			this.Elbow = Elbow;
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x0008A338 File Offset: 0x00088538
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKSimpleTransforms.StaticStruct();
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x0008A344 File Offset: 0x00088544
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKSimpleTransforms(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x0008A34E File Offset: 0x0008854E
		public FRigUnit_TwoBoneIKSimpleTransforms(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x0008A359 File Offset: 0x00088559
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKSimpleTransforms(Pointer, false, true);
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x0008A363 File Offset: 0x00088563
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKSimpleTransforms(Pointer, MemoryOwner);
		}

		// Token: 0x04002D03 RID: 11523
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms";

		// Token: 0x04002D04 RID: 11524
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D05 RID: 11525
		internal static int __PropertyOffset_Root;

		// Token: 0x04002D06 RID: 11526
		internal static int __PropertyOffset_PoleVector;

		// Token: 0x04002D07 RID: 11527
		internal static int __PropertyOffset_Effector;

		// Token: 0x04002D08 RID: 11528
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x04002D09 RID: 11529
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x04002D0A RID: 11530
		internal static int __PropertyOffset_SecondaryAxisWeight;

		// Token: 0x04002D0B RID: 11531
		internal static int __PropertyOffset_bEnableStretch;

		// Token: 0x04002D0C RID: 11532
		internal static int __PropertyOffset_StretchStartRatio;

		// Token: 0x04002D0D RID: 11533
		internal static int __PropertyOffset_StretchMaximumRatio;

		// Token: 0x04002D0E RID: 11534
		internal static int __PropertyOffset_BoneALength;

		// Token: 0x04002D0F RID: 11535
		internal static int __PropertyOffset_BoneBLength;

		// Token: 0x04002D10 RID: 11536
		internal static int __PropertyOffset_Elbow;
	}
}
