using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CE RID: 5838
	[UnrealObjectPath("/Script/KuroBulletCore.CircleKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UCircleKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015273 RID: 86643 RVA: 0x001F17D9 File Offset: 0x001EF9D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCircleKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x06015274 RID: 86644 RVA: 0x001F17E8 File Offset: 0x001EF9E8
		public UCircleKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(UCircleKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015275 RID: 86645 RVA: 0x001F1810 File Offset: 0x001EFA10
		[NullableContext(1)]
		public UCircleKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCircleKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700539C RID: 21404
		// (get) Token: 0x06015276 RID: 86646 RVA: 0x001F1843 File Offset: 0x001EFA43
		// (set) Token: 0x06015277 RID: 86647 RVA: 0x001F1857 File Offset: 0x001EFA57
		[Nullable(2)]
		public unsafe UCircleKuroBulletEmitterConfig CircleConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCircleKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UCircleKuroBulletEmitter.__PropertyOffset_CircleConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCircleKuroBulletEmitter.__PropertyOffset_CircleConfig, value);
			}
		}

		// Token: 0x06015278 RID: 86648 RVA: 0x001F186C File Offset: 0x001EFA6C
		static UCircleKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.CircleKuroBulletEmitter");
		}

		// Token: 0x06015279 RID: 86649 RVA: 0x001F187A File Offset: 0x001EFA7A
		protected UCircleKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B81D RID: 47133
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.CircleKuroBulletEmitter";

		// Token: 0x0400B81E RID: 47134
		private static IntPtr _ClassPtr;

		// Token: 0x0400B81F RID: 47135
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B820 RID: 47136
		internal static int __PropertyOffset_CircleConfig;
	}
}
