using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022E2 RID: 8930
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MessagingRpc.MessageRpcProgress")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMessageRpcProgress : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021DE7 RID: 138727 RVA: 0x00320B1A File Offset: 0x0031ED1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMessageRpcProgress._ScriptStructPtr != 0) ? FMessageRpcProgress._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MessagingRpc.MessageRpcProgress", ref FMessageRpcProgress._ScriptStructPtr);
		}

		// Token: 0x17008318 RID: 33560
		// (get) Token: 0x06021DE8 RID: 138728 RVA: 0x00320B3E File Offset: 0x0031ED3E
		// (set) Token: 0x06021DE9 RID: 138729 RVA: 0x00320B4E File Offset: 0x0031ED4E
		public unsafe float Completion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMessageRpcProgress.__PropertyOffset_Completion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMessageRpcProgress.__PropertyOffset_Completion) = value;
			}
		}

		// Token: 0x17008319 RID: 33561
		// (get) Token: 0x06021DEA RID: 138730 RVA: 0x00320B5F File Offset: 0x0031ED5F
		// (set) Token: 0x06021DEB RID: 138731 RVA: 0x00320B73 File Offset: 0x0031ED73
		public unsafe FGuid CallId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMessageRpcProgress.__PropertyOffset_CallId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMessageRpcProgress.__PropertyOffset_CallId) = value;
			}
		}

		// Token: 0x1700831A RID: 33562
		// (get) Token: 0x06021DEC RID: 138732 RVA: 0x00320B88 File Offset: 0x0031ED88
		// (set) Token: 0x06021DED RID: 138733 RVA: 0x00320B9C File Offset: 0x0031ED9C
		public unsafe string StatusText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMessageRpcProgress.__PropertyOffset_StatusText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMessageRpcProgress.__PropertyOffset_StatusText)), value);
			}
		}

		// Token: 0x06021DEE RID: 138734 RVA: 0x00320BB1 File Offset: 0x0031EDB1
		public FMessageRpcProgress()
		{
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x00320BB9 File Offset: 0x0031EDB9
		public FMessageRpcProgress(float Completion, FGuid CallId, string StatusText)
		{
			this.Completion = Completion;
			this.CallId = CallId;
			this.StatusText = StatusText;
		}

		// Token: 0x06021DF0 RID: 138736 RVA: 0x00320BD6 File Offset: 0x0031EDD6
		protected override IntPtr GetUStructPtr()
		{
			return FMessageRpcProgress.StaticStruct();
		}

		// Token: 0x06021DF1 RID: 138737 RVA: 0x00320BE2 File Offset: 0x0031EDE2
		[NullableContext(2)]
		public FMessageRpcProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021DF2 RID: 138738 RVA: 0x00320BEC File Offset: 0x0031EDEC
		public FMessageRpcProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021DF3 RID: 138739 RVA: 0x00320BF7 File Offset: 0x0031EDF7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMessageRpcProgress(Pointer, false, true);
		}

		// Token: 0x06021DF4 RID: 138740 RVA: 0x00320C01 File Offset: 0x0031EE01
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMessageRpcProgress(Pointer, MemoryOwner);
		}

		// Token: 0x04012117 RID: 74007
		public const string __ObjectPath = "/Script/MessagingRpc.MessageRpcProgress";

		// Token: 0x04012118 RID: 74008
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012119 RID: 74009
		internal static int __PropertyOffset_Completion;

		// Token: 0x0401211A RID: 74010
		internal static int __PropertyOffset_CallId;

		// Token: 0x0401211B RID: 74011
		internal static int __PropertyOffset_StatusText;
	}
}
