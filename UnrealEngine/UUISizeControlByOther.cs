using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B0 RID: 8624
	[UnrealObjectPath("/Script/LGUI.UISizeControlByOther")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UUISizeControlByOther : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020CAD RID: 134317 RVA: 0x003076BF File Offset: 0x003058BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISizeControlByOther._ClassPtr;
		}

		// Token: 0x06020CAE RID: 134318 RVA: 0x003076CC File Offset: 0x003058CC
		public UUISizeControlByOther() : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOther.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CAF RID: 134319 RVA: 0x003076F4 File Offset: 0x003058F4
		[NullableContext(1)]
		public UUISizeControlByOther(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOther.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008011 RID: 32785
		// (get) Token: 0x06020CB0 RID: 134320 RVA: 0x00307727 File Offset: 0x00305927
		// (set) Token: 0x06020CB1 RID: 134321 RVA: 0x0030773B File Offset: 0x0030593B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TargetActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetActor) = value;
			}
		}

		// Token: 0x17008012 RID: 32786
		// (get) Token: 0x06020CB2 RID: 134322 RVA: 0x00307750 File Offset: 0x00305950
		// (set) Token: 0x06020CB3 RID: 134323 RVA: 0x00307760 File Offset: 0x00305960
		public unsafe bool ControlWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008013 RID: 32787
		// (get) Token: 0x06020CB4 RID: 134324 RVA: 0x00307771 File Offset: 0x00305971
		// (set) Token: 0x06020CB5 RID: 134325 RVA: 0x00307781 File Offset: 0x00305981
		public unsafe bool ControlHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008014 RID: 32788
		// (get) Token: 0x06020CB6 RID: 134326 RVA: 0x00307792 File Offset: 0x00305992
		// (set) Token: 0x06020CB7 RID: 134327 RVA: 0x003077A2 File Offset: 0x003059A2
		public unsafe bool UseWidthRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseWidthRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseWidthRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008015 RID: 32789
		// (get) Token: 0x06020CB8 RID: 134328 RVA: 0x003077B3 File Offset: 0x003059B3
		// (set) Token: 0x06020CB9 RID: 134329 RVA: 0x003077C3 File Offset: 0x003059C3
		public unsafe bool UseHeightRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseHeightRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseHeightRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008016 RID: 32790
		// (get) Token: 0x06020CBA RID: 134330 RVA: 0x003077D4 File Offset: 0x003059D4
		// (set) Token: 0x06020CBB RID: 134331 RVA: 0x003077E4 File Offset: 0x003059E4
		public unsafe int MaxWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxWidth) = value;
			}
		}

		// Token: 0x17008017 RID: 32791
		// (get) Token: 0x06020CBC RID: 134332 RVA: 0x003077F5 File Offset: 0x003059F5
		// (set) Token: 0x06020CBD RID: 134333 RVA: 0x00307805 File Offset: 0x00305A05
		public unsafe int MinWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinWidth) = value;
			}
		}

		// Token: 0x17008018 RID: 32792
		// (get) Token: 0x06020CBE RID: 134334 RVA: 0x00307816 File Offset: 0x00305A16
		// (set) Token: 0x06020CBF RID: 134335 RVA: 0x00307826 File Offset: 0x00305A26
		public unsafe int MaxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxHeight) = value;
			}
		}

		// Token: 0x17008019 RID: 32793
		// (get) Token: 0x06020CC0 RID: 134336 RVA: 0x00307837 File Offset: 0x00305A37
		// (set) Token: 0x06020CC1 RID: 134337 RVA: 0x00307847 File Offset: 0x00305A47
		public unsafe int MinHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinHeight) = value;
			}
		}

		// Token: 0x1700801A RID: 32794
		// (get) Token: 0x06020CC2 RID: 134338 RVA: 0x00307858 File Offset: 0x00305A58
		// (set) Token: 0x06020CC3 RID: 134339 RVA: 0x00307868 File Offset: 0x00305A68
		public unsafe float AdditionalWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalWidth) = value;
			}
		}

		// Token: 0x1700801B RID: 32795
		// (get) Token: 0x06020CC4 RID: 134340 RVA: 0x00307879 File Offset: 0x00305A79
		// (set) Token: 0x06020CC5 RID: 134341 RVA: 0x00307889 File Offset: 0x00305A89
		public unsafe float AdditionalHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalHeight) = value;
			}
		}

		// Token: 0x1700801C RID: 32796
		// (get) Token: 0x06020CC6 RID: 134342 RVA: 0x0030789A File Offset: 0x00305A9A
		// (set) Token: 0x06020CC7 RID: 134343 RVA: 0x003078AA File Offset: 0x00305AAA
		public unsafe bool bSizeZeroWhenNotActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_bSizeZeroWhenNotActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_bSizeZeroWhenNotActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700801D RID: 32797
		// (get) Token: 0x06020CC8 RID: 134344 RVA: 0x003078BB File Offset: 0x00305ABB
		// (set) Token: 0x06020CC9 RID: 134345 RVA: 0x003078CF File Offset: 0x00305ACF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> TargetUIItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetUIItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetUIItem) = value;
			}
		}

		// Token: 0x1700801E RID: 32798
		// (get) Token: 0x06020CCA RID: 134346 RVA: 0x003078E4 File Offset: 0x00305AE4
		// (set) Token: 0x06020CCB RID: 134347 RVA: 0x003078F8 File Offset: 0x00305AF8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISizeControlByOtherHelper> HelperComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_HelperComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_HelperComp) = value;
			}
		}

		// Token: 0x06020CCC RID: 134348 RVA: 0x0030790D File Offset: 0x00305B0D
		[NullableContext(2)]
		public void SetTargetActor(AUIBaseActor NewTargetActor)
		{
			UUISizeControlByOther.__SetTargetActor_Internal(base.NativePtr, (NewTargetActor != null) ? NewTargetActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020CCD RID: 134349 RVA: 0x0030792A File Offset: 0x00305B2A
		public void SetControlWidth(bool value)
		{
			UUISizeControlByOther.__SetControlWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x06020CCE RID: 134350 RVA: 0x00307938 File Offset: 0x00305B38
		public void SetControlHeight(bool value)
		{
			UUISizeControlByOther.__SetControlHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x06020CCF RID: 134351 RVA: 0x00307946 File Offset: 0x00305B46
		public void SetAdditionalWidth(float value)
		{
			UUISizeControlByOther.__SetAdditionalWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x06020CD0 RID: 134352 RVA: 0x00307954 File Offset: 0x00305B54
		public void SetAdditionalHeight(float value)
		{
			UUISizeControlByOther.__SetAdditionalHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x06020CD1 RID: 134353 RVA: 0x00307962 File Offset: 0x00305B62
		[NullableContext(2)]
		public AUIBaseActor GetTargetActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUISizeControlByOther.__GetTargetActor_Internal(base.NativePtr));
		}

		// Token: 0x06020CD2 RID: 134354 RVA: 0x00307974 File Offset: 0x00305B74
		public bool GetControlWidth()
		{
			return UUISizeControlByOther.__GetControlWidth_Internal(base.NativePtr);
		}

		// Token: 0x06020CD3 RID: 134355 RVA: 0x00307981 File Offset: 0x00305B81
		public bool GetControlHeight()
		{
			return UUISizeControlByOther.__GetControlHeight_Internal(base.NativePtr);
		}

		// Token: 0x06020CD4 RID: 134356 RVA: 0x0030798E File Offset: 0x00305B8E
		public float GetAdditionalWidth()
		{
			return UUISizeControlByOther.__GetAdditionalWidth_Internal(base.NativePtr);
		}

		// Token: 0x06020CD5 RID: 134357 RVA: 0x0030799B File Offset: 0x00305B9B
		public float GetAdditionalHeight()
		{
			return UUISizeControlByOther.__GetAdditionalHeight_Internal(base.NativePtr);
		}

		// Token: 0x06020CD6 RID: 134358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetActor_Internal(IntPtr @this, IntPtr NewTargetActor);

		// Token: 0x06020CD7 RID: 134359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlWidth_Internal(IntPtr @this, bool value);

		// Token: 0x06020CD8 RID: 134360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlHeight_Internal(IntPtr @this, bool value);

		// Token: 0x06020CD9 RID: 134361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalWidth_Internal(IntPtr @this, float value);

		// Token: 0x06020CDA RID: 134362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalHeight_Internal(IntPtr @this, float value);

		// Token: 0x06020CDB RID: 134363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetActor_Internal(IntPtr @this);

		// Token: 0x06020CDC RID: 134364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControlWidth_Internal(IntPtr @this);

		// Token: 0x06020CDD RID: 134365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControlHeight_Internal(IntPtr @this);

		// Token: 0x06020CDE RID: 134366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAdditionalWidth_Internal(IntPtr @this);

		// Token: 0x06020CDF RID: 134367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAdditionalHeight_Internal(IntPtr @this);

		// Token: 0x06020CE0 RID: 134368 RVA: 0x003079A8 File Offset: 0x00305BA8
		static UUISizeControlByOther()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISizeControlByOther");
		}

		// Token: 0x06020CE1 RID: 134369 RVA: 0x003079B6 File Offset: 0x00305BB6
		protected UUISizeControlByOther(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401184D RID: 71757
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISizeControlByOther";

		// Token: 0x0401184E RID: 71758
		private static IntPtr _ClassPtr;

		// Token: 0x0401184F RID: 71759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011850 RID: 71760
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x04011851 RID: 71761
		internal static int __PropertyOffset_ControlWidth;

		// Token: 0x04011852 RID: 71762
		internal static int __PropertyOffset_ControlHeight;

		// Token: 0x04011853 RID: 71763
		internal static int __PropertyOffset_UseWidthRange;

		// Token: 0x04011854 RID: 71764
		internal static int __PropertyOffset_UseHeightRange;

		// Token: 0x04011855 RID: 71765
		internal static int __PropertyOffset_MaxWidth;

		// Token: 0x04011856 RID: 71766
		internal static int __PropertyOffset_MinWidth;

		// Token: 0x04011857 RID: 71767
		internal static int __PropertyOffset_MaxHeight;

		// Token: 0x04011858 RID: 71768
		internal static int __PropertyOffset_MinHeight;

		// Token: 0x04011859 RID: 71769
		internal static int __PropertyOffset_AdditionalWidth;

		// Token: 0x0401185A RID: 71770
		internal static int __PropertyOffset_AdditionalHeight;

		// Token: 0x0401185B RID: 71771
		internal static int __PropertyOffset_bSizeZeroWhenNotActive;

		// Token: 0x0401185C RID: 71772
		internal static int __PropertyOffset_TargetUIItem;

		// Token: 0x0401185D RID: 71773
		internal static int __PropertyOffset_HelperComp;
	}
}
