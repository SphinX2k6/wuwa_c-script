using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000427 RID: 1063
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerTestDataResponse")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAutomationWorkerTestDataResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600392D RID: 14637 RVA: 0x00056D4B File Offset: 0x00054F4B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerTestDataResponse._ScriptStructPtr != 0) ? FAutomationWorkerTestDataResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerTestDataResponse", ref FAutomationWorkerTestDataResponse._ScriptStructPtr);
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00056D6F File Offset: 0x00054F6F
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x00056D83 File Offset: 0x00054F83
		public unsafe string JsonData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataResponse.__PropertyOffset_JsonData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataResponse.__PropertyOffset_JsonData)), value);
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00056D98 File Offset: 0x00054F98
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x00056DA8 File Offset: 0x00054FA8
		public unsafe bool bIsNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerTestDataResponse.__PropertyOffset_bIsNew) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerTestDataResponse.__PropertyOffset_bIsNew) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00056DB9 File Offset: 0x00054FB9
		public FAutomationWorkerTestDataResponse()
		{
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00056DC1 File Offset: 0x00054FC1
		public FAutomationWorkerTestDataResponse(string JsonData, bool bIsNew)
		{
			this.JsonData = JsonData;
			this.bIsNew = bIsNew;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00056DD7 File Offset: 0x00054FD7
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerTestDataResponse.StaticStruct();
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00056DE3 File Offset: 0x00054FE3
		[NullableContext(2)]
		public FAutomationWorkerTestDataResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00056DED File Offset: 0x00054FED
		public FAutomationWorkerTestDataResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00056DF8 File Offset: 0x00054FF8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerTestDataResponse(Pointer, false, true);
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x00056E02 File Offset: 0x00055002
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerTestDataResponse(Pointer, MemoryOwner);
		}

		// Token: 0x040019F0 RID: 6640
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerTestDataResponse";

		// Token: 0x040019F1 RID: 6641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019F2 RID: 6642
		internal static int __PropertyOffset_JsonData;

		// Token: 0x040019F3 RID: 6643
		internal static int __PropertyOffset_bIsNew;
	}
}
