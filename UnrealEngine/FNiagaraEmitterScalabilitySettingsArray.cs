using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025A2 RID: 9634
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterScalabilitySettingsArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraEmitterScalabilitySettingsArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C91 RID: 146577 RVA: 0x0034EC68 File Offset: 0x0034CE68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterScalabilitySettingsArray._ScriptStructPtr != 0) ? FNiagaraEmitterScalabilitySettingsArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterScalabilitySettingsArray", ref FNiagaraEmitterScalabilitySettingsArray._ScriptStructPtr);
		}

		// Token: 0x1700898D RID: 35213
		// (get) Token: 0x06023C92 RID: 146578 RVA: 0x0034EC8C File Offset: 0x0034CE8C
		// (set) Token: 0x06023C93 RID: 146579 RVA: 0x0034ECCF File Offset: 0x0034CECF
		public TArray<FNiagaraEmitterScalabilitySettings> Settings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEmitterScalabilitySettings> result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new TArray<FNiagaraEmitterScalabilitySettings>(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettingsArray.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Settings.CopyAssign(value);
			}
		}

		// Token: 0x06023C94 RID: 146580 RVA: 0x0034ECDD File Offset: 0x0034CEDD
		public FNiagaraEmitterScalabilitySettingsArray()
		{
		}

		// Token: 0x06023C95 RID: 146581 RVA: 0x0034ECE5 File Offset: 0x0034CEE5
		public FNiagaraEmitterScalabilitySettingsArray(TArray<FNiagaraEmitterScalabilitySettings> Settings)
		{
			this.Settings = Settings;
		}

		// Token: 0x06023C96 RID: 146582 RVA: 0x0034ECF4 File Offset: 0x0034CEF4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterScalabilitySettingsArray.StaticStruct();
		}

		// Token: 0x06023C97 RID: 146583 RVA: 0x0034ED00 File Offset: 0x0034CF00
		[NullableContext(2)]
		public FNiagaraEmitterScalabilitySettingsArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C98 RID: 146584 RVA: 0x0034ED0A File Offset: 0x0034CF0A
		public FNiagaraEmitterScalabilitySettingsArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C99 RID: 146585 RVA: 0x0034ED15 File Offset: 0x0034CF15
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterScalabilitySettingsArray(Pointer, false, true);
		}

		// Token: 0x06023C9A RID: 146586 RVA: 0x0034ED1F File Offset: 0x0034CF1F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterScalabilitySettingsArray(Pointer, MemoryOwner);
		}

		// Token: 0x0401331A RID: 78618
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterScalabilitySettingsArray";

		// Token: 0x0401331B RID: 78619
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401331C RID: 78620
		internal static int __PropertyOffset_Settings;

		// Token: 0x0401331D RID: 78621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEmitterScalabilitySettings> _Settings;
	}
}
