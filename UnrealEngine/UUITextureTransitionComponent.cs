using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000737 RID: 1847
	[UnrealObjectPath("/Script/LGUI.UITextureTransitionComponent")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UUITextureTransitionComponent : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A108 RID: 41224 RVA: 0x000EE38D File Offset: 0x000EC58D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureTransitionComponent._ClassPtr;
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x000EE39C File Offset: 0x000EC59C
		public UUITextureTransitionComponent() : this(BuiltinUtils.AllocNativeUObject(UUITextureTransitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A10A RID: 41226 RVA: 0x000EE3C4 File Offset: 0x000EC5C4
		[NullableContext(1)]
		public UUITextureTransitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextureTransitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x000EE3F7 File Offset: 0x000EC5F7
		[NullableContext(2)]
		public void SetStateTexture(EUISelectableSelectionState State, UTexture NewTexture)
		{
			UUITextureTransitionComponent.__SetStateTexture_Internal(base.NativePtr, State, (NewTexture != null) ? NewTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x000EE415 File Offset: 0x000EC615
		[NullableContext(2)]
		public void SetAllStateTexture(UTexture NewTexture)
		{
			UUITextureTransitionComponent.__SetAllStateTexture_Internal(base.NativePtr, (NewTexture != null) ? NewTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A10D RID: 41229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateTexture_Internal(IntPtr @this, EUISelectableSelectionState State, IntPtr NewTexture);

		// Token: 0x0600A10E RID: 41230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllStateTexture_Internal(IntPtr @this, IntPtr NewTexture);

		// Token: 0x0600A10F RID: 41231 RVA: 0x000EE432 File Offset: 0x000EC632
		static UUITextureTransitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureTransitionComponent");
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x000EE440 File Offset: 0x000EC640
		protected UUITextureTransitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044F7 RID: 17655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureTransitionComponent";

		// Token: 0x040044F8 RID: 17656
		private static IntPtr _ClassPtr;

		// Token: 0x040044F9 RID: 17657
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
