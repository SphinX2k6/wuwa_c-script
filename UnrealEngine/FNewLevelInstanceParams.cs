using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EEE RID: 3822
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NewLevelInstanceParams")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FNewLevelInstanceParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF3A RID: 53050 RVA: 0x0012E562 File Offset: 0x0012C762
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNewLevelInstanceParams._ScriptStructPtr != 0) ? FNewLevelInstanceParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NewLevelInstanceParams", ref FNewLevelInstanceParams._ScriptStructPtr);
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600CF3B RID: 53051 RVA: 0x0012E586 File Offset: 0x0012C786
		// (set) Token: 0x0600CF3C RID: 53052 RVA: 0x0012E596 File Offset: 0x0012C796
		public unsafe ELevelInstanceCreationType Type
		{
			get
			{
				return (ELevelInstanceCreationType)(*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600CF3D RID: 53053 RVA: 0x0012E5A7 File Offset: 0x0012C7A7
		// (set) Token: 0x0600CF3E RID: 53054 RVA: 0x0012E5B7 File Offset: 0x0012C7B7
		public unsafe ELevelInstancePivotType PivotType
		{
			get
			{
				return (ELevelInstancePivotType)(*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_PivotType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_PivotType) = (byte)value;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600CF3F RID: 53055 RVA: 0x0012E5C8 File Offset: 0x0012C7C8
		// (set) Token: 0x0600CF40 RID: 53056 RVA: 0x0012E5DC File Offset: 0x0012C7DC
		[Nullable(2)]
		public unsafe AActor PivotActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FNewLevelInstanceParams.__PropertyOffset_PivotActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNewLevelInstanceParams.__PropertyOffset_PivotActor, value);
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600CF41 RID: 53057 RVA: 0x0012E5F1 File Offset: 0x0012C7F1
		// (set) Token: 0x0600CF42 RID: 53058 RVA: 0x0012E610 File Offset: 0x0012C810
		public TSoftObjectPtr<UWorldPartitionSettingAsset> WorldPartitionStreamingConfig
		{
			get
			{
				return new TSoftObjectPtr<UWorldPartitionSettingAsset>(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_WorldPartitionStreamingConfig, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_WorldPartitionStreamingConfig, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600CF43 RID: 53059 RVA: 0x0012E635 File Offset: 0x0012C835
		// (set) Token: 0x0600CF44 RID: 53060 RVA: 0x0012E645 File Offset: 0x0012C845
		public unsafe bool bAlwaysShowDialog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bAlwaysShowDialog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bAlwaysShowDialog) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600CF45 RID: 53061 RVA: 0x0012E656 File Offset: 0x0012C856
		// (set) Token: 0x0600CF46 RID: 53062 RVA: 0x0012E66A File Offset: 0x0012C86A
		[Nullable(2)]
		public unsafe UWorld TemplateWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + FNewLevelInstanceParams.__PropertyOffset_TemplateWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNewLevelInstanceParams.__PropertyOffset_TemplateWorld, value);
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600CF47 RID: 53063 RVA: 0x0012E67F File Offset: 0x0012C87F
		// (set) Token: 0x0600CF48 RID: 53064 RVA: 0x0012E693 File Offset: 0x0012C893
		public unsafe string LevelPackageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNewLevelInstanceParams.__PropertyOffset_LevelPackageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNewLevelInstanceParams.__PropertyOffset_LevelPackageName)), value);
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600CF49 RID: 53065 RVA: 0x0012E6A8 File Offset: 0x0012C8A8
		// (set) Token: 0x0600CF4A RID: 53066 RVA: 0x0012E6B8 File Offset: 0x0012C8B8
		public unsafe bool bPromptForSave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bPromptForSave) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bPromptForSave) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600CF4B RID: 53067 RVA: 0x0012E6C9 File Offset: 0x0012C8C9
		// (set) Token: 0x0600CF4C RID: 53068 RVA: 0x0012E6DD File Offset: 0x0012C8DD
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> LevelInstanceClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_LevelInstanceClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_LevelInstanceClass) = value;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600CF4D RID: 53069 RVA: 0x0012E6F2 File Offset: 0x0012C8F2
		// (set) Token: 0x0600CF4E RID: 53070 RVA: 0x0012E702 File Offset: 0x0012C902
		public unsafe bool bEnableStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bEnableStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bEnableStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600CF4F RID: 53071 RVA: 0x0012E713 File Offset: 0x0012C913
		// (set) Token: 0x0600CF50 RID: 53072 RVA: 0x0012E723 File Offset: 0x0012C923
		public unsafe bool bExternalActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bExternalActors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bExternalActors) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600CF51 RID: 53073 RVA: 0x0012E734 File Offset: 0x0012C934
		// (set) Token: 0x0600CF52 RID: 53074 RVA: 0x0012E744 File Offset: 0x0012C944
		public unsafe bool bForceExternalActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bForceExternalActors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bForceExternalActors) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600CF53 RID: 53075 RVA: 0x0012E755 File Offset: 0x0012C955
		// (set) Token: 0x0600CF54 RID: 53076 RVA: 0x0012E765 File Offset: 0x0012C965
		public unsafe bool bHideCreationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bHideCreationType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNewLevelInstanceParams.__PropertyOffset_bHideCreationType) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600CF55 RID: 53077 RVA: 0x0012E776 File Offset: 0x0012C976
		public FNewLevelInstanceParams()
		{
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x0012E780 File Offset: 0x0012C980
		public FNewLevelInstanceParams(ELevelInstanceCreationType Type, ELevelInstancePivotType PivotType, AActor PivotActor, TSoftObjectPtr<UWorldPartitionSettingAsset> WorldPartitionStreamingConfig, bool bAlwaysShowDialog, UWorld TemplateWorld, string LevelPackageName, bool bPromptForSave, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> LevelInstanceClass, bool bEnableStreaming, bool bExternalActors, bool bForceExternalActors, bool bHideCreationType)
		{
			this.Type = Type;
			this.PivotType = PivotType;
			this.PivotActor = PivotActor;
			this.WorldPartitionStreamingConfig = WorldPartitionStreamingConfig;
			this.bAlwaysShowDialog = bAlwaysShowDialog;
			this.TemplateWorld = TemplateWorld;
			this.LevelPackageName = LevelPackageName;
			this.bPromptForSave = bPromptForSave;
			this.LevelInstanceClass = LevelInstanceClass;
			this.bEnableStreaming = bEnableStreaming;
			this.bExternalActors = bExternalActors;
			this.bForceExternalActors = bForceExternalActors;
			this.bHideCreationType = bHideCreationType;
		}

		// Token: 0x0600CF57 RID: 53079 RVA: 0x0012E7F8 File Offset: 0x0012C9F8
		protected override IntPtr GetUStructPtr()
		{
			return FNewLevelInstanceParams.StaticStruct();
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x0012E804 File Offset: 0x0012CA04
		[NullableContext(2)]
		public FNewLevelInstanceParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x0012E80E File Offset: 0x0012CA0E
		public FNewLevelInstanceParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF5A RID: 53082 RVA: 0x0012E819 File Offset: 0x0012CA19
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNewLevelInstanceParams(Pointer, false, true);
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x0012E823 File Offset: 0x0012CA23
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNewLevelInstanceParams(Pointer, MemoryOwner);
		}

		// Token: 0x04006FC3 RID: 28611
		public const string __ObjectPath = "/Script/Engine.NewLevelInstanceParams";

		// Token: 0x04006FC4 RID: 28612
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FC5 RID: 28613
		internal static int __PropertyOffset_Type;

		// Token: 0x04006FC6 RID: 28614
		internal static int __PropertyOffset_PivotType;

		// Token: 0x04006FC7 RID: 28615
		internal static int __PropertyOffset_PivotActor;

		// Token: 0x04006FC8 RID: 28616
		internal static int __PropertyOffset_WorldPartitionStreamingConfig;

		// Token: 0x04006FC9 RID: 28617
		internal static int __PropertyOffset_bAlwaysShowDialog;

		// Token: 0x04006FCA RID: 28618
		internal static int __PropertyOffset_TemplateWorld;

		// Token: 0x04006FCB RID: 28619
		internal static int __PropertyOffset_LevelPackageName;

		// Token: 0x04006FCC RID: 28620
		internal static int __PropertyOffset_bPromptForSave;

		// Token: 0x04006FCD RID: 28621
		internal static int __PropertyOffset_LevelInstanceClass;

		// Token: 0x04006FCE RID: 28622
		internal static int __PropertyOffset_bEnableStreaming;

		// Token: 0x04006FCF RID: 28623
		internal static int __PropertyOffset_bExternalActors;

		// Token: 0x04006FD0 RID: 28624
		internal static int __PropertyOffset_bForceExternalActors;

		// Token: 0x04006FD1 RID: 28625
		internal static int __PropertyOffset_bHideCreationType;
	}
}
