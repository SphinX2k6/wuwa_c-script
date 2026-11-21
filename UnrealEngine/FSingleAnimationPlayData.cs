using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027C RID: 636
	[UnrealObjectPath("/Script/Engine.SingleAnimationPlayData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSingleAnimationPlayData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060041EF RID: 16879 RVA: 0x0005E411 File Offset: 0x0005C611
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSingleAnimationPlayData._ScriptStructPtr != 0) ? FSingleAnimationPlayData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SingleAnimationPlayData", ref FSingleAnimationPlayData._ScriptStructPtr);
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x0005E435 File Offset: 0x0005C635
		// (set) Token: 0x060041F1 RID: 16881 RVA: 0x0005E449 File Offset: 0x0005C649
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x0005E45E File Offset: 0x0005C65E
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x0005E477 File Offset: 0x0005C677
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x0005E4A7 File Offset: 0x0005C6A7
		// (set) Token: 0x060041F5 RID: 16885 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x0005E4F0 File Offset: 0x0005C6F0
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x0005E500 File Offset: 0x0005C700
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x0005E511 File Offset: 0x0005C711
		// (set) Token: 0x060041F9 RID: 16889 RVA: 0x0005E521 File Offset: 0x0005C721
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

		// Token: 0x060041FA RID: 16890 RVA: 0x0005E532 File Offset: 0x0005C732
		public FSingleAnimationPlayData()
		{
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0005E53A File Offset: 0x0005C73A
		protected override IntPtr GetUStructPtr()
		{
			return FSingleAnimationPlayData.StaticStruct();
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0005E546 File Offset: 0x0005C746
		[NullableContext(2)]
		public FSingleAnimationPlayData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x0005E550 File Offset: 0x0005C750
		public FSingleAnimationPlayData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0005E55B File Offset: 0x0005C75B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSingleAnimationPlayData(Pointer, false, true);
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0005E565 File Offset: 0x0005C765
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSingleAnimationPlayData(Pointer, MemoryOwner);
		}

		// Token: 0x040019C8 RID: 6600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SingleAnimationPlayData";

		// Token: 0x040019C9 RID: 6601
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019CA RID: 6602
		internal static int __PropertyOffset_AnimToPlay;

		// Token: 0x040019CB RID: 6603
		internal static int __PropertyOffset_bSavedLooping;

		// Token: 0x040019CC RID: 6604
		internal static byte __PropertyMask_bSavedLooping;

		// Token: 0x040019CD RID: 6605
		internal static int __PropertyOffset_bSavedPlaying;

		// Token: 0x040019CE RID: 6606
		internal static byte __PropertyMask_bSavedPlaying;

		// Token: 0x040019CF RID: 6607
		internal static int __PropertyOffset_SavedPosition;

		// Token: 0x040019D0 RID: 6608
		internal static int __PropertyOffset_SavedPlayRate;
	}
}
