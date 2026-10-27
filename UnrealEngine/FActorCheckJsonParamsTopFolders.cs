using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007AF RID: 1967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorCheckJsonParamsTopFolders")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActorCheckJsonParamsTopFolders : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006902 RID: 26882 RVA: 0x00096D04 File Offset: 0x00094F04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorCheckJsonParamsTopFolders._ScriptStructPtr != 0) ? FActorCheckJsonParamsTopFolders._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorCheckJsonParamsTopFolders", ref FActorCheckJsonParamsTopFolders._ScriptStructPtr);
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x00096D28 File Offset: 0x00094F28
		// (set) Token: 0x06006904 RID: 26884 RVA: 0x00096D3C File Offset: 0x00094F3C
		public unsafe string FirstName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_FirstName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_FirstName)), value);
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06006905 RID: 26885 RVA: 0x00096D51 File Offset: 0x00094F51
		// (set) Token: 0x06006906 RID: 26886 RVA: 0x00096D65 File Offset: 0x00094F65
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x00096D7A File Offset: 0x00094F7A
		// (set) Token: 0x06006908 RID: 26888 RVA: 0x00096D8E File Offset: 0x00094F8E
		public unsafe string VersionMapAreaInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_VersionMapAreaInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsTopFolders.__PropertyOffset_VersionMapAreaInfo)), value);
			}
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x00096DA3 File Offset: 0x00094FA3
		public FActorCheckJsonParamsTopFolders()
		{
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00096DAB File Offset: 0x00094FAB
		public FActorCheckJsonParamsTopFolders(string FirstName, string Regex, string VersionMapAreaInfo)
		{
			this.FirstName = FirstName;
			this.Regex = Regex;
			this.VersionMapAreaInfo = VersionMapAreaInfo;
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x00096DC8 File Offset: 0x00094FC8
		protected override IntPtr GetUStructPtr()
		{
			return FActorCheckJsonParamsTopFolders.StaticStruct();
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x00096DD4 File Offset: 0x00094FD4
		[NullableContext(2)]
		public FActorCheckJsonParamsTopFolders(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00096DDE File Offset: 0x00094FDE
		public FActorCheckJsonParamsTopFolders(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x00096DE9 File Offset: 0x00094FE9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorCheckJsonParamsTopFolders(Pointer, false, true);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00096DF3 File Offset: 0x00094FF3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorCheckJsonParamsTopFolders(Pointer, MemoryOwner);
		}

		// Token: 0x040032AF RID: 12975
		public const string __ObjectPath = "/Script/Engine.ActorCheckJsonParamsTopFolders";

		// Token: 0x040032B0 RID: 12976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040032B1 RID: 12977
		internal static int __PropertyOffset_FirstName;

		// Token: 0x040032B2 RID: 12978
		internal static int __PropertyOffset_Regex;

		// Token: 0x040032B3 RID: 12979
		internal static int __PropertyOffset_VersionMapAreaInfo;
	}
}
