using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AutomationExecutionEntry")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAutomationExecutionEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060010D4 RID: 4308 RVA: 0x0001AB52 File Offset: 0x00018D52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationExecutionEntry._ScriptStructPtr != 0) ? FAutomationExecutionEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AutomationExecutionEntry", ref FAutomationExecutionEntry._ScriptStructPtr);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0001AB78 File Offset: 0x00018D78
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0001ABBB File Offset: 0x00018DBB
		public FAutomationEvent Event
		{
			get
			{
				base.FastCheckIsValid();
				FAutomationEvent result;
				if ((result = this._Event) == null)
				{
					result = (this._Event = new FAutomationEvent(base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_Event, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAutomationEvent.StaticStruct(), base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0001ABDC File Offset: 0x00018DDC
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		public unsafe string Filename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationExecutionEntry.__PropertyOffset_Filename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationExecutionEntry.__PropertyOffset_Filename)), value);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0001AC05 File Offset: 0x00018E05
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0001AC15 File Offset: 0x00018E15
		public unsafe int LineNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_LineNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_LineNumber) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0001AC28 File Offset: 0x00018E28
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0001AC6B File Offset: 0x00018E6B
		public FDateTime Timestamp
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._Timestamp) == null)
				{
					result = (this._Timestamp = new FDateTime(base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_Timestamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FAutomationExecutionEntry.__PropertyOffset_Timestamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0001AC8C File Offset: 0x00018E8C
		public FAutomationExecutionEntry()
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0001AC94 File Offset: 0x00018E94
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationExecutionEntry.StaticStruct();
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[NullableContext(2)]
		public FAutomationExecutionEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0001ACAA File Offset: 0x00018EAA
		public FAutomationExecutionEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0001ACB5 File Offset: 0x00018EB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationExecutionEntry(Pointer, false, true);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0001ACBF File Offset: 0x00018EBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationExecutionEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400041D RID: 1053
		public const string __ObjectPath = "/Script/CoreUObject.AutomationExecutionEntry";

		// Token: 0x0400041E RID: 1054
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400041F RID: 1055
		internal static int __PropertyOffset_Event;

		// Token: 0x04000420 RID: 1056
		[Nullable(2)]
		private FAutomationEvent _Event;

		// Token: 0x04000421 RID: 1057
		internal static int __PropertyOffset_Filename;

		// Token: 0x04000422 RID: 1058
		internal static int __PropertyOffset_LineNumber;

		// Token: 0x04000423 RID: 1059
		internal static int __PropertyOffset_Timestamp;

		// Token: 0x04000424 RID: 1060
		[Nullable(2)]
		private FDateTime _Timestamp;
	}
}
