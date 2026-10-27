using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002591 RID: 9617
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataSetID")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraDataSetID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B04 RID: 146180 RVA: 0x0034C594 File Offset: 0x0034A794
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataSetID._ScriptStructPtr != 0) ? FNiagaraDataSetID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataSetID", ref FNiagaraDataSetID._ScriptStructPtr);
		}

		// Token: 0x17008906 RID: 35078
		// (get) Token: 0x06023B05 RID: 146181 RVA: 0x0034C5B8 File Offset: 0x0034A7B8
		// (set) Token: 0x06023B06 RID: 146182 RVA: 0x0034C5CC File Offset: 0x0034A7CC
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataSetID.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetID.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008907 RID: 35079
		// (get) Token: 0x06023B07 RID: 146183 RVA: 0x0034C5E1 File Offset: 0x0034A7E1
		// (set) Token: 0x06023B08 RID: 146184 RVA: 0x0034C5F1 File Offset: 0x0034A7F1
		public unsafe ENiagaraDataSetType Type
		{
			get
			{
				return (ENiagaraDataSetType)(*(base.NativePtr + (IntPtr)FNiagaraDataSetID.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetID.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06023B09 RID: 146185 RVA: 0x0034C602 File Offset: 0x0034A802
		public FNiagaraDataSetID()
		{
		}

		// Token: 0x06023B0A RID: 146186 RVA: 0x0034C60A File Offset: 0x0034A80A
		public FNiagaraDataSetID(FName Name, ENiagaraDataSetType Type)
		{
			this.Name = Name;
			this.Type = Type;
		}

		// Token: 0x06023B0B RID: 146187 RVA: 0x0034C620 File Offset: 0x0034A820
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataSetID.StaticStruct();
		}

		// Token: 0x06023B0C RID: 146188 RVA: 0x0034C62C File Offset: 0x0034A82C
		[NullableContext(2)]
		public FNiagaraDataSetID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B0D RID: 146189 RVA: 0x0034C636 File Offset: 0x0034A836
		public FNiagaraDataSetID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B0E RID: 146190 RVA: 0x0034C641 File Offset: 0x0034A841
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataSetID(Pointer, false, true);
		}

		// Token: 0x06023B0F RID: 146191 RVA: 0x0034C64B File Offset: 0x0034A84B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataSetID(Pointer, MemoryOwner);
		}

		// Token: 0x0401323A RID: 78394
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataSetID";

		// Token: 0x0401323B RID: 78395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401323C RID: 78396
		internal static int __PropertyOffset_Name;

		// Token: 0x0401323D RID: 78397
		internal static int __PropertyOffset_Type;
	}
}
