using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002822 RID: 10274
	[UnrealObjectPath("/Script/SlateCore.MotionEvent")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMotionEvent : FInputEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262E2 RID: 156386 RVA: 0x0039F064 File Offset: 0x0039D264
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotionEvent._ScriptStructPtr != 0) ? FMotionEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.MotionEvent", ref FMotionEvent._ScriptStructPtr);
		}

		// Token: 0x060262E3 RID: 156387 RVA: 0x0039F088 File Offset: 0x0039D288
		public FMotionEvent()
		{
		}

		// Token: 0x060262E4 RID: 156388 RVA: 0x0039F090 File Offset: 0x0039D290
		protected override IntPtr GetUStructPtr()
		{
			return FMotionEvent.StaticStruct();
		}

		// Token: 0x060262E5 RID: 156389 RVA: 0x0039F09C File Offset: 0x0039D29C
		[NullableContext(2)]
		public FMotionEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262E6 RID: 156390 RVA: 0x0039F0A6 File Offset: 0x0039D2A6
		public FMotionEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262E7 RID: 156391 RVA: 0x0039F0B1 File Offset: 0x0039D2B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotionEvent(Pointer, false, true);
		}

		// Token: 0x060262E8 RID: 156392 RVA: 0x0039F0BB File Offset: 0x0039D2BB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotionEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E5C RID: 85596
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.MotionEvent";

		// Token: 0x04014E5D RID: 85597
		private static IntPtr _ScriptStructPtr;
	}
}
