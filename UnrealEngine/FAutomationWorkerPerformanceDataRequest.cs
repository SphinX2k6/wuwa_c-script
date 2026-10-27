using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000419 RID: 1049
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerPerformanceDataRequest")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAutomationWorkerPerformanceDataRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003877 RID: 14455 RVA: 0x00055E91 File Offset: 0x00054091
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerPerformanceDataRequest._ScriptStructPtr != 0) ? FAutomationWorkerPerformanceDataRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerPerformanceDataRequest", ref FAutomationWorkerPerformanceDataRequest._ScriptStructPtr);
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x00055EB5 File Offset: 0x000540B5
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x00055EC9 File Offset: 0x000540C9
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x00055EDE File Offset: 0x000540DE
		// (set) Token: 0x0600387B RID: 14459 RVA: 0x00055EF2 File Offset: 0x000540F2
		public unsafe string Hardware
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_Hardware)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_Hardware)), value);
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x00055F07 File Offset: 0x00054107
		// (set) Token: 0x0600387D RID: 14461 RVA: 0x00055F1B File Offset: 0x0005411B
		public unsafe string TestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_TestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_TestName)), value);
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x00055F30 File Offset: 0x00054130
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x00055F73 File Offset: 0x00054173
		public TArray<double> DataPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<double> result;
				if ((result = this._DataPoints) == null)
				{
					result = (this._DataPoints = new TArray<double>(base.NativePtr + (IntPtr)FAutomationWorkerPerformanceDataRequest.__PropertyOffset_DataPoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataPoints.CopyAssign(value);
			}
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00055F81 File Offset: 0x00054181
		public FAutomationWorkerPerformanceDataRequest()
		{
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00055F89 File Offset: 0x00054189
		public FAutomationWorkerPerformanceDataRequest(string Platform, string Hardware, string TestName, TArray<double> DataPoints)
		{
			this.Platform = Platform;
			this.Hardware = Hardware;
			this.TestName = TestName;
			this.DataPoints = DataPoints;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00055FAE File Offset: 0x000541AE
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerPerformanceDataRequest.StaticStruct();
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00055FBA File Offset: 0x000541BA
		[NullableContext(2)]
		public FAutomationWorkerPerformanceDataRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00055FC4 File Offset: 0x000541C4
		public FAutomationWorkerPerformanceDataRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00055FCF File Offset: 0x000541CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerPerformanceDataRequest(Pointer, false, true);
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00055FD9 File Offset: 0x000541D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerPerformanceDataRequest(Pointer, MemoryOwner);
		}

		// Token: 0x040019A5 RID: 6565
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerPerformanceDataRequest";

		// Token: 0x040019A6 RID: 6566
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019A7 RID: 6567
		internal static int __PropertyOffset_Platform;

		// Token: 0x040019A8 RID: 6568
		internal static int __PropertyOffset_Hardware;

		// Token: 0x040019A9 RID: 6569
		internal static int __PropertyOffset_TestName;

		// Token: 0x040019AA RID: 6570
		internal static int __PropertyOffset_DataPoints;

		// Token: 0x040019AB RID: 6571
		[Nullable(2)]
		private TArray<double> _DataPoints;
	}
}
