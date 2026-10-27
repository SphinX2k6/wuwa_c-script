using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011F7 RID: 4599
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TODLightManagerSubsystem")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UTODLightManagerSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010F38 RID: 69432 RVA: 0x0018E1FB File Offset: 0x0018C3FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTODLightManagerSubsystem._ClassPtr;
		}

		// Token: 0x06010F39 RID: 69433 RVA: 0x0018E208 File Offset: 0x0018C408
		public UTODLightManagerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UTODLightManagerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010F3A RID: 69434 RVA: 0x0018E230 File Offset: 0x0018C430
		public UTODLightManagerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTODLightManagerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x06010F3B RID: 69435 RVA: 0x0018E263 File Offset: 0x0018C463
		// (set) Token: 0x06010F3C RID: 69436 RVA: 0x0018E273 File Offset: 0x0018C473
		public unsafe bool bEnableLerpLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bEnableLerpLightIntensity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bEnableLerpLightIntensity) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x06010F3D RID: 69437 RVA: 0x0018E284 File Offset: 0x0018C484
		// (set) Token: 0x06010F3E RID: 69438 RVA: 0x0018E294 File Offset: 0x0018C494
		public unsafe float LightScaleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightScaleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightScaleTime) = value;
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x06010F3F RID: 69439 RVA: 0x0018E2A5 File Offset: 0x0018C4A5
		// (set) Token: 0x06010F40 RID: 69440 RVA: 0x0018E2B5 File Offset: 0x0018C4B5
		public unsafe float LightIntensityMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightIntensityMul);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightIntensityMul) = value;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x06010F41 RID: 69441 RVA: 0x0018E2C6 File Offset: 0x0018C4C6
		// (set) Token: 0x06010F42 RID: 69442 RVA: 0x0018E2D6 File Offset: 0x0018C4D6
		public unsafe float LightIntensityCloseLerpMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightIntensityCloseLerpMul);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_LightIntensityCloseLerpMul) = value;
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x06010F43 RID: 69443 RVA: 0x0018E2E7 File Offset: 0x0018C4E7
		// (set) Token: 0x06010F44 RID: 69444 RVA: 0x0018E2F7 File Offset: 0x0018C4F7
		public unsafe bool bEnableRestRegisterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bEnableRestRegisterIntensity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bEnableRestRegisterIntensity) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x06010F45 RID: 69445 RVA: 0x0018E308 File Offset: 0x0018C508
		// (set) Token: 0x06010F46 RID: 69446 RVA: 0x0018E318 File Offset: 0x0018C518
		public unsafe bool bIntoRain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bIntoRain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bIntoRain) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x06010F47 RID: 69447 RVA: 0x0018E329 File Offset: 0x0018C529
		// (set) Token: 0x06010F48 RID: 69448 RVA: 0x0018E339 File Offset: 0x0018C539
		public unsafe bool bOutRain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bOutRain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_bOutRain) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x06010F49 RID: 69449 RVA: 0x0018E34A File Offset: 0x0018C54A
		// (set) Token: 0x06010F4A RID: 69450 RVA: 0x0018E35A File Offset: 0x0018C55A
		public unsafe float RainFadeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_RainFadeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_RainFadeTime) = value;
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x06010F4B RID: 69451 RVA: 0x0018E36C File Offset: 0x0018C56C
		// (set) Token: 0x06010F4C RID: 69452 RVA: 0x0018E3A5 File Offset: 0x0018C5A5
		public TMap<UPointLightComponent, float> ProxiesToDayPointLight
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPointLightComponent, float> result;
				if ((result = this._ProxiesToDayPointLight) == null)
				{
					result = (this._ProxiesToDayPointLight = new TMap<UPointLightComponent, float>(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_ProxiesToDayPointLight, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToDayPointLight.CopyAssign(value);
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x06010F4D RID: 69453 RVA: 0x0018E3B4 File Offset: 0x0018C5B4
		// (set) Token: 0x06010F4E RID: 69454 RVA: 0x0018E3ED File Offset: 0x0018C5ED
		public TMap<UPointLightComponent, float> ProxiesToNightPointLight
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPointLightComponent, float> result;
				if ((result = this._ProxiesToNightPointLight) == null)
				{
					result = (this._ProxiesToNightPointLight = new TMap<UPointLightComponent, float>(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_ProxiesToNightPointLight, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToNightPointLight.CopyAssign(value);
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x06010F4F RID: 69455 RVA: 0x0018E3FC File Offset: 0x0018C5FC
		// (set) Token: 0x06010F50 RID: 69456 RVA: 0x0018E435 File Offset: 0x0018C635
		public TMap<URectLightComponent, float> ProxiesToDayRectLight
		{
			get
			{
				base.FastCheckIsValid();
				TMap<URectLightComponent, float> result;
				if ((result = this._ProxiesToDayRectLight) == null)
				{
					result = (this._ProxiesToDayRectLight = new TMap<URectLightComponent, float>(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_ProxiesToDayRectLight, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToDayRectLight.CopyAssign(value);
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x06010F51 RID: 69457 RVA: 0x0018E444 File Offset: 0x0018C644
		// (set) Token: 0x06010F52 RID: 69458 RVA: 0x0018E47D File Offset: 0x0018C67D
		public TMap<URectLightComponent, float> ProxiesToNightRectLight
		{
			get
			{
				base.FastCheckIsValid();
				TMap<URectLightComponent, float> result;
				if ((result = this._ProxiesToNightRectLight) == null)
				{
					result = (this._ProxiesToNightRectLight = new TMap<URectLightComponent, float>(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_ProxiesToNightRectLight, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToNightRectLight.CopyAssign(value);
			}
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x06010F53 RID: 69459 RVA: 0x0018E48C File Offset: 0x0018C68C
		// (set) Token: 0x06010F54 RID: 69460 RVA: 0x0018E4C5 File Offset: 0x0018C6C5
		public TArray<UPointLightComponent> ProxiesToRainPointLight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPointLightComponent> result;
				if ((result = this._ProxiesToRainPointLight) == null)
				{
					result = (this._ProxiesToRainPointLight = new TArray<UPointLightComponent>(base.NativePtr + (IntPtr)UTODLightManagerSubsystem.__PropertyOffset_ProxiesToRainPointLight, this));
				}
				return result;
			}
			set
			{
				this.ProxiesToRainPointLight.CopyAssign(value);
			}
		}

		// Token: 0x06010F55 RID: 69461 RVA: 0x0018E4D3 File Offset: 0x0018C6D3
		public void EnableTODLightManagerIsDay(bool IsDay)
		{
			UTODLightManagerSubsystem.__EnableTODLightManagerIsDay_Internal(base.NativePtr, IsDay);
		}

		// Token: 0x06010F56 RID: 69462 RVA: 0x0018E4E1 File Offset: 0x0018C6E1
		public void EnableTODLightManagerIsCloseLightLerpTime(bool IsCloseLightLerpTime)
		{
			UTODLightManagerSubsystem.__EnableTODLightManagerIsCloseLightLerpTime_Internal(base.NativePtr, IsCloseLightLerpTime);
		}

		// Token: 0x06010F57 RID: 69463 RVA: 0x0018E4EF File Offset: 0x0018C6EF
		public void EditorTick(float DeltaTime)
		{
			UTODLightManagerSubsystem.__EditorTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06010F58 RID: 69464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTODLightManagerIsDay_Internal(IntPtr @this, bool IsDay);

		// Token: 0x06010F59 RID: 69465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTODLightManagerIsCloseLightLerpTime_Internal(IntPtr @this, bool IsCloseLightLerpTime);

		// Token: 0x06010F5A RID: 69466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06010F5B RID: 69467 RVA: 0x0018E4FD File Offset: 0x0018C6FD
		static UTODLightManagerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TODLightManagerSubsystem");
		}

		// Token: 0x06010F5C RID: 69468 RVA: 0x0018E50B File Offset: 0x0018C70B
		protected UTODLightManagerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009143 RID: 37187
		public new const string __ObjectPath = "/Script/Engine.TODLightManagerSubsystem";

		// Token: 0x04009144 RID: 37188
		private static IntPtr _ClassPtr;

		// Token: 0x04009145 RID: 37189
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009146 RID: 37190
		internal static int __PropertyOffset_bEnableLerpLightIntensity;

		// Token: 0x04009147 RID: 37191
		internal static int __PropertyOffset_LightScaleTime;

		// Token: 0x04009148 RID: 37192
		internal static int __PropertyOffset_LightIntensityMul;

		// Token: 0x04009149 RID: 37193
		internal static int __PropertyOffset_LightIntensityCloseLerpMul;

		// Token: 0x0400914A RID: 37194
		internal static int __PropertyOffset_bEnableRestRegisterIntensity;

		// Token: 0x0400914B RID: 37195
		internal static int __PropertyOffset_bIntoRain;

		// Token: 0x0400914C RID: 37196
		internal static int __PropertyOffset_bOutRain;

		// Token: 0x0400914D RID: 37197
		internal static int __PropertyOffset_RainFadeTime;

		// Token: 0x0400914E RID: 37198
		internal static int __PropertyOffset_ProxiesToDayPointLight;

		// Token: 0x0400914F RID: 37199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UPointLightComponent, float> _ProxiesToDayPointLight;

		// Token: 0x04009150 RID: 37200
		internal static int __PropertyOffset_ProxiesToNightPointLight;

		// Token: 0x04009151 RID: 37201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UPointLightComponent, float> _ProxiesToNightPointLight;

		// Token: 0x04009152 RID: 37202
		internal static int __PropertyOffset_ProxiesToDayRectLight;

		// Token: 0x04009153 RID: 37203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<URectLightComponent, float> _ProxiesToDayRectLight;

		// Token: 0x04009154 RID: 37204
		internal static int __PropertyOffset_ProxiesToNightRectLight;

		// Token: 0x04009155 RID: 37205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<URectLightComponent, float> _ProxiesToNightRectLight;

		// Token: 0x04009156 RID: 37206
		internal static int __PropertyOffset_ProxiesToRainPointLight;

		// Token: 0x04009157 RID: 37207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPointLightComponent> _ProxiesToRainPointLight;
	}
}
