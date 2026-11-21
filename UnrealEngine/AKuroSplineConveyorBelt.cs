using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000403 RID: 1027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineConveyorBelt")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroSplineConveyorBelt : AKuroSplineCylinderTriggerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060064B3 RID: 25779 RVA: 0x0008FBF7 File Offset: 0x0008DDF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineConveyorBelt._ClassPtr;
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x0008FC04 File Offset: 0x0008DE04
		public AKuroSplineConveyorBelt() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineConveyorBelt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x0008FC2C File Offset: 0x0008DE2C
		public AKuroSplineConveyorBelt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineConveyorBelt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060064B6 RID: 25782 RVA: 0x0008FC5F File Offset: 0x0008DE5F
		// (set) Token: 0x060064B7 RID: 25783 RVA: 0x0008FC73 File Offset: 0x0008DE73
		[Nullable(2)]
		public unsafe USplineComponent SplineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineConveyorBelt.__PropertyOffset_SplineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineConveyorBelt.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x0008FC88 File Offset: 0x0008DE88
		// (set) Token: 0x060064B9 RID: 25785 RVA: 0x0008FC98 File Offset: 0x0008DE98
		public unsafe float ConveryWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveryWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveryWidth) = value;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060064BA RID: 25786 RVA: 0x0008FCA9 File Offset: 0x0008DEA9
		// (set) Token: 0x060064BB RID: 25787 RVA: 0x0008FCB9 File Offset: 0x0008DEB9
		public unsafe float ConveyorSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorSpeed) = value;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x0008FCCA File Offset: 0x0008DECA
		// (set) Token: 0x060064BD RID: 25789 RVA: 0x0008FCDA File Offset: 0x0008DEDA
		public unsafe float ConveyorAdsorbDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorAdsorbDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorAdsorbDistance) = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x0008FCEB File Offset: 0x0008DEEB
		// (set) Token: 0x060064BF RID: 25791 RVA: 0x0008FCFB File Offset: 0x0008DEFB
		public unsafe float ConveyorAdsorbSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorAdsorbSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ConveyorAdsorbSpeed) = value;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060064C0 RID: 25792 RVA: 0x0008FD0C File Offset: 0x0008DF0C
		// (set) Token: 0x060064C1 RID: 25793 RVA: 0x0008FD1C File Offset: 0x0008DF1C
		public unsafe bool bIsReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_bIsReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_bIsReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060064C2 RID: 25794 RVA: 0x0008FD30 File Offset: 0x0008DF30
		// (set) Token: 0x060064C3 RID: 25795 RVA: 0x0008FD69 File Offset: 0x0008DF69
		public TArray<AActor> IgnoreActorList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._IgnoreActorList) == null)
				{
					result = (this._IgnoreActorList = new TArray<AActor>(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_IgnoreActorList, this));
				}
				return result;
			}
			set
			{
				this.IgnoreActorList.CopyAssign(value);
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x0008FD77 File Offset: 0x0008DF77
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x0008FD87 File Offset: 0x0008DF87
		public unsafe float ReverseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ReverseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineConveyorBelt.__PropertyOffset_ReverseTime) = value;
			}
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0008FD98 File Offset: 0x0008DF98
		public void ToggleEnableConveyorBelt(bool Enable)
		{
			AKuroSplineConveyorBelt.__ToggleEnableConveyorBelt_Internal(base.NativePtr, Enable);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x0008FDA6 File Offset: 0x0008DFA6
		public void SetConveyorTriggerZScale(float ZScale)
		{
			AKuroSplineConveyorBelt.__SetConveyorTriggerZScale_Internal(base.NativePtr, ZScale);
		}

		// Token: 0x060064C8 RID: 25800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleEnableConveyorBelt_Internal(IntPtr @this, bool Enable);

		// Token: 0x060064C9 RID: 25801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConveyorTriggerZScale_Internal(IntPtr @this, float ZScale);

		// Token: 0x060064CA RID: 25802 RVA: 0x0008FDB4 File Offset: 0x0008DFB4
		static AKuroSplineConveyorBelt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineConveyorBelt");
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x0008FDC2 File Offset: 0x0008DFC2
		protected AKuroSplineConveyorBelt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A6A RID: 10858
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineConveyorBelt";

		// Token: 0x04002A6B RID: 10859
		private static IntPtr _ClassPtr;

		// Token: 0x04002A6C RID: 10860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A6D RID: 10861
		internal static int __PropertyOffset_SplineComponent;

		// Token: 0x04002A6E RID: 10862
		internal static int __PropertyOffset_ConveryWidth;

		// Token: 0x04002A6F RID: 10863
		internal static int __PropertyOffset_ConveyorSpeed;

		// Token: 0x04002A70 RID: 10864
		internal static int __PropertyOffset_ConveyorAdsorbDistance;

		// Token: 0x04002A71 RID: 10865
		internal static int __PropertyOffset_ConveyorAdsorbSpeed;

		// Token: 0x04002A72 RID: 10866
		internal static int __PropertyOffset_bIsReverse;

		// Token: 0x04002A73 RID: 10867
		internal static int __PropertyOffset_IgnoreActorList;

		// Token: 0x04002A74 RID: 10868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _IgnoreActorList;

		// Token: 0x04002A75 RID: 10869
		internal static int __PropertyOffset_ReverseTime;
	}
}
