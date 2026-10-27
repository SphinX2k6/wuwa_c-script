using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200264F RID: 9807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.ActorComponentPrefabData")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UActorComponentPrefabData : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024709 RID: 149257 RVA: 0x0035F0C0 File Offset: 0x0035D2C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorComponentPrefabData._ClassPtr;
		}

		// Token: 0x0602470A RID: 149258 RVA: 0x0035F0CC File Offset: 0x0035D2CC
		public UActorComponentPrefabData() : this(BuiltinUtils.AllocNativeUObject(UActorComponentPrefabData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602470B RID: 149259 RVA: 0x0035F0F4 File Offset: 0x0035D2F4
		public UActorComponentPrefabData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorComponentPrefabData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C6E RID: 35950
		// (get) Token: 0x0602470C RID: 149260 RVA: 0x0035F127 File Offset: 0x0035D327
		// (set) Token: 0x0602470D RID: 149261 RVA: 0x0035F13B File Offset: 0x0035D33B
		public unsafe FGuid PrefabInstanceGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_PrefabInstanceGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_PrefabInstanceGuid) = value;
			}
		}

		// Token: 0x17008C6F RID: 35951
		// (get) Token: 0x0602470E RID: 149262 RVA: 0x0035F150 File Offset: 0x0035D350
		// (set) Token: 0x0602470F RID: 149263 RVA: 0x0035F164 File Offset: 0x0035D364
		public unsafe FGuid SourcePrefabGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourcePrefabGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourcePrefabGuid) = value;
			}
		}

		// Token: 0x17008C70 RID: 35952
		// (get) Token: 0x06024710 RID: 149264 RVA: 0x0035F179 File Offset: 0x0035D379
		// (set) Token: 0x06024711 RID: 149265 RVA: 0x0035F189 File Offset: 0x0035D389
		public unsafe int SourceComponentFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourceComponentFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourceComponentFileID) = value;
			}
		}

		// Token: 0x17008C71 RID: 35953
		// (get) Token: 0x06024712 RID: 149266 RVA: 0x0035F19A File Offset: 0x0035D39A
		// (set) Token: 0x06024713 RID: 149267 RVA: 0x0035F1AA File Offset: 0x0035D3AA
		public unsafe int SourceActorFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourceActorFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_SourceActorFileID) = value;
			}
		}

		// Token: 0x17008C72 RID: 35954
		// (get) Token: 0x06024714 RID: 149268 RVA: 0x0035F1BB File Offset: 0x0035D3BB
		// (set) Token: 0x06024715 RID: 149269 RVA: 0x0035F1CF File Offset: 0x0035D3CF
		public unsafe FGuid OuterPrefabGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabGuid) = value;
			}
		}

		// Token: 0x17008C73 RID: 35955
		// (get) Token: 0x06024716 RID: 149270 RVA: 0x0035F1E4 File Offset: 0x0035D3E4
		// (set) Token: 0x06024717 RID: 149271 RVA: 0x0035F1F4 File Offset: 0x0035D3F4
		public unsafe int OuterPrefabInstanceFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabInstanceFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabInstanceFileID) = value;
			}
		}

		// Token: 0x17008C74 RID: 35956
		// (get) Token: 0x06024718 RID: 149272 RVA: 0x0035F205 File Offset: 0x0035D405
		// (set) Token: 0x06024719 RID: 149273 RVA: 0x0035F219 File Offset: 0x0035D419
		public unsafe FGuid OuterPrefabInstanceGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabInstanceGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabInstanceGuid) = value;
			}
		}

		// Token: 0x17008C75 RID: 35957
		// (get) Token: 0x0602471A RID: 149274 RVA: 0x0035F230 File Offset: 0x0035D430
		// (set) Token: 0x0602471B RID: 149275 RVA: 0x0035F269 File Offset: 0x0035D469
		public TMap<FGuid, int> WithinOuterPrefabActorFileIDMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, int> result;
				if ((result = this._WithinOuterPrefabActorFileIDMap) == null)
				{
					result = (this._WithinOuterPrefabActorFileIDMap = new TMap<FGuid, int>(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_WithinOuterPrefabActorFileIDMap, this));
				}
				return result;
			}
			set
			{
				this.WithinOuterPrefabActorFileIDMap.CopyAssign(value);
			}
		}

		// Token: 0x17008C76 RID: 35958
		// (get) Token: 0x0602471C RID: 149276 RVA: 0x0035F278 File Offset: 0x0035D478
		// (set) Token: 0x0602471D RID: 149277 RVA: 0x0035F2B1 File Offset: 0x0035D4B1
		public TMap<FGuid, int> WithinOuterPrefabComponentFileIDMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, int> result;
				if ((result = this._WithinOuterPrefabComponentFileIDMap) == null)
				{
					result = (this._WithinOuterPrefabComponentFileIDMap = new TMap<FGuid, int>(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_WithinOuterPrefabComponentFileIDMap, this));
				}
				return result;
			}
			set
			{
				this.WithinOuterPrefabComponentFileIDMap.CopyAssign(value);
			}
		}

		// Token: 0x17008C77 RID: 35959
		// (get) Token: 0x0602471E RID: 149278 RVA: 0x0035F2C0 File Offset: 0x0035D4C0
		// (set) Token: 0x0602471F RID: 149279 RVA: 0x0035F2F9 File Offset: 0x0035D4F9
		public TSet<FName> ModifiedPropertyFNames
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._ModifiedPropertyFNames) == null)
				{
					result = (this._ModifiedPropertyFNames = new TSet<FName>(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_ModifiedPropertyFNames, this));
				}
				return result;
			}
			set
			{
				this.ModifiedPropertyFNames.CopyAssign(value);
			}
		}

		// Token: 0x17008C78 RID: 35960
		// (get) Token: 0x06024720 RID: 149280 RVA: 0x0035F308 File Offset: 0x0035D508
		// (set) Token: 0x06024721 RID: 149281 RVA: 0x0035F341 File Offset: 0x0035D541
		public TMap<FGuid, string> OuterPrefabModifedPropertiesMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, string> result;
				if ((result = this._OuterPrefabModifedPropertiesMap) == null)
				{
					result = (this._OuterPrefabModifedPropertiesMap = new TMap<FGuid, string>(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_OuterPrefabModifedPropertiesMap, this));
				}
				return result;
			}
			set
			{
				this.OuterPrefabModifedPropertiesMap.CopyAssign(value);
			}
		}

		// Token: 0x17008C79 RID: 35961
		// (get) Token: 0x06024722 RID: 149282 RVA: 0x0035F350 File Offset: 0x0035D550
		// (set) Token: 0x06024723 RID: 149283 RVA: 0x0035F389 File Offset: 0x0035D589
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<UObject>, int> DeepCopyObjectsFileIDMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UObject>, int> result;
				if ((result = this._DeepCopyObjectsFileIDMap) == null)
				{
					result = (this._DeepCopyObjectsFileIDMap = new TMap<TWeakObjectPtr<UObject>, int>(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_DeepCopyObjectsFileIDMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DeepCopyObjectsFileIDMap.CopyAssign(value);
			}
		}

		// Token: 0x17008C7A RID: 35962
		// (get) Token: 0x06024724 RID: 149284 RVA: 0x0035F397 File Offset: 0x0035D597
		// (set) Token: 0x06024725 RID: 149285 RVA: 0x0035F3A7 File Offset: 0x0035D5A7
		public unsafe bool bIsAnyPrefabInstanceRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_bIsAnyPrefabInstanceRoot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UActorComponentPrefabData.__PropertyOffset_bIsAnyPrefabInstanceRoot) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024726 RID: 149286 RVA: 0x0035F3B8 File Offset: 0x0035D5B8
		static UActorComponentPrefabData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PrefabSystem.ActorComponentPrefabData");
		}

		// Token: 0x06024727 RID: 149287 RVA: 0x0035F3C6 File Offset: 0x0035D5C6
		protected UActorComponentPrefabData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013936 RID: 80182
		public new const string __ObjectPath = "/Script/PrefabSystem.ActorComponentPrefabData";

		// Token: 0x04013937 RID: 80183
		private static IntPtr _ClassPtr;

		// Token: 0x04013938 RID: 80184
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013939 RID: 80185
		internal static int __PropertyOffset_PrefabInstanceGuid;

		// Token: 0x0401393A RID: 80186
		internal static int __PropertyOffset_SourcePrefabGuid;

		// Token: 0x0401393B RID: 80187
		internal static int __PropertyOffset_SourceComponentFileID;

		// Token: 0x0401393C RID: 80188
		internal static int __PropertyOffset_SourceActorFileID;

		// Token: 0x0401393D RID: 80189
		internal static int __PropertyOffset_OuterPrefabGuid;

		// Token: 0x0401393E RID: 80190
		internal static int __PropertyOffset_OuterPrefabInstanceFileID;

		// Token: 0x0401393F RID: 80191
		internal static int __PropertyOffset_OuterPrefabInstanceGuid;

		// Token: 0x04013940 RID: 80192
		internal static int __PropertyOffset_WithinOuterPrefabActorFileIDMap;

		// Token: 0x04013941 RID: 80193
		[Nullable(2)]
		private TMap<FGuid, int> _WithinOuterPrefabActorFileIDMap;

		// Token: 0x04013942 RID: 80194
		internal static int __PropertyOffset_WithinOuterPrefabComponentFileIDMap;

		// Token: 0x04013943 RID: 80195
		[Nullable(2)]
		private TMap<FGuid, int> _WithinOuterPrefabComponentFileIDMap;

		// Token: 0x04013944 RID: 80196
		internal static int __PropertyOffset_ModifiedPropertyFNames;

		// Token: 0x04013945 RID: 80197
		[Nullable(2)]
		private TSet<FName> _ModifiedPropertyFNames;

		// Token: 0x04013946 RID: 80198
		internal static int __PropertyOffset_OuterPrefabModifedPropertiesMap;

		// Token: 0x04013947 RID: 80199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, string> _OuterPrefabModifedPropertiesMap;

		// Token: 0x04013948 RID: 80200
		internal static int __PropertyOffset_DeepCopyObjectsFileIDMap;

		// Token: 0x04013949 RID: 80201
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UObject>, int> _DeepCopyObjectsFileIDMap;

		// Token: 0x0401394A RID: 80202
		internal static int __PropertyOffset_bIsAnyPrefabInstanceRoot;
	}
}
