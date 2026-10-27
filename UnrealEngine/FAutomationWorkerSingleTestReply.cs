using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000424 RID: 1060
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerSingleTestReply")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FAutomationWorkerSingleTestReply : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038FA RID: 14586 RVA: 0x0005691D File Offset: 0x00054B1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerSingleTestReply._ScriptStructPtr != 0) ? FAutomationWorkerSingleTestReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerSingleTestReply", ref FAutomationWorkerSingleTestReply._ScriptStructPtr);
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00056941 File Offset: 0x00054B41
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x00056955 File Offset: 0x00054B55
		public unsafe string DisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_DisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x0005696A File Offset: 0x00054B6A
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0005697E File Offset: 0x00054B7E
		public unsafe string FullTestPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_FullTestPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_FullTestPath)), value);
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x00056993 File Offset: 0x00054B93
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x000569A7 File Offset: 0x00054BA7
		public unsafe string TestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestName)), value);
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x000569BC File Offset: 0x00054BBC
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x000569D0 File Offset: 0x00054BD0
		public unsafe string TestParameter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestParameter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestParameter)), value);
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x000569E5 File Offset: 0x00054BE5
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x000569F9 File Offset: 0x00054BF9
		public unsafe string SourceFile
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_SourceFile)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_SourceFile)), value);
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x00056A0E File Offset: 0x00054C0E
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x00056A1E File Offset: 0x00054C1E
		public unsafe int SourceFileLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_SourceFileLine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_SourceFileLine) = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x00056A2F File Offset: 0x00054C2F
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x00056A43 File Offset: 0x00054C43
		public unsafe string AssetPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_AssetPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_AssetPath)), value);
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x00056A58 File Offset: 0x00054C58
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x00056A6C File Offset: 0x00054C6C
		public unsafe string OpenCommand
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_OpenCommand)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_OpenCommand)), value);
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x00056A81 File Offset: 0x00054C81
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x00056A91 File Offset: 0x00054C91
		public unsafe uint TestFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_TestFlags) = (int)value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00056AA2 File Offset: 0x00054CA2
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x00056AB2 File Offset: 0x00054CB2
		public unsafe uint NumParticipantsRequired
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_NumParticipantsRequired);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerSingleTestReply.__PropertyOffset_NumParticipantsRequired) = (int)value;
			}
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00056AC3 File Offset: 0x00054CC3
		public FAutomationWorkerSingleTestReply()
		{
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00056ACC File Offset: 0x00054CCC
		public FAutomationWorkerSingleTestReply(string DisplayName, string FullTestPath, string TestName, string TestParameter, string SourceFile, int SourceFileLine, string AssetPath, string OpenCommand, uint TestFlags, uint NumParticipantsRequired)
		{
			this.DisplayName = DisplayName;
			this.FullTestPath = FullTestPath;
			this.TestName = TestName;
			this.TestParameter = TestParameter;
			this.SourceFile = SourceFile;
			this.SourceFileLine = SourceFileLine;
			this.AssetPath = AssetPath;
			this.OpenCommand = OpenCommand;
			this.TestFlags = TestFlags;
			this.NumParticipantsRequired = NumParticipantsRequired;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00056B2C File Offset: 0x00054D2C
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerSingleTestReply.StaticStruct();
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00056B38 File Offset: 0x00054D38
		[NullableContext(2)]
		public FAutomationWorkerSingleTestReply(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00056B42 File Offset: 0x00054D42
		public FAutomationWorkerSingleTestReply(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00056B4D File Offset: 0x00054D4D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerSingleTestReply(Pointer, false, true);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00056B57 File Offset: 0x00054D57
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerSingleTestReply(Pointer, MemoryOwner);
		}

		// Token: 0x040019DB RID: 6619
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerSingleTestReply";

		// Token: 0x040019DC RID: 6620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019DD RID: 6621
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x040019DE RID: 6622
		internal static int __PropertyOffset_FullTestPath;

		// Token: 0x040019DF RID: 6623
		internal static int __PropertyOffset_TestName;

		// Token: 0x040019E0 RID: 6624
		internal static int __PropertyOffset_TestParameter;

		// Token: 0x040019E1 RID: 6625
		internal static int __PropertyOffset_SourceFile;

		// Token: 0x040019E2 RID: 6626
		internal static int __PropertyOffset_SourceFileLine;

		// Token: 0x040019E3 RID: 6627
		internal static int __PropertyOffset_AssetPath;

		// Token: 0x040019E4 RID: 6628
		internal static int __PropertyOffset_OpenCommand;

		// Token: 0x040019E5 RID: 6629
		internal static int __PropertyOffset_TestFlags;

		// Token: 0x040019E6 RID: 6630
		internal static int __PropertyOffset_NumParticipantsRequired;
	}
}
