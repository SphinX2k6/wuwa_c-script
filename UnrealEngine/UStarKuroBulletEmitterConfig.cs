using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001714 RID: 5908
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.StarKuroBulletEmitterConfig")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UStarKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601550C RID: 87308 RVA: 0x001F5403 File Offset: 0x001F3603
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStarKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x0601550D RID: 87309 RVA: 0x001F5410 File Offset: 0x001F3610
		public UStarKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UStarKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601550E RID: 87310 RVA: 0x001F5438 File Offset: 0x001F3638
		public UStarKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStarKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x0601550F RID: 87311 RVA: 0x001F546C File Offset: 0x001F366C
		// (set) Token: 0x06015510 RID: 87312 RVA: 0x001F54A5 File Offset: 0x001F36A5
		public FStarEmitterSettings StarSettings
		{
			get
			{
				base.FastCheckIsValid();
				FStarEmitterSettings result;
				if ((result = this._StarSettings) == null)
				{
					result = (this._StarSettings = new FStarEmitterSettings(base.NativePtr + (IntPtr)UStarKuroBulletEmitterConfig.__PropertyOffset_StarSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStarEmitterSettings.StaticStruct(), base.NativePtr + (IntPtr)UStarKuroBulletEmitterConfig.__PropertyOffset_StarSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06015511 RID: 87313 RVA: 0x001F54C6 File Offset: 0x001F36C6
		static UStarKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.StarKuroBulletEmitterConfig");
		}

		// Token: 0x06015512 RID: 87314 RVA: 0x001F54D4 File Offset: 0x001F36D4
		protected UStarKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9E2 RID: 47586
		public new const string __ObjectPath = "/Script/KuroBulletCore.StarKuroBulletEmitterConfig";

		// Token: 0x0400B9E3 RID: 47587
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9E4 RID: 47588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9E5 RID: 47589
		internal static int __PropertyOffset_StarSettings;

		// Token: 0x0400B9E6 RID: 47590
		[Nullable(2)]
		private FStarEmitterSettings _StarSettings;
	}
}
