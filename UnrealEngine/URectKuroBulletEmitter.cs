using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200170D RID: 5901
	[UnrealObjectPath("/Script/KuroBulletCore.RectKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class URectKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154C7 RID: 87239 RVA: 0x001F4DC1 File Offset: 0x001F2FC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URectKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x060154C8 RID: 87240 RVA: 0x001F4DD0 File Offset: 0x001F2FD0
		public URectKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(URectKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154C9 RID: 87241 RVA: 0x001F4DF8 File Offset: 0x001F2FF8
		[NullableContext(1)]
		public URectKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URectKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x060154CA RID: 87242 RVA: 0x001F4E2B File Offset: 0x001F302B
		// (set) Token: 0x060154CB RID: 87243 RVA: 0x001F4E3F File Offset: 0x001F303F
		[Nullable(2)]
		public unsafe URectKuroBulletEmitterConfig RectConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URectKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + URectKuroBulletEmitter.__PropertyOffset_RectConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URectKuroBulletEmitter.__PropertyOffset_RectConfig, value);
			}
		}

		// Token: 0x060154CC RID: 87244 RVA: 0x001F4E54 File Offset: 0x001F3054
		static URectKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.RectKuroBulletEmitter");
		}

		// Token: 0x060154CD RID: 87245 RVA: 0x001F4E62 File Offset: 0x001F3062
		protected URectKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9BE RID: 47550
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.RectKuroBulletEmitter";

		// Token: 0x0400B9BF RID: 47551
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9C0 RID: 47552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9C1 RID: 47553
		internal static int __PropertyOffset_RectConfig;
	}
}
