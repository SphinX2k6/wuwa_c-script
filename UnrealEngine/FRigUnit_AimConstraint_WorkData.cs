using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000544 RID: 1348
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimConstraint_WorkData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_AimConstraint_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004702 RID: 18178 RVA: 0x0006968C File Offset: 0x0006788C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimConstraint_WorkData._ScriptStructPtr != 0) ? FRigUnit_AimConstraint_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimConstraint_WorkData", ref FRigUnit_AimConstraint_WorkData._ScriptStructPtr);
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x000696B0 File Offset: 0x000678B0
		// (set) Token: 0x06004704 RID: 18180 RVA: 0x000696F3 File Offset: 0x000678F3
		public TArray<FConstraintData> ConstraintData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraintData> result;
				if ((result = this._ConstraintData) == null)
				{
					result = (this._ConstraintData = new TArray<FConstraintData>(base.NativePtr + (IntPtr)FRigUnit_AimConstraint_WorkData.__PropertyOffset_ConstraintData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConstraintData.CopyAssign(value);
			}
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00069701 File Offset: 0x00067901
		public FRigUnit_AimConstraint_WorkData()
		{
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00069709 File Offset: 0x00067909
		public FRigUnit_AimConstraint_WorkData(TArray<FConstraintData> ConstraintData)
		{
			this.ConstraintData = ConstraintData;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00069718 File Offset: 0x00067918
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimConstraint_WorkData.StaticStruct();
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00069724 File Offset: 0x00067924
		[NullableContext(2)]
		public FRigUnit_AimConstraint_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x0006972E File Offset: 0x0006792E
		public FRigUnit_AimConstraint_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00069739 File Offset: 0x00067939
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimConstraint_WorkData(Pointer, false, true);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00069743 File Offset: 0x00067943
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimConstraint_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x0400227D RID: 8829
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_AimConstraint_WorkData";

		// Token: 0x0400227E RID: 8830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400227F RID: 8831
		internal static int __PropertyOffset_ConstraintData;

		// Token: 0x04002280 RID: 8832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraintData> _ConstraintData;
	}
}
