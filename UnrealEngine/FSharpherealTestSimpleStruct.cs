using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200273A RID: 10042
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleStruct")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSharpherealTestSimpleStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060252C9 RID: 152265 RVA: 0x003711EA File Offset: 0x0036F3EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestSimpleStruct._ScriptStructPtr != 0) ? FSharpherealTestSimpleStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestSimpleStruct", ref FSharpherealTestSimpleStruct._ScriptStructPtr);
		}

		// Token: 0x17008F69 RID: 36713
		// (get) Token: 0x060252CA RID: 152266 RVA: 0x0037120E File Offset: 0x0036F40E
		// (set) Token: 0x060252CB RID: 152267 RVA: 0x00371222 File Offset: 0x0036F422
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

		// Token: 0x17008F6A RID: 36714
		// (get) Token: 0x060252CC RID: 152268 RVA: 0x00371237 File Offset: 0x0036F437
		// (set) Token: 0x060252CD RID: 152269 RVA: 0x0037124B File Offset: 0x0036F44B
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

		// Token: 0x060252CE RID: 152270 RVA: 0x00371260 File Offset: 0x0036F460
		public FSharpherealTestSimpleStruct()
		{
		}

		// Token: 0x060252CF RID: 152271 RVA: 0x00371268 File Offset: 0x0036F468
		public FSharpherealTestSimpleStruct(FVector Vector, string String)
		{
			this.Vector = Vector;
			this.String = String;
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x0037127E File Offset: 0x0036F47E
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestSimpleStruct.StaticStruct();
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x0037128A File Offset: 0x0036F48A
		[NullableContext(2)]
		public FSharpherealTestSimpleStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x00371294 File Offset: 0x0036F494
		public FSharpherealTestSimpleStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060252D3 RID: 152275 RVA: 0x0037129F File Offset: 0x0036F49F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestSimpleStruct(Pointer, false, true);
		}

		// Token: 0x060252D4 RID: 152276 RVA: 0x003712A9 File Offset: 0x0036F4A9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestSimpleStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014092 RID: 82066
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleStruct";

		// Token: 0x04014093 RID: 82067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014094 RID: 82068
		internal static int __PropertyOffset_Vector;

		// Token: 0x04014095 RID: 82069
		internal static int __PropertyOffset_String;
	}
}
