using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000195 RID: 405
	[UnrealObjectPath("/Script/Engine.BoxComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UBoxComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B2D RID: 6957 RVA: 0x000287D2 File Offset: 0x000269D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoxComponent._ClassPtr;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000287E0 File Offset: 0x000269E0
		public UBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00028808 File Offset: 0x00026A08
		[NullableContext(1)]
		public UBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0002883B File Offset: 0x00026A3B
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0002884F File Offset: 0x00026A4F
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00028864 File Offset: 0x00026A64
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00028874 File Offset: 0x00026A74
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

		// Token: 0x06001B34 RID: 6964 RVA: 0x00028885 File Offset: 0x00026A85
		public void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
		{
			UBoxComponent.__SetBoxExtent_Internal(base.NativePtr, InBoxExtent, bUpdateOverlaps);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00028894 File Offset: 0x00026A94
		public FVector GetUnscaledBoxExtent()
		{
			return UBoxComponent.__GetUnscaledBoxExtent_Internal(base.NativePtr);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000288A1 File Offset: 0x00026AA1
		public FVector GetScaledBoxExtent()
		{
			return UBoxComponent.__GetScaledBoxExtent_Internal(base.NativePtr);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000288AE File Offset: 0x00026AAE
		public void D_SetBoxExtent(FVectorDouble InBoxExtent, bool bUpdateOverlaps = true)
		{
			UBoxComponent.__D_SetBoxExtent_Internal(base.NativePtr, InBoxExtent, bUpdateOverlaps);
		}

		// Token: 0x06001B38 RID: 6968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxExtent_Internal(IntPtr @this, FVector InBoxExtent, bool bUpdateOverlaps);

		// Token: 0x06001B39 RID: 6969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUnscaledBoxExtent_Internal(IntPtr @this);

		// Token: 0x06001B3A RID: 6970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaledBoxExtent_Internal(IntPtr @this);

		// Token: 0x06001B3B RID: 6971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetBoxExtent_Internal(IntPtr @this, FVectorDouble InBoxExtent, bool bUpdateOverlaps);

		// Token: 0x06001B3C RID: 6972 RVA: 0x000288BD File Offset: 0x00026ABD
		static UBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoxComponent");
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000288CB File Offset: 0x00026ACB
		protected UBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008C0 RID: 2240
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BoxComponent";

		// Token: 0x040008C1 RID: 2241
		private static IntPtr _ClassPtr;

		// Token: 0x040008C2 RID: 2242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008C3 RID: 2243
		internal static int __PropertyOffset_BoxExtent;

		// Token: 0x040008C4 RID: 2244
		internal static int __PropertyOffset_LineThickness;
	}
}
