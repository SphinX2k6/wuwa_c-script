using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010BC RID: 4284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyCondition")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRuntimePartitionPolicyCondition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F487 RID: 62599 RVA: 0x0016A9D2 File Offset: 0x00168BD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimePartitionPolicyCondition._ScriptStructPtr != 0) ? FRuntimePartitionPolicyCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimePartitionPolicyCondition", ref FRuntimePartitionPolicyCondition._ScriptStructPtr);
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600F488 RID: 62600 RVA: 0x0016A9F6 File Offset: 0x00168BF6
		// (set) Token: 0x0600F489 RID: 62601 RVA: 0x0016AA06 File Offset: 0x00168C06
		public unsafe bool bInvert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_bInvert) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_bInvert) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600F48A RID: 62602 RVA: 0x0016AA17 File Offset: 0x00168C17
		// (set) Token: 0x0600F48B RID: 62603 RVA: 0x0016AA2B File Offset: 0x00168C2B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_ActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_ActorClass) = value;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600F48C RID: 62604 RVA: 0x0016AA40 File Offset: 0x00168C40
		// (set) Token: 0x0600F48D RID: 62605 RVA: 0x0016AA54 File Offset: 0x00168C54
		public unsafe string Property
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_Property)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_Property)), value);
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600F48E RID: 62606 RVA: 0x0016AA69 File Offset: 0x00168C69
		// (set) Token: 0x0600F48F RID: 62607 RVA: 0x0016AA7D File Offset: 0x00168C7D
		public unsafe string PathRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_PathRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_PathRegex)), value);
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600F490 RID: 62608 RVA: 0x0016AA92 File Offset: 0x00168C92
		// (set) Token: 0x0600F491 RID: 62609 RVA: 0x0016AAA6 File Offset: 0x00168CA6
		public unsafe string MeshTypeFilter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_MeshTypeFilter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRuntimePartitionPolicyCondition.__PropertyOffset_MeshTypeFilter)), value);
			}
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x0016AABB File Offset: 0x00168CBB
		public FRuntimePartitionPolicyCondition()
		{
		}

		// Token: 0x0600F493 RID: 62611 RVA: 0x0016AAC3 File Offset: 0x00168CC3
		public FRuntimePartitionPolicyCondition(bool bInvert, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, string Property, string PathRegex, string MeshTypeFilter)
		{
			this.bInvert = bInvert;
			this.ActorClass = ActorClass;
			this.Property = Property;
			this.PathRegex = PathRegex;
			this.MeshTypeFilter = MeshTypeFilter;
		}

		// Token: 0x0600F494 RID: 62612 RVA: 0x0016AAF0 File Offset: 0x00168CF0
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimePartitionPolicyCondition.StaticStruct();
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x0016AAFC File Offset: 0x00168CFC
		[NullableContext(2)]
		public FRuntimePartitionPolicyCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x0016AB06 File Offset: 0x00168D06
		public FRuntimePartitionPolicyCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F497 RID: 62615 RVA: 0x0016AB11 File Offset: 0x00168D11
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimePartitionPolicyCondition(Pointer, false, true);
		}

		// Token: 0x0600F498 RID: 62616 RVA: 0x0016AB1B File Offset: 0x00168D1B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimePartitionPolicyCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04008489 RID: 33929
		public const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyCondition";

		// Token: 0x0400848A RID: 33930
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400848B RID: 33931
		internal static int __PropertyOffset_bInvert;

		// Token: 0x0400848C RID: 33932
		internal static int __PropertyOffset_ActorClass;

		// Token: 0x0400848D RID: 33933
		internal static int __PropertyOffset_Property;

		// Token: 0x0400848E RID: 33934
		internal static int __PropertyOffset_PathRegex;

		// Token: 0x0400848F RID: 33935
		internal static int __PropertyOffset_MeshTypeFilter;
	}
}
