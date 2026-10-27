using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002187 RID: 8583
	[UnrealObjectPath("/Script/LGUI.UIMultiTemplateLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIMultiTemplateLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020837 RID: 133175 RVA: 0x00302A1B File Offset: 0x00300C1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIMultiTemplateLayout._ClassPtr;
		}

		// Token: 0x06020838 RID: 133176 RVA: 0x00302A28 File Offset: 0x00300C28
		public UUIMultiTemplateLayout() : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020839 RID: 133177 RVA: 0x00302A50 File Offset: 0x00300C50
		[NullableContext(1)]
		public UUIMultiTemplateLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F35 RID: 32565
		// (get) Token: 0x0602083A RID: 133178 RVA: 0x00302A83 File Offset: 0x00300C83
		// (set) Token: 0x0602083B RID: 133179 RVA: 0x00302A93 File Offset: 0x00300C93
		public unsafe ELGUILayoutDirectionType DirectionType
		{
			get
			{
				return (ELGUILayoutDirectionType)(*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_DirectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_DirectionType) = (byte)value;
			}
		}

		// Token: 0x17007F36 RID: 32566
		// (get) Token: 0x0602083C RID: 133180 RVA: 0x00302AA4 File Offset: 0x00300CA4
		// (set) Token: 0x0602083D RID: 133181 RVA: 0x00302AB8 File Offset: 0x00300CB8
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17007F37 RID: 32567
		// (get) Token: 0x0602083E RID: 133182 RVA: 0x00302ACD File Offset: 0x00300CCD
		// (set) Token: 0x0602083F RID: 133183 RVA: 0x00302AE1 File Offset: 0x00300CE1
		public unsafe FVector2D Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17007F38 RID: 32568
		// (get) Token: 0x06020840 RID: 133184 RVA: 0x00302AF6 File Offset: 0x00300CF6
		// (set) Token: 0x06020841 RID: 133185 RVA: 0x00302B06 File Offset: 0x00300D06
		public unsafe bool SizeFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_SizeFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_SizeFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F39 RID: 32569
		// (get) Token: 0x06020842 RID: 133186 RVA: 0x00302B17 File Offset: 0x00300D17
		// (set) Token: 0x06020843 RID: 133187 RVA: 0x00302B27 File Offset: 0x00300D27
		public unsafe bool bAutoAdjustScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_bAutoAdjustScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateLayout.__PropertyOffset_bAutoAdjustScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020844 RID: 133188 RVA: 0x00302B38 File Offset: 0x00300D38
		public void SetSpacing(FVector2D value)
		{
			UUIMultiTemplateLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x06020845 RID: 133189 RVA: 0x00302B46 File Offset: 0x00300D46
		public void SetSizeFitToChildren(bool Value)
		{
			UUIMultiTemplateLayout.__SetSizeFitToChildren_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020846 RID: 133190 RVA: 0x00302B54 File Offset: 0x00300D54
		public void SetPadding(FMargin value)
		{
			UUIMultiTemplateLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x06020847 RID: 133191 RVA: 0x00302B62 File Offset: 0x00300D62
		public void SetDirectionType(ELGUILayoutDirectionType NewDirectionType)
		{
			UUIMultiTemplateLayout.__SetDirectionType_Internal(base.NativePtr, NewDirectionType);
		}

		// Token: 0x06020848 RID: 133192 RVA: 0x00302B70 File Offset: 0x00300D70
		public void SetAutoAdjustScale(bool Value)
		{
			UUIMultiTemplateLayout.__SetAutoAdjustScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020849 RID: 133193 RVA: 0x00302B7E File Offset: 0x00300D7E
		public FVector2D GetSpacing()
		{
			return UUIMultiTemplateLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x0602084A RID: 133194 RVA: 0x00302B8B File Offset: 0x00300D8B
		public bool GetSizeFitToChildren()
		{
			return UUIMultiTemplateLayout.__GetSizeFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x0602084B RID: 133195 RVA: 0x00302B98 File Offset: 0x00300D98
		public FMargin GetPadding()
		{
			return UUIMultiTemplateLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x0602084C RID: 133196 RVA: 0x00302BA5 File Offset: 0x00300DA5
		public ELGUILayoutDirectionType GetDirectionType()
		{
			return UUIMultiTemplateLayout.__GetDirectionType_Internal(base.NativePtr);
		}

		// Token: 0x0602084D RID: 133197 RVA: 0x00302BB2 File Offset: 0x00300DB2
		public bool GetAutoAdjustScale()
		{
			return UUIMultiTemplateLayout.__GetAutoAdjustScale_Internal(base.NativePtr);
		}

		// Token: 0x0602084E RID: 133198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, FVector2D value);

		// Token: 0x0602084F RID: 133199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFitToChildren_Internal(IntPtr @this, bool Value);

		// Token: 0x06020850 RID: 133200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x06020851 RID: 133201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirectionType_Internal(IntPtr @this, ELGUILayoutDirectionType NewDirectionType);

		// Token: 0x06020852 RID: 133202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoAdjustScale_Internal(IntPtr @this, bool Value);

		// Token: 0x06020853 RID: 133203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpacing_Internal(IntPtr @this);

		// Token: 0x06020854 RID: 133204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSizeFitToChildren_Internal(IntPtr @this);

		// Token: 0x06020855 RID: 133205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x06020856 RID: 133206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutDirectionType __GetDirectionType_Internal(IntPtr @this);

		// Token: 0x06020857 RID: 133207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoAdjustScale_Internal(IntPtr @this);

		// Token: 0x06020858 RID: 133208 RVA: 0x00302BBF File Offset: 0x00300DBF
		static UUIMultiTemplateLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIMultiTemplateLayout");
		}

		// Token: 0x06020859 RID: 133209 RVA: 0x00302BCD File Offset: 0x00300DCD
		protected UUIMultiTemplateLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116AE RID: 71342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIMultiTemplateLayout";

		// Token: 0x040116AF RID: 71343
		private static IntPtr _ClassPtr;

		// Token: 0x040116B0 RID: 71344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116B1 RID: 71345
		internal static int __PropertyOffset_DirectionType;

		// Token: 0x040116B2 RID: 71346
		internal static int __PropertyOffset_Padding;

		// Token: 0x040116B3 RID: 71347
		internal static int __PropertyOffset_Spacing;

		// Token: 0x040116B4 RID: 71348
		internal static int __PropertyOffset_SizeFitToChildren;

		// Token: 0x040116B5 RID: 71349
		internal static int __PropertyOffset_bAutoAdjustScale;
	}
}
