using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200170A RID: 5898
	[UnrealObjectPath("/Script/KuroBulletCore.PolygonKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UPolygonKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154AB RID: 87211 RVA: 0x001F4B09 File Offset: 0x001F2D09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPolygonKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x060154AC RID: 87212 RVA: 0x001F4B18 File Offset: 0x001F2D18
		public UPolygonKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(UPolygonKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154AD RID: 87213 RVA: 0x001F4B40 File Offset: 0x001F2D40
		[NullableContext(1)]
		public UPolygonKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPolygonKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x060154AE RID: 87214 RVA: 0x001F4B73 File Offset: 0x001F2D73
		// (set) Token: 0x060154AF RID: 87215 RVA: 0x001F4B87 File Offset: 0x001F2D87
		[Nullable(2)]
		public unsafe UPolygonKuroBulletEmitterConfig PolygonConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPolygonKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UPolygonKuroBulletEmitter.__PropertyOffset_PolygonConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPolygonKuroBulletEmitter.__PropertyOffset_PolygonConfig, value);
			}
		}

		// Token: 0x060154B0 RID: 87216 RVA: 0x001F4B9C File Offset: 0x001F2D9C
		static UPolygonKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.PolygonKuroBulletEmitter");
		}

		// Token: 0x060154B1 RID: 87217 RVA: 0x001F4BAA File Offset: 0x001F2DAA
		protected UPolygonKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9AF RID: 47535
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.PolygonKuroBulletEmitter";

		// Token: 0x0400B9B0 RID: 47536
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9B1 RID: 47537
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9B2 RID: 47538
		internal static int __PropertyOffset_PolygonConfig;
	}
}
