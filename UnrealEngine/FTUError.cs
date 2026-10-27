using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028F3 RID: 10483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TUError")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTUError : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026E13 RID: 159251 RVA: 0x003B4E7F File Offset: 0x003B307F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTUError._ScriptStructPtr != 0) ? FTUError._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TUError", ref FTUError._ScriptStructPtr);
		}

		// Token: 0x170095C8 RID: 38344
		// (get) Token: 0x06026E14 RID: 159252 RVA: 0x003B4EA3 File Offset: 0x003B30A3
		// (set) Token: 0x06026E15 RID: 159253 RVA: 0x003B4EB3 File Offset: 0x003B30B3
		public unsafe int code
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTUError.__PropertyOffset_code);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTUError.__PropertyOffset_code) = value;
			}
		}

		// Token: 0x170095C9 RID: 38345
		// (get) Token: 0x06026E16 RID: 159254 RVA: 0x003B4EC4 File Offset: 0x003B30C4
		// (set) Token: 0x06026E17 RID: 159255 RVA: 0x003B4ED8 File Offset: 0x003B30D8
		public unsafe string error_description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUError.__PropertyOffset_error_description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUError.__PropertyOffset_error_description)), value);
			}
		}

		// Token: 0x170095CA RID: 38346
		// (get) Token: 0x06026E18 RID: 159256 RVA: 0x003B4EED File Offset: 0x003B30ED
		// (set) Token: 0x06026E19 RID: 159257 RVA: 0x003B4F01 File Offset: 0x003B3101
		public unsafe string msg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUError.__PropertyOffset_msg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUError.__PropertyOffset_msg)), value);
			}
		}

		// Token: 0x06026E1A RID: 159258 RVA: 0x003B4F16 File Offset: 0x003B3116
		public FTUError()
		{
		}

		// Token: 0x06026E1B RID: 159259 RVA: 0x003B4F1E File Offset: 0x003B311E
		public FTUError(int code, string error_description, string msg)
		{
			this.code = code;
			this.error_description = error_description;
			this.msg = msg;
		}

		// Token: 0x06026E1C RID: 159260 RVA: 0x003B4F3B File Offset: 0x003B313B
		protected override IntPtr GetUStructPtr()
		{
			return FTUError.StaticStruct();
		}

		// Token: 0x06026E1D RID: 159261 RVA: 0x003B4F47 File Offset: 0x003B3147
		[NullableContext(2)]
		public FTUError(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E1E RID: 159262 RVA: 0x003B4F51 File Offset: 0x003B3151
		public FTUError(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E1F RID: 159263 RVA: 0x003B4F5C File Offset: 0x003B315C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTUError(Pointer, false, true);
		}

		// Token: 0x06026E20 RID: 159264 RVA: 0x003B4F66 File Offset: 0x003B3166
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTUError(Pointer, MemoryOwner);
		}

		// Token: 0x04015589 RID: 87433
		public const string __ObjectPath = "/Script/TapCommon.TUError";

		// Token: 0x0401558A RID: 87434
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401558B RID: 87435
		internal static int __PropertyOffset_code;

		// Token: 0x0401558C RID: 87436
		internal static int __PropertyOffset_error_description;

		// Token: 0x0401558D RID: 87437
		internal static int __PropertyOffset_msg;
	}
}
