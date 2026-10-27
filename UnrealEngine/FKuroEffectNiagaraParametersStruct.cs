using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018CB RID: 6347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectNiagaraParametersStruct")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroEffectNiagaraParametersStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017756 RID: 96086 RVA: 0x00224EAD File Offset: 0x002230AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectNiagaraParametersStruct._ScriptStructPtr != 0) ? FKuroEffectNiagaraParametersStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectNiagaraParametersStruct", ref FKuroEffectNiagaraParametersStruct._ScriptStructPtr);
		}

		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x06017757 RID: 96087 RVA: 0x00224ED4 File Offset: 0x002230D4
		// (set) Token: 0x06017758 RID: 96088 RVA: 0x00224F17 File Offset: 0x00223117
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

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x06017759 RID: 96089 RVA: 0x00224F28 File Offset: 0x00223128
		// (set) Token: 0x0601775A RID: 96090 RVA: 0x00224F6B File Offset: 0x0022316B
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

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0601775B RID: 96091 RVA: 0x00224F7C File Offset: 0x0022317C
		// (set) Token: 0x0601775C RID: 96092 RVA: 0x00224FBF File Offset: 0x002231BF
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

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x0601775D RID: 96093 RVA: 0x00224FD0 File Offset: 0x002231D0
		// (set) Token: 0x0601775E RID: 96094 RVA: 0x00225013 File Offset: 0x00223213
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

		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x0601775F RID: 96095 RVA: 0x00225024 File Offset: 0x00223224
		// (set) Token: 0x06017760 RID: 96096 RVA: 0x00225067 File Offset: 0x00223267
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

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x06017761 RID: 96097 RVA: 0x00225078 File Offset: 0x00223278
		// (set) Token: 0x06017762 RID: 96098 RVA: 0x002250BB File Offset: 0x002232BB
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

		// Token: 0x06017763 RID: 96099 RVA: 0x002250C9 File Offset: 0x002232C9
		public FKuroEffectNiagaraParametersStruct()
		{
		}

		// Token: 0x06017764 RID: 96100 RVA: 0x002250D1 File Offset: 0x002232D1
		public FKuroEffectNiagaraParametersStruct(TArray<FKuroParameterFloat> UserParameterFloat, TArray<FKuroParameterLinearColor> UserParameterColor, TArray<FKuroParameterVector> UserParameterVector, TArray<FKuroParameterArrayVector> UserParameterArrayVector, TArray<FKuroParameterFloat> MaterialParameterFloat, TArray<FKuroParameterLinearColor> MaterialParameterColor)
		{
			this.UserParameterFloat = UserParameterFloat;
			this.UserParameterColor = UserParameterColor;
			this.UserParameterVector = UserParameterVector;
			this.UserParameterArrayVector = UserParameterArrayVector;
			this.MaterialParameterFloat = MaterialParameterFloat;
			this.MaterialParameterColor = MaterialParameterColor;
		}

		// Token: 0x06017765 RID: 96101 RVA: 0x00225106 File Offset: 0x00223306
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectNiagaraParametersStruct.StaticStruct();
		}

		// Token: 0x06017766 RID: 96102 RVA: 0x00225112 File Offset: 0x00223312
		[NullableContext(2)]
		public FKuroEffectNiagaraParametersStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017767 RID: 96103 RVA: 0x0022511C File Offset: 0x0022331C
		public FKuroEffectNiagaraParametersStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017768 RID: 96104 RVA: 0x00225127 File Offset: 0x00223327
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectNiagaraParametersStruct(Pointer, false, true);
		}

		// Token: 0x06017769 RID: 96105 RVA: 0x00225131 File Offset: 0x00223331
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectNiagaraParametersStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC00 RID: 52224
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectNiagaraParametersStruct";

		// Token: 0x0400CC01 RID: 52225
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CC02 RID: 52226
		internal static int __PropertyOffset_UserParameterFloat;

		// Token: 0x0400CC03 RID: 52227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterFloat> _UserParameterFloat;

		// Token: 0x0400CC04 RID: 52228
		internal static int __PropertyOffset_UserParameterColor;

		// Token: 0x0400CC05 RID: 52229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterLinearColor> _UserParameterColor;

		// Token: 0x0400CC06 RID: 52230
		internal static int __PropertyOffset_UserParameterVector;

		// Token: 0x0400CC07 RID: 52231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterVector> _UserParameterVector;

		// Token: 0x0400CC08 RID: 52232
		internal static int __PropertyOffset_UserParameterArrayVector;

		// Token: 0x0400CC09 RID: 52233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterArrayVector> _UserParameterArrayVector;

		// Token: 0x0400CC0A RID: 52234
		internal static int __PropertyOffset_MaterialParameterFloat;

		// Token: 0x0400CC0B RID: 52235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterFloat> _MaterialParameterFloat;

		// Token: 0x0400CC0C RID: 52236
		internal static int __PropertyOffset_MaterialParameterColor;

		// Token: 0x0400CC0D RID: 52237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroParameterLinearColor> _MaterialParameterColor;
	}
}
