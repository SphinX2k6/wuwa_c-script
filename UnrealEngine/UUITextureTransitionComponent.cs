using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D9 RID: 8665
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextureTransitionComponent")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UUITextureTransitionComponent : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021055 RID: 135253 RVA: 0x0030B6BB File Offset: 0x003098BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureTransitionComponent._ClassPtr;
		}

		// Token: 0x06021056 RID: 135254 RVA: 0x0030B6C8 File Offset: 0x003098C8
		public UUITextureTransitionComponent() : this(BuiltinUtils.AllocNativeUObject(UUITextureTransitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021057 RID: 135255 RVA: 0x0030B6F0 File Offset: 0x003098F0
		public UUITextureTransitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextureTransitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080E4 RID: 32996
		// (get) Token: 0x06021058 RID: 135256 RVA: 0x0030B724 File Offset: 0x00309924
		// (set) Token: 0x06021059 RID: 135257 RVA: 0x0030B75D File Offset: 0x0030995D
		public FTextureTransitionInfo Transition
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionInfo result;
				if ((result = this._Transition) == null)
				{
					result = (this._Transition = new FTextureTransitionInfo(base.NativePtr + (IntPtr)UUITextureTransitionComponent.__PropertyOffset_Transition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUITextureTransitionComponent.__PropertyOffset_Transition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602105A RID: 135258 RVA: 0x0030B77E File Offset: 0x0030997E
		[NullableContext(2)]
		public void SetStateTexture(EUISelectableSelectionState State, UTexture NewTexture)
		{
			UUITextureTransitionComponent.__SetStateTexture_Internal(base.NativePtr, State, (NewTexture != null) ? NewTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602105B RID: 135259 RVA: 0x0030B79C File Offset: 0x0030999C
		[NullableContext(2)]
		public void SetAllStateTexture(UTexture NewTexture)
		{
			UUITextureTransitionComponent.__SetAllStateTexture_Internal(base.NativePtr, (NewTexture != null) ? NewTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602105C RID: 135260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateTexture_Internal(IntPtr @this, EUISelectableSelectionState State, IntPtr NewTexture);

		// Token: 0x0602105D RID: 135261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllStateTexture_Internal(IntPtr @this, IntPtr NewTexture);

		// Token: 0x0602105E RID: 135262 RVA: 0x0030B7B9 File Offset: 0x003099B9
		static UUITextureTransitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureTransitionComponent");
		}

		// Token: 0x0602105F RID: 135263 RVA: 0x0030B7C7 File Offset: 0x003099C7
		protected UUITextureTransitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119ED RID: 72173
		public new const string __ObjectPath = "/Script/LGUI.UITextureTransitionComponent";

		// Token: 0x040119EE RID: 72174
		private static IntPtr _ClassPtr;

		// Token: 0x040119EF RID: 72175
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119F0 RID: 72176
		internal static int __PropertyOffset_Transition;

		// Token: 0x040119F1 RID: 72177
		[Nullable(2)]
		private FTextureTransitionInfo _Transition;
	}
}
