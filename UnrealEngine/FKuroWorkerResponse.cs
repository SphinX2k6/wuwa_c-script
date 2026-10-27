using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016AA RID: 5802
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroWorkerResponse")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroWorkerResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060150C1 RID: 86209 RVA: 0x001EEDB8 File Offset: 0x001ECFB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroWorkerResponse._ScriptStructPtr != 0) ? FKuroWorkerResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroWorkerResponse", ref FKuroWorkerResponse._ScriptStructPtr);
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x060150C2 RID: 86210 RVA: 0x001EEDDC File Offset: 0x001ECFDC
		// (set) Token: 0x060150C3 RID: 86211 RVA: 0x001EEDEC File Offset: 0x001ECFEC
		public unsafe bool Finish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorkerResponse.__PropertyOffset_Finish) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorkerResponse.__PropertyOffset_Finish) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x060150C4 RID: 86212 RVA: 0x001EEDFD File Offset: 0x001ECFFD
		// (set) Token: 0x060150C5 RID: 86213 RVA: 0x001EEE0D File Offset: 0x001ED00D
		public unsafe int Error
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorkerResponse.__PropertyOffset_Error);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorkerResponse.__PropertyOffset_Error) = value;
			}
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x060150C6 RID: 86214 RVA: 0x001EEE1E File Offset: 0x001ED01E
		// (set) Token: 0x060150C7 RID: 86215 RVA: 0x001EEE32 File Offset: 0x001ED032
		public unsafe string ErrorMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroWorkerResponse.__PropertyOffset_ErrorMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroWorkerResponse.__PropertyOffset_ErrorMessage)), value);
			}
		}

		// Token: 0x060150C8 RID: 86216 RVA: 0x001EEE47 File Offset: 0x001ED047
		public FKuroWorkerResponse()
		{
		}

		// Token: 0x060150C9 RID: 86217 RVA: 0x001EEE4F File Offset: 0x001ED04F
		public FKuroWorkerResponse(bool Finish, int Error, string ErrorMessage)
		{
			this.Finish = Finish;
			this.Error = Error;
			this.ErrorMessage = ErrorMessage;
		}

		// Token: 0x060150CA RID: 86218 RVA: 0x001EEE6C File Offset: 0x001ED06C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroWorkerResponse.StaticStruct();
		}

		// Token: 0x060150CB RID: 86219 RVA: 0x001EEE78 File Offset: 0x001ED078
		[NullableContext(2)]
		public FKuroWorkerResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060150CC RID: 86220 RVA: 0x001EEE82 File Offset: 0x001ED082
		public FKuroWorkerResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060150CD RID: 86221 RVA: 0x001EEE8D File Offset: 0x001ED08D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroWorkerResponse(Pointer, false, true);
		}

		// Token: 0x060150CE RID: 86222 RVA: 0x001EEE97 File Offset: 0x001ED097
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroWorkerResponse(Pointer, MemoryOwner);
		}

		// Token: 0x0400B755 RID: 46933
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroWorkerResponse";

		// Token: 0x0400B756 RID: 46934
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B757 RID: 46935
		internal static int __PropertyOffset_Finish;

		// Token: 0x0400B758 RID: 46936
		internal static int __PropertyOffset_Error;

		// Token: 0x0400B759 RID: 46937
		internal static int __PropertyOffset_ErrorMessage;
	}
}
