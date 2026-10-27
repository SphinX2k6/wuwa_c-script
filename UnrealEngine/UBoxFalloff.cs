using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AA RID: 4778
	[UnrealObjectPath("/Script/FieldSystemEngine.BoxFalloff")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UBoxFalloff : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601182F RID: 71727 RVA: 0x0019B255 File Offset: 0x00199455
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoxFalloff._ClassPtr;
		}

		// Token: 0x06011830 RID: 71728 RVA: 0x0019B264 File Offset: 0x00199464
		public UBoxFalloff() : this(BuiltinUtils.AllocNativeUObject(UBoxFalloff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011831 RID: 71729 RVA: 0x0019B28C File Offset: 0x0019948C
		[NullableContext(1)]
		public UBoxFalloff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoxFalloff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x06011832 RID: 71730 RVA: 0x0019B2BF File Offset: 0x001994BF
		// (set) Token: 0x06011833 RID: 71731 RVA: 0x0019B2CF File Offset: 0x001994CF
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x06011834 RID: 71732 RVA: 0x0019B2E0 File Offset: 0x001994E0
		// (set) Token: 0x06011835 RID: 71733 RVA: 0x0019B2F0 File Offset: 0x001994F0
		public unsafe float MinRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_MinRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_MinRange) = value;
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x06011836 RID: 71734 RVA: 0x0019B301 File Offset: 0x00199501
		// (set) Token: 0x06011837 RID: 71735 RVA: 0x0019B311 File Offset: 0x00199511
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x06011838 RID: 71736 RVA: 0x0019B322 File Offset: 0x00199522
		// (set) Token: 0x06011839 RID: 71737 RVA: 0x0019B332 File Offset: 0x00199532
		public unsafe float Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x0601183A RID: 71738 RVA: 0x0019B343 File Offset: 0x00199543
		// (set) Token: 0x0601183B RID: 71739 RVA: 0x0019B357 File Offset: 0x00199557
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x0601183C RID: 71740 RVA: 0x0019B36C File Offset: 0x0019956C
		// (set) Token: 0x0601183D RID: 71741 RVA: 0x0019B380 File Offset: 0x00199580
		public unsafe TEnumAsByte<EFieldFalloffType> Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxFalloff.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x0601183E RID: 71742 RVA: 0x0019B398 File Offset: 0x00199598
		[NullableContext(2)]
		public unsafe UBoxFalloff SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, FTransform Transform, EFieldFalloffType Falloff)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBoxFalloff>(UBoxFalloff.__SetBoxFalloff_Internal(base.NativePtr, Magnitude, MinRange, MaxRange, Default, ptr, Falloff));
		}

		// Token: 0x0601183F RID: 71743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetBoxFalloff_Internal(IntPtr @this, float Magnitude, float MinRange, float MaxRange, float Default, in FTransform Transform, TEnumAsByte<EFieldFalloffType> Falloff);

		// Token: 0x06011840 RID: 71744 RVA: 0x0019B3DA File Offset: 0x001995DA
		static UBoxFalloff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.BoxFalloff");
		}

		// Token: 0x06011841 RID: 71745 RVA: 0x0019B3E8 File Offset: 0x001995E8
		protected UBoxFalloff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009623 RID: 38435
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.BoxFalloff";

		// Token: 0x04009624 RID: 38436
		private static IntPtr _ClassPtr;

		// Token: 0x04009625 RID: 38437
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009626 RID: 38438
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009627 RID: 38439
		internal static int __PropertyOffset_MinRange;

		// Token: 0x04009628 RID: 38440
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x04009629 RID: 38441
		internal static int __PropertyOffset_Default;

		// Token: 0x0400962A RID: 38442
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400962B RID: 38443
		internal static int __PropertyOffset_Falloff;
	}
}
