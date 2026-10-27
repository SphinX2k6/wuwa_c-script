using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011C RID: 284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTreeComponent")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class UBehaviorTreeComponent : UBrainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x0001EA02 File Offset: 0x0001CC02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTreeComponent._ClassPtr;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0001EA10 File Offset: 0x0001CC10
		public UBehaviorTreeComponent() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0001EA38 File Offset: 0x0001CC38
		public UBehaviorTreeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0001EA6C File Offset: 0x0001CC6C
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0001EAA5 File Offset: 0x0001CCA5
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0001EAB3 File Offset: 0x0001CCB3
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0001EAC7 File Offset: 0x0001CCC7
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

		// Token: 0x060014D1 RID: 5329 RVA: 0x0001EADC File Offset: 0x0001CCDC
		[NullableContext(2)]
		public void SetDynamicSubtree(FGameplayTag InjectTag, UBehaviorTree BehaviorAsset)
		{
			UBehaviorTreeComponent.__SetDynamicSubtree_Internal(base.NativePtr, InjectTag, (BehaviorAsset != null) ? BehaviorAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0001EAFA File Offset: 0x0001CCFA
		public float GetTagCooldownEndTime(FGameplayTag CooldownTag)
		{
			return UBehaviorTreeComponent.__GetTagCooldownEndTime_Internal(base.NativePtr, CooldownTag);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0001EB08 File Offset: 0x0001CD08
		public void AddCooldownTagDuration(FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)
		{
			UBehaviorTreeComponent.__AddCooldownTagDuration_Internal(base.NativePtr, CooldownTag, CooldownDuration, bAddToExistingDuration);
		}

		// Token: 0x060014D4 RID: 5332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicSubtree_Internal(IntPtr @this, FGameplayTag InjectTag, IntPtr BehaviorAsset);

		// Token: 0x060014D5 RID: 5333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTagCooldownEndTime_Internal(IntPtr @this, FGameplayTag CooldownTag);

		// Token: 0x060014D6 RID: 5334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCooldownTagDuration_Internal(IntPtr @this, FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration);

		// Token: 0x060014D7 RID: 5335 RVA: 0x0001EB18 File Offset: 0x0001CD18
		static UBehaviorTreeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTreeComponent");
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0001EB26 File Offset: 0x0001CD26
		protected UBehaviorTreeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000449 RID: 1097
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTreeComponent";

		// Token: 0x0400044A RID: 1098
		private static IntPtr _ClassPtr;

		// Token: 0x0400044B RID: 1099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400044C RID: 1100
		internal static int __PropertyOffset_NodeInstances;

		// Token: 0x0400044D RID: 1101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTNode> _NodeInstances;

		// Token: 0x0400044E RID: 1102
		internal static int __PropertyOffset_DefaultBehaviorTreeAsset;
	}
}
