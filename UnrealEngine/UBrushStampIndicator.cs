using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200153C RID: 5436
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BrushStampIndicator")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UBrushStampIndicator : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BC8 RID: 80840 RVA: 0x001CFB71 File Offset: 0x001CDD71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushStampIndicator._ClassPtr;
		}

		// Token: 0x06013BC9 RID: 80841 RVA: 0x001CFB80 File Offset: 0x001CDD80
		public UBrushStampIndicator() : this(BuiltinUtils.AllocNativeUObject(UBrushStampIndicator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BCA RID: 80842 RVA: 0x001CFBA8 File Offset: 0x001CDDA8
		[NullableContext(1)]
		public UBrushStampIndicator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushStampIndicator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x06013BCB RID: 80843 RVA: 0x001CFBDB File Offset: 0x001CDDDB
		// (set) Token: 0x06013BCC RID: 80844 RVA: 0x001CFBEB File Offset: 0x001CDDEB
		public unsafe float BrushRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushRadius) = value;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x06013BCD RID: 80845 RVA: 0x001CFBFC File Offset: 0x001CDDFC
		// (set) Token: 0x06013BCE RID: 80846 RVA: 0x001CFC0C File Offset: 0x001CDE0C
		public unsafe float BrushFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushFalloff) = value;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x06013BCF RID: 80847 RVA: 0x001CFC1D File Offset: 0x001CDE1D
		// (set) Token: 0x06013BD0 RID: 80848 RVA: 0x001CFC31 File Offset: 0x001CDE31
		public unsafe FVector BrushPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushPosition) = value;
			}
		}

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x06013BD1 RID: 80849 RVA: 0x001CFC46 File Offset: 0x001CDE46
		// (set) Token: 0x06013BD2 RID: 80850 RVA: 0x001CFC5A File Offset: 0x001CDE5A
		public unsafe FVector BrushNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_BrushNormal) = value;
			}
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x06013BD3 RID: 80851 RVA: 0x001CFC6F File Offset: 0x001CDE6F
		// (set) Token: 0x06013BD4 RID: 80852 RVA: 0x001CFC7F File Offset: 0x001CDE7F
		public unsafe bool bDrawIndicatorLines
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawIndicatorLines) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawIndicatorLines) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x06013BD5 RID: 80853 RVA: 0x001CFC90 File Offset: 0x001CDE90
		// (set) Token: 0x06013BD6 RID: 80854 RVA: 0x001CFCA0 File Offset: 0x001CDEA0
		public unsafe bool bDrawRadiusCircle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawRadiusCircle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawRadiusCircle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06013BD7 RID: 80855 RVA: 0x001CFCB1 File Offset: 0x001CDEB1
		// (set) Token: 0x06013BD8 RID: 80856 RVA: 0x001CFCC1 File Offset: 0x001CDEC1
		public unsafe int SampleStepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SampleStepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SampleStepCount) = value;
			}
		}

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06013BD9 RID: 80857 RVA: 0x001CFCD2 File Offset: 0x001CDED2
		// (set) Token: 0x06013BDA RID: 80858 RVA: 0x001CFCE6 File Offset: 0x001CDEE6
		public unsafe FLinearColor LineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_LineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_LineColor) = value;
			}
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06013BDB RID: 80859 RVA: 0x001CFCFB File Offset: 0x001CDEFB
		// (set) Token: 0x06013BDC RID: 80860 RVA: 0x001CFD0B File Offset: 0x001CDF0B
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x06013BDD RID: 80861 RVA: 0x001CFD1C File Offset: 0x001CDF1C
		// (set) Token: 0x06013BDE RID: 80862 RVA: 0x001CFD2C File Offset: 0x001CDF2C
		public unsafe bool bDepthTested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDepthTested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDepthTested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x06013BDF RID: 80863 RVA: 0x001CFD3D File Offset: 0x001CDF3D
		// (set) Token: 0x06013BE0 RID: 80864 RVA: 0x001CFD4D File Offset: 0x001CDF4D
		public unsafe bool bDrawSecondaryLines
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawSecondaryLines) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_bDrawSecondaryLines) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x06013BE1 RID: 80865 RVA: 0x001CFD5E File Offset: 0x001CDF5E
		// (set) Token: 0x06013BE2 RID: 80866 RVA: 0x001CFD6E File Offset: 0x001CDF6E
		public unsafe float SecondaryLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SecondaryLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SecondaryLineThickness) = value;
			}
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x06013BE3 RID: 80867 RVA: 0x001CFD7F File Offset: 0x001CDF7F
		// (set) Token: 0x06013BE4 RID: 80868 RVA: 0x001CFD93 File Offset: 0x001CDF93
		public unsafe FLinearColor SecondaryLineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SecondaryLineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushStampIndicator.__PropertyOffset_SecondaryLineColor) = value;
			}
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x06013BE5 RID: 80869 RVA: 0x001CFDA8 File Offset: 0x001CDFA8
		// (set) Token: 0x06013BE6 RID: 80870 RVA: 0x001CFDBC File Offset: 0x001CDFBC
		[Nullable(2)]
		public unsafe UPrimitiveComponent AttachedComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBrushStampIndicator.__PropertyOffset_AttachedComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrushStampIndicator.__PropertyOffset_AttachedComponent, value);
			}
		}

		// Token: 0x06013BE7 RID: 80871 RVA: 0x001CFDD1 File Offset: 0x001CDFD1
		static UBrushStampIndicator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.BrushStampIndicator");
		}

		// Token: 0x06013BE8 RID: 80872 RVA: 0x001CFDDF File Offset: 0x001CDFDF
		protected UBrushStampIndicator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AACE RID: 43726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.BrushStampIndicator";

		// Token: 0x0400AACF RID: 43727
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAD0 RID: 43728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAD1 RID: 43729
		internal static int __PropertyOffset_BrushRadius;

		// Token: 0x0400AAD2 RID: 43730
		internal static int __PropertyOffset_BrushFalloff;

		// Token: 0x0400AAD3 RID: 43731
		internal static int __PropertyOffset_BrushPosition;

		// Token: 0x0400AAD4 RID: 43732
		internal static int __PropertyOffset_BrushNormal;

		// Token: 0x0400AAD5 RID: 43733
		internal static int __PropertyOffset_bDrawIndicatorLines;

		// Token: 0x0400AAD6 RID: 43734
		internal static int __PropertyOffset_bDrawRadiusCircle;

		// Token: 0x0400AAD7 RID: 43735
		internal static int __PropertyOffset_SampleStepCount;

		// Token: 0x0400AAD8 RID: 43736
		internal static int __PropertyOffset_LineColor;

		// Token: 0x0400AAD9 RID: 43737
		internal static int __PropertyOffset_LineThickness;

		// Token: 0x0400AADA RID: 43738
		internal static int __PropertyOffset_bDepthTested;

		// Token: 0x0400AADB RID: 43739
		internal static int __PropertyOffset_bDrawSecondaryLines;

		// Token: 0x0400AADC RID: 43740
		internal static int __PropertyOffset_SecondaryLineThickness;

		// Token: 0x0400AADD RID: 43741
		internal static int __PropertyOffset_SecondaryLineColor;

		// Token: 0x0400AADE RID: 43742
		internal static int __PropertyOffset_AttachedComponent;
	}
}
