using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017CB RID: 6091
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSSimpleCollisionAxisInstanced")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class AKuroCSSimpleCollisionAxisInstanced : AKuroCSSimpleCollisionAxis, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016589 RID: 91529 RVA: 0x0020AC75 File Offset: 0x00208E75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSSimpleCollisionAxisInstanced._ClassPtr;
		}

		// Token: 0x0601658A RID: 91530 RVA: 0x0020AC84 File Offset: 0x00208E84
		public AKuroCSSimpleCollisionAxisInstanced() : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollisionAxisInstanced.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601658B RID: 91531 RVA: 0x0020ACAC File Offset: 0x00208EAC
		public AKuroCSSimpleCollisionAxisInstanced(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSSimpleCollisionAxisInstanced.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x0601658C RID: 91532 RVA: 0x0020ACDF File Offset: 0x00208EDF
		// (set) Token: 0x0601658D RID: 91533 RVA: 0x0020ACF3 File Offset: 0x00208EF3
		[Nullable(2)]
		public unsafe UKuroCSAxisInstanceDrawComponent InstanceDrawComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCSAxisInstanceDrawComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceDrawComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceDrawComponent, value);
			}
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x0601658E RID: 91534 RVA: 0x0020AD08 File Offset: 0x00208F08
		// (set) Token: 0x0601658F RID: 91535 RVA: 0x0020AD1C File Offset: 0x00208F1C
		[Nullable(2)]
		public unsafe UStaticMesh InstanceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMesh, value);
			}
		}

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x06016590 RID: 91536 RVA: 0x0020AD31 File Offset: 0x00208F31
		// (set) Token: 0x06016591 RID: 91537 RVA: 0x0020AD45 File Offset: 0x00208F45
		public unsafe FVector InstanceLayoutScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceLayoutScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceLayoutScale) = value;
			}
		}

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x06016592 RID: 91538 RVA: 0x0020AD5A File Offset: 0x00208F5A
		// (set) Token: 0x06016593 RID: 91539 RVA: 0x0020AD6E File Offset: 0x00208F6E
		public unsafe FVector InstancePivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstancePivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstancePivotOffset) = value;
			}
		}

		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x06016594 RID: 91540 RVA: 0x0020AD83 File Offset: 0x00208F83
		// (set) Token: 0x06016595 RID: 91541 RVA: 0x0020AD97 File Offset: 0x00208F97
		public unsafe FVector InstanceDrawScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceDrawScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceDrawScale) = value;
			}
		}

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x06016596 RID: 91542 RVA: 0x0020ADAC File Offset: 0x00208FAC
		// (set) Token: 0x06016597 RID: 91543 RVA: 0x0020ADBC File Offset: 0x00208FBC
		public unsafe bool bEnableInstanceDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bEnableInstanceDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bEnableInstanceDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x06016598 RID: 91544 RVA: 0x0020ADCD File Offset: 0x00208FCD
		// (set) Token: 0x06016599 RID: 91545 RVA: 0x0020ADDD File Offset: 0x00208FDD
		public unsafe float InstanceBoundsMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceBoundsMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceBoundsMargin) = value;
			}
		}

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x0601659A RID: 91546 RVA: 0x0020ADF0 File Offset: 0x00208FF0
		// (set) Token: 0x0601659B RID: 91547 RVA: 0x0020AE29 File Offset: 0x00209029
		public TArray<FKuroCSAxisInstanceLayoutEntry> BakedInstanceLayout
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSAxisInstanceLayoutEntry> result;
				if ((result = this._BakedInstanceLayout) == null)
				{
					result = (this._BakedInstanceLayout = new TArray<FKuroCSAxisInstanceLayoutEntry>(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_BakedInstanceLayout, this));
				}
				return result;
			}
			set
			{
				this.BakedInstanceLayout.CopyAssign(value);
			}
		}

		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x0601659C RID: 91548 RVA: 0x0020AE37 File Offset: 0x00209037
		// (set) Token: 0x0601659D RID: 91549 RVA: 0x0020AE4B File Offset: 0x0020904B
		public unsafe FIntPoint BakedTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_BakedTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_BakedTextureSize) = value;
			}
		}

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x0601659E RID: 91550 RVA: 0x0020AE60 File Offset: 0x00209060
		// (set) Token: 0x0601659F RID: 91551 RVA: 0x0020AE70 File Offset: 0x00209070
		public unsafe int BakedInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_BakedInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_BakedInstanceCount) = value;
			}
		}

		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x060165A0 RID: 91552 RVA: 0x0020AE81 File Offset: 0x00209081
		// (set) Token: 0x060165A1 RID: 91553 RVA: 0x0020AE91 File Offset: 0x00209091
		public unsafe bool bDebugDrawInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugDrawInstances) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugDrawInstances) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x060165A2 RID: 91554 RVA: 0x0020AEA2 File Offset: 0x002090A2
		// (set) Token: 0x060165A3 RID: 91555 RVA: 0x0020AEB2 File Offset: 0x002090B2
		public unsafe bool bDebugLogInstanceBuild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugLogInstanceBuild) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugLogInstanceBuild) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x060165A4 RID: 91556 RVA: 0x0020AEC3 File Offset: 0x002090C3
		// (set) Token: 0x060165A5 RID: 91557 RVA: 0x0020AED3 File Offset: 0x002090D3
		public unsafe float DebugDrawSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_DebugDrawSphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_DebugDrawSphereRadius) = value;
			}
		}

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x060165A6 RID: 91558 RVA: 0x0020AEE4 File Offset: 0x002090E4
		// (set) Token: 0x060165A7 RID: 91559 RVA: 0x0020AEF4 File Offset: 0x002090F4
		public unsafe bool bDebugDrawIncludeSimOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugDrawIncludeSimOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bDebugDrawIncludeSimOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x060165A8 RID: 91560 RVA: 0x0020AF08 File Offset: 0x00209108
		// (set) Token: 0x060165A9 RID: 91561 RVA: 0x0020AF41 File Offset: 0x00209141
		public FKuroCSAxisInstanceLayoutRebuiltSignature OnInstanceLayoutRebuilt
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCSAxisInstanceLayoutRebuiltSignature result;
				if ((result = this._OnInstanceLayoutRebuilt) == null)
				{
					result = (this._OnInstanceLayoutRebuilt = new FKuroCSAxisInstanceLayoutRebuiltSignature(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_OnInstanceLayoutRebuilt, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_OnInstanceLayoutRebuilt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x060165AA RID: 91562 RVA: 0x0020AF64 File Offset: 0x00209164
		// (set) Token: 0x060165AB RID: 91563 RVA: 0x0020AF9D File Offset: 0x0020919D
		public TArray<UMaterialInterface> InstanceMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._InstanceMaterials) == null)
				{
					result = (this._InstanceMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMaterials, this));
				}
				return result;
			}
			set
			{
				this.InstanceMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x060165AC RID: 91564 RVA: 0x0020AFAB File Offset: 0x002091AB
		// (set) Token: 0x060165AD RID: 91565 RVA: 0x0020AFBB File Offset: 0x002091BB
		public unsafe bool bPreserveExistingInstanceMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bPreserveExistingInstanceMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bPreserveExistingInstanceMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x060165AE RID: 91566 RVA: 0x0020AFCC File Offset: 0x002091CC
		// (set) Token: 0x060165AF RID: 91567 RVA: 0x0020AFDC File Offset: 0x002091DC
		public unsafe bool bAutoBindSimulationTexturesOnRebuild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bAutoBindSimulationTexturesOnRebuild) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_bAutoBindSimulationTexturesOnRebuild) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x060165B0 RID: 91568 RVA: 0x0020AFED File Offset: 0x002091ED
		// (set) Token: 0x060165B1 RID: 91569 RVA: 0x0020B001 File Offset: 0x00209201
		public unsafe FName InstanceMaterialParamBottomRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMaterialParamBottomRT);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMaterialParamBottomRT) = value;
			}
		}

		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x060165B2 RID: 91570 RVA: 0x0020B016 File Offset: 0x00209216
		// (set) Token: 0x060165B3 RID: 91571 RVA: 0x0020B02A File Offset: 0x0020922A
		public unsafe FName InstanceMaterialParamAxisRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMaterialParamAxisRT);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceMaterialParamAxisRT) = value;
			}
		}

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x060165B4 RID: 91572 RVA: 0x0020B040 File Offset: 0x00209240
		// (set) Token: 0x060165B5 RID: 91573 RVA: 0x0020B079 File Offset: 0x00209279
		public TArray<UMaterialInstanceDynamic> InstanceRenderMIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._InstanceRenderMIDs) == null)
				{
					result = (this._InstanceRenderMIDs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)AKuroCSSimpleCollisionAxisInstanced.__PropertyOffset_InstanceRenderMIDs, this));
				}
				return result;
			}
			set
			{
				this.InstanceRenderMIDs.CopyAssign(value);
			}
		}

		// Token: 0x060165B6 RID: 91574 RVA: 0x0020B087 File Offset: 0x00209287
		public int SetupInstanceRenderMaterials()
		{
			return AKuroCSSimpleCollisionAxisInstanced.__SetupInstanceRenderMaterials_Internal(base.NativePtr);
		}

		// Token: 0x060165B7 RID: 91575 RVA: 0x0020B094 File Offset: 0x00209294
		public void RebuildInstanceLayoutFromTexture()
		{
			AKuroCSSimpleCollisionAxisInstanced.__RebuildInstanceLayoutFromTexture_Internal(base.NativePtr);
		}

		// Token: 0x060165B8 RID: 91576 RVA: 0x0020B0A1 File Offset: 0x002092A1
		public void BakeInstanceLayout()
		{
			AKuroCSSimpleCollisionAxisInstanced.__BakeInstanceLayout_Internal(base.NativePtr);
		}

		// Token: 0x060165B9 RID: 91577 RVA: 0x0020B0AE File Offset: 0x002092AE
		public void ApplyInstanceMaterials()
		{
			AKuroCSSimpleCollisionAxisInstanced.__ApplyInstanceMaterials_Internal(base.NativePtr);
		}

		// Token: 0x060165BA RID: 91578 RVA: 0x0020B0BB File Offset: 0x002092BB
		public void ApplyBakedInstanceLayout()
		{
			AKuroCSSimpleCollisionAxisInstanced.__ApplyBakedInstanceLayout_Internal(base.NativePtr);
		}

		// Token: 0x060165BB RID: 91579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SetupInstanceRenderMaterials_Internal(IntPtr @this);

		// Token: 0x060165BC RID: 91580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildInstanceLayoutFromTexture_Internal(IntPtr @this);

		// Token: 0x060165BD RID: 91581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BakeInstanceLayout_Internal(IntPtr @this);

		// Token: 0x060165BE RID: 91582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyInstanceMaterials_Internal(IntPtr @this);

		// Token: 0x060165BF RID: 91583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyBakedInstanceLayout_Internal(IntPtr @this);

		// Token: 0x060165C0 RID: 91584 RVA: 0x0020B0C8 File Offset: 0x002092C8
		static AKuroCSSimpleCollisionAxisInstanced()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSSimpleCollisionAxisInstanced");
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x0020B0D6 File Offset: 0x002092D6
		protected AKuroCSSimpleCollisionAxisInstanced(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C25F RID: 49759
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSSimpleCollisionAxisInstanced";

		// Token: 0x0400C260 RID: 49760
		private static IntPtr _ClassPtr;

		// Token: 0x0400C261 RID: 49761
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C262 RID: 49762
		internal static int __PropertyOffset_InstanceDrawComponent;

		// Token: 0x0400C263 RID: 49763
		internal static int __PropertyOffset_InstanceMesh;

		// Token: 0x0400C264 RID: 49764
		internal static int __PropertyOffset_InstanceLayoutScale;

		// Token: 0x0400C265 RID: 49765
		internal static int __PropertyOffset_InstancePivotOffset;

		// Token: 0x0400C266 RID: 49766
		internal static int __PropertyOffset_InstanceDrawScale;

		// Token: 0x0400C267 RID: 49767
		internal static int __PropertyOffset_bEnableInstanceDraw;

		// Token: 0x0400C268 RID: 49768
		internal static int __PropertyOffset_InstanceBoundsMargin;

		// Token: 0x0400C269 RID: 49769
		internal static int __PropertyOffset_BakedInstanceLayout;

		// Token: 0x0400C26A RID: 49770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSAxisInstanceLayoutEntry> _BakedInstanceLayout;

		// Token: 0x0400C26B RID: 49771
		internal static int __PropertyOffset_BakedTextureSize;

		// Token: 0x0400C26C RID: 49772
		internal static int __PropertyOffset_BakedInstanceCount;

		// Token: 0x0400C26D RID: 49773
		internal static int __PropertyOffset_bDebugDrawInstances;

		// Token: 0x0400C26E RID: 49774
		internal static int __PropertyOffset_bDebugLogInstanceBuild;

		// Token: 0x0400C26F RID: 49775
		internal static int __PropertyOffset_DebugDrawSphereRadius;

		// Token: 0x0400C270 RID: 49776
		internal static int __PropertyOffset_bDebugDrawIncludeSimOffset;

		// Token: 0x0400C271 RID: 49777
		internal static int __PropertyOffset_OnInstanceLayoutRebuilt;

		// Token: 0x0400C272 RID: 49778
		[Nullable(2)]
		private FKuroCSAxisInstanceLayoutRebuiltSignature _OnInstanceLayoutRebuilt;

		// Token: 0x0400C273 RID: 49779
		internal static int __PropertyOffset_InstanceMaterials;

		// Token: 0x0400C274 RID: 49780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _InstanceMaterials;

		// Token: 0x0400C275 RID: 49781
		internal static int __PropertyOffset_bPreserveExistingInstanceMaterials;

		// Token: 0x0400C276 RID: 49782
		internal static int __PropertyOffset_bAutoBindSimulationTexturesOnRebuild;

		// Token: 0x0400C277 RID: 49783
		internal static int __PropertyOffset_InstanceMaterialParamBottomRT;

		// Token: 0x0400C278 RID: 49784
		internal static int __PropertyOffset_InstanceMaterialParamAxisRT;

		// Token: 0x0400C279 RID: 49785
		internal static int __PropertyOffset_InstanceRenderMIDs;

		// Token: 0x0400C27A RID: 49786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _InstanceRenderMIDs;
	}
}
