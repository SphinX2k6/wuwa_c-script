using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001710 RID: 5904
	[UnrealObjectPath("/Script/KuroBulletCore.SphereKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class USphereKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154E5 RID: 87269 RVA: 0x001F505E File Offset: 0x001F325E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USphereKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x060154E6 RID: 87270 RVA: 0x001F506C File Offset: 0x001F326C
		public USphereKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(USphereKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154E7 RID: 87271 RVA: 0x001F5094 File Offset: 0x001F3294
		[NullableContext(1)]
		public USphereKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USphereKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x060154E8 RID: 87272 RVA: 0x001F50C7 File Offset: 0x001F32C7
		// (set) Token: 0x060154E9 RID: 87273 RVA: 0x001F50DB File Offset: 0x001F32DB
		[Nullable(2)]
		public unsafe USphereKuroBulletEmitterConfig SphereConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + USphereKuroBulletEmitter.__PropertyOffset_SphereConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USphereKuroBulletEmitter.__PropertyOffset_SphereConfig, value);
			}
		}

		// Token: 0x060154EA RID: 87274 RVA: 0x001F50F0 File Offset: 0x001F32F0
		static USphereKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.SphereKuroBulletEmitter");
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x001F50FE File Offset: 0x001F32FE
		protected USphereKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9CD RID: 47565
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.SphereKuroBulletEmitter";

		// Token: 0x0400B9CE RID: 47566
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9CF RID: 47567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9D0 RID: 47568
		internal static int __PropertyOffset_SphereConfig;
	}
}
