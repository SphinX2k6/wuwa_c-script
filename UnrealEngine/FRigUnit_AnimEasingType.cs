using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200054B RID: 1355
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AnimEasingType")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_AnimEasingType : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600479B RID: 18331 RVA: 0x0006A550 File Offset: 0x00068750
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AnimEasingType._ScriptStructPtr != 0) ? FRigUnit_AnimEasingType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AnimEasingType", ref FRigUnit_AnimEasingType._ScriptStructPtr);
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x0006A574 File Offset: 0x00068774
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x0006A584 File Offset: 0x00068784
		public unsafe EControlRigAnimEasingType Type
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_AnimEasingType.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasingType.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x0006A595 File Offset: 0x00068795
		public FRigUnit_AnimEasingType()
		{
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x0006A59D File Offset: 0x0006879D
		public FRigUnit_AnimEasingType(EControlRigAnimEasingType Type)
		{
			this.Type = Type;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0006A5AC File Offset: 0x000687AC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AnimEasingType.StaticStruct();
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0006A5B8 File Offset: 0x000687B8
		[NullableContext(2)]
		public FRigUnit_AnimEasingType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0006A5C2 File Offset: 0x000687C2
		public FRigUnit_AnimEasingType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x0006A5CD File Offset: 0x000687CD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AnimEasingType(Pointer, false, true);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0006A5D7 File Offset: 0x000687D7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AnimEasingType(Pointer, MemoryOwner);
		}

		// Token: 0x040022CB RID: 8907
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AnimEasingType";

		// Token: 0x040022CC RID: 8908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022CD RID: 8909
		internal static int __PropertyOffset_Type;
	}
}
