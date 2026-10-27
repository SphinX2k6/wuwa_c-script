using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212E RID: 8494
	[UnrealObjectPath("/Script/LGUI.UIBaseRenderable")]
	[UnrealStructLayout(1696, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public abstract class UUIBaseRenderable : UUIItem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF67 RID: 130919 RVA: 0x002F8969 File Offset: 0x002F6B69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBaseRenderable._ClassPtr;
		}

		// Token: 0x17007D97 RID: 32151
		// (get) Token: 0x0601FF68 RID: 130920 RVA: 0x002F8975 File Offset: 0x002F6B75
		// (set) Token: 0x0601FF69 RID: 130921 RVA: 0x002F8985 File Offset: 0x002F6B85
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

		// Token: 0x17007D98 RID: 32152
		// (get) Token: 0x0601FF6A RID: 130922 RVA: 0x002F8996 File Offset: 0x002F6B96
		// (set) Token: 0x0601FF6B RID: 130923 RVA: 0x002F89A6 File Offset: 0x002F6BA6
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

		// Token: 0x17007D99 RID: 32153
		// (get) Token: 0x0601FF6C RID: 130924 RVA: 0x002F89B7 File Offset: 0x002F6BB7
		// (set) Token: 0x0601FF6D RID: 130925 RVA: 0x002F89C7 File Offset: 0x002F6BC7
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

		// Token: 0x17007D9A RID: 32154
		// (get) Token: 0x0601FF6E RID: 130926 RVA: 0x002F89D8 File Offset: 0x002F6BD8
		// (set) Token: 0x0601FF6F RID: 130927 RVA: 0x002F89E8 File Offset: 0x002F6BE8
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

		// Token: 0x17007D9B RID: 32155
		// (get) Token: 0x0601FF70 RID: 130928 RVA: 0x002F89F9 File Offset: 0x002F6BF9
		// (set) Token: 0x0601FF71 RID: 130929 RVA: 0x002F8A09 File Offset: 0x002F6C09
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

		// Token: 0x17007D9C RID: 32156
		// (get) Token: 0x0601FF72 RID: 130930 RVA: 0x002F8A1A File Offset: 0x002F6C1A
		// (set) Token: 0x0601FF73 RID: 130931 RVA: 0x002F8A2E File Offset: 0x002F6C2E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUI2DLineActor> DebugBoundingBoxLine
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_DebugBoundingBoxLine);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIBaseRenderable.__PropertyOffset_DebugBoundingBoxLine) = value;
			}
		}

		// Token: 0x17007D9D RID: 32157
		// (get) Token: 0x0601FF74 RID: 130932 RVA: 0x002F8A43 File Offset: 0x002F6C43
		// (set) Token: 0x0601FF75 RID: 130933 RVA: 0x002F8A57 File Offset: 0x002F6C57
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

		// Token: 0x0601FF76 RID: 130934 RVA: 0x002F8A6C File Offset: 0x002F6C6C
		public void TestAdjustSingleNode()
		{
			UUIBaseRenderable.__TestAdjustSingleNode_Internal(base.NativePtr);
		}

		// Token: 0x0601FF77 RID: 130935 RVA: 0x002F8A79 File Offset: 0x002F6C79
		public void SetUIRenderAfterBlurPartial(bool bAfterBlurPartial)
		{
			UUIBaseRenderable.__SetUIRenderAfterBlurPartial_Internal(base.NativePtr, bAfterBlurPartial);
		}

		// Token: 0x0601FF78 RID: 130936 RVA: 0x002F8A87 File Offset: 0x002F6C87
		public void LogBatchDepthParents()
		{
			UUIBaseRenderable.__LogBatchDepthParents_Internal(base.NativePtr);
		}

		// Token: 0x0601FF79 RID: 130937 RVA: 0x002F8A94 File Offset: 0x002F6C94
		public EUIRenderableType GetUIRenderableType()
		{
			return UUIBaseRenderable.__GetUIRenderableType_Internal(base.NativePtr);
		}

		// Token: 0x0601FF7A RID: 130938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestAdjustSingleNode_Internal(IntPtr @this);

		// Token: 0x0601FF7B RID: 130939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderAfterBlurPartial_Internal(IntPtr @this, bool bAfterBlurPartial);

		// Token: 0x0601FF7C RID: 130940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogBatchDepthParents_Internal(IntPtr @this);

		// Token: 0x0601FF7D RID: 130941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUIRenderableType __GetUIRenderableType_Internal(IntPtr @this);

		// Token: 0x0601FF7E RID: 130942 RVA: 0x002F8AA1 File Offset: 0x002F6CA1
		static UUIBaseRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBaseRenderable");
		}

		// Token: 0x0601FF7F RID: 130943 RVA: 0x002F8AB0 File Offset: 0x002F6CB0
		protected UUIBaseRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIBaseRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF80 RID: 130944 RVA: 0x002F8AD8 File Offset: 0x002F6CD8
		protected UUIBaseRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011364 RID: 70500
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBaseRenderable";

		// Token: 0x04011365 RID: 70501
		private static IntPtr _ClassPtr;

		// Token: 0x04011366 RID: 70502
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011367 RID: 70503
		internal static int __PropertyOffset_BatchDepth;

		// Token: 0x04011368 RID: 70504
		internal static int __PropertyOffset_LayerDepth;

		// Token: 0x04011369 RID: 70505
		internal static int __PropertyOffset_ExtraBatchDepth;

		// Token: 0x0401136A RID: 70506
		internal static int __PropertyOffset_bIsRenderAfterBlurPartial;

		// Token: 0x0401136B RID: 70507
		internal static int __PropertyOffset_bIsAlphaZeroClip;

		// Token: 0x0401136C RID: 70508
		internal static int __PropertyOffset_DebugBoundingBoxLine;

		// Token: 0x0401136D RID: 70509
		internal static int __PropertyOffset_RenderableMask;
	}
}
