using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047A RID: 1146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.NamedFilmbackPreset")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNamedFilmbackPreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D78 RID: 15736 RVA: 0x0005C66B File Offset: 0x0005A86B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedFilmbackPreset._ScriptStructPtr != 0) ? FNamedFilmbackPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.NamedFilmbackPreset", ref FNamedFilmbackPreset._ScriptStructPtr);
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x0005C68F File Offset: 0x0005A88F
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x0005C6A3 File Offset: 0x0005A8A3
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNamedFilmbackPreset.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNamedFilmbackPreset.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x0005C6FB File Offset: 0x0005A8FB
		public FCameraFilmbackSettings FilmbackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFilmbackSettings result;
				if ((result = this._FilmbackSettings) == null)
				{
					result = (this._FilmbackSettings = new FCameraFilmbackSettings(base.NativePtr + (IntPtr)FNamedFilmbackPreset.__PropertyOffset_FilmbackSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFilmbackSettings.StaticStruct(), base.NativePtr + (IntPtr)FNamedFilmbackPreset.__PropertyOffset_FilmbackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x0005C71C File Offset: 0x0005A91C
		public FNamedFilmbackPreset()
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x0005C724 File Offset: 0x0005A924
		public FNamedFilmbackPreset(string Name, FCameraFilmbackSettings FilmbackSettings)
		{
			this.Name = Name;
			this.FilmbackSettings = FilmbackSettings;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0005C73A File Offset: 0x0005A93A
		protected override IntPtr GetUStructPtr()
		{
			return FNamedFilmbackPreset.StaticStruct();
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x0005C746 File Offset: 0x0005A946
		[NullableContext(2)]
		public FNamedFilmbackPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0005C750 File Offset: 0x0005A950
		public FNamedFilmbackPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x0005C75B File Offset: 0x0005A95B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedFilmbackPreset(Pointer, false, true);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x0005C765 File Offset: 0x0005A965
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedFilmbackPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04001CD8 RID: 7384
		public const string __ObjectPath = "/Script/CinematicCamera.NamedFilmbackPreset";

		// Token: 0x04001CD9 RID: 7385
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001CDA RID: 7386
		internal static int __PropertyOffset_Name;

		// Token: 0x04001CDB RID: 7387
		internal static int __PropertyOffset_FilmbackSettings;

		// Token: 0x04001CDC RID: 7388
		[Nullable(2)]
		private FCameraFilmbackSettings _FilmbackSettings;
	}
}
