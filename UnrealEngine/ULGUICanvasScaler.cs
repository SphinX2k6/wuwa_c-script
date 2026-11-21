using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000672 RID: 1650
	[UnrealObjectPath("/Script/LGUI.LGUICanvasScaler")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class ULGUICanvasScaler : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008FBE RID: 36798 RVA: 0x000D7AF1 File Offset: 0x000D5CF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICanvasScaler._ClassPtr;
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x000D7B00 File Offset: 0x000D5D00
		public ULGUICanvasScaler() : this(BuiltinUtils.AllocNativeUObject(ULGUICanvasScaler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x000D7B28 File Offset: 0x000D5D28
		[NullableContext(1)]
		public ULGUICanvasScaler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICanvasScaler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x000D7B5C File Offset: 0x000D5D5C
		// (set) Token: 0x06008FC2 RID: 36802 RVA: 0x000D7B95 File Offset: 0x000D5D95
		[Nullable(1)]
		public FOnViewportSizeChanged OnViewportSizeChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnViewportSizeChanged result;
				if ((result = this._OnViewportSizeChanged) == null)
				{
					result = (this._OnViewportSizeChanged = new FOnViewportSizeChanged(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_OnViewportSizeChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_OnViewportSizeChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x000D7BB6 File Offset: 0x000D5DB6
		// (set) Token: 0x06008FC4 RID: 36804 RVA: 0x000D7BCA File Offset: 0x000D5DCA
		public unsafe TEnumAsByte<ECameraProjectionMode> ProjectionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ProjectionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ProjectionType) = value;
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x000D7BDF File Offset: 0x000D5DDF
		// (set) Token: 0x06008FC6 RID: 36806 RVA: 0x000D7BEF File Offset: 0x000D5DEF
		public unsafe float FOVAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_FOVAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_FOVAngle) = value;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x000D7C00 File Offset: 0x000D5E00
		// (set) Token: 0x06008FC8 RID: 36808 RVA: 0x000D7C10 File Offset: 0x000D5E10
		public unsafe float NearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_NearClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_NearClipPlane) = value;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x000D7C21 File Offset: 0x000D5E21
		// (set) Token: 0x06008FCA RID: 36810 RVA: 0x000D7C31 File Offset: 0x000D5E31
		public unsafe float FarClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_FarClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_FarClipPlane) = value;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x000D7C42 File Offset: 0x000D5E42
		// (set) Token: 0x06008FCC RID: 36812 RVA: 0x000D7C56 File Offset: 0x000D5E56
		public unsafe FVector2D ReferenceResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ReferenceResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ReferenceResolution) = value;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x000D7C6B File Offset: 0x000D5E6B
		// (set) Token: 0x06008FCE RID: 36814 RVA: 0x000D7C7B File Offset: 0x000D5E7B
		public unsafe float MatchFromWidthToHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_MatchFromWidthToHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_MatchFromWidthToHeight) = value;
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x000D7C8C File Offset: 0x000D5E8C
		// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x000D7CA0 File Offset: 0x000D5EA0
		[Nullable(2)]
		public unsafe ULGUICanvas Canvas
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICanvas>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvasScaler.__PropertyOffset_Canvas);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvasScaler.__PropertyOffset_Canvas, value);
			}
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x000D7CB5 File Offset: 0x000D5EB5
		public void SetReferenceResolution(FVector2D value)
		{
			ULGUICanvasScaler.__SetReferenceResolution_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x000D7CC3 File Offset: 0x000D5EC3
		public void SetProjectionType(ECameraProjectionMode value)
		{
			ULGUICanvasScaler.__SetProjectionType_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x000D7CD6 File Offset: 0x000D5ED6
		public void SetNearClipPlane(float value)
		{
			ULGUICanvasScaler.__SetNearClipPlane_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x000D7CE4 File Offset: 0x000D5EE4
		public void SetMatchFromWidthToHeight(float value)
		{
			ULGUICanvasScaler.__SetMatchFromWidthToHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x000D7CF2 File Offset: 0x000D5EF2
		public void SetFovAngle(float value)
		{
			ULGUICanvasScaler.__SetFovAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x000D7D00 File Offset: 0x000D5F00
		public void SetFarClipPlane(float value)
		{
			ULGUICanvasScaler.__SetFarClipPlane_Internal(base.NativePtr, value);
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x000D7D10 File Offset: 0x000D5F10
		public unsafe bool Project3DToScreen(in FVector Position3D, ref FVector2D OutPosition2D)
		{
			fixed (FVector2D* ptr = &OutPosition2D)
			{
				void* ptr2 = (void*)ptr;
				return ULGUICanvasScaler.__Project3DToScreen_Internal(base.NativePtr, Position3D, ref OutPosition2D);
			}
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x000D7D2F File Offset: 0x000D5F2F
		public FVector2D GetReferenceResolution()
		{
			return ULGUICanvasScaler.__GetReferenceResolution_Internal(base.NativePtr);
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x000D7D3C File Offset: 0x000D5F3C
		public TEnumAsByte<ECameraProjectionMode> GetProjectionType()
		{
			return ULGUICanvasScaler.__GetProjectionType_Internal(base.NativePtr);
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x000D7D49 File Offset: 0x000D5F49
		public float GetNearClipPlane()
		{
			return ULGUICanvasScaler.__GetNearClipPlane_Internal(base.NativePtr);
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x000D7D56 File Offset: 0x000D5F56
		public float GetMatchFromWidthToHeight()
		{
			return ULGUICanvasScaler.__GetMatchFromWidthToHeight_Internal(base.NativePtr);
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x000D7D63 File Offset: 0x000D5F63
		public float GetFovAngle()
		{
			return ULGUICanvasScaler.__GetFovAngle_Internal(base.NativePtr);
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x000D7D70 File Offset: 0x000D5F70
		public float GetFarClipPlane()
		{
			return ULGUICanvasScaler.__GetFarClipPlane_Internal(base.NativePtr);
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x000D7D7D File Offset: 0x000D5F7D
		public FVector2D ConvertPositionFromViewportToLGUICanvas(in FVector2D position)
		{
			return ULGUICanvasScaler.__ConvertPositionFromViewportToLGUICanvas_Internal(base.NativePtr, position);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x000D7D8B File Offset: 0x000D5F8B
		public FVector2D ConvertPositionFromLGUICanvasToViewport(in FVector2D position)
		{
			return ULGUICanvasScaler.__ConvertPositionFromLGUICanvasToViewport_Internal(base.NativePtr, position);
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x000D7D9C File Offset: 0x000D5F9C
		public unsafe void CalculateAdaptedSizeAndScale(float Width, float Height, ref float OutWidth, ref float OutHeight, ref float OutScale)
		{
			fixed (float* ptr = &OutWidth)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHeight)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutScale)
					{
						void* ptr6 = (void*)ptr5;
						ULGUICanvasScaler.__CalculateAdaptedSizeAndScale_Internal(base.NativePtr, Width, Height, ref OutWidth, ref OutHeight, ref OutScale);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x06008FE1 RID: 36833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReferenceResolution_Internal(IntPtr @this, FVector2D value);

		// Token: 0x06008FE2 RID: 36834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionType_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> value);

		// Token: 0x06008FE3 RID: 36835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNearClipPlane_Internal(IntPtr @this, float value);

		// Token: 0x06008FE4 RID: 36836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMatchFromWidthToHeight_Internal(IntPtr @this, float value);

		// Token: 0x06008FE5 RID: 36837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFovAngle_Internal(IntPtr @this, float value);

		// Token: 0x06008FE6 RID: 36838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFarClipPlane_Internal(IntPtr @this, float value);

		// Token: 0x06008FE7 RID: 36839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Project3DToScreen_Internal(IntPtr @this, in FVector Position3D, ref FVector2D OutPosition2D);

		// Token: 0x06008FE8 RID: 36840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetReferenceResolution_Internal(IntPtr @this);

		// Token: 0x06008FE9 RID: 36841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECameraProjectionMode> __GetProjectionType_Internal(IntPtr @this);

		// Token: 0x06008FEA RID: 36842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetNearClipPlane_Internal(IntPtr @this);

		// Token: 0x06008FEB RID: 36843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMatchFromWidthToHeight_Internal(IntPtr @this);

		// Token: 0x06008FEC RID: 36844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFovAngle_Internal(IntPtr @this);

		// Token: 0x06008FED RID: 36845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFarClipPlane_Internal(IntPtr @this);

		// Token: 0x06008FEE RID: 36846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertPositionFromViewportToLGUICanvas_Internal(IntPtr @this, in FVector2D position);

		// Token: 0x06008FEF RID: 36847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertPositionFromLGUICanvasToViewport_Internal(IntPtr @this, in FVector2D position);

		// Token: 0x06008FF0 RID: 36848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateAdaptedSizeAndScale_Internal(IntPtr @this, float Width, float Height, ref float OutWidth, ref float OutHeight, ref float OutScale);

		// Token: 0x06008FF1 RID: 36849 RVA: 0x000D7DDB File Offset: 0x000D5FDB
		static ULGUICanvasScaler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICanvasScaler");
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x000D7DE9 File Offset: 0x000D5FE9
		protected ULGUICanvasScaler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003EE2 RID: 16098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUICanvasScaler";

		// Token: 0x04003EE3 RID: 16099
		private static IntPtr _ClassPtr;

		// Token: 0x04003EE4 RID: 16100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003EE5 RID: 16101
		internal static int __PropertyOffset_OnViewportSizeChanged;

		// Token: 0x04003EE6 RID: 16102
		[Nullable(2)]
		private FOnViewportSizeChanged _OnViewportSizeChanged;

		// Token: 0x04003EE7 RID: 16103
		internal static int __PropertyOffset_ProjectionType;

		// Token: 0x04003EE8 RID: 16104
		internal static int __PropertyOffset_FOVAngle;

		// Token: 0x04003EE9 RID: 16105
		internal static int __PropertyOffset_NearClipPlane;

		// Token: 0x04003EEA RID: 16106
		internal static int __PropertyOffset_FarClipPlane;

		// Token: 0x04003EEB RID: 16107
		internal static int __PropertyOffset_ReferenceResolution;

		// Token: 0x04003EEC RID: 16108
		internal static int __PropertyOffset_MatchFromWidthToHeight;

		// Token: 0x04003EED RID: 16109
		internal static int __PropertyOffset_Canvas;
	}
}
