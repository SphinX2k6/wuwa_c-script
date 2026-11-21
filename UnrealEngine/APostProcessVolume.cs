using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200026A RID: 618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PostProcessVolume")]
	[UnrealStructLayout(3792, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3792)]
	public class APostProcessVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003D5F RID: 15711 RVA: 0x000587E7 File Offset: 0x000569E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APostProcessVolume._ClassPtr;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x000587F4 File Offset: 0x000569F4
		public APostProcessVolume() : this(BuiltinUtils.AllocNativeUObject(APostProcessVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x0005881C File Offset: 0x00056A1C
		public APostProcessVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APostProcessVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00058850 File Offset: 0x00056A50
		// (set) Token: 0x06003D63 RID: 15715 RVA: 0x00058889 File Offset: 0x00056A89
		public FPostProcessSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FPostProcessSettings(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x000588AA File Offset: 0x00056AAA
		// (set) Token: 0x06003D65 RID: 15717 RVA: 0x000588BA File Offset: 0x00056ABA
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x000588CB File Offset: 0x00056ACB
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x000588DB File Offset: 0x00056ADB
		public unsafe float BlendRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendRadius) = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x000588EC File Offset: 0x00056AEC
		// (set) Token: 0x06003D69 RID: 15721 RVA: 0x000588FC File Offset: 0x00056AFC
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x0005890D File Offset: 0x00056B0D
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x00058926 File Offset: 0x00056B26
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) & APostProcessVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bEnabled) & ~APostProcessVolume.__PropertyMask_bEnabled) | (value ? APostProcessVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x00058956 File Offset: 0x00056B56
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x0005896F File Offset: 0x00056B6F
		public unsafe bool bUnbound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) & APostProcessVolume.__PropertyMask_bUnbound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bUnbound) & ~APostProcessVolume.__PropertyMask_bUnbound) | (value ? APostProcessVolume.__PropertyMask_bUnbound : 0));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x0005899F File Offset: 0x00056B9F
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x000589B8 File Offset: 0x00056BB8
		public unsafe bool bIsUISceneRendering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) & APostProcessVolume.__PropertyMask_bIsUISceneRendering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsUISceneRendering) & ~APostProcessVolume.__PropertyMask_bIsUISceneRendering) | (value ? APostProcessVolume.__PropertyMask_bIsUISceneRendering : 0));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x000589E8 File Offset: 0x00056BE8
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x00058A01 File Offset: 0x00056C01
		public unsafe bool bIsEffectVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) & APostProcessVolume.__PropertyMask_bIsEffectVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) = ((*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_bIsEffectVolume) & ~APostProcessVolume.__PropertyMask_bIsEffectVolume) | (value ? APostProcessVolume.__PropertyMask_bIsEffectVolume : 0));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x00058A31 File Offset: 0x00056C31
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x00058A41 File Offset: 0x00056C41
		public unsafe int CustomCullFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_CustomCullFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APostProcessVolume.__PropertyOffset_CustomCullFlag) = value;
			}
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00058A52 File Offset: 0x00056C52
		static APostProcessVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PostProcessVolume");
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00058A60 File Offset: 0x00056C60
		protected APostProcessVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017E9 RID: 6121
		public new const string __ObjectPath = "/Script/Engine.PostProcessVolume";

		// Token: 0x040017EA RID: 6122
		private static IntPtr _ClassPtr;

		// Token: 0x040017EB RID: 6123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017EC RID: 6124
		internal static int __PropertyOffset_Settings;

		// Token: 0x040017ED RID: 6125
		[Nullable(2)]
		private FPostProcessSettings _Settings;

		// Token: 0x040017EE RID: 6126
		internal static int __PropertyOffset_Priority;

		// Token: 0x040017EF RID: 6127
		internal static int __PropertyOffset_BlendRadius;

		// Token: 0x040017F0 RID: 6128
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x040017F1 RID: 6129
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040017F2 RID: 6130
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x040017F3 RID: 6131
		internal static int __PropertyOffset_bUnbound;

		// Token: 0x040017F4 RID: 6132
		internal static byte __PropertyMask_bUnbound;

		// Token: 0x040017F5 RID: 6133
		internal static int __PropertyOffset_bIsUISceneRendering;

		// Token: 0x040017F6 RID: 6134
		internal static byte __PropertyMask_bIsUISceneRendering;

		// Token: 0x040017F7 RID: 6135
		internal static int __PropertyOffset_bIsEffectVolume;

		// Token: 0x040017F8 RID: 6136
		internal static byte __PropertyMask_bIsEffectVolume;

		// Token: 0x040017F9 RID: 6137
		internal static int __PropertyOffset_CustomCullFlag;
	}
}
