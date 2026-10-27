using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B29 RID: 6953
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionPlacement")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroInteractionPlacement : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A3D9 RID: 107481 RVA: 0x0026BA0A File Offset: 0x00269C0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroInteractionPlacement._ClassPtr;
		}

		// Token: 0x0601A3DA RID: 107482 RVA: 0x0026BA18 File Offset: 0x00269C18
		public AKuroInteractionPlacement() : this(BuiltinUtils.AllocNativeUObject(AKuroInteractionPlacement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A3DB RID: 107483 RVA: 0x0026BA40 File Offset: 0x00269C40
		[NullableContext(1)]
		public AKuroInteractionPlacement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroInteractionPlacement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700698A RID: 27018
		// (get) Token: 0x0601A3DC RID: 107484 RVA: 0x0026BA73 File Offset: 0x00269C73
		// (set) Token: 0x0601A3DD RID: 107485 RVA: 0x0026BA87 File Offset: 0x00269C87
		public unsafe UStaticMeshComponent StaticComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInteractionPlacement.__PropertyOffset_StaticComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInteractionPlacement.__PropertyOffset_StaticComp, value);
			}
		}

		// Token: 0x1700698B RID: 27019
		// (get) Token: 0x0601A3DE RID: 107486 RVA: 0x0026BA9C File Offset: 0x00269C9C
		// (set) Token: 0x0601A3DF RID: 107487 RVA: 0x0026BAB0 File Offset: 0x00269CB0
		public unsafe UStaticMeshComponent TriggerComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInteractionPlacement.__PropertyOffset_TriggerComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInteractionPlacement.__PropertyOffset_TriggerComp, value);
			}
		}

		// Token: 0x0601A3E0 RID: 107488 RVA: 0x0026BAC5 File Offset: 0x00269CC5
		public void OnTriggerComponentEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			AKuroInteractionPlacement.__OnTriggerComponentEndOverlap_Internal(base.NativePtr, (OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex);
		}

		// Token: 0x0601A3E1 RID: 107489 RVA: 0x0026BB04 File Offset: 0x00269D04
		public void OnTriggerComponentBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			AKuroInteractionPlacement.__OnTriggerComponentBeginOverlap_Internal(base.NativePtr, (OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0601A3E2 RID: 107490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTriggerComponentEndOverlap_Internal(IntPtr @this, IntPtr OverlappedComponent, IntPtr OtherActor, IntPtr OtherComp, int OtherBodyIndex);

		// Token: 0x0601A3E3 RID: 107491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTriggerComponentBeginOverlap_Internal(IntPtr @this, IntPtr OverlappedComponent, IntPtr OtherActor, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x0601A3E4 RID: 107492 RVA: 0x0026BB61 File Offset: 0x00269D61
		static AKuroInteractionPlacement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionPlacement");
		}

		// Token: 0x0601A3E5 RID: 107493 RVA: 0x0026BB6F File Offset: 0x00269D6F
		protected AKuroInteractionPlacement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E3EC RID: 58348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionPlacement";

		// Token: 0x0400E3ED RID: 58349
		private static IntPtr _ClassPtr;

		// Token: 0x0400E3EE RID: 58350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E3EF RID: 58351
		internal static int __PropertyOffset_StaticComp;

		// Token: 0x0400E3F0 RID: 58352
		internal static int __PropertyOffset_TriggerComp;
	}
}
