using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FAB RID: 8107
	[UnrealObjectPath("/Script/LevelSequence.DefaultLevelSequenceInstanceData")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UDefaultLevelSequenceInstanceData : UObject, IUnrealUObject, IUnrealObject, IMovieSceneTransformOrigin, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601EC1D RID: 125981 RVA: 0x002DB94D File Offset: 0x002D9B4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDefaultLevelSequenceInstanceData._ClassPtr;
		}

		// Token: 0x0601EC1E RID: 125982 RVA: 0x002DB959 File Offset: 0x002D9B59
		int IMovieSceneTransformOrigin.InterfaceOffset()
		{
			return UDefaultLevelSequenceInstanceData.__InterfaceOffset_IMovieSceneTransformOrigin;
		}

		// Token: 0x0601EC1F RID: 125983 RVA: 0x002DB960 File Offset: 0x002D9B60
		public UDefaultLevelSequenceInstanceData() : this(BuiltinUtils.AllocNativeUObject(UDefaultLevelSequenceInstanceData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC20 RID: 125984 RVA: 0x002DB988 File Offset: 0x002D9B88
		[NullableContext(1)]
		public UDefaultLevelSequenceInstanceData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDefaultLevelSequenceInstanceData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A82 RID: 31362
		// (get) Token: 0x0601EC21 RID: 125985 RVA: 0x002DB9BB File Offset: 0x002D9BBB
		// (set) Token: 0x0601EC22 RID: 125986 RVA: 0x002DB9CF File Offset: 0x002D9BCF
		[Nullable(2)]
		public unsafe AActor TransformOriginActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOriginActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOriginActor, value);
			}
		}

		// Token: 0x17007A83 RID: 31363
		// (get) Token: 0x0601EC23 RID: 125987 RVA: 0x002DB9E4 File Offset: 0x002D9BE4
		// (set) Token: 0x0601EC24 RID: 125988 RVA: 0x002DB9F8 File Offset: 0x002D9BF8
		public unsafe FTransform TransformOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOrigin) = value;
			}
		}

		// Token: 0x17007A84 RID: 31364
		// (get) Token: 0x0601EC25 RID: 125989 RVA: 0x002DBA0D File Offset: 0x002D9C0D
		// (set) Token: 0x0601EC26 RID: 125990 RVA: 0x002DBA1D File Offset: 0x002D9C1D
		public unsafe bool ApplyWorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_ApplyWorldOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_ApplyWorldOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EC27 RID: 125991 RVA: 0x002DBA2E File Offset: 0x002D9C2E
		static UDefaultLevelSequenceInstanceData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.DefaultLevelSequenceInstanceData");
		}

		// Token: 0x0601EC28 RID: 125992 RVA: 0x002DBA3C File Offset: 0x002D9C3C
		protected UDefaultLevelSequenceInstanceData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A10 RID: 68112
		internal static int __InterfaceOffset_IMovieSceneTransformOrigin;

		// Token: 0x04010A11 RID: 68113
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.DefaultLevelSequenceInstanceData";

		// Token: 0x04010A12 RID: 68114
		private static IntPtr _ClassPtr;

		// Token: 0x04010A13 RID: 68115
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A14 RID: 68116
		internal static int __PropertyOffset_TransformOriginActor;

		// Token: 0x04010A15 RID: 68117
		internal static int __PropertyOffset_TransformOrigin;

		// Token: 0x04010A16 RID: 68118
		internal static int __PropertyOffset_ApplyWorldOrigin;
	}
}
