using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F1 RID: 241
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AutomationEvent")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAutomationEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x0001AA56 File Offset: 0x00018C56
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationEvent._ScriptStructPtr != 0) ? FAutomationEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AutomationEvent", ref FAutomationEvent._ScriptStructPtr);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0001AA7A File Offset: 0x00018C7A
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0001AA8A File Offset: 0x00018C8A
		public unsafe EAutomationEventType Type
		{
			get
			{
				return (EAutomationEventType)(*(base.NativePtr + (IntPtr)FAutomationEvent.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationEvent.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0001AA9B File Offset: 0x00018C9B
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x0001AAAF File Offset: 0x00018CAF
		public unsafe string Message
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationEvent.__PropertyOffset_Message)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationEvent.__PropertyOffset_Message)), value);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		public unsafe string Context
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationEvent.__PropertyOffset_Context)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationEvent.__PropertyOffset_Context)), value);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x0001AAED File Offset: 0x00018CED
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x0001AB01 File Offset: 0x00018D01
		public unsafe FGuid Artifact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationEvent.__PropertyOffset_Artifact);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationEvent.__PropertyOffset_Artifact) = value;
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0001AB16 File Offset: 0x00018D16
		public FAutomationEvent()
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0001AB1E File Offset: 0x00018D1E
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationEvent.StaticStruct();
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0001AB2A File Offset: 0x00018D2A
		[NullableContext(2)]
		public FAutomationEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0001AB34 File Offset: 0x00018D34
		public FAutomationEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0001AB3F File Offset: 0x00018D3F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationEvent(Pointer, false, true);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0001AB49 File Offset: 0x00018D49
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04000417 RID: 1047
		public const string __ObjectPath = "/Script/CoreUObject.AutomationEvent";

		// Token: 0x04000418 RID: 1048
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000419 RID: 1049
		internal static int __PropertyOffset_Type;

		// Token: 0x0400041A RID: 1050
		internal static int __PropertyOffset_Message;

		// Token: 0x0400041B RID: 1051
		internal static int __PropertyOffset_Context;

		// Token: 0x0400041C RID: 1052
		internal static int __PropertyOffset_Artifact;
	}
}
