using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136D RID: 4973
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueNotify_Actor")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class AGameplayCueNotify_Actor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060123C3 RID: 74691 RVA: 0x001AC516 File Offset: 0x001AA716
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayCueNotify_Actor._ClassPtr;
		}

		// Token: 0x060123C4 RID: 74692 RVA: 0x001AC524 File Offset: 0x001AA724
		public AGameplayCueNotify_Actor() : this(BuiltinUtils.AllocNativeUObject(AGameplayCueNotify_Actor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060123C5 RID: 74693 RVA: 0x001AC54C File Offset: 0x001AA74C
		[NullableContext(1)]
		public AGameplayCueNotify_Actor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayCueNotify_Actor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x060123C6 RID: 74694 RVA: 0x001AC57F File Offset: 0x001AA77F
		// (set) Token: 0x060123C7 RID: 74695 RVA: 0x001AC58F File Offset: 0x001AA78F
		public unsafe bool bAutoDestroyOnRemove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAutoDestroyOnRemove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAutoDestroyOnRemove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x060123C8 RID: 74696 RVA: 0x001AC5A0 File Offset: 0x001AA7A0
		// (set) Token: 0x060123C9 RID: 74697 RVA: 0x001AC5B0 File Offset: 0x001AA7B0
		public unsafe float AutoDestroyDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_AutoDestroyDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_AutoDestroyDelay) = value;
			}
		}

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x060123CA RID: 74698 RVA: 0x001AC5C1 File Offset: 0x001AA7C1
		// (set) Token: 0x060123CB RID: 74699 RVA: 0x001AC5D1 File Offset: 0x001AA7D1
		public unsafe bool WarnIfTimelineIsStillRunning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_WarnIfTimelineIsStillRunning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_WarnIfTimelineIsStillRunning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x060123CC RID: 74700 RVA: 0x001AC5E2 File Offset: 0x001AA7E2
		// (set) Token: 0x060123CD RID: 74701 RVA: 0x001AC5F2 File Offset: 0x001AA7F2
		public unsafe bool WarnIfLatentActionIsStillRunning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_WarnIfLatentActionIsStillRunning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_WarnIfLatentActionIsStillRunning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x060123CE RID: 74702 RVA: 0x001AC603 File Offset: 0x001AA803
		// (set) Token: 0x060123CF RID: 74703 RVA: 0x001AC617 File Offset: 0x001AA817
		public unsafe FGameplayTag GameplayCueTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_GameplayCueTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_GameplayCueTag) = value;
			}
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x060123D0 RID: 74704 RVA: 0x001AC62C File Offset: 0x001AA82C
		// (set) Token: 0x060123D1 RID: 74705 RVA: 0x001AC640 File Offset: 0x001AA840
		public unsafe FName GameplayCueName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_GameplayCueName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_GameplayCueName) = value;
			}
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x060123D2 RID: 74706 RVA: 0x001AC655 File Offset: 0x001AA855
		// (set) Token: 0x060123D3 RID: 74707 RVA: 0x001AC665 File Offset: 0x001AA865
		public unsafe bool bAutoAttachToOwner
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAutoAttachToOwner) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAutoAttachToOwner) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x060123D4 RID: 74708 RVA: 0x001AC676 File Offset: 0x001AA876
		// (set) Token: 0x060123D5 RID: 74709 RVA: 0x001AC686 File Offset: 0x001AA886
		public unsafe bool IsOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_IsOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_IsOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x060123D6 RID: 74710 RVA: 0x001AC697 File Offset: 0x001AA897
		// (set) Token: 0x060123D7 RID: 74711 RVA: 0x001AC6A7 File Offset: 0x001AA8A7
		public unsafe bool bUniqueInstancePerInstigator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bUniqueInstancePerInstigator) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bUniqueInstancePerInstigator) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x060123D8 RID: 74712 RVA: 0x001AC6B8 File Offset: 0x001AA8B8
		// (set) Token: 0x060123D9 RID: 74713 RVA: 0x001AC6C8 File Offset: 0x001AA8C8
		public unsafe bool bUniqueInstancePerSourceObject
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bUniqueInstancePerSourceObject) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bUniqueInstancePerSourceObject) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x060123DA RID: 74714 RVA: 0x001AC6D9 File Offset: 0x001AA8D9
		// (set) Token: 0x060123DB RID: 74715 RVA: 0x001AC6E9 File Offset: 0x001AA8E9
		public unsafe bool bAllowMultipleOnActiveEvents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAllowMultipleOnActiveEvents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAllowMultipleOnActiveEvents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x060123DC RID: 74716 RVA: 0x001AC6FA File Offset: 0x001AA8FA
		// (set) Token: 0x060123DD RID: 74717 RVA: 0x001AC70A File Offset: 0x001AA90A
		public unsafe bool bAllowMultipleWhileActiveEvents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAllowMultipleWhileActiveEvents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_bAllowMultipleWhileActiveEvents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x060123DE RID: 74718 RVA: 0x001AC71B File Offset: 0x001AA91B
		// (set) Token: 0x060123DF RID: 74719 RVA: 0x001AC72B File Offset: 0x001AA92B
		public unsafe int NumPreallocatedInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_NumPreallocatedInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayCueNotify_Actor.__PropertyOffset_NumPreallocatedInstances) = value;
			}
		}

		// Token: 0x060123E0 RID: 74720 RVA: 0x001AC73C File Offset: 0x001AA93C
		public virtual bool WhileActive(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__WhileActive_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E1 RID: 74721 RVA: 0x001AC769 File Offset: 0x001AA969
		protected virtual bool WhileActive_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__WhileActive_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E2 RID: 74722 RVA: 0x001AC796 File Offset: 0x001AA996
		public virtual bool OnRemove(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnRemove_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E3 RID: 74723 RVA: 0x001AC7C3 File Offset: 0x001AA9C3
		protected virtual bool OnRemove_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnRemove_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E4 RID: 74724 RVA: 0x001AC7F0 File Offset: 0x001AA9F0
		public void OnOwnerDestroyed(AActor DestroyedActor)
		{
			AGameplayCueNotify_Actor.__OnOwnerDestroyed_Internal(base.NativePtr, (DestroyedActor != null) ? DestroyedActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060123E5 RID: 74725 RVA: 0x001AC80D File Offset: 0x001AAA0D
		public virtual bool OnExecute(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnExecute_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E6 RID: 74726 RVA: 0x001AC83A File Offset: 0x001AAA3A
		protected virtual bool OnExecute_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnExecute_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E7 RID: 74727 RVA: 0x001AC867 File Offset: 0x001AAA67
		public virtual bool OnActive(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnActive_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E8 RID: 74728 RVA: 0x001AC894 File Offset: 0x001AAA94
		protected virtual bool OnActive_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return AGameplayCueNotify_Actor.__OnActive_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123E9 RID: 74729 RVA: 0x001AC8C1 File Offset: 0x001AAAC1
		public virtual void K2_HandleGameplayCue(AActor MyTarget, EGameplayCueEvent EventType, in FGameplayCueParameters Parameters)
		{
			AGameplayCueNotify_Actor.__K2_HandleGameplayCue_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, EventType, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x060123EA RID: 74730 RVA: 0x001AC8F4 File Offset: 0x001AAAF4
		public void K2_EndGameplayCue()
		{
			AGameplayCueNotify_Actor.__K2_EndGameplayCue_Internal(base.NativePtr);
		}

		// Token: 0x060123EB RID: 74731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WhileActive_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123EC RID: 74732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WhileActive_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123ED RID: 74733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnRemove_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123EE RID: 74734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnRemove_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123EF RID: 74735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnOwnerDestroyed_Internal(IntPtr @this, IntPtr DestroyedActor);

		// Token: 0x060123F0 RID: 74736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnExecute_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123F1 RID: 74737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnExecute_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123F2 RID: 74738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnActive_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123F3 RID: 74739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnActive_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x060123F4 RID: 74740
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_HandleGameplayCue_Internal(IntPtr @this, IntPtr MyTarget, TEnumAsByte<EGameplayCueEvent> EventType, IntPtr Parameters);

		// Token: 0x060123F5 RID: 74741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_EndGameplayCue_Internal(IntPtr @this);

		// Token: 0x060123F6 RID: 74742 RVA: 0x001AC901 File Offset: 0x001AAB01
		static AGameplayCueNotify_Actor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueNotify_Actor");
		}

		// Token: 0x060123F7 RID: 74743 RVA: 0x001AC90F File Offset: 0x001AAB0F
		protected AGameplayCueNotify_Actor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C42 RID: 40002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueNotify_Actor";

		// Token: 0x04009C43 RID: 40003
		private static IntPtr _ClassPtr;

		// Token: 0x04009C44 RID: 40004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C45 RID: 40005
		internal static int __PropertyOffset_bAutoDestroyOnRemove;

		// Token: 0x04009C46 RID: 40006
		internal static int __PropertyOffset_AutoDestroyDelay;

		// Token: 0x04009C47 RID: 40007
		internal static int __PropertyOffset_WarnIfTimelineIsStillRunning;

		// Token: 0x04009C48 RID: 40008
		internal static int __PropertyOffset_WarnIfLatentActionIsStillRunning;

		// Token: 0x04009C49 RID: 40009
		internal static int __PropertyOffset_GameplayCueTag;

		// Token: 0x04009C4A RID: 40010
		internal static int __PropertyOffset_GameplayCueName;

		// Token: 0x04009C4B RID: 40011
		internal static int __PropertyOffset_bAutoAttachToOwner;

		// Token: 0x04009C4C RID: 40012
		internal static int __PropertyOffset_IsOverride;

		// Token: 0x04009C4D RID: 40013
		internal static int __PropertyOffset_bUniqueInstancePerInstigator;

		// Token: 0x04009C4E RID: 40014
		internal static int __PropertyOffset_bUniqueInstancePerSourceObject;

		// Token: 0x04009C4F RID: 40015
		internal static int __PropertyOffset_bAllowMultipleOnActiveEvents;

		// Token: 0x04009C50 RID: 40016
		internal static int __PropertyOffset_bAllowMultipleWhileActiveEvents;

		// Token: 0x04009C51 RID: 40017
		internal static int __PropertyOffset_NumPreallocatedInstances;

		// Token: 0x02002E33 RID: 11827
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __WhileActive_FunctionParams
		{
			// Token: 0x040168D1 RID: 92369
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168D2 RID: 92370
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168D3 RID: 92371
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E34 RID: 11828
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnRemove_FunctionParams
		{
			// Token: 0x040168D4 RID: 92372
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168D5 RID: 92373
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168D6 RID: 92374
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E35 RID: 11829
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnExecute_FunctionParams
		{
			// Token: 0x040168D7 RID: 92375
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168D8 RID: 92376
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168D9 RID: 92377
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E36 RID: 11830
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnActive_FunctionParams
		{
			// Token: 0x040168DA RID: 92378
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168DB RID: 92379
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168DC RID: 92380
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E37 RID: 11831
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __K2_HandleGameplayCue_FunctionParams
		{
			// Token: 0x040168DD RID: 92381
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168DE RID: 92382
			[FieldOffset(8)]
			public TEnumAsByte<EGameplayCueEvent> EventType;

			// Token: 0x040168DF RID: 92383
			[FieldOffset(16)]
			public byte Parameters;
		}
	}
}
