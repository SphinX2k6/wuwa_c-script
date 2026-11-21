using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B6 RID: 1974
	[UnrealObjectPath("/Script/PhysicsCore.PhysicalMaterial")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UPhysicalMaterial : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AB4F RID: 43855 RVA: 0x000FCA80 File Offset: 0x000FAC80
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicalMaterial._ClassPtr;
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x000FCA8C File Offset: 0x000FAC8C
		public UPhysicalMaterial() : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x000FCAB4 File Offset: 0x000FACB4
		[NullableContext(1)]
		public UPhysicalMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x000FCAE7 File Offset: 0x000FACE7
		// (set) Token: 0x0600AB53 RID: 43859 RVA: 0x000FCAF7 File Offset: 0x000FACF7
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x000FCB08 File Offset: 0x000FAD08
		// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x000FCB18 File Offset: 0x000FAD18
		public unsafe float StaticFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_StaticFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_StaticFriction) = value;
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x000FCB29 File Offset: 0x000FAD29
		// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x000FCB39 File Offset: 0x000FAD39
		public unsafe bool bOverrideFrictionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_bOverrideFrictionCombineMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_bOverrideFrictionCombineMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x000FCB4A File Offset: 0x000FAD4A
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x000FCB5A File Offset: 0x000FAD5A
		public unsafe float Restitution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Restitution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Restitution) = value;
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x000FCB6B File Offset: 0x000FAD6B
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x000FCB7B File Offset: 0x000FAD7B
		public unsafe bool bOverrideRestitutionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_bOverrideRestitutionCombineMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_bOverrideRestitutionCombineMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x000FCB8C File Offset: 0x000FAD8C
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x000FCB9C File Offset: 0x000FAD9C
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x000FCBAD File Offset: 0x000FADAD
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x000FCBBD File Offset: 0x000FADBD
		public unsafe float SleepLinearVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepLinearVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepLinearVelocityThreshold) = value;
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x000FCBCE File Offset: 0x000FADCE
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x000FCBDE File Offset: 0x000FADDE
		public unsafe float SleepAngularVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepAngularVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepAngularVelocityThreshold) = value;
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x000FCBEF File Offset: 0x000FADEF
		// (set) Token: 0x0600AB63 RID: 43875 RVA: 0x000FCBFF File Offset: 0x000FADFF
		public unsafe int SleepCounterThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepCounterThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SleepCounterThreshold) = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x000FCC10 File Offset: 0x000FAE10
		// (set) Token: 0x0600AB65 RID: 43877 RVA: 0x000FCC20 File Offset: 0x000FAE20
		public unsafe float RaiseMassToPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_RaiseMassToPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_RaiseMassToPower) = value;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x000FCC31 File Offset: 0x000FAE31
		// (set) Token: 0x0600AB67 RID: 43879 RVA: 0x000FCC41 File Offset: 0x000FAE41
		public unsafe float DestructibleDamageThresholdScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_DestructibleDamageThresholdScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_DestructibleDamageThresholdScale) = value;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x0600AB68 RID: 43880 RVA: 0x000FCC52 File Offset: 0x000FAE52
		// (set) Token: 0x0600AB69 RID: 43881 RVA: 0x000FCC66 File Offset: 0x000FAE66
		public unsafe TEnumAsByte<EPhysicalSurface> SurfaceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SurfaceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_SurfaceType) = value;
			}
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x000FCC7B File Offset: 0x000FAE7B
		static UPhysicalMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.PhysicalMaterial");
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x000FCC89 File Offset: 0x000FAE89
		protected UPhysicalMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400498F RID: 18831
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.PhysicalMaterial";

		// Token: 0x04004990 RID: 18832
		private static IntPtr _ClassPtr;

		// Token: 0x04004991 RID: 18833
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004992 RID: 18834
		internal static int __PropertyOffset_Friction;

		// Token: 0x04004993 RID: 18835
		internal static int __PropertyOffset_StaticFriction;

		// Token: 0x04004994 RID: 18836
		internal static int __PropertyOffset_bOverrideFrictionCombineMode;

		// Token: 0x04004995 RID: 18837
		internal static int __PropertyOffset_Restitution;

		// Token: 0x04004996 RID: 18838
		internal static int __PropertyOffset_bOverrideRestitutionCombineMode;

		// Token: 0x04004997 RID: 18839
		internal static int __PropertyOffset_Density;

		// Token: 0x04004998 RID: 18840
		internal static int __PropertyOffset_SleepLinearVelocityThreshold;

		// Token: 0x04004999 RID: 18841
		internal static int __PropertyOffset_SleepAngularVelocityThreshold;

		// Token: 0x0400499A RID: 18842
		internal static int __PropertyOffset_SleepCounterThreshold;

		// Token: 0x0400499B RID: 18843
		internal static int __PropertyOffset_RaiseMassToPower;

		// Token: 0x0400499C RID: 18844
		internal static int __PropertyOffset_DestructibleDamageThresholdScale;

		// Token: 0x0400499D RID: 18845
		internal static int __PropertyOffset_SurfaceType;
	}
}
