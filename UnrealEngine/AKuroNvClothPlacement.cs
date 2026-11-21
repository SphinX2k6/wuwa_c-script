using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D5 RID: 1237
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class AKuroNvClothPlacement : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600738A RID: 29578 RVA: 0x000A96D6 File Offset: 0x000A78D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothPlacement._ClassPtr;
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x000A96E4 File Offset: 0x000A78E4
		public AKuroNvClothPlacement() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x000A970C File Offset: 0x000A790C
		[NullableContext(1)]
		public AKuroNvClothPlacement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x0600738D RID: 29581 RVA: 0x000A973F File Offset: 0x000A793F
		// (set) Token: 0x0600738E RID: 29582 RVA: 0x000A974F File Offset: 0x000A794F
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

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x0600738F RID: 29583 RVA: 0x000A9760 File Offset: 0x000A7960
		// (set) Token: 0x06007390 RID: 29584 RVA: 0x000A9770 File Offset: 0x000A7970
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x000A9781 File Offset: 0x000A7981
		// (set) Token: 0x06007392 RID: 29586 RVA: 0x000A9791 File Offset: 0x000A7991
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x000A97A2 File Offset: 0x000A79A2
		// (set) Token: 0x06007394 RID: 29588 RVA: 0x000A97B2 File Offset: 0x000A79B2
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

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x000A97C3 File Offset: 0x000A79C3
		// (set) Token: 0x06007396 RID: 29590 RVA: 0x000A97D7 File Offset: 0x000A79D7
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

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x000A97EC File Offset: 0x000A79EC
		// (set) Token: 0x06007398 RID: 29592 RVA: 0x000A97FC File Offset: 0x000A79FC
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

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06007399 RID: 29593 RVA: 0x000A980D File Offset: 0x000A7A0D
		// (set) Token: 0x0600739A RID: 29594 RVA: 0x000A9821 File Offset: 0x000A7A21
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

		// Token: 0x0600739B RID: 29595 RVA: 0x000A9836 File Offset: 0x000A7A36
		public void SetEnabled(bool Enable)
		{
			AKuroNvClothPlacement.__SetEnabled_Internal(base.NativePtr, Enable);
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x000A9844 File Offset: 0x000A7A44
		public bool IsEnabled()
		{
			return AKuroNvClothPlacement.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600739D RID: 29597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool Enable);

		// Token: 0x0600739E RID: 29598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x0600739F RID: 29599 RVA: 0x000A9851 File Offset: 0x000A7A51
		static AKuroNvClothPlacement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement");
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x000A985F File Offset: 0x000A7A5F
		protected AKuroNvClothPlacement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003183 RID: 12675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacement";

		// Token: 0x04003184 RID: 12676
		private static IntPtr _ClassPtr;

		// Token: 0x04003185 RID: 12677
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003186 RID: 12678
		internal static int __PropertyOffset_bUseRandomWind;

		// Token: 0x04003187 RID: 12679
		internal static int __PropertyOffset_RandomWindFrequency;

		// Token: 0x04003188 RID: 12680
		internal static int __PropertyOffset_RandomWindStrength;

		// Token: 0x04003189 RID: 12681
		internal static int __PropertyOffset_bUseValidBound;

		// Token: 0x0400318A RID: 12682
		internal static int __PropertyOffset_ValidBound;

		// Token: 0x0400318B RID: 12683
		internal static int __PropertyOffset_bDrawDebugSelfCollision;

		// Token: 0x0400318C RID: 12684
		internal static int __PropertyOffset_DrawDebugSelfCollisionColor;
	}
}
