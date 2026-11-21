using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007EF RID: 2031
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleStruct")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSharpherealTestSimpleStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ADB9 RID: 44473 RVA: 0x001011CE File Offset: 0x000FF3CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestSimpleStruct._ScriptStructPtr != 0) ? FSharpherealTestSimpleStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestSimpleStruct", ref FSharpherealTestSimpleStruct._ScriptStructPtr);
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x001011F2 File Offset: 0x000FF3F2
		// (set) Token: 0x0600ADBB RID: 44475 RVA: 0x00101206 File Offset: 0x000FF406
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestSimpleStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestSimpleStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x0010121B File Offset: 0x000FF41B
		// (set) Token: 0x0600ADBD RID: 44477 RVA: 0x0010122F File Offset: 0x000FF42F
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestSimpleStruct.__PropertyOffset_String)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestSimpleStruct.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x00101244 File Offset: 0x000FF444
		public FSharpherealTestSimpleStruct()
		{
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x0010124C File Offset: 0x000FF44C
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestSimpleStruct.StaticStruct();
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x00101258 File Offset: 0x000FF458
		[NullableContext(2)]
		public FSharpherealTestSimpleStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x00101262 File Offset: 0x000FF462
		public FSharpherealTestSimpleStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x0010126D File Offset: 0x000FF46D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestSimpleStruct(Pointer, false, true);
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x00101277 File Offset: 0x000FF477
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestSimpleStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04004AF5 RID: 19189
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleStruct";

		// Token: 0x04004AF6 RID: 19190
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004AF7 RID: 19191
		internal static int __PropertyOffset_Vector;

		// Token: 0x04004AF8 RID: 19192
		internal static int __PropertyOffset_String;
	}
}
