using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA4 RID: 7588
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Random")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_DA_Move_Random : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D045 RID: 118853 RVA: 0x002AE2FF File Offset: 0x002AC4FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Random._ClassPtr;
		}

		// Token: 0x0601D046 RID: 118854 RVA: 0x002AE30C File Offset: 0x002AC50C
		public UKSC_DA_Move_Random() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D047 RID: 118855 RVA: 0x002AE334 File Offset: 0x002AC534
		[NullableContext(1)]
		public UKSC_DA_Move_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700750E RID: 29966
		// (get) Token: 0x0601D048 RID: 118856 RVA: 0x002AE367 File Offset: 0x002AC567
		// (set) Token: 0x0601D049 RID: 118857 RVA: 0x002AE377 File Offset: 0x002AC577
		public unsafe float MinInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MinInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MinInterval) = value;
			}
		}

		// Token: 0x1700750F RID: 29967
		// (get) Token: 0x0601D04A RID: 118858 RVA: 0x002AE388 File Offset: 0x002AC588
		// (set) Token: 0x0601D04B RID: 118859 RVA: 0x002AE398 File Offset: 0x002AC598
		public unsafe float MaxInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MaxInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MaxInterval) = value;
			}
		}

		// Token: 0x17007510 RID: 29968
		// (get) Token: 0x0601D04C RID: 118860 RVA: 0x002AE3A9 File Offset: 0x002AC5A9
		// (set) Token: 0x0601D04D RID: 118861 RVA: 0x002AE3B9 File Offset: 0x002AC5B9
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MinDistance) = value;
			}
		}

		// Token: 0x17007511 RID: 29969
		// (get) Token: 0x0601D04E RID: 118862 RVA: 0x002AE3CA File Offset: 0x002AC5CA
		// (set) Token: 0x0601D04F RID: 118863 RVA: 0x002AE3DA File Offset: 0x002AC5DA
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17007512 RID: 29970
		// (get) Token: 0x0601D050 RID: 118864 RVA: 0x002AE3EB File Offset: 0x002AC5EB
		// (set) Token: 0x0601D051 RID: 118865 RVA: 0x002AE3FB File Offset: 0x002AC5FB
		public unsafe float DegSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_DegSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Random.__PropertyOffset_DegSpeed) = value;
			}
		}

		// Token: 0x0601D052 RID: 118866 RVA: 0x002AE40C File Offset: 0x002AC60C
		static UKSC_DA_Move_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Random");
		}

		// Token: 0x0601D053 RID: 118867 RVA: 0x002AE41A File Offset: 0x002AC61A
		protected UKSC_DA_Move_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC04 RID: 64516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Random";

		// Token: 0x0400FC05 RID: 64517
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC06 RID: 64518
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC07 RID: 64519
		internal static int __PropertyOffset_MinInterval;

		// Token: 0x0400FC08 RID: 64520
		internal static int __PropertyOffset_MaxInterval;

		// Token: 0x0400FC09 RID: 64521
		internal static int __PropertyOffset_MinDistance;

		// Token: 0x0400FC0A RID: 64522
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400FC0B RID: 64523
		internal static int __PropertyOffset_DegSpeed;
	}
}
