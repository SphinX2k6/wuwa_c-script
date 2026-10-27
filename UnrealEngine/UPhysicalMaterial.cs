using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002645 RID: 9797
	[UnrealObjectPath("/Script/PhysicsCore.PhysicalMaterial")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UPhysicalMaterial : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024677 RID: 149111 RVA: 0x0035E5A9 File Offset: 0x0035C7A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicalMaterial._ClassPtr;
		}

		// Token: 0x06024678 RID: 149112 RVA: 0x0035E5B8 File Offset: 0x0035C7B8
		public UPhysicalMaterial() : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024679 RID: 149113 RVA: 0x0035E5E0 File Offset: 0x0035C7E0
		[NullableContext(1)]
		public UPhysicalMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C3C RID: 35900
		// (get) Token: 0x0602467A RID: 149114 RVA: 0x0035E613 File Offset: 0x0035C813
		// (set) Token: 0x0602467B RID: 149115 RVA: 0x0035E623 File Offset: 0x0035C823
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

		// Token: 0x17008C3D RID: 35901
		// (get) Token: 0x0602467C RID: 149116 RVA: 0x0035E634 File Offset: 0x0035C834
		// (set) Token: 0x0602467D RID: 149117 RVA: 0x0035E644 File Offset: 0x0035C844
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

		// Token: 0x17008C3E RID: 35902
		// (get) Token: 0x0602467E RID: 149118 RVA: 0x0035E655 File Offset: 0x0035C855
		// (set) Token: 0x0602467F RID: 149119 RVA: 0x0035E669 File Offset: 0x0035C869
		public unsafe TEnumAsByte<EFrictionCombineMode> FrictionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_FrictionCombineMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_FrictionCombineMode) = value;
			}
		}

		// Token: 0x17008C3F RID: 35903
		// (get) Token: 0x06024680 RID: 149120 RVA: 0x0035E67E File Offset: 0x0035C87E
		// (set) Token: 0x06024681 RID: 149121 RVA: 0x0035E68E File Offset: 0x0035C88E
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

		// Token: 0x17008C40 RID: 35904
		// (get) Token: 0x06024682 RID: 149122 RVA: 0x0035E69F File Offset: 0x0035C89F
		// (set) Token: 0x06024683 RID: 149123 RVA: 0x0035E6AF File Offset: 0x0035C8AF
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

		// Token: 0x17008C41 RID: 35905
		// (get) Token: 0x06024684 RID: 149124 RVA: 0x0035E6C0 File Offset: 0x0035C8C0
		// (set) Token: 0x06024685 RID: 149125 RVA: 0x0035E6D4 File Offset: 0x0035C8D4
		public unsafe TEnumAsByte<EFrictionCombineMode> RestitutionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_RestitutionCombineMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterial.__PropertyOffset_RestitutionCombineMode) = value;
			}
		}

		// Token: 0x17008C42 RID: 35906
		// (get) Token: 0x06024686 RID: 149126 RVA: 0x0035E6E9 File Offset: 0x0035C8E9
		// (set) Token: 0x06024687 RID: 149127 RVA: 0x0035E6F9 File Offset: 0x0035C8F9
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

		// Token: 0x17008C43 RID: 35907
		// (get) Token: 0x06024688 RID: 149128 RVA: 0x0035E70A File Offset: 0x0035C90A
		// (set) Token: 0x06024689 RID: 149129 RVA: 0x0035E71A File Offset: 0x0035C91A
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

		// Token: 0x17008C44 RID: 35908
		// (get) Token: 0x0602468A RID: 149130 RVA: 0x0035E72B File Offset: 0x0035C92B
		// (set) Token: 0x0602468B RID: 149131 RVA: 0x0035E73B File Offset: 0x0035C93B
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

		// Token: 0x17008C45 RID: 35909
		// (get) Token: 0x0602468C RID: 149132 RVA: 0x0035E74C File Offset: 0x0035C94C
		// (set) Token: 0x0602468D RID: 149133 RVA: 0x0035E75C File Offset: 0x0035C95C
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

		// Token: 0x17008C46 RID: 35910
		// (get) Token: 0x0602468E RID: 149134 RVA: 0x0035E76D File Offset: 0x0035C96D
		// (set) Token: 0x0602468F RID: 149135 RVA: 0x0035E77D File Offset: 0x0035C97D
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

		// Token: 0x17008C47 RID: 35911
		// (get) Token: 0x06024690 RID: 149136 RVA: 0x0035E78E File Offset: 0x0035C98E
		// (set) Token: 0x06024691 RID: 149137 RVA: 0x0035E79E File Offset: 0x0035C99E
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

		// Token: 0x17008C48 RID: 35912
		// (get) Token: 0x06024692 RID: 149138 RVA: 0x0035E7AF File Offset: 0x0035C9AF
		// (set) Token: 0x06024693 RID: 149139 RVA: 0x0035E7BF File Offset: 0x0035C9BF
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

		// Token: 0x17008C49 RID: 35913
		// (get) Token: 0x06024694 RID: 149140 RVA: 0x0035E7D0 File Offset: 0x0035C9D0
		// (set) Token: 0x06024695 RID: 149141 RVA: 0x0035E7E4 File Offset: 0x0035C9E4
		[Nullable(2)]
		public unsafe UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDEPRECATED_PhysicalMaterialPropertyBase>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicalMaterial.__PropertyOffset_PhysicalMaterialProperty_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicalMaterial.__PropertyOffset_PhysicalMaterialProperty_DEPRECATED, value);
			}
		}

		// Token: 0x17008C4A RID: 35914
		// (get) Token: 0x06024696 RID: 149142 RVA: 0x0035E7F9 File Offset: 0x0035C9F9
		// (set) Token: 0x06024697 RID: 149143 RVA: 0x0035E80D File Offset: 0x0035CA0D
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

		// Token: 0x06024698 RID: 149144 RVA: 0x0035E822 File Offset: 0x0035CA22
		static UPhysicalMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.PhysicalMaterial");
		}

		// Token: 0x06024699 RID: 149145 RVA: 0x0035E830 File Offset: 0x0035CA30
		protected UPhysicalMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040138DE RID: 80094
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.PhysicalMaterial";

		// Token: 0x040138DF RID: 80095
		private static IntPtr _ClassPtr;

		// Token: 0x040138E0 RID: 80096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040138E1 RID: 80097
		internal static int __PropertyOffset_Friction;

		// Token: 0x040138E2 RID: 80098
		internal static int __PropertyOffset_StaticFriction;

		// Token: 0x040138E3 RID: 80099
		internal static int __PropertyOffset_FrictionCombineMode;

		// Token: 0x040138E4 RID: 80100
		internal static int __PropertyOffset_bOverrideFrictionCombineMode;

		// Token: 0x040138E5 RID: 80101
		internal static int __PropertyOffset_Restitution;

		// Token: 0x040138E6 RID: 80102
		internal static int __PropertyOffset_RestitutionCombineMode;

		// Token: 0x040138E7 RID: 80103
		internal static int __PropertyOffset_bOverrideRestitutionCombineMode;

		// Token: 0x040138E8 RID: 80104
		internal static int __PropertyOffset_Density;

		// Token: 0x040138E9 RID: 80105
		internal static int __PropertyOffset_SleepLinearVelocityThreshold;

		// Token: 0x040138EA RID: 80106
		internal static int __PropertyOffset_SleepAngularVelocityThreshold;

		// Token: 0x040138EB RID: 80107
		internal static int __PropertyOffset_SleepCounterThreshold;

		// Token: 0x040138EC RID: 80108
		internal static int __PropertyOffset_RaiseMassToPower;

		// Token: 0x040138ED RID: 80109
		internal static int __PropertyOffset_DestructibleDamageThresholdScale;

		// Token: 0x040138EE RID: 80110
		internal static int __PropertyOffset_PhysicalMaterialProperty_DEPRECATED;

		// Token: 0x040138EF RID: 80111
		internal static int __PropertyOffset_SurfaceType;
	}
}
