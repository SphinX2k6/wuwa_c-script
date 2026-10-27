using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200170E RID: 5902
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.RectKuroBulletEmitterConfig")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class URectKuroBulletEmitterConfig : UKuroBulletEmitterConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060154CE RID: 87246 RVA: 0x001F4E6B File Offset: 0x001F306B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URectKuroBulletEmitterConfig._ClassPtr;
		}

		// Token: 0x060154CF RID: 87247 RVA: 0x001F4E78 File Offset: 0x001F3078
		public URectKuroBulletEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(URectKuroBulletEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060154D0 RID: 87248 RVA: 0x001F4EA0 File Offset: 0x001F30A0
		public URectKuroBulletEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URectKuroBulletEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x060154D1 RID: 87249 RVA: 0x001F4ED4 File Offset: 0x001F30D4
		// (set) Token: 0x060154D2 RID: 87250 RVA: 0x001F4F0D File Offset: 0x001F310D
		public FRectEmitterSettings RectSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRectEmitterSettings result;
				if ((result = this._RectSettings) == null)
				{
					result = (this._RectSettings = new FRectEmitterSettings(base.NativePtr + (IntPtr)URectKuroBulletEmitterConfig.__PropertyOffset_RectSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRectEmitterSettings.StaticStruct(), base.NativePtr + (IntPtr)URectKuroBulletEmitterConfig.__PropertyOffset_RectSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154D3 RID: 87251 RVA: 0x001F4F2E File Offset: 0x001F312E
		static URectKuroBulletEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.RectKuroBulletEmitterConfig");
		}

		// Token: 0x060154D4 RID: 87252 RVA: 0x001F4F3C File Offset: 0x001F313C
		protected URectKuroBulletEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9C2 RID: 47554
		public new const string __ObjectPath = "/Script/KuroBulletCore.RectKuroBulletEmitterConfig";

		// Token: 0x0400B9C3 RID: 47555
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9C4 RID: 47556
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9C5 RID: 47557
		internal static int __PropertyOffset_RectSettings;

		// Token: 0x0400B9C6 RID: 47558
		[Nullable(2)]
		private FRectEmitterSettings _RectSettings;
	}
}
