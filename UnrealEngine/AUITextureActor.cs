using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D4 RID: 8660
	[UnrealObjectPath("/Script/LGUI.UITextureActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUITextureActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602101A RID: 135194 RVA: 0x0030B26F File Offset: 0x0030946F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUITextureActor._ClassPtr;
		}

		// Token: 0x0602101B RID: 135195 RVA: 0x0030B27C File Offset: 0x0030947C
		public AUITextureActor() : this(BuiltinUtils.AllocNativeUObject(AUITextureActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602101C RID: 135196 RVA: 0x0030B2A4 File Offset: 0x003094A4
		[NullableContext(1)]
		public AUITextureActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUITextureActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080DC RID: 32988
		// (get) Token: 0x0602101D RID: 135197 RVA: 0x0030B2D7 File Offset: 0x003094D7
		// (set) Token: 0x0602101E RID: 135198 RVA: 0x0030B2EB File Offset: 0x003094EB
		[Nullable(2)]
		public unsafe UUITexture UITexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITexture>(base.NativePtr / (IntPtr)sizeof(void*) + AUITextureActor.__PropertyOffset_UITexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUITextureActor.__PropertyOffset_UITexture, value);
			}
		}

		// Token: 0x0602101F RID: 135199 RVA: 0x0030B300 File Offset: 0x00309500
		static AUITextureActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureActor");
		}

		// Token: 0x06021020 RID: 135200 RVA: 0x0030B30E File Offset: 0x0030950E
		protected AUITextureActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119D6 RID: 72150
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureActor";

		// Token: 0x040119D7 RID: 72151
		private static IntPtr _ClassPtr;

		// Token: 0x040119D8 RID: 72152
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119D9 RID: 72153
		internal static int __PropertyOffset_UITexture;
	}
}
