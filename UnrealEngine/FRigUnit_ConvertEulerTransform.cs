using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000577 RID: 1399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertEulerTransform")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_ConvertEulerTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A80 RID: 19072 RVA: 0x0006EA13 File Offset: 0x0006CC13
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertEulerTransform._ScriptStructPtr != 0) ? FRigUnit_ConvertEulerTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertEulerTransform", ref FRigUnit_ConvertEulerTransform._ScriptStructPtr);
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x0006EA38 File Offset: 0x0006CC38
		// (set) Token: 0x06004A82 RID: 19074 RVA: 0x0006EA7B File Offset: 0x0006CC7B
		public FEulerTransform Input
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_ConvertEulerTransform.__PropertyOffset_Input, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ConvertEulerTransform.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x0006EA9C File Offset: 0x0006CC9C
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertEulerTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertEulerTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x0006EAC5 File Offset: 0x0006CCC5
		public FRigUnit_ConvertEulerTransform()
		{
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x0006EACD File Offset: 0x0006CCCD
		public FRigUnit_ConvertEulerTransform(FEulerTransform Input, FTransform Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x0006EAE3 File Offset: 0x0006CCE3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertEulerTransform.StaticStruct();
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x0006EAEF File Offset: 0x0006CCEF
		[NullableContext(2)]
		public FRigUnit_ConvertEulerTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x0006EAF9 File Offset: 0x0006CCF9
		public FRigUnit_ConvertEulerTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x0006EB04 File Offset: 0x0006CD04
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertEulerTransform(Pointer, false, true);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x0006EB0E File Offset: 0x0006CD0E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertEulerTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0400242D RID: 9261
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertEulerTransform";

		// Token: 0x0400242E RID: 9262
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400242F RID: 9263
		internal static int __PropertyOffset_Input;

		// Token: 0x04002430 RID: 9264
		[Nullable(2)]
		private FEulerTransform _Input;

		// Token: 0x04002431 RID: 9265
		internal static int __PropertyOffset_Result;
	}
}
