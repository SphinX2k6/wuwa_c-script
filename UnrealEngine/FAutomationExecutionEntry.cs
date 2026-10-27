using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000707 RID: 1799
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AutomationExecutionEntry")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAutomationExecutionEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600616C RID: 24940 RVA: 0x0008BA8D File Offset: 0x00089C8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationExecutionEntry._ScriptStructPtr != 0) ? FAutomationExecutionEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AutomationExecutionEntry", ref FAutomationExecutionEntry._ScriptStructPtr);
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600616D RID: 24941 RVA: 0x0008BAB4 File Offset: 0x00089CB4
		// (set) Token: 0x0600616E RID: 24942 RVA: 0x0008BAF7 File Offset: 0x00089CF7
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

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600616F RID: 24943 RVA: 0x0008BB18 File Offset: 0x00089D18
		// (set) Token: 0x06006170 RID: 24944 RVA: 0x0008BB2C File Offset: 0x00089D2C
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

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06006171 RID: 24945 RVA: 0x0008BB41 File Offset: 0x00089D41
		// (set) Token: 0x06006172 RID: 24946 RVA: 0x0008BB51 File Offset: 0x00089D51
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

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06006173 RID: 24947 RVA: 0x0008BB64 File Offset: 0x00089D64
		// (set) Token: 0x06006174 RID: 24948 RVA: 0x0008BBA7 File Offset: 0x00089DA7
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

		// Token: 0x06006175 RID: 24949 RVA: 0x0008BBC8 File Offset: 0x00089DC8
		public FAutomationExecutionEntry()
		{
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x0008BBD0 File Offset: 0x00089DD0
		public FAutomationExecutionEntry(FAutomationEvent Event, string Filename, int LineNumber, FDateTime Timestamp)
		{
			this.Event = Event;
			this.Filename = Filename;
			this.LineNumber = LineNumber;
			this.Timestamp = Timestamp;
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x0008BBF5 File Offset: 0x00089DF5
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationExecutionEntry.StaticStruct();
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x0008BC01 File Offset: 0x00089E01
		[NullableContext(2)]
		public FAutomationExecutionEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x0008BC0B File Offset: 0x00089E0B
		public FAutomationExecutionEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x0008BC16 File Offset: 0x00089E16
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationExecutionEntry(Pointer, false, true);
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x0008BC20 File Offset: 0x00089E20
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationExecutionEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04002D8E RID: 11662
		public const string __ObjectPath = "/Script/CoreUObject.AutomationExecutionEntry";

		// Token: 0x04002D8F RID: 11663
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D90 RID: 11664
		internal static int __PropertyOffset_Event;

		// Token: 0x04002D91 RID: 11665
		[Nullable(2)]
		private FAutomationEvent _Event;

		// Token: 0x04002D92 RID: 11666
		internal static int __PropertyOffset_Filename;

		// Token: 0x04002D93 RID: 11667
		internal static int __PropertyOffset_LineNumber;

		// Token: 0x04002D94 RID: 11668
		internal static int __PropertyOffset_Timestamp;

		// Token: 0x04002D95 RID: 11669
		[Nullable(2)]
		private FDateTime _Timestamp;
	}
}
