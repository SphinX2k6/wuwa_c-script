using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022E3 RID: 8931
	[UnrealObjectPath("/Script/MessagingRpc.MessageRpcUnhandled")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMessageRpcUnhandled : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DF5 RID: 138741 RVA: 0x00320C0A File Offset: 0x0031EE0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMessageRpcUnhandled._ScriptStructPtr != 0) ? FMessageRpcUnhandled._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MessagingRpc.MessageRpcUnhandled", ref FMessageRpcUnhandled._ScriptStructPtr);
		}

		// Token: 0x1700831B RID: 33563
		// (get) Token: 0x06021DF6 RID: 138742 RVA: 0x00320C2E File Offset: 0x0031EE2E
		// (set) Token: 0x06021DF7 RID: 138743 RVA: 0x00320C42 File Offset: 0x0031EE42
		public unsafe FGuid CallId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMessageRpcUnhandled.__PropertyOffset_CallId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMessageRpcUnhandled.__PropertyOffset_CallId) = value;
			}
		}

		// Token: 0x06021DF8 RID: 138744 RVA: 0x00320C57 File Offset: 0x0031EE57
		public FMessageRpcUnhandled()
		{
		}

		// Token: 0x06021DF9 RID: 138745 RVA: 0x00320C5F File Offset: 0x0031EE5F
		public FMessageRpcUnhandled(FGuid CallId)
		{
			this.CallId = CallId;
		}

		// Token: 0x06021DFA RID: 138746 RVA: 0x00320C6E File Offset: 0x0031EE6E
		protected override IntPtr GetUStructPtr()
		{
			return FMessageRpcUnhandled.StaticStruct();
		}

		// Token: 0x06021DFB RID: 138747 RVA: 0x00320C7A File Offset: 0x0031EE7A
		[NullableContext(2)]
		public FMessageRpcUnhandled(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DFC RID: 138748 RVA: 0x00320C84 File Offset: 0x0031EE84
		public FMessageRpcUnhandled(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DFD RID: 138749 RVA: 0x00320C8F File Offset: 0x0031EE8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMessageRpcUnhandled(Pointer, false, true);
		}

		// Token: 0x06021DFE RID: 138750 RVA: 0x00320C99 File Offset: 0x0031EE99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMessageRpcUnhandled(Pointer, MemoryOwner);
		}

		// Token: 0x0401211C RID: 74012
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MessagingRpc.MessageRpcUnhandled";

		// Token: 0x0401211D RID: 74013
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401211E RID: 74014
		internal static int __PropertyOffset_CallId;
	}
}
