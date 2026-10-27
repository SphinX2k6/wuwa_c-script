using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000252 RID: 594
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWaapiFieldNames")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAkWaapiFieldNames : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600230D RID: 8973 RVA: 0x00033EC3 File Offset: 0x000320C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWaapiFieldNames._ScriptStructPtr != 0) ? FAkWaapiFieldNames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWaapiFieldNames", ref FAkWaapiFieldNames._ScriptStructPtr);
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x00033EE7 File Offset: 0x000320E7
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x00033EFB File Offset: 0x000320FB
		public unsafe string FieldName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWaapiFieldNames.__PropertyOffset_FieldName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWaapiFieldNames.__PropertyOffset_FieldName)), value);
			}
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00033F10 File Offset: 0x00032110
		public FAkWaapiFieldNames()
		{
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00033F18 File Offset: 0x00032118
		public FAkWaapiFieldNames(string FieldName)
		{
			this.FieldName = FieldName;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00033F27 File Offset: 0x00032127
		protected override IntPtr GetUStructPtr()
		{
			return FAkWaapiFieldNames.StaticStruct();
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00033F33 File Offset: 0x00032133
		[NullableContext(2)]
		public FAkWaapiFieldNames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00033F3D File Offset: 0x0003213D
		public FAkWaapiFieldNames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00033F48 File Offset: 0x00032148
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWaapiFieldNames(Pointer, false, true);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00033F52 File Offset: 0x00032152
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWaapiFieldNames(Pointer, MemoryOwner);
		}

		// Token: 0x04000C20 RID: 3104
		public const string __ObjectPath = "/Script/AkAudio.AkWaapiFieldNames";

		// Token: 0x04000C21 RID: 3105
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C22 RID: 3106
		internal static int __PropertyOffset_FieldName;
	}
}
