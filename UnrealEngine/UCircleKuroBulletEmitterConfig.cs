using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CF RID: 5839
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.CircleKuroBulletEmitterConfig")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UCircleKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601527A RID: 86650 RVA: 0x001F1883 File Offset: 0x001EFA83
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCircleKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x0601527B RID: 86651 RVA: 0x001F1890 File Offset: 0x001EFA90
		public UCircleKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UCircleKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601527C RID: 86652 RVA: 0x001F18B8 File Offset: 0x001EFAB8
		public UCircleKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCircleKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x0601527D RID: 86653 RVA: 0x001F18EC File Offset: 0x001EFAEC
		// (set) Token: 0x0601527E RID: 86654 RVA: 0x001F1925 File Offset: 0x001EFB25
		public FCircleEmitterSettings CircleSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCircleEmitterSettings result;
				if ((result = this._CircleSettings) == null)
				{
					result = (this._CircleSettings = new FCircleEmitterSettings(base.NativePtr + (IntPtr)UCircleKuroBulletEmitterConfig.__PropertyOffset_CircleSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCircleEmitterSettings.StaticStruct(), base.NativePtr + (IntPtr)UCircleKuroBulletEmitterConfig.__PropertyOffset_CircleSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601527F RID: 86655 RVA: 0x001F1946 File Offset: 0x001EFB46
		static UCircleKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.CircleKuroBulletEmitterConfig");
		}

		// Token: 0x06015280 RID: 86656 RVA: 0x001F1954 File Offset: 0x001EFB54
		protected UCircleKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B821 RID: 47137
		public new const string __ObjectPath = "/Script/KuroBulletCore.CircleKuroBulletEmitterConfig";

		// Token: 0x0400B822 RID: 47138
		private static IntPtr _ClassPtr;

		// Token: 0x0400B823 RID: 47139
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B824 RID: 47140
		internal static int __PropertyOffset_CircleSettings;

		// Token: 0x0400B825 RID: 47141
		[Nullable(2)]
		private FCircleEmitterSettings _CircleSettings;
	}
}
