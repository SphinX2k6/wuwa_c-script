using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE0 RID: 7136
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroVolumetricQualitySettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroVolumetricQualitySettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B653 RID: 112211 RVA: 0x00285E15 File Offset: 0x00284015
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVolumetricQualitySettings._ClassPtr;
		}

		// Token: 0x0601B654 RID: 112212 RVA: 0x00285E24 File Offset: 0x00284024
		public UKuroVolumetricQualitySettings() : this(BuiltinUtils.AllocNativeUObject(UKuroVolumetricQualitySettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B655 RID: 112213 RVA: 0x00285E4C File Offset: 0x0028404C
		public UKuroVolumetricQualitySettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVolumetricQualitySettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E12 RID: 28178
		// (get) Token: 0x0601B656 RID: 112214 RVA: 0x00285E80 File Offset: 0x00284080
		// (set) Token: 0x0601B657 RID: 112215 RVA: 0x00285EB9 File Offset: 0x002840B9
		public TArray<string> VolumetricQuality
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._VolumetricQuality) == null)
				{
					result = (this._VolumetricQuality = new TArray<string>(base.NativePtr + (IntPtr)UKuroVolumetricQualitySettings.__PropertyOffset_VolumetricQuality, this));
				}
				return result;
			}
			set
			{
				this.VolumetricQuality.CopyAssign(value);
			}
		}

		// Token: 0x0601B658 RID: 112216 RVA: 0x00285EC7 File Offset: 0x002840C7
		static UKuroVolumetricQualitySettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroVolumetricQualitySettings");
		}

		// Token: 0x0601B659 RID: 112217 RVA: 0x00285ED5 File Offset: 0x002840D5
		protected UKuroVolumetricQualitySettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBF3 RID: 60403
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroVolumetricQualitySettings";

		// Token: 0x0400EBF4 RID: 60404
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBF5 RID: 60405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBF6 RID: 60406
		internal static int __PropertyOffset_VolumetricQuality;

		// Token: 0x0400EBF7 RID: 60407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _VolumetricQuality;
	}
}
