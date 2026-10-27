using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000727 RID: 1831
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.FrameNumber")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FFrameNumber : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061CC RID: 25036 RVA: 0x0008C3C4 File Offset: 0x0008A5C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumber._ScriptStructPtr != 0) ? FFrameNumber._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumber", ref FFrameNumber._ScriptStructPtr);
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		// (set) Token: 0x060061CE RID: 25038 RVA: 0x0008C3F8 File Offset: 0x0008A5F8
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameNumber.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameNumber.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x0008C409 File Offset: 0x0008A609
		public FFrameNumber()
		{
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x0008C411 File Offset: 0x0008A611
		public FFrameNumber(int Value)
		{
			this.Value = Value;
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x0008C420 File Offset: 0x0008A620
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumber.StaticStruct();
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x0008C42C File Offset: 0x0008A62C
		[NullableContext(2)]
		public FFrameNumber(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x0008C436 File Offset: 0x0008A636
		public FFrameNumber(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x0008C441 File Offset: 0x0008A641
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumber(Pointer, false, true);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x0008C44B File Offset: 0x0008A64B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumber(Pointer, MemoryOwner);
		}

		// Token: 0x04002EB2 RID: 11954
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumber";

		// Token: 0x04002EB3 RID: 11955
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EB4 RID: 11956
		internal static int __PropertyOffset_Value;
	}
}
