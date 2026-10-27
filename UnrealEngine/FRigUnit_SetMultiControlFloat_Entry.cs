using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C4 RID: 1732
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlFloat_Entry")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_SetMultiControlFloat_Entry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C97 RID: 23703 RVA: 0x00084E7E File Offset: 0x0008307E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlFloat_Entry._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlFloat_Entry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlFloat_Entry", ref FRigUnit_SetMultiControlFloat_Entry._ScriptStructPtr);
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06005C98 RID: 23704 RVA: 0x00084EA2 File Offset: 0x000830A2
		// (set) Token: 0x06005C99 RID: 23705 RVA: 0x00084EB6 File Offset: 0x000830B6
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat_Entry.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat_Entry.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06005C9A RID: 23706 RVA: 0x00084ECB File Offset: 0x000830CB
		// (set) Token: 0x06005C9B RID: 23707 RVA: 0x00084EDB File Offset: 0x000830DB
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat_Entry.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat_Entry.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00084EEC File Offset: 0x000830EC
		public FRigUnit_SetMultiControlFloat_Entry()
		{
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x00084EF4 File Offset: 0x000830F4
		public FRigUnit_SetMultiControlFloat_Entry(FName Control, float FloatValue)
		{
			this.Control = Control;
			this.FloatValue = FloatValue;
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x00084F0A File Offset: 0x0008310A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlFloat_Entry.StaticStruct();
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00084F16 File Offset: 0x00083116
		[NullableContext(2)]
		public FRigUnit_SetMultiControlFloat_Entry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00084F20 File Offset: 0x00083120
		public FRigUnit_SetMultiControlFloat_Entry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00084F2B File Offset: 0x0008312B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlFloat_Entry(Pointer, false, true);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00084F35 File Offset: 0x00083135
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlFloat_Entry(Pointer, MemoryOwner);
		}

		// Token: 0x04002B55 RID: 11093
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlFloat_Entry";

		// Token: 0x04002B56 RID: 11094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B57 RID: 11095
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B58 RID: 11096
		internal static int __PropertyOffset_FloatValue;
	}
}
