using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B3 RID: 179
	[UnrealObjectPath("/Script/AIModule.BTNode")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class UBTNode : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x00015555 File Offset: 0x00013755
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTNode._ClassPtr;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00015561 File Offset: 0x00013761
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UBTNode.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00015568 File Offset: 0x00013768
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x0001557C File Offset: 0x0001377C
		[Nullable(1)]
		public unsafe string NodeName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBTNode.__PropertyOffset_NodeName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBTNode.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00015591 File Offset: 0x00013791
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x000155A1 File Offset: 0x000137A1
		public unsafe int NodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTNode.__PropertyOffset_NodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTNode.__PropertyOffset_NodeId) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x000155B2 File Offset: 0x000137B2
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x000155C6 File Offset: 0x000137C6
		[Nullable(2)]
		public unsafe UBehaviorTree TreeAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + UBTNode.__PropertyOffset_TreeAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTNode.__PropertyOffset_TreeAsset, value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000155DB File Offset: 0x000137DB
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000155EF File Offset: 0x000137EF
		[Nullable(2)]
		public unsafe UBTCompositeNode ParentNode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + UBTNode.__PropertyOffset_ParentNode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTNode.__PropertyOffset_ParentNode, value);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00015604 File Offset: 0x00013804
		static UBTNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTNode");
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00015614 File Offset: 0x00013814
		protected UBTNode() : this(BuiltinUtils.AllocNativeUObject(UBTNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0001563C File Offset: 0x0001383C
		protected UBTNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400026C RID: 620
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x0400026D RID: 621
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTNode";

		// Token: 0x0400026E RID: 622
		private static IntPtr _ClassPtr;

		// Token: 0x0400026F RID: 623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000270 RID: 624
		internal static int __PropertyOffset_NodeName;

		// Token: 0x04000271 RID: 625
		internal static int __PropertyOffset_NodeId;

		// Token: 0x04000272 RID: 626
		internal static int __PropertyOffset_TreeAsset;

		// Token: 0x04000273 RID: 627
		internal static int __PropertyOffset_ParentNode;
	}
}
