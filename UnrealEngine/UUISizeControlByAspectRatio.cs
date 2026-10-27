using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021AE RID: 8622
	[UnrealObjectPath("/Script/LGUI.UISizeControlByAspectRatio")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UUISizeControlByAspectRatio : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020C8B RID: 134283 RVA: 0x00307469 File Offset: 0x00305669
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISizeControlByAspectRatio._ClassPtr;
		}

		// Token: 0x06020C8C RID: 134284 RVA: 0x00307478 File Offset: 0x00305678
		public UUISizeControlByAspectRatio() : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByAspectRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C8D RID: 134285 RVA: 0x003074A0 File Offset: 0x003056A0
		[NullableContext(1)]
		public UUISizeControlByAspectRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByAspectRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008009 RID: 32777
		// (get) Token: 0x06020C8E RID: 134286 RVA: 0x003074D3 File Offset: 0x003056D3
		// (set) Token: 0x06020C8F RID: 134287 RVA: 0x003074E3 File Offset: 0x003056E3
		public unsafe EUISizeControlByAspectRatioMode ControlMode
		{
			get
			{
				return (EUISizeControlByAspectRatioMode)(*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_ControlMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_ControlMode) = (byte)value;
			}
		}

		// Token: 0x1700800A RID: 32778
		// (get) Token: 0x06020C90 RID: 134288 RVA: 0x003074F4 File Offset: 0x003056F4
		// (set) Token: 0x06020C91 RID: 134289 RVA: 0x00307504 File Offset: 0x00305704
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x1700800B RID: 32779
		// (get) Token: 0x06020C92 RID: 134290 RVA: 0x00307515 File Offset: 0x00305715
		// (set) Token: 0x06020C93 RID: 134291 RVA: 0x00307529 File Offset: 0x00305729
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISizeControlByAspectRatioHelper> HelperComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_HelperComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_HelperComp) = value;
			}
		}

		// Token: 0x1700800C RID: 32780
		// (get) Token: 0x06020C94 RID: 134292 RVA: 0x0030753E File Offset: 0x0030573E
		// (set) Token: 0x06020C95 RID: 134293 RVA: 0x00307552 File Offset: 0x00305752
		public unsafe FVector2D Pivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_Pivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_Pivot) = value;
			}
		}

		// Token: 0x1700800D RID: 32781
		// (get) Token: 0x06020C96 RID: 134294 RVA: 0x00307567 File Offset: 0x00305767
		// (set) Token: 0x06020C97 RID: 134295 RVA: 0x00307577 File Offset: 0x00305777
		public unsafe bool bChangeChildrenOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700800E RID: 32782
		// (get) Token: 0x06020C98 RID: 134296 RVA: 0x00307588 File Offset: 0x00305788
		// (set) Token: 0x06020C99 RID: 134297 RVA: 0x00307598 File Offset: 0x00305798
		public unsafe bool bChangeChildrenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700800F RID: 32783
		// (get) Token: 0x06020C9A RID: 134298 RVA: 0x003075A9 File Offset: 0x003057A9
		// (set) Token: 0x06020C9B RID: 134299 RVA: 0x003075B9 File Offset: 0x003057B9
		public unsafe bool bChangeChildrenAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenAlign) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatio.__PropertyOffset_bChangeChildrenAlign) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020C9C RID: 134300 RVA: 0x003075CA File Offset: 0x003057CA
		public void SetControlMode(EUISizeControlByAspectRatioMode value)
		{
			UUISizeControlByAspectRatio.__SetControlMode_Internal(base.NativePtr, value);
		}

		// Token: 0x06020C9D RID: 134301 RVA: 0x003075D8 File Offset: 0x003057D8
		public void SetAspectRatio(float value)
		{
			UUISizeControlByAspectRatio.__SetAspectRatio_Internal(base.NativePtr, value);
		}

		// Token: 0x06020C9E RID: 134302 RVA: 0x003075E6 File Offset: 0x003057E6
		public EUISizeControlByAspectRatioMode GetControlMode()
		{
			return UUISizeControlByAspectRatio.__GetControlMode_Internal(base.NativePtr);
		}

		// Token: 0x06020C9F RID: 134303 RVA: 0x003075F3 File Offset: 0x003057F3
		public float GetAspectRatio()
		{
			return UUISizeControlByAspectRatio.__GetAspectRatio_Internal(base.NativePtr);
		}

		// Token: 0x06020CA0 RID: 134304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlMode_Internal(IntPtr @this, EUISizeControlByAspectRatioMode value);

		// Token: 0x06020CA1 RID: 134305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAspectRatio_Internal(IntPtr @this, float value);

		// Token: 0x06020CA2 RID: 134306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISizeControlByAspectRatioMode __GetControlMode_Internal(IntPtr @this);

		// Token: 0x06020CA3 RID: 134307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAspectRatio_Internal(IntPtr @this);

		// Token: 0x06020CA4 RID: 134308 RVA: 0x00307600 File Offset: 0x00305800
		static UUISizeControlByAspectRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISizeControlByAspectRatio");
		}

		// Token: 0x06020CA5 RID: 134309 RVA: 0x0030760E File Offset: 0x0030580E
		protected UUISizeControlByAspectRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401183F RID: 71743
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISizeControlByAspectRatio";

		// Token: 0x04011840 RID: 71744
		private static IntPtr _ClassPtr;

		// Token: 0x04011841 RID: 71745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011842 RID: 71746
		internal static int __PropertyOffset_ControlMode;

		// Token: 0x04011843 RID: 71747
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x04011844 RID: 71748
		internal static int __PropertyOffset_HelperComp;

		// Token: 0x04011845 RID: 71749
		internal static int __PropertyOffset_Pivot;

		// Token: 0x04011846 RID: 71750
		internal static int __PropertyOffset_bChangeChildrenOffset;

		// Token: 0x04011847 RID: 71751
		internal static int __PropertyOffset_bChangeChildrenSize;

		// Token: 0x04011848 RID: 71752
		internal static int __PropertyOffset_bChangeChildrenAlign;
	}
}
