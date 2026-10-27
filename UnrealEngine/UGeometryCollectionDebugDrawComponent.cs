using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200142D RID: 5165
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawComponent")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1720)]
	public class UGeometryCollectionDebugDrawComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012E6D RID: 77421 RVA: 0x001BC8C0 File Offset: 0x001BAAC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCollectionDebugDrawComponent._ClassPtr;
		}

		// Token: 0x06012E6E RID: 77422 RVA: 0x001BC8CC File Offset: 0x001BAACC
		public UGeometryCollectionDebugDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionDebugDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012E6F RID: 77423 RVA: 0x001BC8F4 File Offset: 0x001BAAF4
		[NullableContext(1)]
		public UGeometryCollectionDebugDrawComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionDebugDrawComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06012E70 RID: 77424 RVA: 0x001BC927 File Offset: 0x001BAB27
		// (set) Token: 0x06012E71 RID: 77425 RVA: 0x001BC93B File Offset: 0x001BAB3B
		public unsafe AGeometryCollectionDebugDrawActor GeometryCollectionDebugDrawActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGeometryCollectionDebugDrawActor>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionDebugDrawComponent.__PropertyOffset_GeometryCollectionDebugDrawActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionDebugDrawComponent.__PropertyOffset_GeometryCollectionDebugDrawActor, value);
			}
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x06012E72 RID: 77426 RVA: 0x001BC950 File Offset: 0x001BAB50
		// (set) Token: 0x06012E73 RID: 77427 RVA: 0x001BC964 File Offset: 0x001BAB64
		public unsafe AGeometryCollectionRenderLevelSetActor GeometryCollectionRenderLevelSetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGeometryCollectionRenderLevelSetActor>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionDebugDrawComponent.__PropertyOffset_GeometryCollectionRenderLevelSetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionDebugDrawComponent.__PropertyOffset_GeometryCollectionRenderLevelSetActor, value);
			}
		}

		// Token: 0x06012E74 RID: 77428 RVA: 0x001BC979 File Offset: 0x001BAB79
		static UGeometryCollectionDebugDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawComponent");
		}

		// Token: 0x06012E75 RID: 77429 RVA: 0x001BC987 File Offset: 0x001BAB87
		protected UGeometryCollectionDebugDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A19A RID: 41370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawComponent";

		// Token: 0x0400A19B RID: 41371
		private static IntPtr _ClassPtr;

		// Token: 0x0400A19C RID: 41372
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A19D RID: 41373
		internal static int __PropertyOffset_GeometryCollectionDebugDrawActor;

		// Token: 0x0400A19E RID: 41374
		internal static int __PropertyOffset_GeometryCollectionRenderLevelSetActor;
	}
}
