using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003E6 RID: 998
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectNiagaraParametersStruct")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroEffectNiagaraParametersStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061CF RID: 25039 RVA: 0x0008BD8D File Offset: 0x00089F8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectNiagaraParametersStruct._ScriptStructPtr != 0) ? FKuroEffectNiagaraParametersStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectNiagaraParametersStruct", ref FKuroEffectNiagaraParametersStruct._ScriptStructPtr);
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060061D0 RID: 25040 RVA: 0x0008BDB4 File Offset: 0x00089FB4
		// (set) Token: 0x060061D1 RID: 25041 RVA: 0x0008BDF7 File Offset: 0x00089FF7
		public TArray<FKuroParameterFloat> UserParameterFloat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterFloat> result;
				if ((result = this._UserParameterFloat) == null)
				{
					result = (this._UserParameterFloat = new TArray<FKuroParameterFloat>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_UserParameterFloat, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserParameterFloat.CopyAssign(value);
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060061D2 RID: 25042 RVA: 0x0008BE08 File Offset: 0x0008A008
		// (set) Token: 0x060061D3 RID: 25043 RVA: 0x0008BE4B File Offset: 0x0008A04B
		public TArray<FKuroParameterLinearColor> UserParameterColor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterLinearColor> result;
				if ((result = this._UserParameterColor) == null)
				{
					result = (this._UserParameterColor = new TArray<FKuroParameterLinearColor>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_UserParameterColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserParameterColor.CopyAssign(value);
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x0008BE5C File Offset: 0x0008A05C
		// (set) Token: 0x060061D5 RID: 25045 RVA: 0x0008BE9F File Offset: 0x0008A09F
		public TArray<FKuroParameterVector> UserParameterVector
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterVector> result;
				if ((result = this._UserParameterVector) == null)
				{
					result = (this._UserParameterVector = new TArray<FKuroParameterVector>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_UserParameterVector, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserParameterVector.CopyAssign(value);
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060061D6 RID: 25046 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
		// (set) Token: 0x060061D7 RID: 25047 RVA: 0x0008BEF3 File Offset: 0x0008A0F3
		public TArray<FKuroParameterArrayVector> UserParameterArrayVector
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterArrayVector> result;
				if ((result = this._UserParameterArrayVector) == null)
				{
					result = (this._UserParameterArrayVector = new TArray<FKuroParameterArrayVector>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_UserParameterArrayVector, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserParameterArrayVector.CopyAssign(value);
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060061D8 RID: 25048 RVA: 0x0008BF04 File Offset: 0x0008A104
		// (set) Token: 0x060061D9 RID: 25049 RVA: 0x0008BF47 File Offset: 0x0008A147
		public TArray<FKuroParameterFloat> MaterialParameterFloat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterFloat> result;
				if ((result = this._MaterialParameterFloat) == null)
				{
					result = (this._MaterialParameterFloat = new TArray<FKuroParameterFloat>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_MaterialParameterFloat, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialParameterFloat.CopyAssign(value);
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060061DA RID: 25050 RVA: 0x0008BF58 File Offset: 0x0008A158
		// (set) Token: 0x060061DB RID: 25051 RVA: 0x0008BF9B File Offset: 0x0008A19B
		public TArray<FKuroParameterLinearColor> MaterialParameterColor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroParameterLinearColor> result;
				if ((result = this._MaterialParameterColor) == null)
				{
					result = (this._MaterialParameterColor = new TArray<FKuroParameterLinearColor>(base.NativePtr + (IntPtr)FKuroEffectNiagaraParametersStruct.__PropertyOffset_MaterialParameterColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialParameterColor.CopyAssign(value);
			}
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x0008BFA9 File Offset: 0x0008A1A9
		public FKuroEffectNiagaraParametersStruct()
		{
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x0008BFB1 File Offset: 0x0008A1B1
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectNiagaraParametersStruct.StaticStruct();
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x0008BFBD File Offset: 0x0008A1BD
		[NullableContext(2)]
		public FKuroEffectNiagaraParametersStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x0008BFC7 File Offset: 0x0008A1C7
		public FKuroEffectNiagaraParametersStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x0008BFD2 File Offset: 0x0008A1D2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectNiagaraParametersStruct(Pointer, false, true);
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x0008BFDC File Offset: 0x0008A1DC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectNiagaraParametersStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040029A2 RID: 10658
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectNiagaraParametersStruct";

		// Token: 0x040029A3 RID: 10659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029A4 RID: 10660
		internal static int __PropertyOffset_UserParameterFloat;

		// Token: 0x040029A5 RID: 10661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterFloat> _UserParameterFloat;

		// Token: 0x040029A6 RID: 10662
		internal static int __PropertyOffset_UserParameterColor;

		// Token: 0x040029A7 RID: 10663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterLinearColor> _UserParameterColor;

		// Token: 0x040029A8 RID: 10664
		internal static int __PropertyOffset_UserParameterVector;

		// Token: 0x040029A9 RID: 10665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterVector> _UserParameterVector;

		// Token: 0x040029AA RID: 10666
		internal static int __PropertyOffset_UserParameterArrayVector;

		// Token: 0x040029AB RID: 10667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterArrayVector> _UserParameterArrayVector;

		// Token: 0x040029AC RID: 10668
		internal static int __PropertyOffset_MaterialParameterFloat;

		// Token: 0x040029AD RID: 10669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterFloat> _MaterialParameterFloat;

		// Token: 0x040029AE RID: 10670
		internal static int __PropertyOffset_MaterialParameterColor;

		// Token: 0x040029AF RID: 10671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterLinearColor> _MaterialParameterColor;
	}
}
