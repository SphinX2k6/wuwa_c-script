using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000660 RID: 1632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformToEulerTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_MathTransformToEulerTransform : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005704 RID: 22276 RVA: 0x0007DE2A File Offset: 0x0007C02A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformToEulerTransform._ScriptStructPtr != 0) ? FRigUnit_MathTransformToEulerTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformToEulerTransform", ref FRigUnit_MathTransformToEulerTransform._ScriptStructPtr);
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06005705 RID: 22277 RVA: 0x0007DE4E File Offset: 0x0007C04E
		// (set) Token: 0x06005706 RID: 22278 RVA: 0x0007DE62 File Offset: 0x0007C062
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformToEulerTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformToEulerTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x0007DE78 File Offset: 0x0007C078
		// (set) Token: 0x06005708 RID: 22280 RVA: 0x0007DEBB File Offset: 0x0007C0BB
		public FEulerTransform Result
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._Result) == null)
				{
					result = (this._Result = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_MathTransformToEulerTransform.__PropertyOffset_Result, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathTransformToEulerTransform.__PropertyOffset_Result, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x0007DEDC File Offset: 0x0007C0DC
		public FRigUnit_MathTransformToEulerTransform()
		{
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		public FRigUnit_MathTransformToEulerTransform(FTransform Value, FEulerTransform Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x0007DEFA File Offset: 0x0007C0FA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformToEulerTransform.StaticStruct();
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x0007DF06 File Offset: 0x0007C106
		[NullableContext(2)]
		public FRigUnit_MathTransformToEulerTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x0007DF10 File Offset: 0x0007C110
		public FRigUnit_MathTransformToEulerTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x0007DF1B File Offset: 0x0007C11B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformToEulerTransform(Pointer, false, true);
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x0007DF25 File Offset: 0x0007C125
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformToEulerTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002914 RID: 10516
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformToEulerTransform";

		// Token: 0x04002915 RID: 10517
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002916 RID: 10518
		internal static int __PropertyOffset_Value;

		// Token: 0x04002917 RID: 10519
		internal static int __PropertyOffset_Result;

		// Token: 0x04002918 RID: 10520
		[Nullable(2)]
		private FEulerTransform _Result;
	}
}
