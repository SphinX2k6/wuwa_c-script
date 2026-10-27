using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B9 RID: 9657
	[UnrealObjectPath("/Script/Niagara.NiagaraMatrix")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraMatrix : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E33 RID: 146995 RVA: 0x00351121 File Offset: 0x0034F321
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraMatrix._ScriptStructPtr != 0) ? FNiagaraMatrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraMatrix", ref FNiagaraMatrix._ScriptStructPtr);
		}

		// Token: 0x170089FC RID: 35324
		// (get) Token: 0x06023E34 RID: 146996 RVA: 0x00351145 File Offset: 0x0034F345
		// (set) Token: 0x06023E35 RID: 146997 RVA: 0x00351159 File Offset: 0x0034F359
		public unsafe FVector4 Row0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row0) = value;
			}
		}

		// Token: 0x170089FD RID: 35325
		// (get) Token: 0x06023E36 RID: 146998 RVA: 0x0035116E File Offset: 0x0034F36E
		// (set) Token: 0x06023E37 RID: 146999 RVA: 0x00351182 File Offset: 0x0034F382
		public unsafe FVector4 Row1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row1) = value;
			}
		}

		// Token: 0x170089FE RID: 35326
		// (get) Token: 0x06023E38 RID: 147000 RVA: 0x00351197 File Offset: 0x0034F397
		// (set) Token: 0x06023E39 RID: 147001 RVA: 0x003511AB File Offset: 0x0034F3AB
		public unsafe FVector4 Row2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row2) = value;
			}
		}

		// Token: 0x170089FF RID: 35327
		// (get) Token: 0x06023E3A RID: 147002 RVA: 0x003511C0 File Offset: 0x0034F3C0
		// (set) Token: 0x06023E3B RID: 147003 RVA: 0x003511D4 File Offset: 0x0034F3D4
		public unsafe FVector4 Row3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMatrix.__PropertyOffset_Row3) = value;
			}
		}

		// Token: 0x06023E3C RID: 147004 RVA: 0x003511E9 File Offset: 0x0034F3E9
		public FNiagaraMatrix()
		{
		}

		// Token: 0x06023E3D RID: 147005 RVA: 0x003511F1 File Offset: 0x0034F3F1
		public FNiagaraMatrix(FVector4 Row0, FVector4 Row1, FVector4 Row2, FVector4 Row3)
		{
			this.Row0 = Row0;
			this.Row1 = Row1;
			this.Row2 = Row2;
			this.Row3 = Row3;
		}

		// Token: 0x06023E3E RID: 147006 RVA: 0x00351216 File Offset: 0x0034F416
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraMatrix.StaticStruct();
		}

		// Token: 0x06023E3F RID: 147007 RVA: 0x00351222 File Offset: 0x0034F422
		[NullableContext(2)]
		public FNiagaraMatrix(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E40 RID: 147008 RVA: 0x0035122C File Offset: 0x0034F42C
		public FNiagaraMatrix(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E41 RID: 147009 RVA: 0x00351237 File Offset: 0x0034F437
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraMatrix(Pointer, false, true);
		}

		// Token: 0x06023E42 RID: 147010 RVA: 0x00351241 File Offset: 0x0034F441
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraMatrix(Pointer, MemoryOwner);
		}

		// Token: 0x040133DE RID: 78814
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraMatrix";

		// Token: 0x040133DF RID: 78815
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040133E0 RID: 78816
		internal static int __PropertyOffset_Row0;

		// Token: 0x040133E1 RID: 78817
		internal static int __PropertyOffset_Row1;

		// Token: 0x040133E2 RID: 78818
		internal static int __PropertyOffset_Row2;

		// Token: 0x040133E3 RID: 78819
		internal static int __PropertyOffset_Row3;
	}
}
