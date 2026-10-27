using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200131D RID: 4893
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayCueContainer")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FActiveGameplayCueContainer : FFastArraySerializer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012070 RID: 73840 RVA: 0x001A784A File Offset: 0x001A5A4A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayCueContainer._ScriptStructPtr != 0) ? FActiveGameplayCueContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayCueContainer", ref FActiveGameplayCueContainer._ScriptStructPtr);
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x06012071 RID: 73841 RVA: 0x001A7870 File Offset: 0x001A5A70
		// (set) Token: 0x06012072 RID: 73842 RVA: 0x001A78B3 File Offset: 0x001A5AB3
		public TArray<FActiveGameplayCue> GameplayCues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActiveGameplayCue> result;
				if ((result = this._GameplayCues) == null)
				{
					result = (this._GameplayCues = new TArray<FActiveGameplayCue>(base.NativePtr + (IntPtr)FActiveGameplayCueContainer.__PropertyOffset_GameplayCues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GameplayCues.CopyAssign(value);
			}
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x06012073 RID: 73843 RVA: 0x001A78C1 File Offset: 0x001A5AC1
		// (set) Token: 0x06012074 RID: 73844 RVA: 0x001A78D5 File Offset: 0x001A5AD5
		[Nullable(2)]
		public unsafe UAbilitySystemComponent Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FActiveGameplayCueContainer.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActiveGameplayCueContainer.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06012075 RID: 73845 RVA: 0x001A78EA File Offset: 0x001A5AEA
		public FActiveGameplayCueContainer()
		{
		}

		// Token: 0x06012076 RID: 73846 RVA: 0x001A78F2 File Offset: 0x001A5AF2
		public FActiveGameplayCueContainer(TArray<FActiveGameplayCue> GameplayCues, UAbilitySystemComponent Owner, int ArrayReplicationKey, EFastArraySerializerDeltaFlags DeltaFlags)
		{
			this.GameplayCues = GameplayCues;
			this.Owner = Owner;
			base.ArrayReplicationKey = ArrayReplicationKey;
			base.DeltaFlags = DeltaFlags;
		}

		// Token: 0x06012077 RID: 73847 RVA: 0x001A7917 File Offset: 0x001A5B17
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayCueContainer.StaticStruct();
		}

		// Token: 0x06012078 RID: 73848 RVA: 0x001A7923 File Offset: 0x001A5B23
		[NullableContext(2)]
		public FActiveGameplayCueContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012079 RID: 73849 RVA: 0x001A792D File Offset: 0x001A5B2D
		public FActiveGameplayCueContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601207A RID: 73850 RVA: 0x001A7938 File Offset: 0x001A5B38
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayCueContainer(Pointer, false, true);
		}

		// Token: 0x0601207B RID: 73851 RVA: 0x001A7942 File Offset: 0x001A5B42
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayCueContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009A16 RID: 39446
		public new const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayCueContainer";

		// Token: 0x04009A17 RID: 39447
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A18 RID: 39448
		internal static int __PropertyOffset_GameplayCues;

		// Token: 0x04009A19 RID: 39449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveGameplayCue> _GameplayCues;

		// Token: 0x04009A1A RID: 39450
		internal static int __PropertyOffset_Owner;
	}
}
