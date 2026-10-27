using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140D RID: 5133
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AGeometryCacheActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012BCA RID: 76746 RVA: 0x001B9535 File Offset: 0x001B7735
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGeometryCacheActor._ClassPtr;
		}

		// Token: 0x06012BCB RID: 76747 RVA: 0x001B9544 File Offset: 0x001B7744
		public AGeometryCacheActor() : this(BuiltinUtils.AllocNativeUObject(AGeometryCacheActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BCC RID: 76748 RVA: 0x001B956C File Offset: 0x001B776C
		[NullableContext(1)]
		public AGeometryCacheActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGeometryCacheActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06012BCD RID: 76749 RVA: 0x001B959F File Offset: 0x001B779F
		// (set) Token: 0x06012BCE RID: 76750 RVA: 0x001B95B3 File Offset: 0x001B77B3
		public unsafe UGeometryCacheComponent GeometryCacheComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCacheComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCacheActor.__PropertyOffset_GeometryCacheComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCacheActor.__PropertyOffset_GeometryCacheComponent, value);
			}
		}

		// Token: 0x06012BCF RID: 76751 RVA: 0x001B95C8 File Offset: 0x001B77C8
		public UGeometryCacheComponent GetGeometryCacheComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGeometryCacheComponent>(AGeometryCacheActor.__GetGeometryCacheComponent_Internal(base.NativePtr));
		}

		// Token: 0x06012BD0 RID: 76752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGeometryCacheComponent_Internal(IntPtr @this);

		// Token: 0x06012BD1 RID: 76753 RVA: 0x001B95DA File Offset: 0x001B77DA
		static AGeometryCacheActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheActor");
		}

		// Token: 0x06012BD2 RID: 76754 RVA: 0x001B95E8 File Offset: 0x001B77E8
		protected AGeometryCacheActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A04A RID: 41034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheActor";

		// Token: 0x0400A04B RID: 41035
		private static IntPtr _ClassPtr;

		// Token: 0x0400A04C RID: 41036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A04D RID: 41037
		internal static int __PropertyOffset_GeometryCacheComponent;
	}
}
