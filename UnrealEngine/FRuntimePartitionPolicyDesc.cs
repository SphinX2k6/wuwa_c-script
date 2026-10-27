using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010BD RID: 4285
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyDesc")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRuntimePartitionPolicyDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F499 RID: 62617 RVA: 0x0016AB24 File Offset: 0x00168D24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimePartitionPolicyDesc._ScriptStructPtr != 0) ? FRuntimePartitionPolicyDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimePartitionPolicyDesc", ref FRuntimePartitionPolicyDesc._ScriptStructPtr);
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600F49A RID: 62618 RVA: 0x0016AB48 File Offset: 0x00168D48
		// (set) Token: 0x0600F49B RID: 62619 RVA: 0x0016AB5C File Offset: 0x00168D5C
		public unsafe FName PolicyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyName) = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600F49C RID: 62620 RVA: 0x0016AB71 File Offset: 0x00168D71
		// (set) Token: 0x0600F49D RID: 62621 RVA: 0x0016AB85 File Offset: 0x00168D85
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<URuntimePartitionPolicy> PolicyClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyClass) = value;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600F49E RID: 62622 RVA: 0x0016AB9A File Offset: 0x00168D9A
		// (set) Token: 0x0600F49F RID: 62623 RVA: 0x0016ABAE File Offset: 0x00168DAE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<URuntimePartition> RuntimePartitionClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_RuntimePartitionClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_RuntimePartitionClass) = value;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600F4A0 RID: 62624 RVA: 0x0016ABC3 File Offset: 0x00168DC3
		// (set) Token: 0x0600F4A1 RID: 62625 RVA: 0x0016ABD7 File Offset: 0x00168DD7
		[Nullable(2)]
		public unsafe URuntimePartitionPolicy PolicyLayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimePartitionPolicy>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyLayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionPolicyDesc.__PropertyOffset_PolicyLayer, value);
			}
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x0016ABEC File Offset: 0x00168DEC
		// (set) Token: 0x0600F4A3 RID: 62627 RVA: 0x0016ABFC File Offset: 0x00168DFC
		public unsafe bool bIsEditorOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_bIsEditorOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionPolicyDesc.__PropertyOffset_bIsEditorOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x0016AC0D File Offset: 0x00168E0D
		public FRuntimePartitionPolicyDesc()
		{
		}

		// Token: 0x0600F4A5 RID: 62629 RVA: 0x0016AC15 File Offset: 0x00168E15
		[NullableContext(1)]
		public FRuntimePartitionPolicyDesc(FName PolicyName, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<URuntimePartitionPolicy> PolicyClass, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<URuntimePartition> RuntimePartitionClass, URuntimePartitionPolicy PolicyLayer, bool bIsEditorOnly)
		{
			this.PolicyName = PolicyName;
			this.PolicyClass = PolicyClass;
			this.RuntimePartitionClass = RuntimePartitionClass;
			this.PolicyLayer = PolicyLayer;
			this.bIsEditorOnly = bIsEditorOnly;
		}

		// Token: 0x0600F4A6 RID: 62630 RVA: 0x0016AC42 File Offset: 0x00168E42
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimePartitionPolicyDesc.StaticStruct();
		}

		// Token: 0x0600F4A7 RID: 62631 RVA: 0x0016AC4E File Offset: 0x00168E4E
		[NullableContext(2)]
		public FRuntimePartitionPolicyDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F4A8 RID: 62632 RVA: 0x0016AC58 File Offset: 0x00168E58
		public FRuntimePartitionPolicyDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x0016AC63 File Offset: 0x00168E63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimePartitionPolicyDesc(Pointer, false, true);
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x0016AC6D File Offset: 0x00168E6D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimePartitionPolicyDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04008490 RID: 33936
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyDesc";

		// Token: 0x04008491 RID: 33937
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008492 RID: 33938
		internal static int __PropertyOffset_PolicyName;

		// Token: 0x04008493 RID: 33939
		internal static int __PropertyOffset_PolicyClass;

		// Token: 0x04008494 RID: 33940
		internal static int __PropertyOffset_RuntimePartitionClass;

		// Token: 0x04008495 RID: 33941
		internal static int __PropertyOffset_PolicyLayer;

		// Token: 0x04008496 RID: 33942
		internal static int __PropertyOffset_bIsEditorOnly;
	}
}
