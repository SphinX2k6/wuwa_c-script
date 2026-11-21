using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200063C RID: 1596
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeHeightfieldCollisionComponent")]
	[UnrealStructLayout(2480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2480)]
	public class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008BEA RID: 35818 RVA: 0x000D27DB File Offset: 0x000D09DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeHeightfieldCollisionComponent._ClassPtr;
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x000D27E8 File Offset: 0x000D09E8
		public ULandscapeHeightfieldCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeHeightfieldCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x000D2810 File Offset: 0x000D0A10
		public ULandscapeHeightfieldCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeHeightfieldCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06008BED RID: 35821 RVA: 0x000D2843 File Offset: 0x000D0A43
		// (set) Token: 0x06008BEE RID: 35822 RVA: 0x000D2853 File Offset: 0x000D0A53
		public unsafe int SectionBaseX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseX) = value;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06008BEF RID: 35823 RVA: 0x000D2864 File Offset: 0x000D0A64
		// (set) Token: 0x06008BF0 RID: 35824 RVA: 0x000D2874 File Offset: 0x000D0A74
		public unsafe int SectionBaseY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseY) = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06008BF1 RID: 35825 RVA: 0x000D2885 File Offset: 0x000D0A85
		// (set) Token: 0x06008BF2 RID: 35826 RVA: 0x000D2895 File Offset: 0x000D0A95
		public unsafe int CollisionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionSizeQuads) = value;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06008BF3 RID: 35827 RVA: 0x000D28A6 File Offset: 0x000D0AA6
		// (set) Token: 0x06008BF4 RID: 35828 RVA: 0x000D28B6 File Offset: 0x000D0AB6
		public unsafe float CollisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionScale) = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06008BF5 RID: 35829 RVA: 0x000D28C7 File Offset: 0x000D0AC7
		// (set) Token: 0x06008BF6 RID: 35830 RVA: 0x000D28D7 File Offset: 0x000D0AD7
		public unsafe int SimpleCollisionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SimpleCollisionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_SimpleCollisionSizeQuads) = value;
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x000D28E8 File Offset: 0x000D0AE8
		// (set) Token: 0x06008BF8 RID: 35832 RVA: 0x000D2921 File Offset: 0x000D0B21
		public TArray<byte> CollisionQuadFlags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._CollisionQuadFlags) == null)
				{
					result = (this._CollisionQuadFlags = new TArray<byte>(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionQuadFlags, this));
				}
				return result;
			}
			set
			{
				this.CollisionQuadFlags.CopyAssign(value);
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x000D292F File Offset: 0x000D0B2F
		// (set) Token: 0x06008BFA RID: 35834 RVA: 0x000D2943 File Offset: 0x000D0B43
		public unsafe FGuid HeightfieldGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_HeightfieldGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_HeightfieldGuid) = value;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06008BFB RID: 35835 RVA: 0x000D2958 File Offset: 0x000D0B58
		// (set) Token: 0x06008BFC RID: 35836 RVA: 0x000D296C File Offset: 0x000D0B6C
		public unsafe FBox CachedLocalBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CachedLocalBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CachedLocalBox) = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x000D2984 File Offset: 0x000D0B84
		// (set) Token: 0x06008BFE RID: 35838 RVA: 0x000D29BD File Offset: 0x000D0BBD
		public TArray<UPhysicalMaterial> CookedPhysicalMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._CookedPhysicalMaterials) == null)
				{
					result = (this._CookedPhysicalMaterials = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_CookedPhysicalMaterials, this));
				}
				return result;
			}
			set
			{
				this.CookedPhysicalMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06008BFF RID: 35839 RVA: 0x000D29CB File Offset: 0x000D0BCB
		// (set) Token: 0x06008C00 RID: 35840 RVA: 0x000D29DB File Offset: 0x000D0BDB
		public unsafe bool bRuntimeDisableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_bRuntimeDisableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_bRuntimeDisableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x000D29EC File Offset: 0x000D0BEC
		static ULandscapeHeightfieldCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeHeightfieldCollisionComponent");
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x000D29FA File Offset: 0x000D0BFA
		protected ULandscapeHeightfieldCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CCD RID: 15565
		public new const string __ObjectPath = "/Script/Landscape.LandscapeHeightfieldCollisionComponent";

		// Token: 0x04003CCE RID: 15566
		private static IntPtr _ClassPtr;

		// Token: 0x04003CCF RID: 15567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CD0 RID: 15568
		internal static int __PropertyOffset_SectionBaseX;

		// Token: 0x04003CD1 RID: 15569
		internal static int __PropertyOffset_SectionBaseY;

		// Token: 0x04003CD2 RID: 15570
		internal static int __PropertyOffset_CollisionSizeQuads;

		// Token: 0x04003CD3 RID: 15571
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x04003CD4 RID: 15572
		internal static int __PropertyOffset_SimpleCollisionSizeQuads;

		// Token: 0x04003CD5 RID: 15573
		internal static int __PropertyOffset_CollisionQuadFlags;

		// Token: 0x04003CD6 RID: 15574
		[Nullable(2)]
		private TArray<byte> _CollisionQuadFlags;

		// Token: 0x04003CD7 RID: 15575
		internal static int __PropertyOffset_HeightfieldGuid;

		// Token: 0x04003CD8 RID: 15576
		internal static int __PropertyOffset_CachedLocalBox;

		// Token: 0x04003CD9 RID: 15577
		internal static int __PropertyOffset_CookedPhysicalMaterials;

		// Token: 0x04003CDA RID: 15578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _CookedPhysicalMaterials;

		// Token: 0x04003CDB RID: 15579
		internal static int __PropertyOffset_bRuntimeDisableCollision;
	}
}
