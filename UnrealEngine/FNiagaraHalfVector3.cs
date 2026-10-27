using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B0 RID: 9648
	[UnrealObjectPath("/Script/Niagara.NiagaraHalfVector3")]
	[UnrealStructLayout(6, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 6)]
	public class FNiagaraHalfVector3 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D75 RID: 146805 RVA: 0x00350094 File Offset: 0x0034E294
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraHalfVector3._ScriptStructPtr != 0) ? FNiagaraHalfVector3._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraHalfVector3", ref FNiagaraHalfVector3._ScriptStructPtr);
		}

		// Token: 0x170089BE RID: 35262
		// (get) Token: 0x06023D76 RID: 146806 RVA: 0x003500B8 File Offset: 0x0034E2B8
		// (set) Token: 0x06023D77 RID: 146807 RVA: 0x003500C8 File Offset: 0x0034E2C8
		public unsafe ushort x
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_x);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_x) = (short)value;
			}
		}

		// Token: 0x170089BF RID: 35263
		// (get) Token: 0x06023D78 RID: 146808 RVA: 0x003500D9 File Offset: 0x0034E2D9
		// (set) Token: 0x06023D79 RID: 146809 RVA: 0x003500E9 File Offset: 0x0034E2E9
		public unsafe ushort y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_y) = (short)value;
			}
		}

		// Token: 0x170089C0 RID: 35264
		// (get) Token: 0x06023D7A RID: 146810 RVA: 0x003500FA File Offset: 0x0034E2FA
		// (set) Token: 0x06023D7B RID: 146811 RVA: 0x0035010A File Offset: 0x0034E30A
		public unsafe ushort z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector3.__PropertyOffset_z) = (short)value;
			}
		}

		// Token: 0x06023D7C RID: 146812 RVA: 0x0035011B File Offset: 0x0034E31B
		public FNiagaraHalfVector3()
		{
		}

		// Token: 0x06023D7D RID: 146813 RVA: 0x00350123 File Offset: 0x0034E323
		public FNiagaraHalfVector3(ushort x, ushort y, ushort z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		// Token: 0x06023D7E RID: 146814 RVA: 0x00350140 File Offset: 0x0034E340
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraHalfVector3.StaticStruct();
		}

		// Token: 0x06023D7F RID: 146815 RVA: 0x0035014C File Offset: 0x0034E34C
		[NullableContext(2)]
		public FNiagaraHalfVector3(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D80 RID: 146816 RVA: 0x00350156 File Offset: 0x0034E356
		public FNiagaraHalfVector3(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D81 RID: 146817 RVA: 0x00350161 File Offset: 0x0034E361
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraHalfVector3(Pointer, false, true);
		}

		// Token: 0x06023D82 RID: 146818 RVA: 0x0035016B File Offset: 0x0034E36B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraHalfVector3(Pointer, MemoryOwner);
		}

		// Token: 0x04013379 RID: 78713
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraHalfVector3";

		// Token: 0x0401337A RID: 78714
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401337B RID: 78715
		internal static int __PropertyOffset_x;

		// Token: 0x0401337C RID: 78716
		internal static int __PropertyOffset_y;

		// Token: 0x0401337D RID: 78717
		internal static int __PropertyOffset_z;
	}
}
