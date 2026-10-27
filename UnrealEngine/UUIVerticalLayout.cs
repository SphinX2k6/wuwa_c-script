using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021DF RID: 8671
	[UnrealObjectPath("/Script/LGUI.UIVerticalLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIVerticalLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210D3 RID: 135379 RVA: 0x0030C02D File Offset: 0x0030A22D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIVerticalLayout._ClassPtr;
		}

		// Token: 0x060210D4 RID: 135380 RVA: 0x0030C03C File Offset: 0x0030A23C
		public UUIVerticalLayout() : this(BuiltinUtils.AllocNativeUObject(UUIVerticalLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210D5 RID: 135381 RVA: 0x0030C064 File Offset: 0x0030A264
		[NullableContext(1)]
		public UUIVerticalLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIVerticalLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008101 RID: 33025
		// (get) Token: 0x060210D6 RID: 135382 RVA: 0x0030C097 File Offset: 0x0030A297
		// (set) Token: 0x060210D7 RID: 135383 RVA: 0x0030C0AB File Offset: 0x0030A2AB
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

		// Token: 0x17008102 RID: 33026
		// (get) Token: 0x060210D8 RID: 135384 RVA: 0x0030C0C0 File Offset: 0x0030A2C0
		// (set) Token: 0x060210D9 RID: 135385 RVA: 0x0030C0D0 File Offset: 0x0030A2D0
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

		// Token: 0x17008103 RID: 33027
		// (get) Token: 0x060210DA RID: 135386 RVA: 0x0030C0E1 File Offset: 0x0030A2E1
		// (set) Token: 0x060210DB RID: 135387 RVA: 0x0030C0F1 File Offset: 0x0030A2F1
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

		// Token: 0x17008104 RID: 33028
		// (get) Token: 0x060210DC RID: 135388 RVA: 0x0030C102 File Offset: 0x0030A302
		// (set) Token: 0x060210DD RID: 135389 RVA: 0x0030C112 File Offset: 0x0030A312
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

		// Token: 0x17008105 RID: 33029
		// (get) Token: 0x060210DE RID: 135390 RVA: 0x0030C123 File Offset: 0x0030A323
		// (set) Token: 0x060210DF RID: 135391 RVA: 0x0030C133 File Offset: 0x0030A333
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

		// Token: 0x17008106 RID: 33030
		// (get) Token: 0x060210E0 RID: 135392 RVA: 0x0030C144 File Offset: 0x0030A344
		// (set) Token: 0x060210E1 RID: 135393 RVA: 0x0030C154 File Offset: 0x0030A354
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

		// Token: 0x17008107 RID: 33031
		// (get) Token: 0x060210E2 RID: 135394 RVA: 0x0030C165 File Offset: 0x0030A365
		// (set) Token: 0x060210E3 RID: 135395 RVA: 0x0030C175 File Offset: 0x0030A375
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

		// Token: 0x17008108 RID: 33032
		// (get) Token: 0x060210E4 RID: 135396 RVA: 0x0030C186 File Offset: 0x0030A386
		// (set) Token: 0x060210E5 RID: 135397 RVA: 0x0030C196 File Offset: 0x0030A396
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

		// Token: 0x17008109 RID: 33033
		// (get) Token: 0x060210E6 RID: 135398 RVA: 0x0030C1A7 File Offset: 0x0030A3A7
		// (set) Token: 0x060210E7 RID: 135399 RVA: 0x0030C1B7 File Offset: 0x0030A3B7
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

		// Token: 0x1700810A RID: 33034
		// (get) Token: 0x060210E8 RID: 135400 RVA: 0x0030C1C8 File Offset: 0x0030A3C8
		// (set) Token: 0x060210E9 RID: 135401 RVA: 0x0030C1D8 File Offset: 0x0030A3D8
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

		// Token: 0x1700810B RID: 33035
		// (get) Token: 0x060210EA RID: 135402 RVA: 0x0030C1E9 File Offset: 0x0030A3E9
		// (set) Token: 0x060210EB RID: 135403 RVA: 0x0030C1F9 File Offset: 0x0030A3F9
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

		// Token: 0x060210EC RID: 135404 RVA: 0x0030C20A File Offset: 0x0030A40A
		public void SetWidthFitToChildren(bool value)
		{
			UUIVerticalLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x060210ED RID: 135405 RVA: 0x0030C218 File Offset: 0x0030A418
		public void SetSpacing(float value)
		{
			UUIVerticalLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x060210EE RID: 135406 RVA: 0x0030C226 File Offset: 0x0030A426
		public void SetPadding(FMargin value)
		{
			UUIVerticalLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x060210EF RID: 135407 RVA: 0x0030C234 File Offset: 0x0030A434
		public void SetHeightFitToChildren(bool value)
		{
			UUIVerticalLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x060210F0 RID: 135408 RVA: 0x0030C242 File Offset: 0x0030A442
		public void SetExpendChildrenWidth(bool value)
		{
			UUIVerticalLayout.__SetExpendChildrenWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x060210F1 RID: 135409 RVA: 0x0030C250 File Offset: 0x0030A450
		public void SetExpendChildrenHeight(bool value)
		{
			UUIVerticalLayout.__SetExpendChildrenHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x060210F2 RID: 135410 RVA: 0x0030C25E File Offset: 0x0030A45E
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIVerticalLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x060210F3 RID: 135411 RVA: 0x0030C26C File Offset: 0x0030A46C
		public bool GetWidthFitToChildren()
		{
			return UUIVerticalLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060210F4 RID: 135412 RVA: 0x0030C279 File Offset: 0x0030A479
		public float GetSpacing()
		{
			return UUIVerticalLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x060210F5 RID: 135413 RVA: 0x0030C286 File Offset: 0x0030A486
		public FMargin GetPadding()
		{
			return UUIVerticalLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x060210F6 RID: 135414 RVA: 0x0030C293 File Offset: 0x0030A493
		public bool GetHeightFitToChildren()
		{
			return UUIVerticalLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060210F7 RID: 135415 RVA: 0x0030C2A0 File Offset: 0x0030A4A0
		public bool GetExpendChildrenWidth()
		{
			return UUIVerticalLayout.__GetExpendChildrenWidth_Internal(base.NativePtr);
		}

		// Token: 0x060210F8 RID: 135416 RVA: 0x0030C2AD File Offset: 0x0030A4AD
		public bool GetExpendChildrenHeight()
		{
			return UUIVerticalLayout.__GetExpendChildrenHeight_Internal(base.NativePtr);
		}

		// Token: 0x060210F9 RID: 135417 RVA: 0x0030C2BA File Offset: 0x0030A4BA
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIVerticalLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x060210FA RID: 135418 RVA: 0x0030C2C7 File Offset: 0x0030A4C7
		public float GetActuralRange()
		{
			return UUIVerticalLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x060210FB RID: 135419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060210FC RID: 135420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, float value);

		// Token: 0x060210FD RID: 135421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x060210FE RID: 135422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060210FF RID: 135423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenWidth_Internal(IntPtr @this, bool value);

		// Token: 0x06021100 RID: 135424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenHeight_Internal(IntPtr @this, bool value);

		// Token: 0x06021101 RID: 135425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x06021102 RID: 135426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x06021103 RID: 135427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpacing_Internal(IntPtr @this);

		// Token: 0x06021104 RID: 135428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x06021105 RID: 135429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x06021106 RID: 135430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenWidth_Internal(IntPtr @this);

		// Token: 0x06021107 RID: 135431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenHeight_Internal(IntPtr @this);

		// Token: 0x06021108 RID: 135432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x06021109 RID: 135433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x0602110A RID: 135434 RVA: 0x0030C2D4 File Offset: 0x0030A4D4
		static UUIVerticalLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIVerticalLayout");
		}

		// Token: 0x0602110B RID: 135435 RVA: 0x0030C2E2 File Offset: 0x0030A4E2
		protected UUIVerticalLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A2D RID: 72237
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIVerticalLayout";

		// Token: 0x04011A2E RID: 72238
		private static IntPtr _ClassPtr;

		// Token: 0x04011A2F RID: 72239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A30 RID: 72240
		internal static int __PropertyOffset_Padding;

		// Token: 0x04011A31 RID: 72241
		internal static int __PropertyOffset_Spacing;

		// Token: 0x04011A32 RID: 72242
		internal static int __PropertyOffset_bAutoSpacing;

		// Token: 0x04011A33 RID: 72243
		internal static int __PropertyOffset_Align;

		// Token: 0x04011A34 RID: 72244
		internal static int __PropertyOffset_ExpendChildrenWidth;

		// Token: 0x04011A35 RID: 72245
		internal static int __PropertyOffset_bControlWidthCalculatedScale;

		// Token: 0x04011A36 RID: 72246
		internal static int __PropertyOffset_bExcludeHeightZeroSpace;

		// Token: 0x04011A37 RID: 72247
		internal static int __PropertyOffset_ExpendChildrenHeight;

		// Token: 0x04011A38 RID: 72248
		internal static int __PropertyOffset_bControlHeightCalculatedScale;

		// Token: 0x04011A39 RID: 72249
		internal static int __PropertyOffset_HeightFitToChildren;

		// Token: 0x04011A3A RID: 72250
		internal static int __PropertyOffset_WidthFitToChildren;
	}
}
