using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025BD RID: 9661
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraModuleDependency")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNiagaraModuleDependency : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023EA5 RID: 147109 RVA: 0x00351E06 File Offset: 0x00350006
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraModuleDependency._ScriptStructPtr != 0) ? FNiagaraModuleDependency._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraModuleDependency", ref FNiagaraModuleDependency._ScriptStructPtr);
		}

		// Token: 0x17008A28 RID: 35368
		// (get) Token: 0x06023EA6 RID: 147110 RVA: 0x00351E2A File Offset: 0x0035002A
		// (set) Token: 0x06023EA7 RID: 147111 RVA: 0x00351E3E File Offset: 0x0035003E
		public unsafe FName Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17008A29 RID: 35369
		// (get) Token: 0x06023EA8 RID: 147112 RVA: 0x00351E53 File Offset: 0x00350053
		// (set) Token: 0x06023EA9 RID: 147113 RVA: 0x00351E63 File Offset: 0x00350063
		public unsafe ENiagaraModuleDependencyType Type
		{
			get
			{
				return (ENiagaraModuleDependencyType)(*(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17008A2A RID: 35370
		// (get) Token: 0x06023EAA RID: 147114 RVA: 0x00351E74 File Offset: 0x00350074
		// (set) Token: 0x06023EAB RID: 147115 RVA: 0x00351E84 File Offset: 0x00350084
		public unsafe ENiagaraModuleDependencyScriptConstraint ScriptConstraint
		{
			get
			{
				return (ENiagaraModuleDependencyScriptConstraint)(*(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_ScriptConstraint));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_ScriptConstraint) = (byte)value;
			}
		}

		// Token: 0x17008A2B RID: 35371
		// (get) Token: 0x06023EAC RID: 147116 RVA: 0x00351E98 File Offset: 0x00350098
		// (set) Token: 0x06023EAD RID: 147117 RVA: 0x00351EDB File Offset: 0x003500DB
		public unsafe FText Description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Description) == null)
				{
					result = (this._Description = new FText(base.NativePtr + (IntPtr)FNiagaraModuleDependency.__PropertyOffset_Description, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraModuleDependency.__PropertyOffset_Description)), value.NativePtr, 1);
			}
		}

		// Token: 0x06023EAE RID: 147118 RVA: 0x00351EF6 File Offset: 0x003500F6
		public FNiagaraModuleDependency()
		{
		}

		// Token: 0x06023EAF RID: 147119 RVA: 0x00351EFE File Offset: 0x003500FE
		public FNiagaraModuleDependency(FName Id, ENiagaraModuleDependencyType Type, ENiagaraModuleDependencyScriptConstraint ScriptConstraint, FText Description)
		{
			this.Id = Id;
			this.Type = Type;
			this.ScriptConstraint = ScriptConstraint;
			this.Description = Description;
		}

		// Token: 0x06023EB0 RID: 147120 RVA: 0x00351F23 File Offset: 0x00350123
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraModuleDependency.StaticStruct();
		}

		// Token: 0x06023EB1 RID: 147121 RVA: 0x00351F2F File Offset: 0x0035012F
		[NullableContext(2)]
		public FNiagaraModuleDependency(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023EB2 RID: 147122 RVA: 0x00351F39 File Offset: 0x00350139
		public FNiagaraModuleDependency(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023EB3 RID: 147123 RVA: 0x00351F44 File Offset: 0x00350144
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraModuleDependency(Pointer, false, true);
		}

		// Token: 0x06023EB4 RID: 147124 RVA: 0x00351F4E File Offset: 0x0035014E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraModuleDependency(Pointer, MemoryOwner);
		}

		// Token: 0x0401342C RID: 78892
		public const string __ObjectPath = "/Script/Niagara.NiagaraModuleDependency";

		// Token: 0x0401342D RID: 78893
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401342E RID: 78894
		internal static int __PropertyOffset_Id;

		// Token: 0x0401342F RID: 78895
		internal static int __PropertyOffset_Type;

		// Token: 0x04013430 RID: 78896
		internal static int __PropertyOffset_ScriptConstraint;

		// Token: 0x04013431 RID: 78897
		internal static int __PropertyOffset_Description;

		// Token: 0x04013432 RID: 78898
		[Nullable(2)]
		private FText _Description;
	}
}
