using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008EE RID: 2286
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BPVariableMetaDataEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBPVariableMetaDataEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D6D RID: 32109 RVA: 0x000B3CA0 File Offset: 0x000B1EA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBPVariableMetaDataEntry._ScriptStructPtr != 0) ? FBPVariableMetaDataEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BPVariableMetaDataEntry", ref FBPVariableMetaDataEntry._ScriptStructPtr);
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x000B3CC4 File Offset: 0x000B1EC4
		// (set) Token: 0x06007D6F RID: 32111 RVA: 0x000B3CD8 File Offset: 0x000B1ED8
		public unsafe FName DataKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPVariableMetaDataEntry.__PropertyOffset_DataKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableMetaDataEntry.__PropertyOffset_DataKey) = value;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06007D70 RID: 32112 RVA: 0x000B3CED File Offset: 0x000B1EED
		// (set) Token: 0x06007D71 RID: 32113 RVA: 0x000B3D01 File Offset: 0x000B1F01
		public unsafe string DataValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableMetaDataEntry.__PropertyOffset_DataValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableMetaDataEntry.__PropertyOffset_DataValue)), value);
			}
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x000B3D16 File Offset: 0x000B1F16
		public FBPVariableMetaDataEntry()
		{
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x000B3D1E File Offset: 0x000B1F1E
		public FBPVariableMetaDataEntry(FName DataKey, string DataValue)
		{
			this.DataKey = DataKey;
			this.DataValue = DataValue;
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x000B3D34 File Offset: 0x000B1F34
		protected override IntPtr GetUStructPtr()
		{
			return FBPVariableMetaDataEntry.StaticStruct();
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x000B3D40 File Offset: 0x000B1F40
		[NullableContext(2)]
		public FBPVariableMetaDataEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x000B3D4A File Offset: 0x000B1F4A
		public FBPVariableMetaDataEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x000B3D55 File Offset: 0x000B1F55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBPVariableMetaDataEntry(Pointer, false, true);
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x000B3D5F File Offset: 0x000B1F5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBPVariableMetaDataEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04003C1B RID: 15387
		public const string __ObjectPath = "/Script/Engine.BPVariableMetaDataEntry";

		// Token: 0x04003C1C RID: 15388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C1D RID: 15389
		internal static int __PropertyOffset_DataKey;

		// Token: 0x04003C1E RID: 15390
		internal static int __PropertyOffset_DataValue;
	}
}
