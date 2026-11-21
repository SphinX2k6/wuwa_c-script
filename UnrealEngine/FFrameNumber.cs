using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200010D RID: 269
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.FrameNumber")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FFrameNumber : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x0001B460 File Offset: 0x00019660
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumber._ScriptStructPtr != 0) ? FFrameNumber._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumber", ref FFrameNumber._ScriptStructPtr);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0001B484 File Offset: 0x00019684
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0001B494 File Offset: 0x00019694
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

		// Token: 0x06001136 RID: 4406 RVA: 0x0001B4A5 File Offset: 0x000196A5
		public FFrameNumber()
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0001B4AD File Offset: 0x000196AD
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumber.StaticStruct();
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0001B4B9 File Offset: 0x000196B9
		[NullableContext(2)]
		public FFrameNumber(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0001B4C3 File Offset: 0x000196C3
		public FFrameNumber(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0001B4CE File Offset: 0x000196CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumber(Pointer, false, true);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0001B4D8 File Offset: 0x000196D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumber(Pointer, MemoryOwner);
		}

		// Token: 0x040004E8 RID: 1256
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumber";

		// Token: 0x040004E9 RID: 1257
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004EA RID: 1258
		internal static int __PropertyOffset_Value;
	}
}
