using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A5 RID: 1957
	[UnrealObjectPath("/Script/Engine.ActiveHapticFeedbackEffect")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FActiveHapticFeedbackEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065FD RID: 26109 RVA: 0x000922FC File Offset: 0x000904FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveHapticFeedbackEffect._ScriptStructPtr != 0) ? FActiveHapticFeedbackEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActiveHapticFeedbackEffect", ref FActiveHapticFeedbackEffect._ScriptStructPtr);
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x00092320 File Offset: 0x00090520
		// (set) Token: 0x060065FF RID: 26111 RVA: 0x00092334 File Offset: 0x00090534
		[Nullable(2)]
		public unsafe UHapticFeedbackEffect_Base HapticEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHapticFeedbackEffect_Base>(base.NativePtr / (IntPtr)sizeof(void*) + FActiveHapticFeedbackEffect.__PropertyOffset_HapticEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActiveHapticFeedbackEffect.__PropertyOffset_HapticEffect, value);
			}
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00092349 File Offset: 0x00090549
		public FActiveHapticFeedbackEffect()
		{
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00092351 File Offset: 0x00090551
		[NullableContext(1)]
		public FActiveHapticFeedbackEffect(UHapticFeedbackEffect_Base HapticEffect)
		{
			this.HapticEffect = HapticEffect;
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x00092360 File Offset: 0x00090560
		protected override IntPtr GetUStructPtr()
		{
			return FActiveHapticFeedbackEffect.StaticStruct();
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0009236C File Offset: 0x0009056C
		[NullableContext(2)]
		public FActiveHapticFeedbackEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x00092376 File Offset: 0x00090576
		public FActiveHapticFeedbackEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x00092381 File Offset: 0x00090581
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveHapticFeedbackEffect(Pointer, false, true);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x0009238B File Offset: 0x0009058B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveHapticFeedbackEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04003180 RID: 12672
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActiveHapticFeedbackEffect";

		// Token: 0x04003181 RID: 12673
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003182 RID: 12674
		internal static int __PropertyOffset_HapticEffect;
	}
}
