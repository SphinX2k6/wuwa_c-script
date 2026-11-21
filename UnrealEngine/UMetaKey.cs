using System;

namespace UnrealEngine
{
	// Token: 0x02000885 RID: 2181
	public enum UMetaKey : byte
	{
		// Token: 0x040055CC RID: 21964
		ReplicatedUsing,
		// Token: 0x040055CD RID: 21965
		BlueprintGetter,
		// Token: 0x040055CE RID: 21966
		BlueprintSetter,
		// Token: 0x040055CF RID: 21967
		Category,
		// Token: 0x040055D0 RID: 21968
		Hidden,
		// Token: 0x040055D1 RID: 21969
		ToolTip,
		// Token: 0x040055D2 RID: 21970
		ShortTooltip,
		// Token: 0x040055D3 RID: 21971
		DocumentationPolicy,
		// Token: 0x040055D4 RID: 21972
		BlueprintSpawnableComponent,
		// Token: 0x040055D5 RID: 21973
		ChildCanTick,
		// Token: 0x040055D6 RID: 21974
		ChildCannotTick,
		// Token: 0x040055D7 RID: 21975
		IgnoreCategoryKeywordsInSubclasses,
		// Token: 0x040055D8 RID: 21976
		DeprecatedNode,
		// Token: 0x040055D9 RID: 21977
		DeprecationMessage,
		// Token: 0x040055DA RID: 21978
		DisplayName,
		// Token: 0x040055DB RID: 21979
		ScriptName,
		// Token: 0x040055DC RID: 21980
		IsBlueprintBase,
		// Token: 0x040055DD RID: 21981
		KismetHideOverrides,
		// Token: 0x040055DE RID: 21982
		ProhibitedInterfaces,
		// Token: 0x040055DF RID: 21983
		RestrictedToClasses,
		// Token: 0x040055E0 RID: 21984
		ShowWorldContextPin,
		// Token: 0x040055E1 RID: 21985
		DontUseGenericSpawnObject,
		// Token: 0x040055E2 RID: 21986
		ExposedAsyncProxy,
		// Token: 0x040055E3 RID: 21987
		BlueprintThreadSafe,
		// Token: 0x040055E4 RID: 21988
		UsesHierarchy,
		// Token: 0x040055E5 RID: 21989
		HasNativeBreak,
		// Token: 0x040055E6 RID: 21990
		HasNativeMake,
		// Token: 0x040055E7 RID: 21991
		HiddenByDefault,
		// Token: 0x040055E8 RID: 21992
		DisableSplitPin,
		// Token: 0x040055E9 RID: 21993
		AllowAbstract,
		// Token: 0x040055EA RID: 21994
		AllowAnyActor,
		// Token: 0x040055EB RID: 21995
		AllowedClasses,
		// Token: 0x040055EC RID: 21996
		AllowPreserveRatio,
		// Token: 0x040055ED RID: 21997
		AllowPrivateAccess,
		// Token: 0x040055EE RID: 21998
		ArrayClamp,
		// Token: 0x040055EF RID: 21999
		AssetBundles,
		// Token: 0x040055F0 RID: 22000
		BlueprintBaseOnly,
		// Token: 0x040055F1 RID: 22001
		BlueprintCompilerGeneratedDefaults,
		// Token: 0x040055F2 RID: 22002
		ClampMin,
		// Token: 0x040055F3 RID: 22003
		ClampMax,
		// Token: 0x040055F4 RID: 22004
		ConfigHierarchyEditable,
		// Token: 0x040055F5 RID: 22005
		ContentDir,
		// Token: 0x040055F6 RID: 22006
		DeprecatedProperty,
		// Token: 0x040055F7 RID: 22007
		DisallowedClasses,
		// Token: 0x040055F8 RID: 22008
		DisplayAfter,
		// Token: 0x040055F9 RID: 22009
		DisplayPriority,
		// Token: 0x040055FA RID: 22010
		DisplayThumbnail,
		// Token: 0x040055FB RID: 22011
		EditCondition,
		// Token: 0x040055FC RID: 22012
		EditFixedOrder,
		// Token: 0x040055FD RID: 22013
		ExactClass,
		// Token: 0x040055FE RID: 22014
		ExposeFunctionCategories,
		// Token: 0x040055FF RID: 22015
		ExposeOnSpawn,
		// Token: 0x04005600 RID: 22016
		FilePathFilter,
		// Token: 0x04005601 RID: 22017
		RelativeToGameDir,
		// Token: 0x04005602 RID: 22018
		FixedIncrement,
		// Token: 0x04005603 RID: 22019
		ForceShowEngineContent,
		// Token: 0x04005604 RID: 22020
		ForceShowPluginContent,
		// Token: 0x04005605 RID: 22021
		HideAlphaChannel,
		// Token: 0x04005606 RID: 22022
		HideInDetailPanel,
		// Token: 0x04005607 RID: 22023
		HideViewOptions,
		// Token: 0x04005608 RID: 22024
		IgnoreForMemberInitializationTest,
		// Token: 0x04005609 RID: 22025
		InlineEditConditionToggle,
		// Token: 0x0400560A RID: 22026
		LongPackageName,
		// Token: 0x0400560B RID: 22027
		MakeEditWidget,
		// Token: 0x0400560C RID: 22028
		MakeStructureDefaultValue,
		// Token: 0x0400560D RID: 22029
		MetaClass,
		// Token: 0x0400560E RID: 22030
		MustImplement,
		// Token: 0x0400560F RID: 22031
		Multiple,
		// Token: 0x04005610 RID: 22032
		MultiLine,
		// Token: 0x04005611 RID: 22033
		PasswordField,
		// Token: 0x04005612 RID: 22034
		NoElementDuplicate,
		// Token: 0x04005613 RID: 22035
		NoResetToDefault,
		// Token: 0x04005614 RID: 22036
		NoSpinbox,
		// Token: 0x04005615 RID: 22037
		OnlyPlaceable,
		// Token: 0x04005616 RID: 22038
		RelativePath,
		// Token: 0x04005617 RID: 22039
		RelativeToGameContentDir,
		// Token: 0x04005618 RID: 22040
		ScriptNoExport,
		// Token: 0x04005619 RID: 22041
		ShowOnlyInnerProperties,
		// Token: 0x0400561A RID: 22042
		ShowTreeView,
		// Token: 0x0400561B RID: 22043
		SliderExponent,
		// Token: 0x0400561C RID: 22044
		TitleProperty,
		// Token: 0x0400561D RID: 22045
		UIMin,
		// Token: 0x0400561E RID: 22046
		UIMax,
		// Token: 0x0400561F RID: 22047
		Untracked,
		// Token: 0x04005620 RID: 22048
		DevelopmentOnly,
		// Token: 0x04005621 RID: 22049
		NeedsLatentFixup,
		// Token: 0x04005622 RID: 22050
		LatentCallbackTarget,
		// Token: 0x04005623 RID: 22051
		GetOptions,
		// Token: 0x04005624 RID: 22052
		NeverAsPin,
		// Token: 0x04005625 RID: 22053
		PinHiddenByDefault,
		// Token: 0x04005626 RID: 22054
		PinShownByDefault,
		// Token: 0x04005627 RID: 22055
		AlwaysAsPin,
		// Token: 0x04005628 RID: 22056
		CustomizeProperty,
		// Token: 0x04005629 RID: 22057
		OverridingInputProperty,
		// Token: 0x0400562A RID: 22058
		RequiredInput,
		// Token: 0x0400562B RID: 22059
		AdvancedDisplay,
		// Token: 0x0400562C RID: 22060
		ArrayParm,
		// Token: 0x0400562D RID: 22061
		ArrayTypeDependentParams,
		// Token: 0x0400562E RID: 22062
		AutoCreateRefTerm,
		// Token: 0x0400562F RID: 22063
		BlueprintInternalUseOnly,
		// Token: 0x04005630 RID: 22064
		BlueprintProtected,
		// Token: 0x04005631 RID: 22065
		CallableWithoutWorldContext,
		// Token: 0x04005632 RID: 22066
		CommutativeAssociativeBinaryOperator,
		// Token: 0x04005633 RID: 22067
		CompactNodeTitle,
		// Token: 0x04005634 RID: 22068
		CustomStructureParam,
		// Token: 0x04005635 RID: 22069
		DefaultToSelf,
		// Token: 0x04005636 RID: 22070
		DeprecatedFunction,
		// Token: 0x04005637 RID: 22071
		ExpandEnumAsExecs,
		// Token: 0x04005638 RID: 22072
		ExpandBoolAsExecs,
		// Token: 0x04005639 RID: 22073
		ScriptMethod,
		// Token: 0x0400563A RID: 22074
		ScriptMethodSelfReturn,
		// Token: 0x0400563B RID: 22075
		ScriptOperator,
		// Token: 0x0400563C RID: 22076
		ScriptConstant,
		// Token: 0x0400563D RID: 22077
		ScriptConstantHost,
		// Token: 0x0400563E RID: 22078
		HidePin,
		// Token: 0x0400563F RID: 22079
		HideSpawnParms,
		// Token: 0x04005640 RID: 22080
		Keywords,
		// Token: 0x04005641 RID: 22081
		Latent,
		// Token: 0x04005642 RID: 22082
		LatentInfo,
		// Token: 0x04005643 RID: 22083
		MaterialParameterCollectionFunction,
		// Token: 0x04005644 RID: 22084
		NativeBreakFunc,
		// Token: 0x04005645 RID: 22085
		NativeMakeFunc,
		// Token: 0x04005646 RID: 22086
		UnsafeDuringActorConstruction,
		// Token: 0x04005647 RID: 22087
		WorldContext,
		// Token: 0x04005648 RID: 22088
		BlueprintAutocast,
		// Token: 0x04005649 RID: 22089
		NotBlueprintThreadSafe,
		// Token: 0x0400564A RID: 22090
		DeterminesOutputType,
		// Token: 0x0400564B RID: 22091
		DynamicOutputParam,
		// Token: 0x0400564C RID: 22092
		DataTablePin,
		// Token: 0x0400564D RID: 22093
		SetParam,
		// Token: 0x0400564E RID: 22094
		MapParam,
		// Token: 0x0400564F RID: 22095
		MapKeyParam,
		// Token: 0x04005650 RID: 22096
		MapValueParam,
		// Token: 0x04005651 RID: 22097
		Bitmask,
		// Token: 0x04005652 RID: 22098
		BitmaskEnum,
		// Token: 0x04005653 RID: 22099
		Bitflags,
		// Token: 0x04005654 RID: 22100
		UseEnumValuesAsMaskValuesInEditor,
		// Token: 0x04005655 RID: 22101
		AnimBlueprintFunction,
		// Token: 0x04005656 RID: 22102
		ArrayParam,
		// Token: 0x04005657 RID: 22103
		CannotImplementInterfaceInBlueprint,
		// Token: 0x04005658 RID: 22104
		Categories,
		// Token: 0x04005659 RID: 22105
		GameplayTagFilter
	}
}
