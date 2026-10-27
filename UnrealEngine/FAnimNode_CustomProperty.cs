using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000818 RID: 2072
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_CustomProperty")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FAnimNode_CustomProperty : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F6A RID: 28522 RVA: 0x0009FDE7 File Offset: 0x0009DFE7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CustomProperty._ScriptStructPtr != 0) ? FAnimNode_CustomProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_CustomProperty", ref FAnimNode_CustomProperty._ScriptStructPtr);
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06006F6B RID: 28523 RVA: 0x0009FE0C File Offset: 0x0009E00C
		// (set) Token: 0x06006F6C RID: 28524 RVA: 0x0009FE4F File Offset: 0x0009E04F
		public TArray<FName> SourcePropertyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SourcePropertyNames) == null)
				{
					result = (this._SourcePropertyNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_CustomProperty.__PropertyOffset_SourcePropertyNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourcePropertyNames.CopyAssign(value);
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x0009FE60 File Offset: 0x0009E060
		// (set) Token: 0x06006F6E RID: 28526 RVA: 0x0009FEA3 File Offset: 0x0009E0A3
		public TArray<FName> DestPropertyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DestPropertyNames) == null)
				{
					result = (this._DestPropertyNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_CustomProperty.__PropertyOffset_DestPropertyNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DestPropertyNames.CopyAssign(value);
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06006F6F RID: 28527 RVA: 0x0009FEB1 File Offset: 0x0009E0B1
		// (set) Token: 0x06006F70 RID: 28528 RVA: 0x0009FEC5 File Offset: 0x0009E0C5
		[Nullable(2)]
		public unsafe UObject TargetInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_CustomProperty.__PropertyOffset_TargetInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_CustomProperty.__PropertyOffset_TargetInstance, value);
			}
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x0009FEDA File Offset: 0x0009E0DA
		public FAnimNode_CustomProperty()
		{
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x0009FEE2 File Offset: 0x0009E0E2
		public FAnimNode_CustomProperty(TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.SourcePropertyNames = SourcePropertyNames;
			this.DestPropertyNames = DestPropertyNames;
			this.TargetInstance = TargetInstance;
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x0009FEFF File Offset: 0x0009E0FF
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CustomProperty.StaticStruct();
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x0009FF0B File Offset: 0x0009E10B
		[NullableContext(2)]
		public FAnimNode_CustomProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x0009FF15 File Offset: 0x0009E115
		public FAnimNode_CustomProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x0009FF20 File Offset: 0x0009E120
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CustomProperty(Pointer, false, true);
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x0009FF2A File Offset: 0x0009E12A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CustomProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400358B RID: 13707
		public new const string __ObjectPath = "/Script/Engine.AnimNode_CustomProperty";

		// Token: 0x0400358C RID: 13708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400358D RID: 13709
		internal static int __PropertyOffset_SourcePropertyNames;

		// Token: 0x0400358E RID: 13710
		[Nullable(2)]
		private TArray<FName> _SourcePropertyNames;

		// Token: 0x0400358F RID: 13711
		internal static int __PropertyOffset_DestPropertyNames;

		// Token: 0x04003590 RID: 13712
		[Nullable(2)]
		private TArray<FName> _DestPropertyNames;

		// Token: 0x04003591 RID: 13713
		internal static int __PropertyOffset_TargetInstance;
	}
}
