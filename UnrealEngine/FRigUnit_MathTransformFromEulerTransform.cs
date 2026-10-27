using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000657 RID: 1623
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_MathTransformFromEulerTransform : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600568A RID: 22154 RVA: 0x0007D54C File Offset: 0x0007B74C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformFromEulerTransform._ScriptStructPtr != 0) ? FRigUnit_MathTransformFromEulerTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform", ref FRigUnit_MathTransformFromEulerTransform._ScriptStructPtr);
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x0007D570 File Offset: 0x0007B770
		// (set) Token: 0x0600568C RID: 22156 RVA: 0x0007D5B3 File Offset: 0x0007B7B3
		public FEulerTransform EulerTransform
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._EulerTransform) == null)
				{
					result = (this._EulerTransform = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromEulerTransform.__PropertyOffset_EulerTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathTransformFromEulerTransform.__PropertyOffset_EulerTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600568D RID: 22157 RVA: 0x0007D5D4 File Offset: 0x0007B7D4
		// (set) Token: 0x0600568E RID: 22158 RVA: 0x0007D5E8 File Offset: 0x0007B7E8
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromEulerTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromEulerTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x0007D5FD File Offset: 0x0007B7FD
		public FRigUnit_MathTransformFromEulerTransform()
		{
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x0007D605 File Offset: 0x0007B805
		public FRigUnit_MathTransformFromEulerTransform(FEulerTransform EulerTransform, FTransform Result)
		{
			this.EulerTransform = EulerTransform;
			this.Result = Result;
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x0007D61B File Offset: 0x0007B81B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformFromEulerTransform.StaticStruct();
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x0007D627 File Offset: 0x0007B827
		[NullableContext(2)]
		public FRigUnit_MathTransformFromEulerTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x0007D631 File Offset: 0x0007B831
		public FRigUnit_MathTransformFromEulerTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0007D63C File Offset: 0x0007B83C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformFromEulerTransform(Pointer, false, true);
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x0007D646 File Offset: 0x0007B846
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformFromEulerTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040028E7 RID: 10471
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformFromEulerTransform";

		// Token: 0x040028E8 RID: 10472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028E9 RID: 10473
		internal static int __PropertyOffset_EulerTransform;

		// Token: 0x040028EA RID: 10474
		[Nullable(2)]
		private FEulerTransform _EulerTransform;

		// Token: 0x040028EB RID: 10475
		internal static int __PropertyOffset_Result;
	}
}
