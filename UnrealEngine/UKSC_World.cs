using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E5D RID: 7773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_World")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class UKSC_World : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D97B RID: 121211 RVA: 0x002BB122 File Offset: 0x002B9322
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_World._ClassPtr;
		}

		// Token: 0x0601D97C RID: 121212 RVA: 0x002BB130 File Offset: 0x002B9330
		public UKSC_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D97D RID: 121213 RVA: 0x002BB158 File Offset: 0x002B9358
		public UKSC_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007739 RID: 30521
		// (get) Token: 0x0601D97E RID: 121214 RVA: 0x002BB18C File Offset: 0x002B938C
		// (set) Token: 0x0601D97F RID: 121215 RVA: 0x002BB1C5 File Offset: 0x002B93C5
		public TArray<UKSC_SceneComp> SceneComps_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_SceneComp> result;
				if ((result = this._SceneComps_) == null)
				{
					result = (this._SceneComps_ = new TArray<UKSC_SceneComp>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_SceneComps_, this));
				}
				return result;
			}
			set
			{
				this.SceneComps_.CopyAssign(value);
			}
		}

		// Token: 0x1700773A RID: 30522
		// (get) Token: 0x0601D980 RID: 121216 RVA: 0x002BB1D4 File Offset: 0x002B93D4
		// (set) Token: 0x0601D981 RID: 121217 RVA: 0x002BB20D File Offset: 0x002B940D
		public TArray<AKSC_Entity> Entities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._Entities_) == null)
				{
					result = (this._Entities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_Entities_, this));
				}
				return result;
			}
			set
			{
				this.Entities_.CopyAssign(value);
			}
		}

		// Token: 0x1700773B RID: 30523
		// (get) Token: 0x0601D982 RID: 121218 RVA: 0x002BB21C File Offset: 0x002B941C
		// (set) Token: 0x0601D983 RID: 121219 RVA: 0x002BB255 File Offset: 0x002B9455
		public TMap<int, AKSC_Entity> EntityIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, AKSC_Entity> result;
				if ((result = this._EntityIdMap) == null)
				{
					result = (this._EntityIdMap = new TMap<int, AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_EntityIdMap, this));
				}
				return result;
			}
			set
			{
				this.EntityIdMap.CopyAssign(value);
			}
		}

		// Token: 0x1700773C RID: 30524
		// (get) Token: 0x0601D984 RID: 121220 RVA: 0x002BB264 File Offset: 0x002B9464
		// (set) Token: 0x0601D985 RID: 121221 RVA: 0x002BB29D File Offset: 0x002B949D
		public TArray<AKSC_Entity> DeadEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._DeadEntities_) == null)
				{
					result = (this._DeadEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_DeadEntities_, this));
				}
				return result;
			}
			set
			{
				this.DeadEntities_.CopyAssign(value);
			}
		}

		// Token: 0x1700773D RID: 30525
		// (get) Token: 0x0601D986 RID: 121222 RVA: 0x002BB2AC File Offset: 0x002B94AC
		// (set) Token: 0x0601D987 RID: 121223 RVA: 0x002BB2E5 File Offset: 0x002B94E5
		public TArray<AKSC_Entity> ShowHeadUIEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ShowHeadUIEntities_) == null)
				{
					result = (this._ShowHeadUIEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ShowHeadUIEntities_, this));
				}
				return result;
			}
			set
			{
				this.ShowHeadUIEntities_.CopyAssign(value);
			}
		}

		// Token: 0x1700773E RID: 30526
		// (get) Token: 0x0601D988 RID: 121224 RVA: 0x002BB2F4 File Offset: 0x002B94F4
		// (set) Token: 0x0601D989 RID: 121225 RVA: 0x002BB32D File Offset: 0x002B952D
		public TArray<AKSC_Entity> ToRemoveEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ToRemoveEntities_) == null)
				{
					result = (this._ToRemoveEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToRemoveEntities_, this));
				}
				return result;
			}
			set
			{
				this.ToRemoveEntities_.CopyAssign(value);
			}
		}

		// Token: 0x1700773F RID: 30527
		// (get) Token: 0x0601D98A RID: 121226 RVA: 0x002BB33C File Offset: 0x002B953C
		// (set) Token: 0x0601D98B RID: 121227 RVA: 0x002BB375 File Offset: 0x002B9575
		public TArray<AKSC_Entity> ToAddEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ToAddEntities_) == null)
				{
					result = (this._ToAddEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToAddEntities_, this));
				}
				return result;
			}
			set
			{
				this.ToAddEntities_.CopyAssign(value);
			}
		}

		// Token: 0x17007740 RID: 30528
		// (get) Token: 0x0601D98C RID: 121228 RVA: 0x002BB384 File Offset: 0x002B9584
		// (set) Token: 0x0601D98D RID: 121229 RVA: 0x002BB3BD File Offset: 0x002B95BD
		public TArray<FKSC_LandFireContext> ToAddLandFire_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_LandFireContext> result;
				if ((result = this._ToAddLandFire_) == null)
				{
					result = (this._ToAddLandFire_ = new TArray<FKSC_LandFireContext>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToAddLandFire_, this));
				}
				return result;
			}
			set
			{
				this.ToAddLandFire_.CopyAssign(value);
			}
		}

		// Token: 0x17007741 RID: 30529
		// (get) Token: 0x0601D98E RID: 121230 RVA: 0x002BB3CC File Offset: 0x002B95CC
		// (set) Token: 0x0601D98F RID: 121231 RVA: 0x002BB405 File Offset: 0x002B9605
		public TMap<AKSC_Entity, AActor> RenderActorMap_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKSC_Entity, AActor> result;
				if ((result = this._RenderActorMap_) == null)
				{
					result = (this._RenderActorMap_ = new TMap<AKSC_Entity, AActor>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_RenderActorMap_, this));
				}
				return result;
			}
			set
			{
				this.RenderActorMap_.CopyAssign(value);
			}
		}

		// Token: 0x17007742 RID: 30530
		// (get) Token: 0x0601D990 RID: 121232 RVA: 0x002BB414 File Offset: 0x002B9614
		// (set) Token: 0x0601D991 RID: 121233 RVA: 0x002BB44D File Offset: 0x002B964D
		public TMap<UKSC_DA_EntityRender, AActor> SharedRenderActorDaMap_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_EntityRender, AActor> result;
				if ((result = this._SharedRenderActorDaMap_) == null)
				{
					result = (this._SharedRenderActorDaMap_ = new TMap<UKSC_DA_EntityRender, AActor>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_SharedRenderActorDaMap_, this));
				}
				return result;
			}
			set
			{
				this.SharedRenderActorDaMap_.CopyAssign(value);
			}
		}

		// Token: 0x17007743 RID: 30531
		// (get) Token: 0x0601D992 RID: 121234 RVA: 0x002BB45B File Offset: 0x002B965B
		// (set) Token: 0x0601D993 RID: 121235 RVA: 0x002BB46F File Offset: 0x002B966F
		[Nullable(2)]
		public unsafe AKSC_GPUHeadUI GPUHeadUI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_GPUHeadUI>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_GPUHeadUI);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_GPUHeadUI, value);
			}
		}

		// Token: 0x17007744 RID: 30532
		// (get) Token: 0x0601D994 RID: 121236 RVA: 0x002BB484 File Offset: 0x002B9684
		// (set) Token: 0x0601D995 RID: 121237 RVA: 0x002BB498 File Offset: 0x002B9698
		[Nullable(2)]
		public unsafe UKSC_HitContextTextHandle HitContextTextHandle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_HitContextTextHandle>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_HitContextTextHandle);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_HitContextTextHandle, value);
			}
		}

		// Token: 0x17007745 RID: 30533
		// (get) Token: 0x0601D996 RID: 121238 RVA: 0x002BB4B0 File Offset: 0x002B96B0
		// (set) Token: 0x0601D997 RID: 121239 RVA: 0x002BB4E9 File Offset: 0x002B96E9
		public TMap<EKSC_AttrType, EKSC_AttrType> AttributeIdsWithMax
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, EKSC_AttrType> result;
				if ((result = this._AttributeIdsWithMax) == null)
				{
					result = (this._AttributeIdsWithMax = new TMap<EKSC_AttrType, EKSC_AttrType>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_AttributeIdsWithMax, this));
				}
				return result;
			}
			set
			{
				this.AttributeIdsWithMax.CopyAssign(value);
			}
		}

		// Token: 0x17007746 RID: 30534
		// (get) Token: 0x0601D998 RID: 121240 RVA: 0x002BB4F8 File Offset: 0x002B96F8
		// (set) Token: 0x0601D999 RID: 121241 RVA: 0x002BB531 File Offset: 0x002B9731
		public TMap<EKSC_AttrType, int> AttributeEffectiveDamageType
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._AttributeEffectiveDamageType) == null)
				{
					result = (this._AttributeEffectiveDamageType = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_AttributeEffectiveDamageType, this));
				}
				return result;
			}
			set
			{
				this.AttributeEffectiveDamageType.CopyAssign(value);
			}
		}

		// Token: 0x17007747 RID: 30535
		// (get) Token: 0x0601D99A RID: 121242 RVA: 0x002BB540 File Offset: 0x002B9740
		// (set) Token: 0x0601D99B RID: 121243 RVA: 0x002BB579 File Offset: 0x002B9779
		public FOnKSCBatchRemoveAfter OnKSCBatchRemoveAfter
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCBatchRemoveAfter result;
				if ((result = this._OnKSCBatchRemoveAfter) == null)
				{
					result = (this._OnKSCBatchRemoveAfter = new FOnKSCBatchRemoveAfter(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCBatchRemoveAfter, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCBatchRemoveAfter, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007748 RID: 30536
		// (get) Token: 0x0601D99C RID: 121244 RVA: 0x002BB59C File Offset: 0x002B979C
		// (set) Token: 0x0601D99D RID: 121245 RVA: 0x002BB5D5 File Offset: 0x002B97D5
		public FOnKSCLandFireSpawn OnKSCLandFireSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCLandFireSpawn result;
				if ((result = this._OnKSCLandFireSpawn) == null)
				{
					result = (this._OnKSCLandFireSpawn = new FOnKSCLandFireSpawn(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCLandFireSpawn, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCLandFireSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007749 RID: 30537
		// (get) Token: 0x0601D99E RID: 121246 RVA: 0x002BB5F8 File Offset: 0x002B97F8
		// (set) Token: 0x0601D99F RID: 121247 RVA: 0x002BB631 File Offset: 0x002B9831
		public FOnKSCEntitySpawn OnKSCEntitySpawn
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCEntitySpawn result;
				if ((result = this._OnKSCEntitySpawn) == null)
				{
					result = (this._OnKSCEntitySpawn = new FOnKSCEntitySpawn(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySpawn, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700774A RID: 30538
		// (get) Token: 0x0601D9A0 RID: 121248 RVA: 0x002BB654 File Offset: 0x002B9854
		// (set) Token: 0x0601D9A1 RID: 121249 RVA: 0x002BB68D File Offset: 0x002B988D
		public FOnKSCEntitySummon OnKSCEntitySummon
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCEntitySummon result;
				if ((result = this._OnKSCEntitySummon) == null)
				{
					result = (this._OnKSCEntitySummon = new FOnKSCEntitySummon(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySummon, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySummon, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700774B RID: 30539
		// (get) Token: 0x0601D9A2 RID: 121250 RVA: 0x002BB6B0 File Offset: 0x002B98B0
		// (set) Token: 0x0601D9A3 RID: 121251 RVA: 0x002BB6E9 File Offset: 0x002B98E9
		public TArray<UKSC_Decorator> Decorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Decorator> result;
				if ((result = this._Decorators) == null)
				{
					result = (this._Decorators = new TArray<UKSC_Decorator>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_Decorators, this));
				}
				return result;
			}
			set
			{
				this.Decorators.CopyAssign(value);
			}
		}

		// Token: 0x1700774C RID: 30540
		// (get) Token: 0x0601D9A4 RID: 121252 RVA: 0x002BB6F8 File Offset: 0x002B98F8
		// (set) Token: 0x0601D9A5 RID: 121253 RVA: 0x002BB731 File Offset: 0x002B9931
		public TMap<EKSC_HeadUiType, UClass> HeadUiHandleClassMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_HeadUiType, UClass> result;
				if ((result = this._HeadUiHandleClassMap) == null)
				{
					result = (this._HeadUiHandleClassMap = new TMap<EKSC_HeadUiType, UClass>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_HeadUiHandleClassMap, this));
				}
				return result;
			}
			set
			{
				this.HeadUiHandleClassMap.CopyAssign(value);
			}
		}

		// Token: 0x1700774D RID: 30541
		// (get) Token: 0x0601D9A6 RID: 121254 RVA: 0x002BB73F File Offset: 0x002B993F
		// (set) Token: 0x0601D9A7 RID: 121255 RVA: 0x002BB753 File Offset: 0x002B9953
		[Nullable(2)]
		public unsafe UKSC_DamageHandler DamageHandler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DamageHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageHandler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageHandler, value);
			}
		}

		// Token: 0x1700774E RID: 30542
		// (get) Token: 0x0601D9A8 RID: 121256 RVA: 0x002BB768 File Offset: 0x002B9968
		// (set) Token: 0x0601D9A9 RID: 121257 RVA: 0x002BB7A1 File Offset: 0x002B99A1
		public TSet<UObject> PoolHelper_
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._PoolHelper_) == null)
				{
					result = (this._PoolHelper_ = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_PoolHelper_, this));
				}
				return result;
			}
			set
			{
				this.PoolHelper_.CopyAssign(value);
			}
		}

		// Token: 0x1700774F RID: 30543
		// (get) Token: 0x0601D9AA RID: 121258 RVA: 0x002BB7AF File Offset: 0x002B99AF
		// (set) Token: 0x0601D9AB RID: 121259 RVA: 0x002BB7C3 File Offset: 0x002B99C3
		[Nullable(2)]
		public unsafe UKSC_WorldBounds WorldBounds
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_WorldBounds>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_WorldBounds);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_WorldBounds, value);
			}
		}

		// Token: 0x17007750 RID: 30544
		// (get) Token: 0x0601D9AC RID: 121260 RVA: 0x002BB7D8 File Offset: 0x002B99D8
		// (set) Token: 0x0601D9AD RID: 121261 RVA: 0x002BB811 File Offset: 0x002B9A11
		public TMap<UKSC_DA_Buff, int> LoadedBuffDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, int> result;
				if ((result = this._LoadedBuffDa) == null)
				{
					result = (this._LoadedBuffDa = new TMap<UKSC_DA_Buff, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedBuffDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedBuffDa.CopyAssign(value);
			}
		}

		// Token: 0x17007751 RID: 30545
		// (get) Token: 0x0601D9AE RID: 121262 RVA: 0x002BB820 File Offset: 0x002B9A20
		// (set) Token: 0x0601D9AF RID: 121263 RVA: 0x002BB859 File Offset: 0x002B9A59
		public TMap<UKSC_DA_Entity, int> LoadedEntityDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Entity, int> result;
				if ((result = this._LoadedEntityDa) == null)
				{
					result = (this._LoadedEntityDa = new TMap<UKSC_DA_Entity, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedEntityDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedEntityDa.CopyAssign(value);
			}
		}

		// Token: 0x17007752 RID: 30546
		// (get) Token: 0x0601D9B0 RID: 121264 RVA: 0x002BB868 File Offset: 0x002B9A68
		// (set) Token: 0x0601D9B1 RID: 121265 RVA: 0x002BB8A1 File Offset: 0x002B9AA1
		public TMap<UKSC_DA_Skill, int> LoadedSkillDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Skill, int> result;
				if ((result = this._LoadedSkillDa) == null)
				{
					result = (this._LoadedSkillDa = new TMap<UKSC_DA_Skill, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedSkillDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedSkillDa.CopyAssign(value);
			}
		}

		// Token: 0x17007753 RID: 30547
		// (get) Token: 0x0601D9B2 RID: 121266 RVA: 0x002BB8AF File Offset: 0x002B9AAF
		// (set) Token: 0x0601D9B3 RID: 121267 RVA: 0x002BB8C3 File Offset: 0x002B9AC3
		[Nullable(2)]
		public unsafe UKSC_DamageId DamageData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DamageId>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageData, value);
			}
		}

		// Token: 0x17007754 RID: 30548
		// (get) Token: 0x0601D9B4 RID: 121268 RVA: 0x002BB8D8 File Offset: 0x002B9AD8
		// (set) Token: 0x0601D9B5 RID: 121269 RVA: 0x002BB8EC File Offset: 0x002B9AEC
		[Nullable(2)]
		public unsafe UKSC_BuffId BuffData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_BuffId>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_BuffData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_BuffData, value);
			}
		}

		// Token: 0x17007755 RID: 30549
		// (get) Token: 0x0601D9B6 RID: 121270 RVA: 0x002BB904 File Offset: 0x002B9B04
		// (set) Token: 0x0601D9B7 RID: 121271 RVA: 0x002BB93D File Offset: 0x002B9B3D
		public TSet<int> BroadcastBuffIdSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._BroadcastBuffIdSet) == null)
				{
					result = (this._BroadcastBuffIdSet = new TSet<int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_BroadcastBuffIdSet, this));
				}
				return result;
			}
			set
			{
				this.BroadcastBuffIdSet.CopyAssign(value);
			}
		}

		// Token: 0x17007756 RID: 30550
		// (get) Token: 0x0601D9B8 RID: 121272 RVA: 0x002BB94B File Offset: 0x002B9B4B
		// (set) Token: 0x0601D9B9 RID: 121273 RVA: 0x002BB95F File Offset: 0x002B9B5F
		[Nullable(2)]
		public unsafe UKSC_SceneMovement SceneMovement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SceneMovement>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_SceneMovement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_SceneMovement, value);
			}
		}

		// Token: 0x17007757 RID: 30551
		// (get) Token: 0x0601D9BA RID: 121274 RVA: 0x002BB974 File Offset: 0x002B9B74
		// (set) Token: 0x0601D9BB RID: 121275 RVA: 0x002BB988 File Offset: 0x002B9B88
		[Nullable(2)]
		public unsafe UKuroFastCollisionAlgorithm KFCAlgorithm
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFastCollisionAlgorithm>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_KFCAlgorithm);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_KFCAlgorithm, value);
			}
		}

		// Token: 0x0601D9BC RID: 121276 RVA: 0x002BB99D File Offset: 0x002B9B9D
		public void SetWorldTimeDilation(float NewTimeDilation)
		{
			UKSC_World.__SetWorldTimeDilation_Internal(base.NativePtr, NewTimeDilation);
		}

		// Token: 0x0601D9BD RID: 121277 RVA: 0x002BB9AB File Offset: 0x002B9BAB
		[NullableContext(2)]
		public void SetWorldBounds(UKSC_DA_WorldBounds DAWorldBounds)
		{
			UKSC_World.__SetWorldBounds_Internal(base.NativePtr, (DAWorldBounds != null) ? DAWorldBounds.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9BE RID: 121278 RVA: 0x002BB9C8 File Offset: 0x002B9BC8
		public void SetWorldAttr(EKSC_WorldAttrType Type, int Value)
		{
			UKSC_World.__SetWorldAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x0601D9BF RID: 121279 RVA: 0x002BB9D7 File Offset: 0x002B9BD7
		public void SetObstacleSegments([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKSC_Segment> InObstacleSegments)
		{
			UKSC_World.__SetObstacleSegments_Internal(base.NativePtr, (InObstacleSegments ?? new TArray<FKSC_Segment>()).NativePtr);
		}

		// Token: 0x0601D9C0 RID: 121280 RVA: 0x002BB9F3 File Offset: 0x002B9BF3
		[NullableContext(2)]
		public void SetKFCAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UKSC_World.__SetKFCAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9C1 RID: 121281 RVA: 0x002BBA10 File Offset: 0x002B9C10
		[NullableContext(2)]
		public void SetHitContextTextData(UKSC_DA_HitContextText InDataAsset)
		{
			UKSC_World.__SetHitContextTextData_Internal(base.NativePtr, (InDataAsset != null) ? InDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9C2 RID: 121282 RVA: 0x002BBA2D File Offset: 0x002B9C2D
		public void SetDamageHandler([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKSC_DamageHandler> HandlerClass)
		{
			UKSC_World.__SetDamageHandler_Internal(base.NativePtr, HandlerClass._NativePtr);
		}

		// Token: 0x0601D9C3 RID: 121283 RVA: 0x002BBA40 File Offset: 0x002B9C40
		[NullableContext(2)]
		public void SetBroadcastBuffIdList(in TArray<int> InBuffIdList)
		{
			UKSC_World.__SetBroadcastBuffIdList_Internal(base.NativePtr, (InBuffIdList ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0601D9C4 RID: 121284 RVA: 0x002BBA5D File Offset: 0x002B9C5D
		[NullableContext(2)]
		public void RemoveWorldAttrListen(EKSC_WorldAttrType Id, in FDOnKSCWorldAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FDOnKSCWorldAttrChange fdonKSCWorldAttrChange = InDelegate;
			UKSC_World.__RemoveWorldAttrListen_Internal(nativePtr, Id, (fdonKSCWorldAttrChange != null) ? fdonKSCWorldAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9C5 RID: 121285 RVA: 0x002BBA7A File Offset: 0x002B9C7A
		[NullableContext(2)]
		public void RemoveEntityReason(AKSC_Entity Entity, FName Reason)
		{
			UKSC_World.__RemoveEntityReason_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero, Reason);
		}

		// Token: 0x0601D9C6 RID: 121286 RVA: 0x002BBA98 File Offset: 0x002B9C98
		[NullableContext(2)]
		public void RemoveEntity(AKSC_Entity Entity)
		{
			UKSC_World.__RemoveEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9C7 RID: 121287 RVA: 0x002BBAB5 File Offset: 0x002B9CB5
		[NullableContext(2)]
		public bool RemoveDecorator(UKSC_DA_Decorator DaDecorator)
		{
			return UKSC_World.__RemoveDecorator_Internal(base.NativePtr, (DaDecorator != null) ? DaDecorator.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9C8 RID: 121288 RVA: 0x002BBAD2 File Offset: 0x002B9CD2
		public TArray<FKSC_HitContext> PopHitInfos()
		{
			return new TArray<FKSC_HitContext>(UKSC_World.__PopHitInfos_Internal(base.NativePtr), null);
		}

		// Token: 0x0601D9C9 RID: 121289 RVA: 0x002BBAE5 File Offset: 0x002B9CE5
		public void ModifyWorldAttr(EKSC_WorldAttrType Type, int Value)
		{
			UKSC_World.__ModifyWorldAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x0601D9CA RID: 121290 RVA: 0x002BBAF4 File Offset: 0x002B9CF4
		public void InitHeadUiClassMap()
		{
			UKSC_World.__InitHeadUiClassMap_Internal(base.NativePtr);
		}

		// Token: 0x0601D9CB RID: 121291 RVA: 0x002BBB01 File Offset: 0x002B9D01
		public int GetWorldAttr(EKSC_WorldAttrType Type)
		{
			return UKSC_World.__GetWorldAttr_Internal(base.NativePtr, Type);
		}

		// Token: 0x0601D9CC RID: 121292 RVA: 0x002BBB0F File Offset: 0x002B9D0F
		public void GetHeadHpInfos([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_HeadHpContext> HpInfos)
		{
			UKSC_World.__GetHeadHpInfos_Internal(base.NativePtr, (HpInfos ?? new TArray<FKSC_HeadHpContext>()).NativePtr);
		}

		// Token: 0x0601D9CD RID: 121293 RVA: 0x002BBB2C File Offset: 0x002B9D2C
		public void GetEntityPositionsEx([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_MiniMapContext> EntityPositions)
		{
			UKSC_World.__GetEntityPositionsEx_Internal(base.NativePtr, (EntityPositions ?? new TArray<FKSC_MiniMapContext>()).NativePtr);
		}

		// Token: 0x0601D9CE RID: 121294 RVA: 0x002BBB49 File Offset: 0x002B9D49
		[NullableContext(2)]
		public AKSC_Entity GetEntityById(int EntityId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__GetEntityById_Internal(base.NativePtr, EntityId));
		}

		// Token: 0x0601D9CF RID: 121295 RVA: 0x002BBB5C File Offset: 0x002B9D5C
		[NullableContext(2)]
		public UKSC_BuffId GetBuffData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_BuffId>(UKSC_World.__GetBuffData_Internal(base.NativePtr));
		}

		// Token: 0x0601D9D0 RID: 121296 RVA: 0x002BBB6E File Offset: 0x002B9D6E
		public bool Debug_SetEntityTag(int EntityId, in FGameplayTag Attr, int TagCount)
		{
			return UKSC_World.__Debug_SetEntityTag_Internal(base.NativePtr, EntityId, Attr, TagCount);
		}

		// Token: 0x0601D9D1 RID: 121297 RVA: 0x002BBB80 File Offset: 0x002B9D80
		public unsafe bool Debug_SetEntityAttr(int EntityId, in EKSC_AttrType Attr, int Value)
		{
			fixed (EKSC_AttrType* ptr = &Attr)
			{
				void* ptr2 = (void*)ptr;
				return UKSC_World.__Debug_SetEntityAttr_Internal(base.NativePtr, EntityId, Attr, Value);
			}
		}

		// Token: 0x0601D9D2 RID: 121298 RVA: 0x002BBBA0 File Offset: 0x002B9DA0
		public bool Debug_IsEntityAlive(int EntityId)
		{
			return UKSC_World.__Debug_IsEntityAlive_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0601D9D3 RID: 121299 RVA: 0x002BBBAE File Offset: 0x002B9DAE
		[NullableContext(2)]
		public bool Debug_GetWorldAttr(ref TMap<EKSC_WorldAttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetWorldAttr_Internal(base.NativePtr, (Attr ?? new TMap<EKSC_WorldAttrType, int>()).NativeMapPtr);
		}

		// Token: 0x0601D9D4 RID: 121300 RVA: 0x002BBBCC File Offset: 0x002B9DCC
		public unsafe string Debug_GetOriginalTagName(in FName TagName)
		{
			fixed (FName* ptr = &TagName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(UKSC_World.__Debug_GetOriginalTagName_Internal(base.NativePtr, TagName));
			}
		}

		// Token: 0x0601D9D5 RID: 121301 RVA: 0x002BBBEF File Offset: 0x002B9DEF
		[NullableContext(2)]
		public bool Debug_GetEntityTags(int EntityId, ref TMap<FGameplayTag, int> Tags)
		{
			return UKSC_World.__Debug_GetEntityTags_Internal(base.NativePtr, EntityId, (Tags ?? new TMap<FGameplayTag, int>()).NativeMapPtr);
		}

		// Token: 0x0601D9D6 RID: 121302 RVA: 0x002BBC0D File Offset: 0x002B9E0D
		[NullableContext(2)]
		public bool Debug_GetEntityLockedAttr(int EntityId, ref TMap<EKSC_AttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetEntityLockedAttr_Internal(base.NativePtr, EntityId, (Attr ?? new TMap<EKSC_AttrType, int>()).NativeMapPtr);
		}

		// Token: 0x0601D9D7 RID: 121303 RVA: 0x002BBC2B File Offset: 0x002B9E2B
		public bool Debug_GetEntityBuffs(int EntityId, [Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UKSC_DA_Buff, int> Buffs)
		{
			return UKSC_World.__Debug_GetEntityBuffs_Internal(base.NativePtr, EntityId, (Buffs ?? new TMap<UKSC_DA_Buff, int>()).NativeMapPtr);
		}

		// Token: 0x0601D9D8 RID: 121304 RVA: 0x002BBC49 File Offset: 0x002B9E49
		[NullableContext(2)]
		public bool Debug_GetEntityAttr(int EntityId, ref TMap<EKSC_AttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetEntityAttr_Internal(base.NativePtr, EntityId, (Attr ?? new TMap<EKSC_AttrType, int>()).NativeMapPtr);
		}

		// Token: 0x0601D9D9 RID: 121305 RVA: 0x002BBC68 File Offset: 0x002B9E68
		[NullableContext(2)]
		public unsafe AKSC_Entity D_AddDaEntity(UKSC_DA_Entity DaEntity, in FTransformDouble Transform, bool InIsPreview = false, int CreatureId = 0)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__D_AddDaEntity_Internal(base.NativePtr, (DaEntity != null) ? DaEntity.NativePtr : IntPtr.Zero, ptr, InIsPreview, CreatureId));
		}

		// Token: 0x0601D9DA RID: 121306 RVA: 0x002BBCB5 File Offset: 0x002B9EB5
		public void ClearDecorator()
		{
			UKSC_World.__ClearDecorator_Internal(base.NativePtr);
		}

		// Token: 0x0601D9DB RID: 121307 RVA: 0x002BBCC2 File Offset: 0x002B9EC2
		[NullableContext(2)]
		public void AssignWorldAttrListen(EKSC_WorldAttrType Id, in FDOnKSCWorldAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FDOnKSCWorldAttrChange fdonKSCWorldAttrChange = InDelegate;
			UKSC_World.__AssignWorldAttrListen_Internal(nativePtr, Id, (fdonKSCWorldAttrChange != null) ? fdonKSCWorldAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9DC RID: 121308 RVA: 0x002BBCDF File Offset: 0x002B9EDF
		[NullableContext(2)]
		public void AssignLandFireSpawnDelegate(in FOnKSCLandFireSpawn InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCLandFireSpawn fonKSCLandFireSpawn = InDelegate;
			UKSC_World.__AssignLandFireSpawnDelegate_Internal(nativePtr, (fonKSCLandFireSpawn != null) ? fonKSCLandFireSpawn.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9DD RID: 121309 RVA: 0x002BBCFB File Offset: 0x002B9EFB
		[NullableContext(2)]
		public void AssignKSCEntitySummon(in FOnKSCEntitySummon InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCEntitySummon fonKSCEntitySummon = InDelegate;
			UKSC_World.__AssignKSCEntitySummon_Internal(nativePtr, (fonKSCEntitySummon != null) ? fonKSCEntitySummon.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9DE RID: 121310 RVA: 0x002BBD17 File Offset: 0x002B9F17
		[NullableContext(2)]
		public void AssignKSCEntitySpawn(in FOnKSCEntitySpawn InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCEntitySpawn fonKSCEntitySpawn = InDelegate;
			UKSC_World.__AssignKSCEntitySpawn_Internal(nativePtr, (fonKSCEntitySpawn != null) ? fonKSCEntitySpawn.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9DF RID: 121311 RVA: 0x002BBD33 File Offset: 0x002B9F33
		[NullableContext(2)]
		public void AssignBatchRemoveDelegate(in FOnKSCBatchRemoveAfter InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCBatchRemoveAfter fonKSCBatchRemoveAfter = InDelegate;
			UKSC_World.__AssignBatchRemoveDelegate_Internal(nativePtr, (fonKSCBatchRemoveAfter != null) ? fonKSCBatchRemoveAfter.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D9E0 RID: 121312 RVA: 0x002BBD4F File Offset: 0x002B9F4F
		public void AddHitContextText(EHitContextTextType TextType, FVector Location, int EntityId)
		{
			UKSC_World.__AddHitContextText_Internal(base.NativePtr, TextType, Location, EntityId);
		}

		// Token: 0x0601D9E1 RID: 121313 RVA: 0x002BBD5F File Offset: 0x002B9F5F
		public bool AddHeadUI([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AKSC_GPUHeadUI> InHeadUIClass)
		{
			return UKSC_World.__AddHeadUI_Internal(base.NativePtr, InHeadUIClass._NativePtr);
		}

		// Token: 0x0601D9E2 RID: 121314 RVA: 0x002BBD72 File Offset: 0x002B9F72
		[NullableContext(2)]
		public bool AddDecorator(UKSC_DA_Decorator DaDecorator)
		{
			return UKSC_World.__AddDecorator_Internal(base.NativePtr, (DaDecorator != null) ? DaDecorator.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D9E3 RID: 121315 RVA: 0x002BBD90 File Offset: 0x002B9F90
		[NullableContext(2)]
		public unsafe AKSC_Entity AddDaEntity(UKSC_DA_Entity DaEntity, in FTransform Transform, bool IsPreview = false, int CreatureId = 0)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__AddDaEntity_Internal(base.NativePtr, (DaEntity != null) ? DaEntity.NativePtr : IntPtr.Zero, ptr, IsPreview, CreatureId));
		}

		// Token: 0x0601D9E4 RID: 121316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldTimeDilation_Internal(IntPtr @this, float NewTimeDilation);

		// Token: 0x0601D9E5 RID: 121317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldBounds_Internal(IntPtr @this, IntPtr DAWorldBounds);

		// Token: 0x0601D9E6 RID: 121318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type, int Value);

		// Token: 0x0601D9E7 RID: 121319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObstacleSegments_Internal(IntPtr @this, IntPtr InObstacleSegments);

		// Token: 0x0601D9E8 RID: 121320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKFCAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x0601D9E9 RID: 121321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHitContextTextData_Internal(IntPtr @this, IntPtr InDataAsset);

		// Token: 0x0601D9EA RID: 121322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDamageHandler_Internal(IntPtr @this, IntPtr HandlerClass);

		// Token: 0x0601D9EB RID: 121323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBroadcastBuffIdList_Internal(IntPtr @this, IntPtr InBuffIdList);

		// Token: 0x0601D9EC RID: 121324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveWorldAttrListen_Internal(IntPtr @this, EKSC_WorldAttrType Id, IntPtr InDelegate);

		// Token: 0x0601D9ED RID: 121325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEntityReason_Internal(IntPtr @this, IntPtr Entity, FName Reason);

		// Token: 0x0601D9EE RID: 121326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x0601D9EF RID: 121327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveDecorator_Internal(IntPtr @this, IntPtr DaDecorator);

		// Token: 0x0601D9F0 RID: 121328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PopHitInfos_Internal(IntPtr @this);

		// Token: 0x0601D9F1 RID: 121329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ModifyWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type, int Value);

		// Token: 0x0601D9F2 RID: 121330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitHeadUiClassMap_Internal(IntPtr @this);

		// Token: 0x0601D9F3 RID: 121331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type);

		// Token: 0x0601D9F4 RID: 121332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetHeadHpInfos_Internal(IntPtr @this, IntPtr HpInfos);

		// Token: 0x0601D9F5 RID: 121333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetEntityPositionsEx_Internal(IntPtr @this, IntPtr EntityPositions);

		// Token: 0x0601D9F6 RID: 121334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEntityById_Internal(IntPtr @this, int EntityId);

		// Token: 0x0601D9F7 RID: 121335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBuffData_Internal(IntPtr @this);

		// Token: 0x0601D9F8 RID: 121336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_SetEntityTag_Internal(IntPtr @this, int EntityId, in FGameplayTag Attr, int TagCount);

		// Token: 0x0601D9F9 RID: 121337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_SetEntityAttr_Internal(IntPtr @this, int EntityId, in EKSC_AttrType Attr, int Value);

		// Token: 0x0601D9FA RID: 121338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_IsEntityAlive_Internal(IntPtr @this, int EntityId);

		// Token: 0x0601D9FB RID: 121339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetWorldAttr_Internal(IntPtr @this, IntPtr Attr);

		// Token: 0x0601D9FC RID: 121340
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Debug_GetOriginalTagName_Internal(IntPtr @this, in FName TagName);

		// Token: 0x0601D9FD RID: 121341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityTags_Internal(IntPtr @this, int EntityId, IntPtr Tags);

		// Token: 0x0601D9FE RID: 121342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityLockedAttr_Internal(IntPtr @this, int EntityId, IntPtr Attr);

		// Token: 0x0601D9FF RID: 121343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityBuffs_Internal(IntPtr @this, int EntityId, IntPtr Buffs);

		// Token: 0x0601DA00 RID: 121344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityAttr_Internal(IntPtr @this, int EntityId, IntPtr Attr);

		// Token: 0x0601DA01 RID: 121345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_AddDaEntity_Internal(IntPtr @this, IntPtr DaEntity, in FTransformDouble Transform, bool InIsPreview, int CreatureId);

		// Token: 0x0601DA02 RID: 121346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDecorator_Internal(IntPtr @this);

		// Token: 0x0601DA03 RID: 121347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignWorldAttrListen_Internal(IntPtr @this, EKSC_WorldAttrType Id, IntPtr InDelegate);

		// Token: 0x0601DA04 RID: 121348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignLandFireSpawnDelegate_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601DA05 RID: 121349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignKSCEntitySummon_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601DA06 RID: 121350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignKSCEntitySpawn_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601DA07 RID: 121351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignBatchRemoveDelegate_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601DA08 RID: 121352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddHitContextText_Internal(IntPtr @this, EHitContextTextType TextType, FVector Location, int EntityId);

		// Token: 0x0601DA09 RID: 121353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddHeadUI_Internal(IntPtr @this, IntPtr InHeadUIClass);

		// Token: 0x0601DA0A RID: 121354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddDecorator_Internal(IntPtr @this, IntPtr DaDecorator);

		// Token: 0x0601DA0B RID: 121355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddDaEntity_Internal(IntPtr @this, IntPtr DaEntity, in FTransform Transform, bool IsPreview, int CreatureId);

		// Token: 0x0601DA0C RID: 121356 RVA: 0x002BBDDD File Offset: 0x002B9FDD
		static UKSC_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_World");
		}

		// Token: 0x0601DA0D RID: 121357 RVA: 0x002BBDEB File Offset: 0x002B9FEB
		protected UKSC_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100AB RID: 65707
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_World";

		// Token: 0x040100AC RID: 65708
		private static IntPtr _ClassPtr;

		// Token: 0x040100AD RID: 65709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100AE RID: 65710
		internal static int __PropertyOffset_SceneComps_;

		// Token: 0x040100AF RID: 65711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SceneComp> _SceneComps_;

		// Token: 0x040100B0 RID: 65712
		internal static int __PropertyOffset_Entities_;

		// Token: 0x040100B1 RID: 65713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _Entities_;

		// Token: 0x040100B2 RID: 65714
		internal static int __PropertyOffset_EntityIdMap;

		// Token: 0x040100B3 RID: 65715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, AKSC_Entity> _EntityIdMap;

		// Token: 0x040100B4 RID: 65716
		internal static int __PropertyOffset_DeadEntities_;

		// Token: 0x040100B5 RID: 65717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _DeadEntities_;

		// Token: 0x040100B6 RID: 65718
		internal static int __PropertyOffset_ShowHeadUIEntities_;

		// Token: 0x040100B7 RID: 65719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ShowHeadUIEntities_;

		// Token: 0x040100B8 RID: 65720
		internal static int __PropertyOffset_ToRemoveEntities_;

		// Token: 0x040100B9 RID: 65721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ToRemoveEntities_;

		// Token: 0x040100BA RID: 65722
		internal static int __PropertyOffset_ToAddEntities_;

		// Token: 0x040100BB RID: 65723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ToAddEntities_;

		// Token: 0x040100BC RID: 65724
		internal static int __PropertyOffset_ToAddLandFire_;

		// Token: 0x040100BD RID: 65725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_LandFireContext> _ToAddLandFire_;

		// Token: 0x040100BE RID: 65726
		internal static int __PropertyOffset_RenderActorMap_;

		// Token: 0x040100BF RID: 65727
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AKSC_Entity, AActor> _RenderActorMap_;

		// Token: 0x040100C0 RID: 65728
		internal static int __PropertyOffset_SharedRenderActorDaMap_;

		// Token: 0x040100C1 RID: 65729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_EntityRender, AActor> _SharedRenderActorDaMap_;

		// Token: 0x040100C2 RID: 65730
		internal static int __PropertyOffset_GPUHeadUI;

		// Token: 0x040100C3 RID: 65731
		internal static int __PropertyOffset_HitContextTextHandle;

		// Token: 0x040100C4 RID: 65732
		internal static int __PropertyOffset_AttributeIdsWithMax;

		// Token: 0x040100C5 RID: 65733
		[Nullable(2)]
		private TMap<EKSC_AttrType, EKSC_AttrType> _AttributeIdsWithMax;

		// Token: 0x040100C6 RID: 65734
		internal static int __PropertyOffset_AttributeEffectiveDamageType;

		// Token: 0x040100C7 RID: 65735
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttributeEffectiveDamageType;

		// Token: 0x040100C8 RID: 65736
		internal static int __PropertyOffset_OnKSCBatchRemoveAfter;

		// Token: 0x040100C9 RID: 65737
		[Nullable(2)]
		private FOnKSCBatchRemoveAfter _OnKSCBatchRemoveAfter;

		// Token: 0x040100CA RID: 65738
		internal static int __PropertyOffset_OnKSCLandFireSpawn;

		// Token: 0x040100CB RID: 65739
		[Nullable(2)]
		private FOnKSCLandFireSpawn _OnKSCLandFireSpawn;

		// Token: 0x040100CC RID: 65740
		internal static int __PropertyOffset_OnKSCEntitySpawn;

		// Token: 0x040100CD RID: 65741
		[Nullable(2)]
		private FOnKSCEntitySpawn _OnKSCEntitySpawn;

		// Token: 0x040100CE RID: 65742
		internal static int __PropertyOffset_OnKSCEntitySummon;

		// Token: 0x040100CF RID: 65743
		[Nullable(2)]
		private FOnKSCEntitySummon _OnKSCEntitySummon;

		// Token: 0x040100D0 RID: 65744
		internal static int __PropertyOffset_Decorators;

		// Token: 0x040100D1 RID: 65745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Decorator> _Decorators;

		// Token: 0x040100D2 RID: 65746
		internal static int __PropertyOffset_HeadUiHandleClassMap;

		// Token: 0x040100D3 RID: 65747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_HeadUiType, UClass> _HeadUiHandleClassMap;

		// Token: 0x040100D4 RID: 65748
		internal static int __PropertyOffset_DamageHandler;

		// Token: 0x040100D5 RID: 65749
		internal static int __PropertyOffset_PoolHelper_;

		// Token: 0x040100D6 RID: 65750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _PoolHelper_;

		// Token: 0x040100D7 RID: 65751
		internal static int __PropertyOffset_WorldBounds;

		// Token: 0x040100D8 RID: 65752
		internal static int __PropertyOffset_LoadedBuffDa;

		// Token: 0x040100D9 RID: 65753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Buff, int> _LoadedBuffDa;

		// Token: 0x040100DA RID: 65754
		internal static int __PropertyOffset_LoadedEntityDa;

		// Token: 0x040100DB RID: 65755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Entity, int> _LoadedEntityDa;

		// Token: 0x040100DC RID: 65756
		internal static int __PropertyOffset_LoadedSkillDa;

		// Token: 0x040100DD RID: 65757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Skill, int> _LoadedSkillDa;

		// Token: 0x040100DE RID: 65758
		internal static int __PropertyOffset_DamageData;

		// Token: 0x040100DF RID: 65759
		internal static int __PropertyOffset_BuffData;

		// Token: 0x040100E0 RID: 65760
		internal static int __PropertyOffset_BroadcastBuffIdSet;

		// Token: 0x040100E1 RID: 65761
		[Nullable(2)]
		private TSet<int> _BroadcastBuffIdSet;

		// Token: 0x040100E2 RID: 65762
		internal static int __PropertyOffset_SceneMovement;

		// Token: 0x040100E3 RID: 65763
		internal static int __PropertyOffset_KFCAlgorithm;
	}
}
