using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF0 RID: 3312
	[UnrealObjectPath("/Script/Engine.KuroLevelFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroLevelFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AFCC RID: 45004 RVA: 0x000F955F File Offset: 0x000F775F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelFolderCheckConfig._ScriptStructPtr != 0) ? FKuroLevelFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroLevelFolderCheckConfig", ref FKuroLevelFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x0600AFCD RID: 45005 RVA: 0x000F9583 File Offset: 0x000F7783
		// (set) Token: 0x0600AFCE RID: 45006 RVA: 0x000F9593 File Offset: 0x000F7793
		public unsafe bool bCheckLevelActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelFolderCheckConfig.__PropertyOffset_bCheckLevelActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelFolderCheckConfig.__PropertyOffset_bCheckLevelActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600AFCF RID: 45007 RVA: 0x000F95A4 File Offset: 0x000F77A4
		// (set) Token: 0x0600AFD0 RID: 45008 RVA: 0x000F95B4 File Offset: 0x000F77B4
		public unsafe bool bCheckBaimoFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelFolderCheckConfig.__PropertyOffset_bCheckBaimoFolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelFolderCheckConfig.__PropertyOffset_bCheckBaimoFolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x000F95C5 File Offset: 0x000F77C5
		public FKuroLevelFolderCheckConfig()
		{
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x000F95CD File Offset: 0x000F77CD
		[NullableContext(1)]
		public FKuroLevelFolderCheckConfig(bool bCheckLevelActor, bool bCheckBaimoFolder, string Regex, int MatchingPriority)
		{
			this.bCheckLevelActor = bCheckLevelActor;
			this.bCheckBaimoFolder = bCheckBaimoFolder;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x000F95F2 File Offset: 0x000F77F2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x000F95FE File Offset: 0x000F77FE
		[NullableContext(2)]
		public FKuroLevelFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x000F9608 File Offset: 0x000F7808
		public FKuroLevelFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x000F9613 File Offset: 0x000F7813
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x000F961D File Offset: 0x000F781D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005C0A RID: 23562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroLevelFolderCheckConfig";

		// Token: 0x04005C0B RID: 23563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C0C RID: 23564
		internal static int __PropertyOffset_bCheckLevelActor;

		// Token: 0x04005C0D RID: 23565
		internal static int __PropertyOffset_bCheckBaimoFolder;
	}
}
