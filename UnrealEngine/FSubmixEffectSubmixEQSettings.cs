using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000384 RID: 900
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectSubmixEQSettings")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSubmixEffectSubmixEQSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003195 RID: 12693 RVA: 0x0004CA0A File Offset: 0x0004AC0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubmixEffectSubmixEQSettings._ScriptStructPtr != 0) ? FSubmixEffectSubmixEQSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioMixer.SubmixEffectSubmixEQSettings", ref FSubmixEffectSubmixEQSettings._ScriptStructPtr);
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0004CA30 File Offset: 0x0004AC30
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0004CA73 File Offset: 0x0004AC73
		public TArray<FSubmixEffectEQBand> EQBands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSubmixEffectEQBand> result;
				if ((result = this._EQBands) == null)
				{
					result = (this._EQBands = new TArray<FSubmixEffectEQBand>(base.NativePtr + (IntPtr)FSubmixEffectSubmixEQSettings.__PropertyOffset_EQBands, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EQBands.CopyAssign(value);
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0004CA81 File Offset: 0x0004AC81
		public FSubmixEffectSubmixEQSettings()
		{
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x0004CA89 File Offset: 0x0004AC89
		public FSubmixEffectSubmixEQSettings(TArray<FSubmixEffectEQBand> EQBands)
		{
			this.EQBands = EQBands;
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0004CA98 File Offset: 0x0004AC98
		protected override IntPtr GetUStructPtr()
		{
			return FSubmixEffectSubmixEQSettings.StaticStruct();
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		[NullableContext(2)]
		public FSubmixEffectSubmixEQSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0004CAAE File Offset: 0x0004ACAE
		public FSubmixEffectSubmixEQSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0004CAB9 File Offset: 0x0004ACB9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubmixEffectSubmixEQSettings(Pointer, false, true);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0004CAC3 File Offset: 0x0004ACC3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubmixEffectSubmixEQSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001595 RID: 5525
		public const string __ObjectPath = "/Script/AudioMixer.SubmixEffectSubmixEQSettings";

		// Token: 0x04001596 RID: 5526
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001597 RID: 5527
		internal static int __PropertyOffset_EQBands;

		// Token: 0x04001598 RID: 5528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSubmixEffectEQBand> _EQBands;
	}
}
