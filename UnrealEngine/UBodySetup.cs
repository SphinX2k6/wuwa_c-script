using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CF RID: 2255
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BodySetup")]
	[UnrealStructLayout(800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UBodySetup : UBodySetupCore, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007C07 RID: 31751 RVA: 0x000B1E18 File Offset: 0x000B0018
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBodySetup._ClassPtr;
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x000B1E24 File Offset: 0x000B0024
		public UBodySetup() : this(BuiltinUtils.AllocNativeUObject(UBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x000B1E4C File Offset: 0x000B004C
		public UBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06007C0A RID: 31754 RVA: 0x000B1E80 File Offset: 0x000B0080
		// (set) Token: 0x06007C0B RID: 31755 RVA: 0x000B1EB9 File Offset: 0x000B00B9
		public FKAggregateGeom AggGeom
		{
			get
			{
				base.FastCheckIsValid();
				FKAggregateGeom result;
				if ((result = this._AggGeom) == null)
				{
					result = (this._AggGeom = new FKAggregateGeom(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_AggGeom, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKAggregateGeom.StaticStruct(), base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_AggGeom, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06007C0C RID: 31756 RVA: 0x000B1EDA File Offset: 0x000B00DA
		// (set) Token: 0x06007C0D RID: 31757 RVA: 0x000B1EF3 File Offset: 0x000B00F3
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

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06007C0E RID: 31758 RVA: 0x000B1F23 File Offset: 0x000B0123
		// (set) Token: 0x06007C0F RID: 31759 RVA: 0x000B1F3C File Offset: 0x000B013C
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

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06007C10 RID: 31760 RVA: 0x000B1F6C File Offset: 0x000B016C
		// (set) Token: 0x06007C11 RID: 31761 RVA: 0x000B1F85 File Offset: 0x000B0185
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

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06007C12 RID: 31762 RVA: 0x000B1FB5 File Offset: 0x000B01B5
		// (set) Token: 0x06007C13 RID: 31763 RVA: 0x000B1FCE File Offset: 0x000B01CE
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

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x000B1FFE File Offset: 0x000B01FE
		// (set) Token: 0x06007C15 RID: 31765 RVA: 0x000B2017 File Offset: 0x000B0217
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

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06007C16 RID: 31766 RVA: 0x000B2047 File Offset: 0x000B0247
		// (set) Token: 0x06007C17 RID: 31767 RVA: 0x000B2060 File Offset: 0x000B0260
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

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x000B2090 File Offset: 0x000B0290
		// (set) Token: 0x06007C19 RID: 31769 RVA: 0x000B20A9 File Offset: 0x000B02A9
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

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06007C1A RID: 31770 RVA: 0x000B20D9 File Offset: 0x000B02D9
		// (set) Token: 0x06007C1B RID: 31771 RVA: 0x000B20F2 File Offset: 0x000B02F2
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

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x000B2122 File Offset: 0x000B0322
		// (set) Token: 0x06007C1D RID: 31773 RVA: 0x000B2136 File Offset: 0x000B0336
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

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06007C1E RID: 31774 RVA: 0x000B214C File Offset: 0x000B034C
		// (set) Token: 0x06007C1F RID: 31775 RVA: 0x000B2185 File Offset: 0x000B0385
		public FWalkableSlopeOverride WalkableSlopeOverride
		{
			get
			{
				base.FastCheckIsValid();
				FWalkableSlopeOverride result;
				if ((result = this._WalkableSlopeOverride) == null)
				{
					result = (this._WalkableSlopeOverride = new FWalkableSlopeOverride(base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_WalkableSlopeOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWalkableSlopeOverride.StaticStruct(), base.NativePtr + (IntPtr)UBodySetup.__PropertyOffset_WalkableSlopeOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x000B21A8 File Offset: 0x000B03A8
		// (set) Token: 0x06007C21 RID: 31777 RVA: 0x000B21E1 File Offset: 0x000B03E1
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

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x000B2202 File Offset: 0x000B0402
		// (set) Token: 0x06007C23 RID: 31779 RVA: 0x000B2216 File Offset: 0x000B0416
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

		// Token: 0x06007C24 RID: 31780 RVA: 0x000B222B File Offset: 0x000B042B
		static UBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BodySetup");
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x000B2239 File Offset: 0x000B0439
		protected UBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B6D RID: 15213
		public new const string __ObjectPath = "/Script/Engine.BodySetup";

		// Token: 0x04003B6E RID: 15214
		private static IntPtr _ClassPtr;

		// Token: 0x04003B6F RID: 15215
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003B70 RID: 15216
		internal static int __PropertyOffset_AggGeom;

		// Token: 0x04003B71 RID: 15217
		[Nullable(2)]
		private FKAggregateGeom _AggGeom;

		// Token: 0x04003B72 RID: 15218
		internal static int __PropertyOffset_bAlwaysFullAnimWeight_DEPRECATED;

		// Token: 0x04003B73 RID: 15219
		internal static byte __PropertyMask_bAlwaysFullAnimWeight_DEPRECATED;

		// Token: 0x04003B74 RID: 15220
		internal static int __PropertyOffset_bConsiderForBounds;

		// Token: 0x04003B75 RID: 15221
		internal static byte __PropertyMask_bConsiderForBounds;

		// Token: 0x04003B76 RID: 15222
		internal static int __PropertyOffset_bMeshCollideAll;

		// Token: 0x04003B77 RID: 15223
		internal static byte __PropertyMask_bMeshCollideAll;

		// Token: 0x04003B78 RID: 15224
		internal static int __PropertyOffset_bDoubleSidedGeometry;

		// Token: 0x04003B79 RID: 15225
		internal static byte __PropertyMask_bDoubleSidedGeometry;

		// Token: 0x04003B7A RID: 15226
		internal static int __PropertyOffset_bGenerateNonMirroredCollision;

		// Token: 0x04003B7B RID: 15227
		internal static byte __PropertyMask_bGenerateNonMirroredCollision;

		// Token: 0x04003B7C RID: 15228
		internal static int __PropertyOffset_bSharedCookedData;

		// Token: 0x04003B7D RID: 15229
		internal static byte __PropertyMask_bSharedCookedData;

		// Token: 0x04003B7E RID: 15230
		internal static int __PropertyOffset_bGenerateMirroredCollision;

		// Token: 0x04003B7F RID: 15231
		internal static byte __PropertyMask_bGenerateMirroredCollision;

		// Token: 0x04003B80 RID: 15232
		internal static int __PropertyOffset_bSupportUVsAndFaceRemap;

		// Token: 0x04003B81 RID: 15233
		internal static byte __PropertyMask_bSupportUVsAndFaceRemap;

		// Token: 0x04003B82 RID: 15234
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04003B83 RID: 15235
		internal static int __PropertyOffset_WalkableSlopeOverride;

		// Token: 0x04003B84 RID: 15236
		[Nullable(2)]
		private FWalkableSlopeOverride _WalkableSlopeOverride;

		// Token: 0x04003B85 RID: 15237
		internal static int __PropertyOffset_DefaultInstance;

		// Token: 0x04003B86 RID: 15238
		[Nullable(2)]
		private FBodyInstance _DefaultInstance;

		// Token: 0x04003B87 RID: 15239
		internal static int __PropertyOffset_BuildScale3D;
	}
}
