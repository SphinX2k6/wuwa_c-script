using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F1 RID: 1009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKuroLevelPlayFlowerPollutionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600633D RID: 25405 RVA: 0x0008DE70 File Offset: 0x0008C070
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayFlowerPollutionComponent._ClassPtr;
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x0008DE7C File Offset: 0x0008C07C
		public UKuroLevelPlayFlowerPollutionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayFlowerPollutionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x0008DEA4 File Offset: 0x0008C0A4
		public UKuroLevelPlayFlowerPollutionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayFlowerPollutionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x0008DED8 File Offset: 0x0008C0D8
		// (set) Token: 0x06006341 RID: 25409 RVA: 0x0008DF11 File Offset: 0x0008C111
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

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x0008DF20 File Offset: 0x0008C120
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x0008DF59 File Offset: 0x0008C159
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x0008DF68 File Offset: 0x0008C168
		// (set) Token: 0x06006345 RID: 25413 RVA: 0x0008DFA1 File Offset: 0x0008C1A1
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

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x0008DFAF File Offset: 0x0008C1AF
		// (set) Token: 0x06006347 RID: 25415 RVA: 0x0008DFC9 File Offset: 0x0008C1C9
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06006348 RID: 25416 RVA: 0x0008DFEF File Offset: 0x0008C1EF
		// (set) Token: 0x06006349 RID: 25417 RVA: 0x0008E003 File Offset: 0x0008C203
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

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x0600634A RID: 25418 RVA: 0x0008E018 File Offset: 0x0008C218
		// (set) Token: 0x0600634B RID: 25419 RVA: 0x0008E051 File Offset: 0x0008C251
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

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x0600634C RID: 25420 RVA: 0x0008E074 File Offset: 0x0008C274
		// (set) Token: 0x0600634D RID: 25421 RVA: 0x0008E0AD File Offset: 0x0008C2AD
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

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x0600634E RID: 25422 RVA: 0x0008E0CE File Offset: 0x0008C2CE
		// (set) Token: 0x0600634F RID: 25423 RVA: 0x0008E0DE File Offset: 0x0008C2DE
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

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x0008E0EF File Offset: 0x0008C2EF
		// (set) Token: 0x06006351 RID: 25425 RVA: 0x0008E103 File Offset: 0x0008C303
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

		// Token: 0x06006352 RID: 25426 RVA: 0x0008E118 File Offset: 0x0008C318
		public void Update()
		{
			UKuroLevelPlayFlowerPollutionComponent.__Update_Internal(base.NativePtr);
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x0008E125 File Offset: 0x0008C325
		public bool IsPositionPolluted(double QueryRadius, in FVectorDouble Position)
		{
			return UKuroLevelPlayFlowerPollutionComponent.__IsPositionPolluted_Internal(base.NativePtr, QueryRadius, Position);
		}

		// Token: 0x06006354 RID: 25428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this);

		// Token: 0x06006355 RID: 25429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPositionPolluted_Internal(IntPtr @this, double QueryRadius, in FVectorDouble Position);

		// Token: 0x06006356 RID: 25430 RVA: 0x0008E134 File Offset: 0x0008C334
		static UKuroLevelPlayFlowerPollutionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent");
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x0008E142 File Offset: 0x0008C342
		protected UKuroLevelPlayFlowerPollutionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029F4 RID: 10740
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayFlowerPollutionComponent";

		// Token: 0x040029F5 RID: 10741
		private static IntPtr _ClassPtr;

		// Token: 0x040029F6 RID: 10742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040029F7 RID: 10743
		internal static int __PropertyOffset_ObstaclePbDataIds;

		// Token: 0x040029F8 RID: 10744
		[Nullable(2)]
		private TArray<int> _ObstaclePbDataIds;

		// Token: 0x040029F9 RID: 10745
		internal static int __PropertyOffset_PointLights;

		// Token: 0x040029FA RID: 10746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroLevelPlayPointLight> _PointLights;

		// Token: 0x040029FB RID: 10747
		internal static int __PropertyOffset_SplineValues;

		// Token: 0x040029FC RID: 10748
		[Nullable(2)]
		private TMap<int, bool> _SplineValues;

		// Token: 0x040029FD RID: 10749
		internal static int __PropertyOffset_Consumer;

		// Token: 0x040029FE RID: 10750
		internal static int __PropertyOffset_CircularPackingAlongSplinePrimaryDataAsset;

		// Token: 0x040029FF RID: 10751
		internal static int __PropertyOffset_OnLightUpPointLight;

		// Token: 0x04002A00 RID: 10752
		[Nullable(2)]
		private FLightUpPointLightSignature _OnLightUpPointLight;

		// Token: 0x04002A01 RID: 10753
		internal static int __PropertyOffset_OnSplinePollutionStateChanged;

		// Token: 0x04002A02 RID: 10754
		[Nullable(2)]
		private FSplinePollutionStateChangedSignature _OnSplinePollutionStateChanged;

		// Token: 0x04002A03 RID: 10755
		internal static int __PropertyOffset_MaxFlowerRadius;

		// Token: 0x04002A04 RID: 10756
		internal static int __PropertyOffset_FlowerPartition;
	}
}
