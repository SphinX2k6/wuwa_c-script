using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000194 RID: 404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BodySetup")]
	[UnrealStructLayout(800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UBodySetup : UBodySetupCore, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x0002845D File Offset: 0x0002665D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBodySetup._ClassPtr;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0002846C File Offset: 0x0002666C
		public UBodySetup() : this(BuiltinUtils.AllocNativeUObject(UBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00028494 File Offset: 0x00026694
		public UBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x000284C7 File Offset: 0x000266C7
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x000284E0 File Offset: 0x000266E0
		public unsafe bool bAlwaysFullAnimWeight_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bAlwaysFullAnimWeight_DEPRECATED) & UBodySetup.__PropertyMask_bAlwaysFullAnimWeight_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bAlwaysFullAnimWeight_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bAlwaysFullAnimWeight_DEPRECATED) & ~UBodySetup.__PropertyMask_bAlwaysFullAnimWeight_DEPRECATED) | (value ? UBodySetup.__PropertyMask_bAlwaysFullAnimWeight_DEPRECATED : 0));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00028510 File Offset: 0x00026710
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00028529 File Offset: 0x00026729
		public unsafe bool bConsiderForBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bConsiderForBounds) & UBodySetup.__PropertyMask_bConsiderForBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bConsiderForBounds) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bConsiderForBounds) & ~UBodySetup.__PropertyMask_bConsiderForBounds) | (value ? UBodySetup.__PropertyMask_bConsiderForBounds : 0));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00028559 File Offset: 0x00026759
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00028572 File Offset: 0x00026772
		public unsafe bool bMeshCollideAll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bMeshCollideAll) & UBodySetup.__PropertyMask_bMeshCollideAll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bMeshCollideAll) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bMeshCollideAll) & ~UBodySetup.__PropertyMask_bMeshCollideAll) | (value ? UBodySetup.__PropertyMask_bMeshCollideAll : 0));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x000285A2 File Offset: 0x000267A2
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x000285BB File Offset: 0x000267BB
		public unsafe bool bDoubleSidedGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bDoubleSidedGeometry) & UBodySetup.__PropertyMask_bDoubleSidedGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bDoubleSidedGeometry) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bDoubleSidedGeometry) & ~UBodySetup.__PropertyMask_bDoubleSidedGeometry) | (value ? UBodySetup.__PropertyMask_bDoubleSidedGeometry : 0));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000285EB File Offset: 0x000267EB
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00028604 File Offset: 0x00026804
		public unsafe bool bGenerateNonMirroredCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateNonMirroredCollision) & UBodySetup.__PropertyMask_bGenerateNonMirroredCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateNonMirroredCollision) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateNonMirroredCollision) & ~UBodySetup.__PropertyMask_bGenerateNonMirroredCollision) | (value ? UBodySetup.__PropertyMask_bGenerateNonMirroredCollision : 0));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00028634 File Offset: 0x00026834
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0002864D File Offset: 0x0002684D
		public unsafe bool bSharedCookedData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSharedCookedData) & UBodySetup.__PropertyMask_bSharedCookedData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSharedCookedData) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSharedCookedData) & ~UBodySetup.__PropertyMask_bSharedCookedData) | (value ? UBodySetup.__PropertyMask_bSharedCookedData : 0));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0002867D File Offset: 0x0002687D
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00028696 File Offset: 0x00026896
		public unsafe bool bGenerateMirroredCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateMirroredCollision) & UBodySetup.__PropertyMask_bGenerateMirroredCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateMirroredCollision) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bGenerateMirroredCollision) & ~UBodySetup.__PropertyMask_bGenerateMirroredCollision) | (value ? UBodySetup.__PropertyMask_bGenerateMirroredCollision : 0));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x000286C6 File Offset: 0x000268C6
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x000286DF File Offset: 0x000268DF
		public unsafe bool bSupportUVsAndFaceRemap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSupportUVsAndFaceRemap) & UBodySetup.__PropertyMask_bSupportUVsAndFaceRemap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSupportUVsAndFaceRemap) = ((*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_bSupportUVsAndFaceRemap) & ~UBodySetup.__PropertyMask_bSupportUVsAndFaceRemap) | (value ? UBodySetup.__PropertyMask_bSupportUVsAndFaceRemap : 0));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0002870F File Offset: 0x0002690F
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00028723 File Offset: 0x00026923
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UBodySetup.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBodySetup.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00028738 File Offset: 0x00026938
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00028771 File Offset: 0x00026971
		public FBodyInstance DefaultInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._DefaultInstance) == null)
				{
					result = (this._DefaultInstance = new FBodyInstance(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_DefaultInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_DefaultInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00028792 File Offset: 0x00026992
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x000287A6 File Offset: 0x000269A6
		public unsafe FVector BuildScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_BuildScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_BuildScale3D) = value;
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000287BB File Offset: 0x000269BB
		static UBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BodySetup");
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000287C9 File Offset: 0x000269C9
		protected UBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008A9 RID: 2217
		public new const string __ObjectPath = "/Script/Engine.BodySetup";

		// Token: 0x040008AA RID: 2218
		private static IntPtr _ClassPtr;

		// Token: 0x040008AB RID: 2219
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008AC RID: 2220
		internal static int __PropertyOffset_bAlwaysFullAnimWeight_DEPRECATED;

		// Token: 0x040008AD RID: 2221
		internal static byte __PropertyMask_bAlwaysFullAnimWeight_DEPRECATED;

		// Token: 0x040008AE RID: 2222
		internal static int __PropertyOffset_bConsiderForBounds;

		// Token: 0x040008AF RID: 2223
		internal static byte __PropertyMask_bConsiderForBounds;

		// Token: 0x040008B0 RID: 2224
		internal static int __PropertyOffset_bMeshCollideAll;

		// Token: 0x040008B1 RID: 2225
		internal static byte __PropertyMask_bMeshCollideAll;

		// Token: 0x040008B2 RID: 2226
		internal static int __PropertyOffset_bDoubleSidedGeometry;

		// Token: 0x040008B3 RID: 2227
		internal static byte __PropertyMask_bDoubleSidedGeometry;

		// Token: 0x040008B4 RID: 2228
		internal static int __PropertyOffset_bGenerateNonMirroredCollision;

		// Token: 0x040008B5 RID: 2229
		internal static byte __PropertyMask_bGenerateNonMirroredCollision;

		// Token: 0x040008B6 RID: 2230
		internal static int __PropertyOffset_bSharedCookedData;

		// Token: 0x040008B7 RID: 2231
		internal static byte __PropertyMask_bSharedCookedData;

		// Token: 0x040008B8 RID: 2232
		internal static int __PropertyOffset_bGenerateMirroredCollision;

		// Token: 0x040008B9 RID: 2233
		internal static byte __PropertyMask_bGenerateMirroredCollision;

		// Token: 0x040008BA RID: 2234
		internal static int __PropertyOffset_bSupportUVsAndFaceRemap;

		// Token: 0x040008BB RID: 2235
		internal static byte __PropertyMask_bSupportUVsAndFaceRemap;

		// Token: 0x040008BC RID: 2236
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x040008BD RID: 2237
		internal static int __PropertyOffset_DefaultInstance;

		// Token: 0x040008BE RID: 2238
		[Nullable(2)]
		private FBodyInstance _DefaultInstance;

		// Token: 0x040008BF RID: 2239
		internal static int __PropertyOffset_BuildScale3D;
	}
}
