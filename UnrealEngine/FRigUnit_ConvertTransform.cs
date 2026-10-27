using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200057C RID: 1404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_ConvertTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004ABC RID: 19132 RVA: 0x0006EE37 File Offset: 0x0006D037
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertTransform._ScriptStructPtr != 0) ? FRigUnit_ConvertTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertTransform", ref FRigUnit_ConvertTransform._ScriptStructPtr);
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x0006EE5B File Offset: 0x0006D05B
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x0006EE6F File Offset: 0x0006D06F
		public unsafe FTransform Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertTransform.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertTransform.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x0006EE84 File Offset: 0x0006D084
		// (set) Token: 0x06004AC0 RID: 19136 RVA: 0x0006EEC7 File Offset: 0x0006D0C7
		public FEulerTransform Result
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._Result) == null)
				{
					result = (this._Result = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_ConvertTransform.__PropertyOffset_Result, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ConvertTransform.__PropertyOffset_Result, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
		public FRigUnit_ConvertTransform()
		{
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x0006EEF0 File Offset: 0x0006D0F0
		public FRigUnit_ConvertTransform(FTransform Input, FEulerTransform Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0006EF06 File Offset: 0x0006D106
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertTransform.StaticStruct();
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x0006EF12 File Offset: 0x0006D112
		[NullableContext(2)]
		public FRigUnit_ConvertTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x0006EF1C File Offset: 0x0006D11C
		public FRigUnit_ConvertTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0006EF27 File Offset: 0x0006D127
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertTransform(Pointer, false, true);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0006EF31 File Offset: 0x0006D131
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002442 RID: 9282
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertTransform";

		// Token: 0x04002443 RID: 9283
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002444 RID: 9284
		internal static int __PropertyOffset_Input;

		// Token: 0x04002445 RID: 9285
		internal static int __PropertyOffset_Result;

		// Token: 0x04002446 RID: 9286
		[Nullable(2)]
		private FEulerTransform _Result;
	}
}
