using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200170B RID: 5899
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.PolygonKuroBulletEmitterConfig")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UPolygonKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154B2 RID: 87218 RVA: 0x001F4BB3 File Offset: 0x001F2DB3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPolygonKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x060154B3 RID: 87219 RVA: 0x001F4BC0 File Offset: 0x001F2DC0
		public UPolygonKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UPolygonKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x001F4BE8 File Offset: 0x001F2DE8
		public UPolygonKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPolygonKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x060154B5 RID: 87221 RVA: 0x001F4C1C File Offset: 0x001F2E1C
		// (set) Token: 0x060154B6 RID: 87222 RVA: 0x001F4C55 File Offset: 0x001F2E55
		public FPolygonEmitterSettings PolygonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FPolygonEmitterSettings result;
				if ((result = this._PolygonSettings) == null)
				{
					result = (this._PolygonSettings = new FPolygonEmitterSettings(base.NativePtr + (IntPtr)UPolygonKuroBulletEmitterConfig.__PropertyOffset_PolygonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPolygonEmitterSettings.StaticStruct(), base.NativePtr + (IntPtr)UPolygonKuroBulletEmitterConfig.__PropertyOffset_PolygonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154B7 RID: 87223 RVA: 0x001F4C76 File Offset: 0x001F2E76
		static UPolygonKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.PolygonKuroBulletEmitterConfig");
		}

		// Token: 0x060154B8 RID: 87224 RVA: 0x001F4C84 File Offset: 0x001F2E84
		protected UPolygonKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9B3 RID: 47539
		public new const string __ObjectPath = "/Script/KuroBulletCore.PolygonKuroBulletEmitterConfig";

		// Token: 0x0400B9B4 RID: 47540
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9B5 RID: 47541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9B6 RID: 47542
		internal static int __PropertyOffset_PolygonSettings;

		// Token: 0x0400B9B7 RID: 47543
		[Nullable(2)]
		private FPolygonEmitterSettings _PolygonSettings;
	}
}
