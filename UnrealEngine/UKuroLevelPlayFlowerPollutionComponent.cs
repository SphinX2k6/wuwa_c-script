using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018EA RID: 6378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKuroLevelPlayFlowerPollutionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017A64 RID: 96868 RVA: 0x0022A8FA File Offset: 0x00228AFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayFlowerPollutionComponent._ClassPtr;
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x0022A908 File Offset: 0x00228B08
		public UKuroLevelPlayFlowerPollutionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayFlowerPollutionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x0022A930 File Offset: 0x00228B30
		public UKuroLevelPlayFlowerPollutionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayFlowerPollutionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x06017A67 RID: 96871 RVA: 0x0022A964 File Offset: 0x00228B64
		// (set) Token: 0x06017A68 RID: 96872 RVA: 0x0022A99D File Offset: 0x00228B9D
		public TArray<int> ObstaclePbDataIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ObstaclePbDataIds) == null)
				{
					result = (this._ObstaclePbDataIds = new TArray<int>(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_ObstaclePbDataIds, this));
				}
				return result;
			}
			set
			{
				this.ObstaclePbDataIds.CopyAssign(value);
			}
		}

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x06017A69 RID: 96873 RVA: 0x0022A9AC File Offset: 0x00228BAC
		// (set) Token: 0x06017A6A RID: 96874 RVA: 0x0022A9E5 File Offset: 0x00228BE5
		public TMap<int, FKuroLevelPlayPointLight> PointLights
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKuroLevelPlayPointLight> result;
				if ((result = this._PointLights) == null)
				{
					result = (this._PointLights = new TMap<int, FKuroLevelPlayPointLight>(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_PointLights, this));
				}
				return result;
			}
			set
			{
				this.PointLights.CopyAssign(value);
			}
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x06017A6B RID: 96875 RVA: 0x0022A9F4 File Offset: 0x00228BF4
		// (set) Token: 0x06017A6C RID: 96876 RVA: 0x0022AA2D File Offset: 0x00228C2D
		public TMap<int, bool> SplineValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._SplineValues) == null)
				{
					result = (this._SplineValues = new TMap<int, bool>(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_SplineValues, this));
				}
				return result;
			}
			set
			{
				this.SplineValues.CopyAssign(value);
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x06017A6D RID: 96877 RVA: 0x0022AA3B File Offset: 0x00228C3B
		// (set) Token: 0x06017A6E RID: 96878 RVA: 0x0022AA55 File Offset: 0x00228C55
		[Nullable(2)]
		public unsafe IKuroRenderingStampConsumer Consumer
		{
			[NullableContext(2)]
			get
			{
				return (IKuroRenderingStampConsumer)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_Consumer));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_Consumer) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x06017A6F RID: 96879 RVA: 0x0022AA7B File Offset: 0x00228C7B
		// (set) Token: 0x06017A70 RID: 96880 RVA: 0x0022AA8F File Offset: 0x00228C8F
		[Nullable(2)]
		public unsafe UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset CircularPackingAlongSplinePrimaryDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_CircularPackingAlongSplinePrimaryDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_CircularPackingAlongSplinePrimaryDataAsset, value);
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x06017A71 RID: 96881 RVA: 0x0022AAA4 File Offset: 0x00228CA4
		// (set) Token: 0x06017A72 RID: 96882 RVA: 0x0022AADD File Offset: 0x00228CDD
		public FLightUpPointLightSignature OnLightUpPointLight
		{
			get
			{
				base.FastCheckIsValid();
				FLightUpPointLightSignature result;
				if ((result = this._OnLightUpPointLight) == null)
				{
					result = (this._OnLightUpPointLight = new FLightUpPointLightSignature(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_OnLightUpPointLight, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_OnLightUpPointLight, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x06017A73 RID: 96883 RVA: 0x0022AB00 File Offset: 0x00228D00
		// (set) Token: 0x06017A74 RID: 96884 RVA: 0x0022AB39 File Offset: 0x00228D39
		public FSplinePollutionStateChangedSignature OnSplinePollutionStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FSplinePollutionStateChangedSignature result;
				if ((result = this._OnSplinePollutionStateChanged) == null)
				{
					result = (this._OnSplinePollutionStateChanged = new FSplinePollutionStateChangedSignature(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_OnSplinePollutionStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_OnSplinePollutionStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x06017A75 RID: 96885 RVA: 0x0022AB5A File Offset: 0x00228D5A
		// (set) Token: 0x06017A76 RID: 96886 RVA: 0x0022AB6A File Offset: 0x00228D6A
		public unsafe float MaxFlowerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_MaxFlowerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_MaxFlowerRadius) = value;
			}
		}

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x06017A77 RID: 96887 RVA: 0x0022AB7B File Offset: 0x00228D7B
		// (set) Token: 0x06017A78 RID: 96888 RVA: 0x0022AB8F File Offset: 0x00228D8F
		[Nullable(2)]
		public unsafe UKuroCircleStampData CachedCircleData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCircleStampData>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_CachedCircleData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_CachedCircleData, value);
			}
		}

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x06017A79 RID: 96889 RVA: 0x0022ABA4 File Offset: 0x00228DA4
		// (set) Token: 0x06017A7A RID: 96890 RVA: 0x0022ABB8 File Offset: 0x00228DB8
		[Nullable(2)]
		public unsafe UGamePartition FlowerPartition
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGamePartition>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_FlowerPartition);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_FlowerPartition, value);
			}
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x06017A7B RID: 96891 RVA: 0x0022ABD0 File Offset: 0x00228DD0
		// (set) Token: 0x06017A7C RID: 96892 RVA: 0x0022AC09 File Offset: 0x00228E09
		public TArray<FKuroLevelPlayFlower> Flowers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelPlayFlower> result;
				if ((result = this._Flowers) == null)
				{
					result = (this._Flowers = new TArray<FKuroLevelPlayFlower>(base.NativePtr + (IntPtr)UKuroLevelPlayFlowerPollutionComponent.__PropertyOffset_Flowers, this));
				}
				return result;
			}
			set
			{
				this.Flowers.CopyAssign(value);
			}
		}

		// Token: 0x06017A7D RID: 96893 RVA: 0x0022AC17 File Offset: 0x00228E17
		public void Update()
		{
			UKuroLevelPlayFlowerPollutionComponent.__Update_Internal(base.NativePtr);
		}

		// Token: 0x06017A7E RID: 96894 RVA: 0x0022AC24 File Offset: 0x00228E24
		[NullableContext(2)]
		public virtual bool PredictFlowerPollutionAtPosition(in FKuroLevelPlayFlower Flower, in FVectorDouble Position)
		{
			return UKuroLevelPlayFlowerPollutionComponent.__PredictFlowerPollutionAtPosition_Internal(base.NativePtr, (Flower ?? new FKuroLevelPlayFlower()).NativePtr, Position);
		}

		// Token: 0x06017A7F RID: 96895 RVA: 0x0022AC42 File Offset: 0x00228E42
		[NullableContext(2)]
		protected virtual bool PredictFlowerPollutionAtPosition_Implementation(in FKuroLevelPlayFlower Flower, in FVectorDouble Position)
		{
			return UKuroLevelPlayFlowerPollutionComponent.__PredictFlowerPollutionAtPosition_Implementation_Internal(base.NativePtr, (Flower ?? new FKuroLevelPlayFlower()).NativePtr, Position);
		}

		// Token: 0x06017A80 RID: 96896 RVA: 0x0022AC60 File Offset: 0x00228E60
		public bool IsPositionPolluted(double QueryRadius, in FVectorDouble Position)
		{
			return UKuroLevelPlayFlowerPollutionComponent.__IsPositionPolluted_Internal(base.NativePtr, QueryRadius, Position);
		}

		// Token: 0x06017A81 RID: 96897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this);

		// Token: 0x06017A82 RID: 96898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PredictFlowerPollutionAtPosition_Internal(IntPtr @this, IntPtr Flower, in FVectorDouble Position);

		// Token: 0x06017A83 RID: 96899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PredictFlowerPollutionAtPosition_Implementation_Internal(IntPtr @this, IntPtr Flower, in FVectorDouble Position);

		// Token: 0x06017A84 RID: 96900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPositionPolluted_Internal(IntPtr @this, double QueryRadius, in FVectorDouble Position);

		// Token: 0x06017A85 RID: 96901 RVA: 0x0022AC6F File Offset: 0x00228E6F
		static UKuroLevelPlayFlowerPollutionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent");
		}

		// Token: 0x06017A86 RID: 96902 RVA: 0x0022AC7D File Offset: 0x00228E7D
		protected UKuroLevelPlayFlowerPollutionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CD8A RID: 52618
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent";

		// Token: 0x0400CD8B RID: 52619
		private static IntPtr _ClassPtr;

		// Token: 0x0400CD8C RID: 52620
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CD8D RID: 52621
		internal static int __PropertyOffset_ObstaclePbDataIds;

		// Token: 0x0400CD8E RID: 52622
		[Nullable(2)]
		private TArray<int> _ObstaclePbDataIds;

		// Token: 0x0400CD8F RID: 52623
		internal static int __PropertyOffset_PointLights;

		// Token: 0x0400CD90 RID: 52624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroLevelPlayPointLight> _PointLights;

		// Token: 0x0400CD91 RID: 52625
		internal static int __PropertyOffset_SplineValues;

		// Token: 0x0400CD92 RID: 52626
		[Nullable(2)]
		private TMap<int, bool> _SplineValues;

		// Token: 0x0400CD93 RID: 52627
		internal static int __PropertyOffset_Consumer;

		// Token: 0x0400CD94 RID: 52628
		internal static int __PropertyOffset_CircularPackingAlongSplinePrimaryDataAsset;

		// Token: 0x0400CD95 RID: 52629
		internal static int __PropertyOffset_OnLightUpPointLight;

		// Token: 0x0400CD96 RID: 52630
		[Nullable(2)]
		private FLightUpPointLightSignature _OnLightUpPointLight;

		// Token: 0x0400CD97 RID: 52631
		internal static int __PropertyOffset_OnSplinePollutionStateChanged;

		// Token: 0x0400CD98 RID: 52632
		[Nullable(2)]
		private FSplinePollutionStateChangedSignature _OnSplinePollutionStateChanged;

		// Token: 0x0400CD99 RID: 52633
		internal static int __PropertyOffset_MaxFlowerRadius;

		// Token: 0x0400CD9A RID: 52634
		internal static int __PropertyOffset_CachedCircleData;

		// Token: 0x0400CD9B RID: 52635
		internal static int __PropertyOffset_FlowerPartition;

		// Token: 0x0400CD9C RID: 52636
		internal static int __PropertyOffset_Flowers;

		// Token: 0x0400CD9D RID: 52637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelPlayFlower> _Flowers;

		// Token: 0x02002FD3 RID: 12243
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __PredictFlowerPollutionAtPosition_FunctionParams
		{
			// Token: 0x04016BC1 RID: 93121
			[FieldOffset(0)]
			public byte Flower;

			// Token: 0x04016BC2 RID: 93122
			[FieldOffset(56)]
			public FVectorDouble Position;

			// Token: 0x04016BC3 RID: 93123
			[FieldOffset(80)]
			public bool __Result;
		}
	}
}
