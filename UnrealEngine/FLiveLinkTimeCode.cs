using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002225 RID: 8741
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTimeCode")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkTimeCode : FLiveLinkTimeCode_Base_DEPRECATED, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602149D RID: 136349 RVA: 0x00311166 File Offset: 0x0030F366
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTimeCode._ScriptStructPtr != 0) ? FLiveLinkTimeCode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTimeCode", ref FLiveLinkTimeCode._ScriptStructPtr);
		}

		// Token: 0x0602149E RID: 136350 RVA: 0x0031118A File Offset: 0x0030F38A
		public FLiveLinkTimeCode()
		{
		}

		// Token: 0x0602149F RID: 136351 RVA: 0x00311192 File Offset: 0x0030F392
		[NullableContext(1)]
		public FLiveLinkTimeCode(int Seconds, int Frames, FLiveLinkFrameRate FrameRate)
		{
			base.Seconds = Seconds;
			base.Frames = Frames;
			base.FrameRate = FrameRate;
		}

		// Token: 0x060214A0 RID: 136352 RVA: 0x003111AF File Offset: 0x0030F3AF
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTimeCode.StaticStruct();
		}

		// Token: 0x060214A1 RID: 136353 RVA: 0x003111BB File Offset: 0x0030F3BB
		[NullableContext(2)]
		public FLiveLinkTimeCode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214A2 RID: 136354 RVA: 0x003111C5 File Offset: 0x0030F3C5
		public FLiveLinkTimeCode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214A3 RID: 136355 RVA: 0x003111D0 File Offset: 0x0030F3D0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTimeCode(Pointer, false, true);
		}

		// Token: 0x060214A4 RID: 136356 RVA: 0x003111DA File Offset: 0x0030F3DA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTimeCode(Pointer, MemoryOwner);
		}

		// Token: 0x04011C0E RID: 72718
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTimeCode";

		// Token: 0x04011C0F RID: 72719
		private static IntPtr _ScriptStructPtr;
	}
}
