using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTreeComponent")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class UBehaviorTreeComponent : UBrainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D11 RID: 3345 RVA: 0x00014C2A File Offset: 0x00012E2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTreeComponent._ClassPtr;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00014C38 File Offset: 0x00012E38
		public UBehaviorTreeComponent() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00014C60 File Offset: 0x00012E60
		public UBehaviorTreeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00014C94 File Offset: 0x00012E94
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00014CCD File Offset: 0x00012ECD
		public TArray<UBTNode> NodeInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTNode> result;
				if ((result = this._NodeInstances) == null)
				{
					result = (this._NodeInstances = new TArray<UBTNode>(base.NativePtr + (IntPtr)UBehaviorTreeComponent.__PropertyOffset_NodeInstances, this));
				}
				return result;
			}
			set
			{
				this.NodeInstances.CopyAssign(value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00014CDB File Offset: 0x00012EDB
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00014CEF File Offset: 0x00012EEF
		[Nullable(2)]
		public unsafe UBehaviorTree DefaultBehaviorTreeAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTreeComponent.__PropertyOffset_DefaultBehaviorTreeAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTreeComponent.__PropertyOffset_DefaultBehaviorTreeAsset, value);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00014D04 File Offset: 0x00012F04
		[NullableContext(2)]
		public void SetDynamicSubtree(FGameplayTag InjectTag, UBehaviorTree BehaviorAsset)
		{
			UBehaviorTreeComponent.__SetDynamicSubtree_Internal(base.NativePtr, InjectTag, (BehaviorAsset != null) ? BehaviorAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00014D22 File Offset: 0x00012F22
		public float GetTagCooldownEndTime(FGameplayTag CooldownTag)
		{
			return UBehaviorTreeComponent.__GetTagCooldownEndTime_Internal(base.NativePtr, CooldownTag);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00014D30 File Offset: 0x00012F30
		public void AddCooldownTagDuration(FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)
		{
			UBehaviorTreeComponent.__AddCooldownTagDuration_Internal(base.NativePtr, CooldownTag, CooldownDuration, bAddToExistingDuration);
		}

		// Token: 0x06000D1B RID: 3355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicSubtree_Internal(IntPtr @this, FGameplayTag InjectTag, IntPtr BehaviorAsset);

		// Token: 0x06000D1C RID: 3356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTagCooldownEndTime_Internal(IntPtr @this, FGameplayTag CooldownTag);

		// Token: 0x06000D1D RID: 3357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCooldownTagDuration_Internal(IntPtr @this, FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration);

		// Token: 0x06000D1E RID: 3358 RVA: 0x00014D40 File Offset: 0x00012F40
		static UBehaviorTreeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTreeComponent");
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00014D4E File Offset: 0x00012F4E
		protected UBehaviorTreeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400023C RID: 572
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTreeComponent";

		// Token: 0x0400023D RID: 573
		private static IntPtr _ClassPtr;

		// Token: 0x0400023E RID: 574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400023F RID: 575
		internal static int __PropertyOffset_NodeInstances;

		// Token: 0x04000240 RID: 576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTNode> _NodeInstances;

		// Token: 0x04000241 RID: 577
		internal static int __PropertyOffset_DefaultBehaviorTreeAsset;
	}
}
