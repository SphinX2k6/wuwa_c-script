using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000575 RID: 1397
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ControlName")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_ControlName : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A6C RID: 19052 RVA: 0x0006E8BD File Offset: 0x0006CABD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ControlName._ScriptStructPtr != 0) ? FRigUnit_ControlName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ControlName", ref FRigUnit_ControlName._ScriptStructPtr);
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x0006E8E1 File Offset: 0x0006CAE1
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x0006E8F5 File Offset: 0x0006CAF5
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ControlName.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ControlName.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0006E90A File Offset: 0x0006CB0A
		public FRigUnit_ControlName()
		{
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0006E912 File Offset: 0x0006CB12
		public FRigUnit_ControlName(FName Control)
		{
			this.Control = Control;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x0006E921 File Offset: 0x0006CB21
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ControlName.StaticStruct();
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x0006E92D File Offset: 0x0006CB2D
		[NullableContext(2)]
		public FRigUnit_ControlName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0006E937 File Offset: 0x0006CB37
		public FRigUnit_ControlName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0006E942 File Offset: 0x0006CB42
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ControlName(Pointer, false, true);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0006E94C File Offset: 0x0006CB4C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ControlName(Pointer, MemoryOwner);
		}

		// Token: 0x04002427 RID: 9255
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ControlName";

		// Token: 0x04002428 RID: 9256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002429 RID: 9257
		internal static int __PropertyOffset_Control;
	}
}
