using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BE9 RID: 3049
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FontRenderInfo")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FFontRenderInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009653 RID: 38483 RVA: 0x000D661D File Offset: 0x000D481D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontRenderInfo._ScriptStructPtr != 0) ? FFontRenderInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FontRenderInfo", ref FFontRenderInfo._ScriptStructPtr);
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06009654 RID: 38484 RVA: 0x000D6641 File Offset: 0x000D4841
		// (set) Token: 0x06009655 RID: 38485 RVA: 0x000D665A File Offset: 0x000D485A
		public unsafe bool bClipText
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bClipText) & FFontRenderInfo.__PropertyMask_bClipText) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bClipText) = ((*(base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bClipText) & ~FFontRenderInfo.__PropertyMask_bClipText) | (value ? FFontRenderInfo.__PropertyMask_bClipText : 0));
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x000D668A File Offset: 0x000D488A
		// (set) Token: 0x06009657 RID: 38487 RVA: 0x000D66A3 File Offset: 0x000D48A3
		public unsafe bool bEnableShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bEnableShadow) & FFontRenderInfo.__PropertyMask_bEnableShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bEnableShadow) = ((*(base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_bEnableShadow) & ~FFontRenderInfo.__PropertyMask_bEnableShadow) | (value ? FFontRenderInfo.__PropertyMask_bEnableShadow : 0));
			}
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x06009658 RID: 38488 RVA: 0x000D66D4 File Offset: 0x000D48D4
		// (set) Token: 0x06009659 RID: 38489 RVA: 0x000D6717 File Offset: 0x000D4917
		public FDepthFieldGlowInfo GlowInfo
		{
			get
			{
				base.FastCheckIsValid();
				FDepthFieldGlowInfo result;
				if ((result = this._GlowInfo) == null)
				{
					result = (this._GlowInfo = new FDepthFieldGlowInfo(base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_GlowInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDepthFieldGlowInfo.StaticStruct(), base.NativePtr + (IntPtr)FFontRenderInfo.__PropertyOffset_GlowInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x000D6738 File Offset: 0x000D4938
		public FFontRenderInfo()
		{
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x000D6740 File Offset: 0x000D4940
		public FFontRenderInfo(bool bClipText, bool bEnableShadow, FDepthFieldGlowInfo GlowInfo)
		{
			this.bClipText = bClipText;
			this.bEnableShadow = bEnableShadow;
			this.GlowInfo = GlowInfo;
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x000D675D File Offset: 0x000D495D
		protected override IntPtr GetUStructPtr()
		{
			return FFontRenderInfo.StaticStruct();
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x000D6769 File Offset: 0x000D4969
		[NullableContext(2)]
		public FFontRenderInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x000D6773 File Offset: 0x000D4973
		public FFontRenderInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x000D677E File Offset: 0x000D497E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontRenderInfo(Pointer, false, true);
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x000D6788 File Offset: 0x000D4988
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontRenderInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005456 RID: 21590
		public const string __ObjectPath = "/Script/Engine.FontRenderInfo";

		// Token: 0x04005457 RID: 21591
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005458 RID: 21592
		internal static int __PropertyOffset_bClipText;

		// Token: 0x04005459 RID: 21593
		internal static byte __PropertyMask_bClipText;

		// Token: 0x0400545A RID: 21594
		internal static int __PropertyOffset_bEnableShadow;

		// Token: 0x0400545B RID: 21595
		internal static byte __PropertyMask_bEnableShadow;

		// Token: 0x0400545C RID: 21596
		internal static int __PropertyOffset_GlowInfo;

		// Token: 0x0400545D RID: 21597
		[Nullable(2)]
		private FDepthFieldGlowInfo _GlowInfo;
	}
}
