using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200062D RID: 1581
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroAnimInstanceVehicle")]
	[UnrealStructLayout(2688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2688)]
	public class UKuroAnimInstanceVehicle : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089D0 RID: 35280 RVA: 0x000CFA8D File Offset: 0x000CDC8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceVehicle._ClassPtr;
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x000CFA9C File Offset: 0x000CDC9C
		public UKuroAnimInstanceVehicle() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x000CFAC4 File Offset: 0x000CDCC4
		[NullableContext(1)]
		public UKuroAnimInstanceVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x000CFAF7 File Offset: 0x000CDCF7
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x000CFB0B File Offset: 0x000CDD0B
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

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x000CFB20 File Offset: 0x000CDD20
		// (set) Token: 0x060089D6 RID: 35286 RVA: 0x000CFB34 File Offset: 0x000CDD34
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

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x000CFB49 File Offset: 0x000CDD49
		// (set) Token: 0x060089D8 RID: 35288 RVA: 0x000CFB59 File Offset: 0x000CDD59
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

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x060089D9 RID: 35289 RVA: 0x000CFB6A File Offset: 0x000CDD6A
		// (set) Token: 0x060089DA RID: 35290 RVA: 0x000CFB7A File Offset: 0x000CDD7A
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x060089DB RID: 35291 RVA: 0x000CFB8B File Offset: 0x000CDD8B
		// (set) Token: 0x060089DC RID: 35292 RVA: 0x000CFB9B File Offset: 0x000CDD9B
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

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x000CFBAC File Offset: 0x000CDDAC
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x000CFBC0 File Offset: 0x000CDDC0
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

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x000CFBD5 File Offset: 0x000CDDD5
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x000CFBE5 File Offset: 0x000CDDE5
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x000CFBF6 File Offset: 0x000CDDF6
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x000CFC0A File Offset: 0x000CDE0A
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x000CFC1F File Offset: 0x000CDE1F
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x000CFC33 File Offset: 0x000CDE33
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

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x000CFC48 File Offset: 0x000CDE48
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x000CFC58 File Offset: 0x000CDE58
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

		// Token: 0x060089E7 RID: 35303 RVA: 0x000CFC69 File Offset: 0x000CDE69
		public void SetDriver(ABaseCharacter InDriver)
		{
			UKuroAnimInstanceVehicle.__SetDriver_Internal(base.NativePtr, (InDriver != null) ? InDriver.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x000CFC86 File Offset: 0x000CDE86
		public ABaseCharacter GetDriver()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ABaseCharacter>(UKuroAnimInstanceVehicle.__GetDriver_Internal(base.NativePtr));
		}

		// Token: 0x060089E9 RID: 35305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDriver_Internal(IntPtr @this, IntPtr InDriver);

		// Token: 0x060089EA RID: 35306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDriver_Internal(IntPtr @this);

		// Token: 0x060089EB RID: 35307 RVA: 0x000CFC98 File Offset: 0x000CDE98
		static UKuroAnimInstanceVehicle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroAnimInstanceVehicle");
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x000CFCA6 File Offset: 0x000CDEA6
		protected UKuroAnimInstanceVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BD3 RID: 15315
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroAnimInstanceVehicle";

		// Token: 0x04003BD4 RID: 15316
		private static IntPtr _ClassPtr;

		// Token: 0x04003BD5 RID: 15317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BD6 RID: 15318
		internal static int __PropertyOffset_LogicParams;

		// Token: 0x04003BD7 RID: 15319
		internal static int __PropertyOffset_BaseVehicle;

		// Token: 0x04003BD8 RID: 15320
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x04003BD9 RID: 15321
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04003BDA RID: 15322
		internal static int __PropertyOffset_bIsAutonomousProxy;

		// Token: 0x04003BDB RID: 15323
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04003BDC RID: 15324
		internal static int __PropertyOffset_bIsMovedLocation;

		// Token: 0x04003BDD RID: 15325
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04003BDE RID: 15326
		internal static int __PropertyOffset_ActorForward;

		// Token: 0x04003BDF RID: 15327
		internal static int __PropertyOffset_bHasDriver;
	}
}
