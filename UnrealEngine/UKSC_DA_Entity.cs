using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8D RID: 7565
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF49 RID: 118601 RVA: 0x002ACCAF File Offset: 0x002AAEAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity._ClassPtr;
		}

		// Token: 0x0601CF4A RID: 118602 RVA: 0x002ACCBC File Offset: 0x002AAEBC
		public UKSC_DA_Entity() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF4B RID: 118603 RVA: 0x002ACCE4 File Offset: 0x002AAEE4
		[NullableContext(1)]
		public UKSC_DA_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074C9 RID: 29897
		// (get) Token: 0x0601CF4C RID: 118604 RVA: 0x002ACD17 File Offset: 0x002AAF17
		// (set) Token: 0x0601CF4D RID: 118605 RVA: 0x002ACD2B File Offset: 0x002AAF2B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AKSC_Entity> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x170074CA RID: 29898
		// (get) Token: 0x0601CF4E RID: 118606 RVA: 0x002ACD40 File Offset: 0x002AAF40
		// (set) Token: 0x0601CF4F RID: 118607 RVA: 0x002ACD54 File Offset: 0x002AAF54
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> EntityClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityClass) = value;
			}
		}

		// Token: 0x170074CB RID: 29899
		// (get) Token: 0x0601CF50 RID: 118608 RVA: 0x002ACD69 File Offset: 0x002AAF69
		// (set) Token: 0x0601CF51 RID: 118609 RVA: 0x002ACD79 File Offset: 0x002AAF79
		public unsafe EKSC_Faction Default_Faction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_Default_Faction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_Default_Faction) = (byte)value;
			}
		}

		// Token: 0x170074CC RID: 29900
		// (get) Token: 0x0601CF52 RID: 118610 RVA: 0x002ACD8C File Offset: 0x002AAF8C
		// (set) Token: 0x0601CF53 RID: 118611 RVA: 0x002ACDC5 File Offset: 0x002AAFC5
		[Nullable(1)]
		public TArray<EKSC_Faction> Default_IgnoreFactions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._Default_IgnoreFactions) == null)
				{
					result = (this._Default_IgnoreFactions = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_Default_IgnoreFactions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Default_IgnoreFactions.CopyAssign(value);
			}
		}

		// Token: 0x170074CD RID: 29901
		// (get) Token: 0x0601CF54 RID: 118612 RVA: 0x002ACDD3 File Offset: 0x002AAFD3
		// (set) Token: 0x0601CF55 RID: 118613 RVA: 0x002ACDE7 File Offset: 0x002AAFE7
		public unsafe UKSC_DA_SceneComp SceneComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SceneComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SceneComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SceneComp, value);
			}
		}

		// Token: 0x170074CE RID: 29902
		// (get) Token: 0x0601CF56 RID: 118614 RVA: 0x002ACDFC File Offset: 0x002AAFFC
		// (set) Token: 0x0601CF57 RID: 118615 RVA: 0x002ACE10 File Offset: 0x002AB010
		public unsafe UKSC_DA_SkillComp SkillComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SkillComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SkillComp, value);
			}
		}

		// Token: 0x170074CF RID: 29903
		// (get) Token: 0x0601CF58 RID: 118616 RVA: 0x002ACE25 File Offset: 0x002AB025
		// (set) Token: 0x0601CF59 RID: 118617 RVA: 0x002ACE39 File Offset: 0x002AB039
		public unsafe UKSC_DA_EntityRender Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_EntityRender>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Render);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Render, value);
			}
		}

		// Token: 0x170074D0 RID: 29904
		// (get) Token: 0x0601CF5A RID: 118618 RVA: 0x002ACE4E File Offset: 0x002AB04E
		// (set) Token: 0x0601CF5B RID: 118619 RVA: 0x002ACE62 File Offset: 0x002AB062
		public unsafe UKSC_DA_Move Move
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Move>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Move);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Move, value);
			}
		}

		// Token: 0x170074D1 RID: 29905
		// (get) Token: 0x0601CF5C RID: 118620 RVA: 0x002ACE77 File Offset: 0x002AB077
		// (set) Token: 0x0601CF5D RID: 118621 RVA: 0x002ACE8B File Offset: 0x002AB08B
		public unsafe UKSC_DA_Anim Anim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Anim>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Anim);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_Anim, value);
			}
		}

		// Token: 0x170074D2 RID: 29906
		// (get) Token: 0x0601CF5E RID: 118622 RVA: 0x002ACEA0 File Offset: 0x002AB0A0
		// (set) Token: 0x0601CF5F RID: 118623 RVA: 0x002ACEB0 File Offset: 0x002AB0B0
		public unsafe float RemoveDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_RemoveDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_RemoveDelay) = value;
			}
		}

		// Token: 0x170074D3 RID: 29907
		// (get) Token: 0x0601CF60 RID: 118624 RVA: 0x002ACEC1 File Offset: 0x002AB0C1
		// (set) Token: 0x0601CF61 RID: 118625 RVA: 0x002ACED1 File Offset: 0x002AB0D1
		public unsafe float AppearDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearDelay) = value;
			}
		}

		// Token: 0x170074D4 RID: 29908
		// (get) Token: 0x0601CF62 RID: 118626 RVA: 0x002ACEE2 File Offset: 0x002AB0E2
		// (set) Token: 0x0601CF63 RID: 118627 RVA: 0x002ACEF7 File Offset: 0x002AB0F7
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> AppearWarningFX
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170074D5 RID: 29909
		// (get) Token: 0x0601CF64 RID: 118628 RVA: 0x002ACF1C File Offset: 0x002AB11C
		// (set) Token: 0x0601CF65 RID: 118629 RVA: 0x002ACF30 File Offset: 0x002AB130
		public unsafe FTransformDouble AppearWarningFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX_Offset) = value;
			}
		}

		// Token: 0x170074D6 RID: 29910
		// (get) Token: 0x0601CF66 RID: 118630 RVA: 0x002ACF45 File Offset: 0x002AB145
		// (set) Token: 0x0601CF67 RID: 118631 RVA: 0x002ACF55 File Offset: 0x002AB155
		public unsafe bool EnableHeadUI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EnableHeadUI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EnableHeadUI) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074D7 RID: 29911
		// (get) Token: 0x0601CF68 RID: 118632 RVA: 0x002ACF66 File Offset: 0x002AB166
		// (set) Token: 0x0601CF69 RID: 118633 RVA: 0x002ACF76 File Offset: 0x002AB176
		public unsafe EKSC_HeadUiType HeadUiType
		{
			get
			{
				return (EKSC_HeadUiType)(*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HeadUiType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HeadUiType) = (byte)value;
			}
		}

		// Token: 0x170074D8 RID: 29912
		// (get) Token: 0x0601CF6A RID: 118634 RVA: 0x002ACF87 File Offset: 0x002AB187
		// (set) Token: 0x0601CF6B RID: 118635 RVA: 0x002ACF9B File Offset: 0x002AB19B
		public unsafe FVector HeadUiOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HeadUiOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HeadUiOffset) = value;
			}
		}

		// Token: 0x170074D9 RID: 29913
		// (get) Token: 0x0601CF6C RID: 118636 RVA: 0x002ACFB0 File Offset: 0x002AB1B0
		// (set) Token: 0x0601CF6D RID: 118637 RVA: 0x002ACFC0 File Offset: 0x002AB1C0
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x170074DA RID: 29914
		// (get) Token: 0x0601CF6E RID: 118638 RVA: 0x002ACFD1 File Offset: 0x002AB1D1
		// (set) Token: 0x0601CF6F RID: 118639 RVA: 0x002ACFE1 File Offset: 0x002AB1E1
		public unsafe int EnemyUIType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EnemyUIType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EnemyUIType) = value;
			}
		}

		// Token: 0x170074DB RID: 29915
		// (get) Token: 0x0601CF70 RID: 118640 RVA: 0x002ACFF2 File Offset: 0x002AB1F2
		// (set) Token: 0x0601CF71 RID: 118641 RVA: 0x002AD006 File Offset: 0x002AB206
		public unsafe FName EntityTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityTypeName) = value;
			}
		}

		// Token: 0x170074DC RID: 29916
		// (get) Token: 0x0601CF72 RID: 118642 RVA: 0x002AD01B File Offset: 0x002AB21B
		// (set) Token: 0x0601CF73 RID: 118643 RVA: 0x002AD02B File Offset: 0x002AB22B
		public unsafe EKSC_EntityType EntityType
		{
			get
			{
				return (EKSC_EntityType)(*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_EntityType) = (byte)value;
			}
		}

		// Token: 0x170074DD RID: 29917
		// (get) Token: 0x0601CF74 RID: 118644 RVA: 0x002AD03C File Offset: 0x002AB23C
		// (set) Token: 0x0601CF75 RID: 118645 RVA: 0x002AD075 File Offset: 0x002AB275
		[Nullable(1)]
		public TMap<FName, FTransform> SocketTransform
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._SocketTransform) == null)
				{
					result = (this._SocketTransform = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_SocketTransform, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SocketTransform.CopyAssign(value);
			}
		}

		// Token: 0x0601CF76 RID: 118646 RVA: 0x002AD083 File Offset: 0x002AB283
		static UKSC_DA_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity");
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x002AD091 File Offset: 0x002AB291
		protected UKSC_DA_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB70 RID: 64368
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity";

		// Token: 0x0400FB71 RID: 64369
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB72 RID: 64370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB73 RID: 64371
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FB74 RID: 64372
		internal static int __PropertyOffset_EntityClass;

		// Token: 0x0400FB75 RID: 64373
		internal static int __PropertyOffset_Default_Faction;

		// Token: 0x0400FB76 RID: 64374
		internal static int __PropertyOffset_Default_IgnoreFactions;

		// Token: 0x0400FB77 RID: 64375
		private TArray<EKSC_Faction> _Default_IgnoreFactions;

		// Token: 0x0400FB78 RID: 64376
		internal static int __PropertyOffset_SceneComp;

		// Token: 0x0400FB79 RID: 64377
		internal static int __PropertyOffset_SkillComp;

		// Token: 0x0400FB7A RID: 64378
		internal static int __PropertyOffset_Render;

		// Token: 0x0400FB7B RID: 64379
		internal static int __PropertyOffset_Move;

		// Token: 0x0400FB7C RID: 64380
		internal static int __PropertyOffset_Anim;

		// Token: 0x0400FB7D RID: 64381
		internal static int __PropertyOffset_RemoveDelay;

		// Token: 0x0400FB7E RID: 64382
		internal static int __PropertyOffset_AppearDelay;

		// Token: 0x0400FB7F RID: 64383
		internal static int __PropertyOffset_AppearWarningFX;

		// Token: 0x0400FB80 RID: 64384
		internal static int __PropertyOffset_AppearWarningFX_Offset;

		// Token: 0x0400FB81 RID: 64385
		internal static int __PropertyOffset_EnableHeadUI;

		// Token: 0x0400FB82 RID: 64386
		internal static int __PropertyOffset_HeadUiType;

		// Token: 0x0400FB83 RID: 64387
		internal static int __PropertyOffset_HeadUiOffset;

		// Token: 0x0400FB84 RID: 64388
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400FB85 RID: 64389
		internal static int __PropertyOffset_EnemyUIType;

		// Token: 0x0400FB86 RID: 64390
		internal static int __PropertyOffset_EntityTypeName;

		// Token: 0x0400FB87 RID: 64391
		internal static int __PropertyOffset_EntityType;

		// Token: 0x0400FB88 RID: 64392
		internal static int __PropertyOffset_SocketTransform;

		// Token: 0x0400FB89 RID: 64393
		private TMap<FName, FTransform> _SocketTransform;
	}
}
