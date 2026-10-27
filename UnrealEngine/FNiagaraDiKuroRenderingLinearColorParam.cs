using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C11 RID: 7185
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingLinearColorParam")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FNiagaraDiKuroRenderingLinearColorParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB81 RID: 113537 RVA: 0x0028CAF4 File Offset: 0x0028ACF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDiKuroRenderingLinearColorParam._ScriptStructPtr != 0) ? FNiagaraDiKuroRenderingLinearColorParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingLinearColorParam", ref FNiagaraDiKuroRenderingLinearColorParam._ScriptStructPtr);
		}

		// Token: 0x17006FC7 RID: 28615
		// (get) Token: 0x0601BB82 RID: 113538 RVA: 0x0028CB18 File Offset: 0x0028AD18
		// (set) Token: 0x0601BB83 RID: 113539 RVA: 0x0028CB2C File Offset: 0x0028AD2C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingLinearColorParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingLinearColorParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006FC8 RID: 28616
		// (get) Token: 0x0601BB84 RID: 113540 RVA: 0x0028CB41 File Offset: 0x0028AD41
		// (set) Token: 0x0601BB85 RID: 113541 RVA: 0x0028CB55 File Offset: 0x0028AD55
		public unsafe FLinearColor Val
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingLinearColorParam.__PropertyOffset_Val);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingLinearColorParam.__PropertyOffset_Val) = value;
			}
		}

		// Token: 0x0601BB86 RID: 113542 RVA: 0x0028CB6A File Offset: 0x0028AD6A
		public FNiagaraDiKuroRenderingLinearColorParam()
		{
		}

		// Token: 0x0601BB87 RID: 113543 RVA: 0x0028CB72 File Offset: 0x0028AD72
		public FNiagaraDiKuroRenderingLinearColorParam(FName Name, FLinearColor Val)
		{
			this.Name = Name;
			this.Val = Val;
		}

		// Token: 0x0601BB88 RID: 113544 RVA: 0x0028CB88 File Offset: 0x0028AD88
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDiKuroRenderingLinearColorParam.StaticStruct();
		}

		// Token: 0x0601BB89 RID: 113545 RVA: 0x0028CB94 File Offset: 0x0028AD94
		[NullableContext(2)]
		public FNiagaraDiKuroRenderingLinearColorParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB8A RID: 113546 RVA: 0x0028CB9E File Offset: 0x0028AD9E
		public FNiagaraDiKuroRenderingLinearColorParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB8B RID: 113547 RVA: 0x0028CBA9 File Offset: 0x0028ADA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDiKuroRenderingLinearColorParam(Pointer, false, true);
		}

		// Token: 0x0601BB8C RID: 113548 RVA: 0x0028CBB3 File Offset: 0x0028ADB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDiKuroRenderingLinearColorParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE7D RID: 61053
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingLinearColorParam";

		// Token: 0x0400EE7E RID: 61054
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE7F RID: 61055
		internal static int __PropertyOffset_Name;

		// Token: 0x0400EE80 RID: 61056
		internal static int __PropertyOffset_Val;
	}
}
