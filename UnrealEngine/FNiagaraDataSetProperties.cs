using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002592 RID: 9618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataSetProperties")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraDataSetProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B10 RID: 146192 RVA: 0x0034C654 File Offset: 0x0034A854
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataSetProperties._ScriptStructPtr != 0) ? FNiagaraDataSetProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataSetProperties", ref FNiagaraDataSetProperties._ScriptStructPtr);
		}

		// Token: 0x17008908 RID: 35080
		// (get) Token: 0x06023B11 RID: 146193 RVA: 0x0034C678 File Offset: 0x0034A878
		// (set) Token: 0x06023B12 RID: 146194 RVA: 0x0034C6BB File Offset: 0x0034A8BB
		public FNiagaraDataSetID ID
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetID result;
				if ((result = this._ID) == null)
				{
					result = (this._ID = new FNiagaraDataSetID(base.NativePtr + (IntPtr)FNiagaraDataSetProperties.__PropertyOffset_ID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetID.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDataSetProperties.__PropertyOffset_ID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008909 RID: 35081
		// (get) Token: 0x06023B13 RID: 146195 RVA: 0x0034C6DC File Offset: 0x0034A8DC
		// (set) Token: 0x06023B14 RID: 146196 RVA: 0x0034C71F File Offset: 0x0034A91F
		public TArray<FNiagaraVariable> Variables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Variables) == null)
				{
					result = (this._Variables = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraDataSetProperties.__PropertyOffset_Variables, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Variables.CopyAssign(value);
			}
		}

		// Token: 0x06023B15 RID: 146197 RVA: 0x0034C72D File Offset: 0x0034A92D
		public FNiagaraDataSetProperties()
		{
		}

		// Token: 0x06023B16 RID: 146198 RVA: 0x0034C735 File Offset: 0x0034A935
		public FNiagaraDataSetProperties(FNiagaraDataSetID ID, TArray<FNiagaraVariable> Variables)
		{
			this.ID = ID;
			this.Variables = Variables;
		}

		// Token: 0x06023B17 RID: 146199 RVA: 0x0034C74B File Offset: 0x0034A94B
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataSetProperties.StaticStruct();
		}

		// Token: 0x06023B18 RID: 146200 RVA: 0x0034C757 File Offset: 0x0034A957
		[NullableContext(2)]
		public FNiagaraDataSetProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B19 RID: 146201 RVA: 0x0034C761 File Offset: 0x0034A961
		public FNiagaraDataSetProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B1A RID: 146202 RVA: 0x0034C76C File Offset: 0x0034A96C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataSetProperties(Pointer, false, true);
		}

		// Token: 0x06023B1B RID: 146203 RVA: 0x0034C776 File Offset: 0x0034A976
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataSetProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0401323E RID: 78398
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataSetProperties";

		// Token: 0x0401323F RID: 78399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013240 RID: 78400
		internal static int __PropertyOffset_ID;

		// Token: 0x04013241 RID: 78401
		[Nullable(2)]
		private FNiagaraDataSetID _ID;

		// Token: 0x04013242 RID: 78402
		internal static int __PropertyOffset_Variables;

		// Token: 0x04013243 RID: 78403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Variables;
	}
}
