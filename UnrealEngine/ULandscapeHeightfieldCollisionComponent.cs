using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F75 RID: 8053
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeHeightfieldCollisionComponent")]
	[UnrealStructLayout(2480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2480)]
	public class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8DF RID: 125151 RVA: 0x002D6996 File Offset: 0x002D4B96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeHeightfieldCollisionComponent._ClassPtr;
		}

		// Token: 0x0601E8E0 RID: 125152 RVA: 0x002D69A4 File Offset: 0x002D4BA4
		public ULandscapeHeightfieldCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeHeightfieldCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8E1 RID: 125153 RVA: 0x002D69CC File Offset: 0x002D4BCC
		public ULandscapeHeightfieldCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeHeightfieldCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007990 RID: 31120
		// (get) Token: 0x0601E8E2 RID: 125154 RVA: 0x002D6A00 File Offset: 0x002D4C00
		// (set) Token: 0x0601E8E3 RID: 125155 RVA: 0x002D6A39 File Offset: 0x002D4C39
		public TArray<ULandscapeLayerInfoObject> ComponentLayerInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeLayerInfoObject> result;
				if ((result = this._ComponentLayerInfos) == null)
				{
					result = (this._ComponentLayerInfos = new TArray<ULandscapeLayerInfoObject>(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_ComponentLayerInfos, this));
				}
				return result;
			}
			set
			{
				this.ComponentLayerInfos.CopyAssign(value);
			}
		}

		// Token: 0x17007991 RID: 31121
		// (get) Token: 0x0601E8E4 RID: 125156 RVA: 0x002D6A47 File Offset: 0x002D4C47
		// (set) Token: 0x0601E8E5 RID: 125157 RVA: 0x002D6A57 File Offset: 0x002D4C57
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

		// Token: 0x17007992 RID: 31122
		// (get) Token: 0x0601E8E6 RID: 125158 RVA: 0x002D6A68 File Offset: 0x002D4C68
		// (set) Token: 0x0601E8E7 RID: 125159 RVA: 0x002D6A78 File Offset: 0x002D4C78
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

		// Token: 0x17007993 RID: 31123
		// (get) Token: 0x0601E8E8 RID: 125160 RVA: 0x002D6A89 File Offset: 0x002D4C89
		// (set) Token: 0x0601E8E9 RID: 125161 RVA: 0x002D6A99 File Offset: 0x002D4C99
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

		// Token: 0x17007994 RID: 31124
		// (get) Token: 0x0601E8EA RID: 125162 RVA: 0x002D6AAA File Offset: 0x002D4CAA
		// (set) Token: 0x0601E8EB RID: 125163 RVA: 0x002D6ABA File Offset: 0x002D4CBA
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

		// Token: 0x17007995 RID: 31125
		// (get) Token: 0x0601E8EC RID: 125164 RVA: 0x002D6ACB File Offset: 0x002D4CCB
		// (set) Token: 0x0601E8ED RID: 125165 RVA: 0x002D6ADB File Offset: 0x002D4CDB
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

		// Token: 0x17007996 RID: 31126
		// (get) Token: 0x0601E8EE RID: 125166 RVA: 0x002D6AEC File Offset: 0x002D4CEC
		// (set) Token: 0x0601E8EF RID: 125167 RVA: 0x002D6B25 File Offset: 0x002D4D25
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

		// Token: 0x17007997 RID: 31127
		// (get) Token: 0x0601E8F0 RID: 125168 RVA: 0x002D6B33 File Offset: 0x002D4D33
		// (set) Token: 0x0601E8F1 RID: 125169 RVA: 0x002D6B47 File Offset: 0x002D4D47
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

		// Token: 0x17007998 RID: 31128
		// (get) Token: 0x0601E8F2 RID: 125170 RVA: 0x002D6B5C File Offset: 0x002D4D5C
		// (set) Token: 0x0601E8F3 RID: 125171 RVA: 0x002D6B70 File Offset: 0x002D4D70
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

		// Token: 0x17007999 RID: 31129
		// (get) Token: 0x0601E8F4 RID: 125172 RVA: 0x002D6B85 File Offset: 0x002D4D85
		// (set) Token: 0x0601E8F5 RID: 125173 RVA: 0x002D6B99 File Offset: 0x002D4D99
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<ULandscapeComponent> RenderComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_RenderComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeHeightfieldCollisionComponent.__PropertyOffset_RenderComponent) = value;
			}
		}

		// Token: 0x1700799A RID: 31130
		// (get) Token: 0x0601E8F6 RID: 125174 RVA: 0x002D6BB0 File Offset: 0x002D4DB0
		// (set) Token: 0x0601E8F7 RID: 125175 RVA: 0x002D6BE9 File Offset: 0x002D4DE9
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

		// Token: 0x1700799B RID: 31131
		// (get) Token: 0x0601E8F8 RID: 125176 RVA: 0x002D6BF7 File Offset: 0x002D4DF7
		// (set) Token: 0x0601E8F9 RID: 125177 RVA: 0x002D6C07 File Offset: 0x002D4E07
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

		// Token: 0x0601E8FA RID: 125178 RVA: 0x002D6C18 File Offset: 0x002D4E18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ULandscapeComponent GetRenderComponent()
		{
			ULandscapeHeightfieldCollisionComponent.__GetRenderComponent_FunctionParams* ptr = stackalloc ULandscapeHeightfieldCollisionComponent.__GetRenderComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ULandscapeHeightfieldCollisionComponent.__GetRenderComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ULandscapeHeightfieldCollisionComponent.__GetRenderComponent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ULandscapeHeightfieldCollisionComponent.__GetRenderComponent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULandscapeComponent>(ptr->__Result);
		}

		// Token: 0x0601E8FB RID: 125179 RVA: 0x002D6C63 File Offset: 0x002D4E63
		static ULandscapeHeightfieldCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeHeightfieldCollisionComponent");
		}

		// Token: 0x0601E8FC RID: 125180 RVA: 0x002D6C71 File Offset: 0x002D4E71
		protected ULandscapeHeightfieldCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010833 RID: 67635
		public new const string __ObjectPath = "/Script/Landscape.LandscapeHeightfieldCollisionComponent";

		// Token: 0x04010834 RID: 67636
		private static IntPtr _ClassPtr;

		// Token: 0x04010835 RID: 67637
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010836 RID: 67638
		internal static int __PropertyOffset_ComponentLayerInfos;

		// Token: 0x04010837 RID: 67639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeLayerInfoObject> _ComponentLayerInfos;

		// Token: 0x04010838 RID: 67640
		internal static int __PropertyOffset_SectionBaseX;

		// Token: 0x04010839 RID: 67641
		internal static int __PropertyOffset_SectionBaseY;

		// Token: 0x0401083A RID: 67642
		internal static int __PropertyOffset_CollisionSizeQuads;

		// Token: 0x0401083B RID: 67643
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x0401083C RID: 67644
		internal static int __PropertyOffset_SimpleCollisionSizeQuads;

		// Token: 0x0401083D RID: 67645
		internal static int __PropertyOffset_CollisionQuadFlags;

		// Token: 0x0401083E RID: 67646
		[Nullable(2)]
		private TArray<byte> _CollisionQuadFlags;

		// Token: 0x0401083F RID: 67647
		internal static int __PropertyOffset_HeightfieldGuid;

		// Token: 0x04010840 RID: 67648
		internal static int __PropertyOffset_CachedLocalBox;

		// Token: 0x04010841 RID: 67649
		internal static int __PropertyOffset_RenderComponent;

		// Token: 0x04010842 RID: 67650
		internal static int __PropertyOffset_CookedPhysicalMaterials;

		// Token: 0x04010843 RID: 67651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _CookedPhysicalMaterials;

		// Token: 0x04010844 RID: 67652
		internal static int __PropertyOffset_bRuntimeDisableCollision;

		// Token: 0x04010845 RID: 67653
		private static IntPtr __GetRenderComponent_NativeFunctionPtr;

		// Token: 0x0200340E RID: 13326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRenderComponent_FunctionParams
		{
			// Token: 0x040173D9 RID: 95193
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
