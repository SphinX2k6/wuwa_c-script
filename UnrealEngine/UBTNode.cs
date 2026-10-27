using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014D RID: 333
	[UnrealObjectPath("/Script/AIModule.BTNode")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class UBTNode : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x0002205A File Offset: 0x0002025A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTNode._ClassPtr;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00022066 File Offset: 0x00020266
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UBTNode.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0002206D File Offset: 0x0002026D
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00022081 File Offset: 0x00020281
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00022096 File Offset: 0x00020296
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x000220A6 File Offset: 0x000202A6
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000220B7 File Offset: 0x000202B7
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x000220CB File Offset: 0x000202CB
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x000220E0 File Offset: 0x000202E0
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x000220F4 File Offset: 0x000202F4
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

		// Token: 0x06001727 RID: 5927 RVA: 0x00022109 File Offset: 0x00020309
		static UBTNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTNode");
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00022118 File Offset: 0x00020318
		protected UBTNode() : this(BuiltinUtils.AllocNativeUObject(UBTNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00022140 File Offset: 0x00020340
		protected UBTNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000562 RID: 1378
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04000563 RID: 1379
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTNode";

		// Token: 0x04000564 RID: 1380
		private static IntPtr _ClassPtr;

		// Token: 0x04000565 RID: 1381
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000566 RID: 1382
		internal static int __PropertyOffset_NodeName;

		// Token: 0x04000567 RID: 1383
		internal static int __PropertyOffset_NodeId;

		// Token: 0x04000568 RID: 1384
		internal static int __PropertyOffset_TreeAsset;

		// Token: 0x04000569 RID: 1385
		internal static int __PropertyOffset_ParentNode;
	}
}
