using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216C RID: 8556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTextureTransition")]
	[UnrealStructLayout(1000, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1000)]
	public class UUIExtendToggleTextureTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204C8 RID: 132296 RVA: 0x002FF7CF File Offset: 0x002FD9CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTextureTransition._ClassPtr;
		}

		// Token: 0x060204C9 RID: 132297 RVA: 0x002FF7DC File Offset: 0x002FD9DC
		public UUIExtendToggleTextureTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextureTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204CA RID: 132298 RVA: 0x002FF804 File Offset: 0x002FDA04
		public UUIExtendToggleTextureTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextureTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E9A RID: 32410
		// (get) Token: 0x060204CB RID: 132299 RVA: 0x002FF837 File Offset: 0x002FDA37
		// (set) Token: 0x060204CC RID: 132300 RVA: 0x002FF847 File Offset: 0x002FDA47
		public unsafe ETextureTransitionType TransitionType
		{
			get
			{
				return (ETextureTransitionType)(*(base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionType) = (byte)value;
			}
		}

		// Token: 0x17007E9B RID: 32411
		// (get) Token: 0x060204CD RID: 132301 RVA: 0x002FF858 File Offset: 0x002FDA58
		// (set) Token: 0x060204CE RID: 132302 RVA: 0x002FF891 File Offset: 0x002FDA91
		public FExtendToggleColorTransition TransitionColors
		{
			get
			{
				base.FastCheckIsValid();
				FExtendToggleColorTransition result;
				if ((result = this._TransitionColors) == null)
				{
					result = (this._TransitionColors = new FExtendToggleColorTransition(base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionColors, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExtendToggleColorTransition.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionColors, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E9C RID: 32412
		// (get) Token: 0x060204CF RID: 132303 RVA: 0x002FF8B4 File Offset: 0x002FDAB4
		// (set) Token: 0x060204D0 RID: 132304 RVA: 0x002FF8ED File Offset: 0x002FDAED
		public FExtendToggleTextureTransitionState TransitionState
		{
			get
			{
				base.FastCheckIsValid();
				FExtendToggleTextureTransitionState result;
				if ((result = this._TransitionState) == null)
				{
					result = (this._TransitionState = new FExtendToggleTextureTransitionState(base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExtendToggleTextureTransitionState.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleTextureTransition.__PropertyOffset_TransitionState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060204D1 RID: 132305 RVA: 0x002FF90E File Offset: 0x002FDB0E
		[NullableContext(2)]
		public void SetTargetStateTexture(EToggleTransitionState State, UTexture Texture, bool ForceNoTriggerOnChange = false)
		{
			UUIExtendToggleTextureTransition.__SetTargetStateTexture_Internal(base.NativePtr, State, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, ForceNoTriggerOnChange);
		}

		// Token: 0x060204D2 RID: 132306 RVA: 0x002FF92D File Offset: 0x002FDB2D
		[NullableContext(2)]
		public void SetAllTransitionStateTexture(UTexture Texture)
		{
			UUIExtendToggleTextureTransition.__SetAllTransitionStateTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060204D3 RID: 132307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetStateTexture_Internal(IntPtr @this, EToggleTransitionState State, IntPtr Texture, bool ForceNoTriggerOnChange);

		// Token: 0x060204D4 RID: 132308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionStateTexture_Internal(IntPtr @this, IntPtr Texture);

		// Token: 0x060204D5 RID: 132309 RVA: 0x002FF94A File Offset: 0x002FDB4A
		static UUIExtendToggleTextureTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTextureTransition");
		}

		// Token: 0x060204D6 RID: 132310 RVA: 0x002FF958 File Offset: 0x002FDB58
		protected UUIExtendToggleTextureTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115A7 RID: 71079
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTextureTransition";

		// Token: 0x040115A8 RID: 71080
		private static IntPtr _ClassPtr;

		// Token: 0x040115A9 RID: 71081
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115AA RID: 71082
		internal static int __PropertyOffset_TransitionType;

		// Token: 0x040115AB RID: 71083
		internal static int __PropertyOffset_TransitionColors;

		// Token: 0x040115AC RID: 71084
		[Nullable(2)]
		private FExtendToggleColorTransition _TransitionColors;

		// Token: 0x040115AD RID: 71085
		internal static int __PropertyOffset_TransitionState;

		// Token: 0x040115AE RID: 71086
		[Nullable(2)]
		private FExtendToggleTextureTransitionState _TransitionState;
	}
}
