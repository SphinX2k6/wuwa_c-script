using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001749 RID: 5961
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.KuroLandscapeHeightfieldCollisionComponent")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class UKuroLandscapeHeightfieldCollisionComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015725 RID: 87845 RVA: 0x001F8492 File Offset: 0x001F6692
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLandscapeHeightfieldCollisionComponent._ClassPtr;
		}

		// Token: 0x06015726 RID: 87846 RVA: 0x001F84A0 File Offset: 0x001F66A0
		public UKuroLandscapeHeightfieldCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLandscapeHeightfieldCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015727 RID: 87847 RVA: 0x001F84C8 File Offset: 0x001F66C8
		public UKuroLandscapeHeightfieldCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLandscapeHeightfieldCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x06015728 RID: 87848 RVA: 0x001F84FC File Offset: 0x001F66FC
		// (set) Token: 0x06015729 RID: 87849 RVA: 0x001F8535 File Offset: 0x001F6735
		public TArray<ULandscapeLayerInfoObject> ComponentLayerInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeLayerInfoObject> result;
				if ((result = this._ComponentLayerInfos) == null)
				{
					result = (this._ComponentLayerInfos = new TArray<ULandscapeLayerInfoObject>(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_ComponentLayerInfos, this));
				}
				return result;
			}
			set
			{
				this.ComponentLayerInfos.CopyAssign(value);
			}
		}

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x0601572A RID: 87850 RVA: 0x001F8543 File Offset: 0x001F6743
		// (set) Token: 0x0601572B RID: 87851 RVA: 0x001F8553 File Offset: 0x001F6753
		public unsafe int SectionBaseX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseX) = value;
			}
		}

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x0601572C RID: 87852 RVA: 0x001F8564 File Offset: 0x001F6764
		// (set) Token: 0x0601572D RID: 87853 RVA: 0x001F8574 File Offset: 0x001F6774
		public unsafe int SectionBaseY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SectionBaseY) = value;
			}
		}

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x0601572E RID: 87854 RVA: 0x001F8585 File Offset: 0x001F6785
		// (set) Token: 0x0601572F RID: 87855 RVA: 0x001F8595 File Offset: 0x001F6795
		public unsafe int CollisionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionSizeQuads) = value;
			}
		}

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x06015730 RID: 87856 RVA: 0x001F85A6 File Offset: 0x001F67A6
		// (set) Token: 0x06015731 RID: 87857 RVA: 0x001F85B6 File Offset: 0x001F67B6
		public unsafe float CollisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CollisionScale) = value;
			}
		}

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x06015732 RID: 87858 RVA: 0x001F85C7 File Offset: 0x001F67C7
		// (set) Token: 0x06015733 RID: 87859 RVA: 0x001F85D7 File Offset: 0x001F67D7
		public unsafe int SimpleCollisionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SimpleCollisionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_SimpleCollisionSizeQuads) = value;
			}
		}

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x06015734 RID: 87860 RVA: 0x001F85E8 File Offset: 0x001F67E8
		// (set) Token: 0x06015735 RID: 87861 RVA: 0x001F85FC File Offset: 0x001F67FC
		public unsafe FGuid HeightfieldGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_HeightfieldGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_HeightfieldGuid) = value;
			}
		}

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x06015736 RID: 87862 RVA: 0x001F8611 File Offset: 0x001F6811
		// (set) Token: 0x06015737 RID: 87863 RVA: 0x001F8625 File Offset: 0x001F6825
		public unsafe FBox CachedLocalBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CachedLocalBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CachedLocalBox) = value;
			}
		}

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x06015738 RID: 87864 RVA: 0x001F863C File Offset: 0x001F683C
		// (set) Token: 0x06015739 RID: 87865 RVA: 0x001F8675 File Offset: 0x001F6875
		public TArray<UPhysicalMaterial> CookedPhysicalMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._CookedPhysicalMaterials) == null)
				{
					result = (this._CookedPhysicalMaterials = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UKuroLandscapeHeightfieldCollisionComponent.__PropertyOffset_CookedPhysicalMaterials, this));
				}
				return result;
			}
			set
			{
				this.CookedPhysicalMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x001F8683 File Offset: 0x001F6883
		static UKuroLandscapeHeightfieldCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroLandscapeHeightfieldCollisionComponent");
		}

		// Token: 0x0601573B RID: 87867 RVA: 0x001F8691 File Offset: 0x001F6891
		protected UKuroLandscapeHeightfieldCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB0D RID: 47885
		public new const string __ObjectPath = "/Script/KuroCollision.KuroLandscapeHeightfieldCollisionComponent";

		// Token: 0x0400BB0E RID: 47886
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB0F RID: 47887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB10 RID: 47888
		internal static int __PropertyOffset_ComponentLayerInfos;

		// Token: 0x0400BB11 RID: 47889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeLayerInfoObject> _ComponentLayerInfos;

		// Token: 0x0400BB12 RID: 47890
		internal static int __PropertyOffset_SectionBaseX;

		// Token: 0x0400BB13 RID: 47891
		internal static int __PropertyOffset_SectionBaseY;

		// Token: 0x0400BB14 RID: 47892
		internal static int __PropertyOffset_CollisionSizeQuads;

		// Token: 0x0400BB15 RID: 47893
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x0400BB16 RID: 47894
		internal static int __PropertyOffset_SimpleCollisionSizeQuads;

		// Token: 0x0400BB17 RID: 47895
		internal static int __PropertyOffset_HeightfieldGuid;

		// Token: 0x0400BB18 RID: 47896
		internal static int __PropertyOffset_CachedLocalBox;

		// Token: 0x0400BB19 RID: 47897
		internal static int __PropertyOffset_CookedPhysicalMaterials;

		// Token: 0x0400BB1A RID: 47898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _CookedPhysicalMaterials;
	}
}
