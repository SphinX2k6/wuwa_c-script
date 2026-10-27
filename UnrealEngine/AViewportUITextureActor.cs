using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E4 RID: 8676
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ViewportUITextureActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AViewportUITextureActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602116B RID: 135531 RVA: 0x0030CA20 File Offset: 0x0030AC20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AViewportUITextureActor._ClassPtr;
		}

		// Token: 0x0602116C RID: 135532 RVA: 0x0030CA2C File Offset: 0x0030AC2C
		public AViewportUITextureActor() : this(BuiltinUtils.AllocNativeUObject(AViewportUITextureActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602116D RID: 135533 RVA: 0x0030CA54 File Offset: 0x0030AC54
		[NullableContext(1)]
		public AViewportUITextureActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AViewportUITextureActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008129 RID: 33065
		// (get) Token: 0x0602116E RID: 135534 RVA: 0x0030CA87 File Offset: 0x0030AC87
		// (set) Token: 0x0602116F RID: 135535 RVA: 0x0030CA9B File Offset: 0x0030AC9B
		public unsafe UViewportUITexture UITextureComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UViewportUITexture>(base.NativePtr / (IntPtr)sizeof(void*) + AViewportUITextureActor.__PropertyOffset_UITextureComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AViewportUITextureActor.__PropertyOffset_UITextureComponent, value);
			}
		}

		// Token: 0x06021170 RID: 135536 RVA: 0x0030CAB0 File Offset: 0x0030ACB0
		public UViewportUITexture GetUITexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UViewportUITexture>(AViewportUITextureActor.__GetUITexture_Internal(base.NativePtr));
		}

		// Token: 0x06021171 RID: 135537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUITexture_Internal(IntPtr @this);

		// Token: 0x06021172 RID: 135538 RVA: 0x0030CAC2 File Offset: 0x0030ACC2
		static AViewportUITextureActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.ViewportUITextureActor");
		}

		// Token: 0x06021173 RID: 135539 RVA: 0x0030CAD0 File Offset: 0x0030ACD0
		protected AViewportUITextureActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A64 RID: 72292
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.ViewportUITextureActor";

		// Token: 0x04011A65 RID: 72293
		private static IntPtr _ClassPtr;

		// Token: 0x04011A66 RID: 72294
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A67 RID: 72295
		internal static int __PropertyOffset_UITextureComponent;
	}
}
