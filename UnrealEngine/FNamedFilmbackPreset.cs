using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EA RID: 234
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.NamedFilmbackPreset")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNamedFilmbackPreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600106C RID: 4204 RVA: 0x0001A273 File Offset: 0x00018473
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedFilmbackPreset._ScriptStructPtr != 0) ? FNamedFilmbackPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.NamedFilmbackPreset", ref FNamedFilmbackPreset._ScriptStructPtr);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0001A297 File Offset: 0x00018497
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x0001A2AB File Offset: 0x000184AB
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0001A2C0 File Offset: 0x000184C0
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x0001A303 File Offset: 0x00018503
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

		// Token: 0x06001071 RID: 4209 RVA: 0x0001A324 File Offset: 0x00018524
		public FNamedFilmbackPreset()
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0001A32C File Offset: 0x0001852C
		protected override IntPtr GetUStructPtr()
		{
			return FNamedFilmbackPreset.StaticStruct();
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0001A338 File Offset: 0x00018538
		[NullableContext(2)]
		public FNamedFilmbackPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0001A342 File Offset: 0x00018542
		public FNamedFilmbackPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0001A34D File Offset: 0x0001854D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedFilmbackPreset(Pointer, false, true);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0001A357 File Offset: 0x00018557
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedFilmbackPreset(Pointer, MemoryOwner);
		}

		// Token: 0x040003E9 RID: 1001
		public const string __ObjectPath = "/Script/CinematicCamera.NamedFilmbackPreset";

		// Token: 0x040003EA RID: 1002
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003EB RID: 1003
		internal static int __PropertyOffset_Name;

		// Token: 0x040003EC RID: 1004
		internal static int __PropertyOffset_FilmbackSettings;

		// Token: 0x040003ED RID: 1005
		[Nullable(2)]
		private FCameraFilmbackSettings _FilmbackSettings;
	}
}
