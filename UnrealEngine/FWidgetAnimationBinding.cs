using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029F7 RID: 10743
	[UnrealObjectPath("/Script/UMG.WidgetAnimationBinding")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FWidgetAnimationBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DFC RID: 163324 RVA: 0x003CBDAB File Offset: 0x003C9FAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetAnimationBinding._ScriptStructPtr != 0) ? FWidgetAnimationBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.WidgetAnimationBinding", ref FWidgetAnimationBinding._ScriptStructPtr);
		}

		// Token: 0x1700987D RID: 39037
		// (get) Token: 0x06027DFD RID: 163325 RVA: 0x003CBDCF File Offset: 0x003C9FCF
		// (set) Token: 0x06027DFE RID: 163326 RVA: 0x003CBDE3 File Offset: 0x003C9FE3
		public unsafe FName WidgetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_WidgetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_WidgetName) = value;
			}
		}

		// Token: 0x1700987E RID: 39038
		// (get) Token: 0x06027DFF RID: 163327 RVA: 0x003CBDF8 File Offset: 0x003C9FF8
		// (set) Token: 0x06027E00 RID: 163328 RVA: 0x003CBE0C File Offset: 0x003CA00C
		public unsafe FName SlotWidgetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_SlotWidgetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_SlotWidgetName) = value;
			}
		}

		// Token: 0x1700987F RID: 39039
		// (get) Token: 0x06027E01 RID: 163329 RVA: 0x003CBE21 File Offset: 0x003CA021
		// (set) Token: 0x06027E02 RID: 163330 RVA: 0x003CBE35 File Offset: 0x003CA035
		public unsafe FGuid AnimationGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_AnimationGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_AnimationGuid) = value;
			}
		}

		// Token: 0x17009880 RID: 39040
		// (get) Token: 0x06027E03 RID: 163331 RVA: 0x003CBE4A File Offset: 0x003CA04A
		// (set) Token: 0x06027E04 RID: 163332 RVA: 0x003CBE5A File Offset: 0x003CA05A
		public unsafe bool bIsRootWidget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_bIsRootWidget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetAnimationBinding.__PropertyOffset_bIsRootWidget) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027E05 RID: 163333 RVA: 0x003CBE6B File Offset: 0x003CA06B
		public FWidgetAnimationBinding()
		{
		}

		// Token: 0x06027E06 RID: 163334 RVA: 0x003CBE73 File Offset: 0x003CA073
		public FWidgetAnimationBinding(FName WidgetName, FName SlotWidgetName, FGuid AnimationGuid, bool bIsRootWidget)
		{
			this.WidgetName = WidgetName;
			this.SlotWidgetName = SlotWidgetName;
			this.AnimationGuid = AnimationGuid;
			this.bIsRootWidget = bIsRootWidget;
		}

		// Token: 0x06027E07 RID: 163335 RVA: 0x003CBE98 File Offset: 0x003CA098
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetAnimationBinding.StaticStruct();
		}

		// Token: 0x06027E08 RID: 163336 RVA: 0x003CBEA4 File Offset: 0x003CA0A4
		[NullableContext(2)]
		public FWidgetAnimationBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027E09 RID: 163337 RVA: 0x003CBEAE File Offset: 0x003CA0AE
		public FWidgetAnimationBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027E0A RID: 163338 RVA: 0x003CBEB9 File Offset: 0x003CA0B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetAnimationBinding(Pointer, false, true);
		}

		// Token: 0x06027E0B RID: 163339 RVA: 0x003CBEC3 File Offset: 0x003CA0C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetAnimationBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04015CBC RID: 89276
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.WidgetAnimationBinding";

		// Token: 0x04015CBD RID: 89277
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015CBE RID: 89278
		internal static int __PropertyOffset_WidgetName;

		// Token: 0x04015CBF RID: 89279
		internal static int __PropertyOffset_SlotWidgetName;

		// Token: 0x04015CC0 RID: 89280
		internal static int __PropertyOffset_AnimationGuid;

		// Token: 0x04015CC1 RID: 89281
		internal static int __PropertyOffset_bIsRootWidget;
	}
}
