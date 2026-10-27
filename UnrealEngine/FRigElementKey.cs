using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200051F RID: 1311
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/ControlRig.RigElementKey")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigElementKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044C4 RID: 17604 RVA: 0x00066662 File Offset: 0x00064862
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigElementKey._ScriptStructPtr != 0) ? FRigElementKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigElementKey", ref FRigElementKey._ScriptStructPtr);
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x00066686 File Offset: 0x00064886
		// (set) Token: 0x060044C6 RID: 17606 RVA: 0x00066696 File Offset: 0x00064896
		public unsafe ERigElementType Type
		{
			get
			{
				return (ERigElementType)(*(base.NativePtr + (IntPtr)FRigElementKey.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigElementKey.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x000666A7 File Offset: 0x000648A7
		// (set) Token: 0x060044C8 RID: 17608 RVA: 0x000666BB File Offset: 0x000648BB
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigElementKey.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigElementKey.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x000666D0 File Offset: 0x000648D0
		public FRigElementKey()
		{
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000666D8 File Offset: 0x000648D8
		public FRigElementKey(ERigElementType Type, FName Name)
		{
			this.Type = Type;
			this.Name = Name;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000666EE File Offset: 0x000648EE
		protected override IntPtr GetUStructPtr()
		{
			return FRigElementKey.StaticStruct();
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000666FA File Offset: 0x000648FA
		[NullableContext(2)]
		public FRigElementKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00066704 File Offset: 0x00064904
		public FRigElementKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x0006670F File Offset: 0x0006490F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigElementKey(Pointer, false, true);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00066719 File Offset: 0x00064919
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigElementKey(Pointer, MemoryOwner);
		}

		// Token: 0x04002181 RID: 8577
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigElementKey";

		// Token: 0x04002182 RID: 8578
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002183 RID: 8579
		internal static int __PropertyOffset_Type;

		// Token: 0x04002184 RID: 8580
		internal static int __PropertyOffset_Name;
	}
}
