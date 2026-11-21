using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200073B RID: 1851
	[UnrealObjectPath("/Script/LGUI.UIVerticalLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIVerticalLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A14A RID: 41290 RVA: 0x000EE849 File Offset: 0x000ECA49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIVerticalLayout._ClassPtr;
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x000EE858 File Offset: 0x000ECA58
		public UUIVerticalLayout() : this(BuiltinUtils.AllocNativeUObject(UUIVerticalLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x000EE880 File Offset: 0x000ECA80
		[NullableContext(1)]
		public UUIVerticalLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIVerticalLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x000EE8B3 File Offset: 0x000ECAB3
		// (set) Token: 0x0600A14E RID: 41294 RVA: 0x000EE8C7 File Offset: 0x000ECAC7
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x000EE8DC File Offset: 0x000ECADC
		// (set) Token: 0x0600A150 RID: 41296 RVA: 0x000EE8EC File Offset: 0x000ECAEC
		public unsafe float Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x000EE8FD File Offset: 0x000ECAFD
		// (set) Token: 0x0600A152 RID: 41298 RVA: 0x000EE90D File Offset: 0x000ECB0D
		public unsafe bool bAutoSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bAutoSpacing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bAutoSpacing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600A153 RID: 41299 RVA: 0x000EE91E File Offset: 0x000ECB1E
		// (set) Token: 0x0600A154 RID: 41300 RVA: 0x000EE92E File Offset: 0x000ECB2E
		public unsafe ELGUILayoutAlignmentType Align
		{
			get
			{
				return (ELGUILayoutAlignmentType)(*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Align));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_Align) = (byte)value;
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600A155 RID: 41301 RVA: 0x000EE93F File Offset: 0x000ECB3F
		// (set) Token: 0x0600A156 RID: 41302 RVA: 0x000EE94F File Offset: 0x000ECB4F
		public unsafe bool ExpendChildrenWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_ExpendChildrenWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_ExpendChildrenWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x000EE960 File Offset: 0x000ECB60
		// (set) Token: 0x0600A158 RID: 41304 RVA: 0x000EE970 File Offset: 0x000ECB70
		public unsafe bool bControlWidthCalculatedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bControlWidthCalculatedScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bControlWidthCalculatedScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x0600A159 RID: 41305 RVA: 0x000EE981 File Offset: 0x000ECB81
		// (set) Token: 0x0600A15A RID: 41306 RVA: 0x000EE991 File Offset: 0x000ECB91
		public unsafe bool bExcludeHeightZeroSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bExcludeHeightZeroSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bExcludeHeightZeroSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x0600A15B RID: 41307 RVA: 0x000EE9A2 File Offset: 0x000ECBA2
		// (set) Token: 0x0600A15C RID: 41308 RVA: 0x000EE9B2 File Offset: 0x000ECBB2
		public unsafe bool ExpendChildrenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_ExpendChildrenHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_ExpendChildrenHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x0600A15D RID: 41309 RVA: 0x000EE9C3 File Offset: 0x000ECBC3
		// (set) Token: 0x0600A15E RID: 41310 RVA: 0x000EE9D3 File Offset: 0x000ECBD3
		public unsafe bool bControlHeightCalculatedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bControlHeightCalculatedScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_bControlHeightCalculatedScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x0600A15F RID: 41311 RVA: 0x000EE9E4 File Offset: 0x000ECBE4
		// (set) Token: 0x0600A160 RID: 41312 RVA: 0x000EE9F4 File Offset: 0x000ECBF4
		public unsafe bool HeightFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_HeightFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_HeightFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600A161 RID: 41313 RVA: 0x000EEA05 File Offset: 0x000ECC05
		// (set) Token: 0x0600A162 RID: 41314 RVA: 0x000EEA15 File Offset: 0x000ECC15
		public unsafe bool WidthFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_WidthFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIVerticalLayout.__PropertyOffset_WidthFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x000EEA26 File Offset: 0x000ECC26
		public void SetWidthFitToChildren(bool value)
		{
			UUIVerticalLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x000EEA34 File Offset: 0x000ECC34
		public void SetSpacing(float value)
		{
			UUIVerticalLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x000EEA42 File Offset: 0x000ECC42
		public void SetPadding(FMargin value)
		{
			UUIVerticalLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x000EEA50 File Offset: 0x000ECC50
		public void SetHeightFitToChildren(bool value)
		{
			UUIVerticalLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x000EEA5E File Offset: 0x000ECC5E
		public void SetExpendChildrenWidth(bool value)
		{
			UUIVerticalLayout.__SetExpendChildrenWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x000EEA6C File Offset: 0x000ECC6C
		public void SetExpendChildrenHeight(bool value)
		{
			UUIVerticalLayout.__SetExpendChildrenHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x000EEA7A File Offset: 0x000ECC7A
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIVerticalLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x000EEA88 File Offset: 0x000ECC88
		public bool GetWidthFitToChildren()
		{
			return UUIVerticalLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x000EEA95 File Offset: 0x000ECC95
		public float GetSpacing()
		{
			return UUIVerticalLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x000EEAA2 File Offset: 0x000ECCA2
		public FMargin GetPadding()
		{
			return UUIVerticalLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x000EEAAF File Offset: 0x000ECCAF
		public bool GetHeightFitToChildren()
		{
			return UUIVerticalLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x000EEABC File Offset: 0x000ECCBC
		public bool GetExpendChildrenWidth()
		{
			return UUIVerticalLayout.__GetExpendChildrenWidth_Internal(base.NativePtr);
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x000EEAC9 File Offset: 0x000ECCC9
		public bool GetExpendChildrenHeight()
		{
			return UUIVerticalLayout.__GetExpendChildrenHeight_Internal(base.NativePtr);
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x000EEAD6 File Offset: 0x000ECCD6
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIVerticalLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x000EEAE3 File Offset: 0x000ECCE3
		public float GetActuralRange()
		{
			return UUIVerticalLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x0600A172 RID: 41330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x0600A173 RID: 41331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, float value);

		// Token: 0x0600A174 RID: 41332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x0600A175 RID: 41333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x0600A176 RID: 41334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenWidth_Internal(IntPtr @this, bool value);

		// Token: 0x0600A177 RID: 41335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenHeight_Internal(IntPtr @this, bool value);

		// Token: 0x0600A178 RID: 41336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x0600A179 RID: 41337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x0600A17A RID: 41338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpacing_Internal(IntPtr @this);

		// Token: 0x0600A17B RID: 41339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x0600A17C RID: 41340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x0600A17D RID: 41341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenWidth_Internal(IntPtr @this);

		// Token: 0x0600A17E RID: 41342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenHeight_Internal(IntPtr @this);

		// Token: 0x0600A17F RID: 41343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x0600A180 RID: 41344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x0600A181 RID: 41345 RVA: 0x000EEAF0 File Offset: 0x000ECCF0
		static UUIVerticalLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIVerticalLayout");
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x000EEAFE File Offset: 0x000ECCFE
		protected UUIVerticalLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004519 RID: 17689
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIVerticalLayout";

		// Token: 0x0400451A RID: 17690
		private static IntPtr _ClassPtr;

		// Token: 0x0400451B RID: 17691
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400451C RID: 17692
		internal static int __PropertyOffset_Padding;

		// Token: 0x0400451D RID: 17693
		internal static int __PropertyOffset_Spacing;

		// Token: 0x0400451E RID: 17694
		internal static int __PropertyOffset_bAutoSpacing;

		// Token: 0x0400451F RID: 17695
		internal static int __PropertyOffset_Align;

		// Token: 0x04004520 RID: 17696
		internal static int __PropertyOffset_ExpendChildrenWidth;

		// Token: 0x04004521 RID: 17697
		internal static int __PropertyOffset_bControlWidthCalculatedScale;

		// Token: 0x04004522 RID: 17698
		internal static int __PropertyOffset_bExcludeHeightZeroSpace;

		// Token: 0x04004523 RID: 17699
		internal static int __PropertyOffset_ExpendChildrenHeight;

		// Token: 0x04004524 RID: 17700
		internal static int __PropertyOffset_bControlHeightCalculatedScale;

		// Token: 0x04004525 RID: 17701
		internal static int __PropertyOffset_HeightFitToChildren;

		// Token: 0x04004526 RID: 17702
		internal static int __PropertyOffset_WidthFitToChildren;
	}
}
