using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EB RID: 235
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.NamedLensPreset")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNamedLensPreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001077 RID: 4215 RVA: 0x0001A360 File Offset: 0x00018560
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedLensPreset._ScriptStructPtr != 0) ? FNamedLensPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.NamedLensPreset", ref FNamedLensPreset._ScriptStructPtr);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0001A384 File Offset: 0x00018584
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x0001A398 File Offset: 0x00018598
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNamedLensPreset.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNamedLensPreset.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0001A3B0 File Offset: 0x000185B0
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0001A3F3 File Offset: 0x000185F3
		public FCameraLensSettings LensSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraLensSettings result;
				if ((result = this._LensSettings) == null)
				{
					result = (this._LensSettings = new FCameraLensSettings(base.NativePtr + (IntPtr)FNamedLensPreset.__PropertyOffset_LensSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraLensSettings.StaticStruct(), base.NativePtr + (IntPtr)FNamedLensPreset.__PropertyOffset_LensSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0001A414 File Offset: 0x00018614
		public FNamedLensPreset()
		{
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0001A41C File Offset: 0x0001861C
		protected override IntPtr GetUStructPtr()
		{
			return FNamedLensPreset.StaticStruct();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0001A428 File Offset: 0x00018628
		[NullableContext(2)]
		public FNamedLensPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0001A432 File Offset: 0x00018632
		public FNamedLensPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0001A43D File Offset: 0x0001863D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedLensPreset(Pointer, false, true);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0001A447 File Offset: 0x00018647
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedLensPreset(Pointer, MemoryOwner);
		}

		// Token: 0x040003EE RID: 1006
		public const string __ObjectPath = "/Script/CinematicCamera.NamedLensPreset";

		// Token: 0x040003EF RID: 1007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003F0 RID: 1008
		internal static int __PropertyOffset_Name;

		// Token: 0x040003F1 RID: 1009
		internal static int __PropertyOffset_LensSettings;

		// Token: 0x040003F2 RID: 1010
		[Nullable(2)]
		private FCameraLensSettings _LensSettings;
	}
}
