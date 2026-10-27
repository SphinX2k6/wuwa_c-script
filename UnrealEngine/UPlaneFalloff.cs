using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B8 RID: 4792
	[UnrealObjectPath("/Script/FieldSystemEngine.PlaneFalloff")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UPlaneFalloff : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118BD RID: 71869 RVA: 0x0019BE90 File Offset: 0x0019A090
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlaneFalloff._ClassPtr;
		}

		// Token: 0x060118BE RID: 71870 RVA: 0x0019BE9C File Offset: 0x0019A09C
		public UPlaneFalloff() : this(BuiltinUtils.AllocNativeUObject(UPlaneFalloff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118BF RID: 71871 RVA: 0x0019BEC4 File Offset: 0x0019A0C4
		[NullableContext(1)]
		public UPlaneFalloff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlaneFalloff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x060118C0 RID: 71872 RVA: 0x0019BEF7 File Offset: 0x0019A0F7
		// (set) Token: 0x060118C1 RID: 71873 RVA: 0x0019BF07 File Offset: 0x0019A107
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x060118C2 RID: 71874 RVA: 0x0019BF18 File Offset: 0x0019A118
		// (set) Token: 0x060118C3 RID: 71875 RVA: 0x0019BF28 File Offset: 0x0019A128
		public unsafe float MinRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_MinRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_MinRange) = value;
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x060118C4 RID: 71876 RVA: 0x0019BF39 File Offset: 0x0019A139
		// (set) Token: 0x060118C5 RID: 71877 RVA: 0x0019BF49 File Offset: 0x0019A149
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x060118C6 RID: 71878 RVA: 0x0019BF5A File Offset: 0x0019A15A
		// (set) Token: 0x060118C7 RID: 71879 RVA: 0x0019BF6A File Offset: 0x0019A16A
		public unsafe float Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x060118C8 RID: 71880 RVA: 0x0019BF7B File Offset: 0x0019A17B
		// (set) Token: 0x060118C9 RID: 71881 RVA: 0x0019BF8B File Offset: 0x0019A18B
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x060118CA RID: 71882 RVA: 0x0019BF9C File Offset: 0x0019A19C
		// (set) Token: 0x060118CB RID: 71883 RVA: 0x0019BFB0 File Offset: 0x0019A1B0
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x060118CC RID: 71884 RVA: 0x0019BFC5 File Offset: 0x0019A1C5
		// (set) Token: 0x060118CD RID: 71885 RVA: 0x0019BFD9 File Offset: 0x0019A1D9
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x060118CE RID: 71886 RVA: 0x0019BFEE File Offset: 0x0019A1EE
		// (set) Token: 0x060118CF RID: 71887 RVA: 0x0019C002 File Offset: 0x0019A202
		public unsafe TEnumAsByte<EFieldFalloffType> Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneFalloff.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x060118D0 RID: 71888 RVA: 0x0019C018 File Offset: 0x0019A218
		[NullableContext(2)]
		public UPlaneFalloff SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, FVector Position, FVector Normal, EFieldFalloffType Falloff)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPlaneFalloff>(UPlaneFalloff.__SetPlaneFalloff_Internal(base.NativePtr, Magnitude, MinRange, MaxRange, Default, Distance, Position, Normal, Falloff));
		}

		// Token: 0x060118D1 RID: 71889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetPlaneFalloff_Internal(IntPtr @this, float Magnitude, float MinRange, float MaxRange, float Default, float Distance, FVector Position, FVector Normal, TEnumAsByte<EFieldFalloffType> Falloff);

		// Token: 0x060118D2 RID: 71890 RVA: 0x0019C047 File Offset: 0x0019A247
		static UPlaneFalloff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.PlaneFalloff");
		}

		// Token: 0x060118D3 RID: 71891 RVA: 0x0019C055 File Offset: 0x0019A255
		protected UPlaneFalloff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009663 RID: 38499
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.PlaneFalloff";

		// Token: 0x04009664 RID: 38500
		private static IntPtr _ClassPtr;

		// Token: 0x04009665 RID: 38501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009666 RID: 38502
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009667 RID: 38503
		internal static int __PropertyOffset_MinRange;

		// Token: 0x04009668 RID: 38504
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x04009669 RID: 38505
		internal static int __PropertyOffset_Default;

		// Token: 0x0400966A RID: 38506
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400966B RID: 38507
		internal static int __PropertyOffset_Position;

		// Token: 0x0400966C RID: 38508
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400966D RID: 38509
		internal static int __PropertyOffset_Falloff;
	}
}
