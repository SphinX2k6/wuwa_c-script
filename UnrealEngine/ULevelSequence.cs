using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FAF RID: 8111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequence")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class ULevelSequence : UMovieSceneSequence, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601EC52 RID: 126034 RVA: 0x002DBE0E File Offset: 0x002DA00E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequence._ClassPtr;
		}

		// Token: 0x0601EC53 RID: 126035 RVA: 0x002DBE1A File Offset: 0x002DA01A
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return ULevelSequence.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x0601EC54 RID: 126036 RVA: 0x002DBE24 File Offset: 0x002DA024
		public ULevelSequence() : this(BuiltinUtils.AllocNativeUObject(ULevelSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC55 RID: 126037 RVA: 0x002DBE4C File Offset: 0x002DA04C
		public ULevelSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A92 RID: 31378
		// (get) Token: 0x0601EC56 RID: 126038 RVA: 0x002DBE7F File Offset: 0x002DA07F
		// (set) Token: 0x0601EC57 RID: 126039 RVA: 0x002DBE93 File Offset: 0x002DA093
		[Nullable(2)]
		public unsafe UMovieScene MovieScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_MovieScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x17007A93 RID: 31379
		// (get) Token: 0x0601EC58 RID: 126040 RVA: 0x002DBEA8 File Offset: 0x002DA0A8
		// (set) Token: 0x0601EC59 RID: 126041 RVA: 0x002DBEE1 File Offset: 0x002DA0E1
		public FLevelSequenceObjectReferenceMap ObjectReferences
		{
			get
			{
				base.FastCheckIsValid();
				FLevelSequenceObjectReferenceMap result;
				if ((result = this._ObjectReferences) == null)
				{
					result = (this._ObjectReferences = new FLevelSequenceObjectReferenceMap(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_ObjectReferences, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLevelSequenceObjectReferenceMap.StaticStruct(), base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_ObjectReferences, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A94 RID: 31380
		// (get) Token: 0x0601EC5A RID: 126042 RVA: 0x002DBF04 File Offset: 0x002DA104
		// (set) Token: 0x0601EC5B RID: 126043 RVA: 0x002DBF3D File Offset: 0x002DA13D
		public FLevelSequenceBindingReferences BindingReferences
		{
			get
			{
				base.FastCheckIsValid();
				FLevelSequenceBindingReferences result;
				if ((result = this._BindingReferences) == null)
				{
					result = (this._BindingReferences = new FLevelSequenceBindingReferences(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_BindingReferences, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLevelSequenceBindingReferences.StaticStruct(), base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_BindingReferences, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A95 RID: 31381
		// (get) Token: 0x0601EC5C RID: 126044 RVA: 0x002DBF60 File Offset: 0x002DA160
		// (set) Token: 0x0601EC5D RID: 126045 RVA: 0x002DBF99 File Offset: 0x002DA199
		public TMap<string, FLevelSequenceObject> PossessedObjects_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLevelSequenceObject> result;
				if ((result = this._PossessedObjects_DEPRECATED) == null)
				{
					result = (this._PossessedObjects_DEPRECATED = new TMap<string, FLevelSequenceObject>(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_PossessedObjects_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.PossessedObjects_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17007A96 RID: 31382
		// (get) Token: 0x0601EC5E RID: 126046 RVA: 0x002DBFA7 File Offset: 0x002DA1A7
		// (set) Token: 0x0601EC5F RID: 126047 RVA: 0x002DBFBB File Offset: 0x002DA1BB
		public unsafe UClassStackOnlyPtr DirectorClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_DirectorClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_DirectorClass) = value;
			}
		}

		// Token: 0x17007A97 RID: 31383
		// (get) Token: 0x0601EC60 RID: 126048 RVA: 0x002DBFD0 File Offset: 0x002DA1D0
		// (set) Token: 0x0601EC61 RID: 126049 RVA: 0x002DBFE0 File Offset: 0x002DA1E0
		public unsafe bool bOverrideCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_bOverrideCenterOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_bOverrideCenterOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007A98 RID: 31384
		// (get) Token: 0x0601EC62 RID: 126050 RVA: 0x002DBFF1 File Offset: 0x002DA1F1
		// (set) Token: 0x0601EC63 RID: 126051 RVA: 0x002DC005 File Offset: 0x002DA205
		public unsafe FVector DefaultCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_DefaultCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_DefaultCenterOffset) = value;
			}
		}

		// Token: 0x17007A99 RID: 31385
		// (get) Token: 0x0601EC64 RID: 126052 RVA: 0x002DC01A File Offset: 0x002DA21A
		// (set) Token: 0x0601EC65 RID: 126053 RVA: 0x002DC02A File Offset: 0x002DA22A
		public unsafe bool bUseAnimAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_bUseAnimAudio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_bUseAnimAudio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007A9A RID: 31386
		// (get) Token: 0x0601EC66 RID: 126054 RVA: 0x002DC03B File Offset: 0x002DA23B
		// (set) Token: 0x0601EC67 RID: 126055 RVA: 0x002DC04F File Offset: 0x002DA24F
		[Nullable(2)]
		public unsafe UKuroSequenceConsoleCommandDataAsset KuroSequenceConsoleCommandDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSequenceConsoleCommandDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_KuroSequenceConsoleCommandDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_KuroSequenceConsoleCommandDataAsset, value);
			}
		}

		// Token: 0x17007A9B RID: 31387
		// (get) Token: 0x0601EC68 RID: 126056 RVA: 0x002DC064 File Offset: 0x002DA264
		// (set) Token: 0x0601EC69 RID: 126057 RVA: 0x002DC078 File Offset: 0x002DA278
		[Nullable(2)]
		public unsafe UKuroSequenceConsoleCommandDataAsset SequenceDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSequenceConsoleCommandDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_SequenceDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_SequenceDataAsset, value);
			}
		}

		// Token: 0x17007A9C RID: 31388
		// (get) Token: 0x0601EC6A RID: 126058 RVA: 0x002DC090 File Offset: 0x002DA290
		// (set) Token: 0x0601EC6B RID: 126059 RVA: 0x002DC0C9 File Offset: 0x002DA2C9
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17007A9D RID: 31389
		// (get) Token: 0x0601EC6C RID: 126060 RVA: 0x002DC0D8 File Offset: 0x002DA2D8
		// (set) Token: 0x0601EC6D RID: 126061 RVA: 0x002DC111 File Offset: 0x002DA311
		public TMap<FGuid, FGuid> CustomGuidToBindingGuidMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._CustomGuidToBindingGuidMap) == null)
				{
					result = (this._CustomGuidToBindingGuidMap = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)ULevelSequence.__PropertyOffset_CustomGuidToBindingGuidMap, this));
				}
				return result;
			}
			set
			{
				this.CustomGuidToBindingGuidMap.CopyAssign(value);
			}
		}

		// Token: 0x0601EC6E RID: 126062 RVA: 0x002DC11F File Offset: 0x002DA31F
		public void SetCenterOffset(FVector InCenterOffset)
		{
			ULevelSequence.__SetCenterOffset_Internal(base.NativePtr, InCenterOffset);
		}

		// Token: 0x0601EC6F RID: 126063 RVA: 0x002DC12D File Offset: 0x002DA32D
		public void SetAnimAudio(bool Value)
		{
			ULevelSequence.__SetAnimAudio_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601EC70 RID: 126064 RVA: 0x002DC13B File Offset: 0x002DA33B
		public void RemoveMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			ULevelSequence.__RemoveMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x0601EC71 RID: 126065 RVA: 0x002DC14E File Offset: 0x002DA34E
		[NullableContext(2)]
		public UMovieScene GetMovieScene()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieScene>(ULevelSequence.__GetMovieScene_Internal(base.NativePtr));
		}

		// Token: 0x0601EC72 RID: 126066 RVA: 0x002DC160 File Offset: 0x002DA360
		public unsafe bool GetCenterOffset(ref FVector OutCenterOffset)
		{
			fixed (FVector* ptr = &OutCenterOffset)
			{
				void* ptr2 = (void*)ptr;
				return ULevelSequence.__GetCenterOffset_Internal(base.NativePtr, ref OutCenterOffset);
			}
		}

		// Token: 0x0601EC73 RID: 126067 RVA: 0x002DC17E File Offset: 0x002DA37E
		public bool GetAnimAudio()
		{
			return ULevelSequence.__GetAnimAudio_Internal(base.NativePtr);
		}

		// Token: 0x0601EC74 RID: 126068 RVA: 0x002DC18B File Offset: 0x002DA38B
		[NullableContext(2)]
		public UObject FindOrAddMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__FindOrAddMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x0601EC75 RID: 126069 RVA: 0x002DC1A3 File Offset: 0x002DA3A3
		[NullableContext(2)]
		public UObject FindMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__FindMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x0601EC76 RID: 126070 RVA: 0x002DC1BC File Offset: 0x002DA3BC
		public unsafe bool D_GetCenterOffset(ref FVectorDouble OutCenterOffset)
		{
			fixed (FVectorDouble* ptr = &OutCenterOffset)
			{
				void* ptr2 = (void*)ptr;
				return ULevelSequence.__D_GetCenterOffset_Internal(base.NativePtr, ref OutCenterOffset);
			}
		}

		// Token: 0x0601EC77 RID: 126071 RVA: 0x002DC1DA File Offset: 0x002DA3DA
		[NullableContext(2)]
		public UObject CopyMetaData(UObject InMetaData)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__CopyMetaData_Internal(base.NativePtr, (InMetaData != null) ? InMetaData.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601EC78 RID: 126072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterOffset_Internal(IntPtr @this, FVector InCenterOffset);

		// Token: 0x0601EC79 RID: 126073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimAudio_Internal(IntPtr @this, bool Value);

		// Token: 0x0601EC7A RID: 126074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0601EC7B RID: 126075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovieScene_Internal(IntPtr @this);

		// Token: 0x0601EC7C RID: 126076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCenterOffset_Internal(IntPtr @this, ref FVector OutCenterOffset);

		// Token: 0x0601EC7D RID: 126077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnimAudio_Internal(IntPtr @this);

		// Token: 0x0601EC7E RID: 126078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindOrAddMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0601EC7F RID: 126079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0601EC80 RID: 126080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetCenterOffset_Internal(IntPtr @this, ref FVectorDouble OutCenterOffset);

		// Token: 0x0601EC81 RID: 126081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyMetaData_Internal(IntPtr @this, IntPtr InMetaData);

		// Token: 0x0601EC82 RID: 126082 RVA: 0x002DC1FC File Offset: 0x002DA3FC
		static ULevelSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequence");
		}

		// Token: 0x0601EC83 RID: 126083 RVA: 0x002DC20A File Offset: 0x002DA40A
		protected ULevelSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A31 RID: 68145
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04010A32 RID: 68146
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequence";

		// Token: 0x04010A33 RID: 68147
		private static IntPtr _ClassPtr;

		// Token: 0x04010A34 RID: 68148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A35 RID: 68149
		internal static int __PropertyOffset_MovieScene;

		// Token: 0x04010A36 RID: 68150
		internal static int __PropertyOffset_ObjectReferences;

		// Token: 0x04010A37 RID: 68151
		[Nullable(2)]
		private FLevelSequenceObjectReferenceMap _ObjectReferences;

		// Token: 0x04010A38 RID: 68152
		internal static int __PropertyOffset_BindingReferences;

		// Token: 0x04010A39 RID: 68153
		[Nullable(2)]
		private FLevelSequenceBindingReferences _BindingReferences;

		// Token: 0x04010A3A RID: 68154
		internal static int __PropertyOffset_PossessedObjects_DEPRECATED;

		// Token: 0x04010A3B RID: 68155
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FLevelSequenceObject> _PossessedObjects_DEPRECATED;

		// Token: 0x04010A3C RID: 68156
		internal static int __PropertyOffset_DirectorClass;

		// Token: 0x04010A3D RID: 68157
		internal static int __PropertyOffset_bOverrideCenterOffset;

		// Token: 0x04010A3E RID: 68158
		internal static int __PropertyOffset_DefaultCenterOffset;

		// Token: 0x04010A3F RID: 68159
		internal static int __PropertyOffset_bUseAnimAudio;

		// Token: 0x04010A40 RID: 68160
		internal static int __PropertyOffset_KuroSequenceConsoleCommandDataAsset;

		// Token: 0x04010A41 RID: 68161
		internal static int __PropertyOffset_SequenceDataAsset;

		// Token: 0x04010A42 RID: 68162
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04010A43 RID: 68163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x04010A44 RID: 68164
		internal static int __PropertyOffset_CustomGuidToBindingGuidMap;

		// Token: 0x04010A45 RID: 68165
		[Nullable(2)]
		private TMap<FGuid, FGuid> _CustomGuidToBindingGuidMap;
	}
}
