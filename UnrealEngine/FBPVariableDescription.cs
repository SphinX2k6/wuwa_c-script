using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008ED RID: 2285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BPVariableDescription")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FBPVariableDescription : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D51 RID: 32081 RVA: 0x000B39AB File Offset: 0x000B1BAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBPVariableDescription._ScriptStructPtr != 0) ? FBPVariableDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BPVariableDescription", ref FBPVariableDescription._ScriptStructPtr);
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06007D52 RID: 32082 RVA: 0x000B39CF File Offset: 0x000B1BCF
		// (set) Token: 0x06007D53 RID: 32083 RVA: 0x000B39E3 File Offset: 0x000B1BE3
		public unsafe FName VarName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarName) = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06007D54 RID: 32084 RVA: 0x000B39F8 File Offset: 0x000B1BF8
		// (set) Token: 0x06007D55 RID: 32085 RVA: 0x000B3A0C File Offset: 0x000B1C0C
		public unsafe FGuid VarGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarGuid) = value;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x000B3A24 File Offset: 0x000B1C24
		// (set) Token: 0x06007D57 RID: 32087 RVA: 0x000B3A67 File Offset: 0x000B1C67
		public FEdGraphPinType VarType
		{
			get
			{
				base.FastCheckIsValid();
				FEdGraphPinType result;
				if ((result = this._VarType) == null)
				{
					result = (this._VarType = new FEdGraphPinType(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEdGraphPinType.StaticStruct(), base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_VarType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x000B3A88 File Offset: 0x000B1C88
		// (set) Token: 0x06007D59 RID: 32089 RVA: 0x000B3A9C File Offset: 0x000B1C9C
		public unsafe string FriendlyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableDescription.__PropertyOffset_FriendlyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableDescription.__PropertyOffset_FriendlyName)), value);
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
		// (set) Token: 0x06007D5B RID: 32091 RVA: 0x000B3AF7 File Offset: 0x000B1CF7
		public unsafe FText Category
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Category) == null)
				{
					result = (this._Category = new FText(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_Category, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableDescription.__PropertyOffset_Category)), value.NativePtr, 1);
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06007D5C RID: 32092 RVA: 0x000B3B12 File Offset: 0x000B1D12
		// (set) Token: 0x06007D5D RID: 32093 RVA: 0x000B3B22 File Offset: 0x000B1D22
		public unsafe ulong PropertyFlags
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_PropertyFlags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_PropertyFlags) = (long)value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06007D5E RID: 32094 RVA: 0x000B3B33 File Offset: 0x000B1D33
		// (set) Token: 0x06007D5F RID: 32095 RVA: 0x000B3B47 File Offset: 0x000B1D47
		public unsafe FName RepNotifyFunc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_RepNotifyFunc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_RepNotifyFunc) = value;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x000B3B5C File Offset: 0x000B1D5C
		// (set) Token: 0x06007D61 RID: 32097 RVA: 0x000B3B70 File Offset: 0x000B1D70
		[Nullable(0)]
		public unsafe TEnumAsByte<ELifetimeCondition> ReplicationCondition
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_ReplicationCondition);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_ReplicationCondition) = value;
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06007D62 RID: 32098 RVA: 0x000B3B88 File Offset: 0x000B1D88
		// (set) Token: 0x06007D63 RID: 32099 RVA: 0x000B3BCB File Offset: 0x000B1DCB
		public TArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBPVariableMetaDataEntry> result;
				if ((result = this._MetaDataArray) == null)
				{
					result = (this._MetaDataArray = new TArray<FBPVariableMetaDataEntry>(base.NativePtr + (IntPtr)FBPVariableDescription.__PropertyOffset_MetaDataArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MetaDataArray.CopyAssign(value);
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x000B3BD9 File Offset: 0x000B1DD9
		// (set) Token: 0x06007D65 RID: 32101 RVA: 0x000B3BED File Offset: 0x000B1DED
		public unsafe string DefaultValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableDescription.__PropertyOffset_DefaultValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBPVariableDescription.__PropertyOffset_DefaultValue)), value);
			}
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x000B3C02 File Offset: 0x000B1E02
		public FBPVariableDescription()
		{
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x000B3C0C File Offset: 0x000B1E0C
		public FBPVariableDescription(FName VarName, FGuid VarGuid, FEdGraphPinType VarType, string FriendlyName, FText Category, ulong PropertyFlags, FName RepNotifyFunc, [Nullable(0)] TEnumAsByte<ELifetimeCondition> ReplicationCondition, TArray<FBPVariableMetaDataEntry> MetaDataArray, string DefaultValue)
		{
			this.VarName = VarName;
			this.VarGuid = VarGuid;
			this.VarType = VarType;
			this.FriendlyName = FriendlyName;
			this.Category = Category;
			this.PropertyFlags = PropertyFlags;
			this.RepNotifyFunc = RepNotifyFunc;
			this.ReplicationCondition = ReplicationCondition;
			this.MetaDataArray = MetaDataArray;
			this.DefaultValue = DefaultValue;
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x000B3C6C File Offset: 0x000B1E6C
		protected override IntPtr GetUStructPtr()
		{
			return FBPVariableDescription.StaticStruct();
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x000B3C78 File Offset: 0x000B1E78
		[NullableContext(2)]
		public FBPVariableDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x000B3C82 File Offset: 0x000B1E82
		public FBPVariableDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x000B3C8D File Offset: 0x000B1E8D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBPVariableDescription(Pointer, false, true);
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x000B3C97 File Offset: 0x000B1E97
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBPVariableDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04003C0C RID: 15372
		public const string __ObjectPath = "/Script/Engine.BPVariableDescription";

		// Token: 0x04003C0D RID: 15373
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C0E RID: 15374
		internal static int __PropertyOffset_VarName;

		// Token: 0x04003C0F RID: 15375
		internal static int __PropertyOffset_VarGuid;

		// Token: 0x04003C10 RID: 15376
		internal static int __PropertyOffset_VarType;

		// Token: 0x04003C11 RID: 15377
		[Nullable(2)]
		private FEdGraphPinType _VarType;

		// Token: 0x04003C12 RID: 15378
		internal static int __PropertyOffset_FriendlyName;

		// Token: 0x04003C13 RID: 15379
		internal static int __PropertyOffset_Category;

		// Token: 0x04003C14 RID: 15380
		[Nullable(2)]
		private FText _Category;

		// Token: 0x04003C15 RID: 15381
		internal static int __PropertyOffset_PropertyFlags;

		// Token: 0x04003C16 RID: 15382
		internal static int __PropertyOffset_RepNotifyFunc;

		// Token: 0x04003C17 RID: 15383
		internal static int __PropertyOffset_ReplicationCondition;

		// Token: 0x04003C18 RID: 15384
		internal static int __PropertyOffset_MetaDataArray;

		// Token: 0x04003C19 RID: 15385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBPVariableMetaDataEntry> _MetaDataArray;

		// Token: 0x04003C1A RID: 15386
		internal static int __PropertyOffset_DefaultValue;
	}
}
