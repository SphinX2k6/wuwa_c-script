using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C6C RID: 3180
	[UnrealObjectPath("/Script/Engine.IntegerAnimationAttribute")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FIntegerAnimationAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1CB RID: 41419 RVA: 0x000E5D30 File Offset: 0x000E3F30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntegerAnimationAttribute._ScriptStructPtr != 0) ? FIntegerAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.IntegerAnimationAttribute", ref FIntegerAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600A1CC RID: 41420 RVA: 0x000E5D54 File Offset: 0x000E3F54
		// (set) Token: 0x0600A1CD RID: 41421 RVA: 0x000E5D64 File Offset: 0x000E3F64
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegerAnimationAttribute.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegerAnimationAttribute.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x000E5D75 File Offset: 0x000E3F75
		public FIntegerAnimationAttribute()
		{
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x000E5D7D File Offset: 0x000E3F7D
		public FIntegerAnimationAttribute(int Value)
		{
			this.Value = Value;
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x000E5D8C File Offset: 0x000E3F8C
		protected override IntPtr GetUStructPtr()
		{
			return FIntegerAnimationAttribute.StaticStruct();
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x000E5D98 File Offset: 0x000E3F98
		[NullableContext(2)]
		public FIntegerAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x000E5DA2 File Offset: 0x000E3FA2
		public FIntegerAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x000E5DAD File Offset: 0x000E3FAD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIntegerAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x000E5DB7 File Offset: 0x000E3FB7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIntegerAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x040058D0 RID: 22736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.IntegerAnimationAttribute";

		// Token: 0x040058D1 RID: 22737
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058D2 RID: 22738
		internal static int __PropertyOffset_Value;
	}
}
