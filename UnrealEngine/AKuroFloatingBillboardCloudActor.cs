using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AFA RID: 6906
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AKuroFloatingBillboardCloudActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CD2 RID: 105682 RVA: 0x00261B8F File Offset: 0x0025FD8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFloatingBillboardCloudActor._ClassPtr;
		}

		// Token: 0x06019CD3 RID: 105683 RVA: 0x00261B9C File Offset: 0x0025FD9C
		public AKuroFloatingBillboardCloudActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingBillboardCloudActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CD4 RID: 105684 RVA: 0x00261BC4 File Offset: 0x0025FDC4
		[NullableContext(1)]
		public AKuroFloatingBillboardCloudActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFloatingBillboardCloudActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019CD5 RID: 105685 RVA: 0x00261BF7 File Offset: 0x0025FDF7
		[NullableContext(1)]
		public TArray<FVector2D> FastPoissonDiscSampling(FVector2D Range, int thresold, FVector2D center)
		{
			return new TArray<FVector2D>(AKuroFloatingBillboardCloudActor.__FastPoissonDiscSampling_Internal(base.NativePtr, Range, thresold, center), null);
		}

		// Token: 0x06019CD6 RID: 105686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FastPoissonDiscSampling_Internal(IntPtr @this, FVector2D Range, int thresold, FVector2D center);

		// Token: 0x06019CD7 RID: 105687 RVA: 0x00261C0D File Offset: 0x0025FE0D
		static AKuroFloatingBillboardCloudActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudActor");
		}

		// Token: 0x06019CD8 RID: 105688 RVA: 0x00261C1B File Offset: 0x0025FE1B
		protected AKuroFloatingBillboardCloudActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E082 RID: 57474
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatingBillboardCloudActor";

		// Token: 0x0400E083 RID: 57475
		private static IntPtr _ClassPtr;

		// Token: 0x0400E084 RID: 57476
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
