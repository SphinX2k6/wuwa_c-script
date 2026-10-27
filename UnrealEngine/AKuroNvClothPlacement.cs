using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B82 RID: 7042
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class AKuroNvClothPlacement : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AB85 RID: 109445 RVA: 0x00275EAA File Offset: 0x002740AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothPlacement._ClassPtr;
		}

		// Token: 0x0601AB86 RID: 109446 RVA: 0x00275EB8 File Offset: 0x002740B8
		public AKuroNvClothPlacement() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AB87 RID: 109447 RVA: 0x00275EE0 File Offset: 0x002740E0
		[NullableContext(1)]
		public AKuroNvClothPlacement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B76 RID: 27510
		// (get) Token: 0x0601AB88 RID: 109448 RVA: 0x00275F13 File Offset: 0x00274113
		// (set) Token: 0x0601AB89 RID: 109449 RVA: 0x00275F23 File Offset: 0x00274123
		public unsafe bool bUseRandomWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bUseRandomWind) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bUseRandomWind) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B77 RID: 27511
		// (get) Token: 0x0601AB8A RID: 109450 RVA: 0x00275F34 File Offset: 0x00274134
		// (set) Token: 0x0601AB8B RID: 109451 RVA: 0x00275F44 File Offset: 0x00274144
		public unsafe float RandomWindFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_RandomWindFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_RandomWindFrequency) = value;
			}
		}

		// Token: 0x17006B78 RID: 27512
		// (get) Token: 0x0601AB8C RID: 109452 RVA: 0x00275F55 File Offset: 0x00274155
		// (set) Token: 0x0601AB8D RID: 109453 RVA: 0x00275F65 File Offset: 0x00274165
		public unsafe float RandomWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_RandomWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_RandomWindStrength) = value;
			}
		}

		// Token: 0x17006B79 RID: 27513
		// (get) Token: 0x0601AB8E RID: 109454 RVA: 0x00275F76 File Offset: 0x00274176
		// (set) Token: 0x0601AB8F RID: 109455 RVA: 0x00275F86 File Offset: 0x00274186
		public unsafe bool bUseValidBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bUseValidBound) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bUseValidBound) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7A RID: 27514
		// (get) Token: 0x0601AB90 RID: 109456 RVA: 0x00275F97 File Offset: 0x00274197
		// (set) Token: 0x0601AB91 RID: 109457 RVA: 0x00275FAB File Offset: 0x002741AB
		public unsafe FBoxSphereBounds ValidBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_ValidBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_ValidBound) = value;
			}
		}

		// Token: 0x17006B7B RID: 27515
		// (get) Token: 0x0601AB92 RID: 109458 RVA: 0x00275FC0 File Offset: 0x002741C0
		// (set) Token: 0x0601AB93 RID: 109459 RVA: 0x00275FD0 File Offset: 0x002741D0
		public unsafe bool bDrawDebugSelfCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bDrawDebugSelfCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_bDrawDebugSelfCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B7C RID: 27516
		// (get) Token: 0x0601AB94 RID: 109460 RVA: 0x00275FE1 File Offset: 0x002741E1
		// (set) Token: 0x0601AB95 RID: 109461 RVA: 0x00275FF5 File Offset: 0x002741F5
		public unsafe FLinearColor DrawDebugSelfCollisionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_DrawDebugSelfCollisionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothPlacement.__PropertyOffset_DrawDebugSelfCollisionColor) = value;
			}
		}

		// Token: 0x0601AB96 RID: 109462 RVA: 0x0027600A File Offset: 0x0027420A
		public void SetEnabled(bool Enable)
		{
			AKuroNvClothPlacement.__SetEnabled_Internal(base.NativePtr, Enable);
		}

		// Token: 0x0601AB97 RID: 109463 RVA: 0x00276018 File Offset: 0x00274218
		public bool IsEnabled()
		{
			return AKuroNvClothPlacement.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0601AB98 RID: 109464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool Enable);

		// Token: 0x0601AB99 RID: 109465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x0601AB9A RID: 109466 RVA: 0x00276025 File Offset: 0x00274225
		static AKuroNvClothPlacement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement");
		}

		// Token: 0x0601AB9B RID: 109467 RVA: 0x00276033 File Offset: 0x00274233
		protected AKuroNvClothPlacement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E745 RID: 59205
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement";

		// Token: 0x0400E746 RID: 59206
		private static IntPtr _ClassPtr;

		// Token: 0x0400E747 RID: 59207
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E748 RID: 59208
		internal static int __PropertyOffset_bUseRandomWind;

		// Token: 0x0400E749 RID: 59209
		internal static int __PropertyOffset_RandomWindFrequency;

		// Token: 0x0400E74A RID: 59210
		internal static int __PropertyOffset_RandomWindStrength;

		// Token: 0x0400E74B RID: 59211
		internal static int __PropertyOffset_bUseValidBound;

		// Token: 0x0400E74C RID: 59212
		internal static int __PropertyOffset_ValidBound;

		// Token: 0x0400E74D RID: 59213
		internal static int __PropertyOffset_bDrawDebugSelfCollision;

		// Token: 0x0400E74E RID: 59214
		internal static int __PropertyOffset_DrawDebugSelfCollisionColor;
	}
}
