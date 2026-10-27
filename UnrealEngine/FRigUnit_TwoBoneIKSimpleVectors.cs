using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F6 RID: 1782
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_TwoBoneIKSimpleVectors : FRigUnit_HighlevelBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600604C RID: 24652 RVA: 0x0008A36C File Offset: 0x0008856C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKSimpleVectors._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKSimpleVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors", ref FRigUnit_TwoBoneIKSimpleVectors._ScriptStructPtr);
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x0600604D RID: 24653 RVA: 0x0008A390 File Offset: 0x00088590
		// (set) Token: 0x0600604E RID: 24654 RVA: 0x0008A3A4 File Offset: 0x000885A4
		public unsafe FVector Root
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Root);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Root) = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x0008A3B9 File Offset: 0x000885B9
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x0008A3CD File Offset: 0x000885CD
		public unsafe FVector PoleVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_PoleVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_PoleVector) = value;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x0008A3E2 File Offset: 0x000885E2
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x0008A3F6 File Offset: 0x000885F6
		public unsafe FVector Effector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Effector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Effector) = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x0008A40B File Offset: 0x0008860B
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x0008A41B File Offset: 0x0008861B
		public unsafe bool bEnableStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_bEnableStretch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_bEnableStretch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x0008A42C File Offset: 0x0008862C
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x0008A43C File Offset: 0x0008863C
		public unsafe float StretchStartRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_StretchStartRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_StretchStartRatio) = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x0008A44D File Offset: 0x0008864D
		// (set) Token: 0x06006058 RID: 24664 RVA: 0x0008A45D File Offset: 0x0008865D
		public unsafe float StretchMaximumRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_StretchMaximumRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_StretchMaximumRatio) = value;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x0008A46E File Offset: 0x0008866E
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x0008A47E File Offset: 0x0008867E
		public unsafe float BoneALength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_BoneALength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_BoneALength) = value;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x0008A48F File Offset: 0x0008868F
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x0008A49F File Offset: 0x0008869F
		public unsafe float BoneBLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_BoneBLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_BoneBLength) = value;
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x0008A4B0 File Offset: 0x000886B0
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x0008A4C4 File Offset: 0x000886C4
		public unsafe FVector Elbow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Elbow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimpleVectors.__PropertyOffset_Elbow) = value;
			}
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x0008A4D9 File Offset: 0x000886D9
		public FRigUnit_TwoBoneIKSimpleVectors()
		{
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x0008A4E4 File Offset: 0x000886E4
		public FRigUnit_TwoBoneIKSimpleVectors(FVector Root, FVector PoleVector, FVector Effector, bool bEnableStretch, float StretchStartRatio, float StretchMaximumRatio, float BoneALength, float BoneBLength, FVector Elbow)
		{
			this.Root = Root;
			this.PoleVector = PoleVector;
			this.Effector = Effector;
			this.bEnableStretch = bEnableStretch;
			this.StretchStartRatio = StretchStartRatio;
			this.StretchMaximumRatio = StretchMaximumRatio;
			this.BoneALength = BoneALength;
			this.BoneBLength = BoneBLength;
			this.Elbow = Elbow;
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x0008A53C File Offset: 0x0008873C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKSimpleVectors.StaticStruct();
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x0008A548 File Offset: 0x00088748
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKSimpleVectors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x0008A552 File Offset: 0x00088752
		public FRigUnit_TwoBoneIKSimpleVectors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x0008A55D File Offset: 0x0008875D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKSimpleVectors(Pointer, false, true);
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x0008A567 File Offset: 0x00088767
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKSimpleVectors(Pointer, MemoryOwner);
		}

		// Token: 0x04002D11 RID: 11537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors";

		// Token: 0x04002D12 RID: 11538
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D13 RID: 11539
		internal static int __PropertyOffset_Root;

		// Token: 0x04002D14 RID: 11540
		internal static int __PropertyOffset_PoleVector;

		// Token: 0x04002D15 RID: 11541
		internal static int __PropertyOffset_Effector;

		// Token: 0x04002D16 RID: 11542
		internal static int __PropertyOffset_bEnableStretch;

		// Token: 0x04002D17 RID: 11543
		internal static int __PropertyOffset_StretchStartRatio;

		// Token: 0x04002D18 RID: 11544
		internal static int __PropertyOffset_StretchMaximumRatio;

		// Token: 0x04002D19 RID: 11545
		internal static int __PropertyOffset_BoneALength;

		// Token: 0x04002D1A RID: 11546
		internal static int __PropertyOffset_BoneBLength;

		// Token: 0x04002D1B RID: 11547
		internal static int __PropertyOffset_Elbow;
	}
}
