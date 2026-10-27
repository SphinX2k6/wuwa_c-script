using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013D RID: 317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_CheckGameplayTagsOnActor")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UBTDecorator_CheckGameplayTagsOnActor : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x00020B09 File Offset: 0x0001ED09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_CheckGameplayTagsOnActor._ClassPtr;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00020B18 File Offset: 0x0001ED18
		public UBTDecorator_CheckGameplayTagsOnActor() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_CheckGameplayTagsOnActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00020B40 File Offset: 0x0001ED40
		public UBTDecorator_CheckGameplayTagsOnActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_CheckGameplayTagsOnActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00020B74 File Offset: 0x0001ED74
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00020BAD File Offset: 0x0001EDAD
		public FBlackboardKeySelector ActorToCheck
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._ActorToCheck) == null)
				{
					result = (this._ActorToCheck = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_ActorToCheck, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_ActorToCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00020BCE File Offset: 0x0001EDCE
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00020BDE File Offset: 0x0001EDDE
		public unsafe EGameplayContainerMatchType TagsToMatch
		{
			get
			{
				return (EGameplayContainerMatchType)(*(base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_TagsToMatch));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_TagsToMatch) = (byte)value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00020C29 File Offset: 0x0001EE29
		public FGameplayTagContainer GameplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._GameplayTags) == null)
				{
					result = (this._GameplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_GameplayTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_GameplayTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00020C4A File Offset: 0x0001EE4A
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00020C5E File Offset: 0x0001EE5E
		public unsafe string CachedDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_CachedDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_CheckGameplayTagsOnActor.__PropertyOffset_CachedDescription)), value);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00020C73 File Offset: 0x0001EE73
		static UBTDecorator_CheckGameplayTagsOnActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_CheckGameplayTagsOnActor");
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00020C81 File Offset: 0x0001EE81
		protected UBTDecorator_CheckGameplayTagsOnActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004F8 RID: 1272
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_CheckGameplayTagsOnActor";

		// Token: 0x040004F9 RID: 1273
		private static IntPtr _ClassPtr;

		// Token: 0x040004FA RID: 1274
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004FB RID: 1275
		internal static int __PropertyOffset_ActorToCheck;

		// Token: 0x040004FC RID: 1276
		[Nullable(2)]
		private FBlackboardKeySelector _ActorToCheck;

		// Token: 0x040004FD RID: 1277
		internal static int __PropertyOffset_TagsToMatch;

		// Token: 0x040004FE RID: 1278
		internal static int __PropertyOffset_GameplayTags;

		// Token: 0x040004FF RID: 1279
		[Nullable(2)]
		private FGameplayTagContainer _GameplayTags;

		// Token: 0x04000500 RID: 1280
		internal static int __PropertyOffset_CachedDescription;
	}
}
