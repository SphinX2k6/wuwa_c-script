using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C13 RID: 7187
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingVectorParam")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraDiKuroRenderingVectorParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB9B RID: 113563 RVA: 0x0028CD32 File Offset: 0x0028AF32
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDiKuroRenderingVectorParam._ScriptStructPtr != 0) ? FNiagaraDiKuroRenderingVectorParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingVectorParam", ref FNiagaraDiKuroRenderingVectorParam._ScriptStructPtr);
		}

		// Token: 0x17006FCC RID: 28620
		// (get) Token: 0x0601BB9C RID: 113564 RVA: 0x0028CD56 File Offset: 0x0028AF56
		// (set) Token: 0x0601BB9D RID: 113565 RVA: 0x0028CD6A File Offset: 0x0028AF6A
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingVectorParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingVectorParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006FCD RID: 28621
		// (get) Token: 0x0601BB9E RID: 113566 RVA: 0x0028CD7F File Offset: 0x0028AF7F
		// (set) Token: 0x0601BB9F RID: 113567 RVA: 0x0028CD93 File Offset: 0x0028AF93
		public unsafe FVector Val
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingVectorParam.__PropertyOffset_Val);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingVectorParam.__PropertyOffset_Val) = value;
			}
		}

		// Token: 0x0601BBA0 RID: 113568 RVA: 0x0028CDA8 File Offset: 0x0028AFA8
		public FNiagaraDiKuroRenderingVectorParam()
		{
		}

		// Token: 0x0601BBA1 RID: 113569 RVA: 0x0028CDB0 File Offset: 0x0028AFB0
		public FNiagaraDiKuroRenderingVectorParam(FName Name, FVector Val)
		{
			this.Name = Name;
			this.Val = Val;
		}

		// Token: 0x0601BBA2 RID: 113570 RVA: 0x0028CDC6 File Offset: 0x0028AFC6
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDiKuroRenderingVectorParam.StaticStruct();
		}

		// Token: 0x0601BBA3 RID: 113571 RVA: 0x0028CDD2 File Offset: 0x0028AFD2
		[NullableContext(2)]
		public FNiagaraDiKuroRenderingVectorParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBA4 RID: 113572 RVA: 0x0028CDDC File Offset: 0x0028AFDC
		public FNiagaraDiKuroRenderingVectorParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBA5 RID: 113573 RVA: 0x0028CDE7 File Offset: 0x0028AFE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDiKuroRenderingVectorParam(Pointer, false, true);
		}

		// Token: 0x0601BBA6 RID: 113574 RVA: 0x0028CDF1 File Offset: 0x0028AFF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDiKuroRenderingVectorParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE89 RID: 61065
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingVectorParam";

		// Token: 0x0400EE8A RID: 61066
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE8B RID: 61067
		internal static int __PropertyOffset_Name;

		// Token: 0x0400EE8C RID: 61068
		internal static int __PropertyOffset_Val;
	}
}
