using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200295D RID: 10589
	[UnrealObjectPath("/Script/UMG.EventReply")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FEventReply : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027353 RID: 160595 RVA: 0x003BC680 File Offset: 0x003BA880
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEventReply._ScriptStructPtr != 0) ? FEventReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.EventReply", ref FEventReply._ScriptStructPtr);
		}

		// Token: 0x06027354 RID: 160596 RVA: 0x003BC6A4 File Offset: 0x003BA8A4
		public FEventReply()
		{
		}

		// Token: 0x06027355 RID: 160597 RVA: 0x003BC6AC File Offset: 0x003BA8AC
		protected override IntPtr GetUStructPtr()
		{
			return FEventReply.StaticStruct();
		}

		// Token: 0x06027356 RID: 160598 RVA: 0x003BC6B8 File Offset: 0x003BA8B8
		[NullableContext(2)]
		public FEventReply(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027357 RID: 160599 RVA: 0x003BC6C2 File Offset: 0x003BA8C2
		public FEventReply(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027358 RID: 160600 RVA: 0x003BC6CD File Offset: 0x003BA8CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEventReply(Pointer, false, true);
		}

		// Token: 0x06027359 RID: 160601 RVA: 0x003BC6D7 File Offset: 0x003BA8D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEventReply(Pointer, MemoryOwner);
		}

		// Token: 0x040158AB RID: 88235
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.EventReply";

		// Token: 0x040158AC RID: 88236
		private static IntPtr _ScriptStructPtr;
	}
}
