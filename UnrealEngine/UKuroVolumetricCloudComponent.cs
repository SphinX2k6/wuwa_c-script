using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D16 RID: 3350
	[UnrealObjectPath("/Script/Engine.KuroVolumetricCloudComponent")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UKuroVolumetricCloudComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B392 RID: 45970 RVA: 0x001002CF File Offset: 0x000FE4CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVolumetricCloudComponent._ClassPtr;
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x001002DC File Offset: 0x000FE4DC
		public UKuroVolumetricCloudComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVolumetricCloudComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x00100304 File Offset: 0x000FE504
		[NullableContext(1)]
		public UKuroVolumetricCloudComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVolumetricCloudComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600B395 RID: 45973 RVA: 0x00100337 File Offset: 0x000FE537
		// (set) Token: 0x0600B396 RID: 45974 RVA: 0x0010034B File Offset: 0x000FE54B
		public unsafe FLinearColor CloudTopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudTopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudTopColor) = value;
			}
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x00100360 File Offset: 0x000FE560
		// (set) Token: 0x0600B398 RID: 45976 RVA: 0x00100374 File Offset: 0x000FE574
		public unsafe FLinearColor CloudBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudBottomColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudBottomColor) = value;
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600B399 RID: 45977 RVA: 0x00100389 File Offset: 0x000FE589
		// (set) Token: 0x0600B39A RID: 45978 RVA: 0x0010039D File Offset: 0x000FE59D
		public unsafe FLinearColor CloudTopEmissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudTopEmissive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudTopEmissive) = value;
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x001003B2 File Offset: 0x000FE5B2
		// (set) Token: 0x0600B39C RID: 45980 RVA: 0x001003C6 File Offset: 0x000FE5C6
		public unsafe FLinearColor CloudBottomEmissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudBottomEmissive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_CloudBottomEmissive) = value;
			}
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x001003DB File Offset: 0x000FE5DB
		// (set) Token: 0x0600B39E RID: 45982 RVA: 0x001003EB File Offset: 0x000FE5EB
		public unsafe float DirectionalLightBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_DirectionalLightBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_DirectionalLightBlend) = value;
			}
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x0600B39F RID: 45983 RVA: 0x001003FC File Offset: 0x000FE5FC
		// (set) Token: 0x0600B3A0 RID: 45984 RVA: 0x0010040C File Offset: 0x000FE60C
		public unsafe float FallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_FallOff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_FallOff) = value;
			}
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x0600B3A1 RID: 45985 RVA: 0x0010041D File Offset: 0x000FE61D
		// (set) Token: 0x0600B3A2 RID: 45986 RVA: 0x0010042D File Offset: 0x000FE62D
		public unsafe float Heighness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_Heighness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_Heighness) = value;
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x0600B3A3 RID: 45987 RVA: 0x0010043E File Offset: 0x000FE63E
		// (set) Token: 0x0600B3A4 RID: 45988 RVA: 0x0010044E File Offset: 0x000FE64E
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x0600B3A5 RID: 45989 RVA: 0x0010045F File Offset: 0x000FE65F
		// (set) Token: 0x0600B3A6 RID: 45990 RVA: 0x00100473 File Offset: 0x000FE673
		public unsafe FVector2D SpeedHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedHigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedHigh) = value;
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600B3A7 RID: 45991 RVA: 0x00100488 File Offset: 0x000FE688
		// (set) Token: 0x0600B3A8 RID: 45992 RVA: 0x0010049C File Offset: 0x000FE69C
		public unsafe FVector2D SpeedMedium
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedMedium);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedMedium) = value;
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600B3A9 RID: 45993 RVA: 0x001004B1 File Offset: 0x000FE6B1
		// (set) Token: 0x0600B3AA RID: 45994 RVA: 0x001004C5 File Offset: 0x000FE6C5
		public unsafe FVector2D SpeedLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_SpeedLow) = value;
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600B3AB RID: 45995 RVA: 0x001004DA File Offset: 0x000FE6DA
		// (set) Token: 0x0600B3AC RID: 45996 RVA: 0x001004EA File Offset: 0x000FE6EA
		public unsafe float FadeOutEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_FadeOutEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_FadeOutEdge) = value;
			}
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600B3AD RID: 45997 RVA: 0x001004FB File Offset: 0x000FE6FB
		// (set) Token: 0x0600B3AE RID: 45998 RVA: 0x0010050B File Offset: 0x000FE70B
		public unsafe bool bEdgeFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_bEdgeFadeOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVolumetricCloudComponent.__PropertyOffset_bEdgeFadeOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x0010051C File Offset: 0x000FE71C
		static UKuroVolumetricCloudComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroVolumetricCloudComponent");
		}

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x0010052A File Offset: 0x000FE72A
		protected UKuroVolumetricCloudComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005E69 RID: 24169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroVolumetricCloudComponent";

		// Token: 0x04005E6A RID: 24170
		private static IntPtr _ClassPtr;

		// Token: 0x04005E6B RID: 24171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005E6C RID: 24172
		internal static int __PropertyOffset_CloudTopColor;

		// Token: 0x04005E6D RID: 24173
		internal static int __PropertyOffset_CloudBottomColor;

		// Token: 0x04005E6E RID: 24174
		internal static int __PropertyOffset_CloudTopEmissive;

		// Token: 0x04005E6F RID: 24175
		internal static int __PropertyOffset_CloudBottomEmissive;

		// Token: 0x04005E70 RID: 24176
		internal static int __PropertyOffset_DirectionalLightBlend;

		// Token: 0x04005E71 RID: 24177
		internal static int __PropertyOffset_FallOff;

		// Token: 0x04005E72 RID: 24178
		internal static int __PropertyOffset_Heighness;

		// Token: 0x04005E73 RID: 24179
		internal static int __PropertyOffset_Speed;

		// Token: 0x04005E74 RID: 24180
		internal static int __PropertyOffset_SpeedHigh;

		// Token: 0x04005E75 RID: 24181
		internal static int __PropertyOffset_SpeedMedium;

		// Token: 0x04005E76 RID: 24182
		internal static int __PropertyOffset_SpeedLow;

		// Token: 0x04005E77 RID: 24183
		internal static int __PropertyOffset_FadeOutEdge;

		// Token: 0x04005E78 RID: 24184
		internal static int __PropertyOffset_bEdgeFadeOut;
	}
}
