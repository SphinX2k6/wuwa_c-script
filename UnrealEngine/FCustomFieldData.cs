using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000433 RID: 1075
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BuildPatchServices.CustomFieldData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCustomFieldData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060039CB RID: 14795 RVA: 0x000579D3 File Offset: 0x00055BD3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomFieldData._ScriptStructPtr != 0) ? FCustomFieldData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/BuildPatchServices.CustomFieldData", ref FCustomFieldData._ScriptStructPtr);
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x000579F7 File Offset: 0x00055BF7
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x00057A0B File Offset: 0x00055C0B
		public unsafe string Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomFieldData.__PropertyOffset_Key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomFieldData.__PropertyOffset_Key)), value);
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x00057A20 File Offset: 0x00055C20
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x00057A34 File Offset: 0x00055C34
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomFieldData.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomFieldData.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x00057A49 File Offset: 0x00055C49
		public FCustomFieldData()
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00057A51 File Offset: 0x00055C51
		public FCustomFieldData(string Key, string Value)
		{
			this.Key = Key;
			this.Value = Value;
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x00057A67 File Offset: 0x00055C67
		protected override IntPtr GetUStructPtr()
		{
			return FCustomFieldData.StaticStruct();
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x00057A73 File Offset: 0x00055C73
		[NullableContext(2)]
		public FCustomFieldData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00057A7D File Offset: 0x00055C7D
		public FCustomFieldData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00057A88 File Offset: 0x00055C88
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomFieldData(Pointer, false, true);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00057A92 File Offset: 0x00055C92
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomFieldData(Pointer, MemoryOwner);
		}

		// Token: 0x04001A57 RID: 6743
		public const string __ObjectPath = "/Script/BuildPatchServices.CustomFieldData";

		// Token: 0x04001A58 RID: 6744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001A59 RID: 6745
		internal static int __PropertyOffset_Key;

		// Token: 0x04001A5A RID: 6746
		internal static int __PropertyOffset_Value;
	}
}
