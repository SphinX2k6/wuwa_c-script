using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ECB RID: 3787
	[UnrealObjectPath("/Script/Engine.NamedVector")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNamedVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCF6 RID: 52470 RVA: 0x0012A81C File Offset: 0x00128A1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedVector._ScriptStructPtr != 0) ? FNamedVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedVector", ref FNamedVector._ScriptStructPtr);
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600CCF7 RID: 52471 RVA: 0x0012A840 File Offset: 0x00128A40
		// (set) Token: 0x0600CCF8 RID: 52472 RVA: 0x0012A854 File Offset: 0x00128A54
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600CCF9 RID: 52473 RVA: 0x0012A869 File Offset: 0x00128A69
		// (set) Token: 0x0600CCFA RID: 52474 RVA: 0x0012A87D File Offset: 0x00128A7D
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedVector.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedVector.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x0012A892 File Offset: 0x00128A92
		public FNamedVector()
		{
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x0012A89A File Offset: 0x00128A9A
		public FNamedVector(FVector Value, FName Name)
		{
			this.Value = Value;
			this.Name = Name;
		}

		// Token: 0x0600CCFD RID: 52477 RVA: 0x0012A8B0 File Offset: 0x00128AB0
		protected override IntPtr GetUStructPtr()
		{
			return FNamedVector.StaticStruct();
		}

		// Token: 0x0600CCFE RID: 52478 RVA: 0x0012A8BC File Offset: 0x00128ABC
		[NullableContext(2)]
		public FNamedVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x0012A8C6 File Offset: 0x00128AC6
		public FNamedVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD00 RID: 52480 RVA: 0x0012A8D1 File Offset: 0x00128AD1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedVector(Pointer, false, true);
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x0012A8DB File Offset: 0x00128ADB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedVector(Pointer, MemoryOwner);
		}

		// Token: 0x04006E4D RID: 28237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedVector";

		// Token: 0x04006E4E RID: 28238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E4F RID: 28239
		internal static int __PropertyOffset_Value;

		// Token: 0x04006E50 RID: 28240
		internal static int __PropertyOffset_Name;
	}
}
