using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000878 RID: 2168
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetLayoutLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWidgetLayoutLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD2A RID: 48426 RVA: 0x0012DE90 File Offset: 0x0012C090
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetLayoutLibrary._ClassPtr;
		}

		// Token: 0x0600BD2B RID: 48427 RVA: 0x0012DE9C File Offset: 0x0012C09C
		public UWidgetLayoutLibrary() : this(BuiltinUtils.AllocNativeUObject(UWidgetLayoutLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x0012DEC4 File Offset: 0x0012C0C4
		[NullableContext(1)]
		public UWidgetLayoutLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetLayoutLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x0012DEF7 File Offset: 0x0012C0F7
		public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvasPanelSlot>(UWidgetLayoutLibrary.__SlotAsCanvasSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x0012DF13 File Offset: 0x0012C113
		public static void RemoveAllWidgets(UObject WorldContextObject)
		{
			UWidgetLayoutLibrary.__RemoveAllWidgets_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x0012DF2C File Offset: 0x0012C12C
		public unsafe static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UWidgetLayoutLibrary.__ProjectWorldLocationToWidgetPosition_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, WorldLocation, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x0600BD30 RID: 48432 RVA: 0x0012DF56 File Offset: 0x0012C156
		public static FVector2D GetViewportSize(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetViewportSize_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BD31 RID: 48433 RVA: 0x0012DF6D File Offset: 0x0012C16D
		public static float GetViewportScale(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetViewportScale_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BD32 RID: 48434 RVA: 0x0012DF84 File Offset: 0x0012C184
		public unsafe static bool GetMousePositionScaledByDPI(APlayerController Player, ref float LocationX, ref float LocationY)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					return UWidgetLayoutLibrary.__GetMousePositionScaledByDPI_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ref LocationX, ref LocationY);
				}
			}
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x0012DFB2 File Offset: 0x0012C1B2
		public static FVector2D GetMousePositionOnViewport(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetMousePositionOnViewport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BD34 RID: 48436
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetMousePositionOnPlatform();

		// Token: 0x0600BD35 RID: 48437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsCanvasSlot_Internal(IntPtr Widget);

		// Token: 0x0600BD36 RID: 48438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllWidgets_Internal(IntPtr WorldContextObject);

		// Token: 0x0600BD37 RID: 48439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldLocationToWidgetPosition_Internal(IntPtr PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x0600BD38 RID: 48440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetViewportSize_Internal(IntPtr WorldContextObject);

		// Token: 0x0600BD39 RID: 48441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetViewportScale_Internal(IntPtr WorldContextObject);

		// Token: 0x0600BD3A RID: 48442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetMousePositionScaledByDPI_Internal(IntPtr Player, ref float LocationX, ref float LocationY);

		// Token: 0x0600BD3B RID: 48443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetMousePositionOnViewport_Internal(IntPtr WorldContextObject);

		// Token: 0x0600BD3C RID: 48444 RVA: 0x0012DFC9 File Offset: 0x0012C1C9
		static UWidgetLayoutLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetLayoutLibrary");
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x0012DFD7 File Offset: 0x0012C1D7
		protected UWidgetLayoutLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400556C RID: 21868
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetLayoutLibrary";

		// Token: 0x0400556D RID: 21869
		private static IntPtr _ClassPtr;

		// Token: 0x0400556E RID: 21870
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
