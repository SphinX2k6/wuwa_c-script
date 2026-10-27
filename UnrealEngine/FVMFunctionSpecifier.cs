using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200260E RID: 9742
	[UnrealObjectPath("/Script/Niagara.VMFunctionSpecifier")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FVMFunctionSpecifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060243DE RID: 148446 RVA: 0x0035A90E File Offset: 0x00358B0E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVMFunctionSpecifier._ScriptStructPtr != 0) ? FVMFunctionSpecifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.VMFunctionSpecifier", ref FVMFunctionSpecifier._ScriptStructPtr);
		}

		// Token: 0x17008B98 RID: 35736
		// (get) Token: 0x060243DF RID: 148447 RVA: 0x0035A932 File Offset: 0x00358B32
		// (set) Token: 0x060243E0 RID: 148448 RVA: 0x0035A946 File Offset: 0x00358B46
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVMFunctionSpecifier.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVMFunctionSpecifier.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x17008B99 RID: 35737
		// (get) Token: 0x060243E1 RID: 148449 RVA: 0x0035A95B File Offset: 0x00358B5B
		// (set) Token: 0x060243E2 RID: 148450 RVA: 0x0035A96F File Offset: 0x00358B6F
		public unsafe FName Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVMFunctionSpecifier.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVMFunctionSpecifier.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060243E3 RID: 148451 RVA: 0x0035A984 File Offset: 0x00358B84
		public FVMFunctionSpecifier()
		{
		}

		// Token: 0x060243E4 RID: 148452 RVA: 0x0035A98C File Offset: 0x00358B8C
		public FVMFunctionSpecifier(FName Key, FName Value)
		{
			this.Key = Key;
			this.Value = Value;
		}

		// Token: 0x060243E5 RID: 148453 RVA: 0x0035A9A2 File Offset: 0x00358BA2
		protected override IntPtr GetUStructPtr()
		{
			return FVMFunctionSpecifier.StaticStruct();
		}

		// Token: 0x060243E6 RID: 148454 RVA: 0x0035A9AE File Offset: 0x00358BAE
		[NullableContext(2)]
		public FVMFunctionSpecifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243E7 RID: 148455 RVA: 0x0035A9B8 File Offset: 0x00358BB8
		public FVMFunctionSpecifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243E8 RID: 148456 RVA: 0x0035A9C3 File Offset: 0x00358BC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVMFunctionSpecifier(Pointer, false, true);
		}

		// Token: 0x060243E9 RID: 148457 RVA: 0x0035A9CD File Offset: 0x00358BCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVMFunctionSpecifier(Pointer, MemoryOwner);
		}

		// Token: 0x04013720 RID: 79648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.VMFunctionSpecifier";

		// Token: 0x04013721 RID: 79649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013722 RID: 79650
		internal static int __PropertyOffset_Key;

		// Token: 0x04013723 RID: 79651
		internal static int __PropertyOffset_Value;
	}
}
