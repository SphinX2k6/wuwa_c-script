using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000735 RID: 1845
	[UnrealObjectPath("/Script/LGUI.UITextureActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUITextureActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0F3 RID: 41203 RVA: 0x000EE1F5 File Offset: 0x000EC3F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUITextureActor._ClassPtr;
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x000EE204 File Offset: 0x000EC404
		public AUITextureActor() : this(BuiltinUtils.AllocNativeUObject(AUITextureActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x000EE22C File Offset: 0x000EC42C
		[NullableContext(1)]
		public AUITextureActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUITextureActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600A0F6 RID: 41206 RVA: 0x000EE25F File Offset: 0x000EC45F
		// (set) Token: 0x0600A0F7 RID: 41207 RVA: 0x000EE273 File Offset: 0x000EC473
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

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x000EE288 File Offset: 0x000EC488
		static AUITextureActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureActor");
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x000EE296 File Offset: 0x000EC496
		protected AUITextureActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044EF RID: 17647
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureActor";

		// Token: 0x040044F0 RID: 17648
		private static IntPtr _ClassPtr;

		// Token: 0x040044F1 RID: 17649
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044F2 RID: 17650
		internal static int __PropertyOffset_UITexture;
	}
}
