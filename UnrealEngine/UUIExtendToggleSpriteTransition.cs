using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000702 RID: 1794
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleSpriteTransition")]
	[UnrealStructLayout(936, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 936)]
	public class UUIExtendToggleSpriteTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060098E0 RID: 39136 RVA: 0x000E6433 File Offset: 0x000E4633
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleSpriteTransition._ClassPtr;
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x000E6440 File Offset: 0x000E4640
		public UUIExtendToggleSpriteTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleSpriteTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x000E6468 File Offset: 0x000E4668
		public UUIExtendToggleSpriteTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleSpriteTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x060098E3 RID: 39139 RVA: 0x000E649C File Offset: 0x000E469C
		// (set) Token: 0x060098E4 RID: 39140 RVA: 0x000E64D5 File Offset: 0x000E46D5
		public FExtendToggleColorTransition TransitionColors
		{
			get
			{
				base.FastCheckIsValid();
				FExtendToggleColorTransition result;
				if ((result = this._TransitionColors) == null)
				{
					result = (this._TransitionColors = new FExtendToggleColorTransition(base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionColors, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExtendToggleColorTransition.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionColors, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x060098E5 RID: 39141 RVA: 0x000E64F8 File Offset: 0x000E46F8
		// (set) Token: 0x060098E6 RID: 39142 RVA: 0x000E6531 File Offset: 0x000E4731
		public FExtendToggleSpriteTransitionState TransitionState
		{
			get
			{
				base.FastCheckIsValid();
				FExtendToggleSpriteTransitionState result;
				if ((result = this._TransitionState) == null)
				{
					result = (this._TransitionState = new FExtendToggleSpriteTransitionState(base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExtendToggleSpriteTransitionState.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x060098E7 RID: 39143 RVA: 0x000E6552 File Offset: 0x000E4752
		// (set) Token: 0x060098E8 RID: 39144 RVA: 0x000E6566 File Offset: 0x000E4766
		[Nullable(2)]
		public unsafe ULTweener ColorTweener
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleSpriteTransition.__PropertyOffset_ColorTweener);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleSpriteTransition.__PropertyOffset_ColorTweener, value);
			}
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x000E657B File Offset: 0x000E477B
		[NullableContext(2)]
		public void SetStateSprite(EToggleTransitionState State, ULGUISpriteData_BaseObject NewSprite, bool ForceNoTriggerOnChange = false)
		{
			UUIExtendToggleSpriteTransition.__SetStateSprite_Internal(base.NativePtr, State, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero, ForceNoTriggerOnChange);
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x000E659A File Offset: 0x000E479A
		[NullableContext(2)]
		public void SetAllStateSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUIExtendToggleSpriteTransition.__SetAllStateSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098EB RID: 39147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateSprite_Internal(IntPtr @this, EToggleTransitionState State, IntPtr NewSprite, bool ForceNoTriggerOnChange);

		// Token: 0x060098EC RID: 39148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllStateSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x060098ED RID: 39149 RVA: 0x000E65B7 File Offset: 0x000E47B7
		static UUIExtendToggleSpriteTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleSpriteTransition");
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x000E65C5 File Offset: 0x000E47C5
		protected UUIExtendToggleSpriteTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004274 RID: 17012
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleSpriteTransition";

		// Token: 0x04004275 RID: 17013
		private static IntPtr _ClassPtr;

		// Token: 0x04004276 RID: 17014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004277 RID: 17015
		internal static int __PropertyOffset_TransitionColors;

		// Token: 0x04004278 RID: 17016
		[Nullable(2)]
		private FExtendToggleColorTransition _TransitionColors;

		// Token: 0x04004279 RID: 17017
		internal static int __PropertyOffset_TransitionState;

		// Token: 0x0400427A RID: 17018
		[Nullable(2)]
		private FExtendToggleSpriteTransitionState _TransitionState;

		// Token: 0x0400427B RID: 17019
		internal static int __PropertyOffset_ColorTweener;
	}
}
