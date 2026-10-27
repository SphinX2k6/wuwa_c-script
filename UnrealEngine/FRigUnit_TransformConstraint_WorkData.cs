using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006EE RID: 1774
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TransformConstraint_WorkData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_TransformConstraint_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F50 RID: 24400 RVA: 0x00088A44 File Offset: 0x00086C44
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TransformConstraint_WorkData._ScriptStructPtr != 0) ? FRigUnit_TransformConstraint_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TransformConstraint_WorkData", ref FRigUnit_TransformConstraint_WorkData._ScriptStructPtr);
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x00088A68 File Offset: 0x00086C68
		// (set) Token: 0x06005F52 RID: 24402 RVA: 0x00088AAB File Offset: 0x00086CAB
		public TArray<FConstraintData> ConstraintData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraintData> result;
				if ((result = this._ConstraintData) == null)
				{
					result = (this._ConstraintData = new TArray<FConstraintData>(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint_WorkData.__PropertyOffset_ConstraintData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConstraintData.CopyAssign(value);
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06005F53 RID: 24403 RVA: 0x00088ABC File Offset: 0x00086CBC
		// (set) Token: 0x06005F54 RID: 24404 RVA: 0x00088AFF File Offset: 0x00086CFF
		public TMap<int, int> ConstraintDataToTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ConstraintDataToTargets) == null)
				{
					result = (this._ConstraintDataToTargets = new TMap<int, int>(base.NativePtr + (IntPtr)FRigUnit_TransformConstraint_WorkData.__PropertyOffset_ConstraintDataToTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConstraintDataToTargets.CopyAssign(value);
			}
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00088B0D File Offset: 0x00086D0D
		public FRigUnit_TransformConstraint_WorkData()
		{
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00088B15 File Offset: 0x00086D15
		public FRigUnit_TransformConstraint_WorkData(TArray<FConstraintData> ConstraintData, TMap<int, int> ConstraintDataToTargets)
		{
			this.ConstraintData = ConstraintData;
			this.ConstraintDataToTargets = ConstraintDataToTargets;
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x00088B2B File Offset: 0x00086D2B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TransformConstraint_WorkData.StaticStruct();
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x00088B37 File Offset: 0x00086D37
		[NullableContext(2)]
		public FRigUnit_TransformConstraint_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x00088B41 File Offset: 0x00086D41
		public FRigUnit_TransformConstraint_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00088B4C File Offset: 0x00086D4C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TransformConstraint_WorkData(Pointer, false, true);
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x00088B56 File Offset: 0x00086D56
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TransformConstraint_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002C8D RID: 11405
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_TransformConstraint_WorkData";

		// Token: 0x04002C8E RID: 11406
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C8F RID: 11407
		internal static int __PropertyOffset_ConstraintData;

		// Token: 0x04002C90 RID: 11408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraintData> _ConstraintData;

		// Token: 0x04002C91 RID: 11409
		internal static int __PropertyOffset_ConstraintDataToTargets;

		// Token: 0x04002C92 RID: 11410
		[Nullable(2)]
		private TMap<int, int> _ConstraintDataToTargets;
	}
}
