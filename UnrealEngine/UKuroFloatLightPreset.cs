using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AFE RID: 6910
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightPreset")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UKuroFloatLightPreset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019D53 RID: 105811 RVA: 0x00262594 File Offset: 0x00260794
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFloatLightPreset._ClassPtr;
		}

		// Token: 0x06019D54 RID: 105812 RVA: 0x002625A0 File Offset: 0x002607A0
		public UKuroFloatLightPreset() : this(BuiltinUtils.AllocNativeUObject(UKuroFloatLightPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019D55 RID: 105813 RVA: 0x002625C8 File Offset: 0x002607C8
		public UKuroFloatLightPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFloatLightPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700676B RID: 26475
		// (get) Token: 0x06019D56 RID: 105814 RVA: 0x002625FB File Offset: 0x002607FB
		// (set) Token: 0x06019D57 RID: 105815 RVA: 0x0026260B File Offset: 0x0026080B
		public unsafe float BaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_BaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_BaseIntensity) = value;
			}
		}

		// Token: 0x1700676C RID: 26476
		// (get) Token: 0x06019D58 RID: 105816 RVA: 0x0026261C File Offset: 0x0026081C
		// (set) Token: 0x06019D59 RID: 105817 RVA: 0x00262655 File Offset: 0x00260855
		public FKuroCurveFloat IntensityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._IntensityCurve) == null)
				{
					result = (this._IntensityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_IntensityCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_IntensityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700676D RID: 26477
		// (get) Token: 0x06019D5A RID: 105818 RVA: 0x00262676 File Offset: 0x00260876
		// (set) Token: 0x06019D5B RID: 105819 RVA: 0x00262686 File Offset: 0x00260886
		public unsafe float FlickSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_FlickSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_FlickSpeed) = value;
			}
		}

		// Token: 0x1700676E RID: 26478
		// (get) Token: 0x06019D5C RID: 105820 RVA: 0x00262697 File Offset: 0x00260897
		// (set) Token: 0x06019D5D RID: 105821 RVA: 0x002626A7 File Offset: 0x002608A7
		public unsafe EFloatLightMovement Movement
		{
			get
			{
				return (EFloatLightMovement)(*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_Movement));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_Movement) = (byte)value;
			}
		}

		// Token: 0x1700676F RID: 26479
		// (get) Token: 0x06019D5E RID: 105822 RVA: 0x002626B8 File Offset: 0x002608B8
		// (set) Token: 0x06019D5F RID: 105823 RVA: 0x002626F1 File Offset: 0x002608F1
		public FKuroCurveFloat MovementCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MovementCurve) == null)
				{
					result = (this._MovementCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006770 RID: 26480
		// (get) Token: 0x06019D60 RID: 105824 RVA: 0x00262712 File Offset: 0x00260912
		// (set) Token: 0x06019D61 RID: 105825 RVA: 0x00262722 File Offset: 0x00260922
		public unsafe float MovementPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementPeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementPeriod) = value;
			}
		}

		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x06019D62 RID: 105826 RVA: 0x00262733 File Offset: 0x00260933
		// (set) Token: 0x06019D63 RID: 105827 RVA: 0x00262743 File Offset: 0x00260943
		public unsafe float MovementPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementPhase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_MovementPhase) = value;
			}
		}

		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x06019D64 RID: 105828 RVA: 0x00262754 File Offset: 0x00260954
		// (set) Token: 0x06019D65 RID: 105829 RVA: 0x00262764 File Offset: 0x00260964
		public unsafe float SwingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_SwingRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_SwingRadius) = value;
			}
		}

		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x06019D66 RID: 105830 RVA: 0x00262775 File Offset: 0x00260975
		// (set) Token: 0x06019D67 RID: 105831 RVA: 0x00262785 File Offset: 0x00260985
		public unsafe float SwingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_SwingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_SwingRange) = value;
			}
		}

		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x06019D68 RID: 105832 RVA: 0x00262796 File Offset: 0x00260996
		// (set) Token: 0x06019D69 RID: 105833 RVA: 0x002627A6 File Offset: 0x002609A6
		public unsafe float JumpDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_JumpDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_JumpDistance) = value;
			}
		}

		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x06019D6A RID: 105834 RVA: 0x002627B7 File Offset: 0x002609B7
		// (set) Token: 0x06019D6B RID: 105835 RVA: 0x002627C7 File Offset: 0x002609C7
		public unsafe float JumpHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_JumpHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFloatLightPreset.__PropertyOffset_JumpHeight) = value;
			}
		}

		// Token: 0x06019D6C RID: 105836 RVA: 0x002627D8 File Offset: 0x002609D8
		static UKuroFloatLightPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightPreset");
		}

		// Token: 0x06019D6D RID: 105837 RVA: 0x002627E6 File Offset: 0x002609E6
		protected UKuroFloatLightPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E0C1 RID: 57537
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightPreset";

		// Token: 0x0400E0C2 RID: 57538
		private static IntPtr _ClassPtr;

		// Token: 0x0400E0C3 RID: 57539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E0C4 RID: 57540
		internal static int __PropertyOffset_BaseIntensity;

		// Token: 0x0400E0C5 RID: 57541
		internal static int __PropertyOffset_IntensityCurve;

		// Token: 0x0400E0C6 RID: 57542
		[Nullable(2)]
		private FKuroCurveFloat _IntensityCurve;

		// Token: 0x0400E0C7 RID: 57543
		internal static int __PropertyOffset_FlickSpeed;

		// Token: 0x0400E0C8 RID: 57544
		internal static int __PropertyOffset_Movement;

		// Token: 0x0400E0C9 RID: 57545
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x0400E0CA RID: 57546
		[Nullable(2)]
		private FKuroCurveFloat _MovementCurve;

		// Token: 0x0400E0CB RID: 57547
		internal static int __PropertyOffset_MovementPeriod;

		// Token: 0x0400E0CC RID: 57548
		internal static int __PropertyOffset_MovementPhase;

		// Token: 0x0400E0CD RID: 57549
		internal static int __PropertyOffset_SwingRadius;

		// Token: 0x0400E0CE RID: 57550
		internal static int __PropertyOffset_SwingRange;

		// Token: 0x0400E0CF RID: 57551
		internal static int __PropertyOffset_JumpDistance;

		// Token: 0x0400E0D0 RID: 57552
		internal static int __PropertyOffset_JumpHeight;
	}
}
