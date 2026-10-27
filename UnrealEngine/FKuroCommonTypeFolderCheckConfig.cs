using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE7 RID: 3303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroCommonTypeFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroCommonTypeFolderCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF47 RID: 44871 RVA: 0x000F8A4C File Offset: 0x000F6C4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCommonTypeFolderCheckConfig._ScriptStructPtr != 0) ? FKuroCommonTypeFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroCommonTypeFolderCheckConfig", ref FKuroCommonTypeFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x000F8A70 File Offset: 0x000F6C70
		// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x000F8A84 File Offset: 0x000F6C84
		public unsafe string ClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCommonTypeFolderCheckConfig.__PropertyOffset_ClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCommonTypeFolderCheckConfig.__PropertyOffset_ClassName)), value);
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x000F8A9C File Offset: 0x000F6C9C
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x000F8ADF File Offset: 0x000F6CDF
		public TArray<string> Regexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Regexes) == null)
				{
					result = (this._Regexes = new TArray<string>(base.NativePtr + (IntPtr)FKuroCommonTypeFolderCheckConfig.__PropertyOffset_Regexes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Regexes.CopyAssign(value);
			}
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x000F8AED File Offset: 0x000F6CED
		public FKuroCommonTypeFolderCheckConfig()
		{
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x000F8AF5 File Offset: 0x000F6CF5
		public FKuroCommonTypeFolderCheckConfig(string ClassName, TArray<string> Regexes)
		{
			this.ClassName = ClassName;
			this.Regexes = Regexes;
		}

		// Token: 0x0600AF4E RID: 44878 RVA: 0x000F8B0B File Offset: 0x000F6D0B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCommonTypeFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AF4F RID: 44879 RVA: 0x000F8B17 File Offset: 0x000F6D17
		[NullableContext(2)]
		public FKuroCommonTypeFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x000F8B21 File Offset: 0x000F6D21
		public FKuroCommonTypeFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x000F8B2C File Offset: 0x000F6D2C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCommonTypeFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AF52 RID: 44882 RVA: 0x000F8B36 File Offset: 0x000F6D36
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCommonTypeFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BCA RID: 23498
		public const string __ObjectPath = "/Script/Engine.KuroCommonTypeFolderCheckConfig";

		// Token: 0x04005BCB RID: 23499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BCC RID: 23500
		internal static int __PropertyOffset_ClassName;

		// Token: 0x04005BCD RID: 23501
		internal static int __PropertyOffset_Regexes;

		// Token: 0x04005BCE RID: 23502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Regexes;
	}
}
