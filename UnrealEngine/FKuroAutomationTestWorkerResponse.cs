using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A4 RID: 5796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationTestWorkerResponse")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroAutomationTestWorkerResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601502B RID: 86059 RVA: 0x001EE08E File Offset: 0x001EC28E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAutomationTestWorkerResponse._ScriptStructPtr != 0) ? FKuroAutomationTestWorkerResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroAutomationTestWorkerResponse", ref FKuroAutomationTestWorkerResponse._ScriptStructPtr);
		}

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x0601502C RID: 86060 RVA: 0x001EE0B2 File Offset: 0x001EC2B2
		// (set) Token: 0x0601502D RID: 86061 RVA: 0x001EE0C2 File Offset: 0x001EC2C2
		public unsafe bool IsConnected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsConnected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsConnected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x0601502E RID: 86062 RVA: 0x001EE0D3 File Offset: 0x001EC2D3
		// (set) Token: 0x0601502F RID: 86063 RVA: 0x001EE0E3 File Offset: 0x001EC2E3
		public unsafe bool IsReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsReady) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsReady) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x06015030 RID: 86064 RVA: 0x001EE0F4 File Offset: 0x001EC2F4
		// (set) Token: 0x06015031 RID: 86065 RVA: 0x001EE104 File Offset: 0x001EC304
		public unsafe bool IsLaunched
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsLaunched) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsLaunched) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005325 RID: 21285
		// (get) Token: 0x06015032 RID: 86066 RVA: 0x001EE115 File Offset: 0x001EC315
		// (set) Token: 0x06015033 RID: 86067 RVA: 0x001EE125 File Offset: 0x001EC325
		public unsafe bool IsFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsFinish) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_IsFinish) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x06015034 RID: 86068 RVA: 0x001EE136 File Offset: 0x001EC336
		// (set) Token: 0x06015035 RID: 86069 RVA: 0x001EE146 File Offset: 0x001EC346
		public unsafe int Error
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_Error);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_Error) = value;
			}
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x06015036 RID: 86070 RVA: 0x001EE157 File Offset: 0x001EC357
		// (set) Token: 0x06015037 RID: 86071 RVA: 0x001EE16B File Offset: 0x001EC36B
		public unsafe string ErrorMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_ErrorMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_ErrorMessage)), value);
			}
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x06015038 RID: 86072 RVA: 0x001EE180 File Offset: 0x001EC380
		// (set) Token: 0x06015039 RID: 86073 RVA: 0x001EE194 File Offset: 0x001EC394
		public unsafe string ExtraMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_ExtraMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTestWorkerResponse.__PropertyOffset_ExtraMessage)), value);
			}
		}

		// Token: 0x0601503A RID: 86074 RVA: 0x001EE1A9 File Offset: 0x001EC3A9
		public FKuroAutomationTestWorkerResponse()
		{
		}

		// Token: 0x0601503B RID: 86075 RVA: 0x001EE1B1 File Offset: 0x001EC3B1
		public FKuroAutomationTestWorkerResponse(bool IsConnected, bool IsReady, bool IsLaunched, bool IsFinish, int Error, string ErrorMessage, string ExtraMessage)
		{
			this.IsConnected = IsConnected;
			this.IsReady = IsReady;
			this.IsLaunched = IsLaunched;
			this.IsFinish = IsFinish;
			this.Error = Error;
			this.ErrorMessage = ErrorMessage;
			this.ExtraMessage = ExtraMessage;
		}

		// Token: 0x0601503C RID: 86076 RVA: 0x001EE1EE File Offset: 0x001EC3EE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAutomationTestWorkerResponse.StaticStruct();
		}

		// Token: 0x0601503D RID: 86077 RVA: 0x001EE1FA File Offset: 0x001EC3FA
		[NullableContext(2)]
		public FKuroAutomationTestWorkerResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x001EE204 File Offset: 0x001EC404
		public FKuroAutomationTestWorkerResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x001EE20F File Offset: 0x001EC40F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAutomationTestWorkerResponse(Pointer, false, true);
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x001EE219 File Offset: 0x001EC419
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAutomationTestWorkerResponse(Pointer, MemoryOwner);
		}

		// Token: 0x0400B70D RID: 46861
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationTestWorkerResponse";

		// Token: 0x0400B70E RID: 46862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B70F RID: 46863
		internal static int __PropertyOffset_IsConnected;

		// Token: 0x0400B710 RID: 46864
		internal static int __PropertyOffset_IsReady;

		// Token: 0x0400B711 RID: 46865
		internal static int __PropertyOffset_IsLaunched;

		// Token: 0x0400B712 RID: 46866
		internal static int __PropertyOffset_IsFinish;

		// Token: 0x0400B713 RID: 46867
		internal static int __PropertyOffset_Error;

		// Token: 0x0400B714 RID: 46868
		internal static int __PropertyOffset_ErrorMessage;

		// Token: 0x0400B715 RID: 46869
		internal static int __PropertyOffset_ExtraMessage;
	}
}
