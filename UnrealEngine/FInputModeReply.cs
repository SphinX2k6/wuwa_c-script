using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001996 RID: 6550
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/KuroInput.InputModeReply")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FInputModeReply : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601853F RID: 99647 RVA: 0x0023DFF5 File Offset: 0x0023C1F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputModeReply._ScriptStructPtr != 0) ? FInputModeReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInput.InputModeReply", ref FInputModeReply._ScriptStructPtr);
		}

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x06018540 RID: 99648 RVA: 0x0023E019 File Offset: 0x0023C219
		// (set) Token: 0x06018541 RID: 99649 RVA: 0x0023E029 File Offset: 0x0023C229
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

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x06018542 RID: 99650 RVA: 0x0023E03A File Offset: 0x0023C23A
		// (set) Token: 0x06018543 RID: 99651 RVA: 0x0023E04E File Offset: 0x0023C24E
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

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x06018544 RID: 99652 RVA: 0x0023E063 File Offset: 0x0023C263
		// (set) Token: 0x06018545 RID: 99653 RVA: 0x0023E073 File Offset: 0x0023C273
		public unsafe EInputMode InputModeType
		{
			get
			{
				return (EInputMode)(*(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_InputModeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputModeReply.__PropertyOffset_InputModeType) = (byte)value;
			}
		}

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x06018546 RID: 99654 RVA: 0x0023E084 File Offset: 0x0023C284
		// (set) Token: 0x06018547 RID: 99655 RVA: 0x0023E094 File Offset: 0x0023C294
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

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x06018548 RID: 99656 RVA: 0x0023E0A5 File Offset: 0x0023C2A5
		// (set) Token: 0x06018549 RID: 99657 RVA: 0x0023E0B5 File Offset: 0x0023C2B5
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

		// Token: 0x0601854A RID: 99658 RVA: 0x0023E0C6 File Offset: 0x0023C2C6
		public FInputModeReply()
		{
		}

		// Token: 0x0601854B RID: 99659 RVA: 0x0023E0CE File Offset: 0x0023C2CE
		public FInputModeReply(int HandleID, string Reason, EInputMode InputModeType, bool IsLockMouseToViewport, bool IsHideCursorDuringCapture)
		{
			this.HandleID = HandleID;
			this.Reason = Reason;
			this.InputModeType = InputModeType;
			this.IsLockMouseToViewport = IsLockMouseToViewport;
			this.IsHideCursorDuringCapture = IsHideCursorDuringCapture;
		}

		// Token: 0x0601854C RID: 99660 RVA: 0x0023E0FB File Offset: 0x0023C2FB
		protected override IntPtr GetUStructPtr()
		{
			return FInputModeReply.StaticStruct();
		}

		// Token: 0x0601854D RID: 99661 RVA: 0x0023E107 File Offset: 0x0023C307
		[NullableContext(2)]
		public FInputModeReply(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601854E RID: 99662 RVA: 0x0023E111 File Offset: 0x0023C311
		public FInputModeReply(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601854F RID: 99663 RVA: 0x0023E11C File Offset: 0x0023C31C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputModeReply(Pointer, false, true);
		}

		// Token: 0x06018550 RID: 99664 RVA: 0x0023E126 File Offset: 0x0023C326
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputModeReply(Pointer, MemoryOwner);
		}

		// Token: 0x0400D28E RID: 53902
		public const string __ObjectPath = "/Script/KuroInput.InputModeReply";

		// Token: 0x0400D28F RID: 53903
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D290 RID: 53904
		internal static int __PropertyOffset_HandleID;

		// Token: 0x0400D291 RID: 53905
		internal static int __PropertyOffset_Reason;

		// Token: 0x0400D292 RID: 53906
		internal static int __PropertyOffset_InputModeType;

		// Token: 0x0400D293 RID: 53907
		internal static int __PropertyOffset_IsLockMouseToViewport;

		// Token: 0x0400D294 RID: 53908
		internal static int __PropertyOffset_IsHideCursorDuringCapture;
	}
}
