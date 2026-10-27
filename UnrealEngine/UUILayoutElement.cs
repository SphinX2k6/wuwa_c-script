using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002183 RID: 8579
	[UnrealObjectPath("/Script/LGUI.UILayoutElement")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUILayoutElement : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060207B6 RID: 133046 RVA: 0x00302295 File Offset: 0x00300495
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILayoutElement._ClassPtr;
		}

		// Token: 0x060207B7 RID: 133047 RVA: 0x003022A4 File Offset: 0x003004A4
		public UUILayoutElement() : this(BuiltinUtils.AllocNativeUObject(UUILayoutElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207B8 RID: 133048 RVA: 0x003022CC File Offset: 0x003004CC
		[NullableContext(1)]
		public UUILayoutElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILayoutElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F1A RID: 32538
		// (get) Token: 0x060207B9 RID: 133049 RVA: 0x003022FF File Offset: 0x003004FF
		// (set) Token: 0x060207BA RID: 133050 RVA: 0x00302313 File Offset: 0x00300513
		[Nullable(2)]
		public unsafe UUILayoutBase ParentLayout
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUILayoutBase>(base.NativePtr / (IntPtr)sizeof(void*) + UUILayoutElement.__PropertyOffset_ParentLayout);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUILayoutElement.__PropertyOffset_ParentLayout, value);
			}
		}

		// Token: 0x17007F1B RID: 32539
		// (get) Token: 0x060207BB RID: 133051 RVA: 0x00302328 File Offset: 0x00300528
		// (set) Token: 0x060207BC RID: 133052 RVA: 0x00302338 File Offset: 0x00300538
		public unsafe ELayoutElementType LayoutElementType
		{
			get
			{
				return (ELayoutElementType)(*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_LayoutElementType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_LayoutElementType) = (byte)value;
			}
		}

		// Token: 0x17007F1C RID: 32540
		// (get) Token: 0x060207BD RID: 133053 RVA: 0x00302349 File Offset: 0x00300549
		// (set) Token: 0x060207BE RID: 133054 RVA: 0x00302359 File Offset: 0x00300559
		public unsafe float ConstantSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_ConstantSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_ConstantSize) = value;
			}
		}

		// Token: 0x17007F1D RID: 32541
		// (get) Token: 0x060207BF RID: 133055 RVA: 0x0030236A File Offset: 0x0030056A
		// (set) Token: 0x060207C0 RID: 133056 RVA: 0x0030237A File Offset: 0x0030057A
		public unsafe float RatioSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_RatioSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_RatioSize) = value;
			}
		}

		// Token: 0x17007F1E RID: 32542
		// (get) Token: 0x060207C1 RID: 133057 RVA: 0x0030238B File Offset: 0x0030058B
		// (set) Token: 0x060207C2 RID: 133058 RVA: 0x0030239B File Offset: 0x0030059B
		public unsafe bool bIgnoreWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_bIgnoreWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_bIgnoreWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F1F RID: 32543
		// (get) Token: 0x060207C3 RID: 133059 RVA: 0x003023AC File Offset: 0x003005AC
		// (set) Token: 0x060207C4 RID: 133060 RVA: 0x003023BC File Offset: 0x003005BC
		public unsafe bool bIgnoreHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_bIgnoreHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutElement.__PropertyOffset_bIgnoreHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x060207C5 RID: 133061 RVA: 0x003023CD File Offset: 0x003005CD
		public void SetRatioSize(float value)
		{
			UUILayoutElement.__SetRatioSize_Internal(base.NativePtr, value);
		}

		// Token: 0x060207C6 RID: 133062 RVA: 0x003023DB File Offset: 0x003005DB
		public void SetLayoutType(ELayoutElementType InType)
		{
			UUILayoutElement.__SetLayoutType_Internal(base.NativePtr, InType);
		}

		// Token: 0x060207C7 RID: 133063 RVA: 0x003023E9 File Offset: 0x003005E9
		public void SetConstantSize(float value)
		{
			UUILayoutElement.__SetConstantSize_Internal(base.NativePtr, value);
		}

		// Token: 0x060207C8 RID: 133064 RVA: 0x003023F7 File Offset: 0x003005F7
		public bool IsIgnoredWidth()
		{
			return UUILayoutElement.__IsIgnoredWidth_Internal(base.NativePtr);
		}

		// Token: 0x060207C9 RID: 133065 RVA: 0x00302404 File Offset: 0x00300604
		public bool IsIgnoredHeight()
		{
			return UUILayoutElement.__IsIgnoredHeight_Internal(base.NativePtr);
		}

		// Token: 0x060207CA RID: 133066 RVA: 0x00302411 File Offset: 0x00300611
		public float GetRatioSize()
		{
			return UUILayoutElement.__GetRatioSize_Internal(base.NativePtr);
		}

		// Token: 0x060207CB RID: 133067 RVA: 0x0030241E File Offset: 0x0030061E
		public ELayoutElementType GetLayoutType()
		{
			return UUILayoutElement.__GetLayoutType_Internal(base.NativePtr);
		}

		// Token: 0x060207CC RID: 133068 RVA: 0x0030242B File Offset: 0x0030062B
		public bool GetIgnoreLayout()
		{
			return UUILayoutElement.__GetIgnoreLayout_Internal(base.NativePtr);
		}

		// Token: 0x060207CD RID: 133069 RVA: 0x00302438 File Offset: 0x00300638
		public float GetConstantSize()
		{
			return UUILayoutElement.__GetConstantSize_Internal(base.NativePtr);
		}

		// Token: 0x060207CE RID: 133070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRatioSize_Internal(IntPtr @this, float value);

		// Token: 0x060207CF RID: 133071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLayoutType_Internal(IntPtr @this, ELayoutElementType InType);

		// Token: 0x060207D0 RID: 133072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstantSize_Internal(IntPtr @this, float value);

		// Token: 0x060207D1 RID: 133073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIgnoredWidth_Internal(IntPtr @this);

		// Token: 0x060207D2 RID: 133074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIgnoredHeight_Internal(IntPtr @this);

		// Token: 0x060207D3 RID: 133075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRatioSize_Internal(IntPtr @this);

		// Token: 0x060207D4 RID: 133076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELayoutElementType __GetLayoutType_Internal(IntPtr @this);

		// Token: 0x060207D5 RID: 133077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreLayout_Internal(IntPtr @this);

		// Token: 0x060207D6 RID: 133078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetConstantSize_Internal(IntPtr @this);

		// Token: 0x060207D7 RID: 133079 RVA: 0x00302445 File Offset: 0x00300645
		static UUILayoutElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILayoutElement");
		}

		// Token: 0x060207D8 RID: 133080 RVA: 0x00302453 File Offset: 0x00300653
		protected UUILayoutElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011682 RID: 71298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UILayoutElement";

		// Token: 0x04011683 RID: 71299
		private static IntPtr _ClassPtr;

		// Token: 0x04011684 RID: 71300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011685 RID: 71301
		internal static int __PropertyOffset_ParentLayout;

		// Token: 0x04011686 RID: 71302
		internal static int __PropertyOffset_LayoutElementType;

		// Token: 0x04011687 RID: 71303
		internal static int __PropertyOffset_ConstantSize;

		// Token: 0x04011688 RID: 71304
		internal static int __PropertyOffset_RatioSize;

		// Token: 0x04011689 RID: 71305
		internal static int __PropertyOffset_bIgnoreWidth;

		// Token: 0x0401168A RID: 71306
		internal static int __PropertyOffset_bIgnoreHeight;
	}
}
