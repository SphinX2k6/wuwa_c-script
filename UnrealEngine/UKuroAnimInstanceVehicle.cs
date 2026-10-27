using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F25 RID: 7973
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroAnimInstanceVehicle")]
	[UnrealStructLayout(2672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2672)]
	public class UKuroAnimInstanceVehicle : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E3D4 RID: 123860 RVA: 0x002CF159 File Offset: 0x002CD359
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceVehicle._ClassPtr;
		}

		// Token: 0x0601E3D5 RID: 123861 RVA: 0x002CF168 File Offset: 0x002CD368
		public UKuroAnimInstanceVehicle() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3D6 RID: 123862 RVA: 0x002CF190 File Offset: 0x002CD390
		[NullableContext(1)]
		public UKuroAnimInstanceVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700780A RID: 30730
		// (get) Token: 0x0601E3D7 RID: 123863 RVA: 0x002CF1C3 File Offset: 0x002CD3C3
		// (set) Token: 0x0601E3D8 RID: 123864 RVA: 0x002CF1D7 File Offset: 0x002CD3D7
		public unsafe UAbpLogicParams LogicParams
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbpLogicParams>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceVehicle.__PropertyOffset_LogicParams);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceVehicle.__PropertyOffset_LogicParams, value);
			}
		}

		// Token: 0x1700780B RID: 30731
		// (get) Token: 0x0601E3D9 RID: 123865 RVA: 0x002CF1EC File Offset: 0x002CD3EC
		// (set) Token: 0x0601E3DA RID: 123866 RVA: 0x002CF200 File Offset: 0x002CD400
		public unsafe AKuroBaseVehicle BaseVehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceVehicle.__PropertyOffset_BaseVehicle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceVehicle.__PropertyOffset_BaseVehicle, value);
			}
		}

		// Token: 0x1700780C RID: 30732
		// (get) Token: 0x0601E3DB RID: 123867 RVA: 0x002CF215 File Offset: 0x002CD415
		// (set) Token: 0x0601E3DC RID: 123868 RVA: 0x002CF225 File Offset: 0x002CD425
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_DeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_DeltaTime) = value;
			}
		}

		// Token: 0x1700780D RID: 30733
		// (get) Token: 0x0601E3DD RID: 123869 RVA: 0x002CF236 File Offset: 0x002CD436
		// (set) Token: 0x0601E3DE RID: 123870 RVA: 0x002CF246 File Offset: 0x002CD446
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x1700780E RID: 30734
		// (get) Token: 0x0601E3DF RID: 123871 RVA: 0x002CF257 File Offset: 0x002CD457
		// (set) Token: 0x0601E3E0 RID: 123872 RVA: 0x002CF267 File Offset: 0x002CD467
		public unsafe bool bIsAutonomousProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bIsAutonomousProxy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bIsAutonomousProxy) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700780F RID: 30735
		// (get) Token: 0x0601E3E1 RID: 123873 RVA: 0x002CF278 File Offset: 0x002CD478
		// (set) Token: 0x0601E3E2 RID: 123874 RVA: 0x002CF28C File Offset: 0x002CD48C
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17007810 RID: 30736
		// (get) Token: 0x0601E3E3 RID: 123875 RVA: 0x002CF2A1 File Offset: 0x002CD4A1
		// (set) Token: 0x0601E3E4 RID: 123876 RVA: 0x002CF2B1 File Offset: 0x002CD4B1
		public unsafe bool bIsMovedLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bIsMovedLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bIsMovedLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007811 RID: 30737
		// (get) Token: 0x0601E3E5 RID: 123877 RVA: 0x002CF2C2 File Offset: 0x002CD4C2
		// (set) Token: 0x0601E3E6 RID: 123878 RVA: 0x002CF2D6 File Offset: 0x002CD4D6
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17007812 RID: 30738
		// (get) Token: 0x0601E3E7 RID: 123879 RVA: 0x002CF2EB File Offset: 0x002CD4EB
		// (set) Token: 0x0601E3E8 RID: 123880 RVA: 0x002CF2FF File Offset: 0x002CD4FF
		public unsafe FVector ActorForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_ActorForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_ActorForward) = value;
			}
		}

		// Token: 0x17007813 RID: 30739
		// (get) Token: 0x0601E3E9 RID: 123881 RVA: 0x002CF314 File Offset: 0x002CD514
		// (set) Token: 0x0601E3EA RID: 123882 RVA: 0x002CF324 File Offset: 0x002CD524
		public unsafe bool bHasDriver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bHasDriver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceVehicle.__PropertyOffset_bHasDriver) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E3EB RID: 123883 RVA: 0x002CF335 File Offset: 0x002CD535
		public void SetDriver(ABaseCharacter InDriver)
		{
			UKuroAnimInstanceVehicle.__SetDriver_Internal(base.NativePtr, (InDriver != null) ? InDriver.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E3EC RID: 123884 RVA: 0x002CF352 File Offset: 0x002CD552
		public ABaseCharacter GetDriver()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ABaseCharacter>(UKuroAnimInstanceVehicle.__GetDriver_Internal(base.NativePtr));
		}

		// Token: 0x0601E3ED RID: 123885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDriver_Internal(IntPtr @this, IntPtr InDriver);

		// Token: 0x0601E3EE RID: 123886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDriver_Internal(IntPtr @this);

		// Token: 0x0601E3EF RID: 123887 RVA: 0x002CF364 File Offset: 0x002CD564
		static UKuroAnimInstanceVehicle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroAnimInstanceVehicle");
		}

		// Token: 0x0601E3F0 RID: 123888 RVA: 0x002CF372 File Offset: 0x002CD572
		protected UKuroAnimInstanceVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010518 RID: 66840
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroAnimInstanceVehicle";

		// Token: 0x04010519 RID: 66841
		private static IntPtr _ClassPtr;

		// Token: 0x0401051A RID: 66842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401051B RID: 66843
		internal static int __PropertyOffset_LogicParams;

		// Token: 0x0401051C RID: 66844
		internal static int __PropertyOffset_BaseVehicle;

		// Token: 0x0401051D RID: 66845
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x0401051E RID: 66846
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0401051F RID: 66847
		internal static int __PropertyOffset_bIsAutonomousProxy;

		// Token: 0x04010520 RID: 66848
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04010521 RID: 66849
		internal static int __PropertyOffset_bIsMovedLocation;

		// Token: 0x04010522 RID: 66850
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04010523 RID: 66851
		internal static int __PropertyOffset_ActorForward;

		// Token: 0x04010524 RID: 66852
		internal static int __PropertyOffset_bHasDriver;
	}
}
