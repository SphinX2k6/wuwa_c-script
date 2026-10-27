using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B5 RID: 1205
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ConstraintNodeData")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FConstraintNodeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004026 RID: 16422 RVA: 0x000606D5 File Offset: 0x0005E8D5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintNodeData._ScriptStructPtr != 0) ? FConstraintNodeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ConstraintNodeData", ref FConstraintNodeData._ScriptStructPtr);
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x000606F9 File Offset: 0x0005E8F9
		// (set) Token: 0x06004028 RID: 16424 RVA: 0x0006070D File Offset: 0x0005E90D
		public unsafe FTransform RelativeParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_RelativeParent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_RelativeParent) = value;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x00060724 File Offset: 0x0005E924
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x00060767 File Offset: 0x0005E967
		public FConstraintOffset ConstraintOffset
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintOffset result;
				if ((result = this._ConstraintOffset) == null)
				{
					result = (this._ConstraintOffset = new FConstraintOffset(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_ConstraintOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintOffset.StaticStruct(), base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_ConstraintOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x00060788 File Offset: 0x0005E988
		// (set) Token: 0x0600402C RID: 16428 RVA: 0x0006079C File Offset: 0x0005E99C
		public unsafe FName LinkedNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_LinkedNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_LinkedNode) = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x000607B4 File Offset: 0x0005E9B4
		// (set) Token: 0x0600402E RID: 16430 RVA: 0x000607F7 File Offset: 0x0005E9F7
		public TArray<FTransformConstraint> Constraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransformConstraint> result;
				if ((result = this._Constraints) == null)
				{
					result = (this._Constraints = new TArray<FTransformConstraint>(base.NativePtr + (IntPtr)FConstraintNodeData.__PropertyOffset_Constraints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Constraints.CopyAssign(value);
			}
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00060805 File Offset: 0x0005EA05
		public FConstraintNodeData()
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0006080D File Offset: 0x0005EA0D
		public FConstraintNodeData(FTransform RelativeParent, FConstraintOffset ConstraintOffset, FName LinkedNode, TArray<FTransformConstraint> Constraints)
		{
			this.RelativeParent = RelativeParent;
			this.ConstraintOffset = ConstraintOffset;
			this.LinkedNode = LinkedNode;
			this.Constraints = Constraints;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00060832 File Offset: 0x0005EA32
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintNodeData.StaticStruct();
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x0006083E File Offset: 0x0005EA3E
		[NullableContext(2)]
		public FConstraintNodeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00060848 File Offset: 0x0005EA48
		public FConstraintNodeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00060853 File Offset: 0x0005EA53
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintNodeData(Pointer, false, true);
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0006085D File Offset: 0x0005EA5D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintNodeData(Pointer, MemoryOwner);
		}

		// Token: 0x04001EAC RID: 7852
		public const string __ObjectPath = "/Script/ControlRig.ConstraintNodeData";

		// Token: 0x04001EAD RID: 7853
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EAE RID: 7854
		internal static int __PropertyOffset_RelativeParent;

		// Token: 0x04001EAF RID: 7855
		internal static int __PropertyOffset_ConstraintOffset;

		// Token: 0x04001EB0 RID: 7856
		[Nullable(2)]
		private FConstraintOffset _ConstraintOffset;

		// Token: 0x04001EB1 RID: 7857
		internal static int __PropertyOffset_LinkedNode;

		// Token: 0x04001EB2 RID: 7858
		internal static int __PropertyOffset_Constraints;

		// Token: 0x04001EB3 RID: 7859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransformConstraint> _Constraints;
	}
}
