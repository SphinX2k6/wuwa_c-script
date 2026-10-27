using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190E RID: 6414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineConveyorBelt")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroSplineConveyorBelt : AKuroSplineCylinderTriggerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017CE5 RID: 97509 RVA: 0x0022DE74 File Offset: 0x0022C074
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineConveyorBelt._ClassPtr;
		}

		// Token: 0x06017CE6 RID: 97510 RVA: 0x0022DE80 File Offset: 0x0022C080
		public AKuroSplineConveyorBelt() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineConveyorBelt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017CE7 RID: 97511 RVA: 0x0022DEA8 File Offset: 0x0022C0A8
		public AKuroSplineConveyorBelt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineConveyorBelt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x06017CE8 RID: 97512 RVA: 0x0022DEDB File Offset: 0x0022C0DB
		// (set) Token: 0x06017CE9 RID: 97513 RVA: 0x0022DEEF File Offset: 0x0022C0EF
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

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x06017CEA RID: 97514 RVA: 0x0022DF04 File Offset: 0x0022C104
		// (set) Token: 0x06017CEB RID: 97515 RVA: 0x0022DF14 File Offset: 0x0022C114
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

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x06017CEC RID: 97516 RVA: 0x0022DF25 File Offset: 0x0022C125
		// (set) Token: 0x06017CED RID: 97517 RVA: 0x0022DF35 File Offset: 0x0022C135
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

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x06017CEE RID: 97518 RVA: 0x0022DF46 File Offset: 0x0022C146
		// (set) Token: 0x06017CEF RID: 97519 RVA: 0x0022DF56 File Offset: 0x0022C156
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

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x06017CF0 RID: 97520 RVA: 0x0022DF67 File Offset: 0x0022C167
		// (set) Token: 0x06017CF1 RID: 97521 RVA: 0x0022DF77 File Offset: 0x0022C177
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

		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x06017CF2 RID: 97522 RVA: 0x0022DF88 File Offset: 0x0022C188
		// (set) Token: 0x06017CF3 RID: 97523 RVA: 0x0022DF98 File Offset: 0x0022C198
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

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x06017CF4 RID: 97524 RVA: 0x0022DFAC File Offset: 0x0022C1AC
		// (set) Token: 0x06017CF5 RID: 97525 RVA: 0x0022DFE5 File Offset: 0x0022C1E5
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

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x06017CF6 RID: 97526 RVA: 0x0022DFF3 File Offset: 0x0022C1F3
		// (set) Token: 0x06017CF7 RID: 97527 RVA: 0x0022E003 File Offset: 0x0022C203
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

		// Token: 0x06017CF8 RID: 97528 RVA: 0x0022E014 File Offset: 0x0022C214
		public void ToggleEnableConveyorBelt(bool Enable)
		{
			AKuroSplineConveyorBelt.__ToggleEnableConveyorBelt_Internal(base.NativePtr, Enable);
		}

		// Token: 0x06017CF9 RID: 97529 RVA: 0x0022E022 File Offset: 0x0022C222
		public void SetConveyorTriggerZScale(float ZScale)
		{
			AKuroSplineConveyorBelt.__SetConveyorTriggerZScale_Internal(base.NativePtr, ZScale);
		}

		// Token: 0x06017CFA RID: 97530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleEnableConveyorBelt_Internal(IntPtr @this, bool Enable);

		// Token: 0x06017CFB RID: 97531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConveyorTriggerZScale_Internal(IntPtr @this, float ZScale);

		// Token: 0x06017CFC RID: 97532 RVA: 0x0022E030 File Offset: 0x0022C230
		static AKuroSplineConveyorBelt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineConveyorBelt");
		}

		// Token: 0x06017CFD RID: 97533 RVA: 0x0022E03E File Offset: 0x0022C23E
		protected AKuroSplineConveyorBelt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE76 RID: 52854
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineConveyorBelt";

		// Token: 0x0400CE77 RID: 52855
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE78 RID: 52856
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE79 RID: 52857
		internal static int __PropertyOffset_SplineComponent;

		// Token: 0x0400CE7A RID: 52858
		internal static int __PropertyOffset_ConveryWidth;

		// Token: 0x0400CE7B RID: 52859
		internal static int __PropertyOffset_ConveyorSpeed;

		// Token: 0x0400CE7C RID: 52860
		internal static int __PropertyOffset_ConveyorAdsorbDistance;

		// Token: 0x0400CE7D RID: 52861
		internal static int __PropertyOffset_ConveyorAdsorbSpeed;

		// Token: 0x0400CE7E RID: 52862
		internal static int __PropertyOffset_bIsReverse;

		// Token: 0x0400CE7F RID: 52863
		internal static int __PropertyOffset_IgnoreActorList;

		// Token: 0x0400CE80 RID: 52864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _IgnoreActorList;

		// Token: 0x0400CE81 RID: 52865
		internal static int __PropertyOffset_ReverseTime;
	}
}
