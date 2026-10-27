using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E7 RID: 2279
	[UnrealObjectPath("/Script/Engine.BoxComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UBoxComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007D0A RID: 32010 RVA: 0x000B3453 File Offset: 0x000B1653
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoxComponent._ClassPtr;
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x000B3460 File Offset: 0x000B1660
		public UBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x000B3488 File Offset: 0x000B1688
		[NullableContext(1)]
		public UBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x000B34BB File Offset: 0x000B16BB
		// (set) Token: 0x06007D0E RID: 32014 RVA: 0x000B34CF File Offset: 0x000B16CF
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxComponent.__PropertyOffset_BoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxComponent.__PropertyOffset_BoxExtent) = value;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x000B34E4 File Offset: 0x000B16E4
		// (set) Token: 0x06007D10 RID: 32016 RVA: 0x000B34F4 File Offset: 0x000B16F4
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxComponent.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxComponent.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x000B3505 File Offset: 0x000B1705
		public void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
		{
			UBoxComponent.__SetBoxExtent_Internal(base.NativePtr, InBoxExtent, bUpdateOverlaps);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x000B3514 File Offset: 0x000B1714
		public FVector GetUnscaledBoxExtent()
		{
			return UBoxComponent.__GetUnscaledBoxExtent_Internal(base.NativePtr);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x000B3521 File Offset: 0x000B1721
		public FVector GetScaledBoxExtent()
		{
			return UBoxComponent.__GetScaledBoxExtent_Internal(base.NativePtr);
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x000B352E File Offset: 0x000B172E
		public void D_SetBoxExtent(FVectorDouble InBoxExtent, bool bUpdateOverlaps = true)
		{
			UBoxComponent.__D_SetBoxExtent_Internal(base.NativePtr, InBoxExtent, bUpdateOverlaps);
		}

		// Token: 0x06007D15 RID: 32021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxExtent_Internal(IntPtr @this, FVector InBoxExtent, bool bUpdateOverlaps);

		// Token: 0x06007D16 RID: 32022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUnscaledBoxExtent_Internal(IntPtr @this);

		// Token: 0x06007D17 RID: 32023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaledBoxExtent_Internal(IntPtr @this);

		// Token: 0x06007D18 RID: 32024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetBoxExtent_Internal(IntPtr @this, FVectorDouble InBoxExtent, bool bUpdateOverlaps);

		// Token: 0x06007D19 RID: 32025 RVA: 0x000B353D File Offset: 0x000B173D
		static UBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoxComponent");
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x000B354B File Offset: 0x000B174B
		protected UBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BEF RID: 15343
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BoxComponent";

		// Token: 0x04003BF0 RID: 15344
		private static IntPtr _ClassPtr;

		// Token: 0x04003BF1 RID: 15345
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BF2 RID: 15346
		internal static int __PropertyOffset_BoxExtent;

		// Token: 0x04003BF3 RID: 15347
		internal static int __PropertyOffset_LineThickness;
	}
}
