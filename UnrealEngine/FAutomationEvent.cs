using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000706 RID: 1798
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AutomationEvent")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAutomationEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600615C RID: 24924 RVA: 0x0008B96C File Offset: 0x00089B6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationEvent._ScriptStructPtr != 0) ? FAutomationEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AutomationEvent", ref FAutomationEvent._ScriptStructPtr);
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x0600615D RID: 24925 RVA: 0x0008B990 File Offset: 0x00089B90
		// (set) Token: 0x0600615E RID: 24926 RVA: 0x0008B9A0 File Offset: 0x00089BA0
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

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x0600615F RID: 24927 RVA: 0x0008B9B1 File Offset: 0x00089BB1
		// (set) Token: 0x06006160 RID: 24928 RVA: 0x0008B9C5 File Offset: 0x00089BC5
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

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06006161 RID: 24929 RVA: 0x0008B9DA File Offset: 0x00089BDA
		// (set) Token: 0x06006162 RID: 24930 RVA: 0x0008B9EE File Offset: 0x00089BEE
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

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06006163 RID: 24931 RVA: 0x0008BA03 File Offset: 0x00089C03
		// (set) Token: 0x06006164 RID: 24932 RVA: 0x0008BA17 File Offset: 0x00089C17
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

		// Token: 0x06006165 RID: 24933 RVA: 0x0008BA2C File Offset: 0x00089C2C
		public FAutomationEvent()
		{
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x0008BA34 File Offset: 0x00089C34
		public FAutomationEvent(EAutomationEventType Type, string Message, string Context, FGuid Artifact)
		{
			this.Type = Type;
			this.Message = Message;
			this.Context = Context;
			this.Artifact = Artifact;
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x0008BA59 File Offset: 0x00089C59
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationEvent.StaticStruct();
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x0008BA65 File Offset: 0x00089C65
		[NullableContext(2)]
		public FAutomationEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x0008BA6F File Offset: 0x00089C6F
		public FAutomationEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x0008BA7A File Offset: 0x00089C7A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationEvent(Pointer, false, true);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x0008BA84 File Offset: 0x00089C84
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04002D88 RID: 11656
		public const string __ObjectPath = "/Script/CoreUObject.AutomationEvent";

		// Token: 0x04002D89 RID: 11657
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D8A RID: 11658
		internal static int __PropertyOffset_Type;

		// Token: 0x04002D8B RID: 11659
		internal static int __PropertyOffset_Message;

		// Token: 0x04002D8C RID: 11660
		internal static int __PropertyOffset_Context;

		// Token: 0x04002D8D RID: 11661
		internal static int __PropertyOffset_Artifact;
	}
}
