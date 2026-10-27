using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000992 RID: 2450
	[UnrealObjectPath("/Script/Engine.DamageType")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UDamageType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008A51 RID: 35409 RVA: 0x000C60BF File Offset: 0x000C42BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDamageType._ClassPtr;
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x000C60CC File Offset: 0x000C42CC
		public UDamageType() : this(BuiltinUtils.AllocNativeUObject(UDamageType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x000C60F4 File Offset: 0x000C42F4
		[NullableContext(1)]
		public UDamageType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDamageType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06008A54 RID: 35412 RVA: 0x000C6127 File Offset: 0x000C4327
		// (set) Token: 0x06008A55 RID: 35413 RVA: 0x000C6140 File Offset: 0x000C4340
		public unsafe bool bCausedByWorld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bCausedByWorld) & UDamageType.__PropertyMask_bCausedByWorld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDamageType.__PropertyOffset_bCausedByWorld) = ((*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bCausedByWorld) & ~UDamageType.__PropertyMask_bCausedByWorld) | (value ? UDamageType.__PropertyMask_bCausedByWorld : 0));
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06008A56 RID: 35414 RVA: 0x000C6170 File Offset: 0x000C4370
		// (set) Token: 0x06008A57 RID: 35415 RVA: 0x000C6189 File Offset: 0x000C4389
		public unsafe bool bScaleMomentumByMass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bScaleMomentumByMass) & UDamageType.__PropertyMask_bScaleMomentumByMass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDamageType.__PropertyOffset_bScaleMomentumByMass) = ((*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bScaleMomentumByMass) & ~UDamageType.__PropertyMask_bScaleMomentumByMass) | (value ? UDamageType.__PropertyMask_bScaleMomentumByMass : 0));
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06008A58 RID: 35416 RVA: 0x000C61B9 File Offset: 0x000C43B9
		// (set) Token: 0x06008A59 RID: 35417 RVA: 0x000C61D2 File Offset: 0x000C43D2
		public unsafe bool bRadialDamageVelChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bRadialDamageVelChange) & UDamageType.__PropertyMask_bRadialDamageVelChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDamageType.__PropertyOffset_bRadialDamageVelChange) = ((*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_bRadialDamageVelChange) & ~UDamageType.__PropertyMask_bRadialDamageVelChange) | (value ? UDamageType.__PropertyMask_bRadialDamageVelChange : 0));
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06008A5A RID: 35418 RVA: 0x000C6202 File Offset: 0x000C4402
		// (set) Token: 0x06008A5B RID: 35419 RVA: 0x000C6212 File Offset: 0x000C4412
		public unsafe float DamageImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DamageImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DamageImpulse) = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06008A5C RID: 35420 RVA: 0x000C6223 File Offset: 0x000C4423
		// (set) Token: 0x06008A5D RID: 35421 RVA: 0x000C6233 File Offset: 0x000C4433
		public unsafe float DestructibleImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DestructibleImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DestructibleImpulse) = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06008A5E RID: 35422 RVA: 0x000C6244 File Offset: 0x000C4444
		// (set) Token: 0x06008A5F RID: 35423 RVA: 0x000C6254 File Offset: 0x000C4454
		public unsafe float DestructibleDamageSpreadScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DestructibleDamageSpreadScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DestructibleDamageSpreadScale) = value;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06008A60 RID: 35424 RVA: 0x000C6265 File Offset: 0x000C4465
		// (set) Token: 0x06008A61 RID: 35425 RVA: 0x000C6275 File Offset: 0x000C4475
		public unsafe float DamageFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DamageFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDamageType.__PropertyOffset_DamageFalloff) = value;
			}
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x000C6286 File Offset: 0x000C4486
		static UDamageType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DamageType");
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x000C6294 File Offset: 0x000C4494
		protected UDamageType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041A9 RID: 16809
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DamageType";

		// Token: 0x040041AA RID: 16810
		private static IntPtr _ClassPtr;

		// Token: 0x040041AB RID: 16811
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041AC RID: 16812
		internal static int __PropertyOffset_bCausedByWorld;

		// Token: 0x040041AD RID: 16813
		internal static byte __PropertyMask_bCausedByWorld;

		// Token: 0x040041AE RID: 16814
		internal static int __PropertyOffset_bScaleMomentumByMass;

		// Token: 0x040041AF RID: 16815
		internal static byte __PropertyMask_bScaleMomentumByMass;

		// Token: 0x040041B0 RID: 16816
		internal static int __PropertyOffset_bRadialDamageVelChange;

		// Token: 0x040041B1 RID: 16817
		internal static byte __PropertyMask_bRadialDamageVelChange;

		// Token: 0x040041B2 RID: 16818
		internal static int __PropertyOffset_DamageImpulse;

		// Token: 0x040041B3 RID: 16819
		internal static int __PropertyOffset_DestructibleImpulse;

		// Token: 0x040041B4 RID: 16820
		internal static int __PropertyOffset_DestructibleDamageSpreadScale;

		// Token: 0x040041B5 RID: 16821
		internal static int __PropertyOffset_DamageFalloff;
	}
}
