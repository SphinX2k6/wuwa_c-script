using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000704 RID: 1796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTextureTransition")]
	[UnrealStructLayout(1000, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1000)]
	public class UUIExtendToggleTextureTransition : UUIExtendToggleTransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060098FA RID: 39162 RVA: 0x000E66FB File Offset: 0x000E48FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTextureTransition._ClassPtr;
		}

		// Token: 0x060098FB RID: 39163 RVA: 0x000E6708 File Offset: 0x000E4908
		public UUIExtendToggleTextureTransition() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextureTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x000E6730 File Offset: 0x000E4930
		public UUIExtendToggleTextureTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTextureTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x060098FD RID: 39165 RVA: 0x000E6764 File Offset: 0x000E4964
		// (set) Token: 0x060098FE RID: 39166 RVA: 0x000E679D File Offset: 0x000E499D
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

		// Token: 0x060098FF RID: 39167 RVA: 0x000E67BE File Offset: 0x000E49BE
		[NullableContext(2)]
		public void SetTargetStateTexture(EToggleTransitionState State, UTexture Texture, bool ForceNoTriggerOnChange = false)
		{
			UUIExtendToggleTextureTransition.__SetTargetStateTexture_Internal(base.NativePtr, State, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, ForceNoTriggerOnChange);
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x000E67DD File Offset: 0x000E49DD
		[NullableContext(2)]
		public void SetAllTransitionStateTexture(UTexture Texture)
		{
			UUIExtendToggleTextureTransition.__SetAllTransitionStateTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009901 RID: 39169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetStateTexture_Internal(IntPtr @this, EToggleTransitionState State, IntPtr Texture, bool ForceNoTriggerOnChange);

		// Token: 0x06009902 RID: 39170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionStateTexture_Internal(IntPtr @this, IntPtr Texture);

		// Token: 0x06009903 RID: 39171 RVA: 0x000E67FA File Offset: 0x000E49FA
		static UUIExtendToggleTextureTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTextureTransition");
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x000E6808 File Offset: 0x000E4A08
		protected UUIExtendToggleTextureTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004283 RID: 17027
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTextureTransition";

		// Token: 0x04004284 RID: 17028
		private static IntPtr _ClassPtr;

		// Token: 0x04004285 RID: 17029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004286 RID: 17030
		internal static int __PropertyOffset_TransitionColors;

		// Token: 0x04004287 RID: 17031
		[Nullable(2)]
		private FExtendToggleColorTransition _TransitionColors;
	}
}
