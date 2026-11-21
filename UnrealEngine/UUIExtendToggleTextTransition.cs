using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000703 RID: 1795
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTextTransition")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 744)]
	public class UUIExtendToggleTextTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060098EF RID: 39151 RVA: 0x000E65CE File Offset: 0x000E47CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTextTransition._ClassPtr;
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x000E65DC File Offset: 0x000E47DC
		public UUIExtendToggleTextTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x000E6604 File Offset: 0x000E4804
		[NullableContext(1)]
		public UUIExtendToggleTextTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x000E6638 File Offset: 0x000E4838
		// (set) Token: 0x060098F3 RID: 39155 RVA: 0x000E6671 File Offset: 0x000E4871
		[Nullable(1)]
		public FExtendToggleTextTransitionState TransitionState
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExtendToggleTextTransitionState result;
				if ((result = this._TransitionState) == null)
				{
					result = (this._TransitionState = new FExtendToggleTextTransitionState(base.NativePtr + (IntPtr)UUIExtendToggleTextTransition.__PropertyOffset_TransitionState, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExtendToggleTextTransitionState.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleTextTransition.__PropertyOffset_TransitionState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x060098F4 RID: 39156 RVA: 0x000E6692 File Offset: 0x000E4892
		// (set) Token: 0x060098F5 RID: 39157 RVA: 0x000E66A6 File Offset: 0x000E48A6
		public unsafe ULTweener ColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleTextTransition.__PropertyOffset_ColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleTextTransition.__PropertyOffset_ColorTweener, value);
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x060098F6 RID: 39158 RVA: 0x000E66BB File Offset: 0x000E48BB
		// (set) Token: 0x060098F7 RID: 39159 RVA: 0x000E66CF File Offset: 0x000E48CF
		public unsafe ULTweener OutlineColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleTextTransition.__PropertyOffset_OutlineColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIExtendToggleTextTransition.__PropertyOffset_OutlineColorTweener, value);
			}
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x000E66E4 File Offset: 0x000E48E4
		static UUIExtendToggleTextTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTextTransition");
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x000E66F2 File Offset: 0x000E48F2
		protected UUIExtendToggleTextTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400427C RID: 17020
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTextTransition";

		// Token: 0x0400427D RID: 17021
		private static IntPtr _ClassPtr;

		// Token: 0x0400427E RID: 17022
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400427F RID: 17023
		internal static int __PropertyOffset_TransitionState;

		// Token: 0x04004280 RID: 17024
		private FExtendToggleTextTransitionState _TransitionState;

		// Token: 0x04004281 RID: 17025
		internal static int __PropertyOffset_ColorTweener;

		// Token: 0x04004282 RID: 17026
		internal static int __PropertyOffset_OutlineColorTweener;
	}
}
