using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F0 RID: 4336
	[UnrealObjectPath("/Script/Engine.SingleAnimationPlayData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSingleAnimationPlayData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F8B9 RID: 63673 RVA: 0x0016FDCE File Offset: 0x0016DFCE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSingleAnimationPlayData._ScriptStructPtr != 0) ? FSingleAnimationPlayData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SingleAnimationPlayData", ref FSingleAnimationPlayData._ScriptStructPtr);
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600F8BA RID: 63674 RVA: 0x0016FDF2 File Offset: 0x0016DFF2
		// (set) Token: 0x0600F8BB RID: 63675 RVA: 0x0016FE06 File Offset: 0x0016E006
		[Nullable(2)]
		public unsafe UAnimationAsset AnimToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FSingleAnimationPlayData.__PropertyOffset_AnimToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSingleAnimationPlayData.__PropertyOffset_AnimToPlay, value);
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x0016FE1B File Offset: 0x0016E01B
		// (set) Token: 0x0600F8BD RID: 63677 RVA: 0x0016FE34 File Offset: 0x0016E034
		public unsafe bool bSavedLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedLooping) & FSingleAnimationPlayData.__PropertyMask_bSavedLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedLooping) = ((*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedLooping) & ~FSingleAnimationPlayData.__PropertyMask_bSavedLooping) | (value ? FSingleAnimationPlayData.__PropertyMask_bSavedLooping : 0));
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x0016FE64 File Offset: 0x0016E064
		// (set) Token: 0x0600F8BF RID: 63679 RVA: 0x0016FE7D File Offset: 0x0016E07D
		public unsafe bool bSavedPlaying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedPlaying) & FSingleAnimationPlayData.__PropertyMask_bSavedPlaying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedPlaying) = ((*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_bSavedPlaying) & ~FSingleAnimationPlayData.__PropertyMask_bSavedPlaying) | (value ? FSingleAnimationPlayData.__PropertyMask_bSavedPlaying : 0));
			}
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x0016FEAD File Offset: 0x0016E0AD
		// (set) Token: 0x0600F8C1 RID: 63681 RVA: 0x0016FEBD File Offset: 0x0016E0BD
		public unsafe float SavedPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_SavedPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_SavedPosition) = value;
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x0016FECE File Offset: 0x0016E0CE
		// (set) Token: 0x0600F8C3 RID: 63683 RVA: 0x0016FEDE File Offset: 0x0016E0DE
		public unsafe float SavedPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_SavedPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSingleAnimationPlayData.__PropertyOffset_SavedPlayRate) = value;
			}
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x0016FEEF File Offset: 0x0016E0EF
		public FSingleAnimationPlayData()
		{
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x0016FEF7 File Offset: 0x0016E0F7
		[NullableContext(1)]
		public FSingleAnimationPlayData(UAnimationAsset AnimToPlay, bool bSavedLooping, bool bSavedPlaying, float SavedPosition, float SavedPlayRate)
		{
			this.AnimToPlay = AnimToPlay;
			this.bSavedLooping = bSavedLooping;
			this.bSavedPlaying = bSavedPlaying;
			this.SavedPosition = SavedPosition;
			this.SavedPlayRate = SavedPlayRate;
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x0016FF24 File Offset: 0x0016E124
		protected override IntPtr GetUStructPtr()
		{
			return FSingleAnimationPlayData.StaticStruct();
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x0016FF30 File Offset: 0x0016E130
		[NullableContext(2)]
		public FSingleAnimationPlayData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x0016FF3A File Offset: 0x0016E13A
		public FSingleAnimationPlayData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x0016FF45 File Offset: 0x0016E145
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSingleAnimationPlayData(Pointer, false, true);
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x0016FF4F File Offset: 0x0016E14F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSingleAnimationPlayData(Pointer, MemoryOwner);
		}

		// Token: 0x0400865E RID: 34398
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SingleAnimationPlayData";

		// Token: 0x0400865F RID: 34399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008660 RID: 34400
		internal static int __PropertyOffset_AnimToPlay;

		// Token: 0x04008661 RID: 34401
		internal static int __PropertyOffset_bSavedLooping;

		// Token: 0x04008662 RID: 34402
		internal static byte __PropertyMask_bSavedLooping;

		// Token: 0x04008663 RID: 34403
		internal static int __PropertyOffset_bSavedPlaying;

		// Token: 0x04008664 RID: 34404
		internal static byte __PropertyMask_bSavedPlaying;

		// Token: 0x04008665 RID: 34405
		internal static int __PropertyOffset_SavedPosition;

		// Token: 0x04008666 RID: 34406
		internal static int __PropertyOffset_SavedPlayRate;
	}
}
