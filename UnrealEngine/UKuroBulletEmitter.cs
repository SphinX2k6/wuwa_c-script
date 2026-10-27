using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F9 RID: 5881
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletEmitter")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UKuroBulletEmitter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060153FB RID: 87035 RVA: 0x001F3BBD File Offset: 0x001F1DBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x060153FC RID: 87036 RVA: 0x001F3BCC File Offset: 0x001F1DCC
		public UKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060153FD RID: 87037 RVA: 0x001F3BF4 File Offset: 0x001F1DF4
		[NullableContext(1)]
		public UKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x060153FE RID: 87038 RVA: 0x001F3C27 File Offset: 0x001F1E27
		// (set) Token: 0x060153FF RID: 87039 RVA: 0x001F3C3B File Offset: 0x001F1E3B
		public unsafe UKuroBulletPattern OwnerPattern
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletPattern>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletEmitter.__PropertyOffset_OwnerPattern);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletEmitter.__PropertyOffset_OwnerPattern, value);
			}
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x06015400 RID: 87040 RVA: 0x001F3C50 File Offset: 0x001F1E50
		// (set) Token: 0x06015401 RID: 87041 RVA: 0x001F3C64 File Offset: 0x001F1E64
		public unsafe UKuroBulletEmitterConfig EmitterConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletEmitter.__PropertyOffset_EmitterConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletEmitter.__PropertyOffset_EmitterConfig, value);
			}
		}

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x06015402 RID: 87042 RVA: 0x001F3C7C File Offset: 0x001F1E7C
		// (set) Token: 0x06015403 RID: 87043 RVA: 0x001F3CB5 File Offset: 0x001F1EB5
		[Nullable(1)]
		public TArray<int> SpawnedBulletIds
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SpawnedBulletIds) == null)
				{
					result = (this._SpawnedBulletIds = new TArray<int>(base.NativePtr + (IntPtr)UKuroBulletEmitter.__PropertyOffset_SpawnedBulletIds, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SpawnedBulletIds.CopyAssign(value);
			}
		}

		// Token: 0x06015404 RID: 87044 RVA: 0x001F3CC3 File Offset: 0x001F1EC3
		static UKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletEmitter");
		}

		// Token: 0x06015405 RID: 87045 RVA: 0x001F3CD1 File Offset: 0x001F1ED1
		protected UKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B961 RID: 47457
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletEmitter";

		// Token: 0x0400B962 RID: 47458
		private static IntPtr _ClassPtr;

		// Token: 0x0400B963 RID: 47459
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B964 RID: 47460
		internal static int __PropertyOffset_OwnerPattern;

		// Token: 0x0400B965 RID: 47461
		internal static int __PropertyOffset_EmitterConfig;

		// Token: 0x0400B966 RID: 47462
		internal static int __PropertyOffset_SpawnedBulletIds;

		// Token: 0x0400B967 RID: 47463
		private TArray<int> _SpawnedBulletIds;
	}
}
