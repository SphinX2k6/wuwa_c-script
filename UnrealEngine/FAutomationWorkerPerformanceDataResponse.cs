using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041A RID: 1050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerPerformanceDataResponse")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAutomationWorkerPerformanceDataResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003887 RID: 14471 RVA: 0x00055FE2 File Offset: 0x000541E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerPerformanceDataResponse._ScriptStructPtr != 0) ? FAutomationWorkerPerformanceDataResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerPerformanceDataResponse", ref FAutomationWorkerPerformanceDataResponse._ScriptStructPtr);
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x00056006 File Offset: 0x00054206
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x00056016 File Offset: 0x00054216
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerPerformanceDataResponse.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerPerformanceDataResponse.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x00056027 File Offset: 0x00054227
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x0005603B File Offset: 0x0005423B
		public unsafe string ErrorMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataResponse.__PropertyOffset_ErrorMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerPerformanceDataResponse.__PropertyOffset_ErrorMessage)), value);
			}
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00056050 File Offset: 0x00054250
		public FAutomationWorkerPerformanceDataResponse()
		{
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00056058 File Offset: 0x00054258
		public FAutomationWorkerPerformanceDataResponse(bool bSuccess, string ErrorMessage)
		{
			this.bSuccess = bSuccess;
			this.ErrorMessage = ErrorMessage;
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x0005606E File Offset: 0x0005426E
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerPerformanceDataResponse.StaticStruct();
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0005607A File Offset: 0x0005427A
		[NullableContext(2)]
		public FAutomationWorkerPerformanceDataResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00056084 File Offset: 0x00054284
		public FAutomationWorkerPerformanceDataResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x0005608F File Offset: 0x0005428F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerPerformanceDataResponse(Pointer, false, true);
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00056099 File Offset: 0x00054299
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerPerformanceDataResponse(Pointer, MemoryOwner);
		}

		// Token: 0x040019AC RID: 6572
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerPerformanceDataResponse";

		// Token: 0x040019AD RID: 6573
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019AE RID: 6574
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040019AF RID: 6575
		internal static int __PropertyOffset_ErrorMessage;
	}
}
