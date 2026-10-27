using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011F2 RID: 4594
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.TimerHandle")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTimerHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F01 RID: 69377 RVA: 0x0018DDE2 File Offset: 0x0018BFE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimerHandle._ScriptStructPtr != 0) ? FTimerHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimerHandle", ref FTimerHandle._ScriptStructPtr);
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x06010F02 RID: 69378 RVA: 0x0018DE06 File Offset: 0x0018C006
		// (set) Token: 0x06010F03 RID: 69379 RVA: 0x0018DE16 File Offset: 0x0018C016
		public unsafe ulong Handle
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FTimerHandle.__PropertyOffset_Handle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimerHandle.__PropertyOffset_Handle) = (long)value;
			}
		}

		// Token: 0x06010F04 RID: 69380 RVA: 0x0018DE27 File Offset: 0x0018C027
		public FTimerHandle()
		{
		}

		// Token: 0x06010F05 RID: 69381 RVA: 0x0018DE2F File Offset: 0x0018C02F
		public FTimerHandle(ulong Handle)
		{
			this.Handle = Handle;
		}

		// Token: 0x06010F06 RID: 69382 RVA: 0x0018DE3E File Offset: 0x0018C03E
		protected override IntPtr GetUStructPtr()
		{
			return FTimerHandle.StaticStruct();
		}

		// Token: 0x06010F07 RID: 69383 RVA: 0x0018DE4A File Offset: 0x0018C04A
		[NullableContext(2)]
		public FTimerHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F08 RID: 69384 RVA: 0x0018DE54 File Offset: 0x0018C054
		public FTimerHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F09 RID: 69385 RVA: 0x0018DE5F File Offset: 0x0018C05F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimerHandle(Pointer, false, true);
		}

		// Token: 0x06010F0A RID: 69386 RVA: 0x0018DE69 File Offset: 0x0018C069
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimerHandle(Pointer, MemoryOwner);
		}

		// Token: 0x0400912C RID: 37164
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TimerHandle";

		// Token: 0x0400912D RID: 37165
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400912E RID: 37166
		internal static int __PropertyOffset_Handle;
	}
}
