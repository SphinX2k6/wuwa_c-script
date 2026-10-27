using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002603 RID: 9731
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableInfo")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNiagaraVariableInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024306 RID: 148230 RVA: 0x00359183 File Offset: 0x00357383
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableInfo._ScriptStructPtr != 0) ? FNiagaraVariableInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableInfo", ref FNiagaraVariableInfo._ScriptStructPtr);
		}

		// Token: 0x17008B5A RID: 35674
		// (get) Token: 0x06024307 RID: 148231 RVA: 0x003591A8 File Offset: 0x003573A8
		// (set) Token: 0x06024308 RID: 148232 RVA: 0x003591EB File Offset: 0x003573EB
		public FNiagaraVariable Variable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._Variable) == null)
				{
					result = (this._Variable = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraVariableInfo.__PropertyOffset_Variable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableInfo.__PropertyOffset_Variable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B5B RID: 35675
		// (get) Token: 0x06024309 RID: 148233 RVA: 0x0035920C File Offset: 0x0035740C
		// (set) Token: 0x0602430A RID: 148234 RVA: 0x0035924F File Offset: 0x0035744F
		public unsafe FText Definition
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Definition) == null)
				{
					result = (this._Definition = new FText(base.NativePtr + (IntPtr)FNiagaraVariableInfo.__PropertyOffset_Definition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraVariableInfo.__PropertyOffset_Definition)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008B5C RID: 35676
		// (get) Token: 0x0602430B RID: 148235 RVA: 0x0035926A File Offset: 0x0035746A
		// (set) Token: 0x0602430C RID: 148236 RVA: 0x0035927E File Offset: 0x0035747E
		[Nullable(2)]
		public unsafe UNiagaraDataInterface DataInterface
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariableInfo.__PropertyOffset_DataInterface);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariableInfo.__PropertyOffset_DataInterface, value);
			}
		}

		// Token: 0x0602430D RID: 148237 RVA: 0x00359293 File Offset: 0x00357493
		public FNiagaraVariableInfo()
		{
		}

		// Token: 0x0602430E RID: 148238 RVA: 0x0035929B File Offset: 0x0035749B
		public FNiagaraVariableInfo(FNiagaraVariable Variable, FText Definition, UNiagaraDataInterface DataInterface)
		{
			this.Variable = Variable;
			this.Definition = Definition;
			this.DataInterface = DataInterface;
		}

		// Token: 0x0602430F RID: 148239 RVA: 0x003592B8 File Offset: 0x003574B8
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableInfo.StaticStruct();
		}

		// Token: 0x06024310 RID: 148240 RVA: 0x003592C4 File Offset: 0x003574C4
		[NullableContext(2)]
		public FNiagaraVariableInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024311 RID: 148241 RVA: 0x003592CE File Offset: 0x003574CE
		public FNiagaraVariableInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024312 RID: 148242 RVA: 0x003592D9 File Offset: 0x003574D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableInfo(Pointer, false, true);
		}

		// Token: 0x06024313 RID: 148243 RVA: 0x003592E3 File Offset: 0x003574E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040136AB RID: 79531
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableInfo";

		// Token: 0x040136AC RID: 79532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136AD RID: 79533
		internal static int __PropertyOffset_Variable;

		// Token: 0x040136AE RID: 79534
		[Nullable(2)]
		private FNiagaraVariable _Variable;

		// Token: 0x040136AF RID: 79535
		internal static int __PropertyOffset_Definition;

		// Token: 0x040136B0 RID: 79536
		[Nullable(2)]
		private FText _Definition;

		// Token: 0x040136B1 RID: 79537
		internal static int __PropertyOffset_DataInterface;
	}
}
