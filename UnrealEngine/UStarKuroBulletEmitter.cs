using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001713 RID: 5907
	[UnrealObjectPath("/Script/KuroBulletCore.StarKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UStarKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015505 RID: 87301 RVA: 0x001F5359 File Offset: 0x001F3559
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStarKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x06015506 RID: 87302 RVA: 0x001F5368 File Offset: 0x001F3568
		public UStarKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(UStarKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015507 RID: 87303 RVA: 0x001F5390 File Offset: 0x001F3590
		[NullableContext(1)]
		public UStarKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStarKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x06015508 RID: 87304 RVA: 0x001F53C3 File Offset: 0x001F35C3
		// (set) Token: 0x06015509 RID: 87305 RVA: 0x001F53D7 File Offset: 0x001F35D7
		[Nullable(2)]
		public unsafe UStarKuroBulletEmitterConfig StarConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStarKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UStarKuroBulletEmitter.__PropertyOffset_StarConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStarKuroBulletEmitter.__PropertyOffset_StarConfig, value);
			}
		}

		// Token: 0x0601550A RID: 87306 RVA: 0x001F53EC File Offset: 0x001F35EC
		static UStarKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.StarKuroBulletEmitter");
		}

		// Token: 0x0601550B RID: 87307 RVA: 0x001F53FA File Offset: 0x001F35FA
		protected UStarKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9DE RID: 47582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.StarKuroBulletEmitter";

		// Token: 0x0400B9DF RID: 47583
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9E0 RID: 47584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9E1 RID: 47585
		internal static int __PropertyOffset_StarConfig;
	}
}
