using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B7 RID: 1719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlColor")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRigUnit_SetControlColor : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BCF RID: 23503 RVA: 0x00083D1D File Offset: 0x00081F1D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlColor._ScriptStructPtr != 0) ? FRigUnit_SetControlColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlColor", ref FRigUnit_SetControlColor._ScriptStructPtr);
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x00083D41 File Offset: 0x00081F41
		// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x00083D55 File Offset: 0x00081F55
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x00083D6A File Offset: 0x00081F6A
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x00083D7E File Offset: 0x00081F7E
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x00083D94 File Offset: 0x00081F94
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x00083DD7 File Offset: 0x00081FD7
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlColor.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00083DF8 File Offset: 0x00081FF8
		public FRigUnit_SetControlColor()
		{
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x00083E00 File Offset: 0x00082000
		public FRigUnit_SetControlColor(FName Control, FLinearColor Color, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Color = Color;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00083E25 File Offset: 0x00082025
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlColor.StaticStruct();
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x00083E31 File Offset: 0x00082031
		[NullableContext(2)]
		public FRigUnit_SetControlColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00083E3B File Offset: 0x0008203B
		public FRigUnit_SetControlColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x00083E46 File Offset: 0x00082046
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlColor(Pointer, false, true);
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00083E50 File Offset: 0x00082050
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002AFC RID: 11004
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlColor";

		// Token: 0x04002AFD RID: 11005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AFE RID: 11006
		internal static int __PropertyOffset_Control;

		// Token: 0x04002AFF RID: 11007
		internal static int __PropertyOffset_Color;

		// Token: 0x04002B00 RID: 11008
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B01 RID: 11009
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
