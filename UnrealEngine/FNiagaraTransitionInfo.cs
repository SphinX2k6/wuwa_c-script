using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F1 RID: 8433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.NiagaraTransitionInfo")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FNiagaraTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FBF1 RID: 130033 RVA: 0x002F33BD File Offset: 0x002F15BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraTransitionInfo._ScriptStructPtr != 0) ? FNiagaraTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.NiagaraTransitionInfo", ref FNiagaraTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17007CF7 RID: 31991
		// (get) Token: 0x0601FBF2 RID: 130034 RVA: 0x002F33E4 File Offset: 0x002F15E4
		// (set) Token: 0x0601FBF3 RID: 130035 RVA: 0x002F3427 File Offset: 0x002F1627
		public FNiagaraTransitionOfState NormalTransition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTransitionOfState result;
				if ((result = this._NormalTransition) == null)
				{
					result = (this._NormalTransition = new FNiagaraTransitionOfState(base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_NormalTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_NormalTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007CF8 RID: 31992
		// (get) Token: 0x0601FBF4 RID: 130036 RVA: 0x002F3448 File Offset: 0x002F1648
		// (set) Token: 0x0601FBF5 RID: 130037 RVA: 0x002F348B File Offset: 0x002F168B
		public FNiagaraTransitionOfState HighlightedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTransitionOfState result;
				if ((result = this._HighlightedTransition) == null)
				{
					result = (this._HighlightedTransition = new FNiagaraTransitionOfState(base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_HighlightedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_HighlightedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007CF9 RID: 31993
		// (get) Token: 0x0601FBF6 RID: 130038 RVA: 0x002F34AC File Offset: 0x002F16AC
		// (set) Token: 0x0601FBF7 RID: 130039 RVA: 0x002F34EF File Offset: 0x002F16EF
		public FNiagaraTransitionOfState PressedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTransitionOfState result;
				if ((result = this._PressedTransition) == null)
				{
					result = (this._PressedTransition = new FNiagaraTransitionOfState(base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_PressedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_PressedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007CFA RID: 31994
		// (get) Token: 0x0601FBF8 RID: 130040 RVA: 0x002F3510 File Offset: 0x002F1710
		// (set) Token: 0x0601FBF9 RID: 130041 RVA: 0x002F3553 File Offset: 0x002F1753
		public FNiagaraTransitionOfState DisabledTransition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTransitionOfState result;
				if ((result = this._DisabledTransition) == null)
				{
					result = (this._DisabledTransition = new FNiagaraTransitionOfState(base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_DisabledTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraTransitionInfo.__PropertyOffset_DisabledTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FBFA RID: 130042 RVA: 0x002F3574 File Offset: 0x002F1774
		public FNiagaraTransitionInfo()
		{
		}

		// Token: 0x0601FBFB RID: 130043 RVA: 0x002F357C File Offset: 0x002F177C
		public FNiagaraTransitionInfo(FNiagaraTransitionOfState NormalTransition, FNiagaraTransitionOfState HighlightedTransition, FNiagaraTransitionOfState PressedTransition, FNiagaraTransitionOfState DisabledTransition)
		{
			this.NormalTransition = NormalTransition;
			this.HighlightedTransition = HighlightedTransition;
			this.PressedTransition = PressedTransition;
			this.DisabledTransition = DisabledTransition;
		}

		// Token: 0x0601FBFC RID: 130044 RVA: 0x002F35A1 File Offset: 0x002F17A1
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraTransitionInfo.StaticStruct();
		}

		// Token: 0x0601FBFD RID: 130045 RVA: 0x002F35AD File Offset: 0x002F17AD
		[NullableContext(2)]
		public FNiagaraTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBFE RID: 130046 RVA: 0x002F35B7 File Offset: 0x002F17B7
		public FNiagaraTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBFF RID: 130047 RVA: 0x002F35C2 File Offset: 0x002F17C2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0601FC00 RID: 130048 RVA: 0x002F35CC File Offset: 0x002F17CC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040111D3 RID: 70099
		public const string __ObjectPath = "/Script/LGUI.NiagaraTransitionInfo";

		// Token: 0x040111D4 RID: 70100
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111D5 RID: 70101
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x040111D6 RID: 70102
		[Nullable(2)]
		private FNiagaraTransitionOfState _NormalTransition;

		// Token: 0x040111D7 RID: 70103
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x040111D8 RID: 70104
		[Nullable(2)]
		private FNiagaraTransitionOfState _HighlightedTransition;

		// Token: 0x040111D9 RID: 70105
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x040111DA RID: 70106
		[Nullable(2)]
		private FNiagaraTransitionOfState _PressedTransition;

		// Token: 0x040111DB RID: 70107
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x040111DC RID: 70108
		[Nullable(2)]
		private FNiagaraTransitionOfState _DisabledTransition;
	}
}
