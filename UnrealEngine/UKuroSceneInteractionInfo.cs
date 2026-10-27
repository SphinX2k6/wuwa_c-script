using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA9 RID: 7081
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroSceneInteractionInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B13A RID: 110906 RVA: 0x0027E4D5 File Offset: 0x0027C6D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneInteractionInfo._ClassPtr;
		}

		// Token: 0x0601B13B RID: 110907 RVA: 0x0027E4E4 File Offset: 0x0027C6E4
		public UKuroSceneInteractionInfo() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B13C RID: 110908 RVA: 0x0027E50C File Offset: 0x0027C70C
		[NullableContext(1)]
		public UKuroSceneInteractionInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C7E RID: 27774
		// (get) Token: 0x0601B13D RID: 110909 RVA: 0x0027E53F File Offset: 0x0027C73F
		// (set) Token: 0x0601B13E RID: 110910 RVA: 0x0027E553 File Offset: 0x0027C753
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17006C7F RID: 27775
		// (get) Token: 0x0601B13F RID: 110911 RVA: 0x0027E568 File Offset: 0x0027C768
		// (set) Token: 0x0601B140 RID: 110912 RVA: 0x0027E57C File Offset: 0x0027C77C
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17006C80 RID: 27776
		// (get) Token: 0x0601B141 RID: 110913 RVA: 0x0027E591 File Offset: 0x0027C791
		// (set) Token: 0x0601B142 RID: 110914 RVA: 0x0027E5A5 File Offset: 0x0027C7A5
		[Nullable(1)]
		public unsafe string LevelName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_LevelName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_LevelName)), value);
			}
		}

		// Token: 0x17006C81 RID: 27777
		// (get) Token: 0x0601B143 RID: 110915 RVA: 0x0027E5BA File Offset: 0x0027C7BA
		// (set) Token: 0x0601B144 RID: 110916 RVA: 0x0027E5CA File Offset: 0x0027C7CA
		public unsafe int HandleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_HandleId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_HandleId) = value;
			}
		}

		// Token: 0x17006C82 RID: 27778
		// (get) Token: 0x0601B145 RID: 110917 RVA: 0x0027E5DB File Offset: 0x0027C7DB
		// (set) Token: 0x0601B146 RID: 110918 RVA: 0x0027E5EB File Offset: 0x0027C7EB
		public unsafe EKuroSceneInteractionState CurrentState
		{
			get
			{
				return (EKuroSceneInteractionState)(*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_CurrentState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_CurrentState) = (byte)value;
			}
		}

		// Token: 0x17006C83 RID: 27779
		// (get) Token: 0x0601B147 RID: 110919 RVA: 0x0027E5FC File Offset: 0x0027C7FC
		// (set) Token: 0x0601B148 RID: 110920 RVA: 0x0027E60C File Offset: 0x0027C80C
		public unsafe bool LoadingLevelComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_LoadingLevelComplete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneInteractionInfo.__PropertyOffset_LoadingLevelComplete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C84 RID: 27780
		// (get) Token: 0x0601B149 RID: 110921 RVA: 0x0027E61D File Offset: 0x0027C81D
		// (set) Token: 0x0601B14A RID: 110922 RVA: 0x0027E631 File Offset: 0x0027C831
		public unsafe AKuroSceneInteractionActor InteractionActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroSceneInteractionActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneInteractionInfo.__PropertyOffset_InteractionActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneInteractionInfo.__PropertyOffset_InteractionActor, value);
			}
		}

		// Token: 0x17006C85 RID: 27781
		// (get) Token: 0x0601B14B RID: 110923 RVA: 0x0027E646 File Offset: 0x0027C846
		// (set) Token: 0x0601B14C RID: 110924 RVA: 0x0027E65A File Offset: 0x0027C85A
		public unsafe ULevelStreamingDynamic LevelStreaming
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelStreamingDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneInteractionInfo.__PropertyOffset_LevelStreaming);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneInteractionInfo.__PropertyOffset_LevelStreaming, value);
			}
		}

		// Token: 0x0601B14D RID: 110925 RVA: 0x0027E66F File Offset: 0x0027C86F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnLevelShown()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneInteractionInfo.__OnLevelShown_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B14E RID: 110926 RVA: 0x0027E684 File Offset: 0x0027C884
		static UKuroSceneInteractionInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionInfo");
		}

		// Token: 0x0601B14F RID: 110927 RVA: 0x0027E692 File Offset: 0x0027C892
		protected UKuroSceneInteractionInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E93A RID: 59706
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionInfo";

		// Token: 0x0400E93B RID: 59707
		private static IntPtr _ClassPtr;

		// Token: 0x0400E93C RID: 59708
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E93D RID: 59709
		internal static int __PropertyOffset_Location;

		// Token: 0x0400E93E RID: 59710
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400E93F RID: 59711
		internal static int __PropertyOffset_LevelName;

		// Token: 0x0400E940 RID: 59712
		internal static int __PropertyOffset_HandleId;

		// Token: 0x0400E941 RID: 59713
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x0400E942 RID: 59714
		internal static int __PropertyOffset_LoadingLevelComplete;

		// Token: 0x0400E943 RID: 59715
		internal static int __PropertyOffset_InteractionActor;

		// Token: 0x0400E944 RID: 59716
		internal static int __PropertyOffset_LevelStreaming;

		// Token: 0x0400E945 RID: 59717
		private static IntPtr __OnLevelShown_NativeFunctionPtr;
	}
}
