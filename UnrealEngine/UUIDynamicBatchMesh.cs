using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002142 RID: 8514
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynamicBatchMesh")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2144)]
	public class UUIDynamicBatchMesh : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602010F RID: 131343 RVA: 0x002FAFE2 File Offset: 0x002F91E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynamicBatchMesh._ClassPtr;
		}

		// Token: 0x06020110 RID: 131344 RVA: 0x002FAFF0 File Offset: 0x002F91F0
		public UUIDynamicBatchMesh() : this(BuiltinUtils.AllocNativeUObject(UUIDynamicBatchMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020111 RID: 131345 RVA: 0x002FB018 File Offset: 0x002F9218
		public UUIDynamicBatchMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynamicBatchMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DF1 RID: 32241
		// (get) Token: 0x06020112 RID: 131346 RVA: 0x002FB04C File Offset: 0x002F924C
		// (set) Token: 0x06020113 RID: 131347 RVA: 0x002FB085 File Offset: 0x002F9285
		public TMap<int, UGeometryHandle> GeometryHandleMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UGeometryHandle> result;
				if ((result = this._GeometryHandleMap) == null)
				{
					result = (this._GeometryHandleMap = new TMap<int, UGeometryHandle>(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_GeometryHandleMap, this));
				}
				return result;
			}
			set
			{
				this.GeometryHandleMap.CopyAssign(value);
			}
		}

		// Token: 0x17007DF2 RID: 32242
		// (get) Token: 0x06020114 RID: 131348 RVA: 0x002FB094 File Offset: 0x002F9294
		// (set) Token: 0x06020115 RID: 131349 RVA: 0x002FB0CD File Offset: 0x002F92CD
		public TArray<UGeometryHandle> GeometryHandlePool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGeometryHandle> result;
				if ((result = this._GeometryHandlePool) == null)
				{
					result = (this._GeometryHandlePool = new TArray<UGeometryHandle>(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_GeometryHandlePool, this));
				}
				return result;
			}
			set
			{
				this.GeometryHandlePool.CopyAssign(value);
			}
		}

		// Token: 0x17007DF3 RID: 32243
		// (get) Token: 0x06020116 RID: 131350 RVA: 0x002FB0DB File Offset: 0x002F92DB
		// (set) Token: 0x06020117 RID: 131351 RVA: 0x002FB0EB File Offset: 0x002F92EB
		public unsafe bool bGenerateGeometryHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_bGenerateGeometryHandle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_bGenerateGeometryHandle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007DF4 RID: 32244
		// (get) Token: 0x06020118 RID: 131352 RVA: 0x002FB0FC File Offset: 0x002F92FC
		// (set) Token: 0x06020119 RID: 131353 RVA: 0x002FB10C File Offset: 0x002F930C
		public unsafe int GeometryHandleMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_GeometryHandleMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_GeometryHandleMaxCount) = value;
			}
		}

		// Token: 0x17007DF5 RID: 32245
		// (get) Token: 0x0602011A RID: 131354 RVA: 0x002FB11D File Offset: 0x002F931D
		// (set) Token: 0x0602011B RID: 131355 RVA: 0x002FB12D File Offset: 0x002F932D
		public unsafe float SingleGeometryExistTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_SingleGeometryExistTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_SingleGeometryExistTime) = value;
			}
		}

		// Token: 0x17007DF6 RID: 32246
		// (get) Token: 0x0602011C RID: 131356 RVA: 0x002FB13E File Offset: 0x002F933E
		// (set) Token: 0x0602011D RID: 131357 RVA: 0x002FB14E File Offset: 0x002F934E
		public unsafe int MaxVerticeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_MaxVerticeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynamicBatchMesh.__PropertyOffset_MaxVerticeCount) = value;
			}
		}

		// Token: 0x0602011E RID: 131358 RVA: 0x002FB15F File Offset: 0x002F935F
		[NullableContext(2)]
		public void MarkAllItemGeometryDirty(UUIItem ContainerNode)
		{
			UUIDynamicBatchMesh.__MarkAllItemGeometryDirty_Internal(base.NativePtr, (ContainerNode != null) ? ContainerNode.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602011F RID: 131359 RVA: 0x002FB17C File Offset: 0x002F937C
		public void ClearAllGeometries()
		{
			UUIDynamicBatchMesh.__ClearAllGeometries_Internal(base.NativePtr);
		}

		// Token: 0x06020120 RID: 131360 RVA: 0x002FB189 File Offset: 0x002F9389
		[NullableContext(2)]
		public void AddContainerNode(UUIItem ContainerNode, bool bClearTransformChanged = false)
		{
			UUIDynamicBatchMesh.__AddContainerNode_Internal(base.NativePtr, (ContainerNode != null) ? ContainerNode.NativePtr : IntPtr.Zero, bClearTransformChanged);
		}

		// Token: 0x06020121 RID: 131361 RVA: 0x002FB1A7 File Offset: 0x002F93A7
		[NullableContext(2)]
		public UGeometryHandle AddBatchGeometryRenderable(UUIBatchGeometryRenderable Renderable)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGeometryHandle>(UUIDynamicBatchMesh.__AddBatchGeometryRenderable_Internal(base.NativePtr, (Renderable != null) ? Renderable.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06020122 RID: 131362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkAllItemGeometryDirty_Internal(IntPtr @this, IntPtr ContainerNode);

		// Token: 0x06020123 RID: 131363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllGeometries_Internal(IntPtr @this);

		// Token: 0x06020124 RID: 131364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddContainerNode_Internal(IntPtr @this, IntPtr ContainerNode, bool bClearTransformChanged);

		// Token: 0x06020125 RID: 131365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddBatchGeometryRenderable_Internal(IntPtr @this, IntPtr Renderable);

		// Token: 0x06020126 RID: 131366 RVA: 0x002FB1C9 File Offset: 0x002F93C9
		static UUIDynamicBatchMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynamicBatchMesh");
		}

		// Token: 0x06020127 RID: 131367 RVA: 0x002FB1D7 File Offset: 0x002F93D7
		protected UUIDynamicBatchMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401142D RID: 70701
		public new const string __ObjectPath = "/Script/LGUI.UIDynamicBatchMesh";

		// Token: 0x0401142E RID: 70702
		private static IntPtr _ClassPtr;

		// Token: 0x0401142F RID: 70703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011430 RID: 70704
		internal static int __PropertyOffset_GeometryHandleMap;

		// Token: 0x04011431 RID: 70705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UGeometryHandle> _GeometryHandleMap;

		// Token: 0x04011432 RID: 70706
		internal static int __PropertyOffset_GeometryHandlePool;

		// Token: 0x04011433 RID: 70707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGeometryHandle> _GeometryHandlePool;

		// Token: 0x04011434 RID: 70708
		internal static int __PropertyOffset_bGenerateGeometryHandle;

		// Token: 0x04011435 RID: 70709
		internal static int __PropertyOffset_GeometryHandleMaxCount;

		// Token: 0x04011436 RID: 70710
		internal static int __PropertyOffset_SingleGeometryExistTime;

		// Token: 0x04011437 RID: 70711
		internal static int __PropertyOffset_MaxVerticeCount;
	}
}
