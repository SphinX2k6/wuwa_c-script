using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001428 RID: 5160
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AGeometryCollectionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012D74 RID: 77172 RVA: 0x001BB529 File Offset: 0x001B9729
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGeometryCollectionActor._ClassPtr;
		}

		// Token: 0x06012D75 RID: 77173 RVA: 0x001BB538 File Offset: 0x001B9738
		public AGeometryCollectionActor() : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012D76 RID: 77174 RVA: 0x001BB560 File Offset: 0x001B9760
		[NullableContext(1)]
		public AGeometryCollectionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x06012D77 RID: 77175 RVA: 0x001BB593 File Offset: 0x001B9793
		// (set) Token: 0x06012D78 RID: 77176 RVA: 0x001BB5A7 File Offset: 0x001B97A7
		public unsafe UGeometryCollectionComponent GeometryCollectionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCollectionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionActor.__PropertyOffset_GeometryCollectionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionActor.__PropertyOffset_GeometryCollectionComponent, value);
			}
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x06012D79 RID: 77177 RVA: 0x001BB5BC File Offset: 0x001B97BC
		// (set) Token: 0x06012D7A RID: 77178 RVA: 0x001BB5D0 File Offset: 0x001B97D0
		public unsafe UGeometryCollectionDebugDrawComponent GeometryCollectionDebugDrawComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCollectionDebugDrawComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionActor.__PropertyOffset_GeometryCollectionDebugDrawComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionActor.__PropertyOffset_GeometryCollectionDebugDrawComponent, value);
			}
		}

		// Token: 0x06012D7B RID: 77179 RVA: 0x001BB5E5 File Offset: 0x001B97E5
		public bool RaycastSingle(FVector Start, FVector End, ref FHitResult OutHit)
		{
			return AGeometryCollectionActor.__RaycastSingle_Internal(base.NativePtr, Start, End, (OutHit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06012D7C RID: 77180 RVA: 0x001BB604 File Offset: 0x001B9804
		public void ChangeObjectTypeRuntime(EObjectStateTypeEnum type)
		{
			AGeometryCollectionActor.__ChangeObjectTypeRuntime_Internal(base.NativePtr, type);
		}

		// Token: 0x06012D7D RID: 77181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RaycastSingle_Internal(IntPtr @this, FVector Start, FVector End, IntPtr OutHit);

		// Token: 0x06012D7E RID: 77182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeObjectTypeRuntime_Internal(IntPtr @this, EObjectStateTypeEnum type);

		// Token: 0x06012D7F RID: 77183 RVA: 0x001BB612 File Offset: 0x001B9812
		static AGeometryCollectionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionActor");
		}

		// Token: 0x06012D80 RID: 77184 RVA: 0x001BB620 File Offset: 0x001B9820
		protected AGeometryCollectionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A119 RID: 41241
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionActor";

		// Token: 0x0400A11A RID: 41242
		private static IntPtr _ClassPtr;

		// Token: 0x0400A11B RID: 41243
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A11C RID: 41244
		internal static int __PropertyOffset_GeometryCollectionComponent;

		// Token: 0x0400A11D RID: 41245
		internal static int __PropertyOffset_GeometryCollectionDebugDrawComponent;
	}
}
