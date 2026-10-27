using System;

namespace UnrealEngine
{
	// Token: 0x02002AD6 RID: 10966
	public enum UMetaKey : byte
	{
		// Token: 0x040161B1 RID: 90545
		ReplicatedUsing,
		// Token: 0x040161B2 RID: 90546
		BlueprintGetter,
		// Token: 0x040161B3 RID: 90547
		BlueprintSetter,
		// Token: 0x040161B4 RID: 90548
		Category,
		// Token: 0x040161B5 RID: 90549
		Hidden,
		// Token: 0x040161B6 RID: 90550
		ToolTip,
		// Token: 0x040161B7 RID: 90551
		ShortTooltip,
		// Token: 0x040161B8 RID: 90552
		DocumentationPolicy,
		// Token: 0x040161B9 RID: 90553
		BlueprintSpawnableComponent,
		// Token: 0x040161BA RID: 90554
		ChildCanTick,
		// Token: 0x040161BB RID: 90555
		ChildCannotTick,
		// Token: 0x040161BC RID: 90556
		IgnoreCategoryKeywordsInSubclasses,
		// Token: 0x040161BD RID: 90557
		DeprecatedNode,
		// Token: 0x040161BE RID: 90558
		DeprecationMessage,
		// Token: 0x040161BF RID: 90559
		DisplayName,
		// Token: 0x040161C0 RID: 90560
		ScriptName,
		// Token: 0x040161C1 RID: 90561
		IsBlueprintBase,
		// Token: 0x040161C2 RID: 90562
		KismetHideOverrides,
		// Token: 0x040161C3 RID: 90563
		ProhibitedInterfaces,
		// Token: 0x040161C4 RID: 90564
		RestrictedToClasses,
		// Token: 0x040161C5 RID: 90565
		ShowWorldContextPin,
		// Token: 0x040161C6 RID: 90566
		DontUseGenericSpawnObject,
		// Token: 0x040161C7 RID: 90567
		ExposedAsyncProxy,
		// Token: 0x040161C8 RID: 90568
		BlueprintThreadSafe,
		// Token: 0x040161C9 RID: 90569
		UsesHierarchy,
		// Token: 0x040161CA RID: 90570
		HasNativeBreak,
		// Token: 0x040161CB RID: 90571
		HasNativeMake,
		// Token: 0x040161CC RID: 90572
		HiddenByDefault,
		// Token: 0x040161CD RID: 90573
		DisableSplitPin,
		// Token: 0x040161CE RID: 90574
		AllowAbstract,
		// Token: 0x040161CF RID: 90575
		AllowAnyActor,
		// Token: 0x040161D0 RID: 90576
		AllowedClasses,
		// Token: 0x040161D1 RID: 90577
		AllowPreserveRatio,
		// Token: 0x040161D2 RID: 90578
		AllowPrivateAccess,
		// Token: 0x040161D3 RID: 90579
		ArrayClamp,
		// Token: 0x040161D4 RID: 90580
		AssetBundles,
		// Token: 0x040161D5 RID: 90581
		BlueprintBaseOnly,
		// Token: 0x040161D6 RID: 90582
		BlueprintCompilerGeneratedDefaults,
		// Token: 0x040161D7 RID: 90583
		ClampMin,
		// Token: 0x040161D8 RID: 90584
		ClampMax,
		// Token: 0x040161D9 RID: 90585
		ConfigHierarchyEditable,
		// Token: 0x040161DA RID: 90586
		ContentDir,
		// Token: 0x040161DB RID: 90587
		DeprecatedProperty,
		// Token: 0x040161DC RID: 90588
		DisallowedClasses,
		// Token: 0x040161DD RID: 90589
		DisplayAfter,
		// Token: 0x040161DE RID: 90590
		DisplayPriority,
		// Token: 0x040161DF RID: 90591
		DisplayThumbnail,
		// Token: 0x040161E0 RID: 90592
		EditCondition,
		// Token: 0x040161E1 RID: 90593
		EditFixedOrder,
		// Token: 0x040161E2 RID: 90594
		ExactClass,
		// Token: 0x040161E3 RID: 90595
		ExposeFunctionCategories,
		// Token: 0x040161E4 RID: 90596
		ExposeOnSpawn,
		// Token: 0x040161E5 RID: 90597
		FilePathFilter,
		// Token: 0x040161E6 RID: 90598
		RelativeToGameDir,
		// Token: 0x040161E7 RID: 90599
		FixedIncrement,
		// Token: 0x040161E8 RID: 90600
		ForceShowEngineContent,
		// Token: 0x040161E9 RID: 90601
		ForceShowPluginContent,
		// Token: 0x040161EA RID: 90602
		HideAlphaChannel,
		// Token: 0x040161EB RID: 90603
		HideInDetailPanel,
		// Token: 0x040161EC RID: 90604
		HideViewOptions,
		// Token: 0x040161ED RID: 90605
		IgnoreForMemberInitializationTest,
		// Token: 0x040161EE RID: 90606
		InlineEditConditionToggle,
		// Token: 0x040161EF RID: 90607
		LongPackageName,
		// Token: 0x040161F0 RID: 90608
		MakeEditWidget,
		// Token: 0x040161F1 RID: 90609
		MakeStructureDefaultValue,
		// Token: 0x040161F2 RID: 90610
		MetaClass,
		// Token: 0x040161F3 RID: 90611
		MustImplement,
		// Token: 0x040161F4 RID: 90612
		Multiple,
		// Token: 0x040161F5 RID: 90613
		MultiLine,
		// Token: 0x040161F6 RID: 90614
		PasswordField,
		// Token: 0x040161F7 RID: 90615
		NoElementDuplicate,
		// Token: 0x040161F8 RID: 90616
		NoResetToDefault,
		// Token: 0x040161F9 RID: 90617
		NoSpinbox,
		// Token: 0x040161FA RID: 90618
		OnlyPlaceable,
		// Token: 0x040161FB RID: 90619
		RelativePath,
		// Token: 0x040161FC RID: 90620
		RelativeToGameContentDir,
		// Token: 0x040161FD RID: 90621
		ScriptNoExport,
		// Token: 0x040161FE RID: 90622
		ShowOnlyInnerProperties,
		// Token: 0x040161FF RID: 90623
		ShowTreeView,
		// Token: 0x04016200 RID: 90624
		SliderExponent,
		// Token: 0x04016201 RID: 90625
		TitleProperty,
		// Token: 0x04016202 RID: 90626
		UIMin,
		// Token: 0x04016203 RID: 90627
		UIMax,
		// Token: 0x04016204 RID: 90628
		Untracked,
		// Token: 0x04016205 RID: 90629
		DevelopmentOnly,
		// Token: 0x04016206 RID: 90630
		NeedsLatentFixup,
		// Token: 0x04016207 RID: 90631
		LatentCallbackTarget,
		// Token: 0x04016208 RID: 90632
		GetOptions,
		// Token: 0x04016209 RID: 90633
		NeverAsPin,
		// Token: 0x0401620A RID: 90634
		PinHiddenByDefault,
		// Token: 0x0401620B RID: 90635
		PinShownByDefault,
		// Token: 0x0401620C RID: 90636
		AlwaysAsPin,
		// Token: 0x0401620D RID: 90637
		CustomizeProperty,
		// Token: 0x0401620E RID: 90638
		OverridingInputProperty,
		// Token: 0x0401620F RID: 90639
		RequiredInput,
		// Token: 0x04016210 RID: 90640
		AdvancedDisplay,
		// Token: 0x04016211 RID: 90641
		ArrayParm,
		// Token: 0x04016212 RID: 90642
		ArrayTypeDependentParams,
		// Token: 0x04016213 RID: 90643
		AutoCreateRefTerm,
		// Token: 0x04016214 RID: 90644
		BlueprintInternalUseOnly,
		// Token: 0x04016215 RID: 90645
		BlueprintProtected,
		// Token: 0x04016216 RID: 90646
		CallableWithoutWorldContext,
		// Token: 0x04016217 RID: 90647
		CommutativeAssociativeBinaryOperator,
		// Token: 0x04016218 RID: 90648
		CompactNodeTitle,
		// Token: 0x04016219 RID: 90649
		CustomStructureParam,
		// Token: 0x0401621A RID: 90650
		DefaultToSelf,
		// Token: 0x0401621B RID: 90651
		DeprecatedFunction,
		// Token: 0x0401621C RID: 90652
		ExpandEnumAsExecs,
		// Token: 0x0401621D RID: 90653
		ExpandBoolAsExecs,
		// Token: 0x0401621E RID: 90654
		ScriptMethod,
		// Token: 0x0401621F RID: 90655
		ScriptMethodSelfReturn,
		// Token: 0x04016220 RID: 90656
		ScriptOperator,
		// Token: 0x04016221 RID: 90657
		ScriptConstant,
		// Token: 0x04016222 RID: 90658
		ScriptConstantHost,
		// Token: 0x04016223 RID: 90659
		HidePin,
		// Token: 0x04016224 RID: 90660
		HideSpawnParms,
		// Token: 0x04016225 RID: 90661
		Keywords,
		// Token: 0x04016226 RID: 90662
		Latent,
		// Token: 0x04016227 RID: 90663
		LatentInfo,
		// Token: 0x04016228 RID: 90664
		MaterialParameterCollectionFunction,
		// Token: 0x04016229 RID: 90665
		NativeBreakFunc,
		// Token: 0x0401622A RID: 90666
		NativeMakeFunc,
		// Token: 0x0401622B RID: 90667
		UnsafeDuringActorConstruction,
		// Token: 0x0401622C RID: 90668
		WorldContext,
		// Token: 0x0401622D RID: 90669
		BlueprintAutocast,
		// Token: 0x0401622E RID: 90670
		NotBlueprintThreadSafe,
		// Token: 0x0401622F RID: 90671
		DeterminesOutputType,
		// Token: 0x04016230 RID: 90672
		DynamicOutputParam,
		// Token: 0x04016231 RID: 90673
		DataTablePin,
		// Token: 0x04016232 RID: 90674
		SetParam,
		// Token: 0x04016233 RID: 90675
		MapParam,
		// Token: 0x04016234 RID: 90676
		MapKeyParam,
		// Token: 0x04016235 RID: 90677
		MapValueParam,
		// Token: 0x04016236 RID: 90678
		Bitmask,
		// Token: 0x04016237 RID: 90679
		BitmaskEnum,
		// Token: 0x04016238 RID: 90680
		Bitflags,
		// Token: 0x04016239 RID: 90681
		UseEnumValuesAsMaskValuesInEditor,
		// Token: 0x0401623A RID: 90682
		AnimBlueprintFunction,
		// Token: 0x0401623B RID: 90683
		ArrayParam,
		// Token: 0x0401623C RID: 90684
		CannotImplementInterfaceInBlueprint,
		// Token: 0x0401623D RID: 90685
		Categories,
		// Token: 0x0401623E RID: 90686
		GameplayTagFilter
	}
}
