using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043B RID: 1083
	[UnrealObjectPath("/Script/ChaosCloth.ChaosClothSharedSimConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UChaosClothSharedSimConfig : UClothSharedConfigCommon, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x00058876 File Offset: 0x00056A76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosClothSharedSimConfig._ClassPtr;
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00058884 File Offset: 0x00056A84
		public UChaosClothSharedSimConfig() : this(BuiltinUtils.AllocNativeUObject(UChaosClothSharedSimConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000588AC File Offset: 0x00056AAC
		[NullableContext(1)]
		public UChaosClothSharedSimConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosClothSharedSimConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x000588DF File Offset: 0x00056ADF
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x000588EF File Offset: 0x00056AEF
		public unsafe int IterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_IterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_IterationCount) = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00058900 File Offset: 0x00056B00
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x00058910 File Offset: 0x00056B10
		public unsafe int SubdivisionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_SubdivisionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_SubdivisionCount) = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00058921 File Offset: 0x00056B21
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x00058931 File Offset: 0x00056B31
		public unsafe float SelfCollisionThickness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_SelfCollisionThickness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_SelfCollisionThickness_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x00058942 File Offset: 0x00056B42
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00058952 File Offset: 0x00056B52
		public unsafe float CollisionThickness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_CollisionThickness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_CollisionThickness_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x00058963 File Offset: 0x00056B63
		// (set) Token: 0x06003A9A RID: 15002 RVA: 0x00058973 File Offset: 0x00056B73
		public unsafe bool bUseDampingOverride_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseDampingOverride_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseDampingOverride_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x00058984 File Offset: 0x00056B84
		// (set) Token: 0x06003A9C RID: 15004 RVA: 0x00058994 File Offset: 0x00056B94
		public unsafe float Damping_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_Damping_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_Damping_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000589A5 File Offset: 0x00056BA5
		// (set) Token: 0x06003A9E RID: 15006 RVA: 0x000589B5 File Offset: 0x00056BB5
		public unsafe bool bUseGravityOverride_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseGravityOverride_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseGravityOverride_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x000589C6 File Offset: 0x00056BC6
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x000589D6 File Offset: 0x00056BD6
		public unsafe float GravityScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_GravityScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_GravityScale_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x000589E7 File Offset: 0x00056BE7
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x000589FB File Offset: 0x00056BFB
		public unsafe FVector Gravity_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_Gravity_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_Gravity_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00058A10 File Offset: 0x00056C10
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00058A20 File Offset: 0x00056C20
		public unsafe bool bUseLocalSpaceSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseLocalSpaceSimulation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseLocalSpaceSimulation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x00058A31 File Offset: 0x00056C31
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00058A41 File Offset: 0x00056C41
		public unsafe bool bUseXPBDConstraints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseXPBDConstraints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothSharedSimConfig.__PropertyOffset_bUseXPBDConstraints) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00058A52 File Offset: 0x00056C52
		static UChaosClothSharedSimConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosCloth.ChaosClothSharedSimConfig");
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00058A60 File Offset: 0x00056C60
		protected UChaosClothSharedSimConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001AB3 RID: 6835
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosCloth.ChaosClothSharedSimConfig";

		// Token: 0x04001AB4 RID: 6836
		private static IntPtr _ClassPtr;

		// Token: 0x04001AB5 RID: 6837
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001AB6 RID: 6838
		internal static int __PropertyOffset_IterationCount;

		// Token: 0x04001AB7 RID: 6839
		internal static int __PropertyOffset_SubdivisionCount;

		// Token: 0x04001AB8 RID: 6840
		internal static int __PropertyOffset_SelfCollisionThickness_DEPRECATED;

		// Token: 0x04001AB9 RID: 6841
		internal static int __PropertyOffset_CollisionThickness_DEPRECATED;

		// Token: 0x04001ABA RID: 6842
		internal static int __PropertyOffset_bUseDampingOverride_DEPRECATED;

		// Token: 0x04001ABB RID: 6843
		internal static int __PropertyOffset_Damping_DEPRECATED;

		// Token: 0x04001ABC RID: 6844
		internal static int __PropertyOffset_bUseGravityOverride_DEPRECATED;

		// Token: 0x04001ABD RID: 6845
		internal static int __PropertyOffset_GravityScale_DEPRECATED;

		// Token: 0x04001ABE RID: 6846
		internal static int __PropertyOffset_Gravity_DEPRECATED;

		// Token: 0x04001ABF RID: 6847
		internal static int __PropertyOffset_bUseLocalSpaceSimulation;

		// Token: 0x04001AC0 RID: 6848
		internal static int __PropertyOffset_bUseXPBDConstraints;
	}
}
