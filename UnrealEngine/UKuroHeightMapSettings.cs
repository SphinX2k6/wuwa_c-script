using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B22 RID: 6946
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroHeightMapSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A2B3 RID: 107187 RVA: 0x0026A59C File Offset: 0x0026879C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHeightMapSettings._ClassPtr;
		}

		// Token: 0x0601A2B4 RID: 107188 RVA: 0x0026A5A8 File Offset: 0x002687A8
		public UKuroHeightMapSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroHeightMapSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A2B5 RID: 107189 RVA: 0x0026A5D0 File Offset: 0x002687D0
		[NullableContext(1)]
		public UKuroHeightMapSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHeightMapSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006933 RID: 26931
		// (get) Token: 0x0601A2B6 RID: 107190 RVA: 0x0026A603 File Offset: 0x00268803
		// (set) Token: 0x0601A2B7 RID: 107191 RVA: 0x0026A617 File Offset: 0x00268817
		[Nullable(2)]
		public unsafe UKuroSplitTextureStreamerSettings StreamerSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSplitTextureStreamerSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroHeightMapSettings.__PropertyOffset_StreamerSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroHeightMapSettings.__PropertyOffset_StreamerSettings, value);
			}
		}

		// Token: 0x17006934 RID: 26932
		// (get) Token: 0x0601A2B8 RID: 107192 RVA: 0x0026A62C File Offset: 0x0026882C
		// (set) Token: 0x0601A2B9 RID: 107193 RVA: 0x0026A63C File Offset: 0x0026883C
		public unsafe float ShotHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHeightMapSettings.__PropertyOffset_ShotHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHeightMapSettings.__PropertyOffset_ShotHeight) = value;
			}
		}

		// Token: 0x0601A2BA RID: 107194 RVA: 0x0026A64D File Offset: 0x0026884D
		static UKuroHeightMapSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapSettings");
		}

		// Token: 0x0601A2BB RID: 107195 RVA: 0x0026A65B File Offset: 0x0026885B
		protected UKuroHeightMapSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E37D RID: 58237
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapSettings";

		// Token: 0x0400E37E RID: 58238
		private static IntPtr _ClassPtr;

		// Token: 0x0400E37F RID: 58239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E380 RID: 58240
		internal static int __PropertyOffset_StreamerSettings;

		// Token: 0x0400E381 RID: 58241
		internal static int __PropertyOffset_ShotHeight;
	}
}
