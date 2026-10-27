using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020CC RID: 8396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISubPrefabData")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FLGUISubPrefabData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FA2E RID: 129582 RVA: 0x002F09A4 File Offset: 0x002EEBA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUISubPrefabData._ScriptStructPtr != 0) ? FLGUISubPrefabData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUISubPrefabData", ref FLGUISubPrefabData._ScriptStructPtr);
		}

		// Token: 0x17007CC4 RID: 31940
		// (get) Token: 0x0601FA2F RID: 129583 RVA: 0x002F09C8 File Offset: 0x002EEBC8
		// (set) Token: 0x0601FA30 RID: 129584 RVA: 0x002F09DC File Offset: 0x002EEBDC
		public unsafe FGuid MasterPrefabGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_MasterPrefabGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_MasterPrefabGuid) = value;
			}
		}

		// Token: 0x17007CC5 RID: 31941
		// (get) Token: 0x0601FA31 RID: 129585 RVA: 0x002F09F1 File Offset: 0x002EEBF1
		// (set) Token: 0x0601FA32 RID: 129586 RVA: 0x002F0A05 File Offset: 0x002EEC05
		public unsafe FGuid UniqueStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_UniqueStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_UniqueStamp) = value;
			}
		}

		// Token: 0x17007CC6 RID: 31942
		// (get) Token: 0x0601FA33 RID: 129587 RVA: 0x002F0A1A File Offset: 0x002EEC1A
		// (set) Token: 0x0601FA34 RID: 129588 RVA: 0x002F0A2E File Offset: 0x002EEC2E
		[Nullable(2)]
		public unsafe ULGUIPrefabV2 PrefabAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIPrefabV2>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUISubPrefabData.__PropertyOffset_PrefabAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUISubPrefabData.__PropertyOffset_PrefabAsset, value);
			}
		}

		// Token: 0x17007CC7 RID: 31943
		// (get) Token: 0x0601FA35 RID: 129589 RVA: 0x002F0A44 File Offset: 0x002EEC44
		// (set) Token: 0x0601FA36 RID: 129590 RVA: 0x002F0A87 File Offset: 0x002EEC87
		public TArray<FLGUIPrefabOverrideParameterData> ObjectOverrideParameterArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUIPrefabOverrideParameterData> result;
				if ((result = this._ObjectOverrideParameterArray) == null)
				{
					result = (this._ObjectOverrideParameterArray = new TArray<FLGUIPrefabOverrideParameterData>(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_ObjectOverrideParameterArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectOverrideParameterArray.CopyAssign(value);
			}
		}

		// Token: 0x17007CC8 RID: 31944
		// (get) Token: 0x0601FA37 RID: 129591 RVA: 0x002F0A98 File Offset: 0x002EEC98
		// (set) Token: 0x0601FA38 RID: 129592 RVA: 0x002F0ADB File Offset: 0x002EECDB
		public TMap<FGuid, FGuid> ObjMainGuidToSelfGuidMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._ObjMainGuidToSelfGuidMap) == null)
				{
					result = (this._ObjMainGuidToSelfGuidMap = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_ObjMainGuidToSelfGuidMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjMainGuidToSelfGuidMap.CopyAssign(value);
			}
		}

		// Token: 0x17007CC9 RID: 31945
		// (get) Token: 0x0601FA39 RID: 129593 RVA: 0x002F0AEC File Offset: 0x002EECEC
		// (set) Token: 0x0601FA3A RID: 129594 RVA: 0x002F0B2F File Offset: 0x002EED2F
		public TMap<FGuid, UObject> SelfGuidObjMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, UObject> result;
				if ((result = this._SelfGuidObjMap) == null)
				{
					result = (this._SelfGuidObjMap = new TMap<FGuid, UObject>(base.NativePtr + (IntPtr)FLGUISubPrefabData.__PropertyOffset_SelfGuidObjMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SelfGuidObjMap.CopyAssign(value);
			}
		}

		// Token: 0x0601FA3B RID: 129595 RVA: 0x002F0B3D File Offset: 0x002EED3D
		public FLGUISubPrefabData()
		{
		}

		// Token: 0x0601FA3C RID: 129596 RVA: 0x002F0B45 File Offset: 0x002EED45
		public FLGUISubPrefabData(FGuid MasterPrefabGuid, FGuid UniqueStamp, ULGUIPrefabV2 PrefabAsset, TArray<FLGUIPrefabOverrideParameterData> ObjectOverrideParameterArray, TMap<FGuid, FGuid> ObjMainGuidToSelfGuidMap, TMap<FGuid, UObject> SelfGuidObjMap)
		{
			this.MasterPrefabGuid = MasterPrefabGuid;
			this.UniqueStamp = UniqueStamp;
			this.PrefabAsset = PrefabAsset;
			this.ObjectOverrideParameterArray = ObjectOverrideParameterArray;
			this.ObjMainGuidToSelfGuidMap = ObjMainGuidToSelfGuidMap;
			this.SelfGuidObjMap = SelfGuidObjMap;
		}

		// Token: 0x0601FA3D RID: 129597 RVA: 0x002F0B7A File Offset: 0x002EED7A
		protected override IntPtr GetUStructPtr()
		{
			return FLGUISubPrefabData.StaticStruct();
		}

		// Token: 0x0601FA3E RID: 129598 RVA: 0x002F0B86 File Offset: 0x002EED86
		[NullableContext(2)]
		public FLGUISubPrefabData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA3F RID: 129599 RVA: 0x002F0B90 File Offset: 0x002EED90
		public FLGUISubPrefabData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA40 RID: 129600 RVA: 0x002F0B9B File Offset: 0x002EED9B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUISubPrefabData(Pointer, false, true);
		}

		// Token: 0x0601FA41 RID: 129601 RVA: 0x002F0BA5 File Offset: 0x002EEDA5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUISubPrefabData(Pointer, MemoryOwner);
		}

		// Token: 0x04011129 RID: 69929
		public const string __ObjectPath = "/Script/LGUI.LGUISubPrefabData";

		// Token: 0x0401112A RID: 69930
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401112B RID: 69931
		internal static int __PropertyOffset_MasterPrefabGuid;

		// Token: 0x0401112C RID: 69932
		internal static int __PropertyOffset_UniqueStamp;

		// Token: 0x0401112D RID: 69933
		internal static int __PropertyOffset_PrefabAsset;

		// Token: 0x0401112E RID: 69934
		internal static int __PropertyOffset_ObjectOverrideParameterArray;

		// Token: 0x0401112F RID: 69935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUIPrefabOverrideParameterData> _ObjectOverrideParameterArray;

		// Token: 0x04011130 RID: 69936
		internal static int __PropertyOffset_ObjMainGuidToSelfGuidMap;

		// Token: 0x04011131 RID: 69937
		[Nullable(2)]
		private TMap<FGuid, FGuid> _ObjMainGuidToSelfGuidMap;

		// Token: 0x04011132 RID: 69938
		internal static int __PropertyOffset_SelfGuidObjMap;

		// Token: 0x04011133 RID: 69939
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, UObject> _SelfGuidObjMap;
	}
}
