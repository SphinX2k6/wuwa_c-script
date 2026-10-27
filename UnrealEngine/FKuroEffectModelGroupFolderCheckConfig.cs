using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CEA RID: 3306
	[UnrealObjectPath("/Script/Engine.KuroEffectModelGroupFolderCheckConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectModelGroupFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF77 RID: 44919 RVA: 0x000F8E60 File Offset: 0x000F7060
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectModelGroupFolderCheckConfig._ScriptStructPtr != 0) ? FKuroEffectModelGroupFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroEffectModelGroupFolderCheckConfig", ref FKuroEffectModelGroupFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x000F8E84 File Offset: 0x000F7084
		public FKuroEffectModelGroupFolderCheckConfig()
		{
		}

		// Token: 0x0600AF79 RID: 44921 RVA: 0x000F8E8C File Offset: 0x000F708C
		[NullableContext(1)]
		public FKuroEffectModelGroupFolderCheckConfig(string Regex, int MatchingPriority)
		{
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x000F8EA2 File Offset: 0x000F70A2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectModelGroupFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AF7B RID: 44923 RVA: 0x000F8EAE File Offset: 0x000F70AE
		[NullableContext(2)]
		public FKuroEffectModelGroupFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF7C RID: 44924 RVA: 0x000F8EB8 File Offset: 0x000F70B8
		public FKuroEffectModelGroupFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF7D RID: 44925 RVA: 0x000F8EC3 File Offset: 0x000F70C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectModelGroupFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x000F8ECD File Offset: 0x000F70CD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectModelGroupFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BE3 RID: 23523
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroEffectModelGroupFolderCheckConfig";

		// Token: 0x04005BE4 RID: 23524
		private static IntPtr _ScriptStructPtr;
	}
}
