using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BAD RID: 2989
	[UnrealObjectPath("/Script/Engine.EventGraphFastCallPair")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FEventGraphFastCallPair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009296 RID: 37526 RVA: 0x000D2488 File Offset: 0x000D0688
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEventGraphFastCallPair._ScriptStructPtr != 0) ? FEventGraphFastCallPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EventGraphFastCallPair", ref FEventGraphFastCallPair._ScriptStructPtr);
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x000D24AC File Offset: 0x000D06AC
		// (set) Token: 0x06009298 RID: 37528 RVA: 0x000D24C0 File Offset: 0x000D06C0
		[Nullable(2)]
		public unsafe UFunction FunctionToPatch
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FEventGraphFastCallPair.__PropertyOffset_FunctionToPatch);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEventGraphFastCallPair.__PropertyOffset_FunctionToPatch, value);
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x06009299 RID: 37529 RVA: 0x000D24D5 File Offset: 0x000D06D5
		// (set) Token: 0x0600929A RID: 37530 RVA: 0x000D24E5 File Offset: 0x000D06E5
		public unsafe int EventGraphCallOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEventGraphFastCallPair.__PropertyOffset_EventGraphCallOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEventGraphFastCallPair.__PropertyOffset_EventGraphCallOffset) = value;
			}
		}

		// Token: 0x0600929B RID: 37531 RVA: 0x000D24F6 File Offset: 0x000D06F6
		public FEventGraphFastCallPair()
		{
		}

		// Token: 0x0600929C RID: 37532 RVA: 0x000D24FE File Offset: 0x000D06FE
		[NullableContext(1)]
		public FEventGraphFastCallPair(UFunction FunctionToPatch, int EventGraphCallOffset)
		{
			this.FunctionToPatch = FunctionToPatch;
			this.EventGraphCallOffset = EventGraphCallOffset;
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x000D2514 File Offset: 0x000D0714
		protected override IntPtr GetUStructPtr()
		{
			return FEventGraphFastCallPair.StaticStruct();
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x000D2520 File Offset: 0x000D0720
		[NullableContext(2)]
		public FEventGraphFastCallPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x000D252A File Offset: 0x000D072A
		public FEventGraphFastCallPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x000D2535 File Offset: 0x000D0735
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEventGraphFastCallPair(Pointer, false, true);
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x000D253F File Offset: 0x000D073F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEventGraphFastCallPair(Pointer, MemoryOwner);
		}

		// Token: 0x04005243 RID: 21059
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EventGraphFastCallPair";

		// Token: 0x04005244 RID: 21060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005245 RID: 21061
		internal static int __PropertyOffset_FunctionToPatch;

		// Token: 0x04005246 RID: 21062
		internal static int __PropertyOffset_EventGraphCallOffset;
	}
}
