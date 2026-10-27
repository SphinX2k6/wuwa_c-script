using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002227 RID: 8743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTimeSynchronizationSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLiveLinkTimeSynchronizationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214B3 RID: 136371 RVA: 0x00311309 File Offset: 0x0030F509
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTimeSynchronizationSettings._ScriptStructPtr != 0) ? FLiveLinkTimeSynchronizationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTimeSynchronizationSettings", ref FLiveLinkTimeSynchronizationSettings._ScriptStructPtr);
		}

		// Token: 0x170081F3 RID: 33267
		// (get) Token: 0x060214B4 RID: 136372 RVA: 0x0031132D File Offset: 0x0030F52D
		// (set) Token: 0x060214B5 RID: 136373 RVA: 0x00311341 File Offset: 0x0030F541
		public unsafe FFrameRate FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTimeSynchronizationSettings.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTimeSynchronizationSettings.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x170081F4 RID: 33268
		// (get) Token: 0x060214B6 RID: 136374 RVA: 0x00311358 File Offset: 0x0030F558
		// (set) Token: 0x060214B7 RID: 136375 RVA: 0x0031139B File Offset: 0x0030F59B
		public FFrameNumber FrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FrameOffset) == null)
				{
					result = (this._FrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FLiveLinkTimeSynchronizationSettings.__PropertyOffset_FrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTimeSynchronizationSettings.__PropertyOffset_FrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060214B8 RID: 136376 RVA: 0x003113BC File Offset: 0x0030F5BC
		public FLiveLinkTimeSynchronizationSettings()
		{
		}

		// Token: 0x060214B9 RID: 136377 RVA: 0x003113C4 File Offset: 0x0030F5C4
		public FLiveLinkTimeSynchronizationSettings(FFrameRate FrameRate, FFrameNumber FrameOffset)
		{
			this.FrameRate = FrameRate;
			this.FrameOffset = FrameOffset;
		}

		// Token: 0x060214BA RID: 136378 RVA: 0x003113DA File Offset: 0x0030F5DA
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTimeSynchronizationSettings.StaticStruct();
		}

		// Token: 0x060214BB RID: 136379 RVA: 0x003113E6 File Offset: 0x0030F5E6
		[NullableContext(2)]
		public FLiveLinkTimeSynchronizationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214BC RID: 136380 RVA: 0x003113F0 File Offset: 0x0030F5F0
		public FLiveLinkTimeSynchronizationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214BD RID: 136381 RVA: 0x003113FB File Offset: 0x0030F5FB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTimeSynchronizationSettings(Pointer, false, true);
		}

		// Token: 0x060214BE RID: 136382 RVA: 0x00311405 File Offset: 0x0030F605
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTimeSynchronizationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04011C16 RID: 72726
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTimeSynchronizationSettings";

		// Token: 0x04011C17 RID: 72727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C18 RID: 72728
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04011C19 RID: 72729
		internal static int __PropertyOffset_FrameOffset;

		// Token: 0x04011C1A RID: 72730
		[Nullable(2)]
		private FFrameNumber _FrameOffset;
	}
}
