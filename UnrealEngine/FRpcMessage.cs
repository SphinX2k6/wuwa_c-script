using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022E4 RID: 8932
	[UnrealObjectPath("/Script/MessagingRpc.RpcMessage")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRpcMessage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DFF RID: 138751 RVA: 0x00320CA2 File Offset: 0x0031EEA2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRpcMessage._ScriptStructPtr != 0) ? FRpcMessage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MessagingRpc.RpcMessage", ref FRpcMessage._ScriptStructPtr);
		}

		// Token: 0x1700831C RID: 33564
		// (get) Token: 0x06021E00 RID: 138752 RVA: 0x00320CC6 File Offset: 0x0031EEC6
		// (set) Token: 0x06021E01 RID: 138753 RVA: 0x00320CDA File Offset: 0x0031EEDA
		public unsafe FGuid CallId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRpcMessage.__PropertyOffset_CallId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRpcMessage.__PropertyOffset_CallId) = value;
			}
		}

		// Token: 0x06021E02 RID: 138754 RVA: 0x00320CEF File Offset: 0x0031EEEF
		public FRpcMessage()
		{
		}

		// Token: 0x06021E03 RID: 138755 RVA: 0x00320CF7 File Offset: 0x0031EEF7
		public FRpcMessage(FGuid CallId)
		{
			this.CallId = CallId;
		}

		// Token: 0x06021E04 RID: 138756 RVA: 0x00320D06 File Offset: 0x0031EF06
		protected override IntPtr GetUStructPtr()
		{
			return FRpcMessage.StaticStruct();
		}

		// Token: 0x06021E05 RID: 138757 RVA: 0x00320D12 File Offset: 0x0031EF12
		[NullableContext(2)]
		public FRpcMessage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E06 RID: 138758 RVA: 0x00320D1C File Offset: 0x0031EF1C
		public FRpcMessage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E07 RID: 138759 RVA: 0x00320D27 File Offset: 0x0031EF27
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRpcMessage(Pointer, false, true);
		}

		// Token: 0x06021E08 RID: 138760 RVA: 0x00320D31 File Offset: 0x0031EF31
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRpcMessage(Pointer, MemoryOwner);
		}

		// Token: 0x0401211F RID: 74015
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MessagingRpc.RpcMessage";

		// Token: 0x04012120 RID: 74016
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012121 RID: 74017
		internal static int __PropertyOffset_CallId;
	}
}
