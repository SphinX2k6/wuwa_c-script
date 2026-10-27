using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000208 RID: 520
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGeometryComponent")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UAkGeometryComponent : UAkAcousticTextureSetComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001EF9 RID: 7929 RVA: 0x0002DC92 File Offset: 0x0002BE92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGeometryComponent._ClassPtr;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
		public UAkGeometryComponent() : this(BuiltinUtils.AllocNativeUObject(UAkGeometryComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		public UAkGeometryComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkGeometryComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0002DCFB File Offset: 0x0002BEFB
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0002DD0B File Offset: 0x0002BF0B
		public unsafe EAkMeshType MeshType
		{
			get
			{
				return (EAkMeshType)(*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_MeshType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_MeshType) = (byte)value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0002DD1C File Offset: 0x0002BF1C
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0002DD2C File Offset: 0x0002BF2C
		public unsafe int LOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_LOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_LOD) = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0002DD3D File Offset: 0x0002BF3D
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0002DD4D File Offset: 0x0002BF4D
		public unsafe float WeldingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_WeldingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_WeldingThreshold) = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0002DD60 File Offset: 0x0002BF60
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0002DD99 File Offset: 0x0002BF99
		public TMap<UMaterialInterface, FAkGeometrySurfaceOverride> StaticMeshSurfaceOverride
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UMaterialInterface, FAkGeometrySurfaceOverride> result;
				if ((result = this._StaticMeshSurfaceOverride) == null)
				{
					result = (this._StaticMeshSurfaceOverride = new TMap<UMaterialInterface, FAkGeometrySurfaceOverride>(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_StaticMeshSurfaceOverride, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshSurfaceOverride.CopyAssign(value);
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0002DDA8 File Offset: 0x0002BFA8
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0002DDE1 File Offset: 0x0002BFE1
		public FAkGeometrySurfaceOverride CollisionMeshSurfaceOverride
		{
			get
			{
				base.FastCheckIsValid();
				FAkGeometrySurfaceOverride result;
				if ((result = this._CollisionMeshSurfaceOverride) == null)
				{
					result = (this._CollisionMeshSurfaceOverride = new FAkGeometrySurfaceOverride(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_CollisionMeshSurfaceOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkGeometrySurfaceOverride.StaticStruct(), base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_CollisionMeshSurfaceOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0002DE02 File Offset: 0x0002C002
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0002DE12 File Offset: 0x0002C012
		public unsafe bool bEnableDiffraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_bEnableDiffraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_bEnableDiffraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0002DE23 File Offset: 0x0002C023
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0002DE33 File Offset: 0x0002C033
		public unsafe bool bEnableDiffractionOnBoundaryEdges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_bEnableDiffractionOnBoundaryEdges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_bEnableDiffractionOnBoundaryEdges) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x0002DE44 File Offset: 0x0002C044
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Nullable(2)]
		public unsafe AActor AssociatedRoom
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAkGeometryComponent.__PropertyOffset_AssociatedRoom);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkGeometryComponent.__PropertyOffset_AssociatedRoom, value);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0002DE70 File Offset: 0x0002C070
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0002DEA9 File Offset: 0x0002C0A9
		public FAkGeometryData GeometryData
		{
			get
			{
				base.FastCheckIsValid();
				FAkGeometryData result;
				if ((result = this._GeometryData) == null)
				{
					result = (this._GeometryData = new FAkGeometryData(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_GeometryData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkGeometryData.StaticStruct(), base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_GeometryData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x0002DECC File Offset: 0x0002C0CC
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0002DF05 File Offset: 0x0002C105
		public TMap<int, double> SurfaceAreas
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, double> result;
				if ((result = this._SurfaceAreas) == null)
				{
					result = (this._SurfaceAreas = new TMap<int, double>(base.NativePtr + (IntPtr)UAkGeometryComponent.__PropertyOffset_SurfaceAreas, this));
				}
				return result;
			}
			set
			{
				this.SurfaceAreas.CopyAssign(value);
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0002DF13 File Offset: 0x0002C113
		public void UpdateGeometry()
		{
			UAkGeometryComponent.__UpdateGeometry_Internal(base.NativePtr);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0002DF20 File Offset: 0x0002C120
		public void SendGeometry()
		{
			UAkGeometryComponent.__SendGeometry_Internal(base.NativePtr);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0002DF2D File Offset: 0x0002C12D
		public void RemoveGeometry()
		{
			UAkGeometryComponent.__RemoveGeometry_Internal(base.NativePtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0002DF3A File Offset: 0x0002C13A
		public void ConvertMesh()
		{
			UAkGeometryComponent.__ConvertMesh_Internal(base.NativePtr);
		}

		// Token: 0x06001F14 RID: 7956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateGeometry_Internal(IntPtr @this);

		// Token: 0x06001F15 RID: 7957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendGeometry_Internal(IntPtr @this);

		// Token: 0x06001F16 RID: 7958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveGeometry_Internal(IntPtr @this);

		// Token: 0x06001F17 RID: 7959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConvertMesh_Internal(IntPtr @this);

		// Token: 0x06001F18 RID: 7960 RVA: 0x0002DF47 File Offset: 0x0002C147
		static UAkGeometryComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGeometryComponent");
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0002DF55 File Offset: 0x0002C155
		protected UAkGeometryComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A23 RID: 2595
		public new const string __ObjectPath = "/Script/AkAudio.AkGeometryComponent";

		// Token: 0x04000A24 RID: 2596
		private static IntPtr _ClassPtr;

		// Token: 0x04000A25 RID: 2597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A26 RID: 2598
		internal static int __PropertyOffset_MeshType;

		// Token: 0x04000A27 RID: 2599
		internal static int __PropertyOffset_LOD;

		// Token: 0x04000A28 RID: 2600
		internal static int __PropertyOffset_WeldingThreshold;

		// Token: 0x04000A29 RID: 2601
		internal static int __PropertyOffset_StaticMeshSurfaceOverride;

		// Token: 0x04000A2A RID: 2602
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UMaterialInterface, FAkGeometrySurfaceOverride> _StaticMeshSurfaceOverride;

		// Token: 0x04000A2B RID: 2603
		internal static int __PropertyOffset_CollisionMeshSurfaceOverride;

		// Token: 0x04000A2C RID: 2604
		[Nullable(2)]
		private FAkGeometrySurfaceOverride _CollisionMeshSurfaceOverride;

		// Token: 0x04000A2D RID: 2605
		internal static int __PropertyOffset_bEnableDiffraction;

		// Token: 0x04000A2E RID: 2606
		internal static int __PropertyOffset_bEnableDiffractionOnBoundaryEdges;

		// Token: 0x04000A2F RID: 2607
		internal static int __PropertyOffset_AssociatedRoom;

		// Token: 0x04000A30 RID: 2608
		internal static int __PropertyOffset_GeometryData;

		// Token: 0x04000A31 RID: 2609
		[Nullable(2)]
		private FAkGeometryData _GeometryData;

		// Token: 0x04000A32 RID: 2610
		internal static int __PropertyOffset_SurfaceAreas;

		// Token: 0x04000A33 RID: 2611
		[Nullable(2)]
		private TMap<int, double> _SurfaceAreas;
	}
}
