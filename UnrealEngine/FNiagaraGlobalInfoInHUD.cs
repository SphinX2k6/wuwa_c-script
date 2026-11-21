using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007A9 RID: 1961
	[UnrealObjectPath("/Script/Niagara.NiagaraGlobalInfoInHUD")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraGlobalInfoInHUD : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AA67 RID: 43623 RVA: 0x000FB5F1 File Offset: 0x000F97F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraGlobalInfoInHUD._ScriptStructPtr != 0) ? FNiagaraGlobalInfoInHUD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraGlobalInfoInHUD", ref FNiagaraGlobalInfoInHUD._ScriptStructPtr);
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x000FB615 File Offset: 0x000F9815
		// (set) Token: 0x0600AA69 RID: 43625 RVA: 0x000FB625 File Offset: 0x000F9825
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

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x0600AA6A RID: 43626 RVA: 0x000FB636 File Offset: 0x000F9836
		// (set) Token: 0x0600AA6B RID: 43627 RVA: 0x000FB646 File Offset: 0x000F9846
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x000FB657 File Offset: 0x000F9857
		// (set) Token: 0x0600AA6D RID: 43629 RVA: 0x000FB667 File Offset: 0x000F9867
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

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600AA6E RID: 43630 RVA: 0x000FB678 File Offset: 0x000F9878
		// (set) Token: 0x0600AA6F RID: 43631 RVA: 0x000FB688 File Offset: 0x000F9888
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

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600AA70 RID: 43632 RVA: 0x000FB699 File Offset: 0x000F9899
		// (set) Token: 0x0600AA71 RID: 43633 RVA: 0x000FB6A9 File Offset: 0x000F98A9
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

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x000FB6BA File Offset: 0x000F98BA
		// (set) Token: 0x0600AA73 RID: 43635 RVA: 0x000FB6CA File Offset: 0x000F98CA
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600AA74 RID: 43636 RVA: 0x000FB6DB File Offset: 0x000F98DB
		// (set) Token: 0x0600AA75 RID: 43637 RVA: 0x000FB6EB File Offset: 0x000F98EB
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600AA76 RID: 43638 RVA: 0x000FB6FC File Offset: 0x000F98FC
		// (set) Token: 0x0600AA77 RID: 43639 RVA: 0x000FB70C File Offset: 0x000F990C
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

		// Token: 0x0600AA78 RID: 43640 RVA: 0x000FB71D File Offset: 0x000F991D
		public FNiagaraGlobalInfoInHUD()
		{
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x000FB725 File Offset: 0x000F9925
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraGlobalInfoInHUD.StaticStruct();
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x000FB731 File Offset: 0x000F9931
		[NullableContext(2)]
		public FNiagaraGlobalInfoInHUD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x000FB73B File Offset: 0x000F993B
		public FNiagaraGlobalInfoInHUD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x000FB746 File Offset: 0x000F9946
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraGlobalInfoInHUD(Pointer, false, true);
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x000FB750 File Offset: 0x000F9950
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraGlobalInfoInHUD(Pointer, MemoryOwner);
		}

		// Token: 0x040048F1 RID: 18673
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraGlobalInfoInHUD";

		// Token: 0x040048F2 RID: 18674
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040048F3 RID: 18675
		internal static int __PropertyOffset_GlobalTotalActive;

		// Token: 0x040048F4 RID: 18676
		internal static int __PropertyOffset_GlobalTotalScalability;

		// Token: 0x040048F5 RID: 18677
		internal static int __PropertyOffset_GlobalTotalEmitters;

		// Token: 0x040048F6 RID: 18678
		internal static int __PropertyOffset_GlobalTotalParticles;

		// Token: 0x040048F7 RID: 18679
		internal static int __PropertyOffset_GlobalTotalBatchActive;

		// Token: 0x040048F8 RID: 18680
		internal static int __PropertyOffset_GlobalTotalBatchScalability;

		// Token: 0x040048F9 RID: 18681
		internal static int __PropertyOffset_GlobalTotalBatchEmitters;

		// Token: 0x040048FA RID: 18682
		internal static int __PropertyOffset_GlobalTotalBatchParticles;
	}
}
