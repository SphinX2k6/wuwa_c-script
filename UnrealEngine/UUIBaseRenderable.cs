using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EC RID: 1772
	[UnrealObjectPath("/Script/LGUI.UIBaseRenderable")]
	[UnrealStructLayout(1696, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public abstract class UUIBaseRenderable : UUIItem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600965B RID: 38491 RVA: 0x000E2DFD File Offset: 0x000E0FFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBaseRenderable._ClassPtr;
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x0600965C RID: 38492 RVA: 0x000E2E09 File Offset: 0x000E1009
		// (set) Token: 0x0600965D RID: 38493 RVA: 0x000E2E19 File Offset: 0x000E1019
		public unsafe int BatchDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_BatchDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_BatchDepth) = value;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x000E2E2A File Offset: 0x000E102A
		// (set) Token: 0x0600965F RID: 38495 RVA: 0x000E2E3A File Offset: 0x000E103A
		public unsafe int LayerDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_LayerDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_LayerDepth) = value;
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x000E2E4B File Offset: 0x000E104B
		// (set) Token: 0x06009661 RID: 38497 RVA: 0x000E2E5B File Offset: 0x000E105B
		public unsafe int ExtraBatchDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_ExtraBatchDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_ExtraBatchDepth) = value;
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x000E2E6C File Offset: 0x000E106C
		// (set) Token: 0x06009663 RID: 38499 RVA: 0x000E2E7C File Offset: 0x000E107C
		public unsafe bool bIsRenderAfterBlurPartial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_bIsRenderAfterBlurPartial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_bIsRenderAfterBlurPartial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x000E2E8D File Offset: 0x000E108D
		// (set) Token: 0x06009665 RID: 38501 RVA: 0x000E2E9D File Offset: 0x000E109D
		public unsafe bool bIsAlphaZeroClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_bIsAlphaZeroClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_bIsAlphaZeroClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x000E2EAE File Offset: 0x000E10AE
		// (set) Token: 0x06009667 RID: 38503 RVA: 0x000E2EC2 File Offset: 0x000E10C2
		[Nullable(2)]
		public unsafe UUIRenderableMask RenderableMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIRenderableMask>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBaseRenderable.__PropertyOffset_RenderableMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBaseRenderable.__PropertyOffset_RenderableMask, value);
			}
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x000E2ED7 File Offset: 0x000E10D7
		public void TestAdjustSingleNode()
		{
			UUIBaseRenderable.__TestAdjustSingleNode_Internal(base.NativePtr);
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x000E2EE4 File Offset: 0x000E10E4
		public void SetUIRenderAfterBlurPartial(bool bAfterBlurPartial)
		{
			UUIBaseRenderable.__SetUIRenderAfterBlurPartial_Internal(base.NativePtr, bAfterBlurPartial);
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x000E2EF2 File Offset: 0x000E10F2
		public void LogBatchDepthParents()
		{
			UUIBaseRenderable.__LogBatchDepthParents_Internal(base.NativePtr);
		}

		// Token: 0x0600966B RID: 38507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestAdjustSingleNode_Internal(IntPtr @this);

		// Token: 0x0600966C RID: 38508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderAfterBlurPartial_Internal(IntPtr @this, bool bAfterBlurPartial);

		// Token: 0x0600966D RID: 38509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogBatchDepthParents_Internal(IntPtr @this);

		// Token: 0x0600966E RID: 38510 RVA: 0x000E2EFF File Offset: 0x000E10FF
		static UUIBaseRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBaseRenderable");
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x000E2F10 File Offset: 0x000E1110
		protected UUIBaseRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIBaseRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x000E2F38 File Offset: 0x000E1138
		protected UUIBaseRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004163 RID: 16739
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBaseRenderable";

		// Token: 0x04004164 RID: 16740
		private static IntPtr _ClassPtr;

		// Token: 0x04004165 RID: 16741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004166 RID: 16742
		internal static int __PropertyOffset_BatchDepth;

		// Token: 0x04004167 RID: 16743
		internal static int __PropertyOffset_LayerDepth;

		// Token: 0x04004168 RID: 16744
		internal static int __PropertyOffset_ExtraBatchDepth;

		// Token: 0x04004169 RID: 16745
		internal static int __PropertyOffset_bIsRenderAfterBlurPartial;

		// Token: 0x0400416A RID: 16746
		internal static int __PropertyOffset_bIsAlphaZeroClip;

		// Token: 0x0400416B RID: 16747
		internal static int __PropertyOffset_RenderableMask;
	}
}
