using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070A RID: 1802
	[UnrealObjectPath("/Script/LGUI.UIHorizontalLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIHorizontalLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009983 RID: 39299 RVA: 0x000E6EFE File Offset: 0x000E50FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIHorizontalLayout._ClassPtr;
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x000E6F0C File Offset: 0x000E510C
		public UUIHorizontalLayout() : this(BuiltinUtils.AllocNativeUObject(UUIHorizontalLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x000E6F34 File Offset: 0x000E5134
		[NullableContext(1)]
		public UUIHorizontalLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIHorizontalLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06009986 RID: 39302 RVA: 0x000E6F67 File Offset: 0x000E5167
		// (set) Token: 0x06009987 RID: 39303 RVA: 0x000E6F7B File Offset: 0x000E517B
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

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06009988 RID: 39304 RVA: 0x000E6F90 File Offset: 0x000E5190
		// (set) Token: 0x06009989 RID: 39305 RVA: 0x000E6FA0 File Offset: 0x000E51A0
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

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x0600998A RID: 39306 RVA: 0x000E6FB1 File Offset: 0x000E51B1
		// (set) Token: 0x0600998B RID: 39307 RVA: 0x000E6FC1 File Offset: 0x000E51C1
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

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x000E6FD2 File Offset: 0x000E51D2
		// (set) Token: 0x0600998D RID: 39309 RVA: 0x000E6FE2 File Offset: 0x000E51E2
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

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x0600998E RID: 39310 RVA: 0x000E6FF3 File Offset: 0x000E51F3
		// (set) Token: 0x0600998F RID: 39311 RVA: 0x000E7003 File Offset: 0x000E5203
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

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06009990 RID: 39312 RVA: 0x000E7014 File Offset: 0x000E5214
		// (set) Token: 0x06009991 RID: 39313 RVA: 0x000E7024 File Offset: 0x000E5224
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

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x000E7035 File Offset: 0x000E5235
		// (set) Token: 0x06009993 RID: 39315 RVA: 0x000E7045 File Offset: 0x000E5245
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

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x000E7056 File Offset: 0x000E5256
		// (set) Token: 0x06009995 RID: 39317 RVA: 0x000E7066 File Offset: 0x000E5266
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

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06009996 RID: 39318 RVA: 0x000E7077 File Offset: 0x000E5277
		// (set) Token: 0x06009997 RID: 39319 RVA: 0x000E7087 File Offset: 0x000E5287
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

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x000E7098 File Offset: 0x000E5298
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x000E70A8 File Offset: 0x000E52A8
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

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x000E70B9 File Offset: 0x000E52B9
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x000E70C9 File Offset: 0x000E52C9
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

		// Token: 0x0600999C RID: 39324 RVA: 0x000E70DA File Offset: 0x000E52DA
		public void SetWidthFitToChildren(bool value)
		{
			UUIHorizontalLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x000E70E8 File Offset: 0x000E52E8
		public void SetSpacing(float value)
		{
			UUIHorizontalLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x000E70F6 File Offset: 0x000E52F6
		public void SetPadding(FMargin value)
		{
			UUIHorizontalLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x000E7104 File Offset: 0x000E5304
		public void SetHeightFitToChildren(bool value)
		{
			UUIHorizontalLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x000E7112 File Offset: 0x000E5312
		public void SetExpendChildrenWidth(bool value)
		{
			UUIHorizontalLayout.__SetExpendChildrenWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x000E7120 File Offset: 0x000E5320
		public void SetExpendChildrenHeight(bool value)
		{
			UUIHorizontalLayout.__SetExpendChildrenHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x000E712E File Offset: 0x000E532E
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIHorizontalLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x000E713C File Offset: 0x000E533C
		public bool GetWidthFitToChildren()
		{
			return UUIHorizontalLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x000E7149 File Offset: 0x000E5349
		public float GetSpacing()
		{
			return UUIHorizontalLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x000E7156 File Offset: 0x000E5356
		public FMargin GetPadding()
		{
			return UUIHorizontalLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x000E7163 File Offset: 0x000E5363
		public bool GetHeightFitToChildren()
		{
			return UUIHorizontalLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x000E7170 File Offset: 0x000E5370
		public bool GetExpendChildrenWidth()
		{
			return UUIHorizontalLayout.__GetExpendChildrenWidth_Internal(base.NativePtr);
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x000E717D File Offset: 0x000E537D
		public bool GetExpendChildrenHeight()
		{
			return UUIHorizontalLayout.__GetExpendChildrenHeight_Internal(base.NativePtr);
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x000E718A File Offset: 0x000E538A
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIHorizontalLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x000E7197 File Offset: 0x000E5397
		public float GetActuralRange()
		{
			return UUIHorizontalLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x060099AB RID: 39339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060099AC RID: 39340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, float value);

		// Token: 0x060099AD RID: 39341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x060099AE RID: 39342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060099AF RID: 39343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenWidth_Internal(IntPtr @this, bool value);

		// Token: 0x060099B0 RID: 39344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildrenHeight_Internal(IntPtr @this, bool value);

		// Token: 0x060099B1 RID: 39345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x060099B2 RID: 39346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x060099B3 RID: 39347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSpacing_Internal(IntPtr @this);

		// Token: 0x060099B4 RID: 39348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x060099B5 RID: 39349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x060099B6 RID: 39350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenWidth_Internal(IntPtr @this);

		// Token: 0x060099B7 RID: 39351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildrenHeight_Internal(IntPtr @this);

		// Token: 0x060099B8 RID: 39352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x060099B9 RID: 39353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x060099BA RID: 39354 RVA: 0x000E71A4 File Offset: 0x000E53A4
		static UUIHorizontalLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIHorizontalLayout");
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x000E71B2 File Offset: 0x000E53B2
		protected UUIHorizontalLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042AE RID: 17070
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIHorizontalLayout";

		// Token: 0x040042AF RID: 17071
		private static IntPtr _ClassPtr;

		// Token: 0x040042B0 RID: 17072
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042B1 RID: 17073
		internal static int __PropertyOffset_Padding;

		// Token: 0x040042B2 RID: 17074
		internal static int __PropertyOffset_Spacing;

		// Token: 0x040042B3 RID: 17075
		internal static int __PropertyOffset_bAutoSpacing;

		// Token: 0x040042B4 RID: 17076
		internal static int __PropertyOffset_Align;

		// Token: 0x040042B5 RID: 17077
		internal static int __PropertyOffset_ExpendChildrenWidth;

		// Token: 0x040042B6 RID: 17078
		internal static int __PropertyOffset_bControlWidthCalculatedScale;

		// Token: 0x040042B7 RID: 17079
		internal static int __PropertyOffset_bExcludeWidthZeroSpace;

		// Token: 0x040042B8 RID: 17080
		internal static int __PropertyOffset_ExpendChildrenHeight;

		// Token: 0x040042B9 RID: 17081
		internal static int __PropertyOffset_bControlHeightCalculatedScale;

		// Token: 0x040042BA RID: 17082
		internal static int __PropertyOffset_WidthFitToChildren;

		// Token: 0x040042BB RID: 17083
		internal static int __PropertyOffset_HeightFitToChildren;
	}
}
