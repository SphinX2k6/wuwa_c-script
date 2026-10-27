using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022E1 RID: 8929
	[UnrealObjectPath("/Script/MessagingRpc.MessageRpcCancel")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMessageRpcCancel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DDD RID: 138717 RVA: 0x00320A82 File Offset: 0x0031EC82
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMessageRpcCancel._ScriptStructPtr != 0) ? FMessageRpcCancel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MessagingRpc.MessageRpcCancel", ref FMessageRpcCancel._ScriptStructPtr);
		}

		// Token: 0x17008317 RID: 33559
		// (get) Token: 0x06021DDE RID: 138718 RVA: 0x00320AA6 File Offset: 0x0031ECA6
		// (set) Token: 0x06021DDF RID: 138719 RVA: 0x00320ABA File Offset: 0x0031ECBA
		public unsafe FGuid CallId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMessageRpcCancel.__PropertyOffset_CallId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMessageRpcCancel.__PropertyOffset_CallId) = value;
			}
		}

		// Token: 0x06021DE0 RID: 138720 RVA: 0x00320ACF File Offset: 0x0031ECCF
		public FMessageRpcCancel()
		{
		}

		// Token: 0x06021DE1 RID: 138721 RVA: 0x00320AD7 File Offset: 0x0031ECD7
		public FMessageRpcCancel(FGuid CallId)
		{
			this.CallId = CallId;
		}

		// Token: 0x06021DE2 RID: 138722 RVA: 0x00320AE6 File Offset: 0x0031ECE6
		protected override IntPtr GetUStructPtr()
		{
			return FMessageRpcCancel.StaticStruct();
		}

		// Token: 0x06021DE3 RID: 138723 RVA: 0x00320AF2 File Offset: 0x0031ECF2
		[NullableContext(2)]
		public FMessageRpcCancel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DE4 RID: 138724 RVA: 0x00320AFC File Offset: 0x0031ECFC
		public FMessageRpcCancel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DE5 RID: 138725 RVA: 0x00320B07 File Offset: 0x0031ED07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMessageRpcCancel(Pointer, false, true);
		}

		// Token: 0x06021DE6 RID: 138726 RVA: 0x00320B11 File Offset: 0x0031ED11
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMessageRpcCancel(Pointer, MemoryOwner);
		}

		// Token: 0x04012114 RID: 74004
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MessagingRpc.MessageRpcCancel";

		// Token: 0x04012115 RID: 74005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012116 RID: 74006
		internal static int __PropertyOffset_CallId;
	}
}
