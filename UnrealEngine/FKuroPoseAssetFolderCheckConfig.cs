using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D03 RID: 3331
	[UnrealObjectPath("/Script/Engine.KuroPoseAssetFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroPoseAssetFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B15D RID: 45405 RVA: 0x000FBC3D File Offset: 0x000F9E3D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPoseAssetFolderCheckConfig._ScriptStructPtr != 0) ? FKuroPoseAssetFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroPoseAssetFolderCheckConfig", ref FKuroPoseAssetFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600B15E RID: 45406 RVA: 0x000FBC61 File Offset: 0x000F9E61
		// (set) Token: 0x0600B15F RID: 45407 RVA: 0x000FBC7A File Offset: 0x000F9E7A
		public unsafe bool IsAdditive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPoseAssetFolderCheckConfig.__PropertyOffset_IsAdditive) & FKuroPoseAssetFolderCheckConfig.__PropertyMask_IsAdditive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPoseAssetFolderCheckConfig.__PropertyOffset_IsAdditive) = ((*(base.NativePtr + (IntPtr)FKuroPoseAssetFolderCheckConfig.__PropertyOffset_IsAdditive) & ~FKuroPoseAssetFolderCheckConfig.__PropertyMask_IsAdditive) | (value ? FKuroPoseAssetFolderCheckConfig.__PropertyMask_IsAdditive : 0));
			}
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x000FBCAA File Offset: 0x000F9EAA
		public FKuroPoseAssetFolderCheckConfig()
		{
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x000FBCB2 File Offset: 0x000F9EB2
		[NullableContext(1)]
		public FKuroPoseAssetFolderCheckConfig(bool IsAdditive, string Regex, int MatchingPriority)
		{
			this.IsAdditive = IsAdditive;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x000FBCCF File Offset: 0x000F9ECF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPoseAssetFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x000FBCDB File Offset: 0x000F9EDB
		[NullableContext(2)]
		public FKuroPoseAssetFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x000FBCE5 File Offset: 0x000F9EE5
		public FKuroPoseAssetFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x000FBCF0 File Offset: 0x000F9EF0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPoseAssetFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x000FBCFA File Offset: 0x000F9EFA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPoseAssetFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005CE1 RID: 23777
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroPoseAssetFolderCheckConfig";

		// Token: 0x04005CE2 RID: 23778
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CE3 RID: 23779
		internal static int __PropertyOffset_IsAdditive;

		// Token: 0x04005CE4 RID: 23780
		internal static byte __PropertyMask_IsAdditive;
	}
}
