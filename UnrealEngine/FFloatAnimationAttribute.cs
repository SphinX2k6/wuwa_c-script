using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD6 RID: 3030
	[UnrealObjectPath("/Script/Engine.FloatAnimationAttribute")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FFloatAnimationAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009502 RID: 38146 RVA: 0x000D49F5 File Offset: 0x000D2BF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatAnimationAttribute._ScriptStructPtr != 0) ? FFloatAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FloatAnimationAttribute", ref FFloatAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x06009503 RID: 38147 RVA: 0x000D4A19 File Offset: 0x000D2C19
		// (set) Token: 0x06009504 RID: 38148 RVA: 0x000D4A29 File Offset: 0x000D2C29
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFloatAnimationAttribute.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFloatAnimationAttribute.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x000D4A3A File Offset: 0x000D2C3A
		public FFloatAnimationAttribute()
		{
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x000D4A42 File Offset: 0x000D2C42
		public FFloatAnimationAttribute(float Value)
		{
			this.Value = Value;
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x000D4A51 File Offset: 0x000D2C51
		protected override IntPtr GetUStructPtr()
		{
			return FFloatAnimationAttribute.StaticStruct();
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x000D4A5D File Offset: 0x000D2C5D
		[NullableContext(2)]
		public FFloatAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x000D4A67 File Offset: 0x000D2C67
		public FFloatAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x000D4A72 File Offset: 0x000D2C72
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x000D4A7C File Offset: 0x000D2C7C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x040053A7 RID: 21415
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FloatAnimationAttribute";

		// Token: 0x040053A8 RID: 21416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053A9 RID: 21417
		internal static int __PropertyOffset_Value;
	}
}
