using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200044A RID: 1098
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/KuroInput.InputModeReply")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FInputModeReply : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069F6 RID: 27126 RVA: 0x0009A981 File Offset: 0x00098B81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputModeReply._ScriptStructPtr != 0) ? FInputModeReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInput.InputModeReply", ref FInputModeReply._ScriptStructPtr);
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060069F7 RID: 27127 RVA: 0x0009A9A5 File Offset: 0x00098BA5
		// (set) Token: 0x060069F8 RID: 27128 RVA: 0x0009A9B5 File Offset: 0x00098BB5
		public unsafe int HandleID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_HandleID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_HandleID) = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x0009A9C6 File Offset: 0x00098BC6
		// (set) Token: 0x060069FA RID: 27130 RVA: 0x0009A9DA File Offset: 0x00098BDA
		public unsafe string Reason
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInputModeReply.__PropertyOffset_Reason)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInputModeReply.__PropertyOffset_Reason)), value);
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x0009A9EF File Offset: 0x00098BEF
		// (set) Token: 0x060069FC RID: 27132 RVA: 0x0009A9FF File Offset: 0x00098BFF
		public unsafe bool IsLockMouseToViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_IsLockMouseToViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_IsLockMouseToViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x0009AA10 File Offset: 0x00098C10
		// (set) Token: 0x060069FE RID: 27134 RVA: 0x0009AA20 File Offset: 0x00098C20
		public unsafe bool IsHideCursorDuringCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_IsHideCursorDuringCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_IsHideCursorDuringCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0009AA31 File Offset: 0x00098C31
		public FInputModeReply()
		{
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x0009AA39 File Offset: 0x00098C39
		protected override IntPtr GetUStructPtr()
		{
			return FInputModeReply.StaticStruct();
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0009AA45 File Offset: 0x00098C45
		[NullableContext(2)]
		public FInputModeReply(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x0009AA4F File Offset: 0x00098C4F
		public FInputModeReply(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0009AA5A File Offset: 0x00098C5A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputModeReply(Pointer, false, true);
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0009AA64 File Offset: 0x00098C64
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputModeReply(Pointer, MemoryOwner);
		}

		// Token: 0x04002CFB RID: 11515
		public const string __ObjectPath = "/Script/KuroInput.InputModeReply";

		// Token: 0x04002CFC RID: 11516
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CFD RID: 11517
		internal static int __PropertyOffset_HandleID;

		// Token: 0x04002CFE RID: 11518
		internal static int __PropertyOffset_Reason;

		// Token: 0x04002CFF RID: 11519
		internal static int __PropertyOffset_IsLockMouseToViewport;

		// Token: 0x04002D00 RID: 11520
		internal static int __PropertyOffset_IsHideCursorDuringCapture;
	}
}
