using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216B RID: 8555
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTextTransition")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 744)]
	public class UUIExtendToggleTextTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204BD RID: 132285 RVA: 0x002FF6A2 File Offset: 0x002FD8A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTextTransition._ClassPtr;
		}

		// Token: 0x060204BE RID: 132286 RVA: 0x002FF6B0 File Offset: 0x002FD8B0
		public UUIExtendToggleTextTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204BF RID: 132287 RVA: 0x002FF6D8 File Offset: 0x002FD8D8
		[NullableContext(1)]
		public UUIExtendToggleTextTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E97 RID: 32407
		// (get) Token: 0x060204C0 RID: 132288 RVA: 0x002FF70C File Offset: 0x002FD90C
		// (set) Token: 0x060204C1 RID: 132289 RVA: 0x002FF745 File Offset: 0x002FD945
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

		// Token: 0x17007E98 RID: 32408
		// (get) Token: 0x060204C2 RID: 132290 RVA: 0x002FF766 File Offset: 0x002FD966
		// (set) Token: 0x060204C3 RID: 132291 RVA: 0x002FF77A File Offset: 0x002FD97A
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

		// Token: 0x17007E99 RID: 32409
		// (get) Token: 0x060204C4 RID: 132292 RVA: 0x002FF78F File Offset: 0x002FD98F
		// (set) Token: 0x060204C5 RID: 132293 RVA: 0x002FF7A3 File Offset: 0x002FD9A3
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

		// Token: 0x060204C6 RID: 132294 RVA: 0x002FF7B8 File Offset: 0x002FD9B8
		static UUIExtendToggleTextTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTextTransition");
		}

		// Token: 0x060204C7 RID: 132295 RVA: 0x002FF7C6 File Offset: 0x002FD9C6
		protected UUIExtendToggleTextTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115A0 RID: 71072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTextTransition";

		// Token: 0x040115A1 RID: 71073
		private static IntPtr _ClassPtr;

		// Token: 0x040115A2 RID: 71074
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115A3 RID: 71075
		internal static int __PropertyOffset_TransitionState;

		// Token: 0x040115A4 RID: 71076
		private FExtendToggleTextTransitionState _TransitionState;

		// Token: 0x040115A5 RID: 71077
		internal static int __PropertyOffset_ColorTweener;

		// Token: 0x040115A6 RID: 71078
		internal static int __PropertyOffset_OutlineColorTweener;
	}
}
