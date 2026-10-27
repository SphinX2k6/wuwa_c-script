using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C10 RID: 7184
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingFloatParam")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraDiKuroRenderingFloatParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB75 RID: 113525 RVA: 0x0028CA34 File Offset: 0x0028AC34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDiKuroRenderingFloatParam._ScriptStructPtr != 0) ? FNiagaraDiKuroRenderingFloatParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingFloatParam", ref FNiagaraDiKuroRenderingFloatParam._ScriptStructPtr);
		}

		// Token: 0x17006FC5 RID: 28613
		// (get) Token: 0x0601BB76 RID: 113526 RVA: 0x0028CA58 File Offset: 0x0028AC58
		// (set) Token: 0x0601BB77 RID: 113527 RVA: 0x0028CA6C File Offset: 0x0028AC6C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingFloatParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingFloatParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006FC6 RID: 28614
		// (get) Token: 0x0601BB78 RID: 113528 RVA: 0x0028CA81 File Offset: 0x0028AC81
		// (set) Token: 0x0601BB79 RID: 113529 RVA: 0x0028CA91 File Offset: 0x0028AC91
		public unsafe float Val
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingFloatParam.__PropertyOffset_Val);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingFloatParam.__PropertyOffset_Val) = value;
			}
		}

		// Token: 0x0601BB7A RID: 113530 RVA: 0x0028CAA2 File Offset: 0x0028ACA2
		public FNiagaraDiKuroRenderingFloatParam()
		{
		}

		// Token: 0x0601BB7B RID: 113531 RVA: 0x0028CAAA File Offset: 0x0028ACAA
		public FNiagaraDiKuroRenderingFloatParam(FName Name, float Val)
		{
			this.Name = Name;
			this.Val = Val;
		}

		// Token: 0x0601BB7C RID: 113532 RVA: 0x0028CAC0 File Offset: 0x0028ACC0
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDiKuroRenderingFloatParam.StaticStruct();
		}

		// Token: 0x0601BB7D RID: 113533 RVA: 0x0028CACC File Offset: 0x0028ACCC
		[NullableContext(2)]
		public FNiagaraDiKuroRenderingFloatParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB7E RID: 113534 RVA: 0x0028CAD6 File Offset: 0x0028ACD6
		public FNiagaraDiKuroRenderingFloatParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB7F RID: 113535 RVA: 0x0028CAE1 File Offset: 0x0028ACE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDiKuroRenderingFloatParam(Pointer, false, true);
		}

		// Token: 0x0601BB80 RID: 113536 RVA: 0x0028CAEB File Offset: 0x0028ACEB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDiKuroRenderingFloatParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE79 RID: 61049
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingFloatParam";

		// Token: 0x0400EE7A RID: 61050
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE7B RID: 61051
		internal static int __PropertyOffset_Name;

		// Token: 0x0400EE7C RID: 61052
		internal static int __PropertyOffset_Val;
	}
}
