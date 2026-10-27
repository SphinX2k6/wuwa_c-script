using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200202E RID: 8238
	[UnrealObjectPath("/Script/LGUI.LGUICanvasScaler")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class ULGUICanvasScaler : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F26E RID: 127598 RVA: 0x002E42E1 File Offset: 0x002E24E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICanvasScaler._ClassPtr;
		}

		// Token: 0x0601F26F RID: 127599 RVA: 0x002E42F0 File Offset: 0x002E24F0
		public ULGUICanvasScaler() : this(BuiltinUtils.AllocNativeUObject(ULGUICanvasScaler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F270 RID: 127600 RVA: 0x002E4318 File Offset: 0x002E2518
		[NullableContext(1)]
		public ULGUICanvasScaler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICanvasScaler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B8C RID: 31628
		// (get) Token: 0x0601F271 RID: 127601 RVA: 0x002E434C File Offset: 0x002E254C
		// (set) Token: 0x0601F272 RID: 127602 RVA: 0x002E4385 File Offset: 0x002E2585
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

		// Token: 0x17007B8D RID: 31629
		// (get) Token: 0x0601F273 RID: 127603 RVA: 0x002E43A6 File Offset: 0x002E25A6
		// (set) Token: 0x0601F274 RID: 127604 RVA: 0x002E43BA File Offset: 0x002E25BA
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

		// Token: 0x17007B8E RID: 31630
		// (get) Token: 0x0601F275 RID: 127605 RVA: 0x002E43CF File Offset: 0x002E25CF
		// (set) Token: 0x0601F276 RID: 127606 RVA: 0x002E43DF File Offset: 0x002E25DF
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

		// Token: 0x17007B8F RID: 31631
		// (get) Token: 0x0601F277 RID: 127607 RVA: 0x002E43F0 File Offset: 0x002E25F0
		// (set) Token: 0x0601F278 RID: 127608 RVA: 0x002E4400 File Offset: 0x002E2600
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

		// Token: 0x17007B90 RID: 31632
		// (get) Token: 0x0601F279 RID: 127609 RVA: 0x002E4411 File Offset: 0x002E2611
		// (set) Token: 0x0601F27A RID: 127610 RVA: 0x002E4421 File Offset: 0x002E2621
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

		// Token: 0x17007B91 RID: 31633
		// (get) Token: 0x0601F27B RID: 127611 RVA: 0x002E4432 File Offset: 0x002E2632
		// (set) Token: 0x0601F27C RID: 127612 RVA: 0x002E4442 File Offset: 0x002E2642
		public unsafe LGUIScaleMode UIScaleMode
		{
			get
			{
				return (LGUIScaleMode)(*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_UIScaleMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_UIScaleMode) = (byte)value;
			}
		}

		// Token: 0x17007B92 RID: 31634
		// (get) Token: 0x0601F27D RID: 127613 RVA: 0x002E4453 File Offset: 0x002E2653
		// (set) Token: 0x0601F27E RID: 127614 RVA: 0x002E4467 File Offset: 0x002E2667
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

		// Token: 0x17007B93 RID: 31635
		// (get) Token: 0x0601F27F RID: 127615 RVA: 0x002E447C File Offset: 0x002E267C
		// (set) Token: 0x0601F280 RID: 127616 RVA: 0x002E448C File Offset: 0x002E268C
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

		// Token: 0x17007B94 RID: 31636
		// (get) Token: 0x0601F281 RID: 127617 RVA: 0x002E449D File Offset: 0x002E269D
		// (set) Token: 0x0601F282 RID: 127618 RVA: 0x002E44AD File Offset: 0x002E26AD
		public unsafe LGUIScreenMatchMode ScreenMatchMode
		{
			get
			{
				return (LGUIScreenMatchMode)(*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ScreenMatchMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvasScaler.__PropertyOffset_ScreenMatchMode) = (byte)value;
			}
		}

		// Token: 0x17007B95 RID: 31637
		// (get) Token: 0x0601F283 RID: 127619 RVA: 0x002E44BE File Offset: 0x002E26BE
		// (set) Token: 0x0601F284 RID: 127620 RVA: 0x002E44D2 File Offset: 0x002E26D2
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

		// Token: 0x0601F285 RID: 127621 RVA: 0x002E44E7 File Offset: 0x002E26E7
		public void SetUIScaleMode(LGUIScaleMode value)
		{
			ULGUICanvasScaler.__SetUIScaleMode_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F286 RID: 127622 RVA: 0x002E44F5 File Offset: 0x002E26F5
		public void SetScreenMatchMode(LGUIScreenMatchMode value)
		{
			ULGUICanvasScaler.__SetScreenMatchMode_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F287 RID: 127623 RVA: 0x002E4503 File Offset: 0x002E2703
		public void SetReferenceResolution(FVector2D value)
		{
			ULGUICanvasScaler.__SetReferenceResolution_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F288 RID: 127624 RVA: 0x002E4511 File Offset: 0x002E2711
		public void SetProjectionType(ECameraProjectionMode value)
		{
			ULGUICanvasScaler.__SetProjectionType_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F289 RID: 127625 RVA: 0x002E4524 File Offset: 0x002E2724
		public void SetNearClipPlane(float value)
		{
			ULGUICanvasScaler.__SetNearClipPlane_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F28A RID: 127626 RVA: 0x002E4532 File Offset: 0x002E2732
		public void SetMatchFromWidthToHeight(float value)
		{
			ULGUICanvasScaler.__SetMatchFromWidthToHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F28B RID: 127627 RVA: 0x002E4540 File Offset: 0x002E2740
		public void SetFovAngle(float value)
		{
			ULGUICanvasScaler.__SetFovAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F28C RID: 127628 RVA: 0x002E454E File Offset: 0x002E274E
		public void SetFarClipPlane(float value)
		{
			ULGUICanvasScaler.__SetFarClipPlane_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F28D RID: 127629 RVA: 0x002E455C File Offset: 0x002E275C
		public unsafe bool Project3DToScreen(in FVector Position3D, ref FVector2D OutPosition2D)
		{
			fixed (FVector2D* ptr = &OutPosition2D)
			{
				void* ptr2 = (void*)ptr;
				return ULGUICanvasScaler.__Project3DToScreen_Internal(base.NativePtr, Position3D, ref OutPosition2D);
			}
		}

		// Token: 0x0601F28E RID: 127630 RVA: 0x002E457B File Offset: 0x002E277B
		public LGUIScaleMode GetUIScaleMode()
		{
			return ULGUICanvasScaler.__GetUIScaleMode_Internal(base.NativePtr);
		}

		// Token: 0x0601F28F RID: 127631 RVA: 0x002E4588 File Offset: 0x002E2788
		public LGUIScreenMatchMode GetScreenMatchMode()
		{
			return ULGUICanvasScaler.__GetScreenMatchMode_Internal(base.NativePtr);
		}

		// Token: 0x0601F290 RID: 127632 RVA: 0x002E4595 File Offset: 0x002E2795
		public FVector2D GetReferenceResolution()
		{
			return ULGUICanvasScaler.__GetReferenceResolution_Internal(base.NativePtr);
		}

		// Token: 0x0601F291 RID: 127633 RVA: 0x002E45A2 File Offset: 0x002E27A2
		public TEnumAsByte<ECameraProjectionMode> GetProjectionType()
		{
			return ULGUICanvasScaler.__GetProjectionType_Internal(base.NativePtr);
		}

		// Token: 0x0601F292 RID: 127634 RVA: 0x002E45AF File Offset: 0x002E27AF
		public float GetNearClipPlane()
		{
			return ULGUICanvasScaler.__GetNearClipPlane_Internal(base.NativePtr);
		}

		// Token: 0x0601F293 RID: 127635 RVA: 0x002E45BC File Offset: 0x002E27BC
		public float GetMatchFromWidthToHeight()
		{
			return ULGUICanvasScaler.__GetMatchFromWidthToHeight_Internal(base.NativePtr);
		}

		// Token: 0x0601F294 RID: 127636 RVA: 0x002E45C9 File Offset: 0x002E27C9
		public float GetFovAngle()
		{
			return ULGUICanvasScaler.__GetFovAngle_Internal(base.NativePtr);
		}

		// Token: 0x0601F295 RID: 127637 RVA: 0x002E45D6 File Offset: 0x002E27D6
		public float GetFarClipPlane()
		{
			return ULGUICanvasScaler.__GetFarClipPlane_Internal(base.NativePtr);
		}

		// Token: 0x0601F296 RID: 127638 RVA: 0x002E45E3 File Offset: 0x002E27E3
		public FVector2D ConvertPositionFromViewportToLGUICanvas(in FVector2D position)
		{
			return ULGUICanvasScaler.__ConvertPositionFromViewportToLGUICanvas_Internal(base.NativePtr, position);
		}

		// Token: 0x0601F297 RID: 127639 RVA: 0x002E45F1 File Offset: 0x002E27F1
		public FVector2D ConvertPositionFromLGUICanvasToViewport(in FVector2D position)
		{
			return ULGUICanvasScaler.__ConvertPositionFromLGUICanvasToViewport_Internal(base.NativePtr, position);
		}

		// Token: 0x0601F298 RID: 127640 RVA: 0x002E4600 File Offset: 0x002E2800
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

		// Token: 0x0601F299 RID: 127641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIScaleMode_Internal(IntPtr @this, LGUIScaleMode value);

		// Token: 0x0601F29A RID: 127642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScreenMatchMode_Internal(IntPtr @this, LGUIScreenMatchMode value);

		// Token: 0x0601F29B RID: 127643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReferenceResolution_Internal(IntPtr @this, FVector2D value);

		// Token: 0x0601F29C RID: 127644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionType_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> value);

		// Token: 0x0601F29D RID: 127645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNearClipPlane_Internal(IntPtr @this, float value);

		// Token: 0x0601F29E RID: 127646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMatchFromWidthToHeight_Internal(IntPtr @this, float value);

		// Token: 0x0601F29F RID: 127647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFovAngle_Internal(IntPtr @this, float value);

		// Token: 0x0601F2A0 RID: 127648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFarClipPlane_Internal(IntPtr @this, float value);

		// Token: 0x0601F2A1 RID: 127649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Project3DToScreen_Internal(IntPtr @this, in FVector Position3D, ref FVector2D OutPosition2D);

		// Token: 0x0601F2A2 RID: 127650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern LGUIScaleMode __GetUIScaleMode_Internal(IntPtr @this);

		// Token: 0x0601F2A3 RID: 127651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern LGUIScreenMatchMode __GetScreenMatchMode_Internal(IntPtr @this);

		// Token: 0x0601F2A4 RID: 127652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetReferenceResolution_Internal(IntPtr @this);

		// Token: 0x0601F2A5 RID: 127653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECameraProjectionMode> __GetProjectionType_Internal(IntPtr @this);

		// Token: 0x0601F2A6 RID: 127654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetNearClipPlane_Internal(IntPtr @this);

		// Token: 0x0601F2A7 RID: 127655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMatchFromWidthToHeight_Internal(IntPtr @this);

		// Token: 0x0601F2A8 RID: 127656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFovAngle_Internal(IntPtr @this);

		// Token: 0x0601F2A9 RID: 127657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFarClipPlane_Internal(IntPtr @this);

		// Token: 0x0601F2AA RID: 127658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertPositionFromViewportToLGUICanvas_Internal(IntPtr @this, in FVector2D position);

		// Token: 0x0601F2AB RID: 127659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertPositionFromLGUICanvasToViewport_Internal(IntPtr @this, in FVector2D position);

		// Token: 0x0601F2AC RID: 127660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateAdaptedSizeAndScale_Internal(IntPtr @this, float Width, float Height, ref float OutWidth, ref float OutHeight, ref float OutScale);

		// Token: 0x0601F2AD RID: 127661 RVA: 0x002E463F File Offset: 0x002E283F
		static ULGUICanvasScaler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICanvasScaler");
		}

		// Token: 0x0601F2AE RID: 127662 RVA: 0x002E464D File Offset: 0x002E284D
		protected ULGUICanvasScaler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DE9 RID: 69097
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUICanvasScaler";

		// Token: 0x04010DEA RID: 69098
		private static IntPtr _ClassPtr;

		// Token: 0x04010DEB RID: 69099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DEC RID: 69100
		internal static int __PropertyOffset_OnViewportSizeChanged;

		// Token: 0x04010DED RID: 69101
		[Nullable(2)]
		private FOnViewportSizeChanged _OnViewportSizeChanged;

		// Token: 0x04010DEE RID: 69102
		internal static int __PropertyOffset_ProjectionType;

		// Token: 0x04010DEF RID: 69103
		internal static int __PropertyOffset_FOVAngle;

		// Token: 0x04010DF0 RID: 69104
		internal static int __PropertyOffset_NearClipPlane;

		// Token: 0x04010DF1 RID: 69105
		internal static int __PropertyOffset_FarClipPlane;

		// Token: 0x04010DF2 RID: 69106
		internal static int __PropertyOffset_UIScaleMode;

		// Token: 0x04010DF3 RID: 69107
		internal static int __PropertyOffset_ReferenceResolution;

		// Token: 0x04010DF4 RID: 69108
		internal static int __PropertyOffset_MatchFromWidthToHeight;

		// Token: 0x04010DF5 RID: 69109
		internal static int __PropertyOffset_ScreenMatchMode;

		// Token: 0x04010DF6 RID: 69110
		internal static int __PropertyOffset_Canvas;
	}
}
