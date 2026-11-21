using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056A RID: 1386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E28 RID: 32296 RVA: 0x000BAFC9 File Offset: 0x000B91C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity._ClassPtr;
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x000BAFD8 File Offset: 0x000B91D8
		public UKSC_DA_Entity() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x000BB000 File Offset: 0x000B9200
		public UKSC_DA_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x000BB033 File Offset: 0x000B9233
		// (set) Token: 0x06007E2C RID: 32300 RVA: 0x000BB047 File Offset: 0x000B9247
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

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06007E2D RID: 32301 RVA: 0x000BB05C File Offset: 0x000B925C
		// (set) Token: 0x06007E2E RID: 32302 RVA: 0x000BB070 File Offset: 0x000B9270
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

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06007E2F RID: 32303 RVA: 0x000BB085 File Offset: 0x000B9285
		// (set) Token: 0x06007E30 RID: 32304 RVA: 0x000BB095 File Offset: 0x000B9295
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

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06007E31 RID: 32305 RVA: 0x000BB0A8 File Offset: 0x000B92A8
		// (set) Token: 0x06007E32 RID: 32306 RVA: 0x000BB0E1 File Offset: 0x000B92E1
		public TArray<EKSC_Faction> Default_IgnoreFactions
		{
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
			set
			{
				this.Default_IgnoreFactions.CopyAssign(value);
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06007E33 RID: 32307 RVA: 0x000BB0EF File Offset: 0x000B92EF
		// (set) Token: 0x06007E34 RID: 32308 RVA: 0x000BB103 File Offset: 0x000B9303
		[Nullable(2)]
		public unsafe UKSC_DA_SceneComp SceneComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SceneComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SceneComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Entity.__PropertyOffset_SceneComp, value);
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06007E35 RID: 32309 RVA: 0x000BB118 File Offset: 0x000B9318
		// (set) Token: 0x06007E36 RID: 32310 RVA: 0x000BB128 File Offset: 0x000B9328
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

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06007E37 RID: 32311 RVA: 0x000BB139 File Offset: 0x000B9339
		// (set) Token: 0x06007E38 RID: 32312 RVA: 0x000BB149 File Offset: 0x000B9349
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

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x000BB15A File Offset: 0x000B935A
		// (set) Token: 0x06007E3A RID: 32314 RVA: 0x000BB16F File Offset: 0x000B936F
		public TSoftObjectPtr<UEffectModelBase> AppearWarningFX
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKSC_DA_Entity.__PropertyOffset_AppearWarningFX, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x000BB194 File Offset: 0x000B9394
		// (set) Token: 0x06007E3C RID: 32316 RVA: 0x000BB1A8 File Offset: 0x000B93A8
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

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x000BB1BD File Offset: 0x000B93BD
		// (set) Token: 0x06007E3E RID: 32318 RVA: 0x000BB1CD File Offset: 0x000B93CD
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

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06007E3F RID: 32319 RVA: 0x000BB1DE File Offset: 0x000B93DE
		// (set) Token: 0x06007E40 RID: 32320 RVA: 0x000BB1EE File Offset: 0x000B93EE
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

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06007E41 RID: 32321 RVA: 0x000BB1FF File Offset: 0x000B93FF
		// (set) Token: 0x06007E42 RID: 32322 RVA: 0x000BB213 File Offset: 0x000B9413
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

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x000BB228 File Offset: 0x000B9428
		// (set) Token: 0x06007E44 RID: 32324 RVA: 0x000BB238 File Offset: 0x000B9438
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

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x000BB249 File Offset: 0x000B9449
		// (set) Token: 0x06007E46 RID: 32326 RVA: 0x000BB259 File Offset: 0x000B9459
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x000BB26A File Offset: 0x000B946A
		// (set) Token: 0x06007E48 RID: 32328 RVA: 0x000BB27E File Offset: 0x000B947E
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

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x000BB293 File Offset: 0x000B9493
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x000BB2A3 File Offset: 0x000B94A3
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

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x000BB2B4 File Offset: 0x000B94B4
		// (set) Token: 0x06007E4C RID: 32332 RVA: 0x000BB2ED File Offset: 0x000B94ED
		public TMap<FName, FTransform> SocketTransform
		{
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
			set
			{
				this.SocketTransform.CopyAssign(value);
			}
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x000BB2FB File Offset: 0x000B94FB
		static UKSC_DA_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity");
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x000BB309 File Offset: 0x000B9509
		protected UKSC_DA_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003706 RID: 14086
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity";

		// Token: 0x04003707 RID: 14087
		private static IntPtr _ClassPtr;

		// Token: 0x04003708 RID: 14088
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003709 RID: 14089
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400370A RID: 14090
		internal static int __PropertyOffset_EntityClass;

		// Token: 0x0400370B RID: 14091
		internal static int __PropertyOffset_Default_Faction;

		// Token: 0x0400370C RID: 14092
		internal static int __PropertyOffset_Default_IgnoreFactions;

		// Token: 0x0400370D RID: 14093
		[Nullable(2)]
		private TArray<EKSC_Faction> _Default_IgnoreFactions;

		// Token: 0x0400370E RID: 14094
		internal static int __PropertyOffset_SceneComp;

		// Token: 0x0400370F RID: 14095
		internal static int __PropertyOffset_RemoveDelay;

		// Token: 0x04003710 RID: 14096
		internal static int __PropertyOffset_AppearDelay;

		// Token: 0x04003711 RID: 14097
		internal static int __PropertyOffset_AppearWarningFX;

		// Token: 0x04003712 RID: 14098
		internal static int __PropertyOffset_AppearWarningFX_Offset;

		// Token: 0x04003713 RID: 14099
		internal static int __PropertyOffset_EnableHeadUI;

		// Token: 0x04003714 RID: 14100
		internal static int __PropertyOffset_HeadUiType;

		// Token: 0x04003715 RID: 14101
		internal static int __PropertyOffset_HeadUiOffset;

		// Token: 0x04003716 RID: 14102
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x04003717 RID: 14103
		internal static int __PropertyOffset_EnemyUIType;

		// Token: 0x04003718 RID: 14104
		internal static int __PropertyOffset_EntityTypeName;

		// Token: 0x04003719 RID: 14105
		internal static int __PropertyOffset_EntityType;

		// Token: 0x0400371A RID: 14106
		internal static int __PropertyOffset_SocketTransform;

		// Token: 0x0400371B RID: 14107
		[Nullable(2)]
		private TMap<FName, FTransform> _SocketTransform;
	}
}
