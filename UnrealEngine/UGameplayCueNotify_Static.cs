using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136F RID: 4975
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueNotify_Static")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGameplayCueNotify_Static : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012401 RID: 74753 RVA: 0x001AC9E8 File Offset: 0x001AABE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueNotify_Static._ClassPtr;
		}

		// Token: 0x06012402 RID: 74754 RVA: 0x001AC9F4 File Offset: 0x001AABF4
		public UGameplayCueNotify_Static() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueNotify_Static.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012403 RID: 74755 RVA: 0x001ACA1C File Offset: 0x001AAC1C
		[NullableContext(1)]
		public UGameplayCueNotify_Static(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayCueNotify_Static.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x06012404 RID: 74756 RVA: 0x001ACA4F File Offset: 0x001AAC4F
		// (set) Token: 0x06012405 RID: 74757 RVA: 0x001ACA63 File Offset: 0x001AAC63
		public unsafe FGameplayTag GameplayCueTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_GameplayCueTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_GameplayCueTag) = value;
			}
		}

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x06012406 RID: 74758 RVA: 0x001ACA78 File Offset: 0x001AAC78
		// (set) Token: 0x06012407 RID: 74759 RVA: 0x001ACA8C File Offset: 0x001AAC8C
		public unsafe FName GameplayCueName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_GameplayCueName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_GameplayCueName) = value;
			}
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06012408 RID: 74760 RVA: 0x001ACAA1 File Offset: 0x001AACA1
		// (set) Token: 0x06012409 RID: 74761 RVA: 0x001ACAB1 File Offset: 0x001AACB1
		public unsafe bool IsOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_IsOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayCueNotify_Static.__PropertyOffset_IsOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601240A RID: 74762 RVA: 0x001ACAC2 File Offset: 0x001AACC2
		[NullableContext(2)]
		public virtual bool WhileActive(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__WhileActive_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x0601240B RID: 74763 RVA: 0x001ACAEF File Offset: 0x001AACEF
		[NullableContext(2)]
		protected virtual bool WhileActive_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__WhileActive_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x0601240C RID: 74764 RVA: 0x001ACB1C File Offset: 0x001AAD1C
		[NullableContext(2)]
		public virtual bool OnRemove(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnRemove_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x0601240D RID: 74765 RVA: 0x001ACB49 File Offset: 0x001AAD49
		[NullableContext(2)]
		protected virtual bool OnRemove_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnRemove_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x0601240E RID: 74766 RVA: 0x001ACB76 File Offset: 0x001AAD76
		[NullableContext(2)]
		public virtual bool OnExecute(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnExecute_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x0601240F RID: 74767 RVA: 0x001ACBA3 File Offset: 0x001AADA3
		[NullableContext(2)]
		protected virtual bool OnExecute_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnExecute_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06012410 RID: 74768 RVA: 0x001ACBD0 File Offset: 0x001AADD0
		[NullableContext(2)]
		public virtual bool OnActive(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnActive_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06012411 RID: 74769 RVA: 0x001ACBFD File Offset: 0x001AADFD
		[NullableContext(2)]
		protected virtual bool OnActive_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			return UGameplayCueNotify_Static.__OnActive_Implementation_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06012412 RID: 74770 RVA: 0x001ACC2A File Offset: 0x001AAE2A
		[NullableContext(2)]
		public virtual void K2_HandleGameplayCue(AActor MyTarget, EGameplayCueEvent EventType, in FGameplayCueParameters Parameters)
		{
			UGameplayCueNotify_Static.__K2_HandleGameplayCue_Internal(base.NativePtr, (MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero, EventType, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06012413 RID: 74771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WhileActive_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012414 RID: 74772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WhileActive_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012415 RID: 74773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnRemove_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012416 RID: 74774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnRemove_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012417 RID: 74775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnExecute_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012418 RID: 74776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnExecute_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x06012419 RID: 74777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnActive_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x0601241A RID: 74778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnActive_Implementation_Internal(IntPtr @this, IntPtr MyTarget, IntPtr Parameters);

		// Token: 0x0601241B RID: 74779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_HandleGameplayCue_Internal(IntPtr @this, IntPtr MyTarget, TEnumAsByte<EGameplayCueEvent> EventType, IntPtr Parameters);

		// Token: 0x0601241C RID: 74780 RVA: 0x001ACC5D File Offset: 0x001AAE5D
		static UGameplayCueNotify_Static()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueNotify_Static");
		}

		// Token: 0x0601241D RID: 74781 RVA: 0x001ACC6B File Offset: 0x001AAE6B
		protected UGameplayCueNotify_Static(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C57 RID: 40023
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueNotify_Static";

		// Token: 0x04009C58 RID: 40024
		private static IntPtr _ClassPtr;

		// Token: 0x04009C59 RID: 40025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C5A RID: 40026
		internal static int __PropertyOffset_GameplayCueTag;

		// Token: 0x04009C5B RID: 40027
		internal static int __PropertyOffset_GameplayCueName;

		// Token: 0x04009C5C RID: 40028
		internal static int __PropertyOffset_IsOverride;

		// Token: 0x02002E38 RID: 11832
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __WhileActive_FunctionParams
		{
			// Token: 0x040168E0 RID: 92384
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168E1 RID: 92385
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168E2 RID: 92386
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E39 RID: 11833
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnRemove_FunctionParams
		{
			// Token: 0x040168E3 RID: 92387
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168E4 RID: 92388
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168E5 RID: 92389
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E3A RID: 11834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnExecute_FunctionParams
		{
			// Token: 0x040168E6 RID: 92390
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168E7 RID: 92391
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168E8 RID: 92392
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E3B RID: 11835
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __OnActive_FunctionParams
		{
			// Token: 0x040168E9 RID: 92393
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168EA RID: 92394
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x040168EB RID: 92395
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x02002E3C RID: 11836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __K2_HandleGameplayCue_FunctionParams
		{
			// Token: 0x040168EC RID: 92396
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x040168ED RID: 92397
			[FieldOffset(8)]
			public TEnumAsByte<EGameplayCueEvent> EventType;

			// Token: 0x040168EE RID: 92398
			[FieldOffset(16)]
			public byte Parameters;
		}
	}
}
