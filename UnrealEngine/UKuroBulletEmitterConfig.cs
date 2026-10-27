using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016FA RID: 5882
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletEmitterConfig")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroBulletEmitterConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015406 RID: 87046 RVA: 0x001F3CDA File Offset: 0x001F1EDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x06015407 RID: 87047 RVA: 0x001F3CE8 File Offset: 0x001F1EE8
		public UKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015408 RID: 87048 RVA: 0x001F3D10 File Offset: 0x001F1F10
		public UKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x06015409 RID: 87049 RVA: 0x001F3D44 File Offset: 0x001F1F44
		// (set) Token: 0x0601540A RID: 87050 RVA: 0x001F3D7D File Offset: 0x001F1F7D
		public FEmitterCommonSettings CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterCommonSettings result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FEmitterCommonSettings(base.NativePtr + (IntPtr)UKuroBulletEmitterConfig.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterCommonSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroBulletEmitterConfig.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601540B RID: 87051 RVA: 0x001F3D9E File Offset: 0x001F1F9E
		static UKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletEmitterConfig");
		}

		// Token: 0x0601540C RID: 87052 RVA: 0x001F3DAC File Offset: 0x001F1FAC
		protected UKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B968 RID: 47464
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletEmitterConfig";

		// Token: 0x0400B969 RID: 47465
		private static IntPtr _ClassPtr;

		// Token: 0x0400B96A RID: 47466
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B96B RID: 47467
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x0400B96C RID: 47468
		[Nullable(2)]
		private FEmitterCommonSettings _CommonSettings;
	}
}
