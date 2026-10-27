using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F2 RID: 8434
	[UnrealObjectPath("/Script/LGUI.NiagaraTransitionOfState")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNiagaraTransitionOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC01 RID: 130049 RVA: 0x002F35D5 File Offset: 0x002F17D5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraTransitionOfState._ScriptStructPtr != 0) ? FNiagaraTransitionOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.NiagaraTransitionOfState", ref FNiagaraTransitionOfState._ScriptStructPtr);
		}

		// Token: 0x17007CFB RID: 31995
		// (get) Token: 0x0601FC02 RID: 130050 RVA: 0x002F35F9 File Offset: 0x002F17F9
		// (set) Token: 0x0601FC03 RID: 130051 RVA: 0x002F360D File Offset: 0x002F180D
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraTransitionOfState.__PropertyOffset_NiagaraSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraTransitionOfState.__PropertyOffset_NiagaraSystem, value);
			}
		}

		// Token: 0x17007CFC RID: 31996
		// (get) Token: 0x0601FC04 RID: 130052 RVA: 0x002F3622 File Offset: 0x002F1822
		// (set) Token: 0x0601FC05 RID: 130053 RVA: 0x002F3636 File Offset: 0x002F1836
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17007CFD RID: 31997
		// (get) Token: 0x0601FC06 RID: 130054 RVA: 0x002F364B File Offset: 0x002F184B
		// (set) Token: 0x0601FC07 RID: 130055 RVA: 0x002F365B File Offset: 0x002F185B
		public unsafe bool bActivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bActivate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bActivate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007CFE RID: 31998
		// (get) Token: 0x0601FC08 RID: 130056 RVA: 0x002F366C File Offset: 0x002F186C
		// (set) Token: 0x0601FC09 RID: 130057 RVA: 0x002F367C File Offset: 0x002F187C
		public unsafe bool bResetOnActivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bResetOnActivate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bResetOnActivate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007CFF RID: 31999
		// (get) Token: 0x0601FC0A RID: 130058 RVA: 0x002F368D File Offset: 0x002F188D
		// (set) Token: 0x0601FC0B RID: 130059 RVA: 0x002F36A6 File Offset: 0x002F18A6
		public unsafe bool bGradualChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bGradualChange) & FNiagaraTransitionOfState.__PropertyMask_bGradualChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bGradualChange) = ((*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_bGradualChange) & ~FNiagaraTransitionOfState.__PropertyMask_bGradualChange) | (value ? FNiagaraTransitionOfState.__PropertyMask_bGradualChange : 0));
			}
		}

		// Token: 0x17007D00 RID: 32000
		// (get) Token: 0x0601FC0C RID: 130060 RVA: 0x002F36D6 File Offset: 0x002F18D6
		// (set) Token: 0x0601FC0D RID: 130061 RVA: 0x002F36E6 File Offset: 0x002F18E6
		public unsafe float GradualDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_GradualDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTransitionOfState.__PropertyOffset_GradualDuration) = value;
			}
		}

		// Token: 0x0601FC0E RID: 130062 RVA: 0x002F36F7 File Offset: 0x002F18F7
		public FNiagaraTransitionOfState()
		{
		}

		// Token: 0x0601FC0F RID: 130063 RVA: 0x002F36FF File Offset: 0x002F18FF
		[NullableContext(1)]
		public FNiagaraTransitionOfState(UNiagaraSystem NiagaraSystem, string PredefineColor, FColor Color, bool bActivate, bool bResetOnActivate, bool bGradualChange, float GradualDuration)
		{
			this.NiagaraSystem = NiagaraSystem;
			this.Color = Color;
			this.bActivate = bActivate;
			this.bResetOnActivate = bResetOnActivate;
			this.bGradualChange = bGradualChange;
			this.GradualDuration = GradualDuration;
		}

		// Token: 0x0601FC10 RID: 130064 RVA: 0x002F3735 File Offset: 0x002F1935
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraTransitionOfState.StaticStruct();
		}

		// Token: 0x0601FC11 RID: 130065 RVA: 0x002F3741 File Offset: 0x002F1941
		[NullableContext(2)]
		public FNiagaraTransitionOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC12 RID: 130066 RVA: 0x002F374B File Offset: 0x002F194B
		public FNiagaraTransitionOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC13 RID: 130067 RVA: 0x002F3756 File Offset: 0x002F1956
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraTransitionOfState(Pointer, false, true);
		}

		// Token: 0x0601FC14 RID: 130068 RVA: 0x002F3760 File Offset: 0x002F1960
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraTransitionOfState(Pointer, MemoryOwner);
		}

		// Token: 0x040111DD RID: 70109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.NiagaraTransitionOfState";

		// Token: 0x040111DE RID: 70110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111DF RID: 70111
		internal static int __PropertyOffset_NiagaraSystem;

		// Token: 0x040111E0 RID: 70112
		internal static int __PropertyOffset_Color;

		// Token: 0x040111E1 RID: 70113
		internal static int __PropertyOffset_bActivate;

		// Token: 0x040111E2 RID: 70114
		internal static int __PropertyOffset_bResetOnActivate;

		// Token: 0x040111E3 RID: 70115
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x040111E4 RID: 70116
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x040111E5 RID: 70117
		internal static int __PropertyOffset_GradualDuration;
	}
}
