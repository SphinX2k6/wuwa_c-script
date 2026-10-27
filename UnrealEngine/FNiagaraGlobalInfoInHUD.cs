using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025AC RID: 9644
	[UnrealObjectPath("/Script/Niagara.NiagaraGlobalInfoInHUD")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraGlobalInfoInHUD : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D39 RID: 146745 RVA: 0x0034FCAC File Offset: 0x0034DEAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraGlobalInfoInHUD._ScriptStructPtr != 0) ? FNiagaraGlobalInfoInHUD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraGlobalInfoInHUD", ref FNiagaraGlobalInfoInHUD._ScriptStructPtr);
		}

		// Token: 0x170089B0 RID: 35248
		// (get) Token: 0x06023D3A RID: 146746 RVA: 0x0034FCD0 File Offset: 0x0034DED0
		// (set) Token: 0x06023D3B RID: 146747 RVA: 0x0034FCE0 File Offset: 0x0034DEE0
		public unsafe int GlobalTotalActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalActive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalActive) = value;
			}
		}

		// Token: 0x170089B1 RID: 35249
		// (get) Token: 0x06023D3C RID: 146748 RVA: 0x0034FCF1 File Offset: 0x0034DEF1
		// (set) Token: 0x06023D3D RID: 146749 RVA: 0x0034FD01 File Offset: 0x0034DF01
		public unsafe int GlobalTotalScalability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalScalability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalScalability) = value;
			}
		}

		// Token: 0x170089B2 RID: 35250
		// (get) Token: 0x06023D3E RID: 146750 RVA: 0x0034FD12 File Offset: 0x0034DF12
		// (set) Token: 0x06023D3F RID: 146751 RVA: 0x0034FD22 File Offset: 0x0034DF22
		public unsafe int GlobalTotalEmitters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalEmitters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalEmitters) = value;
			}
		}

		// Token: 0x170089B3 RID: 35251
		// (get) Token: 0x06023D40 RID: 146752 RVA: 0x0034FD33 File Offset: 0x0034DF33
		// (set) Token: 0x06023D41 RID: 146753 RVA: 0x0034FD43 File Offset: 0x0034DF43
		public unsafe int GlobalTotalParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalParticles) = value;
			}
		}

		// Token: 0x170089B4 RID: 35252
		// (get) Token: 0x06023D42 RID: 146754 RVA: 0x0034FD54 File Offset: 0x0034DF54
		// (set) Token: 0x06023D43 RID: 146755 RVA: 0x0034FD64 File Offset: 0x0034DF64
		public unsafe int GlobalTotalBatchActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchActive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchActive) = value;
			}
		}

		// Token: 0x170089B5 RID: 35253
		// (get) Token: 0x06023D44 RID: 146756 RVA: 0x0034FD75 File Offset: 0x0034DF75
		// (set) Token: 0x06023D45 RID: 146757 RVA: 0x0034FD85 File Offset: 0x0034DF85
		public unsafe int GlobalTotalBatchScalability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchScalability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchScalability) = value;
			}
		}

		// Token: 0x170089B6 RID: 35254
		// (get) Token: 0x06023D46 RID: 146758 RVA: 0x0034FD96 File Offset: 0x0034DF96
		// (set) Token: 0x06023D47 RID: 146759 RVA: 0x0034FDA6 File Offset: 0x0034DFA6
		public unsafe int GlobalTotalBatchEmitters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchEmitters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchEmitters) = value;
			}
		}

		// Token: 0x170089B7 RID: 35255
		// (get) Token: 0x06023D48 RID: 146760 RVA: 0x0034FDB7 File Offset: 0x0034DFB7
		// (set) Token: 0x06023D49 RID: 146761 RVA: 0x0034FDC7 File Offset: 0x0034DFC7
		public unsafe int GlobalTotalBatchParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGlobalInfoInHUD.__PropertyOffset_GlobalTotalBatchParticles) = value;
			}
		}

		// Token: 0x06023D4A RID: 146762 RVA: 0x0034FDD8 File Offset: 0x0034DFD8
		public FNiagaraGlobalInfoInHUD()
		{
		}

		// Token: 0x06023D4B RID: 146763 RVA: 0x0034FDE0 File Offset: 0x0034DFE0
		public FNiagaraGlobalInfoInHUD(int GlobalTotalActive, int GlobalTotalScalability, int GlobalTotalEmitters, int GlobalTotalParticles, int GlobalTotalBatchActive, int GlobalTotalBatchScalability, int GlobalTotalBatchEmitters, int GlobalTotalBatchParticles)
		{
			this.GlobalTotalActive = GlobalTotalActive;
			this.GlobalTotalScalability = GlobalTotalScalability;
			this.GlobalTotalEmitters = GlobalTotalEmitters;
			this.GlobalTotalParticles = GlobalTotalParticles;
			this.GlobalTotalBatchActive = GlobalTotalBatchActive;
			this.GlobalTotalBatchScalability = GlobalTotalBatchScalability;
			this.GlobalTotalBatchEmitters = GlobalTotalBatchEmitters;
			this.GlobalTotalBatchParticles = GlobalTotalBatchParticles;
		}

		// Token: 0x06023D4C RID: 146764 RVA: 0x0034FE30 File Offset: 0x0034E030
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraGlobalInfoInHUD.StaticStruct();
		}

		// Token: 0x06023D4D RID: 146765 RVA: 0x0034FE3C File Offset: 0x0034E03C
		[NullableContext(2)]
		public FNiagaraGlobalInfoInHUD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D4E RID: 146766 RVA: 0x0034FE46 File Offset: 0x0034E046
		public FNiagaraGlobalInfoInHUD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D4F RID: 146767 RVA: 0x0034FE51 File Offset: 0x0034E051
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraGlobalInfoInHUD(Pointer, false, true);
		}

		// Token: 0x06023D50 RID: 146768 RVA: 0x0034FE5B File Offset: 0x0034E05B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraGlobalInfoInHUD(Pointer, MemoryOwner);
		}

		// Token: 0x04013363 RID: 78691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraGlobalInfoInHUD";

		// Token: 0x04013364 RID: 78692
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013365 RID: 78693
		internal static int __PropertyOffset_GlobalTotalActive;

		// Token: 0x04013366 RID: 78694
		internal static int __PropertyOffset_GlobalTotalScalability;

		// Token: 0x04013367 RID: 78695
		internal static int __PropertyOffset_GlobalTotalEmitters;

		// Token: 0x04013368 RID: 78696
		internal static int __PropertyOffset_GlobalTotalParticles;

		// Token: 0x04013369 RID: 78697
		internal static int __PropertyOffset_GlobalTotalBatchActive;

		// Token: 0x0401336A RID: 78698
		internal static int __PropertyOffset_GlobalTotalBatchScalability;

		// Token: 0x0401336B RID: 78699
		internal static int __PropertyOffset_GlobalTotalBatchEmitters;

		// Token: 0x0401336C RID: 78700
		internal static int __PropertyOffset_GlobalTotalBatchParticles;
	}
}
