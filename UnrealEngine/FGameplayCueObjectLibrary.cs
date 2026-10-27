using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001370 RID: 4976
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueObjectLibrary")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGameplayCueObjectLibrary : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601241E RID: 74782 RVA: 0x001ACC74 File Offset: 0x001AAE74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueObjectLibrary._ScriptStructPtr != 0) ? FGameplayCueObjectLibrary._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueObjectLibrary", ref FGameplayCueObjectLibrary._ScriptStructPtr);
		}

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x0601241F RID: 74783 RVA: 0x001ACC98 File Offset: 0x001AAE98
		// (set) Token: 0x06012420 RID: 74784 RVA: 0x001ACCDB File Offset: 0x001AAEDB
		[Nullable(1)]
		public TArray<string> Paths
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Paths) == null)
				{
					result = (this._Paths = new TArray<string>(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_Paths, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Paths.CopyAssign(value);
			}
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x06012421 RID: 74785 RVA: 0x001ACCE9 File Offset: 0x001AAEE9
		// (set) Token: 0x06012422 RID: 74786 RVA: 0x001ACCFD File Offset: 0x001AAEFD
		public unsafe UObjectLibrary ActorObjectLibrary
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObjectLibrary>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_ActorObjectLibrary);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_ActorObjectLibrary, value);
			}
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x06012423 RID: 74787 RVA: 0x001ACD12 File Offset: 0x001AAF12
		// (set) Token: 0x06012424 RID: 74788 RVA: 0x001ACD26 File Offset: 0x001AAF26
		public unsafe UObjectLibrary StaticObjectLibrary
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObjectLibrary>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_StaticObjectLibrary);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_StaticObjectLibrary, value);
			}
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x06012425 RID: 74789 RVA: 0x001ACD3B File Offset: 0x001AAF3B
		// (set) Token: 0x06012426 RID: 74790 RVA: 0x001ACD4F File Offset: 0x001AAF4F
		public unsafe UGameplayCueSet CueSet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayCueSet>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_CueSet);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueObjectLibrary.__PropertyOffset_CueSet, value);
			}
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x06012427 RID: 74791 RVA: 0x001ACD64 File Offset: 0x001AAF64
		// (set) Token: 0x06012428 RID: 74792 RVA: 0x001ACD74 File Offset: 0x001AAF74
		public unsafe bool bShouldSyncScan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldSyncScan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldSyncScan) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x06012429 RID: 74793 RVA: 0x001ACD85 File Offset: 0x001AAF85
		// (set) Token: 0x0601242A RID: 74794 RVA: 0x001ACD95 File Offset: 0x001AAF95
		public unsafe bool bShouldAsyncLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldAsyncLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldAsyncLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x0601242B RID: 74795 RVA: 0x001ACDA6 File Offset: 0x001AAFA6
		// (set) Token: 0x0601242C RID: 74796 RVA: 0x001ACDB6 File Offset: 0x001AAFB6
		public unsafe bool bShouldSyncLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldSyncLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bShouldSyncLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x0601242D RID: 74797 RVA: 0x001ACDC7 File Offset: 0x001AAFC7
		// (set) Token: 0x0601242E RID: 74798 RVA: 0x001ACDD7 File Offset: 0x001AAFD7
		public unsafe bool bHasBeenInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bHasBeenInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueObjectLibrary.__PropertyOffset_bHasBeenInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601242F RID: 74799 RVA: 0x001ACDE8 File Offset: 0x001AAFE8
		public FGameplayCueObjectLibrary()
		{
		}

		// Token: 0x06012430 RID: 74800 RVA: 0x001ACDF0 File Offset: 0x001AAFF0
		[NullableContext(1)]
		public FGameplayCueObjectLibrary(TArray<string> Paths, UObjectLibrary ActorObjectLibrary, UObjectLibrary StaticObjectLibrary, UGameplayCueSet CueSet, bool bShouldSyncScan, bool bShouldAsyncLoad, bool bShouldSyncLoad, bool bHasBeenInitialized)
		{
			this.Paths = Paths;
			this.ActorObjectLibrary = ActorObjectLibrary;
			this.StaticObjectLibrary = StaticObjectLibrary;
			this.CueSet = CueSet;
			this.bShouldSyncScan = bShouldSyncScan;
			this.bShouldAsyncLoad = bShouldAsyncLoad;
			this.bShouldSyncLoad = bShouldSyncLoad;
			this.bHasBeenInitialized = bHasBeenInitialized;
		}

		// Token: 0x06012431 RID: 74801 RVA: 0x001ACE40 File Offset: 0x001AB040
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueObjectLibrary.StaticStruct();
		}

		// Token: 0x06012432 RID: 74802 RVA: 0x001ACE4C File Offset: 0x001AB04C
		public FGameplayCueObjectLibrary(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012433 RID: 74803 RVA: 0x001ACE56 File Offset: 0x001AB056
		public FGameplayCueObjectLibrary(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012434 RID: 74804 RVA: 0x001ACE61 File Offset: 0x001AB061
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueObjectLibrary(Pointer, false, true);
		}

		// Token: 0x06012435 RID: 74805 RVA: 0x001ACE6B File Offset: 0x001AB06B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueObjectLibrary(Pointer, MemoryOwner);
		}

		// Token: 0x04009C5D RID: 40029
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueObjectLibrary";

		// Token: 0x04009C5E RID: 40030
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C5F RID: 40031
		internal static int __PropertyOffset_Paths;

		// Token: 0x04009C60 RID: 40032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Paths;

		// Token: 0x04009C61 RID: 40033
		internal static int __PropertyOffset_ActorObjectLibrary;

		// Token: 0x04009C62 RID: 40034
		internal static int __PropertyOffset_StaticObjectLibrary;

		// Token: 0x04009C63 RID: 40035
		internal static int __PropertyOffset_CueSet;

		// Token: 0x04009C64 RID: 40036
		internal static int __PropertyOffset_bShouldSyncScan;

		// Token: 0x04009C65 RID: 40037
		internal static int __PropertyOffset_bShouldAsyncLoad;

		// Token: 0x04009C66 RID: 40038
		internal static int __PropertyOffset_bShouldSyncLoad;

		// Token: 0x04009C67 RID: 40039
		internal static int __PropertyOffset_bHasBeenInitialized;
	}
}
