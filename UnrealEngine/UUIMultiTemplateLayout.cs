using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000713 RID: 1811
	[UnrealObjectPath("/Script/LGUI.UIMultiTemplateLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIMultiTemplateLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009BA5 RID: 39845 RVA: 0x000E8B33 File Offset: 0x000E6D33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIMultiTemplateLayout._ClassPtr;
		}

		// Token: 0x06009BA6 RID: 39846 RVA: 0x000E8B40 File Offset: 0x000E6D40
		public UUIMultiTemplateLayout() : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x000E8B68 File Offset: 0x000E6D68
		[NullableContext(1)]
		public UUIMultiTemplateLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x000E8B9B File Offset: 0x000E6D9B
		// (set) Token: 0x06009BA9 RID: 39849 RVA: 0x000E8BAF File Offset: 0x000E6DAF
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

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x000E8BC4 File Offset: 0x000E6DC4
		// (set) Token: 0x06009BAB RID: 39851 RVA: 0x000E8BD8 File Offset: 0x000E6DD8
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

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x000E8BED File Offset: 0x000E6DED
		// (set) Token: 0x06009BAD RID: 39853 RVA: 0x000E8BFD File Offset: 0x000E6DFD
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

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x000E8C0E File Offset: 0x000E6E0E
		// (set) Token: 0x06009BAF RID: 39855 RVA: 0x000E8C1E File Offset: 0x000E6E1E
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

		// Token: 0x06009BB0 RID: 39856 RVA: 0x000E8C2F File Offset: 0x000E6E2F
		public void SetSpacing(FVector2D value)
		{
			UUIMultiTemplateLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x000E8C3D File Offset: 0x000E6E3D
		public void SetSizeFitToChildren(bool Value)
		{
			UUIMultiTemplateLayout.__SetSizeFitToChildren_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x000E8C4B File Offset: 0x000E6E4B
		public void SetPadding(FMargin value)
		{
			UUIMultiTemplateLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x000E8C59 File Offset: 0x000E6E59
		public void SetAutoAdjustScale(bool Value)
		{
			UUIMultiTemplateLayout.__SetAutoAdjustScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x000E8C67 File Offset: 0x000E6E67
		public FVector2D GetSpacing()
		{
			return UUIMultiTemplateLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x000E8C74 File Offset: 0x000E6E74
		public bool GetSizeFitToChildren()
		{
			return UUIMultiTemplateLayout.__GetSizeFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x000E8C81 File Offset: 0x000E6E81
		public FMargin GetPadding()
		{
			return UUIMultiTemplateLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x000E8C8E File Offset: 0x000E6E8E
		public bool GetAutoAdjustScale()
		{
			return UUIMultiTemplateLayout.__GetAutoAdjustScale_Internal(base.NativePtr);
		}

		// Token: 0x06009BB8 RID: 39864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, FVector2D value);

		// Token: 0x06009BB9 RID: 39865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFitToChildren_Internal(IntPtr @this, bool Value);

		// Token: 0x06009BBA RID: 39866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x06009BBB RID: 39867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoAdjustScale_Internal(IntPtr @this, bool Value);

		// Token: 0x06009BBC RID: 39868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpacing_Internal(IntPtr @this);

		// Token: 0x06009BBD RID: 39869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSizeFitToChildren_Internal(IntPtr @this);

		// Token: 0x06009BBE RID: 39870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x06009BBF RID: 39871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoAdjustScale_Internal(IntPtr @this);

		// Token: 0x06009BC0 RID: 39872 RVA: 0x000E8C9B File Offset: 0x000E6E9B
		static UUIMultiTemplateLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIMultiTemplateLayout");
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x000E8CA9 File Offset: 0x000E6EA9
		protected UUIMultiTemplateLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400432B RID: 17195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIMultiTemplateLayout";

		// Token: 0x0400432C RID: 17196
		private static IntPtr _ClassPtr;

		// Token: 0x0400432D RID: 17197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400432E RID: 17198
		internal static int __PropertyOffset_Padding;

		// Token: 0x0400432F RID: 17199
		internal static int __PropertyOffset_Spacing;

		// Token: 0x04004330 RID: 17200
		internal static int __PropertyOffset_SizeFitToChildren;

		// Token: 0x04004331 RID: 17201
		internal static int __PropertyOffset_bAutoAdjustScale;
	}
}
