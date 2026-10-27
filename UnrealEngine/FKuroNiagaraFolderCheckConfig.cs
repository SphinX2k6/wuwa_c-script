using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CFD RID: 3325
	[UnrealObjectPath("/Script/Engine.KuroNiagaraFolderCheckConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroNiagaraFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B115 RID: 45333 RVA: 0x000FB79C File Offset: 0x000F999C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNiagaraFolderCheckConfig._ScriptStructPtr != 0) ? FKuroNiagaraFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroNiagaraFolderCheckConfig", ref FKuroNiagaraFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x000FB7C0 File Offset: 0x000F99C0
		public FKuroNiagaraFolderCheckConfig()
		{
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x000FB7C8 File Offset: 0x000F99C8
		[NullableContext(1)]
		public FKuroNiagaraFolderCheckConfig(string Regex, int MatchingPriority)
		{
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x000FB7DE File Offset: 0x000F99DE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNiagaraFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x000FB7EA File Offset: 0x000F99EA
		[NullableContext(2)]
		public FKuroNiagaraFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x000FB7F4 File Offset: 0x000F99F4
		public FKuroNiagaraFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x000FB7FF File Offset: 0x000F99FF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNiagaraFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x000FB809 File Offset: 0x000F9A09
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNiagaraFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005CCC RID: 23756
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroNiagaraFolderCheckConfig";

		// Token: 0x04005CCD RID: 23757
		private static IntPtr _ScriptStructPtr;
	}
}
