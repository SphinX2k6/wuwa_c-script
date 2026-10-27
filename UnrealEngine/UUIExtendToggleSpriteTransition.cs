using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216A RID: 8554
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleSpriteTransition")]
	[UnrealStructLayout(936, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 936)]
	public class UUIExtendToggleSpriteTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204AC RID: 132268 RVA: 0x002FF4E7 File Offset: 0x002FD6E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleSpriteTransition._ClassPtr;
		}

		// Token: 0x060204AD RID: 132269 RVA: 0x002FF4F4 File Offset: 0x002FD6F4
		public UUIExtendToggleSpriteTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleSpriteTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204AE RID: 132270 RVA: 0x002FF51C File Offset: 0x002FD71C
		public UUIExtendToggleSpriteTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleSpriteTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E93 RID: 32403
		// (get) Token: 0x060204AF RID: 132271 RVA: 0x002FF54F File Offset: 0x002FD74F
		// (set) Token: 0x060204B0 RID: 132272 RVA: 0x002FF55F File Offset: 0x002FD75F
		public unsafe ESpriteTransitionType TransitionType
		{
			get
			{
				return (ESpriteTransitionType)(*(base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggleSpriteTransition.__PropertyOffset_TransitionType) = (byte)value;
			}
		}

		// Token: 0x17007E94 RID: 32404
		// (get) Token: 0x060204B1 RID: 132273 RVA: 0x002FF570 File Offset: 0x002FD770
		// (set) Token: 0x060204B2 RID: 132274 RVA: 0x002FF5A9 File Offset: 0x002FD7A9
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

		// Token: 0x17007E95 RID: 32405
		// (get) Token: 0x060204B3 RID: 132275 RVA: 0x002FF5CC File Offset: 0x002FD7CC
		// (set) Token: 0x060204B4 RID: 132276 RVA: 0x002FF605 File Offset: 0x002FD805
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

		// Token: 0x17007E96 RID: 32406
		// (get) Token: 0x060204B5 RID: 132277 RVA: 0x002FF626 File Offset: 0x002FD826
		// (set) Token: 0x060204B6 RID: 132278 RVA: 0x002FF63A File Offset: 0x002FD83A
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

		// Token: 0x060204B7 RID: 132279 RVA: 0x002FF64F File Offset: 0x002FD84F
		[NullableContext(2)]
		public void SetStateSprite(EToggleTransitionState State, ULGUISpriteData_BaseObject NewSprite, bool ForceNoTriggerOnChange = false)
		{
			UUIExtendToggleSpriteTransition.__SetStateSprite_Internal(base.NativePtr, State, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero, ForceNoTriggerOnChange);
		}

		// Token: 0x060204B8 RID: 132280 RVA: 0x002FF66E File Offset: 0x002FD86E
		[NullableContext(2)]
		public void SetAllStateSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUIExtendToggleSpriteTransition.__SetAllStateSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060204B9 RID: 132281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateSprite_Internal(IntPtr @this, EToggleTransitionState State, IntPtr NewSprite, bool ForceNoTriggerOnChange);

		// Token: 0x060204BA RID: 132282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllStateSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x060204BB RID: 132283 RVA: 0x002FF68B File Offset: 0x002FD88B
		static UUIExtendToggleSpriteTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleSpriteTransition");
		}

		// Token: 0x060204BC RID: 132284 RVA: 0x002FF699 File Offset: 0x002FD899
		protected UUIExtendToggleSpriteTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011597 RID: 71063
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleSpriteTransition";

		// Token: 0x04011598 RID: 71064
		private static IntPtr _ClassPtr;

		// Token: 0x04011599 RID: 71065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401159A RID: 71066
		internal static int __PropertyOffset_TransitionType;

		// Token: 0x0401159B RID: 71067
		internal static int __PropertyOffset_TransitionColors;

		// Token: 0x0401159C RID: 71068
		[Nullable(2)]
		private FExtendToggleColorTransition _TransitionColors;

		// Token: 0x0401159D RID: 71069
		internal static int __PropertyOffset_TransitionState;

		// Token: 0x0401159E RID: 71070
		[Nullable(2)]
		private FExtendToggleSpriteTransitionState _TransitionState;

		// Token: 0x0401159F RID: 71071
		internal static int __PropertyOffset_ColorTweener;
	}
}
