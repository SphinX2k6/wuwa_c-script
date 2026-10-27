using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200059C RID: 1436
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DistributeRotation_WorkData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_DistributeRotation_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D13 RID: 19731 RVA: 0x00071EC9 File Offset: 0x000700C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DistributeRotation_WorkData._ScriptStructPtr != 0) ? FRigUnit_DistributeRotation_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DistributeRotation_WorkData", ref FRigUnit_DistributeRotation_WorkData._ScriptStructPtr);
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x00071EF0 File Offset: 0x000700F0
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x00071F33 File Offset: 0x00070133
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x00071F44 File Offset: 0x00070144
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x00071F87 File Offset: 0x00070187
		public TArray<int> ItemRotationA
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ItemRotationA) == null)
				{
					result = (this._ItemRotationA = new TArray<int>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_WorkData.__PropertyOffset_ItemRotationA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationA.CopyAssign(value);
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x00071F98 File Offset: 0x00070198
		// (set) Token: 0x06004D19 RID: 19737 RVA: 0x00071FDB File Offset: 0x000701DB
		public TArray<int> ItemRotationB
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ItemRotationB) == null)
				{
					result = (this._ItemRotationB = new TArray<int>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_WorkData.__PropertyOffset_ItemRotationB, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationB.CopyAssign(value);
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x00071FEC File Offset: 0x000701EC
		// (set) Token: 0x06004D1B RID: 19739 RVA: 0x0007202F File Offset: 0x0007022F
		public TArray<float> ItemRotationT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ItemRotationT) == null)
				{
					result = (this._ItemRotationT = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_WorkData.__PropertyOffset_ItemRotationT, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationT.CopyAssign(value);
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x00072040 File Offset: 0x00070240
		// (set) Token: 0x06004D1D RID: 19741 RVA: 0x00072083 File Offset: 0x00070283
		public TArray<FTransform> ItemLocalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._ItemLocalTransforms) == null)
				{
					result = (this._ItemLocalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_WorkData.__PropertyOffset_ItemLocalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemLocalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00072091 File Offset: 0x00070291
		public FRigUnit_DistributeRotation_WorkData()
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00072099 File Offset: 0x00070299
		public FRigUnit_DistributeRotation_WorkData(TArray<FCachedRigElement> CachedItems, TArray<int> ItemRotationA, TArray<int> ItemRotationB, TArray<float> ItemRotationT, TArray<FTransform> ItemLocalTransforms)
		{
			this.CachedItems = CachedItems;
			this.ItemRotationA = ItemRotationA;
			this.ItemRotationB = ItemRotationB;
			this.ItemRotationT = ItemRotationT;
			this.ItemLocalTransforms = ItemLocalTransforms;
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x000720C6 File Offset: 0x000702C6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DistributeRotation_WorkData.StaticStruct();
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x000720D2 File Offset: 0x000702D2
		[NullableContext(2)]
		public FRigUnit_DistributeRotation_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x000720DC File Offset: 0x000702DC
		public FRigUnit_DistributeRotation_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x000720E7 File Offset: 0x000702E7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DistributeRotation_WorkData(Pointer, false, true);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000720F1 File Offset: 0x000702F1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DistributeRotation_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002541 RID: 9537
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_DistributeRotation_WorkData";

		// Token: 0x04002542 RID: 9538
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002543 RID: 9539
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x04002544 RID: 9540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x04002545 RID: 9541
		internal static int __PropertyOffset_ItemRotationA;

		// Token: 0x04002546 RID: 9542
		[Nullable(2)]
		private TArray<int> _ItemRotationA;

		// Token: 0x04002547 RID: 9543
		internal static int __PropertyOffset_ItemRotationB;

		// Token: 0x04002548 RID: 9544
		[Nullable(2)]
		private TArray<int> _ItemRotationB;

		// Token: 0x04002549 RID: 9545
		internal static int __PropertyOffset_ItemRotationT;

		// Token: 0x0400254A RID: 9546
		[Nullable(2)]
		private TArray<float> _ItemRotationT;

		// Token: 0x0400254B RID: 9547
		internal static int __PropertyOffset_ItemLocalTransforms;

		// Token: 0x0400254C RID: 9548
		[Nullable(2)]
		private TArray<FTransform> _ItemLocalTransforms;
	}
}
