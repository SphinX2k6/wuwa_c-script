using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C44 RID: 3140
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ImportFactorySettingValues")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FImportFactorySettingValues : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F5D RID: 40797 RVA: 0x000E2830 File Offset: 0x000E0A30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImportFactorySettingValues._ScriptStructPtr != 0) ? FImportFactorySettingValues._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ImportFactorySettingValues", ref FImportFactorySettingValues._ScriptStructPtr);
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x000E2854 File Offset: 0x000E0A54
		// (set) Token: 0x06009F5F RID: 40799 RVA: 0x000E2868 File Offset: 0x000E0A68
		public unsafe string SettingName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FImportFactorySettingValues.__PropertyOffset_SettingName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FImportFactorySettingValues.__PropertyOffset_SettingName)), value);
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x000E287D File Offset: 0x000E0A7D
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x000E2891 File Offset: 0x000E0A91
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FImportFactorySettingValues.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FImportFactorySettingValues.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x000E28A6 File Offset: 0x000E0AA6
		public FImportFactorySettingValues()
		{
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x000E28AE File Offset: 0x000E0AAE
		public FImportFactorySettingValues(string SettingName, string Value)
		{
			this.SettingName = SettingName;
			this.Value = Value;
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x000E28C4 File Offset: 0x000E0AC4
		protected override IntPtr GetUStructPtr()
		{
			return FImportFactorySettingValues.StaticStruct();
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x000E28D0 File Offset: 0x000E0AD0
		[NullableContext(2)]
		public FImportFactorySettingValues(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x000E28DA File Offset: 0x000E0ADA
		public FImportFactorySettingValues(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x000E28E5 File Offset: 0x000E0AE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImportFactorySettingValues(Pointer, false, true);
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x000E28EF File Offset: 0x000E0AEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImportFactorySettingValues(Pointer, MemoryOwner);
		}

		// Token: 0x040057B9 RID: 22457
		public const string __ObjectPath = "/Script/Engine.ImportFactorySettingValues";

		// Token: 0x040057BA RID: 22458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057BB RID: 22459
		internal static int __PropertyOffset_SettingName;

		// Token: 0x040057BC RID: 22460
		internal static int __PropertyOffset_Value;
	}
}
