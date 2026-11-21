using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021E RID: 542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAxisKeyMapping")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputAxisKeyMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060024BE RID: 9406 RVA: 0x00034EDC File Offset: 0x000330DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputAxisKeyMapping._ScriptStructPtr != 0) ? FInputAxisKeyMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputAxisKeyMapping", ref FInputAxisKeyMapping._ScriptStructPtr);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x00034F00 File Offset: 0x00033100
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00034F14 File Offset: 0x00033114
		public unsafe FName AxisName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_AxisName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_AxisName) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00034F29 File Offset: 0x00033129
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x00034F39 File Offset: 0x00033139
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00034F4C File Offset: 0x0003314C
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00034F8F File Offset: 0x0003318F
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00034FB0 File Offset: 0x000331B0
		public FInputAxisKeyMapping()
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00034FB8 File Offset: 0x000331B8
		protected override IntPtr GetUStructPtr()
		{
			return FInputAxisKeyMapping.StaticStruct();
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00034FC4 File Offset: 0x000331C4
		[NullableContext(2)]
		public FInputAxisKeyMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00034FCE File Offset: 0x000331CE
		public FInputAxisKeyMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00034FD9 File Offset: 0x000331D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputAxisKeyMapping(Pointer, false, true);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00034FE3 File Offset: 0x000331E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputAxisKeyMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04000DD4 RID: 3540
		public const string __ObjectPath = "/Script/Engine.InputAxisKeyMapping";

		// Token: 0x04000DD5 RID: 3541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DD6 RID: 3542
		internal static int __PropertyOffset_AxisName;

		// Token: 0x04000DD7 RID: 3543
		internal static int __PropertyOffset_Scale;

		// Token: 0x04000DD8 RID: 3544
		internal static int __PropertyOffset_Key;

		// Token: 0x04000DD9 RID: 3545
		[Nullable(2)]
		private FKey _Key;
	}
}
