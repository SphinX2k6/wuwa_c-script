using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002226 RID: 8742
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTimeCode_Base_DEPRECATED")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkTimeCode_Base_DEPRECATED : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214A5 RID: 136357 RVA: 0x003111E3 File Offset: 0x0030F3E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTimeCode_Base_DEPRECATED._ScriptStructPtr != 0) ? FLiveLinkTimeCode_Base_DEPRECATED._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTimeCode_Base_DEPRECATED", ref FLiveLinkTimeCode_Base_DEPRECATED._ScriptStructPtr);
		}

		// Token: 0x170081F0 RID: 33264
		// (get) Token: 0x060214A6 RID: 136358 RVA: 0x00311207 File Offset: 0x0030F407
		// (set) Token: 0x060214A7 RID: 136359 RVA: 0x00311217 File Offset: 0x0030F417
		public unsafe int Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_Seconds) = value;
			}
		}

		// Token: 0x170081F1 RID: 33265
		// (get) Token: 0x060214A8 RID: 136360 RVA: 0x00311228 File Offset: 0x0030F428
		// (set) Token: 0x060214A9 RID: 136361 RVA: 0x00311238 File Offset: 0x0030F438
		public unsafe int Frames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_Frames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_Frames) = value;
			}
		}

		// Token: 0x170081F2 RID: 33266
		// (get) Token: 0x060214AA RID: 136362 RVA: 0x0031124C File Offset: 0x0030F44C
		// (set) Token: 0x060214AB RID: 136363 RVA: 0x0031128F File Offset: 0x0030F48F
		public FLiveLinkFrameRate FrameRate
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkFrameRate result;
				if ((result = this._FrameRate) == null)
				{
					result = (this._FrameRate = new FLiveLinkFrameRate(base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_FrameRate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkFrameRate.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTimeCode_Base_DEPRECATED.__PropertyOffset_FrameRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060214AC RID: 136364 RVA: 0x003112B0 File Offset: 0x0030F4B0
		public FLiveLinkTimeCode_Base_DEPRECATED()
		{
		}

		// Token: 0x060214AD RID: 136365 RVA: 0x003112B8 File Offset: 0x0030F4B8
		public FLiveLinkTimeCode_Base_DEPRECATED(int Seconds, int Frames, FLiveLinkFrameRate FrameRate)
		{
			this.Seconds = Seconds;
			this.Frames = Frames;
			this.FrameRate = FrameRate;
		}

		// Token: 0x060214AE RID: 136366 RVA: 0x003112D5 File Offset: 0x0030F4D5
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTimeCode_Base_DEPRECATED.StaticStruct();
		}

		// Token: 0x060214AF RID: 136367 RVA: 0x003112E1 File Offset: 0x0030F4E1
		[NullableContext(2)]
		public FLiveLinkTimeCode_Base_DEPRECATED(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214B0 RID: 136368 RVA: 0x003112EB File Offset: 0x0030F4EB
		public FLiveLinkTimeCode_Base_DEPRECATED(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214B1 RID: 136369 RVA: 0x003112F6 File Offset: 0x0030F4F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTimeCode_Base_DEPRECATED(Pointer, false, true);
		}

		// Token: 0x060214B2 RID: 136370 RVA: 0x00311300 File Offset: 0x0030F500
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTimeCode_Base_DEPRECATED(Pointer, MemoryOwner);
		}

		// Token: 0x04011C10 RID: 72720
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTimeCode_Base_DEPRECATED";

		// Token: 0x04011C11 RID: 72721
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C12 RID: 72722
		internal static int __PropertyOffset_Seconds;

		// Token: 0x04011C13 RID: 72723
		internal static int __PropertyOffset_Frames;

		// Token: 0x04011C14 RID: 72724
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04011C15 RID: 72725
		[Nullable(2)]
		private FLiveLinkFrameRate _FrameRate;
	}
}
