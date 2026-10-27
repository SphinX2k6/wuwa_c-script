using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C6 RID: 8646
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIStaticMesh")]
	[UnrealStructLayout(1824, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class UUIStaticMesh : UUIDirectMeshRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E3A RID: 134714 RVA: 0x0030934D File Offset: 0x0030754D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIStaticMesh._ClassPtr;
		}

		// Token: 0x06020E3B RID: 134715 RVA: 0x0030935C File Offset: 0x0030755C
		public UUIStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UUIStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E3C RID: 134716 RVA: 0x00309384 File Offset: 0x00307584
		[NullableContext(1)]
		public UUIStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700806F RID: 32879
		// (get) Token: 0x06020E3D RID: 134717 RVA: 0x003093B7 File Offset: 0x003075B7
		// (set) Token: 0x06020E3E RID: 134718 RVA: 0x003093CB File Offset: 0x003075CB
		public unsafe UStaticMesh mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UUIStaticMesh.__PropertyOffset_mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIStaticMesh.__PropertyOffset_mesh, value);
			}
		}

		// Token: 0x17008070 RID: 32880
		// (get) Token: 0x06020E3F RID: 134719 RVA: 0x003093E0 File Offset: 0x003075E0
		// (set) Token: 0x06020E40 RID: 134720 RVA: 0x003093F0 File Offset: 0x003075F0
		public unsafe UIStaticMeshVertexColorType vertexColorType
		{
			get
			{
				return (UIStaticMeshVertexColorType)(*(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_vertexColorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_vertexColorType) = (byte)value;
			}
		}

		// Token: 0x17008071 RID: 32881
		// (get) Token: 0x06020E41 RID: 134721 RVA: 0x00309401 File Offset: 0x00307601
		// (set) Token: 0x06020E42 RID: 134722 RVA: 0x00309411 File Offset: 0x00307611
		public unsafe bool bAutoAdjustSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_bAutoAdjustSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_bAutoAdjustSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008072 RID: 32882
		// (get) Token: 0x06020E43 RID: 134723 RVA: 0x00309424 File Offset: 0x00307624
		// (set) Token: 0x06020E44 RID: 134724 RVA: 0x0030945D File Offset: 0x0030765D
		[Nullable(1)]
		public FCacheMeshData CachedMeshData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCacheMeshData result;
				if ((result = this._CachedMeshData) == null)
				{
					result = (this._CachedMeshData = new FCacheMeshData(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_CachedMeshData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCacheMeshData.StaticStruct(), base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_CachedMeshData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008073 RID: 32883
		// (get) Token: 0x06020E45 RID: 134725 RVA: 0x0030947E File Offset: 0x0030767E
		// (set) Token: 0x06020E46 RID: 134726 RVA: 0x0030948E File Offset: 0x0030768E
		public unsafe bool bCacheMeshData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_bCacheMeshData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIStaticMesh.__PropertyOffset_bCacheMeshData) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020E47 RID: 134727 RVA: 0x0030949F File Offset: 0x0030769F
		public void SetVertexColorType(UIStaticMeshVertexColorType value)
		{
			UUIStaticMesh.__SetVertexColorType_Internal(base.NativePtr, value);
		}

		// Token: 0x06020E48 RID: 134728 RVA: 0x003094AD File Offset: 0x003076AD
		public void SetMesh(UStaticMesh value)
		{
			UUIStaticMesh.__SetMesh_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020E49 RID: 134729 RVA: 0x003094CA File Offset: 0x003076CA
		public UIStaticMeshVertexColorType GetVertexColorType()
		{
			return UUIStaticMesh.__GetVertexColorType_Internal(base.NativePtr);
		}

		// Token: 0x06020E4A RID: 134730 RVA: 0x003094D7 File Offset: 0x003076D7
		public UStaticMesh GetMesh()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(UUIStaticMesh.__GetMesh_Internal(base.NativePtr));
		}

		// Token: 0x06020E4B RID: 134731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexColorType_Internal(IntPtr @this, UIStaticMeshVertexColorType value);

		// Token: 0x06020E4C RID: 134732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMesh_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020E4D RID: 134733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIStaticMeshVertexColorType __GetVertexColorType_Internal(IntPtr @this);

		// Token: 0x06020E4E RID: 134734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMesh_Internal(IntPtr @this);

		// Token: 0x06020E4F RID: 134735 RVA: 0x003094E9 File Offset: 0x003076E9
		static UUIStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIStaticMesh");
		}

		// Token: 0x06020E50 RID: 134736 RVA: 0x003094F7 File Offset: 0x003076F7
		protected UUIStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401191B RID: 71963
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIStaticMesh";

		// Token: 0x0401191C RID: 71964
		private static IntPtr _ClassPtr;

		// Token: 0x0401191D RID: 71965
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401191E RID: 71966
		internal static int __PropertyOffset_mesh;

		// Token: 0x0401191F RID: 71967
		internal static int __PropertyOffset_vertexColorType;

		// Token: 0x04011920 RID: 71968
		internal static int __PropertyOffset_bAutoAdjustSize;

		// Token: 0x04011921 RID: 71969
		internal static int __PropertyOffset_CachedMeshData;

		// Token: 0x04011922 RID: 71970
		private FCacheMeshData _CachedMeshData;

		// Token: 0x04011923 RID: 71971
		internal static int __PropertyOffset_bCacheMeshData;
	}
}
