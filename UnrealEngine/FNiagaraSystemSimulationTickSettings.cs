using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025F6 RID: 9718
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemSimulationTickSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FNiagaraSystemSimulationTickSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024267 RID: 148071 RVA: 0x0035828C File Offset: 0x0035648C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemSimulationTickSettings._ScriptStructPtr != 0) ? FNiagaraSystemSimulationTickSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemSimulationTickSettings", ref FNiagaraSystemSimulationTickSettings._ScriptStructPtr);
		}

		// Token: 0x17008B3E RID: 35646
		// (get) Token: 0x06024268 RID: 148072 RVA: 0x003582B0 File Offset: 0x003564B0
		// (set) Token: 0x06024269 RID: 148073 RVA: 0x003582F3 File Offset: 0x003564F3
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)FNiagaraSystemSimulationTickSettings.__PropertyOffset_Platforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemSimulationTickSettings.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B3F RID: 35647
		// (get) Token: 0x0602426A RID: 148074 RVA: 0x00358314 File Offset: 0x00356514
		// (set) Token: 0x0602426B RID: 148075 RVA: 0x00358324 File Offset: 0x00356524
		public unsafe float TickMinDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSystemSimulationTickSettings.__PropertyOffset_TickMinDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSystemSimulationTickSettings.__PropertyOffset_TickMinDeltaTime) = value;
			}
		}

		// Token: 0x0602426C RID: 148076 RVA: 0x00358335 File Offset: 0x00356535
		public FNiagaraSystemSimulationTickSettings()
		{
		}

		// Token: 0x0602426D RID: 148077 RVA: 0x0035833D File Offset: 0x0035653D
		public FNiagaraSystemSimulationTickSettings(FNiagaraPlatformSet Platforms, float TickMinDeltaTime)
		{
			this.Platforms = Platforms;
			this.TickMinDeltaTime = TickMinDeltaTime;
		}

		// Token: 0x0602426E RID: 148078 RVA: 0x00358353 File Offset: 0x00356553
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemSimulationTickSettings.StaticStruct();
		}

		// Token: 0x0602426F RID: 148079 RVA: 0x0035835F File Offset: 0x0035655F
		[NullableContext(2)]
		public FNiagaraSystemSimulationTickSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024270 RID: 148080 RVA: 0x00358369 File Offset: 0x00356569
		public FNiagaraSystemSimulationTickSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024271 RID: 148081 RVA: 0x00358374 File Offset: 0x00356574
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemSimulationTickSettings(Pointer, false, true);
		}

		// Token: 0x06024272 RID: 148082 RVA: 0x0035837E File Offset: 0x0035657E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemSimulationTickSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401365D RID: 79453
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemSimulationTickSettings";

		// Token: 0x0401365E RID: 79454
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401365F RID: 79455
		internal static int __PropertyOffset_Platforms;

		// Token: 0x04013660 RID: 79456
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x04013661 RID: 79457
		internal static int __PropertyOffset_TickMinDeltaTime;
	}
}
