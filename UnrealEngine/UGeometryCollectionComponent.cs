using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200142A RID: 5162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent")]
	[UnrealStructLayout(2912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2912)]
	public class UGeometryCollectionComponent : UMeshComponent, IUnrealUObject, IUnrealObject, IChaosNotifyHandlerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012D8C RID: 77196 RVA: 0x001BB757 File Offset: 0x001B9957
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCollectionComponent._ClassPtr;
		}

		// Token: 0x06012D8D RID: 77197 RVA: 0x001BB763 File Offset: 0x001B9963
		int IChaosNotifyHandlerInterface.InterfaceOffset()
		{
			return UGeometryCollectionComponent.__InterfaceOffset_IChaosNotifyHandlerInterface;
		}

		// Token: 0x06012D8E RID: 77198 RVA: 0x001BB76C File Offset: 0x001B996C
		public UGeometryCollectionComponent() : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012D8F RID: 77199 RVA: 0x001BB794 File Offset: 0x001B9994
		public UGeometryCollectionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x06012D90 RID: 77200 RVA: 0x001BB7C7 File Offset: 0x001B99C7
		// (set) Token: 0x06012D91 RID: 77201 RVA: 0x001BB7DB File Offset: 0x001B99DB
		[Nullable(2)]
		public unsafe AChaosSolverActor ChaosSolverActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AChaosSolverActor>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_ChaosSolverActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_ChaosSolverActor, value);
			}
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x06012D92 RID: 77202 RVA: 0x001BB7F0 File Offset: 0x001B99F0
		// (set) Token: 0x06012D93 RID: 77203 RVA: 0x001BB804 File Offset: 0x001B9A04
		[Nullable(2)]
		public unsafe UGeometryCollection RestCollection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_RestCollection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_RestCollection, value);
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x06012D94 RID: 77204 RVA: 0x001BB81C File Offset: 0x001B9A1C
		// (set) Token: 0x06012D95 RID: 77205 RVA: 0x001BB855 File Offset: 0x001B9A55
		public TArray<AFieldSystemActor> InitializationFields
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AFieldSystemActor> result;
				if ((result = this._InitializationFields) == null)
				{
					result = (this._InitializationFields = new TArray<AFieldSystemActor>(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitializationFields, this));
				}
				return result;
			}
			set
			{
				this.InitializationFields.CopyAssign(value);
			}
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x06012D96 RID: 77206 RVA: 0x001BB863 File Offset: 0x001B9A63
		// (set) Token: 0x06012D97 RID: 77207 RVA: 0x001BB873 File Offset: 0x001B9A73
		public unsafe bool Simulating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_Simulating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_Simulating) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x06012D98 RID: 77208 RVA: 0x001BB884 File Offset: 0x001B9A84
		// (set) Token: 0x06012D99 RID: 77209 RVA: 0x001BB894 File Offset: 0x001B9A94
		public unsafe EObjectStateTypeEnum ObjectType
		{
			get
			{
				return (EObjectStateTypeEnum)(*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ObjectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ObjectType) = (byte)value;
			}
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x06012D9A RID: 77210 RVA: 0x001BB8A5 File Offset: 0x001B9AA5
		// (set) Token: 0x06012D9B RID: 77211 RVA: 0x001BB8B5 File Offset: 0x001B9AB5
		public unsafe bool EnableClustering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_EnableClustering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_EnableClustering) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x06012D9C RID: 77212 RVA: 0x001BB8C6 File Offset: 0x001B9AC6
		// (set) Token: 0x06012D9D RID: 77213 RVA: 0x001BB8D6 File Offset: 0x001B9AD6
		public unsafe int ClusterGroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ClusterGroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ClusterGroupIndex) = value;
			}
		}

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x06012D9E RID: 77214 RVA: 0x001BB8E7 File Offset: 0x001B9AE7
		// (set) Token: 0x06012D9F RID: 77215 RVA: 0x001BB8F7 File Offset: 0x001B9AF7
		public unsafe int MaxClusterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_MaxClusterLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_MaxClusterLevel) = value;
			}
		}

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x06012DA0 RID: 77216 RVA: 0x001BB908 File Offset: 0x001B9B08
		// (set) Token: 0x06012DA1 RID: 77217 RVA: 0x001BB941 File Offset: 0x001B9B41
		public TArray<float> DamageThreshold
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DamageThreshold) == null)
				{
					result = (this._DamageThreshold = new TArray<float>(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_DamageThreshold, this));
				}
				return result;
			}
			set
			{
				this.DamageThreshold.CopyAssign(value);
			}
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x06012DA2 RID: 77218 RVA: 0x001BB94F File Offset: 0x001B9B4F
		// (set) Token: 0x06012DA3 RID: 77219 RVA: 0x001BB95F File Offset: 0x001B9B5F
		public unsafe EClusterConnectionTypeEnum ClusterConnectionType
		{
			get
			{
				return (EClusterConnectionTypeEnum)(*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ClusterConnectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ClusterConnectionType) = (byte)value;
			}
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x06012DA4 RID: 77220 RVA: 0x001BB970 File Offset: 0x001B9B70
		// (set) Token: 0x06012DA5 RID: 77221 RVA: 0x001BB980 File Offset: 0x001B9B80
		public unsafe int CollisionGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CollisionGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CollisionGroup) = value;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x06012DA6 RID: 77222 RVA: 0x001BB991 File Offset: 0x001B9B91
		// (set) Token: 0x06012DA7 RID: 77223 RVA: 0x001BB9A1 File Offset: 0x001B9BA1
		public unsafe float CollisionSampleFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CollisionSampleFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CollisionSampleFraction) = value;
			}
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x06012DA8 RID: 77224 RVA: 0x001BB9B2 File Offset: 0x001B9BB2
		// (set) Token: 0x06012DA9 RID: 77225 RVA: 0x001BB9C2 File Offset: 0x001B9BC2
		public unsafe float LinearEtherDrag_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_LinearEtherDrag_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_LinearEtherDrag_DEPRECATED) = value;
			}
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x06012DAA RID: 77226 RVA: 0x001BB9D3 File Offset: 0x001B9BD3
		// (set) Token: 0x06012DAB RID: 77227 RVA: 0x001BB9E3 File Offset: 0x001B9BE3
		public unsafe float AngularEtherDrag_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_AngularEtherDrag_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_AngularEtherDrag_DEPRECATED) = value;
			}
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x06012DAC RID: 77228 RVA: 0x001BB9F4 File Offset: 0x001B9BF4
		// (set) Token: 0x06012DAD RID: 77229 RVA: 0x001BBA08 File Offset: 0x001B9C08
		[Nullable(2)]
		public unsafe UChaosPhysicalMaterial PhysicalMaterial_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChaosPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_PhysicalMaterial_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_PhysicalMaterial_DEPRECATED, value);
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x06012DAE RID: 77230 RVA: 0x001BBA1D File Offset: 0x001B9C1D
		// (set) Token: 0x06012DAF RID: 77231 RVA: 0x001BBA2D File Offset: 0x001B9C2D
		public unsafe EInitialVelocityTypeEnum InitialVelocityType
		{
			get
			{
				return (EInitialVelocityTypeEnum)(*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialVelocityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialVelocityType) = (byte)value;
			}
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x06012DB0 RID: 77232 RVA: 0x001BBA3E File Offset: 0x001B9C3E
		// (set) Token: 0x06012DB1 RID: 77233 RVA: 0x001BBA52 File Offset: 0x001B9C52
		public unsafe FVector InitialLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialLinearVelocity) = value;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x06012DB2 RID: 77234 RVA: 0x001BBA67 File Offset: 0x001B9C67
		// (set) Token: 0x06012DB3 RID: 77235 RVA: 0x001BBA7B File Offset: 0x001B9C7B
		public unsafe FVector InitialAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_InitialAngularVelocity) = value;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x06012DB4 RID: 77236 RVA: 0x001BBA90 File Offset: 0x001B9C90
		// (set) Token: 0x06012DB5 RID: 77237 RVA: 0x001BBAA4 File Offset: 0x001B9CA4
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysicalMaterialOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_PhysicalMaterialOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_PhysicalMaterialOverride, value);
			}
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x06012DB6 RID: 77238 RVA: 0x001BBABC File Offset: 0x001B9CBC
		// (set) Token: 0x06012DB7 RID: 77239 RVA: 0x001BBAF5 File Offset: 0x001B9CF5
		public FGeomComponentCacheParameters CacheParameters
		{
			get
			{
				base.FastCheckIsValid();
				FGeomComponentCacheParameters result;
				if ((result = this._CacheParameters) == null)
				{
					result = (this._CacheParameters = new FGeomComponentCacheParameters(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CacheParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeomComponentCacheParameters.StaticStruct(), base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CacheParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x06012DB8 RID: 77240 RVA: 0x001BBB18 File Offset: 0x001B9D18
		// (set) Token: 0x06012DB9 RID: 77241 RVA: 0x001BBB51 File Offset: 0x001B9D51
		public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange
		{
			get
			{
				base.FastCheckIsValid();
				FNotifyGeometryCollectionPhysicsStateChange result;
				if ((result = this._NotifyGeometryCollectionPhysicsStateChange) == null)
				{
					result = (this._NotifyGeometryCollectionPhysicsStateChange = new FNotifyGeometryCollectionPhysicsStateChange(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_NotifyGeometryCollectionPhysicsStateChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_NotifyGeometryCollectionPhysicsStateChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x06012DBA RID: 77242 RVA: 0x001BBB74 File Offset: 0x001B9D74
		// (set) Token: 0x06012DBB RID: 77243 RVA: 0x001BBBAD File Offset: 0x001B9DAD
		public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange
		{
			get
			{
				base.FastCheckIsValid();
				FNotifyGeometryCollectionPhysicsLoadingStateChange result;
				if ((result = this._NotifyGeometryCollectionPhysicsLoadingStateChange) == null)
				{
					result = (this._NotifyGeometryCollectionPhysicsLoadingStateChange = new FNotifyGeometryCollectionPhysicsLoadingStateChange(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_NotifyGeometryCollectionPhysicsLoadingStateChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_NotifyGeometryCollectionPhysicsLoadingStateChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x06012DBC RID: 77244 RVA: 0x001BBBD0 File Offset: 0x001B9DD0
		// (set) Token: 0x06012DBD RID: 77245 RVA: 0x001BBC09 File Offset: 0x001B9E09
		public FOnChaosBreakEvent OnChaosBreakEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosBreakEvent result;
				if ((result = this._OnChaosBreakEvent) == null)
				{
					result = (this._OnChaosBreakEvent = new FOnChaosBreakEvent(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_OnChaosBreakEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_OnChaosBreakEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x06012DBE RID: 77246 RVA: 0x001BBC2A File Offset: 0x001B9E2A
		// (set) Token: 0x06012DBF RID: 77247 RVA: 0x001BBC3A File Offset: 0x001B9E3A
		public unsafe float DesiredCacheTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_DesiredCacheTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_DesiredCacheTime) = value;
			}
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x06012DC0 RID: 77248 RVA: 0x001BBC4B File Offset: 0x001B9E4B
		// (set) Token: 0x06012DC1 RID: 77249 RVA: 0x001BBC5B File Offset: 0x001B9E5B
		public unsafe bool CachePlayback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CachePlayback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_CachePlayback) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x06012DC2 RID: 77250 RVA: 0x001BBC6C File Offset: 0x001B9E6C
		// (set) Token: 0x06012DC3 RID: 77251 RVA: 0x001BBCA5 File Offset: 0x001B9EA5
		public FOnChaosPhysicsCollision OnChaosPhysicsCollision
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosPhysicsCollision result;
				if ((result = this._OnChaosPhysicsCollision) == null)
				{
					result = (this._OnChaosPhysicsCollision = new FOnChaosPhysicsCollision(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_OnChaosPhysicsCollision, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_OnChaosPhysicsCollision, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x06012DC4 RID: 77252 RVA: 0x001BBCC6 File Offset: 0x001B9EC6
		// (set) Token: 0x06012DC5 RID: 77253 RVA: 0x001BBCD6 File Offset: 0x001B9ED6
		public unsafe bool bNotifyBreaks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bNotifyBreaks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bNotifyBreaks) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x06012DC6 RID: 77254 RVA: 0x001BBCE7 File Offset: 0x001B9EE7
		// (set) Token: 0x06012DC7 RID: 77255 RVA: 0x001BBCF7 File Offset: 0x001B9EF7
		public unsafe bool bNotifyCollisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bNotifyCollisions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bNotifyCollisions) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x06012DC8 RID: 77256 RVA: 0x001BBD08 File Offset: 0x001B9F08
		// (set) Token: 0x06012DC9 RID: 77257 RVA: 0x001BBD18 File Offset: 0x001B9F18
		public unsafe bool bEnableReplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bEnableReplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bEnableReplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x06012DCA RID: 77258 RVA: 0x001BBD29 File Offset: 0x001B9F29
		// (set) Token: 0x06012DCB RID: 77259 RVA: 0x001BBD39 File Offset: 0x001B9F39
		public unsafe bool bEnableAbandonAfterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bEnableAbandonAfterLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_bEnableAbandonAfterLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x06012DCC RID: 77260 RVA: 0x001BBD4A File Offset: 0x001B9F4A
		// (set) Token: 0x06012DCD RID: 77261 RVA: 0x001BBD5A File Offset: 0x001B9F5A
		public unsafe int ReplicationAbandonClusterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ReplicationAbandonClusterLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_ReplicationAbandonClusterLevel) = value;
			}
		}

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06012DCE RID: 77262 RVA: 0x001BBD6C File Offset: 0x001B9F6C
		// (set) Token: 0x06012DCF RID: 77263 RVA: 0x001BBDA5 File Offset: 0x001B9FA5
		public FGeometryCollectionRepData RepData
		{
			get
			{
				base.FastCheckIsValid();
				FGeometryCollectionRepData result;
				if ((result = this._RepData) == null)
				{
					result = (this._RepData = new FGeometryCollectionRepData(base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_RepData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometryCollectionRepData.StaticStruct(), base.NativePtr + (IntPtr)UGeometryCollectionComponent.__PropertyOffset_RepData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06012DD0 RID: 77264 RVA: 0x001BBDC6 File Offset: 0x001B9FC6
		// (set) Token: 0x06012DD1 RID: 77265 RVA: 0x001BBDDA File Offset: 0x001B9FDA
		[Nullable(2)]
		public unsafe UBodySetup DummyBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_DummyBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionComponent.__PropertyOffset_DummyBodySetup, value);
			}
		}

		// Token: 0x06012DD2 RID: 77266 RVA: 0x001BBDEF File Offset: 0x001B9FEF
		public void SetNotifyBreaks(bool bNewNotifyBreaks)
		{
			UGeometryCollectionComponent.__SetNotifyBreaks_Internal(base.NativePtr, bNewNotifyBreaks);
		}

		// Token: 0x06012DD3 RID: 77267 RVA: 0x001BBDFD File Offset: 0x001B9FFD
		[NullableContext(2)]
		public virtual void ReceivePhysicsCollision(in FChaosPhysicsCollisionInfo CollisionInfo)
		{
			UGeometryCollectionComponent.__ReceivePhysicsCollision_Internal(base.NativePtr, (CollisionInfo ?? new FChaosPhysicsCollisionInfo()).NativePtr);
		}

		// Token: 0x06012DD4 RID: 77268 RVA: 0x001BBE1A File Offset: 0x001BA01A
		[NullableContext(2)]
		public void OnRep_RepData(in FGeometryCollectionRepData OldData)
		{
			UGeometryCollectionComponent.__OnRep_RepData_Internal(base.NativePtr, (OldData ?? new FGeometryCollectionRepData()).NativePtr);
		}

		// Token: 0x06012DD5 RID: 77269 RVA: 0x001BBE37 File Offset: 0x001BA037
		public void NetAbandonCluster(int TransformIndex)
		{
			UGeometryCollectionComponent.__NetAbandonCluster_Internal(base.NativePtr, TransformIndex);
		}

		// Token: 0x06012DD6 RID: 77270 RVA: 0x001BBE45 File Offset: 0x001BA045
		[NullableContext(2)]
		public void ApplyPhysicsField(bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			UGeometryCollectionComponent.__ApplyPhysicsField_Internal(base.NativePtr, Enabled, Target, (MetaData != null) ? MetaData.NativePtr : IntPtr.Zero, (Field != null) ? Field.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012DD7 RID: 77271 RVA: 0x001BBE76 File Offset: 0x001BA076
		public void ApplyKinematicField(float Radius, FVector Position)
		{
			UGeometryCollectionComponent.__ApplyKinematicField_Internal(base.NativePtr, Radius, Position);
		}

		// Token: 0x06012DD8 RID: 77272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNotifyBreaks_Internal(IntPtr @this, bool bNewNotifyBreaks);

		// Token: 0x06012DD9 RID: 77273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePhysicsCollision_Internal(IntPtr @this, IntPtr CollisionInfo);

		// Token: 0x06012DDA RID: 77274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_RepData_Internal(IntPtr @this, IntPtr OldData);

		// Token: 0x06012DDB RID: 77275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetAbandonCluster_Internal(IntPtr @this, int TransformIndex);

		// Token: 0x06012DDC RID: 77276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPhysicsField_Internal(IntPtr @this, bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, IntPtr MetaData, IntPtr Field);

		// Token: 0x06012DDD RID: 77277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyKinematicField_Internal(IntPtr @this, float Radius, FVector Position);

		// Token: 0x06012DDE RID: 77278 RVA: 0x001BBE85 File Offset: 0x001BA085
		static UGeometryCollectionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionComponent");
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x001BBE93 File Offset: 0x001BA093
		protected UGeometryCollectionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A125 RID: 41253
		internal static int __InterfaceOffset_IChaosNotifyHandlerInterface;

		// Token: 0x0400A126 RID: 41254
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionComponent";

		// Token: 0x0400A127 RID: 41255
		private static IntPtr _ClassPtr;

		// Token: 0x0400A128 RID: 41256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A129 RID: 41257
		public static IntPtr __NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400A12A RID: 41258
		public static IntPtr __NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400A12B RID: 41259
		internal static int __PropertyOffset_ChaosSolverActor;

		// Token: 0x0400A12C RID: 41260
		internal static int __PropertyOffset_RestCollection;

		// Token: 0x0400A12D RID: 41261
		internal static int __PropertyOffset_InitializationFields;

		// Token: 0x0400A12E RID: 41262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AFieldSystemActor> _InitializationFields;

		// Token: 0x0400A12F RID: 41263
		internal static int __PropertyOffset_Simulating;

		// Token: 0x0400A130 RID: 41264
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x0400A131 RID: 41265
		internal static int __PropertyOffset_EnableClustering;

		// Token: 0x0400A132 RID: 41266
		internal static int __PropertyOffset_ClusterGroupIndex;

		// Token: 0x0400A133 RID: 41267
		internal static int __PropertyOffset_MaxClusterLevel;

		// Token: 0x0400A134 RID: 41268
		internal static int __PropertyOffset_DamageThreshold;

		// Token: 0x0400A135 RID: 41269
		[Nullable(2)]
		private TArray<float> _DamageThreshold;

		// Token: 0x0400A136 RID: 41270
		internal static int __PropertyOffset_ClusterConnectionType;

		// Token: 0x0400A137 RID: 41271
		internal static int __PropertyOffset_CollisionGroup;

		// Token: 0x0400A138 RID: 41272
		internal static int __PropertyOffset_CollisionSampleFraction;

		// Token: 0x0400A139 RID: 41273
		internal static int __PropertyOffset_LinearEtherDrag_DEPRECATED;

		// Token: 0x0400A13A RID: 41274
		internal static int __PropertyOffset_AngularEtherDrag_DEPRECATED;

		// Token: 0x0400A13B RID: 41275
		internal static int __PropertyOffset_PhysicalMaterial_DEPRECATED;

		// Token: 0x0400A13C RID: 41276
		internal static int __PropertyOffset_InitialVelocityType;

		// Token: 0x0400A13D RID: 41277
		internal static int __PropertyOffset_InitialLinearVelocity;

		// Token: 0x0400A13E RID: 41278
		internal static int __PropertyOffset_InitialAngularVelocity;

		// Token: 0x0400A13F RID: 41279
		internal static int __PropertyOffset_PhysicalMaterialOverride;

		// Token: 0x0400A140 RID: 41280
		internal static int __PropertyOffset_CacheParameters;

		// Token: 0x0400A141 RID: 41281
		[Nullable(2)]
		private FGeomComponentCacheParameters _CacheParameters;

		// Token: 0x0400A142 RID: 41282
		internal static int __PropertyOffset_NotifyGeometryCollectionPhysicsStateChange;

		// Token: 0x0400A143 RID: 41283
		[Nullable(2)]
		private FNotifyGeometryCollectionPhysicsStateChange _NotifyGeometryCollectionPhysicsStateChange;

		// Token: 0x0400A144 RID: 41284
		internal static int __PropertyOffset_NotifyGeometryCollectionPhysicsLoadingStateChange;

		// Token: 0x0400A145 RID: 41285
		[Nullable(2)]
		private FNotifyGeometryCollectionPhysicsLoadingStateChange _NotifyGeometryCollectionPhysicsLoadingStateChange;

		// Token: 0x0400A146 RID: 41286
		internal static int __PropertyOffset_OnChaosBreakEvent;

		// Token: 0x0400A147 RID: 41287
		[Nullable(2)]
		private FOnChaosBreakEvent _OnChaosBreakEvent;

		// Token: 0x0400A148 RID: 41288
		internal static int __PropertyOffset_DesiredCacheTime;

		// Token: 0x0400A149 RID: 41289
		internal static int __PropertyOffset_CachePlayback;

		// Token: 0x0400A14A RID: 41290
		internal static int __PropertyOffset_OnChaosPhysicsCollision;

		// Token: 0x0400A14B RID: 41291
		[Nullable(2)]
		private FOnChaosPhysicsCollision _OnChaosPhysicsCollision;

		// Token: 0x0400A14C RID: 41292
		internal static int __PropertyOffset_bNotifyBreaks;

		// Token: 0x0400A14D RID: 41293
		internal static int __PropertyOffset_bNotifyCollisions;

		// Token: 0x0400A14E RID: 41294
		internal static int __PropertyOffset_bEnableReplication;

		// Token: 0x0400A14F RID: 41295
		internal static int __PropertyOffset_bEnableAbandonAfterLevel;

		// Token: 0x0400A150 RID: 41296
		internal static int __PropertyOffset_ReplicationAbandonClusterLevel;

		// Token: 0x0400A151 RID: 41297
		internal static int __PropertyOffset_RepData;

		// Token: 0x0400A152 RID: 41298
		[Nullable(2)]
		private FGeometryCollectionRepData _RepData;

		// Token: 0x0400A153 RID: 41299
		internal static int __PropertyOffset_DummyBodySetup;

		// Token: 0x02002E7F RID: 11903
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceivePhysicsCollision_FunctionParams
		{
			// Token: 0x04016953 RID: 92499
			[FieldOffset(0)]
			public byte CollisionInfo;
		}
	}
}
