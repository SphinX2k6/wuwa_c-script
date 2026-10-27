using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200059A RID: 1434
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DistributeRotationForCollection")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FRigUnit_DistributeRotationForCollection : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CF5 RID: 19701 RVA: 0x00071C18 File Offset: 0x0006FE18
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DistributeRotationForCollection._ScriptStructPtr != 0) ? FRigUnit_DistributeRotationForCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DistributeRotationForCollection", ref FRigUnit_DistributeRotationForCollection._ScriptStructPtr);
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x00071C3C File Offset: 0x0006FE3C
		// (set) Token: 0x06004CF7 RID: 19703 RVA: 0x00071C7F File Offset: 0x0006FE7F
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		// (set) Token: 0x06004CF9 RID: 19705 RVA: 0x00071CE3 File Offset: 0x0006FEE3
		public TArray<FRigUnit_DistributeRotation_Rotation> Rotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_DistributeRotation_Rotation> result;
				if ((result = this._Rotations) == null)
				{
					result = (this._Rotations = new TArray<FRigUnit_DistributeRotation_Rotation>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_Rotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotations.CopyAssign(value);
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00071CF1 File Offset: 0x0006FEF1
		// (set) Token: 0x06004CFB RID: 19707 RVA: 0x00071D01 File Offset: 0x0006FF01
		public unsafe EControlRigAnimEasingType RotationEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_RotationEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_RotationEaseType) = (byte)value;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x00071D12 File Offset: 0x0006FF12
		// (set) Token: 0x06004CFD RID: 19709 RVA: 0x00071D22 File Offset: 0x0006FF22
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x00071D34 File Offset: 0x0006FF34
		// (set) Token: 0x06004CFF RID: 19711 RVA: 0x00071D77 File Offset: 0x0006FF77
		public FRigUnit_DistributeRotation_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_DistributeRotation_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_DistributeRotation_WorkData(base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_DistributeRotation_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DistributeRotationForCollection.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00071D98 File Offset: 0x0006FF98
		public FRigUnit_DistributeRotationForCollection()
		{
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00071DA0 File Offset: 0x0006FFA0
		public FRigUnit_DistributeRotationForCollection(FRigElementKeyCollection Items, TArray<FRigUnit_DistributeRotation_Rotation> Rotations, EControlRigAnimEasingType RotationEaseType, float Weight, FRigUnit_DistributeRotation_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
			this.Rotations = Rotations;
			this.RotationEaseType = RotationEaseType;
			this.Weight = Weight;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x00071DD5 File Offset: 0x0006FFD5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DistributeRotationForCollection.StaticStruct();
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00071DE1 File Offset: 0x0006FFE1
		[NullableContext(2)]
		public FRigUnit_DistributeRotationForCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00071DEB File Offset: 0x0006FFEB
		public FRigUnit_DistributeRotationForCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00071DF6 File Offset: 0x0006FFF6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DistributeRotationForCollection(Pointer, false, true);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00071E00 File Offset: 0x00070000
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DistributeRotationForCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04002533 RID: 9523
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DistributeRotationForCollection";

		// Token: 0x04002534 RID: 9524
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002535 RID: 9525
		internal static int __PropertyOffset_Items;

		// Token: 0x04002536 RID: 9526
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x04002537 RID: 9527
		internal static int __PropertyOffset_Rotations;

		// Token: 0x04002538 RID: 9528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_DistributeRotation_Rotation> _Rotations;

		// Token: 0x04002539 RID: 9529
		internal static int __PropertyOffset_RotationEaseType;

		// Token: 0x0400253A RID: 9530
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400253B RID: 9531
		internal static int __PropertyOffset_WorkData;

		// Token: 0x0400253C RID: 9532
		[Nullable(2)]
		private FRigUnit_DistributeRotation_WorkData _WorkData;
	}
}
