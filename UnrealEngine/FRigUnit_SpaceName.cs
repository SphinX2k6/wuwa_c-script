using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D8 RID: 1752
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SpaceName")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_SpaceName : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DDA RID: 24026 RVA: 0x00086BC2 File Offset: 0x00084DC2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SpaceName._ScriptStructPtr != 0) ? FRigUnit_SpaceName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SpaceName", ref FRigUnit_SpaceName._ScriptStructPtr);
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06005DDB RID: 24027 RVA: 0x00086BE6 File Offset: 0x00084DE6
		// (set) Token: 0x06005DDC RID: 24028 RVA: 0x00086BFA File Offset: 0x00084DFA
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpaceName.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpaceName.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x00086C0F File Offset: 0x00084E0F
		public FRigUnit_SpaceName()
		{
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x00086C17 File Offset: 0x00084E17
		public FRigUnit_SpaceName(FName Space)
		{
			this.Space = Space;
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00086C26 File Offset: 0x00084E26
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SpaceName.StaticStruct();
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00086C32 File Offset: 0x00084E32
		[NullableContext(2)]
		public FRigUnit_SpaceName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00086C3C File Offset: 0x00084E3C
		public FRigUnit_SpaceName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00086C47 File Offset: 0x00084E47
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SpaceName(Pointer, false, true);
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00086C51 File Offset: 0x00084E51
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SpaceName(Pointer, MemoryOwner);
		}

		// Token: 0x04002BEC RID: 11244
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SpaceName";

		// Token: 0x04002BED RID: 11245
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BEE RID: 11246
		internal static int __PropertyOffset_Space;
	}
}
