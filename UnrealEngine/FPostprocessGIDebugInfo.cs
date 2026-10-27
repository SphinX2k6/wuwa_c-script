using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C22 RID: 7202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.PostprocessGIDebugInfo")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FPostprocessGIDebugInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BD1F RID: 113951 RVA: 0x0028F2C0 File Offset: 0x0028D4C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPostprocessGIDebugInfo._ScriptStructPtr != 0) ? FPostprocessGIDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.PostprocessGIDebugInfo", ref FPostprocessGIDebugInfo._ScriptStructPtr);
		}

		// Token: 0x17007042 RID: 28738
		// (get) Token: 0x0601BD20 RID: 113952 RVA: 0x0028F2E4 File Offset: 0x0028D4E4
		// (set) Token: 0x0601BD21 RID: 113953 RVA: 0x0028F2F8 File Offset: 0x0028D4F8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> OwnerActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_OwnerActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_OwnerActor) = value;
			}
		}

		// Token: 0x17007043 RID: 28739
		// (get) Token: 0x0601BD22 RID: 113954 RVA: 0x0028F30D File Offset: 0x0028D50D
		// (set) Token: 0x0601BD23 RID: 113955 RVA: 0x0028F321 File Offset: 0x0028D521
		public unsafe string OwnerActorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_OwnerActorName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_OwnerActorName)), value);
			}
		}

		// Token: 0x17007044 RID: 28740
		// (get) Token: 0x0601BD24 RID: 113956 RVA: 0x0028F336 File Offset: 0x0028D536
		// (set) Token: 0x0601BD25 RID: 113957 RVA: 0x0028F34A File Offset: 0x0028D54A
		public unsafe FName ActorFolderPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ActorFolderPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ActorFolderPath) = value;
			}
		}

		// Token: 0x17007045 RID: 28741
		// (get) Token: 0x0601BD26 RID: 113958 RVA: 0x0028F35F File Offset: 0x0028D55F
		// (set) Token: 0x0601BD27 RID: 113959 RVA: 0x0028F373 File Offset: 0x0028D573
		public unsafe string ActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ActorLabel)), value);
			}
		}

		// Token: 0x17007046 RID: 28742
		// (get) Token: 0x0601BD28 RID: 113960 RVA: 0x0028F388 File Offset: 0x0028D588
		// (set) Token: 0x0601BD29 RID: 113961 RVA: 0x0028F398 File Offset: 0x0028D598
		public unsafe bool IsVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_IsVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_IsVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007047 RID: 28743
		// (get) Token: 0x0601BD2A RID: 113962 RVA: 0x0028F3A9 File Offset: 0x0028D5A9
		// (set) Token: 0x0601BD2B RID: 113963 RVA: 0x0028F3BD File Offset: 0x0028D5BD
		public unsafe string ComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ComponentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_ComponentName)), value);
			}
		}

		// Token: 0x17007048 RID: 28744
		// (get) Token: 0x0601BD2C RID: 113964 RVA: 0x0028F3D2 File Offset: 0x0028D5D2
		// (set) Token: 0x0601BD2D RID: 113965 RVA: 0x0028F3E2 File Offset: 0x0028D5E2
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17007049 RID: 28745
		// (get) Token: 0x0601BD2E RID: 113966 RVA: 0x0028F3F3 File Offset: 0x0028D5F3
		// (set) Token: 0x0601BD2F RID: 113967 RVA: 0x0028F403 File Offset: 0x0028D603
		public unsafe int WorldPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WorldPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WorldPriority) = value;
			}
		}

		// Token: 0x1700704A RID: 28746
		// (get) Token: 0x0601BD30 RID: 113968 RVA: 0x0028F414 File Offset: 0x0028D614
		// (set) Token: 0x0601BD31 RID: 113969 RVA: 0x0028F424 File Offset: 0x0028D624
		public unsafe float LocalBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_LocalBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_LocalBlendWeight) = value;
			}
		}

		// Token: 0x1700704B RID: 28747
		// (get) Token: 0x0601BD32 RID: 113970 RVA: 0x0028F435 File Offset: 0x0028D635
		// (set) Token: 0x0601BD33 RID: 113971 RVA: 0x0028F445 File Offset: 0x0028D645
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x1700704C RID: 28748
		// (get) Token: 0x0601BD34 RID: 113972 RVA: 0x0028F456 File Offset: 0x0028D656
		// (set) Token: 0x0601BD35 RID: 113973 RVA: 0x0028F466 File Offset: 0x0028D666
		public unsafe bool IsUnbound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_IsUnbound) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_IsUnbound) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700704D RID: 28749
		// (get) Token: 0x0601BD36 RID: 113974 RVA: 0x0028F477 File Offset: 0x0028D677
		// (set) Token: 0x0601BD37 RID: 113975 RVA: 0x0028F48B File Offset: 0x0028D68B
		public unsafe string WeatherDAPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WeatherDAPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WeatherDAPath)), value);
			}
		}

		// Token: 0x1700704E RID: 28750
		// (get) Token: 0x0601BD38 RID: 113976 RVA: 0x0028F4A0 File Offset: 0x0028D6A0
		// (set) Token: 0x0601BD39 RID: 113977 RVA: 0x0028F4B4 File Offset: 0x0028D6B4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UKuroWeatherDataAsset> WeatherDAData
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WeatherDAData);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_WeatherDAData) = value;
			}
		}

		// Token: 0x1700704F RID: 28751
		// (get) Token: 0x0601BD3A RID: 113978 RVA: 0x0028F4C9 File Offset: 0x0028D6C9
		// (set) Token: 0x0601BD3B RID: 113979 RVA: 0x0028F4DD File Offset: 0x0028D6DD
		public unsafe string TodDAPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_TodDAPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_TodDAPath)), value);
			}
		}

		// Token: 0x17007050 RID: 28752
		// (get) Token: 0x0601BD3C RID: 113980 RVA: 0x0028F4F2 File Offset: 0x0028D6F2
		// (set) Token: 0x0601BD3D RID: 113981 RVA: 0x0028F506 File Offset: 0x0028D706
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UKuroTODData> TodDAData
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_TodDAData);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_TodDAData) = value;
			}
		}

		// Token: 0x17007051 RID: 28753
		// (get) Token: 0x0601BD3E RID: 113982 RVA: 0x0028F51C File Offset: 0x0028D71C
		// (set) Token: 0x0601BD3F RID: 113983 RVA: 0x0028F55F File Offset: 0x0028D75F
		public TArray<string> OverridedProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OverridedProperties) == null)
				{
					result = (this._OverridedProperties = new TArray<string>(base.NativePtr + (IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_OverridedProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverridedProperties.CopyAssign(value);
			}
		}

		// Token: 0x17007052 RID: 28754
		// (get) Token: 0x0601BD40 RID: 113984 RVA: 0x0028F56D File Offset: 0x0028D76D
		// (set) Token: 0x0601BD41 RID: 113985 RVA: 0x0028F581 File Offset: 0x0028D781
		public unsafe string PostProcessMaterialPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_PostProcessMaterialPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPostprocessGIDebugInfo.__PropertyOffset_PostProcessMaterialPath)), value);
			}
		}

		// Token: 0x0601BD42 RID: 113986 RVA: 0x0028F596 File Offset: 0x0028D796
		public FPostprocessGIDebugInfo()
		{
		}

		// Token: 0x0601BD43 RID: 113987 RVA: 0x0028F5A0 File Offset: 0x0028D7A0
		public FPostprocessGIDebugInfo([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> OwnerActor, string OwnerActorName, FName ActorFolderPath, string ActorLabel, bool IsVolume, string ComponentName, int Priority, int WorldPriority, float LocalBlendWeight, float BlendWeight, bool IsUnbound, string WeatherDAPath, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UKuroWeatherDataAsset> WeatherDAData, string TodDAPath, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UKuroTODData> TodDAData, TArray<string> OverridedProperties, string PostProcessMaterialPath)
		{
			this.OwnerActor = OwnerActor;
			this.OwnerActorName = OwnerActorName;
			this.ActorFolderPath = ActorFolderPath;
			this.ActorLabel = ActorLabel;
			this.IsVolume = IsVolume;
			this.ComponentName = ComponentName;
			this.Priority = Priority;
			this.WorldPriority = WorldPriority;
			this.LocalBlendWeight = LocalBlendWeight;
			this.BlendWeight = BlendWeight;
			this.IsUnbound = IsUnbound;
			this.WeatherDAPath = WeatherDAPath;
			this.WeatherDAData = WeatherDAData;
			this.TodDAPath = TodDAPath;
			this.TodDAData = TodDAData;
			this.OverridedProperties = OverridedProperties;
			this.PostProcessMaterialPath = PostProcessMaterialPath;
		}

		// Token: 0x0601BD44 RID: 113988 RVA: 0x0028F638 File Offset: 0x0028D838
		protected override IntPtr GetUStructPtr()
		{
			return FPostprocessGIDebugInfo.StaticStruct();
		}

		// Token: 0x0601BD45 RID: 113989 RVA: 0x0028F644 File Offset: 0x0028D844
		[NullableContext(2)]
		public FPostprocessGIDebugInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD46 RID: 113990 RVA: 0x0028F64E File Offset: 0x0028D84E
		public FPostprocessGIDebugInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD47 RID: 113991 RVA: 0x0028F659 File Offset: 0x0028D859
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPostprocessGIDebugInfo(Pointer, false, true);
		}

		// Token: 0x0601BD48 RID: 113992 RVA: 0x0028F663 File Offset: 0x0028D863
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPostprocessGIDebugInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF3B RID: 61243
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.PostprocessGIDebugInfo";

		// Token: 0x0400EF3C RID: 61244
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF3D RID: 61245
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x0400EF3E RID: 61246
		internal static int __PropertyOffset_OwnerActorName;

		// Token: 0x0400EF3F RID: 61247
		internal static int __PropertyOffset_ActorFolderPath;

		// Token: 0x0400EF40 RID: 61248
		internal static int __PropertyOffset_ActorLabel;

		// Token: 0x0400EF41 RID: 61249
		internal static int __PropertyOffset_IsVolume;

		// Token: 0x0400EF42 RID: 61250
		internal static int __PropertyOffset_ComponentName;

		// Token: 0x0400EF43 RID: 61251
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400EF44 RID: 61252
		internal static int __PropertyOffset_WorldPriority;

		// Token: 0x0400EF45 RID: 61253
		internal static int __PropertyOffset_LocalBlendWeight;

		// Token: 0x0400EF46 RID: 61254
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x0400EF47 RID: 61255
		internal static int __PropertyOffset_IsUnbound;

		// Token: 0x0400EF48 RID: 61256
		internal static int __PropertyOffset_WeatherDAPath;

		// Token: 0x0400EF49 RID: 61257
		internal static int __PropertyOffset_WeatherDAData;

		// Token: 0x0400EF4A RID: 61258
		internal static int __PropertyOffset_TodDAPath;

		// Token: 0x0400EF4B RID: 61259
		internal static int __PropertyOffset_TodDAData;

		// Token: 0x0400EF4C RID: 61260
		internal static int __PropertyOffset_OverridedProperties;

		// Token: 0x0400EF4D RID: 61261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverridedProperties;

		// Token: 0x0400EF4E RID: 61262
		internal static int __PropertyOffset_PostProcessMaterialPath;
	}
}
