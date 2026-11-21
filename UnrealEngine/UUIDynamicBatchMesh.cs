using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F5 RID: 1781
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynamicBatchMesh")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2144)]
	public class UUIDynamicBatchMesh : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009752 RID: 38738 RVA: 0x000E44CE File Offset: 0x000E26CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynamicBatchMesh._ClassPtr;
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x000E44DC File Offset: 0x000E26DC
		public UUIDynamicBatchMesh() : this(BuiltinUtils.AllocNativeUObject(UUIDynamicBatchMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x000E4504 File Offset: 0x000E2704
		public UUIDynamicBatchMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynamicBatchMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x000E4538 File Offset: 0x000E2738
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x000E4571 File Offset: 0x000E2771
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

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x000E4580 File Offset: 0x000E2780
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x000E45B9 File Offset: 0x000E27B9
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

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x000E45C7 File Offset: 0x000E27C7
		// (set) Token: 0x0600975A RID: 38746 RVA: 0x000E45D7 File Offset: 0x000E27D7
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

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x000E45E8 File Offset: 0x000E27E8
		// (set) Token: 0x0600975C RID: 38748 RVA: 0x000E45F8 File Offset: 0x000E27F8
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

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x000E4609 File Offset: 0x000E2809
		// (set) Token: 0x0600975E RID: 38750 RVA: 0x000E4619 File Offset: 0x000E2819
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

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x000E462A File Offset: 0x000E282A
		// (set) Token: 0x06009760 RID: 38752 RVA: 0x000E463A File Offset: 0x000E283A
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

		// Token: 0x06009761 RID: 38753 RVA: 0x000E464B File Offset: 0x000E284B
		[NullableContext(2)]
		public void MarkAllItemGeometryDirty(UUIItem ContainerNode)
		{
			UUIDynamicBatchMesh.__MarkAllItemGeometryDirty_Internal(base.NativePtr, (ContainerNode != null) ? ContainerNode.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x000E4668 File Offset: 0x000E2868
		public void ClearAllGeometries()
		{
			UUIDynamicBatchMesh.__ClearAllGeometries_Internal(base.NativePtr);
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x000E4675 File Offset: 0x000E2875
		[NullableContext(2)]
		public void AddContainerNode(UUIItem ContainerNode, bool bClearTransformChanged = false)
		{
			UUIDynamicBatchMesh.__AddContainerNode_Internal(base.NativePtr, (ContainerNode != null) ? ContainerNode.NativePtr : IntPtr.Zero, bClearTransformChanged);
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x000E4693 File Offset: 0x000E2893
		[NullableContext(2)]
		public UGeometryHandle AddBatchGeometryRenderable(UUIBatchGeometryRenderable Renderable)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGeometryHandle>(UUIDynamicBatchMesh.__AddBatchGeometryRenderable_Internal(base.NativePtr, (Renderable != null) ? Renderable.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009765 RID: 38757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkAllItemGeometryDirty_Internal(IntPtr @this, IntPtr ContainerNode);

		// Token: 0x06009766 RID: 38758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllGeometries_Internal(IntPtr @this);

		// Token: 0x06009767 RID: 38759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddContainerNode_Internal(IntPtr @this, IntPtr ContainerNode, bool bClearTransformChanged);

		// Token: 0x06009768 RID: 38760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddBatchGeometryRenderable_Internal(IntPtr @this, IntPtr Renderable);

		// Token: 0x06009769 RID: 38761 RVA: 0x000E46B5 File Offset: 0x000E28B5
		static UUIDynamicBatchMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynamicBatchMesh");
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x000E46C3 File Offset: 0x000E28C3
		protected UUIDynamicBatchMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041D6 RID: 16854
		public new const string __ObjectPath = "/Script/LGUI.UIDynamicBatchMesh";

		// Token: 0x040041D7 RID: 16855
		private static IntPtr _ClassPtr;

		// Token: 0x040041D8 RID: 16856
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041D9 RID: 16857
		internal static int __PropertyOffset_GeometryHandleMap;

		// Token: 0x040041DA RID: 16858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UGeometryHandle> _GeometryHandleMap;

		// Token: 0x040041DB RID: 16859
		internal static int __PropertyOffset_GeometryHandlePool;

		// Token: 0x040041DC RID: 16860
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGeometryHandle> _GeometryHandlePool;

		// Token: 0x040041DD RID: 16861
		internal static int __PropertyOffset_bGenerateGeometryHandle;

		// Token: 0x040041DE RID: 16862
		internal static int __PropertyOffset_GeometryHandleMaxCount;

		// Token: 0x040041DF RID: 16863
		internal static int __PropertyOffset_SingleGeometryExistTime;

		// Token: 0x040041E0 RID: 16864
		internal static int __PropertyOffset_MaxVerticeCount;
	}
}
