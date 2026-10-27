using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001711 RID: 5905
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.SphereKuroBulletEmitterConfig")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class USphereKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154EC RID: 87276 RVA: 0x001F5107 File Offset: 0x001F3307
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USphereKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x060154ED RID: 87277 RVA: 0x001F5114 File Offset: 0x001F3314
		public USphereKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(USphereKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154EE RID: 87278 RVA: 0x001F513C File Offset: 0x001F333C
		public USphereKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USphereKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x060154EF RID: 87279 RVA: 0x001F5170 File Offset: 0x001F3370
		// (set) Token: 0x060154F0 RID: 87280 RVA: 0x001F51A9 File Offset: 0x001F33A9
		public FSphereEmitterSettings SphereSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSphereEmitterSettings result;
				if ((result = this._SphereSettings) == null)
				{
					result = (this._SphereSettings = new FSphereEmitterSettings(base.NativePtr + (IntPtr)USphereKuroBulletEmitterConfig.__PropertyOffset_SphereSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSphereEmitterSettings.StaticStruct(), base.NativePtr + (IntPtr)USphereKuroBulletEmitterConfig.__PropertyOffset_SphereSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154F1 RID: 87281 RVA: 0x001F51CA File Offset: 0x001F33CA
		static USphereKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.SphereKuroBulletEmitterConfig");
		}

		// Token: 0x060154F2 RID: 87282 RVA: 0x001F51D8 File Offset: 0x001F33D8
		protected USphereKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9D1 RID: 47569
		public new const string __ObjectPath = "/Script/KuroBulletCore.SphereKuroBulletEmitterConfig";

		// Token: 0x0400B9D2 RID: 47570
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9D3 RID: 47571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9D4 RID: 47572
		internal static int __PropertyOffset_SphereSettings;

		// Token: 0x0400B9D5 RID: 47573
		[Nullable(2)]
		private FSphereEmitterSettings _SphereSettings;
	}
}
