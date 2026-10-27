using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ECA RID: 3786
	[UnrealObjectPath("/Script/Engine.NamedTransform")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNamedTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCEA RID: 52458 RVA: 0x0012A754 File Offset: 0x00128954
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedTransform._ScriptStructPtr != 0) ? FNamedTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedTransform", ref FNamedTransform._ScriptStructPtr);
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x0012A778 File Offset: 0x00128978
		// (set) Token: 0x0600CCEC RID: 52460 RVA: 0x0012A78C File Offset: 0x0012898C
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600CCED RID: 52461 RVA: 0x0012A7A1 File Offset: 0x001289A1
		// (set) Token: 0x0600CCEE RID: 52462 RVA: 0x0012A7B5 File Offset: 0x001289B5
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedTransform.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedTransform.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x0012A7CA File Offset: 0x001289CA
		public FNamedTransform()
		{
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x0012A7D2 File Offset: 0x001289D2
		public FNamedTransform(FTransform Value, FName Name)
		{
			this.Value = Value;
			this.Name = Name;
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x0012A7E8 File Offset: 0x001289E8
		protected override IntPtr GetUStructPtr()
		{
			return FNamedTransform.StaticStruct();
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x0012A7F4 File Offset: 0x001289F4
		[NullableContext(2)]
		public FNamedTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x0012A7FE File Offset: 0x001289FE
		public FNamedTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x0012A809 File Offset: 0x00128A09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedTransform(Pointer, false, true);
		}

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x0012A813 File Offset: 0x00128A13
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04006E49 RID: 28233
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedTransform";

		// Token: 0x04006E4A RID: 28234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E4B RID: 28235
		internal static int __PropertyOffset_Value;

		// Token: 0x04006E4C RID: 28236
		internal static int __PropertyOffset_Name;
	}
}
