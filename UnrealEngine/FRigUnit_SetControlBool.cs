using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B6 RID: 1718
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlBool")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetControlBool : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BC1 RID: 23489 RVA: 0x00083BE9 File Offset: 0x00081DE9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlBool._ScriptStructPtr != 0) ? FRigUnit_SetControlBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlBool", ref FRigUnit_SetControlBool._ScriptStructPtr);
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06005BC2 RID: 23490 RVA: 0x00083C0D File Offset: 0x00081E0D
		// (set) Token: 0x06005BC3 RID: 23491 RVA: 0x00083C21 File Offset: 0x00081E21
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x00083C36 File Offset: 0x00081E36
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x00083C46 File Offset: 0x00081E46
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_BoolValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_BoolValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x00083C58 File Offset: 0x00081E58
		// (set) Token: 0x06005BC7 RID: 23495 RVA: 0x00083C9B File Offset: 0x00081E9B
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlBool.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00083CBC File Offset: 0x00081EBC
		public FRigUnit_SetControlBool()
		{
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00083CC4 File Offset: 0x00081EC4
		public FRigUnit_SetControlBool(FName Control, bool BoolValue, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.BoolValue = BoolValue;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00083CE9 File Offset: 0x00081EE9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlBool.StaticStruct();
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00083CF5 File Offset: 0x00081EF5
		[NullableContext(2)]
		public FRigUnit_SetControlBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00083CFF File Offset: 0x00081EFF
		public FRigUnit_SetControlBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00083D0A File Offset: 0x00081F0A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlBool(Pointer, false, true);
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x00083D14 File Offset: 0x00081F14
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlBool(Pointer, MemoryOwner);
		}

		// Token: 0x04002AF6 RID: 10998
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlBool";

		// Token: 0x04002AF7 RID: 10999
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AF8 RID: 11000
		internal static int __PropertyOffset_Control;

		// Token: 0x04002AF9 RID: 11001
		internal static int __PropertyOffset_BoolValue;

		// Token: 0x04002AFA RID: 11002
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002AFB RID: 11003
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
