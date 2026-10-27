using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CEB RID: 3307
	[UnrealObjectPath("/Script/Engine.KuroEffectModelNiagaraFolderCheckConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectModelNiagaraFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF7F RID: 44927 RVA: 0x000F8ED6 File Offset: 0x000F70D6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectModelNiagaraFolderCheckConfig._ScriptStructPtr != 0) ? FKuroEffectModelNiagaraFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroEffectModelNiagaraFolderCheckConfig", ref FKuroEffectModelNiagaraFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x000F8EFA File Offset: 0x000F70FA
		public FKuroEffectModelNiagaraFolderCheckConfig()
		{
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x000F8F02 File Offset: 0x000F7102
		[NullableContext(1)]
		public FKuroEffectModelNiagaraFolderCheckConfig(string Regex, int MatchingPriority)
		{
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x000F8F18 File Offset: 0x000F7118
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectModelNiagaraFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AF83 RID: 44931 RVA: 0x000F8F24 File Offset: 0x000F7124
		[NullableContext(2)]
		public FKuroEffectModelNiagaraFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF84 RID: 44932 RVA: 0x000F8F2E File Offset: 0x000F712E
		public FKuroEffectModelNiagaraFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF85 RID: 44933 RVA: 0x000F8F39 File Offset: 0x000F7139
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectModelNiagaraFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x000F8F43 File Offset: 0x000F7143
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectModelNiagaraFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BE5 RID: 23525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroEffectModelNiagaraFolderCheckConfig";

		// Token: 0x04005BE6 RID: 23526
		private static IntPtr _ScriptStructPtr;
	}
}
