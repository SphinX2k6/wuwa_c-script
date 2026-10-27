using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002177 RID: 8567
	[UnrealObjectPath("/Script/LGUI.UIHorizontalLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIHorizontalLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205C0 RID: 132544 RVA: 0x0030090A File Offset: 0x002FEB0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIHorizontalLayout._ClassPtr;
		}

		// Token: 0x060205C1 RID: 132545 RVA: 0x00300918 File Offset: 0x002FEB18
		public UUIHorizontalLayout() : this(BuiltinUtils.AllocNativeUObject(UUIHorizontalLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205C2 RID: 132546 RVA: 0x00300940 File Offset: 0x002FEB40
		[NullableContext(1)]
		public UUIHorizontalLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIHorizontalLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007ED2 RID: 32466
		// (get) Token: 0x060205C3 RID: 132547 RVA: 0x00300973 File Offset: 0x002FEB73
		// (set) Token: 0x060205C4 RID: 132548 RVA: 0x00300987 File Offset: 0x002FEB87
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17007ED3 RID: 32467
		// (get) Token: 0x060205C5 RID: 132549 RVA: 0x0030099C File Offset: 0x002FEB9C
		// (set) Token: 0x060205C6 RID: 132550 RVA: 0x003009AC File Offset: 0x002FEBAC
		public unsafe float Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17007ED4 RID: 32468
		// (get) Token: 0x060205C7 RID: 132551 RVA: 0x003009BD File Offset: 0x002FEBBD
		// (set) Token: 0x060205C8 RID: 132552 RVA: 0x003009CD File Offset: 0x002FEBCD
		public unsafe bool bAutoSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bAutoSpacing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bAutoSpacing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ED5 RID: 32469
		// (get) Token: 0x060205C9 RID: 132553 RVA: 0x003009DE File Offset: 0x002FEBDE
		// (set) Token: 0x060205CA RID: 132554 RVA: 0x003009EE File Offset: 0x002FEBEE
		public unsafe ELGUILayoutAlignmentType Align
		{
			get
			{
				return (ELGUILayoutAlignmentType)(*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Align));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_Align) = (byte)value;
			}
		}

		// Token: 0x17007ED6 RID: 32470
		// (get) Token: 0x060205CB RID: 132555 RVA: 0x003009FF File Offset: 0x002FEBFF
		// (set) Token: 0x060205CC RID: 132556 RVA: 0x00300A0F File Offset: 0x002FEC0F
		public unsafe bool ExpendChildrenWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_ExpendChildrenWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_ExpendChildrenWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ED7 RID: 32471
		// (get) Token: 0x060205CD RID: 132557 RVA: 0x00300A20 File Offset: 0x002FEC20
		// (set) Token: 0x060205CE RID: 132558 RVA: 0x00300A30 File Offset: 0x002FEC30
		public unsafe bool bControlWidthCalculatedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bControlWidthCalculatedScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bControlWidthCalculatedScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ED8 RID: 32472
		// (get) Token: 0x060205CF RID: 132559 RVA: 0x00300A41 File Offset: 0x002FEC41
		// (set) Token: 0x060205D0 RID: 132560 RVA: 0x00300A51 File Offset: 0x002FEC51
		public unsafe bool bExcludeWidthZeroSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bExcludeWidthZeroSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bExcludeWidthZeroSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ED9 RID: 32473
		// (get) Token: 0x060205D1 RID: 132561 RVA: 0x00300A62 File Offset: 0x002FEC62
		// (set) Token: 0x060205D2 RID: 132562 RVA: 0x00300A72 File Offset: 0x002FEC72
		public unsafe bool ExpendChildrenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_ExpendChildrenHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_ExpendChildrenHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EDA RID: 32474
		// (get) Token: 0x060205D3 RID: 132563 RVA: 0x00300A83 File Offset: 0x002FEC83
		// (set) Token: 0x060205D4 RID: 132564 RVA: 0x00300A93 File Offset: 0x002FEC93
		public unsafe bool bControlHeightCalculatedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bControlHeightCalculatedScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_bControlHeightCalculatedScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EDB RID: 32475
		// (get) Token: 0x060205D5 RID: 132565 RVA: 0x00300AA4 File Offset: 0x002FECA4
		// (set) Token: 0x060205D6 RID: 132566 RVA: 0x00300AB4 File Offset: 0x002FECB4
		public unsafe bool WidthFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_WidthFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_WidthFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EDC RID: 32476
		// (get) Token: 0x060205D7 RID: 132567 RVA: 0x00300AC5 File Offset: 0x002FECC5
		// (set) Token: 0x060205D8 RID: 132568 RVA: 0x00300AD5 File Offset: 0x002FECD5
		public unsafe bool HeightFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_HeightFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIHorizontalLayout.__PropertyOffset_HeightFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x060205D9 RID: 132569 RVA: 0x00300AE6 File Offset: 0x002FECE6
		public void SetWidthFitToChildren(bool value)
		{
			UUIHorizontalLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DA RID: 132570 RVA: 0x00300AF4 File Offset: 0x002FECF4
		public void SetSpacing(float value)
		{
			UUIHorizontalLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DB RID: 132571 RVA: 0x00300B02 File Offset: 0x002FED02
		public void SetPadding(FMargin value)
		{
			UUIHorizontalLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DC RID: 132572 RVA: 0x00300B10 File Offset: 0x002FED10
		public void SetHeightFitToChildren(bool value)
		{
			UUIHorizontalLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DD RID: 132573 RVA: 0x00300B1E File Offset: 0x002FED1E
		public void SetExpendChildrenWidth(bool value)
		{
			UUIHorizontalLayout.__SetExpendChildrenWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DE RID: 132574 RVA: 0x00300B2C File Offset: 0x002FED2C
		public void SetExpendChildrenHeight(bool value)
		{
			UUIHorizontalLayout.__SetExpendChildrenHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x060205DF RID: 132575 RVA: 0x00300B3A File Offset: 0x002FED3A
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIHorizontalLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x060205E0 RID: 132576 RVA: 0x00300B48 File Offset: 0x002FED48
		public bool GetWidthFitToChildren()
		{
			return UUIHorizontalLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060205E1 RID: 132577 RVA: 0x00300B55 File Offset: 0x002FED55
		public float GetSpacing()
		{
			return UUIHorizontalLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x060205E2 RID: 132578 RVA: 0x00300B62 File Offset: 0x002FED62
		public FMargin GetPadding()
		{
			return UUIHorizontalLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x060205E3 RID: 132579 RVA: 0x00300B6F File Offset: 0x002FED6F
		public bool GetHeightFitToChildren()
		{
			return UUIHorizontalLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060205E4 RID: 132580 RVA: 0x00300B7C File Offset: 0x002FED7C
		public bool GetExpendChildrenWidth()
		{
			return UUIHorizontalLayout.__GetExpendChildrenWidth_Internal(base.NativePtr);
		}

		// Token: 0x060205E5 RID: 132581 RVA: 0x00300B89 File Offset: 0x002FED89
		public bool GetExpendChildrenHeight()
		{
			return UUIHorizontalLayout.__GetExpendChildrenHeight_Internal(base.NativePtr);
		}

		// Token: 0x060205E6 RID: 132582 RVA: 0x00300B96 File Offset: 0x002FED96
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIHorizontalLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x060205E7 RID: 132583 RVA: 0x00300BA3 File Offset: 0x002FEDA3
		public float GetActuralRange()
		{
			return UUIHorizontalLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x060205E8 RID: 132584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060205E9 RID: 132585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, float value);

		// Token: 0x060205EA RID: 132586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x060205EB RID: 132587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060205EC RID: 132588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenWidth_Internal(IntPtr @this, bool value);

		// Token: 0x060205ED RID: 132589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenHeight_Internal(IntPtr @this, bool value);

		// Token: 0x060205EE RID: 132590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x060205EF RID: 132591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x060205F0 RID: 132592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpacing_Internal(IntPtr @this);

		// Token: 0x060205F1 RID: 132593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x060205F2 RID: 132594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x060205F3 RID: 132595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenWidth_Internal(IntPtr @this);

		// Token: 0x060205F4 RID: 132596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenHeight_Internal(IntPtr @this);

		// Token: 0x060205F5 RID: 132597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x060205F6 RID: 132598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x060205F7 RID: 132599 RVA: 0x00300BB0 File Offset: 0x002FEDB0
		static UUIHorizontalLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIHorizontalLayout");
		}

		// Token: 0x060205F8 RID: 132600 RVA: 0x00300BBE File Offset: 0x002FEDBE
		protected UUIHorizontalLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011607 RID: 71175
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIHorizontalLayout";

		// Token: 0x04011608 RID: 71176
		private static IntPtr _ClassPtr;

		// Token: 0x04011609 RID: 71177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401160A RID: 71178
		internal static int __PropertyOffset_Padding;

		// Token: 0x0401160B RID: 71179
		internal static int __PropertyOffset_Spacing;

		// Token: 0x0401160C RID: 71180
		internal static int __PropertyOffset_bAutoSpacing;

		// Token: 0x0401160D RID: 71181
		internal static int __PropertyOffset_Align;

		// Token: 0x0401160E RID: 71182
		internal static int __PropertyOffset_ExpendChildrenWidth;

		// Token: 0x0401160F RID: 71183
		internal static int __PropertyOffset_bControlWidthCalculatedScale;

		// Token: 0x04011610 RID: 71184
		internal static int __PropertyOffset_bExcludeWidthZeroSpace;

		// Token: 0x04011611 RID: 71185
		internal static int __PropertyOffset_ExpendChildrenHeight;

		// Token: 0x04011612 RID: 71186
		internal static int __PropertyOffset_bControlHeightCalculatedScale;

		// Token: 0x04011613 RID: 71187
		internal static int __PropertyOffset_WidthFitToChildren;

		// Token: 0x04011614 RID: 71188
		internal static int __PropertyOffset_HeightFitToChildren;
	}
}
