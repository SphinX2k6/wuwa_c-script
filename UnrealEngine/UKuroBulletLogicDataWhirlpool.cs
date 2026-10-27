using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016FE RID: 5886
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletLogicDataWhirlpool")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroBulletLogicDataWhirlpool : UKuroBulletLogicDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601542A RID: 87082 RVA: 0x001F3F8D File Offset: 0x001F218D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletLogicDataWhirlpool._ClassPtr;
		}

		// Token: 0x0601542B RID: 87083 RVA: 0x001F3F9C File Offset: 0x001F219C
		public UKuroBulletLogicDataWhirlpool() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletLogicDataWhirlpool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601542C RID: 87084 RVA: 0x001F3FC4 File Offset: 0x001F21C4
		[NullableContext(1)]
		public UKuroBulletLogicDataWhirlpool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletLogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x0601542D RID: 87085 RVA: 0x001F3FF7 File Offset: 0x001F21F7
		// (set) Token: 0x0601542E RID: 87086 RVA: 0x001F4007 File Offset: 0x001F2207
		public unsafe float MoveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_MoveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_MoveTime) = value;
			}
		}

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x0601542F RID: 87087 RVA: 0x001F4018 File Offset: 0x001F2218
		// (set) Token: 0x06015430 RID: 87088 RVA: 0x001F4028 File Offset: 0x001F2228
		public unsafe float WeightLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_WeightLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_WeightLimit) = value;
			}
		}

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x06015431 RID: 87089 RVA: 0x001F4039 File Offset: 0x001F2239
		// (set) Token: 0x06015432 RID: 87090 RVA: 0x001F4049 File Offset: 0x001F2249
		public unsafe EKuroBulletWhirlpoolVelocityCurveType VelocityCurve
		{
			get
			{
				return (EKuroBulletWhirlpoolVelocityCurveType)(*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_VelocityCurve));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_VelocityCurve) = (byte)value;
			}
		}

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x06015433 RID: 87091 RVA: 0x001F405A File Offset: 0x001F225A
		// (set) Token: 0x06015434 RID: 87092 RVA: 0x001F406E File Offset: 0x001F226E
		public unsafe FGameplayTag TagNeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_TagNeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_TagNeed) = value;
			}
		}

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x06015435 RID: 87093 RVA: 0x001F4083 File Offset: 0x001F2283
		// (set) Token: 0x06015436 RID: 87094 RVA: 0x001F4097 File Offset: 0x001F2297
		public unsafe FName AttackerSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_AttackerSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_AttackerSocketName) = value;
			}
		}

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x06015437 RID: 87095 RVA: 0x001F40AC File Offset: 0x001F22AC
		// (set) Token: 0x06015438 RID: 87096 RVA: 0x001F40BC File Offset: 0x001F22BC
		public unsafe bool CancelByHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_CancelByHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataWhirlpool.__PropertyOffset_CancelByHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015439 RID: 87097 RVA: 0x001F40CD File Offset: 0x001F22CD
		static UKuroBulletLogicDataWhirlpool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletLogicDataWhirlpool");
		}

		// Token: 0x0601543A RID: 87098 RVA: 0x001F40DB File Offset: 0x001F22DB
		protected UKuroBulletLogicDataWhirlpool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B977 RID: 47479
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletLogicDataWhirlpool";

		// Token: 0x0400B978 RID: 47480
		private static IntPtr _ClassPtr;

		// Token: 0x0400B979 RID: 47481
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B97A RID: 47482
		internal static int __PropertyOffset_MoveTime;

		// Token: 0x0400B97B RID: 47483
		internal static int __PropertyOffset_WeightLimit;

		// Token: 0x0400B97C RID: 47484
		internal static int __PropertyOffset_VelocityCurve;

		// Token: 0x0400B97D RID: 47485
		internal static int __PropertyOffset_TagNeed;

		// Token: 0x0400B97E RID: 47486
		internal static int __PropertyOffset_AttackerSocketName;

		// Token: 0x0400B97F RID: 47487
		internal static int __PropertyOffset_CancelByHit;
	}
}
