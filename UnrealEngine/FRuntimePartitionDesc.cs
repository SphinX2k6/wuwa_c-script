using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B2 RID: 4274
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimePartitionDesc")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRuntimePartitionDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F442 RID: 62530 RVA: 0x0016A3C5 File Offset: 0x001685C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimePartitionDesc._ScriptStructPtr != 0) ? FRuntimePartitionDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimePartitionDesc", ref FRuntimePartitionDesc._ScriptStructPtr);
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600F443 RID: 62531 RVA: 0x0016A3E9 File Offset: 0x001685E9
		// (set) Token: 0x0600F444 RID: 62532 RVA: 0x0016A3FD File Offset: 0x001685FD
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionDesc.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionDesc.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600F445 RID: 62533 RVA: 0x0016A412 File Offset: 0x00168612
		// (set) Token: 0x0600F446 RID: 62534 RVA: 0x0016A426 File Offset: 0x00168626
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<URuntimePartition> Class
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionDesc.__PropertyOffset_Class);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionDesc.__PropertyOffset_Class) = value;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600F447 RID: 62535 RVA: 0x0016A43B File Offset: 0x0016863B
		// (set) Token: 0x0600F448 RID: 62536 RVA: 0x0016A44F File Offset: 0x0016864F
		[Nullable(2)]
		public unsafe URuntimePartition MainLayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimePartition>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionDesc.__PropertyOffset_MainLayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionDesc.__PropertyOffset_MainLayer, value);
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600F449 RID: 62537 RVA: 0x0016A464 File Offset: 0x00168664
		// (set) Token: 0x0600F44A RID: 62538 RVA: 0x0016A4A7 File Offset: 0x001686A7
		public TArray<FRuntimePartitionHLODSetup> HLODSetups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionHLODSetup> result;
				if ((result = this._HLODSetups) == null)
				{
					result = (this._HLODSetups = new TArray<FRuntimePartitionHLODSetup>(base.NativePtr + (IntPtr)FRuntimePartitionDesc.__PropertyOffset_HLODSetups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HLODSetups.CopyAssign(value);
			}
		}

		// Token: 0x0600F44B RID: 62539 RVA: 0x0016A4B5 File Offset: 0x001686B5
		public FRuntimePartitionDesc()
		{
		}

		// Token: 0x0600F44C RID: 62540 RVA: 0x0016A4BD File Offset: 0x001686BD
		public FRuntimePartitionDesc(FName Name, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<URuntimePartition> Class, URuntimePartition MainLayer, TArray<FRuntimePartitionHLODSetup> HLODSetups)
		{
			this.Name = Name;
			this.Class = Class;
			this.MainLayer = MainLayer;
			this.HLODSetups = HLODSetups;
		}

		// Token: 0x0600F44D RID: 62541 RVA: 0x0016A4E2 File Offset: 0x001686E2
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimePartitionDesc.StaticStruct();
		}

		// Token: 0x0600F44E RID: 62542 RVA: 0x0016A4EE File Offset: 0x001686EE
		[NullableContext(2)]
		public FRuntimePartitionDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F44F RID: 62543 RVA: 0x0016A4F8 File Offset: 0x001686F8
		public FRuntimePartitionDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F450 RID: 62544 RVA: 0x0016A503 File Offset: 0x00168703
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimePartitionDesc(Pointer, false, true);
		}

		// Token: 0x0600F451 RID: 62545 RVA: 0x0016A50D File Offset: 0x0016870D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimePartitionDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04008465 RID: 33893
		public const string __ObjectPath = "/Script/Engine.RuntimePartitionDesc";

		// Token: 0x04008466 RID: 33894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008467 RID: 33895
		internal static int __PropertyOffset_Name;

		// Token: 0x04008468 RID: 33896
		internal static int __PropertyOffset_Class;

		// Token: 0x04008469 RID: 33897
		internal static int __PropertyOffset_MainLayer;

		// Token: 0x0400846A RID: 33898
		internal static int __PropertyOffset_HLODSetups;

		// Token: 0x0400846B RID: 33899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionHLODSetup> _HLODSetups;
	}
}
