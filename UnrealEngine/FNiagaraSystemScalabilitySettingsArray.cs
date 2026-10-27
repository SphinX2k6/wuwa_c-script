using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F5 RID: 9717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemScalabilitySettingsArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraSystemScalabilitySettingsArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602425D RID: 148061 RVA: 0x003581CC File Offset: 0x003563CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemScalabilitySettingsArray._ScriptStructPtr != 0) ? FNiagaraSystemScalabilitySettingsArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemScalabilitySettingsArray", ref FNiagaraSystemScalabilitySettingsArray._ScriptStructPtr);
		}

		// Token: 0x17008B3D RID: 35645
		// (get) Token: 0x0602425E RID: 148062 RVA: 0x003581F0 File Offset: 0x003563F0
		// (set) Token: 0x0602425F RID: 148063 RVA: 0x00358233 File Offset: 0x00356433
		public TArray<FNiagaraSystemScalabilitySettings> Settings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemScalabilitySettings> result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new TArray<FNiagaraSystemScalabilitySettings>(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettingsArray.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Settings.CopyAssign(value);
			}
		}

		// Token: 0x06024260 RID: 148064 RVA: 0x00358241 File Offset: 0x00356441
		public FNiagaraSystemScalabilitySettingsArray()
		{
		}

		// Token: 0x06024261 RID: 148065 RVA: 0x00358249 File Offset: 0x00356449
		public FNiagaraSystemScalabilitySettingsArray(TArray<FNiagaraSystemScalabilitySettings> Settings)
		{
			this.Settings = Settings;
		}

		// Token: 0x06024262 RID: 148066 RVA: 0x00358258 File Offset: 0x00356458
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemScalabilitySettingsArray.StaticStruct();
		}

		// Token: 0x06024263 RID: 148067 RVA: 0x00358264 File Offset: 0x00356464
		[NullableContext(2)]
		public FNiagaraSystemScalabilitySettingsArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024264 RID: 148068 RVA: 0x0035826E File Offset: 0x0035646E
		public FNiagaraSystemScalabilitySettingsArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024265 RID: 148069 RVA: 0x00358279 File Offset: 0x00356479
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemScalabilitySettingsArray(Pointer, false, true);
		}

		// Token: 0x06024266 RID: 148070 RVA: 0x00358283 File Offset: 0x00356483
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemScalabilitySettingsArray(Pointer, MemoryOwner);
		}

		// Token: 0x04013659 RID: 79449
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemScalabilitySettingsArray";

		// Token: 0x0401365A RID: 79450
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401365B RID: 79451
		internal static int __PropertyOffset_Settings;

		// Token: 0x0401365C RID: 79452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraSystemScalabilitySettings> _Settings;
	}
}
