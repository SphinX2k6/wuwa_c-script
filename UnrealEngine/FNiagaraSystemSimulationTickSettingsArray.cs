using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F7 RID: 9719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemSimulationTickSettingsArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraSystemSimulationTickSettingsArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024273 RID: 148083 RVA: 0x00358387 File Offset: 0x00356587
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemSimulationTickSettingsArray._ScriptStructPtr != 0) ? FNiagaraSystemSimulationTickSettingsArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemSimulationTickSettingsArray", ref FNiagaraSystemSimulationTickSettingsArray._ScriptStructPtr);
		}

		// Token: 0x17008B40 RID: 35648
		// (get) Token: 0x06024274 RID: 148084 RVA: 0x003583AC File Offset: 0x003565AC
		// (set) Token: 0x06024275 RID: 148085 RVA: 0x003583EF File Offset: 0x003565EF
		public TArray<FNiagaraSystemSimulationTickSettings> Settings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemSimulationTickSettings> result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new TArray<FNiagaraSystemSimulationTickSettings>(base.NativePtr + (IntPtr)FNiagaraSystemSimulationTickSettingsArray.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Settings.CopyAssign(value);
			}
		}

		// Token: 0x06024276 RID: 148086 RVA: 0x003583FD File Offset: 0x003565FD
		public FNiagaraSystemSimulationTickSettingsArray()
		{
		}

		// Token: 0x06024277 RID: 148087 RVA: 0x00358405 File Offset: 0x00356605
		public FNiagaraSystemSimulationTickSettingsArray(TArray<FNiagaraSystemSimulationTickSettings> Settings)
		{
			this.Settings = Settings;
		}

		// Token: 0x06024278 RID: 148088 RVA: 0x00358414 File Offset: 0x00356614
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemSimulationTickSettingsArray.StaticStruct();
		}

		// Token: 0x06024279 RID: 148089 RVA: 0x00358420 File Offset: 0x00356620
		[NullableContext(2)]
		public FNiagaraSystemSimulationTickSettingsArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602427A RID: 148090 RVA: 0x0035842A File Offset: 0x0035662A
		public FNiagaraSystemSimulationTickSettingsArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602427B RID: 148091 RVA: 0x00358435 File Offset: 0x00356635
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemSimulationTickSettingsArray(Pointer, false, true);
		}

		// Token: 0x0602427C RID: 148092 RVA: 0x0035843F File Offset: 0x0035663F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemSimulationTickSettingsArray(Pointer, MemoryOwner);
		}

		// Token: 0x04013662 RID: 79458
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemSimulationTickSettingsArray";

		// Token: 0x04013663 RID: 79459
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013664 RID: 79460
		internal static int __PropertyOffset_Settings;

		// Token: 0x04013665 RID: 79461
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraSystemSimulationTickSettings> _Settings;
	}
}
