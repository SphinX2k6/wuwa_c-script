using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000640 RID: 1600
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequence")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class ULevelSequence : UMovieSceneSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CAE RID: 36014 RVA: 0x000D3C34 File Offset: 0x000D1E34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequence._ClassPtr;
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x000D3C40 File Offset: 0x000D1E40
		public ULevelSequence() : this(BuiltinUtils.AllocNativeUObject(ULevelSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x000D3C68 File Offset: 0x000D1E68
		[NullableContext(1)]
		public ULevelSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x000D3C9B File Offset: 0x000D1E9B
		// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x000D3CAF File Offset: 0x000D1EAF
		public unsafe UMovieScene MovieScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_MovieScene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x000D3CC4 File Offset: 0x000D1EC4
		// (set) Token: 0x06008CB4 RID: 36020 RVA: 0x000D3CD8 File Offset: 0x000D1ED8
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

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06008CB5 RID: 36021 RVA: 0x000D3CED File Offset: 0x000D1EED
		// (set) Token: 0x06008CB6 RID: 36022 RVA: 0x000D3CFD File Offset: 0x000D1EFD
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

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06008CB7 RID: 36023 RVA: 0x000D3D0E File Offset: 0x000D1F0E
		// (set) Token: 0x06008CB8 RID: 36024 RVA: 0x000D3D22 File Offset: 0x000D1F22
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

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x000D3D37 File Offset: 0x000D1F37
		// (set) Token: 0x06008CBA RID: 36026 RVA: 0x000D3D47 File Offset: 0x000D1F47
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

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x000D3D58 File Offset: 0x000D1F58
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x000D3D6C File Offset: 0x000D1F6C
		public unsafe UKuroSequenceConsoleCommandDataAsset KuroSequenceConsoleCommandDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSequenceConsoleCommandDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_KuroSequenceConsoleCommandDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_KuroSequenceConsoleCommandDataAsset, value);
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x000D3D81 File Offset: 0x000D1F81
		// (set) Token: 0x06008CBE RID: 36030 RVA: 0x000D3D95 File Offset: 0x000D1F95
		public unsafe UKuroSequenceConsoleCommandDataAsset SequenceDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSequenceConsoleCommandDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_SequenceDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequence.__PropertyOffset_SequenceDataAsset, value);
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x000D3DAC File Offset: 0x000D1FAC
		// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x000D3DE5 File Offset: 0x000D1FE5
		[Nullable(1)]
		public TMap<FGuid, FGuid> CustomGuidToBindingGuidMap
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.CustomGuidToBindingGuidMap.CopyAssign(value);
			}
		}

		// Token: 0x06008CC1 RID: 36033 RVA: 0x000D3DF3 File Offset: 0x000D1FF3
		public void SetCenterOffset(FVector InCenterOffset)
		{
			ULevelSequence.__SetCenterOffset_Internal(base.NativePtr, InCenterOffset);
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x000D3E01 File Offset: 0x000D2001
		public void SetAnimAudio(bool Value)
		{
			ULevelSequence.__SetAnimAudio_Internal(base.NativePtr, Value);
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x000D3E0F File Offset: 0x000D200F
		public void RemoveMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			ULevelSequence.__RemoveMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x000D3E22 File Offset: 0x000D2022
		public UMovieScene GetMovieScene()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieScene>(ULevelSequence.__GetMovieScene_Internal(base.NativePtr));
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x000D3E34 File Offset: 0x000D2034
		public unsafe bool GetCenterOffset(ref FVector OutCenterOffset)
		{
			fixed (FVector* ptr = &OutCenterOffset)
			{
				void* ptr2 = (void*)ptr;
				return ULevelSequence.__GetCenterOffset_Internal(base.NativePtr, ref OutCenterOffset);
			}
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x000D3E52 File Offset: 0x000D2052
		public bool GetAnimAudio()
		{
			return ULevelSequence.__GetAnimAudio_Internal(base.NativePtr);
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x000D3E5F File Offset: 0x000D205F
		public UObject FindOrAddMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__FindOrAddMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x000D3E77 File Offset: 0x000D2077
		public UObject FindMetaDataByClass(UClassStackOnlyPtr InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__FindMetaDataByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x000D3E90 File Offset: 0x000D2090
		public unsafe bool D_GetCenterOffset(ref FVectorDouble OutCenterOffset)
		{
			fixed (FVectorDouble* ptr = &OutCenterOffset)
			{
				void* ptr2 = (void*)ptr;
				return ULevelSequence.__D_GetCenterOffset_Internal(base.NativePtr, ref OutCenterOffset);
			}
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x000D3EAE File Offset: 0x000D20AE
		public UObject CopyMetaData(UObject InMetaData)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ULevelSequence.__CopyMetaData_Internal(base.NativePtr, (InMetaData != null) ? InMetaData.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008CCB RID: 36043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterOffset_Internal(IntPtr @this, FVector InCenterOffset);

		// Token: 0x06008CCC RID: 36044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimAudio_Internal(IntPtr @this, bool Value);

		// Token: 0x06008CCD RID: 36045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06008CCE RID: 36046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovieScene_Internal(IntPtr @this);

		// Token: 0x06008CCF RID: 36047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCenterOffset_Internal(IntPtr @this, ref FVector OutCenterOffset);

		// Token: 0x06008CD0 RID: 36048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnimAudio_Internal(IntPtr @this);

		// Token: 0x06008CD1 RID: 36049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindOrAddMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06008CD2 RID: 36050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMetaDataByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06008CD3 RID: 36051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetCenterOffset_Internal(IntPtr @this, ref FVectorDouble OutCenterOffset);

		// Token: 0x06008CD4 RID: 36052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CopyMetaData_Internal(IntPtr @this, IntPtr InMetaData);

		// Token: 0x06008CD5 RID: 36053 RVA: 0x000D3ED0 File Offset: 0x000D20D0
		static ULevelSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequence");
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x000D3EDE File Offset: 0x000D20DE
		protected ULevelSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D4F RID: 15695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequence";

		// Token: 0x04003D50 RID: 15696
		private static IntPtr _ClassPtr;

		// Token: 0x04003D51 RID: 15697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D52 RID: 15698
		internal static int __PropertyOffset_MovieScene;

		// Token: 0x04003D53 RID: 15699
		internal static int __PropertyOffset_DirectorClass;

		// Token: 0x04003D54 RID: 15700
		internal static int __PropertyOffset_bOverrideCenterOffset;

		// Token: 0x04003D55 RID: 15701
		internal static int __PropertyOffset_DefaultCenterOffset;

		// Token: 0x04003D56 RID: 15702
		internal static int __PropertyOffset_bUseAnimAudio;

		// Token: 0x04003D57 RID: 15703
		internal static int __PropertyOffset_KuroSequenceConsoleCommandDataAsset;

		// Token: 0x04003D58 RID: 15704
		internal static int __PropertyOffset_SequenceDataAsset;

		// Token: 0x04003D59 RID: 15705
		internal static int __PropertyOffset_CustomGuidToBindingGuidMap;

		// Token: 0x04003D5A RID: 15706
		private TMap<FGuid, FGuid> _CustomGuidToBindingGuidMap;
	}
}
