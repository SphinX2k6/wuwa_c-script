using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047B RID: 1147
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.NamedLensPreset")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNamedLensPreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D84 RID: 15748 RVA: 0x0005C76E File Offset: 0x0005A96E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedLensPreset._ScriptStructPtr != 0) ? FNamedLensPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.NamedLensPreset", ref FNamedLensPreset._ScriptStructPtr);
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x0005C792 File Offset: 0x0005A992
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x0005C7A6 File Offset: 0x0005A9A6
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

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x0005C7BC File Offset: 0x0005A9BC
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x0005C7FF File Offset: 0x0005A9FF
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

		// Token: 0x06003D89 RID: 15753 RVA: 0x0005C820 File Offset: 0x0005AA20
		public FNamedLensPreset()
		{
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x0005C828 File Offset: 0x0005AA28
		public FNamedLensPreset(string Name, FCameraLensSettings LensSettings)
		{
			this.Name = Name;
			this.LensSettings = LensSettings;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x0005C83E File Offset: 0x0005AA3E
		protected override IntPtr GetUStructPtr()
		{
			return FNamedLensPreset.StaticStruct();
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0005C84A File Offset: 0x0005AA4A
		[NullableContext(2)]
		public FNamedLensPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0005C854 File Offset: 0x0005AA54
		public FNamedLensPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x0005C85F File Offset: 0x0005AA5F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedLensPreset(Pointer, false, true);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x0005C869 File Offset: 0x0005AA69
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedLensPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04001CDD RID: 7389
		public const string __ObjectPath = "/Script/CinematicCamera.NamedLensPreset";

		// Token: 0x04001CDE RID: 7390
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001CDF RID: 7391
		internal static int __PropertyOffset_Name;

		// Token: 0x04001CE0 RID: 7392
		internal static int __PropertyOffset_LensSettings;

		// Token: 0x04001CE1 RID: 7393
		[Nullable(2)]
		private FCameraLensSettings _LensSettings;
	}
}
