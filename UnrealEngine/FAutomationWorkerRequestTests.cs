using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041E RID: 1054
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerRequestTests")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAutomationWorkerRequestTests : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038A7 RID: 14503 RVA: 0x00056259 File Offset: 0x00054459
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerRequestTests._ScriptStructPtr != 0) ? FAutomationWorkerRequestTests._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerRequestTests", ref FAutomationWorkerRequestTests._ScriptStructPtr);
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x0005627D File Offset: 0x0005447D
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x0005628D File Offset: 0x0005448D
		public unsafe bool DeveloperDirectoryIncluded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRequestTests.__PropertyOffset_DeveloperDirectoryIncluded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRequestTests.__PropertyOffset_DeveloperDirectoryIncluded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x0005629E File Offset: 0x0005449E
		// (set) Token: 0x060038AB RID: 14507 RVA: 0x000562AE File Offset: 0x000544AE
		public unsafe uint RequestedTestFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRequestTests.__PropertyOffset_RequestedTestFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRequestTests.__PropertyOffset_RequestedTestFlags) = (int)value;
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x000562BF File Offset: 0x000544BF
		public FAutomationWorkerRequestTests()
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x000562C7 File Offset: 0x000544C7
		public FAutomationWorkerRequestTests(bool DeveloperDirectoryIncluded, uint RequestedTestFlags)
		{
			this.DeveloperDirectoryIncluded = DeveloperDirectoryIncluded;
			this.RequestedTestFlags = RequestedTestFlags;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x000562DD File Offset: 0x000544DD
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerRequestTests.StaticStruct();
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000562E9 File Offset: 0x000544E9
		[NullableContext(2)]
		public FAutomationWorkerRequestTests(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x000562F3 File Offset: 0x000544F3
		public FAutomationWorkerRequestTests(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x000562FE File Offset: 0x000544FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerRequestTests(Pointer, false, true);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00056308 File Offset: 0x00054508
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerRequestTests(Pointer, MemoryOwner);
		}

		// Token: 0x040019B7 RID: 6583
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerRequestTests";

		// Token: 0x040019B8 RID: 6584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019B9 RID: 6585
		internal static int __PropertyOffset_DeveloperDirectoryIncluded;

		// Token: 0x040019BA RID: 6586
		internal static int __PropertyOffset_RequestedTestFlags;
	}
}
