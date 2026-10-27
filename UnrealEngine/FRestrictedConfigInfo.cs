using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013EA RID: 5098
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.RestrictedConfigInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRestrictedConfigInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012A27 RID: 76327 RVA: 0x001B6B86 File Offset: 0x001B4D86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRestrictedConfigInfo._ScriptStructPtr != 0) ? FRestrictedConfigInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.RestrictedConfigInfo", ref FRestrictedConfigInfo._ScriptStructPtr);
		}

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x06012A28 RID: 76328 RVA: 0x001B6BAA File Offset: 0x001B4DAA
		// (set) Token: 0x06012A29 RID: 76329 RVA: 0x001B6BBE File Offset: 0x001B4DBE
		public unsafe string RestrictedConfigName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRestrictedConfigInfo.__PropertyOffset_RestrictedConfigName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRestrictedConfigInfo.__PropertyOffset_RestrictedConfigName)), value);
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x06012A2A RID: 76330 RVA: 0x001B6BD4 File Offset: 0x001B4DD4
		// (set) Token: 0x06012A2B RID: 76331 RVA: 0x001B6C17 File Offset: 0x001B4E17
		public TArray<string> Owners
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Owners) == null)
				{
					result = (this._Owners = new TArray<string>(base.NativePtr + (IntPtr)FRestrictedConfigInfo.__PropertyOffset_Owners, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Owners.CopyAssign(value);
			}
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x001B6C25 File Offset: 0x001B4E25
		public FRestrictedConfigInfo()
		{
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x001B6C2D File Offset: 0x001B4E2D
		public FRestrictedConfigInfo(string RestrictedConfigName, TArray<string> Owners)
		{
			this.RestrictedConfigName = RestrictedConfigName;
			this.Owners = Owners;
		}

		// Token: 0x06012A2E RID: 76334 RVA: 0x001B6C43 File Offset: 0x001B4E43
		protected override IntPtr GetUStructPtr()
		{
			return FRestrictedConfigInfo.StaticStruct();
		}

		// Token: 0x06012A2F RID: 76335 RVA: 0x001B6C4F File Offset: 0x001B4E4F
		[NullableContext(2)]
		public FRestrictedConfigInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012A30 RID: 76336 RVA: 0x001B6C59 File Offset: 0x001B4E59
		public FRestrictedConfigInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x001B6C64 File Offset: 0x001B4E64
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRestrictedConfigInfo(Pointer, false, true);
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x001B6C6E File Offset: 0x001B4E6E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRestrictedConfigInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009F4C RID: 40780
		public const string __ObjectPath = "/Script/GameplayTags.RestrictedConfigInfo";

		// Token: 0x04009F4D RID: 40781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F4E RID: 40782
		internal static int __PropertyOffset_RestrictedConfigName;

		// Token: 0x04009F4F RID: 40783
		internal static int __PropertyOffset_Owners;

		// Token: 0x04009F50 RID: 40784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Owners;
	}
}
