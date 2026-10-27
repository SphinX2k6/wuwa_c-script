using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000426 RID: 1062
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerTestDataRequest")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAutomationWorkerTestDataRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600391B RID: 14619 RVA: 0x00056BF1 File Offset: 0x00054DF1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerTestDataRequest._ScriptStructPtr != 0) ? FAutomationWorkerTestDataRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerTestDataRequest", ref FAutomationWorkerTestDataRequest._ScriptStructPtr);
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x00056C15 File Offset: 0x00054E15
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x00056C29 File Offset: 0x00054E29
		public unsafe string DataType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataType)), value);
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x00056C3E File Offset: 0x00054E3E
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x00056C52 File Offset: 0x00054E52
		public unsafe string DataPlatform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataPlatform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataPlatform)), value);
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x00056C67 File Offset: 0x00054E67
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x00056C7B File Offset: 0x00054E7B
		public unsafe string DataTestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataTestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataTestName)), value);
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00056C90 File Offset: 0x00054E90
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x00056CA4 File Offset: 0x00054EA4
		public unsafe string DataName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_DataName)), value);
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x00056CB9 File Offset: 0x00054EB9
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x00056CCD File Offset: 0x00054ECD
		public unsafe string JsonData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_JsonData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerTestDataRequest.__PropertyOffset_JsonData)), value);
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00056CE2 File Offset: 0x00054EE2
		public FAutomationWorkerTestDataRequest()
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00056CEA File Offset: 0x00054EEA
		public FAutomationWorkerTestDataRequest(string DataType, string DataPlatform, string DataTestName, string DataName, string JsonData)
		{
			this.DataType = DataType;
			this.DataPlatform = DataPlatform;
			this.DataTestName = DataTestName;
			this.DataName = DataName;
			this.JsonData = JsonData;
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00056D17 File Offset: 0x00054F17
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerTestDataRequest.StaticStruct();
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00056D23 File Offset: 0x00054F23
		[NullableContext(2)]
		public FAutomationWorkerTestDataRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00056D2D File Offset: 0x00054F2D
		public FAutomationWorkerTestDataRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00056D38 File Offset: 0x00054F38
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerTestDataRequest(Pointer, false, true);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00056D42 File Offset: 0x00054F42
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerTestDataRequest(Pointer, MemoryOwner);
		}

		// Token: 0x040019E9 RID: 6633
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerTestDataRequest";

		// Token: 0x040019EA RID: 6634
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019EB RID: 6635
		internal static int __PropertyOffset_DataType;

		// Token: 0x040019EC RID: 6636
		internal static int __PropertyOffset_DataPlatform;

		// Token: 0x040019ED RID: 6637
		internal static int __PropertyOffset_DataTestName;

		// Token: 0x040019EE RID: 6638
		internal static int __PropertyOffset_DataName;

		// Token: 0x040019EF RID: 6639
		internal static int __PropertyOffset_JsonData;
	}
}
