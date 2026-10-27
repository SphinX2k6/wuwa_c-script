using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B08 RID: 6920
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGIMPCSetting")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FKuroGIMPCSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019EA0 RID: 106144 RVA: 0x00263F94 File Offset: 0x00262194
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGIMPCSetting._ScriptStructPtr != 0) ? FKuroGIMPCSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGIMPCSetting", ref FKuroGIMPCSetting._ScriptStructPtr);
		}

		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x06019EA1 RID: 106145 RVA: 0x00263FB8 File Offset: 0x002621B8
		// (set) Token: 0x06019EA2 RID: 106146 RVA: 0x00263FD1 File Offset: 0x002621D1
		public unsafe bool bOverride_FloatParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_FloatParameters) & FKuroGIMPCSetting.__PropertyMask_bOverride_FloatParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_FloatParameters) = ((*(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_FloatParameters) & ~FKuroGIMPCSetting.__PropertyMask_bOverride_FloatParameters) | (value ? FKuroGIMPCSetting.__PropertyMask_bOverride_FloatParameters : 0));
			}
		}

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x06019EA3 RID: 106147 RVA: 0x00264004 File Offset: 0x00262204
		// (set) Token: 0x06019EA4 RID: 106148 RVA: 0x00264047 File Offset: 0x00262247
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170067DA RID: 26586
		// (get) Token: 0x06019EA5 RID: 106149 RVA: 0x00264055 File Offset: 0x00262255
		// (set) Token: 0x06019EA6 RID: 106150 RVA: 0x0026406E File Offset: 0x0026226E
		public unsafe bool bOverride_ColorParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_ColorParameters) & FKuroGIMPCSetting.__PropertyMask_bOverride_ColorParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_ColorParameters) = ((*(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_bOverride_ColorParameters) & ~FKuroGIMPCSetting.__PropertyMask_bOverride_ColorParameters) | (value ? FKuroGIMPCSetting.__PropertyMask_bOverride_ColorParameters : 0));
			}
		}

		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x06019EA7 RID: 106151 RVA: 0x002640A0 File Offset: 0x002622A0
		// (set) Token: 0x06019EA8 RID: 106152 RVA: 0x002640E3 File Offset: 0x002622E3
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroGIMPCSetting.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06019EA9 RID: 106153 RVA: 0x002640F1 File Offset: 0x002622F1
		public FKuroGIMPCSetting()
		{
		}

		// Token: 0x06019EAA RID: 106154 RVA: 0x002640F9 File Offset: 0x002622F9
		public FKuroGIMPCSetting(bool bOverride_FloatParameters, TMap<FName, float> FloatParameters, bool bOverride_ColorParameters, TMap<FName, FLinearColor> ColorParameters)
		{
			this.bOverride_FloatParameters = bOverride_FloatParameters;
			this.FloatParameters = FloatParameters;
			this.bOverride_ColorParameters = bOverride_ColorParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x06019EAB RID: 106155 RVA: 0x0026411E File Offset: 0x0026231E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGIMPCSetting.StaticStruct();
		}

		// Token: 0x06019EAC RID: 106156 RVA: 0x0026412A File Offset: 0x0026232A
		[NullableContext(2)]
		public FKuroGIMPCSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x00264134 File Offset: 0x00262334
		public FKuroGIMPCSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019EAE RID: 106158 RVA: 0x0026413F File Offset: 0x0026233F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGIMPCSetting(Pointer, false, true);
		}

		// Token: 0x06019EAF RID: 106159 RVA: 0x00264149 File Offset: 0x00262349
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGIMPCSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E15A RID: 57690
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGIMPCSetting";

		// Token: 0x0400E15B RID: 57691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E15C RID: 57692
		internal static int __PropertyOffset_bOverride_FloatParameters;

		// Token: 0x0400E15D RID: 57693
		internal static byte __PropertyMask_bOverride_FloatParameters;

		// Token: 0x0400E15E RID: 57694
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400E15F RID: 57695
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x0400E160 RID: 57696
		internal static int __PropertyOffset_bOverride_ColorParameters;

		// Token: 0x0400E161 RID: 57697
		internal static byte __PropertyMask_bOverride_ColorParameters;

		// Token: 0x0400E162 RID: 57698
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400E163 RID: 57699
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;
	}
}
